namespace HouseCatalog.UserContols
{
    partial class UC_AddItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            btnClose = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtCountRooms = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtCity = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtStreet = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtArea = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtSquare = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtDescription = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            btnCreate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnAddPicture = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderRadius = 20;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(32, 82);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "Название";
            txtName.SelectedText = "";
            txtName.Size = new Size(762, 49);
            txtName.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 20;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(32, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(108, 46);
            btnClose.TabIndex = 1;
            btnClose.Text = "закрыть";
            btnClose.Click += siticoneButton1_Click;
            // 
            // txtPrice
            // 
            txtPrice.BorderRadius = 20;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(33, 152);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "цена";
            txtPrice.SelectedText = "";
            txtPrice.Size = new Size(382, 49);
            txtPrice.TabIndex = 2;
            // 
            // txtCountRooms
            // 
            txtCountRooms.BorderRadius = 20;
            txtCountRooms.DefaultText = "";
            txtCountRooms.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCountRooms.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCountRooms.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCountRooms.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCountRooms.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCountRooms.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountRooms.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCountRooms.Location = new Point(33, 228);
            txtCountRooms.Margin = new Padding(3, 4, 3, 4);
            txtCountRooms.Name = "txtCountRooms";
            txtCountRooms.PasswordChar = '\0';
            txtCountRooms.PlaceholderText = "Кол-во комнат";
            txtCountRooms.SelectedText = "";
            txtCountRooms.Size = new Size(382, 49);
            txtCountRooms.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.BorderRadius = 20;
            txtCity.DefaultText = "";
            txtCity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCity.Location = new Point(33, 305);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.PlaceholderText = "Город";
            txtCity.SelectedText = "";
            txtCity.Size = new Size(382, 49);
            txtCity.TabIndex = 4;
            // 
            // txtStreet
            // 
            txtStreet.BorderRadius = 20;
            txtStreet.DefaultText = "";
            txtStreet.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStreet.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStreet.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStreet.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStreet.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStreet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreet.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStreet.Location = new Point(33, 458);
            txtStreet.Margin = new Padding(3, 4, 3, 4);
            txtStreet.Name = "txtStreet";
            txtStreet.PasswordChar = '\0';
            txtStreet.PlaceholderText = "Адрес";
            txtStreet.SelectedText = "";
            txtStreet.Size = new Size(382, 49);
            txtStreet.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.BorderRadius = 20;
            txtArea.DefaultText = "";
            txtArea.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtArea.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtArea.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtArea.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtArea.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtArea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtArea.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtArea.Location = new Point(32, 381);
            txtArea.Margin = new Padding(3, 4, 3, 4);
            txtArea.Name = "txtArea";
            txtArea.PasswordChar = '\0';
            txtArea.PlaceholderText = "Район";
            txtArea.SelectedText = "";
            txtArea.Size = new Size(382, 49);
            txtArea.TabIndex = 6;
            // 
            // txtSquare
            // 
            txtSquare.BorderRadius = 20;
            txtSquare.DefaultText = "";
            txtSquare.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSquare.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSquare.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSquare.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSquare.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSquare.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSquare.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSquare.Location = new Point(32, 536);
            txtSquare.Margin = new Padding(3, 4, 3, 4);
            txtSquare.Name = "txtSquare";
            txtSquare.PasswordChar = '\0';
            txtSquare.PlaceholderText = "Площадь";
            txtSquare.SelectedText = "";
            txtSquare.Size = new Size(382, 49);
            txtSquare.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.BorderRadius = 20;
            txtDescription.DefaultText = "";
            txtDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Location = new Point(456, 152);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderText = "Описание";
            txtDescription.SelectedText = "";
            txtDescription.Size = new Size(338, 433);
            txtDescription.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.BorderRadius = 20;
            btnCreate.DisabledState.BorderColor = Color.DarkGray;
            btnCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(839, 461);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(210, 124);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Создать";
            btnCreate.Click += siticoneButton2_Click;
            // 
            // btnAddPicture
            // 
            btnAddPicture.BorderRadius = 20;
            btnAddPicture.DisabledState.BorderColor = Color.DarkGray;
            btnAddPicture.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddPicture.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddPicture.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddPicture.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPicture.ForeColor = Color.White;
            btnAddPicture.Location = new Point(839, 82);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(210, 49);
            btnAddPicture.TabIndex = 10;
            btnAddPicture.Text = "Прикрепить картинку";
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // UC_AddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddPicture);
            Controls.Add(btnCreate);
            Controls.Add(txtDescription);
            Controls.Add(txtSquare);
            Controls.Add(txtArea);
            Controls.Add(txtStreet);
            Controls.Add(txtCity);
            Controls.Add(txtCountRooms);
            Controls.Add(txtPrice);
            Controls.Add(btnClose);
            Controls.Add(txtName);
            Name = "UC_AddItem";
            Size = new Size(1076, 630);
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClose;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCountRooms;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCity;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtStreet;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtArea;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSquare;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDescription;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCreate;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddPicture;
    }
}
