namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmMain
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
         System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ancient Roman Coins");
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         this.btnExitViaCollection = new System.Windows.Forms.Button();
         this.tabConfiguration = new System.Windows.Forms.TabControl();
         this.tabStartUp = new System.Windows.Forms.TabPage();
         this.webBrowser1 = new System.Windows.Forms.WebBrowser();
         this.tabCollection = new System.Windows.Forms.TabPage();
         this.btnPrintLabels = new System.Windows.Forms.Button();
         this.pnlCoinCollection = new System.Windows.Forms.Panel();
         this.spcCoinCollection = new System.Windows.Forms.SplitContainer();
         this.trvCoinCollection = new System.Windows.Forms.TreeView();
         this.dgvCoins = new System.Windows.Forms.DataGridView();
         this.bnvCoinCollection = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.btnAddCoin = new System.Windows.Forms.Button();
         this.tabReports = new System.Windows.Forms.TabPage();
         this.btnReports = new System.Windows.Forms.Button();
         this.btnLabels = new System.Windows.Forms.Button();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.btnExitViaReports = new System.Windows.Forms.Button();
         this.tabImportExport = new System.Windows.Forms.TabPage();
         this.tabMaintenance = new System.Windows.Forms.TabPage();
         this.btnIssuingAuthorityName = new System.Windows.Forms.Button();
         this.btnIssuingAuthorityReign = new System.Windows.Forms.Button();
         this.btnPeriod = new System.Windows.Forms.Button();
         this.btnRicSection = new System.Windows.Forms.Button();
         this.btnRicVolume = new System.Windows.Forms.Button();
         this.btnAuthority = new System.Windows.Forms.Button();
         this.btnGrade = new System.Windows.Forms.Button();
         this.btnMaterial = new System.Windows.Forms.Button();
         this.btnTitle = new System.Windows.Forms.Button();
         this.btnCoinType = new System.Windows.Forms.Button();
         this.btnAmdMint = new System.Windows.Forms.Button();
         this.spcMaintenance = new System.Windows.Forms.SplitContainer();
         this.btnExitViaMaintenance = new System.Windows.Forms.Button();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.grpTreeViewConfig = new System.Windows.Forms.GroupBox();
         this.lblLogicalTreeViewSecondSort = new System.Windows.Forms.Label();
         this.cmbTreeViewPrimarySort = new System.Windows.Forms.ComboBox();
         this.cmbTreeViewSecondarySort = new System.Windows.Forms.ComboBox();
         this.lblTreeViewSort = new System.Windows.Forms.Label();
         this.spcConfiguration = new System.Windows.Forms.SplitContainer();
         this.btnExitViaConfiguration = new System.Windows.Forms.Button();
         this.tabConfiguration.SuspendLayout();
         this.tabStartUp.SuspendLayout();
         this.tabCollection.SuspendLayout();
         this.pnlCoinCollection.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spcCoinCollection)).BeginInit();
         this.spcCoinCollection.Panel1.SuspendLayout();
         this.spcCoinCollection.Panel2.SuspendLayout();
         this.spcCoinCollection.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bnvCoinCollection)).BeginInit();
         this.bnvCoinCollection.SuspendLayout();
         this.tabReports.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         this.tabMaintenance.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spcMaintenance)).BeginInit();
         this.spcMaintenance.Panel2.SuspendLayout();
         this.spcMaintenance.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.grpTreeViewConfig.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spcConfiguration)).BeginInit();
         this.spcConfiguration.Panel2.SuspendLayout();
         this.spcConfiguration.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnExitViaCollection
         // 
         this.btnExitViaCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnExitViaCollection.Location = new System.Drawing.Point(1142, 611);
         this.btnExitViaCollection.Name = "btnExitViaCollection";
         this.btnExitViaCollection.Size = new System.Drawing.Size(77, 22);
         this.btnExitViaCollection.TabIndex = 2;
         this.btnExitViaCollection.Text = "Exit";
         this.btnExitViaCollection.UseVisualStyleBackColor = true;
         this.btnExitViaCollection.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // tabConfiguration
         // 
         this.tabConfiguration.Controls.Add(this.tabStartUp);
         this.tabConfiguration.Controls.Add(this.tabCollection);
         this.tabConfiguration.Controls.Add(this.tabReports);
         this.tabConfiguration.Controls.Add(this.tabMaintenance);
         this.tabConfiguration.Controls.Add(this.tabPage1);
         this.tabConfiguration.Controls.Add(this.tabImportExport);
         this.tabConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabConfiguration.Location = new System.Drawing.Point(0, 0);
         this.tabConfiguration.Name = "tabConfiguration";
         this.tabConfiguration.SelectedIndex = 0;
         this.tabConfiguration.Size = new System.Drawing.Size(1231, 663);
         this.tabConfiguration.TabIndex = 3;
         this.tabConfiguration.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabConfiguration_Selecting);
         this.tabConfiguration.Enter += new System.EventHandler(this.tabConfiguration_Enter);
         // 
         // tabStartUp
         // 
         this.tabStartUp.BackColor = System.Drawing.Color.LightGray;
         this.tabStartUp.Controls.Add(this.webBrowser1);
         this.tabStartUp.Location = new System.Drawing.Point(4, 22);
         this.tabStartUp.Name = "tabStartUp";
         this.tabStartUp.Padding = new System.Windows.Forms.Padding(3);
         this.tabStartUp.Size = new System.Drawing.Size(1223, 637);
         this.tabStartUp.TabIndex = 0;
         this.tabStartUp.Text = "Start-up";
         // 
         // webBrowser1
         // 
         this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.webBrowser1.Location = new System.Drawing.Point(3, 3);
         this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
         this.webBrowser1.Name = "webBrowser1";
         this.webBrowser1.Size = new System.Drawing.Size(1217, 631);
         this.webBrowser1.TabIndex = 4;
         // 
         // tabCollection
         // 
         this.tabCollection.BackColor = System.Drawing.Color.LightGray;
         this.tabCollection.Controls.Add(this.btnPrintLabels);
         this.tabCollection.Controls.Add(this.btnExitViaCollection);
         this.tabCollection.Controls.Add(this.pnlCoinCollection);
         this.tabCollection.Controls.Add(this.bnvCoinCollection);
         this.tabCollection.Controls.Add(this.btnAddCoin);
         this.tabCollection.Location = new System.Drawing.Point(4, 22);
         this.tabCollection.Name = "tabCollection";
         this.tabCollection.Padding = new System.Windows.Forms.Padding(3);
         this.tabCollection.Size = new System.Drawing.Size(1223, 637);
         this.tabCollection.TabIndex = 1;
         this.tabCollection.Text = "Collection";
         this.tabCollection.Click += new System.EventHandler(this.tabCollection_Click);
         // 
         // btnPrintLabels
         // 
         this.btnPrintLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnPrintLabels.Location = new System.Drawing.Point(1059, 612);
         this.btnPrintLabels.Name = "btnPrintLabels";
         this.btnPrintLabels.Size = new System.Drawing.Size(77, 22);
         this.btnPrintLabels.TabIndex = 7;
         this.btnPrintLabels.Text = "Print Labels";
         this.btnPrintLabels.UseVisualStyleBackColor = true;
         this.btnPrintLabels.Click += new System.EventHandler(this.btnPrintLabels_Click);
         // 
         // pnlCoinCollection
         // 
         this.pnlCoinCollection.Controls.Add(this.spcCoinCollection);
         this.pnlCoinCollection.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlCoinCollection.Location = new System.Drawing.Point(3, 3);
         this.pnlCoinCollection.Name = "pnlCoinCollection";
         this.pnlCoinCollection.Size = new System.Drawing.Size(1217, 606);
         this.pnlCoinCollection.TabIndex = 6;
         // 
         // spcCoinCollection
         // 
         this.spcCoinCollection.Dock = System.Windows.Forms.DockStyle.Fill;
         this.spcCoinCollection.Location = new System.Drawing.Point(0, 0);
         this.spcCoinCollection.Name = "spcCoinCollection";
         // 
         // spcCoinCollection.Panel1
         // 
         this.spcCoinCollection.Panel1.Controls.Add(this.trvCoinCollection);
         // 
         // spcCoinCollection.Panel2
         // 
         this.spcCoinCollection.Panel2.Controls.Add(this.dgvCoins);
         this.spcCoinCollection.Size = new System.Drawing.Size(1217, 606);
         this.spcCoinCollection.SplitterDistance = 225;
         this.spcCoinCollection.TabIndex = 5;
         // 
         // trvCoinCollection
         // 
         this.trvCoinCollection.BackColor = System.Drawing.Color.Silver;
         this.trvCoinCollection.Dock = System.Windows.Forms.DockStyle.Fill;
         this.trvCoinCollection.Location = new System.Drawing.Point(0, 0);
         this.trvCoinCollection.Name = "trvCoinCollection";
         treeNode4.Name = "Ancient Roman Coins";
         treeNode4.Tag = "0";
         treeNode4.Text = "Ancient Roman Coins";
         this.trvCoinCollection.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
         this.trvCoinCollection.Size = new System.Drawing.Size(225, 606);
         this.trvCoinCollection.TabIndex = 0;
         this.trvCoinCollection.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvCoinCollection_BeforeSelect);
         this.trvCoinCollection.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCoinCollection_AfterSelect);
         this.trvCoinCollection.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvCoinCollection_NodeMouseClick);
         // 
         // dgvCoins
         // 
         this.dgvCoins.BackgroundColor = System.Drawing.SystemColors.Control;
         this.dgvCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvCoins.DefaultCellStyle = dataGridViewCellStyle4;
         this.dgvCoins.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvCoins.GridColor = System.Drawing.SystemColors.ControlDarkDark;
         this.dgvCoins.Location = new System.Drawing.Point(0, 0);
         this.dgvCoins.Name = "dgvCoins";
         this.dgvCoins.Size = new System.Drawing.Size(988, 606);
         this.dgvCoins.TabIndex = 4;
         this.dgvCoins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoins_CellClick);
         this.dgvCoins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoins_CellContentClick);
         this.dgvCoins.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoins_CellMouseClick);
         this.dgvCoins.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCoins_RowsAdded);
         this.dgvCoins.DoubleClick += new System.EventHandler(this.dgvCoins_DoubleClick);
         // 
         // bnvCoinCollection
         // 
         this.bnvCoinCollection.AddNewItem = this.bindingNavigatorAddNewItem;
         this.bnvCoinCollection.CountItem = this.bindingNavigatorCountItem;
         this.bnvCoinCollection.DeleteItem = this.bindingNavigatorDeleteItem;
         this.bnvCoinCollection.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.bnvCoinCollection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.bnvCoinCollection.Location = new System.Drawing.Point(3, 609);
         this.bnvCoinCollection.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.bnvCoinCollection.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.bnvCoinCollection.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.bnvCoinCollection.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.bnvCoinCollection.Name = "bnvCoinCollection";
         this.bnvCoinCollection.PositionItem = this.bindingNavigatorPositionItem;
         this.bnvCoinCollection.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
         this.bnvCoinCollection.Size = new System.Drawing.Size(1217, 25);
         this.bnvCoinCollection.TabIndex = 5;
         this.bnvCoinCollection.Text = "bindingNavigator1";
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
         // btnAddCoin
         // 
         this.btnAddCoin.Location = new System.Drawing.Point(606, 522);
         this.btnAddCoin.Name = "btnAddCoin";
         this.btnAddCoin.Size = new System.Drawing.Size(75, 23);
         this.btnAddCoin.TabIndex = 0;
         this.btnAddCoin.Text = "Add";
         this.btnAddCoin.UseVisualStyleBackColor = true;
         this.btnAddCoin.Click += new System.EventHandler(this.btnAddCoin_Click);
         // 
         // tabReports
         // 
         this.tabReports.BackColor = System.Drawing.Color.LightGray;
         this.tabReports.Controls.Add(this.btnReports);
         this.tabReports.Controls.Add(this.btnLabels);
         this.tabReports.Controls.Add(this.splitContainer2);
         this.tabReports.Location = new System.Drawing.Point(4, 22);
         this.tabReports.Name = "tabReports";
         this.tabReports.Padding = new System.Windows.Forms.Padding(3);
         this.tabReports.Size = new System.Drawing.Size(1223, 637);
         this.tabReports.TabIndex = 2;
         this.tabReports.Text = "Reports";
         // 
         // btnReports
         // 
         this.btnReports.Location = new System.Drawing.Point(77, 83);
         this.btnReports.Name = "btnReports";
         this.btnReports.Size = new System.Drawing.Size(75, 23);
         this.btnReports.TabIndex = 1;
         this.btnReports.Text = "Reports";
         this.btnReports.UseVisualStyleBackColor = true;
         // 
         // btnLabels
         // 
         this.btnLabels.Location = new System.Drawing.Point(77, 54);
         this.btnLabels.Name = "btnLabels";
         this.btnLabels.Size = new System.Drawing.Size(75, 23);
         this.btnLabels.TabIndex = 0;
         this.btnLabels.Text = "Labels";
         this.btnLabels.UseVisualStyleBackColor = true;
         // 
         // splitContainer2
         // 
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(3, 3);
         this.splitContainer2.Name = "splitContainer2";
         this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
         this.splitContainer2.Panel2.Controls.Add(this.btnExitViaReports);
         this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
         this.splitContainer2.Size = new System.Drawing.Size(1217, 631);
         this.splitContainer2.SplitterDistance = 599;
         this.splitContainer2.TabIndex = 14;
         // 
         // btnExitViaReports
         // 
         this.btnExitViaReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnExitViaReports.Location = new System.Drawing.Point(1137, 3);
         this.btnExitViaReports.Name = "btnExitViaReports";
         this.btnExitViaReports.Size = new System.Drawing.Size(77, 22);
         this.btnExitViaReports.TabIndex = 8;
         this.btnExitViaReports.Text = "Exit";
         this.btnExitViaReports.UseVisualStyleBackColor = true;
         this.btnExitViaReports.Click += new System.EventHandler(this.btnExitViaReports_Click);
         // 
         // tabImportExport
         // 
         this.tabImportExport.BackColor = System.Drawing.Color.LightGray;
         this.tabImportExport.Location = new System.Drawing.Point(4, 22);
         this.tabImportExport.Name = "tabImportExport";
         this.tabImportExport.Padding = new System.Windows.Forms.Padding(3);
         this.tabImportExport.Size = new System.Drawing.Size(1223, 637);
         this.tabImportExport.TabIndex = 3;
         this.tabImportExport.Text = "Import/Export";
         // 
         // tabMaintenance
         // 
         this.tabMaintenance.BackColor = System.Drawing.Color.LightGray;
         this.tabMaintenance.Controls.Add(this.btnIssuingAuthorityName);
         this.tabMaintenance.Controls.Add(this.btnIssuingAuthorityReign);
         this.tabMaintenance.Controls.Add(this.btnPeriod);
         this.tabMaintenance.Controls.Add(this.btnRicSection);
         this.tabMaintenance.Controls.Add(this.btnRicVolume);
         this.tabMaintenance.Controls.Add(this.btnAuthority);
         this.tabMaintenance.Controls.Add(this.btnGrade);
         this.tabMaintenance.Controls.Add(this.btnMaterial);
         this.tabMaintenance.Controls.Add(this.btnTitle);
         this.tabMaintenance.Controls.Add(this.btnCoinType);
         this.tabMaintenance.Controls.Add(this.btnAmdMint);
         this.tabMaintenance.Controls.Add(this.spcMaintenance);
         this.tabMaintenance.Location = new System.Drawing.Point(4, 22);
         this.tabMaintenance.Name = "tabMaintenance";
         this.tabMaintenance.Padding = new System.Windows.Forms.Padding(3);
         this.tabMaintenance.Size = new System.Drawing.Size(1223, 637);
         this.tabMaintenance.TabIndex = 4;
         this.tabMaintenance.Text = "Maintenance";
         this.tabMaintenance.Click += new System.EventHandler(this.TabMaintenance_Click);
         // 
         // btnIssuingAuthorityName
         // 
         this.btnIssuingAuthorityName.Location = new System.Drawing.Point(173, 101);
         this.btnIssuingAuthorityName.Name = "btnIssuingAuthorityName";
         this.btnIssuingAuthorityName.Size = new System.Drawing.Size(90, 23);
         this.btnIssuingAuthorityName.TabIndex = 12;
         this.btnIssuingAuthorityName.Text = "IssuingAuthorityReign Name";
         this.btnIssuingAuthorityName.UseVisualStyleBackColor = true;
         this.btnIssuingAuthorityName.Click += new System.EventHandler(this.btnIssuingAuthorityName_Click);
         // 
         // btnIssuingAuthorityReign
         // 
         this.btnIssuingAuthorityReign.Location = new System.Drawing.Point(173, 58);
         this.btnIssuingAuthorityReign.Name = "btnIssuingAuthorityReign";
         this.btnIssuingAuthorityReign.Size = new System.Drawing.Size(90, 23);
         this.btnIssuingAuthorityReign.TabIndex = 11;
         this.btnIssuingAuthorityReign.Text = "IssuingAuthorityReign Reign";
         this.btnIssuingAuthorityReign.UseVisualStyleBackColor = true;
         this.btnIssuingAuthorityReign.Click += new System.EventHandler(this.btnIssuingAuthorityReign_Click);
         // 
         // btnPeriod
         // 
         this.btnPeriod.Location = new System.Drawing.Point(61, 402);
         this.btnPeriod.Name = "btnPeriod";
         this.btnPeriod.Size = new System.Drawing.Size(90, 23);
         this.btnPeriod.TabIndex = 9;
         this.btnPeriod.Text = "Period Name";
         this.btnPeriod.UseVisualStyleBackColor = true;
         this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
         // 
         // btnRicSection
         // 
         this.btnRicSection.Location = new System.Drawing.Point(61, 359);
         this.btnRicSection.Name = "btnRicSection";
         this.btnRicSection.Size = new System.Drawing.Size(90, 23);
         this.btnRicSection.TabIndex = 8;
         this.btnRicSection.Text = "RIC Section";
         this.btnRicSection.UseVisualStyleBackColor = true;
         this.btnRicSection.Click += new System.EventHandler(this.btnRicSection_Click);
         // 
         // btnRicVolume
         // 
         this.btnRicVolume.Location = new System.Drawing.Point(61, 316);
         this.btnRicVolume.Name = "btnRicVolume";
         this.btnRicVolume.Size = new System.Drawing.Size(90, 23);
         this.btnRicVolume.TabIndex = 7;
         this.btnRicVolume.Text = "RIC Volume";
         this.btnRicVolume.UseVisualStyleBackColor = true;
         this.btnRicVolume.Click += new System.EventHandler(this.btnRicVolume_Click);
         // 
         // btnAuthority
         // 
         this.btnAuthority.Location = new System.Drawing.Point(61, 273);
         this.btnAuthority.Name = "btnAuthority";
         this.btnAuthority.Size = new System.Drawing.Size(90, 23);
         this.btnAuthority.TabIndex = 6;
         this.btnAuthority.Text = "IssuingAuthorityReign";
         this.btnAuthority.UseVisualStyleBackColor = true;
         this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
         // 
         // btnGrade
         // 
         this.btnGrade.Location = new System.Drawing.Point(61, 230);
         this.btnGrade.Name = "btnGrade";
         this.btnGrade.Size = new System.Drawing.Size(90, 23);
         this.btnGrade.TabIndex = 5;
         this.btnGrade.Text = "Grade";
         this.btnGrade.UseVisualStyleBackColor = true;
         this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
         // 
         // btnMaterial
         // 
         this.btnMaterial.Location = new System.Drawing.Point(61, 187);
         this.btnMaterial.Name = "btnMaterial";
         this.btnMaterial.Size = new System.Drawing.Size(90, 23);
         this.btnMaterial.TabIndex = 4;
         this.btnMaterial.Text = "Material";
         this.btnMaterial.UseVisualStyleBackColor = true;
         this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
         // 
         // btnTitle
         // 
         this.btnTitle.Location = new System.Drawing.Point(61, 144);
         this.btnTitle.Name = "btnTitle";
         this.btnTitle.Size = new System.Drawing.Size(90, 23);
         this.btnTitle.TabIndex = 3;
         this.btnTitle.Text = "Title";
         this.btnTitle.UseVisualStyleBackColor = true;
         this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
         // 
         // btnCoinType
         // 
         this.btnCoinType.Location = new System.Drawing.Point(61, 58);
         this.btnCoinType.Name = "btnCoinType";
         this.btnCoinType.Size = new System.Drawing.Size(90, 23);
         this.btnCoinType.TabIndex = 2;
         this.btnCoinType.Text = "Coin Type";
         this.btnCoinType.UseVisualStyleBackColor = true;
         this.btnCoinType.Click += new System.EventHandler(this.btnCoinType_Click);
         // 
         // btnAmdMint
         // 
         this.btnAmdMint.Location = new System.Drawing.Point(61, 101);
         this.btnAmdMint.Name = "btnAmdMint";
         this.btnAmdMint.Size = new System.Drawing.Size(90, 23);
         this.btnAmdMint.TabIndex = 1;
         this.btnAmdMint.Text = "Mint";
         this.btnAmdMint.UseVisualStyleBackColor = true;
         this.btnAmdMint.Click += new System.EventHandler(this.btnAmdMint_Click);
         // 
         // spcMaintenance
         // 
         this.spcMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
         this.spcMaintenance.Location = new System.Drawing.Point(3, 3);
         this.spcMaintenance.Name = "spcMaintenance";
         this.spcMaintenance.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // spcMaintenance.Panel2
         // 
         this.spcMaintenance.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
         this.spcMaintenance.Panel2.Controls.Add(this.btnExitViaMaintenance);
         this.spcMaintenance.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
         this.spcMaintenance.Size = new System.Drawing.Size(1217, 631);
         this.spcMaintenance.SplitterDistance = 600;
         this.spcMaintenance.TabIndex = 13;
         this.spcMaintenance.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SpcMaintenance_SplitterMoved);
         // 
         // btnExitViaMaintenance
         // 
         this.btnExitViaMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnExitViaMaintenance.Location = new System.Drawing.Point(1137, 3);
         this.btnExitViaMaintenance.Name = "btnExitViaMaintenance";
         this.btnExitViaMaintenance.Size = new System.Drawing.Size(77, 22);
         this.btnExitViaMaintenance.TabIndex = 8;
         this.btnExitViaMaintenance.Text = "Exit";
         this.btnExitViaMaintenance.UseVisualStyleBackColor = true;
         this.btnExitViaMaintenance.Click += new System.EventHandler(this.BtnExitViaMaintenance_Click);
         // 
         // tabPage1
         // 
         this.tabPage1.BackColor = System.Drawing.Color.LightGray;
         this.tabPage1.Controls.Add(this.grpTreeViewConfig);
         this.tabPage1.Controls.Add(this.spcConfiguration);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(1223, 637);
         this.tabPage1.TabIndex = 5;
         this.tabPage1.Text = "Configuration";
         // 
         // grpTreeViewConfig
         // 
         this.grpTreeViewConfig.Controls.Add(this.lblLogicalTreeViewSecondSort);
         this.grpTreeViewConfig.Controls.Add(this.cmbTreeViewPrimarySort);
         this.grpTreeViewConfig.Controls.Add(this.cmbTreeViewSecondarySort);
         this.grpTreeViewConfig.Controls.Add(this.lblTreeViewSort);
         this.grpTreeViewConfig.Location = new System.Drawing.Point(46, 61);
         this.grpTreeViewConfig.Name = "grpTreeViewConfig";
         this.grpTreeViewConfig.Size = new System.Drawing.Size(397, 134);
         this.grpTreeViewConfig.TabIndex = 2;
         this.grpTreeViewConfig.TabStop = false;
         this.grpTreeViewConfig.Text = "LogicalTreeView Configuration";
         // 
         // lblLogicalTreeViewSecondSort
         // 
         this.lblLogicalTreeViewSecondSort.AutoSize = true;
         this.lblLogicalTreeViewSecondSort.Location = new System.Drawing.Point(31, 80);
         this.lblLogicalTreeViewSecondSort.Name = "lblLogicalTreeViewSecondSort";
         this.lblLogicalTreeViewSecondSort.Size = new System.Drawing.Size(165, 13);
         this.lblLogicalTreeViewSecondSort.TabIndex = 3;
         this.lblLogicalTreeViewSecondSort.Text = "LogicalTreeView Secondary Sort:";
         this.lblLogicalTreeViewSecondSort.Click += new System.EventHandler(this.label1_Click);
         // 
         // cmbTreeViewPrimarySort
         // 
         this.cmbTreeViewPrimarySort.FormattingEnabled = true;
         this.cmbTreeViewPrimarySort.Location = new System.Drawing.Point(236, 38);
         this.cmbTreeViewPrimarySort.Name = "cmbTreeViewPrimarySort";
         this.cmbTreeViewPrimarySort.Size = new System.Drawing.Size(121, 21);
         this.cmbTreeViewPrimarySort.TabIndex = 0;
         // 
         // cmbTreeViewSecondarySort
         // 
         this.cmbTreeViewSecondarySort.FormattingEnabled = true;
         this.cmbTreeViewSecondarySort.Location = new System.Drawing.Point(236, 76);
         this.cmbTreeViewSecondarySort.Name = "cmbTreeViewSecondarySort";
         this.cmbTreeViewSecondarySort.Size = new System.Drawing.Size(121, 21);
         this.cmbTreeViewSecondarySort.TabIndex = 2;
         this.cmbTreeViewSecondarySort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // lblTreeViewSort
         // 
         this.lblTreeViewSort.AutoSize = true;
         this.lblTreeViewSort.Location = new System.Drawing.Point(48, 42);
         this.lblTreeViewSort.Name = "lblTreeViewSort";
         this.lblTreeViewSort.Size = new System.Drawing.Size(148, 13);
         this.lblTreeViewSort.TabIndex = 1;
         this.lblTreeViewSort.Text = "LogicalTreeView Primary Sort:";
         // 
         // spcConfiguration
         // 
         this.spcConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
         this.spcConfiguration.Location = new System.Drawing.Point(3, 3);
         this.spcConfiguration.Name = "spcConfiguration";
         this.spcConfiguration.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // spcConfiguration.Panel2
         // 
         this.spcConfiguration.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
         this.spcConfiguration.Panel2.Controls.Add(this.btnExitViaConfiguration);
         this.spcConfiguration.Size = new System.Drawing.Size(1217, 631);
         this.spcConfiguration.SplitterDistance = 597;
         this.spcConfiguration.TabIndex = 3;
         // 
         // btnExitViaConfiguration
         // 
         this.btnExitViaConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnExitViaConfiguration.Location = new System.Drawing.Point(1137, 4);
         this.btnExitViaConfiguration.Name = "btnExitViaConfiguration";
         this.btnExitViaConfiguration.Size = new System.Drawing.Size(77, 22);
         this.btnExitViaConfiguration.TabIndex = 9;
         this.btnExitViaConfiguration.Text = "Exit";
         this.btnExitViaConfiguration.UseVisualStyleBackColor = true;
         this.btnExitViaConfiguration.Click += new System.EventHandler(this.BtnExitViaConfiguration_Click);
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(1231, 663);
         this.Controls.Add(this.tabConfiguration);
         this.Name = "frmMain";
         this.Text = "Ancient Roman Coins";
         this.Activated += new System.EventHandler(this.frmMain_Activated);
         this.Load += new System.EventHandler(this.frmMain_Load);
         this.tabConfiguration.ResumeLayout(false);
         this.tabStartUp.ResumeLayout(false);
         this.tabCollection.ResumeLayout(false);
         this.tabCollection.PerformLayout();
         this.pnlCoinCollection.ResumeLayout(false);
         this.spcCoinCollection.Panel1.ResumeLayout(false);
         this.spcCoinCollection.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.spcCoinCollection)).EndInit();
         this.spcCoinCollection.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bnvCoinCollection)).EndInit();
         this.bnvCoinCollection.ResumeLayout(false);
         this.bnvCoinCollection.PerformLayout();
         this.tabReports.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.tabMaintenance.ResumeLayout(false);
         this.spcMaintenance.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.spcMaintenance)).EndInit();
         this.spcMaintenance.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.grpTreeViewConfig.ResumeLayout(false);
         this.grpTreeViewConfig.PerformLayout();
         this.spcConfiguration.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.spcConfiguration)).EndInit();
         this.spcConfiguration.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnExitViaCollection;
      private System.Windows.Forms.TabControl tabConfiguration;
      private System.Windows.Forms.TabPage tabStartUp;
      private System.Windows.Forms.TabPage tabCollection;
      private System.Windows.Forms.Button btnAddCoin;
      private System.Windows.Forms.TabPage tabReports;
      private System.Windows.Forms.TabPage tabImportExport;
      private System.Windows.Forms.TabPage tabMaintenance;
      private System.Windows.Forms.Button btnCoinType;
      private System.Windows.Forms.Button btnAmdMint;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.Button btnTitle;
      private System.Windows.Forms.Button btnAuthority;
      private System.Windows.Forms.Button btnGrade;
      private System.Windows.Forms.Button btnMaterial;
      private System.Windows.Forms.Button btnLabels;
      private System.Windows.Forms.WebBrowser webBrowser1;
      private System.Windows.Forms.DataGridView dgvCoins;
      private System.Windows.Forms.BindingNavigator bnvCoinCollection;
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
      private System.Windows.Forms.Panel pnlCoinCollection;
      private System.Windows.Forms.Button btnRicSection;
      private System.Windows.Forms.Button btnRicVolume;
      private System.Windows.Forms.Button btnReports;
      private System.Windows.Forms.SplitContainer spcCoinCollection;
      private System.Windows.Forms.TreeView trvCoinCollection;
      private System.Windows.Forms.Button btnPeriod;
      private System.Windows.Forms.Button btnIssuingAuthorityName;
      private System.Windows.Forms.Button btnPrintLabels;
      private System.Windows.Forms.Button btnIssuingAuthorityReign;
      private System.Windows.Forms.SplitContainer spcMaintenance;
      private System.Windows.Forms.Button btnExitViaMaintenance;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.Button btnExitViaReports;
      private System.Windows.Forms.GroupBox grpTreeViewConfig;
      private System.Windows.Forms.Label lblLogicalTreeViewSecondSort;
      private System.Windows.Forms.ComboBox cmbTreeViewPrimarySort;
      private System.Windows.Forms.ComboBox cmbTreeViewSecondarySort;
      private System.Windows.Forms.Label lblTreeViewSort;
      private System.Windows.Forms.SplitContainer spcConfiguration;
      private System.Windows.Forms.Button btnExitViaConfiguration;
   }
}

