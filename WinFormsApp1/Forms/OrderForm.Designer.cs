namespace HouseCatalog.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            label1 = new Label();
            txtTelephoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            siticoneBorderlessForm1.BorderRadius = 20;
            siticoneBorderlessForm1.ContainerControl = this;
            siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderRadius = 25;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.DarkSlateGray;
            siticoneButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(11, 12);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(162, 51);
            siticoneButton1.TabIndex = 0;
            siticoneButton1.Text = "Назад";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 92);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 1;
            label1.Text = "Оформление заказа";
            // 
            // txtTelephoneNumber
            // 
            txtTelephoneNumber.BorderRadius = 30;
            txtTelephoneNumber.DefaultText = "";
            txtTelephoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelephoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelephoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelephoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelephoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelephoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelephoneNumber.ForeColor = Color.Black;
            txtTelephoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelephoneNumber.Location = new Point(139, 173);
            txtTelephoneNumber.Margin = new Padding(3, 5, 3, 5);
            txtTelephoneNumber.Name = "txtTelephoneNumber";
            txtTelephoneNumber.PasswordChar = '\0';
            txtTelephoneNumber.PlaceholderForeColor = Color.Black;
            txtTelephoneNumber.PlaceholderText = "Номер телефона";
            txtTelephoneNumber.SelectedText = "";
            txtTelephoneNumber.Size = new Size(286, 60);
            txtTelephoneNumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 30;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(139, 276);
            txtEmail.Margin = new Padding(3, 5, 3, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderForeColor = Color.Black;
            txtEmail.PlaceholderText = "Почта";
            txtEmail.SelectedText = "";
            txtEmail.Size = new Size(286, 60);
            txtEmail.TabIndex = 3;
            // 
            // siticoneButton2
            // 
            siticoneButton2.BorderRadius = 30;
            siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton2.FillColor = Color.DarkSlateGray;
            siticoneButton2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton2.ForeColor = Color.White;
            siticoneButton2.Location = new Point(139, 397);
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.Size = new Size(286, 89);
            siticoneButton2.TabIndex = 4;
            siticoneButton2.Text = "Оформить";
            siticoneButton2.Click += siticoneButton2_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 592);
            Controls.Add(siticoneButton2);
            Controls.Add(txtEmail);
            Controls.Add(txtTelephoneNumber);
            Controls.Add(label1);
            Controls.Add(siticoneButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTelephoneNumber;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
    }
}