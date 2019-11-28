namespace bcs.arcSpace.arcSpaceWinform
{
    partial class frmHistoricalPerspective
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
            this.btnClose = new System.Windows.Forms.Button();
            this.spltHistoricalPerspective = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spltHistoricalPerspective)).BeginInit();
            this.spltHistoricalPerspective.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(633, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // spltHistoricalPerspective
            // 
            this.spltHistoricalPerspective.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltHistoricalPerspective.Location = new System.Drawing.Point(0, 0);
            this.spltHistoricalPerspective.Name = "spltHistoricalPerspective";
            this.spltHistoricalPerspective.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.spltHistoricalPerspective.Size = new System.Drawing.Size(730, 378);
            this.spltHistoricalPerspective.SplitterDistance = 176;
            this.spltHistoricalPerspective.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 46);
            this.panel1.TabIndex = 2;
            // 
            // frmHistoricalPerspective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spltHistoricalPerspective);
            this.Name = "frmHistoricalPerspective";
            this.Text = "frmHistoricalPerspective";
            ((System.ComponentModel.ISupportInitialize)(this.spltHistoricalPerspective)).EndInit();
            this.spltHistoricalPerspective.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer spltHistoricalPerspective;
        private System.Windows.Forms.Panel panel1;
    }
}