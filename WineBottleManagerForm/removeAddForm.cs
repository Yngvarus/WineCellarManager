using System;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class removeAddForm : Form
    {
        // Attributi
        private readonly WineManager wineManager;

        // Inizializzazione
        public removeAddForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
            PopulateText(wineManager.SelectedBottle);
        }

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

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(createForm));
        }

        // Metodo chiamato quando il form viene chiuso
        private void removeAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Pulisce i campi di testo
        private void ClearText()
        {
            nameTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            stockText.Text = string.Empty;
            cellarLocationTextBox.Text = string.Empty;
        }

        // Popola i campi di testo con i dati della bottiglia selezionata
        public void PopulateText(WineBottle wineBottle)
        {
            if (wineBottle == null)
                return;

            nameTextBox.Text = wineBottle.Name;
            yearTextBox.Text = wineBottle.Year.ToString();
            stockText.Text = wineBottle.Stock.ToString();
            cellarLocationTextBox.Text = wineBottle.CellarLocation;
        }

        // Pulisce i campi di testo e passa alla vista Catalogue
        private void btnToAnother_Click(object sender, EventArgs e)
        {
            ClearText();
            FormUtilities.OpenForm(this, wineManager, typeof(catalogueForm));
        }

        private void btnAddBottle_Click(object sender, EventArgs e)
        {
            WineBottle wineBottle = wineManager.SelectedBottle;
            int quantityToAdd;
            if (int.TryParse(lblQuantity.Text, out quantityToAdd))
            {
                int newStock = wineBottle.Stock + quantityToAdd;
                wineManager.UpdateWineBottleAttribute(wineBottle, "Stock", newStock);
                wineBottle.Stock = newStock;
                ClearText();
                PopulateText(wineBottle);
            }
        }


        private void btnRemoveBottle_Click(object sender, EventArgs e)
        {
            WineBottle wineBottle = wineManager.SelectedBottle;
            int quantityToRemove;
            if (int.TryParse(lblQuantity.Text, out quantityToRemove))
            {
                if (quantityToRemove >= wineBottle.Stock)
                {
                    DialogResult result = MessageBox.Show("La quantità selezionata è uguale o superiore a quella in magazzino, rimuovere la bottiglia?",
                                                          "Conferma Rimozione",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        wineManager.RemoveWineBottle(wineBottle);
                        ClearText();
                        PopulateText(wineBottle);
                    }
                }
                else
                {
                    int newStock = wineBottle.Stock - quantityToRemove;
                    wineManager.UpdateWineBottleAttribute(wineBottle, "Stock", newStock);
                    wineBottle.Stock = newStock;
                    ClearText();
                    PopulateText(wineBottle);
                }
            }
        }

    }
}
