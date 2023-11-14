namespace WinFormsApp1
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registrButton = new CodeeloUI.Controls.CodeeloButton();
            loginButton = new CodeeloUI.Controls.CodeeloButton();
            auth_label = new Label();
            registr_label = new Label();
            noacc_label = new Label();
            backlabel = new Label();
            Login = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Pass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Repass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            SuspendLayout();
            // 
            // registrButton
            // 
            registrButton.AccessibleRole = null;
            registrButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registrButton.BackColor = Color.Transparent;
            registrButton.BorderColor_1 = Color.Transparent;
            registrButton.BorderColor_2 = Color.Transparent;
            registrButton.BorderRadius = 20;
            registrButton.BorderSize = 3;
            registrButton.CausesValidation = false;
            registrButton.ColorFill_1 = Color.FromArgb(139, 144, 176);
            registrButton.ColorFill_2 = Color.FromArgb(159, 185, 189);
            registrButton.DialogResult = false;
            registrButton.FlatAppearance.BorderSize = 0;
            registrButton.FlatStyle = FlatStyle.Flat;
            registrButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registrButton.ForeColor = Color.WhiteSmoke;
            registrButton.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            registrButton.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            registrButton.Location = new Point(341, 439);
            registrButton.Margin = new Padding(3, 4, 3, 4);
            registrButton.Name = "registrButton";
            registrButton.OnClick_BorderColor_1 = Color.Transparent;
            registrButton.OnClick_BorderColor_2 = Color.Transparent;
            registrButton.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            registrButton.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            registrButton.OnOver_BorderColor_1 = Color.Transparent;
            registrButton.OnOver_BorderColor_2 = Color.Transparent;
            registrButton.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            registrButton.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            registrButton.Size = new Size(226, 63);
            registrButton.TabIndex = 2;
            registrButton.TabStop = false;
            registrButton.Text = "Зарегестрироваться";
            registrButton.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            registrButton.UseMnemonic = false;
            registrButton.UseVisualStyleBackColor = false;
            registrButton.Visible = false;
            registrButton.Click += codeeloButton1_Click;
            // 
            // loginButton
            // 
            loginButton.AccessibleRole = null;
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.BackColor = Color.Transparent;
            loginButton.BorderColor_1 = Color.Transparent;
            loginButton.BorderColor_2 = Color.Transparent;
            loginButton.BorderRadius = 20;
            loginButton.BorderSize = 3;
            loginButton.CausesValidation = false;
            loginButton.ColorFill_1 = Color.FromArgb(139, 144, 176);
            loginButton.ColorFill_2 = Color.FromArgb(159, 185, 189);
            loginButton.DialogResult = false;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.WhiteSmoke;
            loginButton.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            loginButton.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            loginButton.Location = new Point(341, 439);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.OnClick_BorderColor_1 = Color.Transparent;
            loginButton.OnClick_BorderColor_2 = Color.Transparent;
            loginButton.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            loginButton.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            loginButton.OnOver_BorderColor_1 = Color.Transparent;
            loginButton.OnOver_BorderColor_2 = Color.Transparent;
            loginButton.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            loginButton.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            loginButton.Size = new Size(226, 63);
            loginButton.TabIndex = 3;
            loginButton.TabStop = false;
            loginButton.Text = "Войти";
            loginButton.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            loginButton.UseMnemonic = false;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += codeeloButton2_Click;
            // 
            // auth_label
            // 
            auth_label.AutoSize = true;
            auth_label.BackColor = Color.Transparent;
            auth_label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            auth_label.ForeColor = Color.Black;
            auth_label.Location = new Point(347, 53);
            auth_label.Name = "auth_label";
            auth_label.Size = new Size(215, 36);
            auth_label.TabIndex = 5;
            auth_label.Text = "Авторизация";
            // 
            // registr_label
            // 
            registr_label.AutoSize = true;
            registr_label.BackColor = Color.Transparent;
            registr_label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registr_label.ForeColor = Color.Black;
            registr_label.Location = new Point(341, 53);
            registr_label.Name = "registr_label";
            registr_label.Size = new Size(214, 36);
            registr_label.TabIndex = 6;
            registr_label.Text = "Регистрация";
            registr_label.Visible = false;
            // 
            // noacc_label
            // 
            noacc_label.AutoSize = true;
            noacc_label.Cursor = Cursors.Hand;
            noacc_label.Location = new Point(505, 548);
            noacc_label.Name = "noacc_label";
            noacc_label.Size = new Size(105, 20);
            noacc_label.TabIndex = 7;
            noacc_label.Text = "Нет аккаунта?";
            noacc_label.Click += label1_Click;
            // 
            // backlabel
            // 
            backlabel.AutoSize = true;
            backlabel.Cursor = Cursors.Hand;
            backlabel.Location = new Point(552, 548);
            backlabel.Name = "backlabel";
            backlabel.Size = new Size(51, 20);
            backlabel.TabIndex = 8;
            backlabel.Text = "Назад";
            backlabel.Visible = false;
            backlabel.Click += backlabel_Click;
            // 
            // Login
            // 
            Login.BorderRadius = 25;
            Login.DefaultText = "";
            Login.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Login.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Login.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Login.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Login.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Login.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Login.Location = new Point(311, 180);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.PasswordChar = '\0';
            Login.PlaceholderText = "Введите свой номер телефона";
            Login.SelectedText = "";
            Login.Size = new Size(286, 48);
            Login.TabIndex = 9;
            // 
            // Pass
            // 
            Pass.BorderRadius = 25;
            Pass.DefaultText = "";
            Pass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Pass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Pass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Pass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Pass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Pass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Pass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Pass.Location = new Point(311, 255);
            Pass.Margin = new Padding(3, 4, 3, 4);
            Pass.Name = "Pass";
            Pass.PasswordChar = '●';
            Pass.PlaceholderText = "Введите пароль";
            Pass.SelectedText = "";
            Pass.Size = new Size(286, 48);
            Pass.TabIndex = 10;
            Pass.UseSystemPasswordChar = true;
            // 
            // Repass
            // 
            Repass.BorderRadius = 25;
            Repass.DefaultText = "";
            Repass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Repass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Repass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Repass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Repass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Repass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Repass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Repass.Location = new Point(311, 339);
            Repass.Margin = new Padding(3, 4, 3, 4);
            Repass.Name = "Repass";
            Repass.PasswordChar = '●';
            Repass.PlaceholderText = "Повторите пароль";
            Repass.SelectedText = "";
            Repass.Size = new Size(286, 48);
            Repass.TabIndex = 11;
            Repass.UseSystemPasswordChar = true;
            Repass.Visible = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(914, 600);
            Controls.Add(Repass);
            Controls.Add(Pass);
            Controls.Add(Login);
            Controls.Add(backlabel);
            Controls.Add(noacc_label);
            Controls.Add(registr_label);
            Controls.Add(auth_label);
            Controls.Add(loginButton);
            Controls.Add(registrButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuthForm";
            Text = "Form1";
            FormClosed += AuthForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CodeeloUI.Controls.CodeeloButton registrButton;
        private CodeeloUI.Controls.CodeeloButton loginButton;
        private Label auth_label;
        private Label registr_label;
        private Label noacc_label;
        private Label backlabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Login;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Pass;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Repass;
    }
}