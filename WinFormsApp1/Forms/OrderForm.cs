using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.DataBase;

namespace HouseCatalog.Forms
{

    public partial class OrderForm : Form
    {
        public int HouseId { get; set; }
        public OrderForm()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (txtTelephoneNumber.Text != "" && txtEmail.Text != "")
            {
                HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
                Orders order = new()
                {
                    TelephoneNumber = txtTelephoneNumber.Text,
                    Email = txtEmail.Text,
                    HouseId = HouseId
                };
                houseCatalogContext.Orders.Add(order);
                houseCatalogContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Укажите свои данные!");
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {


























































        }
    }
}
