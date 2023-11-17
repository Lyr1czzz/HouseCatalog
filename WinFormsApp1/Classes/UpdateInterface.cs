using HouseCatalog.UserContols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;
using WinFormsApp1.DataBase;

namespace HouseCatalog.Classes
{
    static public class UpdateInterface
    {
        static public void Update()
        {

        }

        static public void UpdateItems(MainForm mainForm)
        {
            HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
            var items = houseCatalogContext.Houses.ToList();
            foreach (var item in items)
            {
                var deletePages = mainForm.Controls.Find("pg" + item.Name, true);
                foreach (var page in deletePages)
                {
                    if(page != null) mainForm.Controls.Remove(page);
                }
            }
            foreach ( var item in items )
            {
                UC_Item uC_Item = new UC_Item();
                uC_Item.ItemName = item.Name;
                uC_Item.Price = (decimal)item.Price;
                uC_Item.CountRooms = (int)item.Countrooms;
                uC_Item.City = item.Сity;
                uC_Item.Street = item.Street;
                uC_Item.Area = item.Area;
                uC_Item.ImagePath = item.Imagepath;
                uC_Item.SetText();
                mainForm.pnlItemsList.Controls.Add(uC_Item);
                uC_Item.Dock = DockStyle.Top;

                UC_ItemsPage uC_ItemsPage = new UC_ItemsPage(mainForm);
                uC_ItemsPage.HouseId = item.Id;
                uC_ItemsPage.ItemName = item.Name;
                uC_Item.Name = "pg" + item.Name;
                uC_ItemsPage.Price = (decimal)item.Price;
                uC_ItemsPage.CountRooms = (int)item.Countrooms;
                uC_ItemsPage.City = item.Сity;
                uC_ItemsPage.Street = item.Street;
                uC_ItemsPage.Area = item.Area;
                uC_ItemsPage.ImagePath = item.Imagepath;
                uC_ItemsPage.Square = (double)item.Square;
                uC_ItemsPage.Description = item.Description;
                uC_ItemsPage.Location = new Point(0, 0);
                uC_ItemsPage.SetText();

                mainForm.Controls.Add(uC_ItemsPage);

                uC_Item.btnOpenPage.Click += (object sender, EventArgs e) =>
                {
                    uC_ItemsPage.BringToFront();
                };
            }
        }

        static public void UpdateItemsWithFilters(MainForm mainForm, string city, double square1, double square2, decimal price1, decimal price2, bool sortBy)
        {
            HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
            List<House> items;
            if (sortBy)
            {
                items = houseCatalogContext.Houses
                    .Where(i => (city == "Все города" || i.Сity == city)
                             && (price1 == 0 || i.Price > price1)
                             && (price2 == 0 || i.Price < price2)
                             && (square1 == 0 || i.Square > square1)
                             && (square2 == 0 || i.Square < square2)
                             //&& (countRooms == 0 || i.Countrooms == countRooms)
                             ).OrderByDescending(i => i.Price).ToList();
            }
            else
            {
                items = houseCatalogContext.Houses
                .Where(i => (city == "Все города" || i.Сity == city)
                             && (price1 == 0 || i.Price > price1)
                             && (price2 == 0 || i.Price < price2)
                             && (square1 == 0 || i.Square > square1)
                             && (square2 == 0 || i.Square < square2)
                             //&& (countRooms == 0 || i.Countrooms == countRooms)
                             ).OrderBy(i => i.Price).ToList();
            }
            

            mainForm.pnlItemsList.Controls.Clear();

            foreach (var item in items)
            {
                var deletePages = mainForm.Controls.Find("pg" + item.Name, true);
                foreach (var page in deletePages)
                {
                    if (page != null) mainForm.Controls.Remove(page);
                }
            }

            foreach (var item in items)
            {
                UC_Item uC_Item = new UC_Item();
                uC_Item.ItemName = item.Name;
                uC_Item.Name = item.Name;
                uC_Item.Price = (decimal)item.Price;
                uC_Item.CountRooms = (int)item.Countrooms;
                uC_Item.City = item.Сity;
                uC_Item.Street = item.Street;
                uC_Item.Area = item.Area;
                uC_Item.ImagePath = item.Imagepath;
                uC_Item.SetText();
                mainForm.pnlItemsList.Controls.Add(uC_Item);
                uC_Item.Dock = DockStyle.Top;

                UC_ItemsPage uC_ItemsPage = new UC_ItemsPage(mainForm);
                uC_ItemsPage.HouseId = item.Id;
                uC_ItemsPage.ItemName = item.Name;
                uC_Item.Name = "pg" + item.Name;
                uC_ItemsPage.Price = (decimal)item.Price;
                uC_ItemsPage.CountRooms = (int)item.Countrooms;
                uC_ItemsPage.City = item.Сity;
                uC_ItemsPage.Street = item.Street;
                uC_ItemsPage.Area = item.Area;
                uC_ItemsPage.ImagePath = item.Imagepath;
                uC_ItemsPage.Square = (double)item.Square;
                uC_ItemsPage.Description = item.Description;
                uC_ItemsPage.Location = new Point(0, 0);
                uC_ItemsPage.SetText();

                mainForm.Controls.Add(uC_ItemsPage);

                uC_Item.btnOpenPage.Click += (object sender, EventArgs e) =>
                {
                    uC_ItemsPage.BringToFront();
                };
            }
        }

