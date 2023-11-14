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
    public partial class UC_Item : UserControl
    {
        public UC_Item()
        {
            InitializeComponent();

        }

        public void SetText()
        {
            pictureBox1.Image = Image.FromFile(ImagePath);
            lblName.Text = ItemName;
            lblPrice.Text = Price.ToString();
            lblCountRooms.Text = CountRooms.ToString();
            lblCity.Text = City;
            lblStreet.Text = Street;
            lblArea.Text = Area;
        }

        private void btnOpenPage_Click(object sender, EventArgs e)
        {

        }

        public string ItemName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CountRooms { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
    }
}
