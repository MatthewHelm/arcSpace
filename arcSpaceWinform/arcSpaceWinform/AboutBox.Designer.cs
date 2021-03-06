﻿namespace bcs.arcSpace.arcSpaceWinform
{
   partial class AboutBox1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
         this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
         this.logoPictureBox = new System.Windows.Forms.PictureBox();
         this.labelProductName = new System.Windows.Forms.Label();
         this.applicationLabelVersion = new System.Windows.Forms.Label();
         this.applicationLabelCopyright = new System.Windows.Forms.Label();
         this.labelCompanyName = new System.Windows.Forms.Label();
         this.txtApplicationDescription = new System.Windows.Forms.TextBox();
         this.okButton = new System.Windows.Forms.Button();
         this.tableLayoutPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel
         // 
         this.tableLayoutPanel.ColumnCount = 2;
         this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.11511F));
         this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.88489F));
         this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
         this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
         this.tableLayoutPanel.Controls.Add(this.applicationLabelVersion, 1, 1);
         this.tableLayoutPanel.Controls.Add(this.applicationLabelCopyright, 1, 2);
         this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
         this.tableLayoutPanel.Controls.Add(this.txtApplicationDescription, 1, 4);
         this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
         this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
         this.tableLayoutPanel.Name = "tableLayoutPanel";
         this.tableLayoutPanel.RowCount = 6;
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel.Size = new System.Drawing.Size(451, 258);
         this.tableLayoutPanel.TabIndex = 0;
         // 
         // logoPictureBox
         // 
         this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
         this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
         this.logoPictureBox.Name = "logoPictureBox";
         this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
         this.logoPictureBox.Size = new System.Drawing.Size(247, 252);
         this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.logoPictureBox.TabIndex = 12;
         this.logoPictureBox.TabStop = false;
         // 
         // labelProductName
         // 
         this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelProductName.Location = new System.Drawing.Point(259, 0);
         this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
         this.labelProductName.Name = "labelProductName";
         this.labelProductName.Size = new System.Drawing.Size(189, 17);
         this.labelProductName.TabIndex = 19;
         this.labelProductName.Text = "Ancient Roman Coins Application";
         this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
         // 
         // applicationLabelVersion
         // 
         this.applicationLabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
         this.applicationLabelVersion.Location = new System.Drawing.Point(259, 25);
         this.applicationLabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.applicationLabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
         this.applicationLabelVersion.Name = "applicationLabelVersion";
         this.applicationLabelVersion.Size = new System.Drawing.Size(189, 17);
         this.applicationLabelVersion.TabIndex = 0;
         this.applicationLabelVersion.Text = "1.0";
         this.applicationLabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // applicationLabelCopyright
         // 
         this.applicationLabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
         this.applicationLabelCopyright.Location = new System.Drawing.Point(259, 50);
         this.applicationLabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.applicationLabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
         this.applicationLabelCopyright.Name = "applicationLabelCopyright";
         this.applicationLabelCopyright.Size = new System.Drawing.Size(189, 17);
         this.applicationLabelCopyright.TabIndex = 21;
         this.applicationLabelCopyright.Text = "Copyright 2018";
         this.applicationLabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelCompanyName
         // 
         this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelCompanyName.Location = new System.Drawing.Point(259, 75);
         this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
         this.labelCompanyName.Name = "labelCompanyName";
         this.labelCompanyName.Size = new System.Drawing.Size(189, 17);
         this.labelCompanyName.TabIndex = 22;
         this.labelCompanyName.Text = "Brandywine Creek Software";
         this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtApplicationDescription
         // 
         this.txtApplicationDescription.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtApplicationDescription.Location = new System.Drawing.Point(259, 103);
         this.txtApplicationDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.txtApplicationDescription.Multiline = true;
         this.txtApplicationDescription.Name = "txtApplicationDescription";
         this.txtApplicationDescription.ReadOnly = true;
         this.txtApplicationDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtApplicationDescription.Size = new System.Drawing.Size(189, 123);
         this.txtApplicationDescription.TabIndex = 23;
         this.txtApplicationDescription.TabStop = false;
         this.txtApplicationDescription.Text = "Description";
         // 
         // okButton
         // 
         this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.okButton.Location = new System.Drawing.Point(373, 232);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 23);
         this.okButton.TabIndex = 24;
         this.okButton.Text = "&OK";
         // 
         // AboutBox1
         // 
         this.AcceptButton = this.okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(469, 276);
         this.Controls.Add(this.tableLayoutPanel);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AboutBox1";
         this.Padding = new System.Windows.Forms.Padding(9);
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Ancient Roman Coins";
         this.tableLayoutPanel.ResumeLayout(false);
         this.tableLayoutPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
      private System.Windows.Forms.PictureBox logoPictureBox;
      private System.Windows.Forms.Label labelProductName;
      private System.Windows.Forms.Label applicationLabelVersion;
      private System.Windows.Forms.Label applicationLabelCopyright;
      private System.Windows.Forms.Label labelCompanyName;
      private System.Windows.Forms.TextBox txtApplicationDescription;
      private System.Windows.Forms.Button okButton;
   }
}
