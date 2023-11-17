using HouseCatalog.Classes;
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
using WinFormsApp1;
using WinFormsApp1.DataBase;

namespace HouseCatalog.UserContols
{
    public partial class UC_ItemsPage : UserControl
    {
        public MainForm mainForm;

        public UC_ItemsPage(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            if (CurrentUser.isAdmin == true)
            {
                btnDelete.Visible = true;
                btnSaveChanges.Visible = true;

                //Активация textbox
                txtName.Visible = true;
                txtSquare.Visible = true;
                txtStreet.Visible = true;
                txtCity.Visible = true;
                txtCountrooms.Visible = true;
                txtArea.Visible = true;
                txtDescription.Visible = true;
                txtPrice.Visible = true;

                //Выключаем лабелы
                lblArea.Visible = false;
                lblDescription.Visible = false;
                lblPrice.Visible = false;
                lblCity.Visible = false;
                lblCountRooms.Visible = false;
                lblName.Visible = false;
                lblStreet.Visible = false;
                lblPrice.Visible = false;

            }
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
            if (CurrentUser.isAdmin == true)
            {
                pictureBox1.Image = Image.FromFile(ImagePath);
                txtName.Text = ItemName;
                txtPrice.Text = Price.ToString();
                txtCountrooms.Text = CountRooms.ToString();
                txtCity.Text = City;
                txtStreet.Text = Street;
                txtArea.Text = Area;
                txtDescription.Text = Description;
                txtSquare.Text = Square.ToString();
            }
            else
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

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
            House item = houseCatalogContext.Houses.FirstOrDefault(h => h.Id == HouseId);
            houseCatalogContext.Houses.Remove(item);
            houseCatalogContext.SaveChanges();
            UpdateInterface.UpdateItemsWithoutFilters(mainForm);
            this.SendToBack();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
                House item = houseCatalogContext.Houses.FirstOrDefault(h => h.Id == HouseId);
                item.Name = txtName.Text;
                item.Area = txtArea.Text;
                item.Description = txtDescription.Text;
                item.Price = decimal.Parse(txtPrice.Text);
                item.Street = txtStreet.Text;
                item.Square = double.Parse(txtSquare.Text);
                item.Countrooms = int.Parse(txtCountrooms.Text);
                item.Сity = txtCity.Text;

                houseCatalogContext.SaveChanges();
                UpdateInterface.UpdateItemsWithoutFilters(mainForm);
                this.SendToBack();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения!");
            }
        }
    }
}
