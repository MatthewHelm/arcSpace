namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmArcPeriod
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArcPeriod));
         this.bnvArcPeriod = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.lblArcPeriodName = new System.Windows.Forms.Label();
         this.lblArcPeriodDescription = new System.Windows.Forms.Label();
         this.txtArcPeriodDescription = new System.Windows.Forms.TextBox();
         this.txtArcPeriodName = new System.Windows.Forms.TextBox();
         this.txtStartYear = new System.Windows.Forms.TextBox();
         this.txtEndYear = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.cmbStartPeriodYearEra = new System.Windows.Forms.ComboBox();
         this.cmbEndPeriodYearEra = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bnvArcPeriod)).BeginInit();
         this.bnvArcPeriod.SuspendLayout();
         this.SuspendLayout();
         // 
         // bnvArcPeriod
         // 
         this.bnvArcPeriod.AddNewItem = this.bindingNavigatorAddNewItem;
         this.bnvArcPeriod.CountItem = this.bindingNavigatorCountItem;
         this.bnvArcPeriod.DeleteItem = this.bindingNavigatorDeleteItem;
         this.bnvArcPeriod.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.bnvArcPeriod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.bnvArcPeriod.Location = new System.Drawing.Point(0, 306);
         this.bnvArcPeriod.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.bnvArcPeriod.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.bnvArcPeriod.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.bnvArcPeriod.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.bnvArcPeriod.Name = "bnvArcPeriod";
         this.bnvArcPeriod.PositionItem = this.bindingNavigatorPositionItem;
         this.bnvArcPeriod.Size = new System.Drawing.Size(460, 25);
         this.bnvArcPeriod.TabIndex = 0;
         this.bnvArcPeriod.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
         this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(278, 270);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(360, 270);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 2;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // lblArcPeriodName
         // 
         this.lblArcPeriodName.AutoSize = true;
         this.lblArcPeriodName.Location = new System.Drawing.Point(15, 31);
         this.lblArcPeriodName.Name = "lblArcPeriodName";
         this.lblArcPeriodName.Size = new System.Drawing.Size(74, 13);
         this.lblArcPeriodName.TabIndex = 3;
         this.lblArcPeriodName.Text = "Period_Name:";
         // 
         // lblArcPeriodDescription
         // 
         this.lblArcPeriodDescription.AutoSize = true;
         this.lblArcPeriodDescription.Location = new System.Drawing.Point(27, 135);
         this.lblArcPeriodDescription.Name = "lblArcPeriodDescription";
         this.lblArcPeriodDescription.Size = new System.Drawing.Size(63, 13);
         this.lblArcPeriodDescription.TabIndex = 4;
         this.lblArcPeriodDescription.Text = "Description:";
         // 
         // txtArcPeriodDescription
         // 
         this.txtArcPeriodDescription.Location = new System.Drawing.Point(106, 135);
         this.txtArcPeriodDescription.Multiline = true;
         this.txtArcPeriodDescription.Name = "txtArcPeriodDescription";
         this.txtArcPeriodDescription.Size = new System.Drawing.Size(329, 106);
         this.txtArcPeriodDescription.TabIndex = 5;
         // 
         // txtArcPeriodName
         // 
         this.txtArcPeriodName.Location = new System.Drawing.Point(106, 28);
         this.txtArcPeriodName.Name = "txtArcPeriodName";
         this.txtArcPeriodName.Size = new System.Drawing.Size(247, 20);
         this.txtArcPeriodName.TabIndex = 6;
         // 
         // txtStartYear
         // 
         this.txtStartYear.Location = new System.Drawing.Point(106, 75);
         this.txtStartYear.Name = "txtStartYear";
         this.txtStartYear.Size = new System.Drawing.Size(50, 20);
         this.txtStartYear.TabIndex = 7;
         // 
         // txtEndYear
         // 
         this.txtEndYear.Location = new System.Drawing.Point(106, 99);
         this.txtEndYear.Name = "txtEndYear";
         this.txtEndYear.Size = new System.Drawing.Size(50, 20);
         this.txtEndYear.TabIndex = 8;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(61, 101);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(29, 13);
         this.label1.TabIndex = 9;
         this.label1.Text = "End:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(58, 75);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(32, 13);
         this.label2.TabIndex = 10;
         this.label2.Text = "Start:";
         this.label2.Click += new System.EventHandler(this.label2_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(105, 58);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(68, 13);
         this.label3.TabIndex = 11;
         this.label3.Text = "Time Interval";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // cmbStartPeriodYearEra
         // 
         this.cmbStartPeriodYearEra.FormattingEnabled = true;
         this.cmbStartPeriodYearEra.Location = new System.Drawing.Point(157, 75);
         this.cmbStartPeriodYearEra.Name = "cmbStartPeriodYearEra";
         this.cmbStartPeriodYearEra.Size = new System.Drawing.Size(52, 21);
         this.cmbStartPeriodYearEra.TabIndex = 12;
         // 
         // cmbEndPeriodYearEra
         // 
         this.cmbEndPeriodYearEra.FormattingEnabled = true;
         this.cmbEndPeriodYearEra.Location = new System.Drawing.Point(157, 99);
         this.cmbEndPeriodYearEra.Name = "cmbEndPeriodYearEra";
         this.cmbEndPeriodYearEra.Size = new System.Drawing.Size(52, 21);
         this.cmbEndPeriodYearEra.TabIndex = 13;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(19, 31);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(71, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "Period Name:";
         this.label4.Click += new System.EventHandler(this.label4_Click);
         // 
         // frmArcPeriod
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(460, 331);
         this.Controls.Add(this.cmbEndPeriodYearEra);
         this.Controls.Add(this.cmbStartPeriodYearEra);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtEndYear);
         this.Controls.Add(this.txtStartYear);
         this.Controls.Add(this.txtArcPeriodName);
         this.Controls.Add(this.txtArcPeriodDescription);
         this.Controls.Add(this.lblArcPeriodDescription);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.lblArcPeriodName);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.bnvArcPeriod);
         this.Name = "frmArcPeriod";
         this.Text = "frmArcPeriod";
         this.Load += new System.EventHandler(this.frmArcPeriod_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bnvArcPeriod)).EndInit();
         this.bnvArcPeriod.ResumeLayout(false);
         this.bnvArcPeriod.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingNavigator bnvArcPeriod;
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
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label lblArcPeriodName;
      private System.Windows.Forms.Label lblArcPeriodDescription;
      private System.Windows.Forms.TextBox txtArcPeriodDescription;
      private System.Windows.Forms.TextBox txtArcPeriodName;
      private System.Windows.Forms.TextBox txtStartYear;
      private System.Windows.Forms.TextBox txtEndYear;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cmbStartPeriodYearEra;
      private System.Windows.Forms.ComboBox cmbEndPeriodYearEra;
      private System.Windows.Forms.Label label4;
   }
}