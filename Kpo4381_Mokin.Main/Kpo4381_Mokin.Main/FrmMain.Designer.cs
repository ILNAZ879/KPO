namespace Kpo4381_Mokin.Main
{
    partial class FrmMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmPK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenParticipant = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTransports = new System.Windows.Forms.DataGridView();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransports)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmPK});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(476, 24);
            this.MMenu.TabIndex = 8;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "1&.Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(152, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(152, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mmPK
            // 
            this.mmPK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenParticipant});
            this.mmPK.Name = "mmPK";
            this.mmPK.Size = new System.Drawing.Size(86, 20);
            this.mmPK.Text = "2.Участники";
            // 
            // mnOpenParticipant
            // 
            this.mnOpenParticipant.Name = "mnOpenParticipant";
            this.mnOpenParticipant.Size = new System.Drawing.Size(224, 22);
            this.mnOpenParticipant.Text = "Открыть данные участника";
            this.mnOpenParticipant.Click += new System.EventHandler(this.mnOpenParticipant_Click);
            // 
            // dgvTransports
            // 
            this.dgvTransports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransports.Location = new System.Drawing.Point(12, 39);
            this.dgvTransports.Name = "dgvTransports";
            this.dgvTransports.Size = new System.Drawing.Size(452, 131);
            this.dgvTransports.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 179);
            this.Controls.Add(this.dgvTransports);
            this.Controls.Add(this.MMenu);
            this.Name = "FrmMain";
            this.Text = "Ведомость спортивних состязаний";
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem mmPK;
        private System.Windows.Forms.ToolStripMenuItem mnOpenParticipant;
        private System.Windows.Forms.DataGridView dgvTransports;
    }
}

