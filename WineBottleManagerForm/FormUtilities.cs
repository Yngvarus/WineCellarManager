using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCellarManager;

namespace WineBottleManagerForm
{
    internal static class FormUtilities
    {
        public static Form OpenForm(Form form, WineManager wineManager, Type type)
        {
            var openForms = Application.OpenForms;
            bool find = false;
            Form f = null;
            var l = form.Controls;
            var datagrid = form.Controls.OfType<SplitContainer>().FirstOrDefault().Controls[1].Controls.OfType<DataGridView>().FirstOrDefault();
            if (datagrid != null)
            {
                if (datagrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagrid.SelectedRows[0];
                    wineManager.SelectedBottle = (WineBottle)selectedRow.DataBoundItem;
                }
                
            }
            foreach (var item in openForms)
            {
                if (item.GetType().Equals(type))
                {
                    find = true;
                    f = item as Form;
                    break;
                }
            }
            if (find)
            {
                f.WindowState = FormWindowState.Normal; // Riporta il form già aperto alla vista
                f.Show(); // Porta il form già aperto in primo piano
            }
            else
            {
                f = Activator.CreateInstance(type, wineManager) as Form;
                f.Show();
            }

            form.Hide();
            return f;
        }
    }
}
