using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class shelfForm : Form
    {
        #region Fields
        // Attributi
        private readonly WineManager wineManager;
        private readonly List<string> currentFilters = new List<string>();
        #endregion

        #region Constructor
        // Inizializzazione
        public shelfForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
            SortShelfListBox(); // Ordina alfabeticamente la lista
            PopulateShelfListBox();
            shelfDataGrid.DataSource = wineManager.GetWineBottles();
            GenerateColumns();
        }
        #endregion

        #region Sidebar Buttons
        // Bottoni della barra laterale
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
        #endregion

        #region Methods
        // Metodo per gestire la chiusura del form
        private void shelfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Metodo chiamato quando il form diventa visibile
        private void shelfForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                shelfListBox.Items.Clear(); // Pulisce la lista prima di popolarla
                PopulateShelfListBox();
                shelfDataGrid.DataSource = wineManager.GetWineBottles();
            }
        }

        // Metodo per ordinare alfabeticamente la lista delle posizioni in cantina
        private void SortShelfListBox()
        {
            shelfListBox.Sorted = true;
        }

        // Metodo per generare le colonne della lista
        private void GenerateColumns()
        {
            foreach (DataGridViewColumn column in shelfDataGrid.Columns)
            {
                if (column.Name == "Location" || column.Name == "CellarLocation" || column.Name == "Stock" ||
                    column.Name == "SellingPrice" || column.Name == "BuyingPrice" || column.Name == "TastingNotes")
                    column.Visible = false;
                else
                    column.HeaderText = wineManager.propertyMap[column.Name];
            }
        }

        // Metodo per popolare la lista delle posizioni in cantina
        private void PopulateShelfListBox()
        {
            GenerateColumns();

            var uniqueCellarLocations = wineManager.GetWineBottles()
                                                    .Select(bottle => bottle.CellarLocation)
                                                    .Distinct()
                                                    .OrderBy(location => location) // Ordina alfabeticamente
                                                    .ToList();

            foreach (var location in uniqueCellarLocations)
                shelfListBox.Items.Add(location);
        }

        // Metodo chiamato quando cambia lo stato di selezione di un elemento nella lista delle posizioni in cantina
        private void shelfListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var selectedLocation = shelfListBox.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
                currentFilters.Add(selectedLocation);
            else if (e.NewValue == CheckState.Unchecked)
            {
                currentFilters.Remove(selectedLocation);
                if (shelfListBox.CheckedItems.Count - 1 == 0)
                {
                    shelfDataGrid.DataSource = wineManager.GetWineBottles();
                    return;
                }
            }

            shelfDataGrid.DataSource = null;

            var filteredBottles = wineManager.GetWineBottles()
                                        .Where(bottle => currentFilters.Contains(bottle.CellarLocation))
                                        .ToList();

            shelfDataGrid.DataSource = filteredBottles;
            GenerateColumns();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var mainMenuForm = FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm)) as MainMenuForm;
            mainMenuForm?.PopulateLbl(wineManager.SelectedBottle);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var modifyBottleForm = FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm)) as modifyBottleForm;
            modifyBottleForm?.PopulateWithSelectedBottle(wineManager.SelectedBottle);
        }
        #endregion
    }
}
