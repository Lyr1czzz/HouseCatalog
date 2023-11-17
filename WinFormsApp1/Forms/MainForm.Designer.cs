namespace WinFormsApp1
{
    partial class MainForm
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
            pnlHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            btnItemes = new CodeeloUI.Controls.CodeeloButton();
            btnOrders = new CodeeloUI.Controls.CodeeloButton();
            btnAdd = new CodeeloUI.Controls.CodeeloButton();
            pnlFilters = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            comboCity = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            numSquare2 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            numSquare1 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            numPrice2 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            numPrice1 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            btnSetFilter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            comboSort = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            btnDeleteFilter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pnlItemsList = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSquare2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSquare1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Aquamarine;
            pnlHeader.Controls.Add(btnItemes);
            pnlHeader.Controls.Add(btnOrders);
            pnlHeader.Controls.Add(btnAdd);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1339, 75);
            pnlHeader.TabIndex = 1;
            // 
            // btnItemes
            // 
            btnItemes.AccessibleRole = null;
            btnItemes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemes.BackColor = Color.Transparent;
            btnItemes.BorderColor_1 = Color.Transparent;
            btnItemes.BorderColor_2 = Color.Transparent;
            btnItemes.BorderRadius = 20;
            btnItemes.BorderSize = 3;
            btnItemes.CausesValidation = false;
            btnItemes.ColorFill_1 = Color.DarkSlateGray;
            btnItemes.ColorFill_2 = Color.DarkSlateGray;
            btnItemes.DialogResult = false;
            btnItemes.FlatAppearance.BorderSize = 0;
            btnItemes.FlatStyle = FlatStyle.Flat;
            btnItemes.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnItemes.ForeColor = Color.WhiteSmoke;
            btnItemes.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnItemes.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnItemes.Location = new Point(583, 0);
            btnItemes.Name = "btnItemes";
            btnItemes.OnClick_BorderColor_1 = Color.Transparent;
            btnItemes.OnClick_BorderColor_2 = Color.Transparent;
            btnItemes.OnClick_FillColor_1 = Color.DarkSlateGray;
            btnItemes.OnClick_FillColor_2 = Color.DarkSlateGray;
            btnItemes.OnOver_BorderColor_1 = Color.Empty;
            btnItemes.OnOver_BorderColor_2 = Color.Transparent;
            btnItemes.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnItemes.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnItemes.Size = new Size(248, 75);
            btnItemes.TabIndex = 2;
            btnItemes.TabStop = false;
            btnItemes.Text = "Обьявления";
            btnItemes.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnItemes.UseMnemonic = false;
            btnItemes.UseVisualStyleBackColor = false;
            btnItemes.Visible = false;
            btnItemes.Click += codeeloButton1_Click_1;
            // 
            // btnOrders
            // 
            btnOrders.AccessibleRole = null;
            btnOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOrders.BackColor = Color.Transparent;
            btnOrders.BorderColor_1 = Color.Transparent;
            btnOrders.BorderColor_2 = Color.Transparent;
            btnOrders.BorderRadius = 20;
            btnOrders.BorderSize = 3;
            btnOrders.CausesValidation = false;
            btnOrders.ColorFill_1 = Color.DarkSlateGray;
            btnOrders.ColorFill_2 = Color.DarkSlateGray;
            btnOrders.DialogResult = false;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrders.ForeColor = Color.WhiteSmoke;
            btnOrders.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnOrders.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnOrders.Location = new Point(837, 0);
            btnOrders.Name = "btnOrders";
            btnOrders.OnClick_BorderColor_1 = Color.Transparent;
            btnOrders.OnClick_BorderColor_2 = Color.Transparent;
            btnOrders.OnClick_FillColor_1 = Color.DarkSlateGray;
            btnOrders.OnClick_FillColor_2 = Color.DarkSlateGray;
            btnOrders.OnOver_BorderColor_1 = Color.Empty;
            btnOrders.OnOver_BorderColor_2 = Color.Transparent;
            btnOrders.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnOrders.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnOrders.Size = new Size(248, 75);
            btnOrders.TabIndex = 1;
            btnOrders.TabStop = false;
            btnOrders.Text = "Заказы";
            btnOrders.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnOrders.UseMnemonic = false;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Visible = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleRole = null;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor_1 = Color.Transparent;
            btnAdd.BorderColor_2 = Color.Transparent;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 3;
            btnAdd.CausesValidation = false;
            btnAdd.ColorFill_1 = Color.DarkSlateGray;
            btnAdd.ColorFill_2 = Color.DarkSlateGray;
            btnAdd.DialogResult = false;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAdd.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAdd.Location = new Point(1091, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.OnClick_BorderColor_1 = Color.Transparent;
            btnAdd.OnClick_BorderColor_2 = Color.Transparent;
            btnAdd.OnClick_FillColor_1 = Color.DarkSlateGray;
            btnAdd.OnClick_FillColor_2 = Color.DarkSlateGray;
            btnAdd.OnOver_BorderColor_1 = Color.Empty;
            btnAdd.OnOver_BorderColor_2 = Color.Transparent;
            btnAdd.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnAdd.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnAdd.Size = new Size(248, 75);
            btnAdd.TabIndex = 0;
            btnAdd.TabStop = false;
            btnAdd.Text = "Добавить обьявление";
            btnAdd.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnAdd.UseMnemonic = false;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            btnAdd.Click += codeeloButton1_Click;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.MediumAquamarine;
            pnlFilters.BorderRadius = 30;
            pnlFilters.Controls.Add(comboCity);
            pnlFilters.Controls.Add(numSquare2);
            pnlFilters.Controls.Add(numSquare1);
            pnlFilters.Controls.Add(numPrice2);
            pnlFilters.Controls.Add(numPrice1);
            pnlFilters.Controls.Add(btnSetFilter);
            pnlFilters.Controls.Add(comboSort);
            pnlFilters.Controls.Add(btnDeleteFilter);
            pnlFilters.Dock = DockStyle.Left;
            pnlFilters.FillColor = Color.Transparent;
            pnlFilters.Location = new Point(0, 75);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(263, 630);
            pnlFilters.TabIndex = 2;
            // 
            // comboCity
            // 
            comboCity.BackColor = Color.Transparent;
            comboCity.BorderRadius = 15;
            comboCity.DisplayMember = "df";
            comboCity.DrawMode = DrawMode.OwnerDrawFixed;
            comboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCity.FocusedColor = Color.FromArgb(94, 148, 255);
            comboCity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboCity.ForeColor = Color.FromArgb(68, 88, 112);
            comboCity.ItemHeight = 30;
            comboCity.Items.AddRange(new object[] { "Все города", "Минск", "Могилёв", "Витебск", "Гомель", "Гродно", "Полоцк", "Пинск", "Брест" });
            comboCity.Location = new Point(11, 19);
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(233, 36);
            comboCity.TabIndex = 12;
            // 
            // numSquare2
            // 
            numSquare2.BackColor = Color.Transparent;
            numSquare2.BorderRadius = 15;
            numSquare2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numSquare2.Location = new Point(11, 305);
            numSquare2.Margin = new Padding(3, 5, 3, 5);
            numSquare2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSquare2.Name = "numSquare2";
            numSquare2.Size = new Size(233, 49);
            numSquare2.TabIndex = 11;
            numSquare2.UpDownButtonFillColor = Color.DarkSlateGray;
            numSquare2.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numSquare1
            // 
            numSquare1.BackColor = Color.Transparent;
            numSquare1.BorderRadius = 15;
            numSquare1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numSquare1.Location = new Point(11, 235);
            numSquare1.Margin = new Padding(3, 5, 3, 5);
            numSquare1.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numSquare1.Name = "numSquare1";
            numSquare1.Size = new Size(233, 49);
            numSquare1.TabIndex = 10;
            numSquare1.UpDownButtonFillColor = Color.DarkSlateGray;
            // 
            // numPrice2
            // 
            numPrice2.BackColor = Color.Transparent;
            numPrice2.BorderRadius = 15;
            numPrice2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numPrice2.Location = new Point(11, 165);
            numPrice2.Margin = new Padding(3, 5, 3, 5);
            numPrice2.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice2.Name = "numPrice2";
            numPrice2.Size = new Size(233, 49);
            numPrice2.TabIndex = 9;
            numPrice2.UpDownButtonFillColor = Color.DarkSlateGray;
            numPrice2.Value = new decimal(new int[] { 100000000, 0, 0, 0 });
            // 
            // numPrice1
            // 
            numPrice1.BackColor = Color.Transparent;
            numPrice1.BorderRadius = 15;
            numPrice1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numPrice1.Location = new Point(11, 96);
            numPrice1.Margin = new Padding(3, 5, 3, 5);
            numPrice1.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numPrice1.Name = "numPrice1";
            numPrice1.Size = new Size(233, 49);
            numPrice1.TabIndex = 8;
            numPrice1.UpDownButtonFillColor = Color.DarkSlateGray;
            // 
            // btnSetFilter
            // 
            btnSetFilter.BorderRadius = 25;
            btnSetFilter.DisabledState.BorderColor = Color.DarkGray;
            btnSetFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSetFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSetFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSetFilter.FillColor = Color.DarkSlateGray;
            btnSetFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetFilter.ForeColor = Color.White;
            btnSetFilter.Location = new Point(11, 449);
            btnSetFilter.Name = "btnSetFilter";
            btnSetFilter.Size = new Size(225, 68);
            btnSetFilter.TabIndex = 7;
            btnSetFilter.Text = "Фильтровать";
            btnSetFilter.Click += btnSetFilter_Click;
            // 
            // comboSort
            // 
            comboSort.BackColor = Color.Transparent;
            comboSort.BorderRadius = 15;
            comboSort.DrawMode = DrawMode.OwnerDrawFixed;
            comboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSort.FocusedColor = Color.FromArgb(94, 148, 255);
            comboSort.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboSort.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboSort.ForeColor = Color.FromArgb(68, 88, 112);
            comboSort.ItemHeight = 30;
            comboSort.Items.AddRange(new object[] { "От низкой к высокой", "От высокой к низкой" });
            comboSort.Location = new Point(11, 379);
            comboSort.Name = "comboSort";
            comboSort.Size = new Size(233, 36);
            comboSort.TabIndex = 6;
            // 
            // btnDeleteFilter
            // 
            btnDeleteFilter.BorderRadius = 25;
            btnDeleteFilter.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteFilter.FillColor = Color.DarkSlateGray;
            btnDeleteFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteFilter.ForeColor = Color.White;
            btnDeleteFilter.Location = new Point(11, 563);
            btnDeleteFilter.Name = "btnDeleteFilter";
            btnDeleteFilter.Size = new Size(225, 56);
            btnDeleteFilter.TabIndex = 0;
            btnDeleteFilter.Text = "Сбросить фильтр";
            btnDeleteFilter.Click += btnDeleteFilter_Click;
            // 
            // pnlItemsList
            // 
            pnlItemsList.AutoScroll = true;
            pnlItemsList.BackColor = Color.LightCyan;
            pnlItemsList.Dock = DockStyle.Fill;
            pnlItemsList.Location = new Point(263, 75);
            pnlItemsList.Name = "pnlItemsList";
            pnlItemsList.Size = new Size(1076, 630);
            pnlItemsList.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 705);
            Controls.Add(pnlItemsList);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HouseCatalog";
            FormClosed += MainForm_FormClosed;
            pnlHeader.ResumeLayout(false);
            pnlFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSquare2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSquare1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlHeader;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlFilters;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlItemsList;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDeleteFilter;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCountRooms;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboSort;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSetFilter;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numSquare2;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numSquare1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numPrice2;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numPrice1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboCity;
        private CodeeloUI.Controls.CodeeloButton btnAdd;
        private CodeeloUI.Controls.CodeeloButton btnOrders;
        private CodeeloUI.Controls.CodeeloButton btnItemes;
    }
}