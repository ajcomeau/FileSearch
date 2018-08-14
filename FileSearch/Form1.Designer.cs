namespace FileSearch
{
    partial class Form1
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
            this.fbdSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentFolder = new System.Windows.Forms.Label();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(12, 56);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(316, 20);
            this.txtFolder.TabIndex = 0;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(9, 40);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 1;
            this.lblFolder.Text = "Folder:";
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Location = new System.Drawing.Point(334, 54);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(87, 23);
            this.btnSelFolder.TabIndex = 2;
            this.btnSelFolder.Text = "Select Folder";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.btnSelFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "*.*";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Results:  (Double-click on row to open folder in Windows Explorer.)";
            // 
            // lblCurrentFolder
            // 
            this.lblCurrentFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentFolder.AutoSize = true;
            this.lblCurrentFolder.Location = new System.Drawing.Point(9, 325);
            this.lblCurrentFolder.Name = "lblCurrentFolder";
            this.lblCurrentFolder.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentFolder.TabIndex = 8;
            // 
            // dgFiles
            // 
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Location = new System.Drawing.Point(12, 143);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.ReadOnly = true;
            this.dgFiles.Size = new System.Drawing.Size(440, 178);
            this.dgFiles.TabIndex = 9;
            this.dgFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFiles_CellDoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(480, 24);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 362);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.lblCurrentFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "File Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSelect;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnSelFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentFolder;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

