using System;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class MainMenuForm : Form
    {
        #region Fields
        // Attributi
        private readonly WineManager wineManager;
        private bool firstLoad = true; // Flag per tracciare il primo caricamento del form
        #endregion

        #region Constructor
        // Inizializzazione
        public MainMenuForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
        }
        #endregion

        #region Sidebar Buttons
        // Bottoni della barra laterale
        private void btnToShelf_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(shelfForm));
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
        // Metodo chiamato quando il form diventa visibile
        private void MainMenuForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Popola le etichette solo se non è il primo caricamento dell'applicazione
                if (!firstLoad)
                    PopulateLbl(wineManager.SelectedBottle);
                else
                    firstLoad = false;
            }
        }

        // Metodo per popolare le etichette con i dettagli della bottiglia selezionata
        public void PopulateLbl(WineBottle selectedWineBottle)
        {
            if (selectedWineBottle != null)
            {
                lblName.Text = selectedWineBottle.Name;
                string locYear = $"{selectedWineBottle.Location} {selectedWineBottle.Year}";
                lblLocYear.Text = locYear;
                lblVineyard.Text = selectedWineBottle.Vineyard;
                string notes = $"{selectedWineBottle.Style} - {selectedWineBottle.TastingNotes}";
                lblNote.Text = notes;
                string stockPos = $"Quantità: {selectedWineBottle.Stock} - {selectedWineBottle.CellarLocation}";
                lblStockPos.Text = stockPos;
                string price = $"Vendita: {selectedWineBottle.SellingPrice}€ / Acquisto: {selectedWineBottle.BuyingPrice}€";
                lblPrice.Text = price;
            }
            else
            {
                ClearText(); // Se non è stata selezionata alcuna bottiglia, pulisci le etichette
            }
        }

        private void ClearText()
        {
            lblName.Text = "Bottiglia selezionata";
            lblVineyard.Text = "Vigneto";
            lblLocYear.Text = "Locazione geografica, anno";
            lblNote.Text = "Note: Stile, ...";
            lblStockPos.Text = "Quantità e Posizione";
            lblPrice.Text = "Prezzo Acquisto/Vendita";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ClearText();
            btnToCatalogue_Click(sender, e);
        }

        private void modifyBottleBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            var f = FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm)) as modifyBottleForm;
            f?.PopulateWithSelectedBottle(wineManager.SelectedBottle);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearText();
            FormUtilities.OpenForm(this, wineManager, typeof(createForm));
        }

        private void addRemBottleBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            var f = FormUtilities.OpenForm(this, wineManager, typeof(removeAddForm)) as removeAddForm;
            f?.PopulateText(wineManager.SelectedBottle);
        }

        private Type CallType() => GetType();

        private void MainMenufForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Aggiorna la sorgente dati delle labels quando il form diventa visibile
                this.PopulateLbl(wineManager.SelectedBottle);
            }
        }
        #endregion
    }
}
