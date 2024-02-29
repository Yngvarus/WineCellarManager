using System;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class createForm : Form
    {
        #region Fields
        // Attributi
        private readonly WineManager wineManager;
        #endregion

        #region Constructor
        // Inizializzazione
        public createForm(WineManager wineManager)
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm));
        }
        #endregion

        #region Methods
        // Metodo chiamato quando il form viene chiuso
        private void createForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        // Crea una nuova bottiglia e aggiungila al manager delle bottiglie
        private void btnCreateBottle_Click(object sender, EventArgs e)
        {
            WineBottle createdBottle = new WineBottle(
                nameTextBox.Text,
                vineyardTextBox.Text,
                locationTextBox.Text,
                int.Parse(yearTextBox.Text),
                styleTextBox.Text,
                cellarLocationTextBox.Text,
                int.Parse(stockTextBox.Text),
                decimal.Parse(sellingTextBox.Text),
                decimal.Parse(buyingTextBox.Text),
                tastingTextBox.Text
            );

            wineManager.AddWineBottle(createdBottle);
            wineManager.SelectedBottle = createdBottle;
            var f = FormUtilities.OpenForm(this, wineManager, typeof(MainMenuForm)) as MainMenuForm;
            f?.PopulateLbl(wineManager.SelectedBottle);
            ClearText();
        }
        #endregion
    }
}
