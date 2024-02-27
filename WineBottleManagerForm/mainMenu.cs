using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCellarManager;

namespace WineBottleManagerForm
{
    public partial class MainMenuForm : Form
    {
        //attributi
        private WineManager wineManager;

        //inizializzazione
        public MainMenuForm(WineManager wineManager)
        {
            this.wineManager = wineManager;
            InitializeComponent();
        }

        //bottoni sidebar
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

        //metodi
        public void PopulateLbl(WineBottle selectedWineBottle)
        {
            lblName.Text = selectedWineBottle.Name;
            String locYear = selectedWineBottle.Location + " " + selectedWineBottle.Year;
            lblLocYear.Text = locYear;
            lblVineyard.Text = selectedWineBottle.Vineyard;
            String notes = selectedWineBottle.Style + " - " + selectedWineBottle.TastingNotes;
            lblNote.Text = notes;
            String stockPos = "Quantità: " + selectedWineBottle.Stock + " - " + selectedWineBottle.CellarLocation;
            lblStockPos.Text = stockPos;
            String price = "Vendita: " + selectedWineBottle.SellingPrice + "€" + "/Acquisto: " + selectedWineBottle.BuyingPrice + "€";
            lblPrice.Text = price;
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
            f.PopulateWithSelectedBottle(wineManager.SelectedBottle);
        }

        private void btnCreate_Click(Object sender, EventArgs e)
        {
            ClearText();
            FormUtilities.OpenForm(this, wineManager, typeof(createForm));
        }

        private void addRemBottleBtn_Click(Object sender, EventArgs e)
        {
            ClearText();
            var f = FormUtilities.OpenForm(this, wineManager, typeof(removeAddForm)) as removeAddForm;
            f.PopulateText(wineManager.SelectedBottle);
        }

        private Type CallType()
        {
            return this.GetType();
        }
    }
}