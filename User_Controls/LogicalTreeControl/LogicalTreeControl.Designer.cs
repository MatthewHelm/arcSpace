namespace bcs.LogicalTree
{
    partial class LogicalTreeControl 
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogicalTreeControl));
         this.bnvLogicalTreeBinder = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.spcLogicalTreeContainer = new System.Windows.Forms.SplitContainer();
         this.ltvLogicalTreeView = new bcs.LogicalTree.LogicalTreeView();
         this.dgvLogicalTreeGrid = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.bnvLogicalTreeBinder)).BeginInit();
         this.bnvLogicalTreeBinder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spcLogicalTreeContainer)).BeginInit();
         this.spcLogicalTreeContainer.Panel1.SuspendLayout();
         this.spcLogicalTreeContainer.Panel2.SuspendLayout();
         this.spcLogicalTreeContainer.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvLogicalTreeGrid)).BeginInit();
         this.SuspendLayout();
         // 
         // bnvLogicalTreeBinder
         // 
         this.bnvLogicalTreeBinder.AddNewItem = this.bindingNavigatorAddNewItem;
         this.bnvLogicalTreeBinder.CountItem = this.bindingNavigatorCountItem;
         this.bnvLogicalTreeBinder.DeleteItem = this.bindingNavigatorDeleteItem;
         this.bnvLogicalTreeBinder.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.bnvLogicalTreeBinder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
         this.bnvLogicalTreeBinder.Location = new System.Drawing.Point(0, 591);
         this.bnvLogicalTreeBinder.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.bnvLogicalTreeBinder.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.bnvLogicalTreeBinder.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.bnvLogicalTreeBinder.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.bnvLogicalTreeBinder.Name = "bnvLogicalTreeBinder";
         this.bnvLogicalTreeBinder.PositionItem = this.bindingNavigatorPositionItem;
         this.bnvLogicalTreeBinder.Size = new System.Drawing.Size(1306, 25);
         this.bnvLogicalTreeBinder.TabIndex = 0;
         this.bnvLogicalTreeBinder.Text = "bindingNavigator1";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // spcLogicalTreeContainer
         // 
         this.spcLogicalTreeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.spcLogicalTreeContainer.Location = new System.Drawing.Point(0, 0);
         this.spcLogicalTreeContainer.Name = "spcLogicalTreeContainer";
         // 
         // spcLogicalTreeContainer.Panel1
         // 
         this.spcLogicalTreeContainer.Panel1.Controls.Add(this.ltvLogicalTreeView);
         // 
         // spcLogicalTreeContainer.Panel2
         // 
         this.spcLogicalTreeContainer.Panel2.Controls.Add(this.dgvLogicalTreeGrid);
         this.spcLogicalTreeContainer.Size = new System.Drawing.Size(1306, 591);
         this.spcLogicalTreeContainer.SplitterDistance = 250;
         this.spcLogicalTreeContainer.TabIndex = 1;
         // 
         // ltvLogicalTreeView
         // 
         this.ltvLogicalTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ltvLogicalTreeView.Location = new System.Drawing.Point(0, 0);
         this.ltvLogicalTreeView.Name = "ltvLogicalTreeView";
         this.ltvLogicalTreeView.Size = new System.Drawing.Size(250, 591);
         this.ltvLogicalTreeView.TabIndex = 0;
         // 
         // dgvLogicalTreeGrid
         // 
         this.dgvLogicalTreeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvLogicalTreeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvLogicalTreeGrid.Location = new System.Drawing.Point(0, 0);
         this.dgvLogicalTreeGrid.Name = "dgvLogicalTreeGrid";
         this.dgvLogicalTreeGrid.Size = new System.Drawing.Size(1052, 591);
         this.dgvLogicalTreeGrid.TabIndex = 0;
         // 
         // LogicalTreeControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.spcLogicalTreeContainer);
         this.Controls.Add(this.bnvLogicalTreeBinder);
         this.Name = "LogicalTreeControl";
         this.Size = new System.Drawing.Size(1306, 616);
         ((System.ComponentModel.ISupportInitialize)(this.bnvLogicalTreeBinder)).EndInit();
         this.bnvLogicalTreeBinder.ResumeLayout(false);
         this.bnvLogicalTreeBinder.PerformLayout();
         this.spcLogicalTreeContainer.Panel1.ResumeLayout(false);
         this.spcLogicalTreeContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.spcLogicalTreeContainer)).EndInit();
         this.spcLogicalTreeContainer.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvLogicalTreeGrid)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.BindingNavigator bnvLogicalTreeBinder;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.SplitContainer spcLogicalTreeContainer;
      private LogicalTreeView ltvLogicalTreeView;
      private System.Windows.Forms.DataGridView dgvLogicalTreeGrid;
   }
}
