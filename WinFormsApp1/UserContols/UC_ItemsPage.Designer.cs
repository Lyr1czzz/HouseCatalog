namespace HouseCatalog.UserContols
{
    partial class UC_ItemsPage
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
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            lblCountRooms = new Label();
            lblStreet = new Label();
            label11 = new Label();
            lblArea = new Label();
            label9 = new Label();
            lblCity = new Label();
            label5 = new Label();
            lblPrice = new Label();
            label2 = new Label();
            lblName = new Label();
            label1 = new Label();
            lblDescription = new Label();
            label3 = new Label();
            lblSquare = new Label();
            btnCreateOrder = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtCity = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtArea = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtSquare = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtCountrooms = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtStreet = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtDescription = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            btnSaveChanges = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderRadius = 15;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.DarkSlateGray;
            siticoneButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(19, 16);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(141, 37);
            siticoneButton1.TabIndex = 0;
            siticoneButton1.Text = "Назад";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(619, 273);
            label13.Name = "label13";
            label13.Size = new Size(153, 28);
            label13.TabIndex = 23;
            label13.Text = "Кол-во комнат:";
            // 
            // lblCountRooms
            // 
            lblCountRooms.AutoSize = true;
            lblCountRooms.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountRooms.Location = new Point(772, 275);
            lblCountRooms.Name = "lblCountRooms";
            lblCountRooms.Size = new Size(73, 25);
            lblCountRooms.TabIndex = 24;
            lblCountRooms.Text = "label12";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStreet.Location = new Point(680, 225);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(73, 25);
            lblStreet.TabIndex = 22;
            lblStreet.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(619, 224);
            label11.Name = "label11";
            label11.Size = new Size(71, 28);
            label11.TabIndex = 21;
            label11.Text = "Адрес:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblArea.Location = new Point(680, 177);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(63, 25);
            lblArea.TabIndex = 20;
            lblArea.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(619, 176);
            label9.Name = "label9";
            label9.Size = new Size(73, 28);
            label9.TabIndex = 19;
            label9.Text = "Район:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.Location = new Point(679, 129);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(63, 25);
            lblCity.TabIndex = 18;
            lblCity.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(619, 128);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 17;
            label5.Text = "Город:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(1130, 84);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(71, 30);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1067, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 15;
            label2.Text = "Цена:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(619, 81);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 32);
            lblName.TabIndex = 14;
            lblName.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 491);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 25;
            label1.Text = "Описание:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(19, 527);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 25);
            lblDescription.TabIndex = 26;
            lblDescription.Text = "label12";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(619, 323);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 27;
            label3.Text = "Плащадь:";
            // 
            // lblSquare
            // 
            lblSquare.AutoSize = true;
            lblSquare.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSquare.Location = new Point(723, 326);
            lblSquare.Name = "lblSquare";
            lblSquare.Size = new Size(73, 25);
            lblSquare.TabIndex = 28;
            lblSquare.Text = "label12";
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BorderRadius = 15;
            btnCreateOrder.DisabledState.BorderColor = Color.DarkGray;
            btnCreateOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateOrder.FillColor = Color.DarkSlateGray;
            btnCreateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrder.ForeColor = Color.White;
            btnCreateOrder.Location = new Point(1045, 367);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(267, 88);
            btnCreateOrder.TabIndex = 31;
            btnCreateOrder.Text = "Оформить заказ";
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 15;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.DarkSlateGray;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1045, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(267, 59);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Удалить";
            btnDelete.Visible = false;
            btnDelete.Click += siticoneButton2_Click;
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
            txtName.Location = new Point(745, 81);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.Size = new Size(242, 37);
            txtName.TabIndex = 33;
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
            txtCity.Location = new Point(745, 128);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.PlaceholderText = "";
            txtCity.SelectedText = "";
            txtCity.Size = new Size(200, 37);
            txtCity.TabIndex = 33;
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
            txtArea.Location = new Point(745, 176);
            txtArea.Margin = new Padding(3, 4, 3, 4);
            txtArea.Name = "txtArea";
            txtArea.PasswordChar = '\0';
            txtArea.PlaceholderText = "";
            txtArea.SelectedText = "";
            txtArea.Size = new Size(200, 37);
            txtArea.TabIndex = 34;
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
            txtSquare.Location = new Point(808, 318);
            txtSquare.Margin = new Padding(3, 4, 3, 4);
            txtSquare.Name = "txtSquare";
            txtSquare.PasswordChar = '\0';
            txtSquare.PlaceholderText = "";
            txtSquare.SelectedText = "";
            txtSquare.Size = new Size(137, 37);
            txtSquare.TabIndex = 37;
            // 
            // txtCountrooms
            // 
            txtCountrooms.BorderRadius = 20;
            txtCountrooms.DefaultText = "";
            txtCountrooms.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCountrooms.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCountrooms.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCountrooms.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCountrooms.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCountrooms.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountrooms.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCountrooms.Location = new Point(851, 271);
            txtCountrooms.Margin = new Padding(3, 4, 3, 4);
            txtCountrooms.Name = "txtCountrooms";
            txtCountrooms.PasswordChar = '\0';
            txtCountrooms.PlaceholderText = "";
            txtCountrooms.SelectedText = "";
            txtCountrooms.Size = new Size(233, 37);
            txtCountrooms.TabIndex = 35;
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
            txtStreet.Location = new Point(759, 221);
            txtStreet.Margin = new Padding(3, 4, 3, 4);
            txtStreet.Name = "txtStreet";
            txtStreet.PasswordChar = '\0';
            txtStreet.PlaceholderText = "";
            txtStreet.SelectedText = "";
            txtStreet.Size = new Size(228, 37);
            txtStreet.TabIndex = 36;
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
            txtPrice.Location = new Point(1207, 81);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.Size = new Size(160, 37);
            txtPrice.TabIndex = 38;
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
            txtDescription.Location = new Point(582, 491);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderText = "";
            txtDescription.SelectedText = "";
            txtDescription.Size = new Size(405, 268);
            txtDescription.TabIndex = 39;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BorderRadius = 15;
            btnSaveChanges.DisabledState.BorderColor = Color.DarkGray;
            btnSaveChanges.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaveChanges.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaveChanges.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaveChanges.FillColor = Color.DarkSlateGray;
            btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(1045, 546);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(267, 59);
            btnSaveChanges.TabIndex = 40;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.Visible = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // UC_ItemsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnSaveChanges);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtSquare);
            Controls.Add(txtCountrooms);
            Controls.Add(txtStreet);
            Controls.Add(txtArea);
            Controls.Add(txtCity);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnCreateOrder);
            Controls.Add(label3);
            Controls.Add(lblSquare);
            Controls.Add(label1);
            Controls.Add(lblDescription);
            Controls.Add(label13);
            Controls.Add(lblCountRooms);
            Controls.Add(lblStreet);
            Controls.Add(label11);
            Controls.Add(lblArea);
            Controls.Add(label9);
            Controls.Add(lblCity);
            Controls.Add(label5);
            Controls.Add(lblPrice);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(siticoneButton1);
            Name = "UC_ItemsPage";
            Size = new Size(1403, 795);
            Load += UC_ItemsPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private PictureBox pictureBox1;
        private Label label13;
        private Label lblCountRooms;
        private Label lblStreet;
        private Label label11;
        private Label lblArea;
        private Label label9;
        private Label lblCity;
        private Label label5;
        private Label lblPrice;
        private Label label2;
        private Label lblName;
        private Label label1;
        private Label lblDescription;
        private Label label3;
        private Label lblSquare;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCreateOrder;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCity;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtArea;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSquare;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCountrooms;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtStreet;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDescription;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSaveChanges;
    }
}
