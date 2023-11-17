namespace HouseCatalog.UserContols
{
    partial class UC_Item
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
            lblName = new Label();
            label2 = new Label();
            lblPrice = new Label();
            lblCity = new Label();
            label5 = new Label();
            lblArea = new Label();
            label9 = new Label();
            lblStreet = new Label();
            label11 = new Label();
            lblCountRooms = new Label();
            label13 = new Label();
            btnOpenPage = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(370, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(856, 15);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "Цена:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(912, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "label3";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(419, 61);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(50, 20);
            lblCity.TabIndex = 5;
            lblCity.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 61);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Город:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(419, 109);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(50, 20);
            lblArea.TabIndex = 9;
            lblArea.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 109);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 8;
            label9.Text = "Район:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(419, 157);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(58, 20);
            lblStreet.TabIndex = 11;
            lblStreet.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(370, 157);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 10;
            label11.Text = "Адрес:";
            // 
            // lblCountRooms
            // 
            lblCountRooms.AutoSize = true;
            lblCountRooms.Location = new Point(485, 207);
            lblCountRooms.Name = "lblCountRooms";
            lblCountRooms.Size = new Size(58, 20);
            lblCountRooms.TabIndex = 13;
            lblCountRooms.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(370, 207);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 12;
            label13.Text = "Кол-во комнат:";
            // 
            // btnOpenPage
            // 
            btnOpenPage.BorderRadius = 25;
            btnOpenPage.DisabledState.BorderColor = Color.DarkGray;
            btnOpenPage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOpenPage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOpenPage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOpenPage.FillColor = Color.DarkSlateGray;
            btnOpenPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenPage.ForeColor = Color.White;
            btnOpenPage.Location = new Point(826, 109);
            btnOpenPage.Name = "btnOpenPage";
            btnOpenPage.Size = new Size(181, 56);
            btnOpenPage.TabIndex = 14;
            btnOpenPage.Text = "Перейти";
            btnOpenPage.Click += btnOpenPage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // UC_Item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pictureBox1);
            Controls.Add(btnOpenPage);
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
            Name = "UC_Item";
            Size = new Size(1038, 275);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label label2;
        private Label lblPrice;
        private Label lblCity;
        private Label label5;
        private Label lblArea;
        private Label label9;
        private Label lblStreet;
        private Label label11;
        private Label lblCountRooms;
        private Label label13;
        public Siticone.Desktop.UI.WinForms.SiticoneButton btnOpenPage;
        private PictureBox pictureBox1;
    }
}
