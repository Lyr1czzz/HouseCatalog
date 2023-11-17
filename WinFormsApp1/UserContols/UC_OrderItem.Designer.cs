namespace HouseCatalog.UserContols
{
    partial class UC_OrderItem
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
            btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new Label();
            txtTelephoneNumber = new Label();
            txtMail = new Label();
            txtHouseId = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(796, 43);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 56);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Удалить";
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 1;
            label1.Text = "Номер телефона:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 71);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Почта:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 30);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 71);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 4;
            label4.Text = "id обьявления:";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(53, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 20);
            txtId.TabIndex = 5;
            txtId.Text = "label5";
            // 
            // txtTelephoneNumber
            // 
            txtTelephoneNumber.AutoSize = true;
            txtTelephoneNumber.Location = new Point(464, 30);
            txtTelephoneNumber.Name = "txtTelephoneNumber";
            txtTelephoneNumber.Size = new Size(50, 20);
            txtTelephoneNumber.TabIndex = 6;
            txtTelephoneNumber.Text = "label5";
            // 
            // txtMail
            // 
            txtMail.AutoSize = true;
            txtMail.Location = new Point(388, 71);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(50, 20);
            txtMail.TabIndex = 7;
            txtMail.Text = "label5";
            // 
            // txtHouseId
            // 
            txtHouseId.AutoSize = true;
            txtHouseId.Location = new Point(139, 71);
            txtHouseId.Name = "txtHouseId";
            txtHouseId.Size = new Size(50, 20);
            txtHouseId.TabIndex = 8;
            txtHouseId.Text = "label5";
            // 
            // UC_OrderItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtHouseId);
            Controls.Add(txtMail);
            Controls.Add(txtTelephoneNumber);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Name = "UC_OrderItem";
            Size = new Size(1038, 140);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txtId;
        private Label txtTelephoneNumber;
        private Label txtMail;
        private Label txtHouseId;
    }
}
