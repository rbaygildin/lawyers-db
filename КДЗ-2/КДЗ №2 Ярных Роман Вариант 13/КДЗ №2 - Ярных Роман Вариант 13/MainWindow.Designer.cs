namespace CHW_2_Yarnykh_Roman_V13
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubuttonOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menubuttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menubuttonSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubuttonAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridLawyersList = new System.Windows.Forms.DataGridView();
            this.textboxLineNumber = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboboxFilterKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.checkboxLastNameSortKey = new System.Windows.Forms.CheckBox();
            this.checkboxFirstNameSortKey = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLawyersList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubuttonOpen,
            this.menubuttonSave,
            this.menubuttonSaveAs});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menubuttonOpen
            // 
            this.menubuttonOpen.Name = "menubuttonOpen";
            this.menubuttonOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menubuttonOpen.Size = new System.Drawing.Size(172, 22);
            this.menubuttonOpen.Text = "Открыть";
            this.menubuttonOpen.Click += new System.EventHandler(this.menubuttonOpen_Click);
            // 
            // menubuttonSave
            // 
            this.menubuttonSave.Name = "menubuttonSave";
            this.menubuttonSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menubuttonSave.Size = new System.Drawing.Size(172, 22);
            this.menubuttonSave.Text = "Сохранить";
            this.menubuttonSave.Click += new System.EventHandler(this.menubuttonSave_Click);
            // 
            // menubuttonSaveAs
            // 
            this.menubuttonSaveAs.Name = "menubuttonSaveAs";
            this.menubuttonSaveAs.Size = new System.Drawing.Size(172, 22);
            this.menubuttonSaveAs.Text = "Сохранить как...";
            this.menubuttonSaveAs.Click += new System.EventHandler(this.menubuttonSaveAs_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubuttonAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // menubuttonAbout
            // 
            this.menubuttonAbout.Name = "menubuttonAbout";
            this.menubuttonAbout.Size = new System.Drawing.Size(157, 22);
            this.menubuttonAbout.Text = "О приложении";
            this.menubuttonAbout.Click += new System.EventHandler(this.menubuttonAbout_Click);
            // 
            // datagridLawyersList
            // 
            this.datagridLawyersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridLawyersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridLawyersList.Location = new System.Drawing.Point(12, 105);
            this.datagridLawyersList.Name = "datagridLawyersList";
            this.datagridLawyersList.RowHeadersVisible = false;
            this.datagridLawyersList.Size = new System.Drawing.Size(902, 373);
            this.datagridLawyersList.TabIndex = 1;
            // 
            // textboxLineNumber
            // 
            this.textboxLineNumber.Location = new System.Drawing.Point(12, 55);
            this.textboxLineNumber.Name = "textboxLineNumber";
            this.textboxLineNumber.Size = new System.Drawing.Size(134, 20);
            this.textboxLineNumber.TabIndex = 2;
            // 
            // buttonShow
            // 
            this.buttonShow.Enabled = false;
            this.buttonShow.Location = new System.Drawing.Point(152, 52);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(97, 23);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Отобразить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число строк";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Enabled = false;
            this.buttonFilter.Location = new System.Drawing.Point(496, 53);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Отфильтровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboboxFilterKey
            // 
            this.comboboxFilterKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFilterKey.FormattingEnabled = true;
            this.comboboxFilterKey.Items.AddRange(new object[] {
            "Приостановление статуса адвоката",
            "Возобновление статуса адвоката"});
            this.comboboxFilterKey.Location = new System.Drawing.Point(290, 55);
            this.comboboxFilterKey.Name = "comboboxFilterKey";
            this.comboboxFilterKey.Size = new System.Drawing.Size(191, 21);
            this.comboboxFilterKey.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фильтрация по полю";
            // 
            // buttonSort
            // 
            this.buttonSort.Enabled = false;
            this.buttonSort.Location = new System.Drawing.Point(733, 53);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(115, 23);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // checkboxLastNameSortKey
            // 
            this.checkboxLastNameSortKey.AutoSize = true;
            this.checkboxLastNameSortKey.Location = new System.Drawing.Point(647, 52);
            this.checkboxLastNameSortKey.Name = "checkboxLastNameSortKey";
            this.checkboxLastNameSortKey.Size = new System.Drawing.Size(75, 17);
            this.checkboxLastNameSortKey.TabIndex = 9;
            this.checkboxLastNameSortKey.Text = "Фамилия";
            this.checkboxLastNameSortKey.UseVisualStyleBackColor = true;
            // 
            // checkboxFirstNameSortKey
            // 
            this.checkboxFirstNameSortKey.AutoSize = true;
            this.checkboxFirstNameSortKey.Location = new System.Drawing.Point(647, 75);
            this.checkboxFirstNameSortKey.Name = "checkboxFirstNameSortKey";
            this.checkboxFirstNameSortKey.Size = new System.Drawing.Size(48, 17);
            this.checkboxFirstNameSortKey.TabIndex = 10;
            this.checkboxFirstNameSortKey.Text = "Имя";
            this.checkboxFirstNameSortKey.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 490);
            this.Controls.Add(this.checkboxFirstNameSortKey);
            this.Controls.Add(this.checkboxLastNameSortKey);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxFilterKey);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textboxLineNumber);
            this.Controls.Add(this.datagridLawyersList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Реестр адвокатов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLawyersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menubuttonOpen;
        private System.Windows.Forms.ToolStripMenuItem menubuttonSave;
        private System.Windows.Forms.ToolStripMenuItem menubuttonSaveAs;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menubuttonAbout;
        private System.Windows.Forms.DataGridView datagridLawyersList;
        private System.Windows.Forms.TextBox textboxLineNumber;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboboxFilterKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.CheckBox checkboxLastNameSortKey;
        private System.Windows.Forms.CheckBox checkboxFirstNameSortKey;
    }
}

