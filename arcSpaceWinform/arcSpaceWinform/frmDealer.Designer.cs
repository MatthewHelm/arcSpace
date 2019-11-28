namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmDealer
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDealer));
         this.bnvDealer = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.txtFirstName = new System.Windows.Forms.TextBox();
         this.txtLastName = new System.Windows.Forms.TextBox();
         this.txtAddress1 = new System.Windows.Forms.TextBox();
         this.txtAddress2 = new System.Windows.Forms.TextBox();
         this.txtCity = new System.Windows.Forms.TextBox();
         this.txtPostalCode = new System.Windows.Forms.TextBox();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtWebSite = new System.Windows.Forms.TextBox();
         this.txtBusinessName = new System.Windows.Forms.TextBox();
         this.lblFirstName = new System.Windows.Forms.Label();
         this.lblLastName = new System.Windows.Forms.Label();
         this.lblBusinessName = new System.Windows.Forms.Label();
         this.lblAddress1 = new System.Windows.Forms.Label();
         this.lblAddress2 = new System.Windows.Forms.Label();
         this.lblCity = new System.Windows.Forms.Label();
         this.lblStateProvince = new System.Windows.Forms.Label();
         this.lblCountry = new System.Windows.Forms.Label();
         this.lblPostalCode = new System.Windows.Forms.Label();
         this.lblEmail = new System.Windows.Forms.Label();
         this.lblWebSite = new System.Windows.Forms.Label();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.txtNotes = new System.Windows.Forms.TextBox();
         this.lblNotes = new System.Windows.Forms.Label();
         this.cmbStateProvince = new System.Windows.Forms.ComboBox();
         this.cmbCountry = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.bnvDealer)).BeginInit();
         this.bnvDealer.SuspendLayout();
         this.SuspendLayout();
         // 
         // bnvDealer
         // 
         this.bnvDealer.AddNewItem = this.bindingNavigatorAddNewItem;
         this.bnvDealer.CountItem = this.bindingNavigatorCountItem;
         this.bnvDealer.DeleteItem = this.bindingNavigatorDeleteItem;
         this.bnvDealer.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.bnvDealer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.bnvDealer.Location = new System.Drawing.Point(0, 555);
         this.bnvDealer.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.bnvDealer.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.bnvDealer.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.bnvDealer.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.bnvDealer.Name = "bnvDealer";
         this.bnvDealer.PositionItem = this.bindingNavigatorPositionItem;
         this.bnvDealer.Size = new System.Drawing.Size(853, 25);
         this.bnvDealer.TabIndex = 0;
         this.bnvDealer.Text = "bindingNavigator1";
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
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // txtFirstName
         // 
         this.txtFirstName.Location = new System.Drawing.Point(140, 35);
         this.txtFirstName.Name = "txtFirstName";
         this.txtFirstName.Size = new System.Drawing.Size(178, 20);
         this.txtFirstName.TabIndex = 1;
         // 
         // txtLastName
         // 
         this.txtLastName.Location = new System.Drawing.Point(140, 71);
         this.txtLastName.Name = "txtLastName";
         this.txtLastName.Size = new System.Drawing.Size(245, 20);
         this.txtLastName.TabIndex = 2;
         // 
         // txtAddress1
         // 
         this.txtAddress1.Location = new System.Drawing.Point(140, 143);
         this.txtAddress1.Name = "txtAddress1";
         this.txtAddress1.Size = new System.Drawing.Size(439, 20);
         this.txtAddress1.TabIndex = 3;
         // 
         // txtAddress2
         // 
         this.txtAddress2.Location = new System.Drawing.Point(140, 179);
         this.txtAddress2.Name = "txtAddress2";
         this.txtAddress2.Size = new System.Drawing.Size(439, 20);
         this.txtAddress2.TabIndex = 4;
         // 
         // txtCity
         // 
         this.txtCity.Location = new System.Drawing.Point(140, 215);
         this.txtCity.Name = "txtCity";
         this.txtCity.Size = new System.Drawing.Size(245, 20);
         this.txtCity.TabIndex = 5;
         // 
         // txtPostalCode
         // 
         this.txtPostalCode.Location = new System.Drawing.Point(140, 287);
         this.txtPostalCode.Name = "txtPostalCode";
         this.txtPostalCode.Size = new System.Drawing.Size(245, 20);
         this.txtPostalCode.TabIndex = 8;
         // 
         // txtEmail
         // 
         this.txtEmail.Location = new System.Drawing.Point(140, 359);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(178, 20);
         this.txtEmail.TabIndex = 9;
         // 
         // txtWebSite
         // 
         this.txtWebSite.Location = new System.Drawing.Point(140, 395);
         this.txtWebSite.Name = "txtWebSite";
         this.txtWebSite.Size = new System.Drawing.Size(377, 20);
         this.txtWebSite.TabIndex = 10;
         // 
         // txtBusinessName
         // 
         this.txtBusinessName.Location = new System.Drawing.Point(140, 107);
         this.txtBusinessName.Name = "txtBusinessName";
         this.txtBusinessName.Size = new System.Drawing.Size(331, 20);
         this.txtBusinessName.TabIndex = 11;
         // 
         // lblFirstName
         // 
         this.lblFirstName.AutoSize = true;
         this.lblFirstName.Location = new System.Drawing.Point(74, 38);
         this.lblFirstName.Name = "lblFirstName";
         this.lblFirstName.Size = new System.Drawing.Size(60, 13);
         this.lblFirstName.TabIndex = 12;
         this.lblFirstName.Text = "First Name:";
         // 
         // lblLastName
         // 
         this.lblLastName.AutoSize = true;
         this.lblLastName.Location = new System.Drawing.Point(73, 74);
         this.lblLastName.Name = "lblLastName";
         this.lblLastName.Size = new System.Drawing.Size(61, 13);
         this.lblLastName.TabIndex = 13;
         this.lblLastName.Text = "Last Name:";
         // 
         // lblBusinessName
         // 
         this.lblBusinessName.AutoSize = true;
         this.lblBusinessName.Location = new System.Drawing.Point(51, 109);
         this.lblBusinessName.Name = "lblBusinessName";
         this.lblBusinessName.Size = new System.Drawing.Size(83, 13);
         this.lblBusinessName.TabIndex = 14;
         this.lblBusinessName.Text = "Business Name:";
         // 
         // lblAddress1
         // 
         this.lblAddress1.AutoSize = true;
         this.lblAddress1.Location = new System.Drawing.Point(41, 145);
         this.lblAddress1.Name = "lblAddress1";
         this.lblAddress1.Size = new System.Drawing.Size(93, 13);
         this.lblAddress1.TabIndex = 15;
         this.lblAddress1.Text = "Address First Line:";
         // 
         // lblAddress2
         // 
         this.lblAddress2.AutoSize = true;
         this.lblAddress2.Location = new System.Drawing.Point(23, 181);
         this.lblAddress2.Name = "lblAddress2";
         this.lblAddress2.Size = new System.Drawing.Size(111, 13);
         this.lblAddress2.TabIndex = 16;
         this.lblAddress2.Text = "Address Second Line:";
         // 
         // lblCity
         // 
         this.lblCity.AutoSize = true;
         this.lblCity.Location = new System.Drawing.Point(107, 217);
         this.lblCity.Name = "lblCity";
         this.lblCity.Size = new System.Drawing.Size(27, 13);
         this.lblCity.TabIndex = 17;
         this.lblCity.Text = "City:";
         // 
         // lblStateProvince
         // 
         this.lblStateProvince.AutoSize = true;
         this.lblStateProvince.Location = new System.Drawing.Point(52, 253);
         this.lblStateProvince.Name = "lblStateProvince";
         this.lblStateProvince.Size = new System.Drawing.Size(82, 13);
         this.lblStateProvince.TabIndex = 18;
         this.lblStateProvince.Text = "State/Province:";
         // 
         // lblCountry
         // 
         this.lblCountry.AutoSize = true;
         this.lblCountry.Location = new System.Drawing.Point(88, 326);
         this.lblCountry.Name = "lblCountry";
         this.lblCountry.Size = new System.Drawing.Size(46, 13);
         this.lblCountry.TabIndex = 19;
         this.lblCountry.Text = "Country:";
         // 
         // lblPostalCode
         // 
         this.lblPostalCode.AutoSize = true;
         this.lblPostalCode.Location = new System.Drawing.Point(67, 290);
         this.lblPostalCode.Name = "lblPostalCode";
         this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
         this.lblPostalCode.TabIndex = 20;
         this.lblPostalCode.Text = "Postal Code:";
         // 
         // lblEmail
         // 
         this.lblEmail.AutoSize = true;
         this.lblEmail.Location = new System.Drawing.Point(58, 361);
         this.lblEmail.Name = "lblEmail";
         this.lblEmail.Size = new System.Drawing.Size(76, 13);
         this.lblEmail.TabIndex = 21;
         this.lblEmail.Text = "Email Address:";
         // 
         // lblWebSite
         // 
         this.lblWebSite.AutoSize = true;
         this.lblWebSite.Location = new System.Drawing.Point(80, 397);
         this.lblWebSite.Name = "lblWebSite";
         this.lblWebSite.Size = new System.Drawing.Size(54, 13);
         this.lblWebSite.TabIndex = 22;
         this.lblWebSite.Text = "Web Site:";
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(642, 510);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 23;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(738, 510);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 24;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // txtNotes
         // 
         this.txtNotes.Location = new System.Drawing.Point(140, 435);
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.Size = new System.Drawing.Size(377, 98);
         this.txtNotes.TabIndex = 25;
         // 
         // lblNotes
         // 
         this.lblNotes.AutoSize = true;
         this.lblNotes.Location = new System.Drawing.Point(80, 438);
         this.lblNotes.Name = "lblNotes";
         this.lblNotes.Size = new System.Drawing.Size(38, 13);
         this.lblNotes.TabIndex = 26;
         this.lblNotes.Text = "Notes:";
         // 
         // cmbStateProvince
         // 
         this.cmbStateProvince.FormattingEnabled = true;
         this.cmbStateProvince.Location = new System.Drawing.Point(140, 250);
         this.cmbStateProvince.Name = "cmbStateProvince";
         this.cmbStateProvince.Size = new System.Drawing.Size(204, 21);
         this.cmbStateProvince.TabIndex = 27;
         // 
         // cmbCountry
         // 
         this.cmbCountry.FormattingEnabled = true;
         this.cmbCountry.Location = new System.Drawing.Point(140, 318);
         this.cmbCountry.Name = "cmbCountry";
         this.cmbCountry.Size = new System.Drawing.Size(204, 21);
         this.cmbCountry.TabIndex = 28;
         // 
         // frmDealer
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(853, 580);
         this.Controls.Add(this.cmbCountry);
         this.Controls.Add(this.cmbStateProvince);
         this.Controls.Add(this.lblNotes);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.lblWebSite);
         this.Controls.Add(this.lblEmail);
         this.Controls.Add(this.lblPostalCode);
         this.Controls.Add(this.lblCountry);
         this.Controls.Add(this.lblStateProvince);
         this.Controls.Add(this.lblCity);
         this.Controls.Add(this.lblAddress2);
         this.Controls.Add(this.lblAddress1);
         this.Controls.Add(this.lblBusinessName);
         this.Controls.Add(this.lblLastName);
         this.Controls.Add(this.lblFirstName);
         this.Controls.Add(this.txtBusinessName);
         this.Controls.Add(this.txtWebSite);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.txtPostalCode);
         this.Controls.Add(this.txtCity);
         this.Controls.Add(this.txtAddress2);
         this.Controls.Add(this.txtAddress1);
         this.Controls.Add(this.txtLastName);
         this.Controls.Add(this.txtFirstName);
         this.Controls.Add(this.bnvDealer);
         this.Name = "frmDealer";
         this.Text = "Dealer";
         ((System.ComponentModel.ISupportInitialize)(this.bnvDealer)).EndInit();
         this.bnvDealer.ResumeLayout(false);
         this.bnvDealer.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingNavigator bnvDealer;
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
      private System.Windows.Forms.TextBox txtFirstName;
      private System.Windows.Forms.TextBox txtLastName;
      private System.Windows.Forms.TextBox txtAddress1;
      private System.Windows.Forms.TextBox txtAddress2;
      private System.Windows.Forms.TextBox txtCity;
      private System.Windows.Forms.TextBox txtPostalCode;
      private System.Windows.Forms.TextBox txtEmail;
      private System.Windows.Forms.TextBox txtWebSite;
      private System.Windows.Forms.TextBox txtBusinessName;
      private System.Windows.Forms.Label lblFirstName;
      private System.Windows.Forms.Label lblLastName;
      private System.Windows.Forms.Label lblBusinessName;
      private System.Windows.Forms.Label lblAddress1;
      private System.Windows.Forms.Label lblAddress2;
      private System.Windows.Forms.Label lblCity;
      private System.Windows.Forms.Label lblStateProvince;
      private System.Windows.Forms.Label lblCountry;
      private System.Windows.Forms.Label lblPostalCode;
      private System.Windows.Forms.Label lblEmail;
      private System.Windows.Forms.Label lblWebSite;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.TextBox txtNotes;
      private System.Windows.Forms.Label lblNotes;
      private System.Windows.Forms.ComboBox cmbStateProvince;
      private System.Windows.Forms.ComboBox cmbCountry;
   }
}