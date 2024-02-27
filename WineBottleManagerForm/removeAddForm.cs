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
    public partial class removeAddForm : Form
    {
        //atributi
        private WineManager wineManager;

        //inizializzazione
        public removeAddForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
            PopulateText(wineManager.SelectedBottle);
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

        //metodi
        private void removeAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClearText()
        {
            nameTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            stockText.Text = string.Empty;
            cellarLocationTextBox.Text = string.Empty;
        }

        public void PopulateText(WineBottle wineBottle)
        {
            if (wineBottle == null)
                return;
            nameTextBox.Text = wineBottle.Name;
            yearTextBox.Text = wineBottle.Year.ToString();
            stockText.Text = wineBottle.Stock.ToString();
            cellarLocationTextBox.Text = wineBottle.CellarLocation;
        }

        private void btnToAnother_Click(object sender, EventArgs e)
        {
            ClearText();
            btnToCatalogue_Click(sender, e);
        }

        private void btnAddBottle_Click(object sender, EventArgs e)
        {
            WineBottle wineBottle = wineManager.SelectedBottle; 
            wineManager.addQuantity(wineBottle, int.Parse(lblQuantity.Text));
            wineBottle.Stock = wineBottle.Stock + int.Parse(lblQuantity.Text);
            ClearText();
            PopulateText(wineBottle);
        }
        private void btnRemoveBottle_Click(object sender, EventArgs e)
        {
            WineBottle wineBottle = wineManager.SelectedBottle;

            int quantity;
            if (!int.TryParse(lblQuantity.Text, out quantity) || quantity >= wineBottle.Stock)
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
                wineManager.removeQuantity(wineBottle, quantity);
                wineBottle.Stock = wineBottle.Stock - quantity;
                ClearText();
            }
        }
    }
}
