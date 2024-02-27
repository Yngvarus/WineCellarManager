using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using WineCellarManager;
using SqlSortOrder = Microsoft.Data.SqlClient.SortOrder; 

namespace WineBottleManagerForm
{
    public partial class catalogueForm : Form
    {
        //attributi
        private WineManager wineManager;

        //inizializzazione
        public catalogueForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
            catalogueDataGrid.DataSource = wineManager.GetWineBottles();
            GenerateColGrid();
            PopulateVisualCheckedListBox();
            PopulatePropertyComboBox();
            int index = deCreListBox.FindStringExact("Crescente");
            if (index != ListBox.NoMatches)
                deCreListBox.SetItemChecked(index, true);
        }

        //bottoni sidebar
        private void btnToMain_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm));
        }

        private void btnToShelf_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(shelfForm));
        }

        private void btnToModify_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm));
        }

        //metodi
        private void catalogueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cataloguefForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Aggiorna la sorgente dati della griglia quando il form diventa visibile
                catalogueDataGrid.DataSource = wineManager.GetWineBottles();
            }
        }

        private void PopulateVisualCheckedListBox()
        {
            foreach (var property in wineManager.propertyMap.Values)
            {
                if (property == "Posizione in magazzino" || property == "Annotazioni")
                {
                    continue;
                }

                visualCheckedListBox.Items.Add(property);
                int n = visualCheckedListBox.Items.IndexOf(property);
                visualCheckedListBox.SetItemChecked(n, true);
            }
        }

        private void PopulatePropertyComboBox()
        {
            propertyComboBox.Items.Add("Nessun filtro");
            foreach (var property in wineManager.propertyMap.Values)
            {
                if (property == "Posizione in magazzino" || property == "Annotazioni")
                {
                    continue;
                }

                propertyComboBox.Items.Add(property);
            }
            propertyComboBox.Text = "Nessun filtro";
        }

        private void GenerateColGrid()
        {

            catalogueDataGrid.Columns["cellarLocation"].Visible = false;
            catalogueDataGrid.Columns["tastingNotes"].Visible = false;
            var uncheck = visualCheckedListBox.Items
                    .Cast<String>()
                    .Where(item => !visualCheckedListBox.CheckedItems.Contains(item))
                    .ToList();
            foreach (String u in uncheck)
            {
                catalogueDataGrid.Columns[wineManager.propertyMap[char.ToUpper(u[0]) + u.Substring(1)]].Visible = false;
            }
            foreach (DataGridViewColumn column in catalogueDataGrid.Columns)
            {
                // Traduci il nome della colonna
                column.HeaderText = wineManager.propertyMap[column.Name];
            }
        }

        private void visualCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string deselection = visualCheckedListBox.Items[e.Index].ToString();
            // Verifica se l'evento è stato causato da un cambio di stato di selezione
            if (e.NewValue == CheckState.Unchecked)
            {
                // Aggiungi il nuovo filtro solo se la crocetta è stata appena deselezionata
                catalogueDataGrid.Columns[wineManager.propertyMap.FirstOrDefault(x => x.Value == char.ToUpper(deselection[0]) + deselection.Substring(1)).Key].Visible = false;
            }
            else if (e.NewValue == CheckState.Checked)
            {
                // Rimuovi il filtro corrispondente alla crocetta selezionata
                catalogueDataGrid.Columns[wineManager.propertyMap.FirstOrDefault(x => x.Value == char.ToUpper(deselection[0]) + deselection.Substring(1)).Key].Visible = true;
                if (visualCheckedListBox.CheckedItems.Count - 1 == 0)
                {
                    // Se non ci sono crocette selezionate, mostra tutti i dati
                    catalogueDataGrid.DataSource = wineManager.GetWineBottles();
                    return; // Esci dalla funzione dopo aver mostrato tutti i dati
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var f = FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm)) as MainMenuForm;
            f.PopulateLbl(wineManager.SelectedBottle);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var f = FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm)) as modifyBottleForm;
            f.PopulateWithSelectedBottle(wineManager.SelectedBottle);
        }

        private void SortGrid(SqlSortOrder sortOrder)
        {
            string propertyName = (string)propertyComboBox.SelectedItem;

            // Applica l'ordinamento
            if (propertyComboBox.SelectedItem != null || propertyName != "Nessun filtro")
            {
                wineManager.SortWineBottles(propertyName, sortOrder);
            }
            else
            {
                // Se non è stato selezionato alcun filtro di proprietà, ordina per nome
                wineManager.SortWineBottles("Name", sortOrder);
            }

            // Verifica se è stato selezionato un filtro di proprietà
            if (!string.IsNullOrWhiteSpace(propertyName) && propertyName != "Nessun filtro")
            {
                // Applica il filtro
                string searchTerm = keyWordTextBox.Text;
                catalogueDataGrid.DataSource = wineManager.FilterWineBottles(propertyName, searchTerm);
            }
            else
            {
                // Se non è stato selezionato alcun filtro, mostra tutti i dati
                catalogueDataGrid.DataSource = wineManager.GetWineBottles();
            }
            GenerateColGrid();
            catalogueDataGrid.Refresh();
        }


        private void SortGridAscending()
        {
            SqlSortOrder sortOrder = SqlSortOrder.Ascending;
            SortGrid(sortOrder);
        }

        private void SortGridDescending()
        {
            SqlSortOrder sortOrder = SqlSortOrder.Descending;
            SortGrid(sortOrder);
        }

        private void btnToScan_Click(object sender, EventArgs e)
        {
            string propertyName = (string)propertyComboBox.SelectedItem;
            string searchTerm = keyWordTextBox.Text;

            // Verifica se SelectedItem e Text non sono nulli o vuoti
            if (!string.IsNullOrWhiteSpace(propertyName) && !string.IsNullOrWhiteSpace(searchTerm))
            {
                catalogueDataGrid.DataSource = null;
                catalogueDataGrid.DataSource = wineManager.FilterWineBottles(propertyName, searchTerm);
                GenerateColGrid();
                SqlSortOrder sortOrder = deCreListBox.GetItemChecked(0) ? SqlSortOrder.Ascending : SqlSortOrder.Descending;
                SortGrid(sortOrder);
            }
            else
            {
                // Se SelectedItem o Text sono nulli o vuoti, applica "Crescente" o "Decrescente"
                SqlSortOrder sortOrder = deCreListBox.GetItemChecked(0) ? SqlSortOrder.Ascending : SqlSortOrder.Descending;
                SortGrid(sortOrder);
            }
        }

        private void deCreListBox_SelectedValueChanged(object sender, EventArgs e)
        {
  

            // Ottieni l'elemento attualmente selezionato
            string selectedValue = deCreListBox.SelectedItem as string;

            // Verifica se un elemento è stato selezionato
            if (selectedValue != null)
            {
                // Deseleziona l'altro elemento
                if (selectedValue == "Crescente")
                {
                    deCreListBox.SetItemChecked(1, false); // Decrescente
                }
                else if (selectedValue == "Decrescente")
                {
                    deCreListBox.SetItemChecked(0, false); // Crescente
                }

                // Ottieni lo stato di ordinamento corrente
                SqlSortOrder sortOrder = selectedValue == "Crescente" ? SqlSortOrder.Ascending : SqlSortOrder.Descending;
                // Applica l'ordinamento
                SortGrid(sortOrder);
            }
            else if (deCreListBox.SelectedItems.Count == 0)
            {
                // Se nessun elemento è selezionato, reimposta l'ordinamento predefinito
                SortGrid(SqlSortOrder.Ascending);
            }
          // Seleziona il default se non ci sono elementi checked
            if (deCreListBox.CheckedItems.Count == 0)
            {
                int index = deCreListBox.FindStringExact("Crescente");
                if (index != ListBox.NoMatches)
                    deCreListBox.SetItemChecked(index, true);
            }
            
        }
    }
}
