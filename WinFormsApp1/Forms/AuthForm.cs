using HouseCatalog.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using WinFormsApp1.DataBase;

namespace WinFormsApp1
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Pass.Text;

            try
            {
                HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
                var userExists = houseCatalogContext.Users
                    .FirstOrDefault(u => u.Username == login);
                if (userExists != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован!");
                    return;
                }
                if (Pass.Text != Repass.Text)
                {
                    MessageBox.Show("Вам не удалось повторить пароль!");
                    return;
                }

                DataBase.User newUser = new()
                {
                    Username = login,
                    Password = password
                };

                houseCatalogContext.Users.Add(newUser);
                houseCatalogContext.SaveChanges();

                MessageBox.Show("Пользователь успешно зарегистрирован!");
                ShowLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации пользователя: {ex.Message}");
            }
        }

        private void codeeloButton2_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Pass.Text;

            try
            {
                HouseCatalogContext houseCatalogContext = new HouseCatalogContext();
                var user = houseCatalogContext.Users
                    .FirstOrDefault(u => u.Username == login && u.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Неправильныйд логин или пароль!");
                    return;
                }
                if (Login.Text == "admin")
                {
                    CurrentUser.isAdmin = true;
                    MessageBox.Show("Вы входите как администратор");
                }

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}");
            }
        }

        private void ShowReg()
        {
            noacc_label.Visible = false;
            registr_label.Visible = true;
            Repass.Visible = true;
            auth_label.Visible = false;
            loginButton.Visible = false;
            registrButton.Visible = true;
            backlabel.Visible = true;
            Login.Text = "";
            Pass.Text = "";
            Repass.Text = "";
            Pass.UseSystemPasswordChar = false;
            Pass.PasswordChar = '\0';
            Repass.UseSystemPasswordChar = false;
            Repass.PasswordChar = '\0';

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowReg();
        }

        private void ShowLogin()
        {
            noacc_label.Visible = true;
            registr_label.Visible = false;
            Repass.Visible = false;
            auth_label.Visible = true;
            loginButton.Visible = true;
            registrButton.Visible = false;
            backlabel.Visible = false;
            Login.Text = "";
            Pass.Text = "";
            Repass.Text = "";
            Pass.UseSystemPasswordChar = true;
            Pass.PasswordChar = '*';
            Repass.UseSystemPasswordChar = true;
            Repass.PasswordChar = '*';
        }

        private void backlabel_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}