        static public void UpdateItemsWithoutFilters(MainForm mainForm)
        {
            HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
            var items = houseCatalogContext.Houses.ToList();
            mainForm.pnlItemsList.Controls.Clear();

            foreach (var item in items)
            {
                var deletePages = mainForm.Controls.Find("pg" + item.Name, true);
                foreach (var page in deletePages)
                {
                    if (page != null) mainForm.Controls.Remove(page);
                }
            }

            foreach (var item in items)
            {
                UC_Item uC_Item = new UC_Item();
                uC_Item.ItemName = item.Name;
                uC_Item.Price = (decimal)item.Price;
                uC_Item.CountRooms = (int)item.Countrooms;
                uC_Item.City = item.Сity;
                uC_Item.Street = item.Street;
                uC_Item.Area = item.Area;
                uC_Item.ImagePath = item.Imagepath;
                uC_Item.SetText();
                mainForm.pnlItemsList.Controls.Add(uC_Item);
                uC_Item.Dock = DockStyle.Top;

                UC_ItemsPage uC_ItemsPage = new UC_ItemsPage(mainForm);
                uC_ItemsPage.HouseId = item.Id;
                uC_ItemsPage.ItemName = item.Name;
                uC_Item.Name = "pg" + item.Name;
                uC_ItemsPage.Price = (decimal)item.Price;
                uC_ItemsPage.CountRooms = (int)item.Countrooms;
                uC_ItemsPage.City = item.Сity;
                uC_ItemsPage.Street = item.Street;
                uC_ItemsPage.Area = item.Area;
                uC_ItemsPage.ImagePath = item.Imagepath;
                uC_ItemsPage.Square = (double)item.Square;
                uC_ItemsPage.Description = item.Description;
                uC_ItemsPage.Location = new Point(0, 0);
                uC_ItemsPage.SetText();

                mainForm.Controls.Add(uC_ItemsPage);

                uC_Item.btnOpenPage.Click += (object sender, EventArgs e) =>
                {
                    uC_ItemsPage.BringToFront();
                };
            }
        }

        static public void UpdatePages()
        {

        }

        internal static void UpdateOrderList(MainForm mainForm)
        {
            HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
            var items = houseCatalogContext.Houses.ToList();
            mainForm.pnlItemsList.Controls.Clear();

            foreach (var item in items)
            {
                var deletePages = mainForm.Controls.Find("pg" + item.Name, true);
                foreach (var page in deletePages)
                {
                    if (page != null) mainForm.Controls.Remove(page);
                }
            }

            var orders = houseCatalogContext.Orders.ToList();
            foreach (var order in orders)
            {
                UC_OrderItem uC_OrderItem = new();
                uC_OrderItem.Id = order.Id;
                uC_OrderItem.HouseId = order.HouseId;
                uC_OrderItem.TelephoneNumber = order.TelephoneNumber;
                uC_OrderItem.Email = order.Email;
                uC_OrderItem.SetText();

                mainForm.pnlItemsList.Controls.Add(uC_OrderItem);
                uC_OrderItem.Dock = DockStyle.Top;
            }
        }
    }
}
