namespace cmdwtf.Dithering.Example
{
  partial class AboutDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.nameLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.webLinkLabelCmdWtf = new System.Windows.Forms.LinkLabel();
			this.closeButton = new System.Windows.Forms.Button();
			this.ossLinkLabel = new System.Windows.Forms.LinkLabel();
			this.webLinkLabelCyotek = new System.Windows.Forms.LinkLabel();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.nameLabel.Location = new System.Drawing.Point(14, 10);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(61, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "AppName";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(14, 25);
			this.copyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(60, 15);
			this.copyrightLabel.TabIndex = 1;
			this.copyrightLabel.Text = "Copyright";
			// 
			// webLinkLabelCmdWtf
			// 
			this.webLinkLabelCmdWtf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.webLinkLabelCmdWtf.AutoSize = true;
			this.webLinkLabelCmdWtf.Location = new System.Drawing.Point(14, 269);
			this.webLinkLabelCmdWtf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.webLinkLabelCmdWtf.Name = "webLinkLabelCmdWtf";
			this.webLinkLabelCmdWtf.Size = new System.Drawing.Size(91, 15);
			this.webLinkLabelCmdWtf.TabIndex = 2;
			this.webLinkLabelCmdWtf.TabStop = true;
			this.webLinkLabelCmdWtf.Tag = "https://cmd.wtf";
			this.webLinkLabelCmdWtf.Text = "https://cmd.wtf";
			this.webLinkLabelCmdWtf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webLinkLabel_LinkClicked);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(490, 263);
			this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(88, 27);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// ossLinkLabel
			// 
			this.ossLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ossLinkLabel.Location = new System.Drawing.Point(14, 81);
			this.ossLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ossLinkLabel.Name = "ossLinkLabel";
			this.ossLinkLabel.Size = new System.Drawing.Size(564, 179);
			this.ossLinkLabel.TabIndex = 4;
			this.ossLinkLabel.TabStop = true;
			this.ossLinkLabel.Text = resources.GetString("ossLinkLabel.Text");
			this.ossLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ossLinkLabel_LinkClicked);
			// 
			// webLinkLabelCyotek
			// 
			this.webLinkLabelCyotek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.webLinkLabelCyotek.AutoSize = true;
			this.webLinkLabelCyotek.Location = new System.Drawing.Point(108, 269);
			this.webLinkLabelCyotek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.webLinkLabelCyotek.Name = "webLinkLabelCyotek";
			this.webLinkLabelCyotek.Size = new System.Drawing.Size(139, 15);
			this.webLinkLabelCyotek.TabIndex = 2;
			this.webLinkLabelCyotek.TabStop = true;
			this.webLinkLabelCyotek.Tag = "https://www.cyotek.com";
			this.webLinkLabelCyotek.Text = "https://www.cyotek.com";
			this.webLinkLabelCyotek.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webLinkLabel_LinkClicked);
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(14, 40);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
			this.descriptionLabel.TabIndex = 1;
			this.descriptionLabel.Text = "Description";
			// 
			// AboutDialog
			// 
			this.AcceptButton = this.closeButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(592, 303);
			this.Controls.Add(this.ossLinkLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.webLinkLabelCyotek);
			this.Controls.Add(this.webLinkLabelCmdWtf);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.nameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label copyrightLabel;
    private System.Windows.Forms.LinkLabel webLinkLabelCmdWtf;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.LinkLabel ossLinkLabel;
		private System.Windows.Forms.LinkLabel webLinkLabelCyotek;
		private System.Windows.Forms.Label descriptionLabel;
	}
}
