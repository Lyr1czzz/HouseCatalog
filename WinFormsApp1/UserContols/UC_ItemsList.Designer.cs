namespace HouseCatalog.UserContols
{
    partial class UC_ItemsList
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
            pnlItemsList = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            SuspendLayout();
            // 
            // pnlItemsList
            // 
            pnlItemsList.Dock = DockStyle.Fill;
            pnlItemsList.Location = new Point(0, 0);
            pnlItemsList.Name = "pnlItemsList";
            pnlItemsList.Size = new Size(1339, 630);
            pnlItemsList.TabIndex = 1;
            pnlItemsList.Paint += pnlItemsList_Paint;
            // 
            // UC_ItemsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlItemsList);
            Name = "UC_ItemsList";
            Size = new Size(1339, 630);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlItemsList;
    }
}
