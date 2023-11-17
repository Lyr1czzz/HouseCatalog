using HouseCatalog.Classes;
using HouseCatalog.UserContols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateInterface.UpdateItems(this);
            comboCity.SelectedItem = "Все города";
            comboSort.SelectedItem = "От низкой к высокой";
            if (CurrentUser.isAdmin == true)
            {
                btnAdd.Visible = true;
                btnOrders.Visible = true;
                btnItemes.Visible = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }


        private void btnSetFilter_Click(object sender, EventArgs e)
        {
            if (comboSort.SelectedIndex == 0)
            {
                UpdateInterface.UpdateItemsWithFilters(
                    this,
                    comboCity.SelectedItem.ToString(),
                    (double)numSquare1.Value,
                    (double)numSquare2.Value,
                    numPrice1.Value,
                    numPrice2.Value,
                    true
                );
            }
            else if (comboSort.SelectedIndex == 1)
            {
                UpdateInterface.UpdateItemsWithFilters(
                    this,
                    comboCity.SelectedItem.ToString(),
                    (double)numSquare1.Value,
                    (double)numSquare2.Value,
                    numPrice1.Value,
                    numPrice2.Value,
                    false
                );
            }
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            UpdateInterface.UpdateItemsWithoutFilters(this);
            comboCity.SelectedItem = "Все города";
            numPrice1.Value = 0;
            numPrice2.Value = 100000000;
            numSquare1.Value = 0;
            numSquare2.Value = 1000;
        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            UC_AddItem uC_AddItem = new UC_AddItem(this);
            pnlItemsList.Controls.Clear();
            pnlItemsList.Controls.Add(uC_AddItem);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UpdateInterface.UpdateItemsWithoutFilters(this);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            UpdateInterface.UpdateOrderList(this);
        }

        private void codeeloButton1_Click_1(object sender, EventArgs e)
        {
            UpdateInterface.UpdateItemsWithoutFilters(this);
        }
    }
}
