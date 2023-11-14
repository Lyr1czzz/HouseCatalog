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
            label6 = new Label();
            txtCountRooms = new Label();
            btnCreateOrder = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            siticoneButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(19, 16);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(141, 38);
            siticoneButton1.TabIndex = 0;
            siticoneButton1.Text = "Назад";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(619, 273);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 23;
            label13.Text = "Кол-во комнат:";
            // 
            // lblCountRooms
            // 
            lblCountRooms.AutoSize = true;
            lblCountRooms.Location = new Point(740, 273);
            lblCountRooms.Name = "lblCountRooms";
            lblCountRooms.Size = new Size(58, 20);
            lblCountRooms.TabIndex = 24;
            lblCountRooms.Text = "label12";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(679, 224);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(58, 20);
            lblStreet.TabIndex = 22;
            lblStreet.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(619, 224);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 21;
            label11.Text = "Адрес:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(680, 176);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(50, 20);
            lblArea.TabIndex = 20;
            lblArea.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(619, 176);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 19;
            label9.Text = "Район:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(679, 128);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(50, 20);
            lblCity.TabIndex = 18;
            lblCity.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 128);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 17;
            label5.Text = "Город:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(1101, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1045, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 15;
            label2.Text = "Цена:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(619, 81);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 20);
            lblName.TabIndex = 14;
            lblName.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 490);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 25;
            label1.Text = "Описание:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 527);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(58, 20);
            lblDescription.TabIndex = 26;
            lblDescription.Text = "label12";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 323);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 27;
            label3.Text = "Плащадь:";
            // 
            // lblSquare
            // 
            lblSquare.AutoSize = true;
            lblSquare.Location = new Point(700, 323);
            lblSquare.Name = "lblSquare";
            lblSquare.Size = new Size(58, 20);
            lblSquare.TabIndex = 28;
            lblSquare.Text = "label12";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(619, 377);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 29;
            label6.Text = "Кол-во комнат:";
            // 
            // txtCountRooms
            // 
            txtCountRooms.AutoSize = true;
            txtCountRooms.Location = new Point(740, 377);
            txtCountRooms.Name = "txtCountRooms";
            txtCountRooms.Size = new Size(58, 20);
            txtCountRooms.TabIndex = 30;
            txtCountRooms.Text = "label12";
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BorderRadius = 15;
            btnCreateOrder.DisabledState.BorderColor = Color.DarkGray;
            btnCreateOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateOrder.FillColor = Color.DarkSlateGray;
            btnCreateOrder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrder.ForeColor = Color.White;
            btnCreateOrder.Location = new Point(1045, 367);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(267, 88);
            btnCreateOrder.TabIndex = 31;
            btnCreateOrder.Text = "Оформить заказ";
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // UC_ItemsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnCreateOrder);
            Controls.Add(label6);
            Controls.Add(txtCountRooms);
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
            Size = new Size(1404, 794);
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
        private Label label6;
        private Label txtCountRooms;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCreateOrder;
    }
}
