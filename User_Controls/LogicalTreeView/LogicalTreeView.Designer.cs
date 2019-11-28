namespace bcs.LogicalTree
{
    partial class LogicalTreeView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.ltvLogicalTreeView = new System.Windows.Forms.TreeView();
         this.SuspendLayout();
         // 
         // ltvLogicalTreeView
         // 
         this.ltvLogicalTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ltvLogicalTreeView.Location = new System.Drawing.Point(0, 0);
         this.ltvLogicalTreeView.Name = "ltvLogicalTreeView";
         this.ltvLogicalTreeView.Size = new System.Drawing.Size(263, 615);
         this.ltvLogicalTreeView.TabIndex = 0;
         // 
         // bcs.LogicalTree
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.ltvLogicalTreeView);
         this.Name = "bcs.LogicalTree";
         this.Size = new System.Drawing.Size(263, 615);
         this.ResumeLayout(false);

        }

      #endregion

      private System.Windows.Forms.TreeView ltvLogicalTreeView;
   }
}
