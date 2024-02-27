using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class modifyBottleForm : Form
    {
        //attributi
        private WineManager wineManager;

        //inizializzazione
        public modifyBottleForm(WineManager wineManager)
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
        private void btnCreate_Click(object sender, EventArgs e)
        {   
            FormUtilities.OpenForm(this, wineManager, typeof(createForm));
        }

        //metodi
        private void modifyBottleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        public void PopulateWithSelectedBottle(WineBottle wineBottle)
        {
            if(wineBottle == null)
                return;

            nameTextBox.Text = wineBottle.Name;
            vineyardTextBox.Text = wineBottle.Vineyard;
            locationTextBox.Text = wineBottle.Location;
            yearTextBox.Text = wineBottle.Year.ToString();
            styleTextBox.Text = wineBottle.Style;
            stockTextBox.Text = wineBottle.Stock.ToString();
            cellarLocationTextBox.Text = wineBottle.CellarLocation;
            buyingTextBox.Text = wineBottle.BuyingPrice.ToString() + " €";
            sellingTextBox.Text = wineBottle.SellingPrice.ToString() + " €";
            tastingTextBox.Text = wineBottle.TastingNotes;
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

        private void btnAnotherBottle_Click(object sender, EventArgs e)
        {
            this.ClearText();
            this.btnToCatalogue_Click(sender, e);
        }

        private void btnChangeBottle_Click(Object sender, EventArgs e)
        {
            WineBottle modifiedBottle = new WineBottle(nameTextBox.Text,
                                                       vineyardTextBox.Text,
                                                       locationTextBox.Text,
                                                       int.Parse(yearTextBox.Text),
                                                       styleTextBox.Text,
                                                       cellarLocationTextBox.Text,
                                                       int.Parse(stockTextBox.Text),
                                                       double.Parse(sellingTextBox.Text.Remove(sellingTextBox.Text.IndexOf("€"), 1)),
                                                       double.Parse(buyingTextBox.Text.Remove(buyingTextBox.Text.IndexOf("€"), 1)),
                                                       tastingTextBox.Text);

            // Controlla le differenze tra modifiedBottle e selectedBottle e applica le modifiche a selectedBottle
            UpdateModifiedAttributes(modifiedBottle, wineManager.SelectedBottle);
        }

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
    }
}
