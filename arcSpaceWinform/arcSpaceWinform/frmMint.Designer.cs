namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmMint
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMint));
         this.txtMintName = new System.Windows.Forms.TextBox();
         this.txtMintLocation = new System.Windows.Forms.TextBox();
         this.lblMintName = new System.Windows.Forms.Label();
         this.lblLocation = new System.Windows.Forms.Label();
         this.txtServiceStartYear = new System.Windows.Forms.TextBox();
         this.lblServiceStartYear = new System.Windows.Forms.Label();
         this.txtServiceEndYear = new System.Windows.Forms.TextBox();
         this.lblServiceStopYear = new System.Windows.Forms.Label();
         this.txtAbbreviations = new System.Windows.Forms.TextBox();
         this.lblAbbreviations = new System.Windows.Forms.Label();
         this.bnvMint = new System.Windows.Forms.BindingNavigator(this.components);
         this.bnvAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bnvCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bnvDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bnvFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bnvPreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bnvPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bnvNextItem = new System.Windows.Forms.ToolStripButton();
         this.bnvLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.btnCancelRecord = new System.Windows.Forms.Button();
         this.btnSaveRecord = new System.Windows.Forms.Button();
         this.lblDescription = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.bnvMint)).BeginInit();
         this.bnvMint.SuspendLayout();
         this.SuspendLayout();
         // 
         // txtMintName
         // 
         this.txtMintName.Location = new System.Drawing.Point(170, 43);
         this.txtMintName.Name = "txtMintName";
         this.txtMintName.Size = new System.Drawing.Size(217, 20);
         this.txtMintName.TabIndex = 0;
         // 
         // txtMintLocation
         // 
         this.txtMintLocation.Location = new System.Drawing.Point(170, 175);
         this.txtMintLocation.Name = "txtMintLocation";
         this.txtMintLocation.Size = new System.Drawing.Size(217, 20);
         this.txtMintLocation.TabIndex = 2;
         // 
         // lblMintName
         // 
         this.lblMintName.AutoSize = true;
         this.lblMintName.Location = new System.Drawing.Point(113, 47);
         this.lblMintName.Name = "lblMintName";
         this.lblMintName.Size = new System.Drawing.Size(38, 13);
         this.lblMintName.TabIndex = 2;
         this.lblMintName.Text = "Name:";
         // 
         // lblLocation
         // 
         this.lblLocation.AutoSize = true;
         this.lblLocation.Location = new System.Drawing.Point(100, 176);
         this.lblLocation.Name = "lblLocation";
         this.lblLocation.Size = new System.Drawing.Size(51, 13);
         this.lblLocation.TabIndex = 3;
         this.lblLocation.Text = "Location:";
         // 
         // txtServiceStartYear
         // 
         this.txtServiceStartYear.Location = new System.Drawing.Point(170, 219);
         this.txtServiceStartYear.Name = "txtServiceStartYear";
         this.txtServiceStartYear.Size = new System.Drawing.Size(84, 20);
         this.txtServiceStartYear.TabIndex = 3;
         // 
         // lblServiceStartYear
         // 
         this.lblServiceStartYear.AutoSize = true;
         this.lblServiceStartYear.Location = new System.Drawing.Point(55, 222);
         this.lblServiceStartYear.Name = "lblServiceStartYear";
         this.lblServiceStartYear.Size = new System.Drawing.Size(96, 13);
         this.lblServiceStartYear.TabIndex = 5;
         this.lblServiceStartYear.Text = "Service Start Year:";
         this.lblServiceStartYear.Click += new System.EventHandler(this.lblServiceStartYear_Click);
         // 
         // txtServiceEndYear
         // 
         this.txtServiceEndYear.Location = new System.Drawing.Point(170, 263);
         this.txtServiceEndYear.Name = "txtServiceEndYear";
         this.txtServiceEndYear.Size = new System.Drawing.Size(84, 20);
         this.txtServiceEndYear.TabIndex = 4;
         // 
         // lblServiceStopYear
         // 
         this.lblServiceStopYear.AutoSize = true;
         this.lblServiceStopYear.Location = new System.Drawing.Point(55, 268);
         this.lblServiceStopYear.Name = "lblServiceStopYear";
         this.lblServiceStopYear.Size = new System.Drawing.Size(96, 13);
         this.lblServiceStopYear.TabIndex = 7;
         this.lblServiceStopYear.Text = "Service Stop Year:";
         // 
         // txtAbbreviations
         // 
         this.txtAbbreviations.Location = new System.Drawing.Point(170, 307);
         this.txtAbbreviations.Name = "txtAbbreviations";
         this.txtAbbreviations.Size = new System.Drawing.Size(207, 20);
         this.txtAbbreviations.TabIndex = 5;
         // 
         // lblAbbreviations
         // 
         this.lblAbbreviations.AutoSize = true;
         this.lblAbbreviations.Location = new System.Drawing.Point(77, 313);
         this.lblAbbreviations.Name = "lblAbbreviations";
         this.lblAbbreviations.Size = new System.Drawing.Size(74, 13);
         this.lblAbbreviations.TabIndex = 9;
         this.lblAbbreviations.Text = "Abbreviations:";
         // 
         // bnvMint
         // 
         this.bnvMint.AddNewItem = this.bnvAddNewItem;
         this.bnvMint.CountItem = this.bnvCountItem;
         this.bnvMint.DeleteItem = this.bnvDeleteItem;
         this.bnvMint.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.bnvMint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnvFirstItem,
            this.bnvPreviousItem,
            this.bindingNavigatorSeparator,
            this.bnvPositionItem,
            this.bnvCountItem,
            this.bindingNavigatorSeparator1,
            this.bnvNextItem,
            this.bnvLastItem,
            this.bindingNavigatorSeparator2,
            this.bnvAddNewItem,
            this.bnvDeleteItem});
         this.bnvMint.Location = new System.Drawing.Point(0, 375);
         this.bnvMint.MoveFirstItem = this.bnvFirstItem;
         this.bnvMint.MoveLastItem = this.bnvLastItem;
         this.bnvMint.MoveNextItem = this.bnvNextItem;
         this.bnvMint.MovePreviousItem = this.bnvPreviousItem;
         this.bnvMint.Name = "bnvMint";
         this.bnvMint.PositionItem = this.bnvPositionItem;
         this.bnvMint.Size = new System.Drawing.Size(614, 25);
         this.bnvMint.TabIndex = 22;
         this.bnvMint.Text = "bindingNavigator1";
         // 
         // bnvAddNewItem
         // 
         this.bnvAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bnvAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bnvAddNewItem.Image")));
         this.bnvAddNewItem.Name = "bnvAddNewItem";
         this.bnvAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bnvAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bnvAddNewItem.Text = "Add new";
         this.bnvAddNewItem.Click += new System.EventHandler(this.bnvAddNewItem_Click);
         // 
         // bnvCountItem
         // 
         this.bnvCountItem.Name = "bnvCountItem";
         this.bnvCountItem.Size = new System.Drawing.Size(35, 22);
         this.bnvCountItem.Text = "of {0}";
         this.bnvCountItem.ToolTipText = "Total number of items";
         // 
         // bnvDeleteItem
         // 
         this.bnvDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bnvDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bnvDeleteItem.Image")));
         this.bnvDeleteItem.Name = "bnvDeleteItem";
         this.bnvDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bnvDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bnvDeleteItem.Text = "Delete";
         this.bnvDeleteItem.Click += new System.EventHandler(this.bnvDeleteItem_Click);
         // 
         // bnvFirstItem
         // 
         this.bnvFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bnvFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bnvFirstItem.Image")));
         this.bnvFirstItem.Name = "bnvFirstItem";
         this.bnvFirstItem.RightToLeftAutoMirrorImage = true;
         this.bnvFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bnvFirstItem.Text = "Move first";
         this.bnvFirstItem.Click += new System.EventHandler(this.bnvFirstItem_Click);
         // 
         // bnvPreviousItem
         // 
         this.bnvPreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bnvPreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bnvPreviousItem.Image")));
         this.bnvPreviousItem.Name = "bnvPreviousItem";
         this.bnvPreviousItem.RightToLeftAutoMirrorImage = true;
         this.bnvPreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bnvPreviousItem.Text = "Move previous";
         this.bnvPreviousItem.Click += new System.EventHandler(this.bnvPreviousItem_Click);
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bnvPositionItem
         // 
         this.bnvPositionItem.AccessibleName = "Position";
         this.bnvPositionItem.AutoSize = false;
         this.bnvPositionItem.Name = "bnvPositionItem";
         this.bnvPositionItem.Size = new System.Drawing.Size(50, 23);
         this.bnvPositionItem.Text = "0";
         this.bnvPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bnvNextItem
         // 
         this.bnvNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bnvNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bnvNextItem.Image")));
         this.bnvNextItem.Name = "bnvNextItem";
         this.bnvNextItem.RightToLeftAutoMirrorImage = true;
         this.bnvNextItem.Size = new System.Drawing.Size(23, 22);
         this.bnvNextItem.Text = "Move next";
         this.bnvNextItem.Click += new System.EventHandler(this.bnvNextItem_Click);
         // 
         // bnvLastItem
         // 
         this.bnvLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bnvLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bnvLastItem.Image")));
         this.bnvLastItem.Name = "bnvLastItem";
         this.bnvLastItem.RightToLeftAutoMirrorImage = true;
         this.bnvLastItem.Size = new System.Drawing.Size(23, 22);
         this.bnvLastItem.Text = "Move last";
         this.bnvLastItem.Click += new System.EventHandler(this.bnvLastItem_Click);
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // btnCancelRecord
         // 
         this.btnCancelRecord.Location = new System.Drawing.Point(516, 336);
         this.btnCancelRecord.Name = "btnCancelRecord";
         this.btnCancelRecord.Size = new System.Drawing.Size(75, 23);
         this.btnCancelRecord.TabIndex = 7;
         this.btnCancelRecord.Text = "Cancel";
         this.btnCancelRecord.UseVisualStyleBackColor = true;
         this.btnCancelRecord.Click += new System.EventHandler(this.btnCancelRecord_Click);
         // 
         // btnSaveRecord
         // 
         this.btnSaveRecord.Location = new System.Drawing.Point(435, 336);
         this.btnSaveRecord.Name = "btnSaveRecord";
         this.btnSaveRecord.Size = new System.Drawing.Size(75, 23);
         this.btnSaveRecord.TabIndex = 6;
         this.btnSaveRecord.Text = "Save";
         this.btnSaveRecord.UseVisualStyleBackColor = true;
         this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
         // 
         // lblDescription
         // 
         this.lblDescription.AutoSize = true;
         this.lblDescription.Location = new System.Drawing.Point(88, 88);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.Size = new System.Drawing.Size(63, 13);
         this.lblDescription.TabIndex = 26;
         this.lblDescription.Text = "Description:";
         // 
         // txtDescription
         // 
         this.txtDescription.Location = new System.Drawing.Point(170, 87);
         this.txtDescription.Multiline = true;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(217, 64);
         this.txtDescription.TabIndex = 1;
         // 
         // frmMint
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(614, 400);
         this.Controls.Add(this.lblDescription);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.btnCancelRecord);
         this.Controls.Add(this.btnSaveRecord);
         this.Controls.Add(this.bnvMint);
         this.Controls.Add(this.lblAbbreviations);
         this.Controls.Add(this.txtAbbreviations);
         this.Controls.Add(this.lblServiceStopYear);
         this.Controls.Add(this.txtServiceEndYear);
         this.Controls.Add(this.lblServiceStartYear);
         this.Controls.Add(this.txtServiceStartYear);
         this.Controls.Add(this.lblLocation);
         this.Controls.Add(this.lblMintName);
         this.Controls.Add(this.txtMintLocation);
         this.Controls.Add(this.txtMintName);
         this.Name = "frmMint";
         this.Text = "Mint";
         this.Load += new System.EventHandler(this.frmMint_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bnvMint)).EndInit();
         this.bnvMint.ResumeLayout(false);
         this.bnvMint.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtMintName;
      private System.Windows.Forms.TextBox txtMintLocation;
      private System.Windows.Forms.Label lblMintName;
      private System.Windows.Forms.Label lblLocation;
      private System.Windows.Forms.TextBox txtServiceStartYear;
      private System.Windows.Forms.Label lblServiceStartYear;
      private System.Windows.Forms.TextBox txtServiceEndYear;
      private System.Windows.Forms.Label lblServiceStopYear;
      private System.Windows.Forms.TextBox txtAbbreviations;
      private System.Windows.Forms.Label lblAbbreviations;
      private System.Windows.Forms.BindingNavigator bnvMint;
      private System.Windows.Forms.ToolStripButton bnvAddNewItem;
      private System.Windows.Forms.ToolStripLabel bnvCountItem;
      private System.Windows.Forms.ToolStripButton bnvDeleteItem;
      private System.Windows.Forms.ToolStripButton bnvFirstItem;
      private System.Windows.Forms.ToolStripButton bnvPreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bnvPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bnvNextItem;
      private System.Windows.Forms.ToolStripButton bnvLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.Button btnCancelRecord;
      private System.Windows.Forms.Button btnSaveRecord;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.TextBox txtDescription;
   }
}