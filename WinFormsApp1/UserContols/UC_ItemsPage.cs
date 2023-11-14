using HouseCatalog.Forms;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseCatalog.UserContols
{
    public partial class UC_ItemsPage : UserControl
    {
        public UC_ItemsPage()
        {
            InitializeComponent();
        }
        public int HouseId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CountRooms { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Description { get; set; }
        public double Square { get; set; }
        public string ImagePath { get; set; } = string.Empty;

        public void SetText()
        {
            pictureBox1.Image = Image.FromFile(ImagePath);
            lblName.Text = ItemName;
            lblPrice.Text = Price.ToString();
            lblCountRooms.Text = CountRooms.ToString();
            lblCity.Text = City;
            lblStreet.Text = Street;
            lblArea.Text = Area;
            lblDescription.Text = Description;
            lblSquare.Text = Square.ToString();
        }

        private void UC_ItemsPage_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.HouseId = HouseId;
            orderForm.Show();
        }
    }
}
