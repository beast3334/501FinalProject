namespace _501FinalProject
{
    partial class uxUserInterface
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
            this.uxFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kSISFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxReloadButton = new System.Windows.Forms.Button();
            this.uxClearButton = new System.Windows.Forms.Button();
            this.utxLocalLabel = new System.Windows.Forms.Label();
            this.uxLocalFileTextbox = new System.Windows.Forms.TextBox();
            this.uxKSISTextBox = new System.Windows.Forms.TextBox();
            this.utxKSISLabel = new System.Windows.Forms.Label();
            this.uxOutputTextbox = new System.Windows.Forms.TextBox();
            this.uxopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileMenu,
            this.uxAboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxFileMenu
            // 
            this.uxFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.uxFileMenu.Name = "uxFileMenu";
            this.uxFileMenu.Size = new System.Drawing.Size(37, 20);
            this.uxFileMenu.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localFileToolStripMenuItem,
            this.kSISFileToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // localFileToolStripMenuItem
            // 
            this.localFileToolStripMenuItem.Name = "localFileToolStripMenuItem";
            this.localFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localFileToolStripMenuItem.Text = "Local File";
            this.localFileToolStripMenuItem.Click += new System.EventHandler(this.localFileToolStripMenuItem_Click);
            // 
            // kSISFileToolStripMenuItem
            // 
            this.kSISFileToolStripMenuItem.Name = "kSISFileToolStripMenuItem";
            this.kSISFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kSISFileToolStripMenuItem.Text = "KSIS File";
            this.kSISFileToolStripMenuItem.Click += new System.EventHandler(this.kSISFileToolStripMenuItem_Click);
            // 
            // uxAboutMenu
            // 
            this.uxAboutMenu.Name = "uxAboutMenu";
            this.uxAboutMenu.Size = new System.Drawing.Size(52, 20);
            this.uxAboutMenu.Text = "About";
            this.uxAboutMenu.Click += new System.EventHandler(this.uxAboutMenu_Click);
            // 
            // uxReloadButton
            // 
            this.uxReloadButton.Location = new System.Drawing.Point(413, 1);
            this.uxReloadButton.Name = "uxReloadButton";
            this.uxReloadButton.Size = new System.Drawing.Size(85, 23);
            this.uxReloadButton.TabIndex = 1;
            this.uxReloadButton.Text = "Reload";
            this.uxReloadButton.UseVisualStyleBackColor = true;
            // 
            // uxClearButton
            // 
            this.uxClearButton.Location = new System.Drawing.Point(504, 1);
            this.uxClearButton.Name = "uxClearButton";
            this.uxClearButton.Size = new System.Drawing.Size(85, 23);
            this.uxClearButton.TabIndex = 2;
            this.uxClearButton.Text = "Clear";
            this.uxClearButton.UseVisualStyleBackColor = true;
            // 
            // utxLocalLabel
            // 
            this.utxLocalLabel.AutoSize = true;
            this.utxLocalLabel.Location = new System.Drawing.Point(11, 37);
            this.utxLocalLabel.Name = "utxLocalLabel";
            this.utxLocalLabel.Size = new System.Drawing.Size(36, 13);
            this.utxLocalLabel.TabIndex = 3;
            this.utxLocalLabel.Text = "Local:";
            // 
            // uxLocalFileTextbox
            // 
            this.uxLocalFileTextbox.Location = new System.Drawing.Point(53, 33);
            this.uxLocalFileTextbox.Name = "uxLocalFileTextbox";
            this.uxLocalFileTextbox.ReadOnly = true;
            this.uxLocalFileTextbox.Size = new System.Drawing.Size(196, 20);
            this.uxLocalFileTextbox.TabIndex = 4;
            // 
            // uxKSISTextBox
            // 
            this.uxKSISTextBox.Location = new System.Drawing.Point(377, 30);
            this.uxKSISTextBox.Name = "uxKSISTextBox";
            this.uxKSISTextBox.ReadOnly = true;
            this.uxKSISTextBox.Size = new System.Drawing.Size(196, 20);
            this.uxKSISTextBox.TabIndex = 6;
            // 
            // utxKSISLabel
            // 
            this.utxKSISLabel.AutoSize = true;
            this.utxKSISLabel.Location = new System.Drawing.Point(335, 33);
            this.utxKSISLabel.Name = "utxKSISLabel";
            this.utxKSISLabel.Size = new System.Drawing.Size(34, 13);
            this.utxKSISLabel.TabIndex = 5;
            this.utxKSISLabel.Text = "KSIS:";
            // 
            // uxOutputTextbox
            // 
            this.uxOutputTextbox.Location = new System.Drawing.Point(14, 70);
            this.uxOutputTextbox.Multiline = true;
            this.uxOutputTextbox.Name = "uxOutputTextbox";
            this.uxOutputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxOutputTextbox.Size = new System.Drawing.Size(559, 318);
            this.uxOutputTextbox.TabIndex = 7;
            // 
            // uxopenFileDialog
            // 
            this.uxopenFileDialog.FileName = "openFileDialog";
            // 
            // uxUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 400);
            this.Controls.Add(this.uxOutputTextbox);
            this.Controls.Add(this.uxKSISTextBox);
            this.Controls.Add(this.utxKSISLabel);
            this.Controls.Add(this.uxLocalFileTextbox);
            this.Controls.Add(this.utxLocalLabel);
            this.Controls.Add(this.uxClearButton);
            this.Controls.Add(this.uxReloadButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "uxUserInterface";
            this.Text = "Scheduler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxFileMenu;
        private System.Windows.Forms.ToolStripMenuItem uxAboutMenu;
        private System.Windows.Forms.Button uxReloadButton;
        private System.Windows.Forms.Button uxClearButton;
        private System.Windows.Forms.Label utxLocalLabel;
        private System.Windows.Forms.TextBox uxLocalFileTextbox;
        private System.Windows.Forms.TextBox uxKSISTextBox;
        private System.Windows.Forms.Label utxKSISLabel;
        private System.Windows.Forms.TextBox uxOutputTextbox;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog uxopenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem localFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kSISFileToolStripMenuItem;
    }
}

