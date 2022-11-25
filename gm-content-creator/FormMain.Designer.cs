namespace gm_content_creator
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadARandomArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RichTextBoxArticleBody = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyTextToTheClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTextFromTheClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.LblBody = new System.Windows.Forms.Label();
            this.TxtBoxArticleTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.GroupBoxArticleOptions = new System.Windows.Forms.GroupBox();
            this.BtnExportArticle = new System.Windows.Forms.Button();
            this.BtnSpin = new System.Windows.Forms.Button();
            this.LblKeywords = new System.Windows.Forms.Label();
            this.BtnSourceArticleContent = new System.Windows.Forms.Button();
            this.TxtBoxKeyword = new System.Windows.Forms.TextBox();
            this.Source2 = new System.Windows.Forms.RadioButton();
            this.Source1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridSynonymsView = new System.Windows.Forms.DataGridView();
            this.colSynEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSynEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSynCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBoxSynonymOptions = new System.Windows.Forms.GroupBox();
            this.BtnLoadSynonymsFile = new System.Windows.Forms.Button();
            this.ComboBoxSynonymFile = new System.Windows.Forms.ComboBox();
            this.LblSelectSynonymsFile = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.BackgroundWorkerImportSynonymsFile = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorkerSpinTax = new System.ComponentModel.BackgroundWorker();
            this.ChkBoxRandomizeParagraphs = new System.Windows.Forms.CheckBox();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.GroupBoxArticleOptions.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSynonymsView)).BeginInit();
            this.GroupBoxSynonymOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(933, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit ...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadARandomArticleToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // downloadARandomArticleToolStripMenuItem
            // 
            this.downloadARandomArticleToolStripMenuItem.Name = "downloadARandomArticleToolStripMenuItem";
            this.downloadARandomArticleToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.downloadARandomArticleToolStripMenuItem.Text = "Download a random article ...";
            this.downloadARandomArticleToolStripMenuItem.Click += new System.EventHandler(this.DownloadARandomArticleToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 600);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(933, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(16, 17);
            this.StatusStripLabel.Text = "...";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.ImageList;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(933, 576);
            this.TabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RichTextBoxArticleBody);
            this.tabPage1.Controls.Add(this.LblBody);
            this.tabPage1.Controls.Add(this.TxtBoxArticleTitle);
            this.tabPage1.Controls.Add(this.LblTitle);
            this.tabPage1.Controls.Add(this.GroupBoxArticleOptions);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor   ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxArticleBody
            // 
            this.RichTextBoxArticleBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxArticleBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RichTextBoxArticleBody.ContextMenuStrip = this.ContextMenuStrip;
            this.RichTextBoxArticleBody.Location = new System.Drawing.Point(11, 168);
            this.RichTextBoxArticleBody.Name = "RichTextBoxArticleBody";
            this.RichTextBoxArticleBody.Size = new System.Drawing.Size(906, 374);
            this.RichTextBoxArticleBody.TabIndex = 4;
            this.RichTextBoxArticleBody.Text = "";
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTextToTheClipboardToolStripMenuItem,
            this.PasteTextFromTheClipboard});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(240, 48);
            // 
            // CopyTextToTheClipboardToolStripMenuItem
            // 
            this.CopyTextToTheClipboardToolStripMenuItem.Name = "CopyTextToTheClipboardToolStripMenuItem";
            this.CopyTextToTheClipboardToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.CopyTextToTheClipboardToolStripMenuItem.Text = "Copy text to the clipboard ...";
            this.CopyTextToTheClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyTextToTheClipboardToolStripMenuItem_Click);
            // 
            // PasteTextFromTheClipboard
            // 
            this.PasteTextFromTheClipboard.Name = "PasteTextFromTheClipboard";
            this.PasteTextFromTheClipboard.Size = new System.Drawing.Size(239, 22);
            this.PasteTextFromTheClipboard.Text = "Paste text from the clipboard ...";
            this.PasteTextFromTheClipboard.Click += new System.EventHandler(this.PasteTextFromTheClipboard_Click);
            // 
            // LblBody
            // 
            this.LblBody.AutoSize = true;
            this.LblBody.Location = new System.Drawing.Point(8, 150);
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(41, 15);
            this.LblBody.TabIndex = 3;
            this.LblBody.Text = "BODY:";
            // 
            // TxtBoxArticleTitle
            // 
            this.TxtBoxArticleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxArticleTitle.Location = new System.Drawing.Point(11, 124);
            this.TxtBoxArticleTitle.Name = "TxtBoxArticleTitle";
            this.TxtBoxArticleTitle.Size = new System.Drawing.Size(906, 23);
            this.TxtBoxArticleTitle.TabIndex = 2;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(8, 106);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(38, 15);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "TITLE:";
            // 
            // GroupBoxArticleOptions
            // 
            this.GroupBoxArticleOptions.Controls.Add(this.ChkBoxRandomizeParagraphs);
            this.GroupBoxArticleOptions.Controls.Add(this.BtnExportArticle);
            this.GroupBoxArticleOptions.Controls.Add(this.BtnSpin);
            this.GroupBoxArticleOptions.Controls.Add(this.LblKeywords);
            this.GroupBoxArticleOptions.Controls.Add(this.BtnSourceArticleContent);
            this.GroupBoxArticleOptions.Controls.Add(this.TxtBoxKeyword);
            this.GroupBoxArticleOptions.Controls.Add(this.Source2);
            this.GroupBoxArticleOptions.Controls.Add(this.Source1);
            this.GroupBoxArticleOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxArticleOptions.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxArticleOptions.Name = "GroupBoxArticleOptions";
            this.GroupBoxArticleOptions.Size = new System.Drawing.Size(919, 100);
            this.GroupBoxArticleOptions.TabIndex = 0;
            this.GroupBoxArticleOptions.TabStop = false;
            this.GroupBoxArticleOptions.Text = "Options:";
            // 
            // BtnExportArticle
            // 
            this.BtnExportArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportArticle.Location = new System.Drawing.Point(675, 14);
            this.BtnExportArticle.Name = "BtnExportArticle";
            this.BtnExportArticle.Size = new System.Drawing.Size(75, 25);
            this.BtnExportArticle.TabIndex = 6;
            this.BtnExportArticle.Text = "Export";
            this.BtnExportArticle.UseVisualStyleBackColor = true;
            this.BtnExportArticle.Click += new System.EventHandler(this.BtnExportArticle_Click);
            // 
            // BtnSpin
            // 
            this.BtnSpin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSpin.ForeColor = System.Drawing.Color.Green;
            this.BtnSpin.Location = new System.Drawing.Point(754, 14);
            this.BtnSpin.Name = "BtnSpin";
            this.BtnSpin.Size = new System.Drawing.Size(75, 25);
            this.BtnSpin.TabIndex = 5;
            this.BtnSpin.Text = "Spin {|}";
            this.BtnSpin.UseVisualStyleBackColor = true;
            this.BtnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // LblKeywords
            // 
            this.LblKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblKeywords.AutoSize = true;
            this.LblKeywords.Location = new System.Drawing.Point(596, 47);
            this.LblKeywords.Name = "LblKeywords";
            this.LblKeywords.Size = new System.Drawing.Size(73, 15);
            this.LblKeywords.TabIndex = 4;
            this.LblKeywords.Text = "Keyword(s):";
            // 
            // BtnSourceArticleContent
            // 
            this.BtnSourceArticleContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSourceArticleContent.Location = new System.Drawing.Point(833, 14);
            this.BtnSourceArticleContent.Name = "BtnSourceArticleContent";
            this.BtnSourceArticleContent.Size = new System.Drawing.Size(75, 25);
            this.BtnSourceArticleContent.TabIndex = 3;
            this.BtnSourceArticleContent.Text = "Source";
            this.BtnSourceArticleContent.UseVisualStyleBackColor = true;
            // 
            // TxtBoxKeyword
            // 
            this.TxtBoxKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxKeyword.Location = new System.Drawing.Point(675, 44);
            this.TxtBoxKeyword.Name = "TxtBoxKeyword";
            this.TxtBoxKeyword.Size = new System.Drawing.Size(233, 23);
            this.TxtBoxKeyword.TabIndex = 2;
            // 
            // Source2
            // 
            this.Source2.AutoSize = true;
            this.Source2.Location = new System.Drawing.Point(20, 56);
            this.Source2.Name = "Source2";
            this.Source2.Size = new System.Drawing.Size(131, 19);
            this.Source2.TabIndex = 1;
            this.Source2.Text = "Source article via AI";
            this.Source2.UseVisualStyleBackColor = true;
            // 
            // Source1
            // 
            this.Source1.AutoSize = true;
            this.Source1.Checked = true;
            this.Source1.Location = new System.Drawing.Point(20, 31);
            this.Source1.Name = "Source1";
            this.Source1.Size = new System.Drawing.Size(160, 19);
            this.Source1.TabIndex = 0;
            this.Source1.TabStop = true;
            this.Source1.Text = "Source article via scraper";
            this.Source1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGridSynonymsView);
            this.tabPage2.Controls.Add(this.GroupBoxSynonymOptions);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Synonyms   ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridSynonymsView
            // 
            this.DataGridSynonymsView.AllowUserToAddRows = false;
            this.DataGridSynonymsView.AllowUserToDeleteRows = false;
            this.DataGridSynonymsView.AllowUserToOrderColumns = true;
            this.DataGridSynonymsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSynonymsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSynEntry,
            this.colSynEdit,
            this.colSynCheckBox});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSynonymsView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSynonymsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridSynonymsView.Location = new System.Drawing.Point(3, 103);
            this.DataGridSynonymsView.Name = "DataGridSynonymsView";
            this.DataGridSynonymsView.RowHeadersVisible = false;
            this.DataGridSynonymsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridSynonymsView.Size = new System.Drawing.Size(919, 442);
            this.DataGridSynonymsView.TabIndex = 1;
            // 
            // colSynEntry
            // 
            this.colSynEntry.HeaderText = "Entry";
            this.colSynEntry.Name = "colSynEntry";
            this.colSynEntry.Width = 600;
            // 
            // colSynEdit
            // 
            this.colSynEdit.HeaderText = "Edit";
            this.colSynEdit.Name = "colSynEdit";
            this.colSynEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSynEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSynEdit.Text = "Edit";
            this.colSynEdit.ToolTipText = "Edit";
            this.colSynEdit.UseColumnTextForButtonValue = true;
            // 
            // colSynCheckBox
            // 
            this.colSynCheckBox.HeaderText = "";
            this.colSynCheckBox.Name = "colSynCheckBox";
            this.colSynCheckBox.Width = 30;
            // 
            // GroupBoxSynonymOptions
            // 
            this.GroupBoxSynonymOptions.Controls.Add(this.BtnLoadSynonymsFile);
            this.GroupBoxSynonymOptions.Controls.Add(this.ComboBoxSynonymFile);
            this.GroupBoxSynonymOptions.Controls.Add(this.LblSelectSynonymsFile);
            this.GroupBoxSynonymOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxSynonymOptions.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxSynonymOptions.Name = "GroupBoxSynonymOptions";
            this.GroupBoxSynonymOptions.Size = new System.Drawing.Size(919, 100);
            this.GroupBoxSynonymOptions.TabIndex = 0;
            this.GroupBoxSynonymOptions.TabStop = false;
            this.GroupBoxSynonymOptions.Text = "Options:";
            // 
            // BtnLoadSynonymsFile
            // 
            this.BtnLoadSynonymsFile.Location = new System.Drawing.Point(428, 35);
            this.BtnLoadSynonymsFile.Name = "BtnLoadSynonymsFile";
            this.BtnLoadSynonymsFile.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadSynonymsFile.TabIndex = 2;
            this.BtnLoadSynonymsFile.Text = "Load";
            this.BtnLoadSynonymsFile.UseVisualStyleBackColor = true;
            this.BtnLoadSynonymsFile.Click += new System.EventHandler(this.BtnLoadSynonymsFile_Click);
            // 
            // ComboBoxSynonymFile
            // 
            this.ComboBoxSynonymFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSynonymFile.FormattingEnabled = true;
            this.ComboBoxSynonymFile.Location = new System.Drawing.Point(146, 35);
            this.ComboBoxSynonymFile.Name = "ComboBoxSynonymFile";
            this.ComboBoxSynonymFile.Size = new System.Drawing.Size(277, 23);
            this.ComboBoxSynonymFile.TabIndex = 1;
            // 
            // LblSelectSynonymsFile
            // 
            this.LblSelectSynonymsFile.AutoSize = true;
            this.LblSelectSynonymsFile.Location = new System.Drawing.Point(20, 38);
            this.LblSelectSynonymsFile.Name = "LblSelectSynonymsFile";
            this.LblSelectSynonymsFile.Size = new System.Drawing.Size(124, 15);
            this.LblSelectSynonymsFile.TabIndex = 0;
            this.LblSelectSynonymsFile.Text = "Select Synonyms File:";
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "ico-editor.png");
            this.ImageList.Images.SetKeyName(1, "ico-synonyms.png");
            // 
            // BackgroundWorkerImportSynonymsFile
            // 
            this.BackgroundWorkerImportSynonymsFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerImportSynonymsFile_DoWork);
            this.BackgroundWorkerImportSynonymsFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerImportSynonymsFile_RunWorkerCompleted);
            // 
            // BackgroundWorkerSpinTax
            // 
            this.BackgroundWorkerSpinTax.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerSpinTax_DoWork);
            this.BackgroundWorkerSpinTax.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerSpinTax_RunWorkerCompleted);
            // 
            // ChkBoxRandomizeParagraphs
            // 
            this.ChkBoxRandomizeParagraphs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkBoxRandomizeParagraphs.AutoSize = true;
            this.ChkBoxRandomizeParagraphs.Location = new System.Drawing.Point(759, 73);
            this.ChkBoxRandomizeParagraphs.Name = "ChkBoxRandomizeParagraphs";
            this.ChkBoxRandomizeParagraphs.Size = new System.Drawing.Size(149, 19);
            this.ChkBoxRandomizeParagraphs.TabIndex = 7;
            this.ChkBoxRandomizeParagraphs.Text = "Randomize paragraphs";
            this.ChkBoxRandomizeParagraphs.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 622);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GM Content Creator - graham23s@hotmail.com";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            this.GroupBoxArticleOptions.ResumeLayout(false);
            this.GroupBoxArticleOptions.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSynonymsView)).EndInit();
            this.GroupBoxSynonymOptions.ResumeLayout(false);
            this.GroupBoxSynonymOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox RichTextBoxArticleBody;
        private System.Windows.Forms.Label LblBody;
        private System.Windows.Forms.TextBox TxtBoxArticleTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GroupBoxArticleOptions;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridSynonymsView;
        private System.Windows.Forms.GroupBox GroupBoxSynonymOptions;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
        private System.Windows.Forms.RadioButton Source2;
        private System.Windows.Forms.RadioButton Source1;
        private System.Windows.Forms.Button BtnSourceArticleContent;
        private System.Windows.Forms.TextBox TxtBoxKeyword;
        private System.Windows.Forms.ComboBox ComboBoxSynonymFile;
        private System.Windows.Forms.Label LblSelectSynonymsFile;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerImportSynonymsFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSynEntry;
        private System.Windows.Forms.DataGridViewButtonColumn colSynEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSynCheckBox;
        private System.Windows.Forms.Label LblKeywords;
        private System.Windows.Forms.Button BtnSpin;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadARandomArticleToolStripMenuItem;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button BtnLoadSynonymsFile;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerSpinTax;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyTextToTheClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteTextFromTheClipboard;
        private System.Windows.Forms.Button BtnExportArticle;
        private System.Windows.Forms.CheckBox ChkBoxRandomizeParagraphs;
    }
}