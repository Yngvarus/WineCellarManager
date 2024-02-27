using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class shelfForm : Form
    {
        //attributi
        private WineManager wineManager;
        private List<String> currentFilters = new List<String>();

        //inizializzazione
        public shelfForm(WineManager wineManager)
        {
            //database manager creato nel main passato 
            this.wineManager = wineManager;
            //inizializzazione componenti form
            InitializeComponent();
            //gestione tablella
            shelfDataGrid.DataSource = wineManager.GetWineBottles();
            PopulateShelfListBox();

        }

        //bottoni sidebar
        private void btnToMain_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm));
        }

        private void btnToCatalogue_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(catalogueForm));
        }

        private void btnToModify_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm));
        }

        //metodi
        private void shelfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void shelfForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Aggiorna la sorgente dati della griglia quando il form diventa visibile
                shelfDataGrid.DataSource = wineManager.GetWineBottles();
            }
        }

        private void generateColListBox()
        {
            //gestione tabella
            shelfDataGrid.Columns["location"].Visible = false;
            shelfDataGrid.Columns["cellarLocation"].Visible = false;
            shelfDataGrid.Columns["stock"].Visible = false;
            shelfDataGrid.Columns["sellingPrice"].Visible = false;
            shelfDataGrid.Columns["buyingPrice"].Visible = false;
            shelfDataGrid.Columns["tastingNotes"].Visible = false;
            foreach (DataGridViewColumn column in shelfDataGrid.Columns)
            {
                    // Traduci il nome della colonna
                    column.HeaderText = wineManager.propertyMap[column.Name];
            }
        }
        private void PopulateShelfListBox()
        {
            //formatta le colonne
            generateColListBox();
            // Ottieni tutti i valori univoci di cellarLocation dalla sorgente dati
            List<string> uniqueCellarLocations = wineManager.GetWineBottles()
                                                    .Select(bottle => bottle.CellarLocation)
                                                    .Distinct()
                                                    .ToList();

            // Aggiungi i valori univoci come membri a shelfListBox
            foreach (string location in uniqueCellarLocations)
            {
                shelfListBox.Items.Add(location);
            }
        }


        private void shelfListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedLocation = shelfListBox.Items[e.Index].ToString();

            // Verifica se l'evento è stato causato da un cambio di stato di selezione
            if (e.NewValue == CheckState.Checked)
            {
                // Aggiungi il nuovo filtro solo se la crocetta è stata appena selezionata
                currentFilters.Add(selectedLocation);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Rimuovi il filtro corrispondente alla crocetta deselezionata
                currentFilters.Remove(selectedLocation);
                // Verifica se non ci sono crocette selezionate
                if (shelfListBox.CheckedItems.Count - 1 == 0)
                {
                    // Se non ci sono crocette selezionate, mostra tutti i dati
                    shelfDataGrid.DataSource = wineManager.GetWineBottles();
                    return; // Esci dalla funzione dopo aver mostrato tutti i dati
                }
            }

            // Rimuovi filtri precedenti
            shelfDataGrid.DataSource = null;

            // Filtra le bottiglie basate sui valori selezionati
            var filteredBottles = wineManager.GetWineBottles()
                                        .Where(bottle => currentFilters.Contains(bottle.CellarLocation))
                                        .ToList();

            // Aggiorna la shelfDataGrid con i filtri correnti
            shelfDataGrid.DataSource = filteredBottles;
            generateColListBox();
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

        
    }
}
