namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmCoinTypeMaintenance
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoinTypeMaintenance));
         this.bnvCoinTypeMaintenance = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.label1 = new System.Windows.Forms.Label();
         this.lblCoinType = new System.Windows.Forms.Label();
         this.txtCoinTypeDesc = new System.Windows.Forms.TextBox();
         this.txtCoinType = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.bnvCoinTypeMaintenance)).BeginInit();
         this.bnvCoinTypeMaintenance.SuspendLayout();
         this.SuspendLayout();
         // 
         // bnvCoinTypeMaintenance
         // 
         this.bnvCoinTypeMaintenance.AddNewItem = this.bnvAddNewItem;
         this.bnvCoinTypeMaintenance.CountItem = this.bnvCountItem;
         this.bnvCoinTypeMaintenance.DeleteItem = this.bnvDeleteItem;
         this.bnvCoinTypeMaintenance.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.bnvCoinTypeMaintenance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.bnvCoinTypeMaintenance.Location = new System.Drawing.Point(0, 250);
         this.bnvCoinTypeMaintenance.MoveFirstItem = this.bnvFirstItem;
         this.bnvCoinTypeMaintenance.MoveLastItem = this.bnvLastItem;
         this.bnvCoinTypeMaintenance.MoveNextItem = this.bnvNextItem;
         this.bnvCoinTypeMaintenance.MovePreviousItem = this.bnvPreviousItem;
         this.bnvCoinTypeMaintenance.Name = "bnvCoinTypeMaintenance";
         this.bnvCoinTypeMaintenance.PositionItem = this.bnvPositionItem;
         this.bnvCoinTypeMaintenance.Size = new System.Drawing.Size(439, 25);
         this.bnvCoinTypeMaintenance.TabIndex = 21;
         this.bnvCoinTypeMaintenance.Text = "bindingNavigator1";
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
         this.btnCancelRecord.Location = new System.Drawing.Point(349, 213);
         this.btnCancelRecord.Name = "btnCancelRecord";
         this.btnCancelRecord.Size = new System.Drawing.Size(75, 23);
         this.btnCancelRecord.TabIndex = 20;
         this.btnCancelRecord.Text = "Cancel";
         this.btnCancelRecord.UseVisualStyleBackColor = true;
         this.btnCancelRecord.Click += new System.EventHandler(this.btnCancelRecord_Click);
         // 
         // btnSaveRecord
         // 
         this.btnSaveRecord.Location = new System.Drawing.Point(268, 213);
         this.btnSaveRecord.Name = "btnSaveRecord";
         this.btnSaveRecord.Size = new System.Drawing.Size(75, 23);
         this.btnSaveRecord.TabIndex = 19;
         this.btnSaveRecord.Text = "Save";
         this.btnSaveRecord.UseVisualStyleBackColor = true;
         this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(38, 65);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(63, 13);
         this.label1.TabIndex = 18;
         this.label1.Text = "Description:";
         // 
         // lblCoinType
         // 
         this.lblCoinType.AutoSize = true;
         this.lblCoinType.Location = new System.Drawing.Point(38, 18);
         this.lblCoinType.Name = "lblCoinType";
         this.lblCoinType.Size = new System.Drawing.Size(58, 13);
         this.lblCoinType.TabIndex = 17;
         this.lblCoinType.Text = "Coin Type:";
         // 
         // txtCoinTypeDesc
         // 
         this.txtCoinTypeDesc.Location = new System.Drawing.Point(112, 65);
         this.txtCoinTypeDesc.Multiline = true;
         this.txtCoinTypeDesc.Name = "txtCoinTypeDesc";
         this.txtCoinTypeDesc.Size = new System.Drawing.Size(188, 103);
         this.txtCoinTypeDesc.TabIndex = 16;
         // 
         // txtCoinType
         // 
         this.txtCoinType.Location = new System.Drawing.Point(112, 15);
         this.txtCoinType.Name = "txtCoinType";
         this.txtCoinType.Size = new System.Drawing.Size(188, 20);
         this.txtCoinType.TabIndex = 15;
         // 
         // frmCoinTypeMaintenance
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(439, 275);
         this.Controls.Add(this.bnvCoinTypeMaintenance);
         this.Controls.Add(this.btnCancelRecord);
         this.Controls.Add(this.btnSaveRecord);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lblCoinType);
         this.Controls.Add(this.txtCoinTypeDesc);
         this.Controls.Add(this.txtCoinType);
         this.Name = "frmCoinTypeMaintenance";
         this.Text = "Coin Type";
         this.Load += new System.EventHandler(this.frmCoinTypeMaintenance_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bnvCoinTypeMaintenance)).EndInit();
         this.bnvCoinTypeMaintenance.ResumeLayout(false);
         this.bnvCoinTypeMaintenance.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingNavigator bnvCoinTypeMaintenance;
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
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblCoinType;
      private System.Windows.Forms.TextBox txtCoinTypeDesc;
      private System.Windows.Forms.TextBox txtCoinType;
   }
}