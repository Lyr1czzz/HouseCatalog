using HouseCatalog.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HouseCatalog.UserContols
{
    public partial class UC_AddItem : UserControl
    {
        public string picturePath { get; set; }
        MainForm mainForm;
        public UC_AddItem(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            mainForm.pnlItemsList.Controls.Remove(this);
            UpdateInterface.UpdateItemsWithoutFilters(mainForm);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtName.Text == string.Empty
                    && txtPrice.Text == string.Empty
                    && txtCountRooms.Text == string.Empty
                    && txtCity.Text == string.Empty
                    && txtStreet.Text == string.Empty
                    && txtArea.Text == string.Empty
                    && txtSquare.Text == string.Empty
                    && txtDescription.Text == string.Empty
                    ) 
                {
                    MessageBox.Show("Заполните все поля!");
                }
                HouseCatalogContext _db = new HouseCatalogContext();
                House house = new()
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Countrooms = int.Parse(txtCountRooms.Text),
                    Сity = txtCity.Text,
                    Street = txtStreet.Text,
                    Area = txtArea.Text,
                    Square = double.Parse(txtSquare.Text),
                    Description = txtDescription.Text,
                    Imagepath = picturePath,
                };
                _db.Houses.Add(house);
                _db.SaveChanges();
                MessageBox.Show("Обьявление успешно создано!");
                this.Visible = false;
                UpdateInterface.UpdateItemsWithoutFilters(mainForm);
            }
            catch
            {
                MessageBox.Show("Ошибка создания");
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                // openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg, *.jpeg, *.png";
                openFileDialog.Title = "Выберите изоюражения";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImage = openFileDialog.FileName;
                    picturePath = selectedImage.Replace("\\", "\\\\");
                }
            }
        }
    }
}
