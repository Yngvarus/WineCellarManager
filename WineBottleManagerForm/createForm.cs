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
    
    public partial class createForm : Form
    {
        //attributi
        private WineManager wineManager;

        //inizializzazione
        public createForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
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
        private void btnAddRem_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(removeAddForm));
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenForm(this, wineManager, typeof(modifyBottleForm));
        }

        //metodi
        private void createForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

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

        private void btnCreateBottle_Click(object sender, EventArgs e)
        {
            WineBottle createdB = new WineBottle(nameTextBox.Text.ToString(), vineyardTextBox.Text.ToString(), locationTextBox.Text.ToString(), int.Parse(yearTextBox.Text), styleTextBox.Text.ToString(), cellarLocationTextBox.Text.ToString(), int.Parse(stockTextBox.Text), double.Parse(sellingTextBox.Text.ToString()), double.Parse(buyingTextBox.Text.ToString()), tastingTextBox.Text.ToString());
            wineManager.AddWineBottle(createdB);
            wineManager.SelectedBottle = createdB;
            btnToMain_Click(sender, e);
            ClearText();
        }
    }
}
