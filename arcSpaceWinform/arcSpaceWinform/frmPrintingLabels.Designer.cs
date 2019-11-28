namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmPrintingLabels
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
         this.pgbPrintingLabels = new System.Windows.Forms.ProgressBar();
         this.lblPrintingLabelAlert = new System.Windows.Forms.Label();
         this.lblLblSpreadsheetName = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.lblStatus = new System.Windows.Forms.Label();
         this.lblStatusMessage = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // pgbPrintingLabels
         // 
         this.pgbPrintingLabels.Location = new System.Drawing.Point(26, 126);
         this.pgbPrintingLabels.Name = "pgbPrintingLabels";
         this.pgbPrintingLabels.Size = new System.Drawing.Size(461, 23);
         this.pgbPrintingLabels.TabIndex = 0;
         this.pgbPrintingLabels.Click += new System.EventHandler(this.pgbPrintingLabels_Click);
         // 
         // lblPrintingLabelAlert
         // 
         this.lblPrintingLabelAlert.AutoSize = true;
         this.lblPrintingLabelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPrintingLabelAlert.Location = new System.Drawing.Point(136, 18);
         this.lblPrintingLabelAlert.Name = "lblPrintingLabelAlert";
         this.lblPrintingLabelAlert.Size = new System.Drawing.Size(128, 20);
         this.lblPrintingLabelAlert.TabIndex = 1;
         this.lblPrintingLabelAlert.Text = "Printing Labels";
         this.lblPrintingLabelAlert.Click += new System.EventHandler(this.label1_Click);
         // 
         // lblLblSpreadsheetName
         // 
         this.lblLblSpreadsheetName.AutoSize = true;
         this.lblLblSpreadsheetName.Location = new System.Drawing.Point(23, 69);
         this.lblLblSpreadsheetName.Name = "lblLblSpreadsheetName";
         this.lblLblSpreadsheetName.Size = new System.Drawing.Size(130, 13);
         this.lblLblSpreadsheetName.TabIndex = 2;
         this.lblLblSpreadsheetName.Text = "Excel Spreadsheet Name:";
         this.lblLblSpreadsheetName.Click += new System.EventHandler(this.lblLblSpreadsheetName_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(161, 66);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(255, 20);
         this.textBox1.TabIndex = 3;
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(314, 173);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(398, 173);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 5;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         // 
         // lblStatus
         // 
         this.lblStatus.AutoSize = true;
         this.lblStatus.Location = new System.Drawing.Point(19, 178);
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(40, 13);
         this.lblStatus.TabIndex = 6;
         this.lblStatus.Text = "Status:";
         // 
         // lblStatusMessage
         // 
         this.lblStatusMessage.AutoSize = true;
         this.lblStatusMessage.Location = new System.Drawing.Point(74, 178);
         this.lblStatusMessage.Name = "lblStatusMessage";
         this.lblStatusMessage.Size = new System.Drawing.Size(19, 13);
         this.lblStatusMessage.TabIndex = 7;
         this.lblStatusMessage.Text = "    ";
         // 
         // frmPrintingLabels
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(499, 217);
         this.Controls.Add(this.lblStatusMessage);
         this.Controls.Add(this.lblStatus);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.lblLblSpreadsheetName);
         this.Controls.Add(this.lblPrintingLabelAlert);
         this.Controls.Add(this.pgbPrintingLabels);
         this.Name = "frmPrintingLabels";
         this.Text = "frmPrintingLabels";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ProgressBar pgbPrintingLabels;
      private System.Windows.Forms.Label lblPrintingLabelAlert;
      private System.Windows.Forms.Label lblLblSpreadsheetName;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.Label lblStatusMessage;
   }
}