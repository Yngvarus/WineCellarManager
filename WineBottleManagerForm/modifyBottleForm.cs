using System;
using System.Reflection;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class modifyBottleForm : Form
    {
        #region Fields
        // Attributi
        private readonly WineManager wineManager;
        #endregion

        #region Constructor
        // Inizializzazione
        public modifyBottleForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
        }
        #endregion

        #region Sidebar Buttons
        // Bottoni della barra laterale
        private void btnToMain_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm));
        }

        private void btnToShelf_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(shelfForm));
        }

        private void btnToCatalogue_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(catalogueForm));
        }

        private void btnAddRem_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(removeAddForm));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(createForm));
        }
        #endregion

        #region Methods
        // Metodo chiamato quando il form viene chiuso
        private void modifyBottleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Popola i campi di testo con i dati della bottiglia selezionata
        public void PopulateWithSelectedBottle(WineBottle wineBottle)
        {
            if (wineBottle == null)
                return;

            nameTextBox.Text = wineBottle.Name;
            vineyardTextBox.Text = wineBottle.Vineyard;
            locationTextBox.Text = wineBottle.Location;
            yearTextBox.Text = wineBottle.Year.ToString();
            styleTextBox.Text = wineBottle.Style;
            stockTextBox.Text = wineBottle.Stock.ToString();
            cellarLocationTextBox.Text = wineBottle.CellarLocation;
            buyingTextBox.Text = $"{wineBottle.BuyingPrice} €";
            sellingTextBox.Text = $"{wineBottle.SellingPrice} €";
            tastingTextBox.Text = wineBottle.TastingNotes;
        }

        // Pulisce i campi di testo
        public void ClearText()
        {
            nameTextBox.Text = string.Empty;
            vineyardTextBox.Text = string.Empty;
            locationTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            styleTextBox.Text = string.Empty;
            stockTextBox.Text = string.Empty;
            cellarLocationTextBox.Text = string.Empty;
            buyingTextBox.Text = "- €";
            sellingTextBox.Text = "- €";
            tastingTextBox.Text = string.Empty;
        }

        // Pulisce i campi di testo e passa alla vista Catalogue
        private void btnAnotherBottle_Click(object sender, EventArgs e)
        {
            ClearText();
            btnToCatalogue_Click(sender, e);
        }

        // Applica le modifiche alla bottiglia selezionata
        private void btnChangeBottle_Click(Object sender, EventArgs e)
        {
            WineBottle modifiedBottle = new WineBottle(
                nameTextBox.Text,
                vineyardTextBox.Text,
                locationTextBox.Text,
                int.Parse(yearTextBox.Text),
                styleTextBox.Text,
                cellarLocationTextBox.Text,
                int.Parse(stockTextBox.Text),
                decimal.Parse(sellingTextBox.Text.Replace("€", "").Trim()),
                decimal.Parse(buyingTextBox.Text.Replace("€", "").Trim()),
                tastingTextBox.Text
            );

            // Controlla le differenze tra modifiedBottle e selectedBottle e applica le modifiche a selectedBottle
            UpdateModifiedAttributes(modifiedBottle, wineManager.SelectedBottle);
            var f = FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm)) as MainMenuForm;
            f?.PopulateLbl(wineManager.SelectedBottle);
        }

        // Applica le modifiche alle proprietà modificate della bottiglia selezionata
        private void UpdateModifiedAttributes(WineBottle modifiedBottle, WineBottle selectedBottle)
        {
            // Ottieni le proprietà di WineBottle utilizzando reflection
            PropertyInfo[] properties = typeof(WineBottle).GetProperties();

            foreach (var property in properties)
            {
                // Ottieni il nome della proprietà
                string propertyName = property.Name;

                // Ottieni il valore della proprietà da modifiedBottle e selectedBottle
                object modifiedValue = property.GetValue(modifiedBottle);
                object selectedValue = property.GetValue(selectedBottle);

                // Controlla se il valore della proprietà è stato modificato
                if (!Equals(modifiedValue, selectedValue))
                {
                    // Applica la modifica alla bottiglia selezionata
                    wineManager.UpdateWineBottleAttribute(selectedBottle, propertyName, modifiedValue);
                }
            }
        }
        #endregion
    }
}
