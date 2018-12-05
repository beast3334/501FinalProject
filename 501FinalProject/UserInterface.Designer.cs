namespace _501FinalProject
{
    partial class UserInterface
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
            this.ux_menuStrip = new System.Windows.Forms.MenuStrip();
            this.ux_fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ux_localFilePath = new System.Windows.Forms.TextBox();
            this.ux_localLabel = new System.Windows.Forms.Label();
            this.ux_KSISFilePath = new System.Windows.Forms.TextBox();
            this.ux_KSISLabel = new System.Windows.Forms.Label();
            this.ux_reloadButton = new System.Windows.Forms.Button();
            this.ux_clearButton = new System.Windows.Forms.Button();
            this.ux_output = new System.Windows.Forms.TextBox();
            this.ux_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_menuStrip
            // 
            this.ux_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ux_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ux_fileMenuItem,
            this.ux_aboutMenuItem});
            this.ux_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.ux_menuStrip.Name = "ux_menuStrip";
            this.ux_menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ux_menuStrip.Size = new System.Drawing.Size(370, 24);
            this.ux_menuStrip.TabIndex = 0;
            this.ux_menuStrip.Text = "menuStrip1";
            // 
            // ux_fileMenuItem
            // 
            this.ux_fileMenuItem.Name = "ux_fileMenuItem";
            this.ux_fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ux_fileMenuItem.Text = "File";
            // 
            // ux_aboutMenuItem
            // 
            this.ux_aboutMenuItem.Name = "ux_aboutMenuItem";
            this.ux_aboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ux_aboutMenuItem.Text = "About";
            // 
            // ux_localFilePath
            // 
            this.ux_localFilePath.Location = new System.Drawing.Point(48, 28);
            this.ux_localFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.ux_localFilePath.Name = "ux_localFilePath";
            this.ux_localFilePath.Size = new System.Drawing.Size(131, 20);
            this.ux_localFilePath.TabIndex = 1;
            // 
            // ux_localLabel
            // 
            this.ux_localLabel.AutoSize = true;
            this.ux_localLabel.Location = new System.Drawing.Point(9, 31);
            this.ux_localLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ux_localLabel.Name = "ux_localLabel";
            this.ux_localLabel.Size = new System.Drawing.Size(36, 13);
            this.ux_localLabel.TabIndex = 2;
            this.ux_localLabel.Text = "Local:";
            // 
            // ux_KSISFilePath
            // 
            this.ux_KSISFilePath.Location = new System.Drawing.Point(215, 28);
            this.ux_KSISFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.ux_KSISFilePath.Name = "ux_KSISFilePath";
            this.ux_KSISFilePath.Size = new System.Drawing.Size(144, 20);
            this.ux_KSISFilePath.TabIndex = 3;
            // 
            // ux_KSISLabel
            // 
            this.ux_KSISLabel.AutoSize = true;
            this.ux_KSISLabel.Location = new System.Drawing.Point(181, 31);
            this.ux_KSISLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ux_KSISLabel.Name = "ux_KSISLabel";
            this.ux_KSISLabel.Size = new System.Drawing.Size(34, 13);
            this.ux_KSISLabel.TabIndex = 4;
            this.ux_KSISLabel.Text = "KSIS:";
            // 
            // ux_reloadButton
            // 
            this.ux_reloadButton.Location = new System.Drawing.Point(219, 4);
            this.ux_reloadButton.Margin = new System.Windows.Forms.Padding(2);
            this.ux_reloadButton.Name = "ux_reloadButton";
            this.ux_reloadButton.Size = new System.Drawing.Size(73, 19);
            this.ux_reloadButton.TabIndex = 5;
            this.ux_reloadButton.Text = "Reload";
            this.ux_reloadButton.UseVisualStyleBackColor = true;
            // 
            // ux_clearButton
            // 
            this.ux_clearButton.Location = new System.Drawing.Point(296, 4);
            this.ux_clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ux_clearButton.Name = "ux_clearButton";
            this.ux_clearButton.Size = new System.Drawing.Size(65, 19);
            this.ux_clearButton.TabIndex = 6;
            this.ux_clearButton.Text = "Clear";
            this.ux_clearButton.UseVisualStyleBackColor = true;
            // 
            // ux_output
            // 
            this.ux_output.Location = new System.Drawing.Point(0, 52);
            this.ux_output.Margin = new System.Windows.Forms.Padding(2);
            this.ux_output.Multiline = true;
            this.ux_output.Name = "ux_output";
            this.ux_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ux_output.Size = new System.Drawing.Size(370, 193);
            this.ux_output.TabIndex = 7;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 245);
            this.Controls.Add(this.ux_output);
            this.Controls.Add(this.ux_clearButton);
            this.Controls.Add(this.ux_reloadButton);
            this.Controls.Add(this.ux_KSISLabel);
            this.Controls.Add(this.ux_KSISFilePath);
            this.Controls.Add(this.ux_localLabel);
            this.Controls.Add(this.ux_localFilePath);
            this.Controls.Add(this.ux_menuStrip);
            this.MainMenuStrip = this.ux_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInterface";
            this.Text = "Scheduler";
            this.ux_menuStrip.ResumeLayout(false);
            this.ux_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ux_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ux_fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ux_aboutMenuItem;
        private System.Windows.Forms.TextBox ux_localFilePath;
        private System.Windows.Forms.Label ux_localLabel;
        private System.Windows.Forms.TextBox ux_KSISFilePath;
        private System.Windows.Forms.Label ux_KSISLabel;
        private System.Windows.Forms.Button ux_reloadButton;
        private System.Windows.Forms.Button ux_clearButton;
        private System.Windows.Forms.TextBox ux_output;
    }
}

