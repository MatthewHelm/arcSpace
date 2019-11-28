namespace bcs.arcSpace.arcSpaceWinform
{
   partial class frmAddCoin
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
         this.cmbMaterial = new System.Windows.Forms.ComboBox();
         this.txtCoinName = new System.Windows.Forms.TextBox();
         this.lblCoinName = new System.Windows.Forms.Label();
         this.lblMaterial = new System.Windows.Forms.Label();
         this.cmbCoinType = new System.Windows.Forms.ComboBox();
         this.lblCoinType = new System.Windows.Forms.Label();
         this.cmbMint = new System.Windows.Forms.ComboBox();
         this.lblMint = new System.Windows.Forms.Label();
         this.cmbIssuingAuthority = new System.Windows.Forms.ComboBox();
         this.lblIssuingAuthority = new System.Windows.Forms.Label();
         this.txtObverseLegend = new System.Windows.Forms.TextBox();
         this.lblObverseLegend = new System.Windows.Forms.Label();
         this.txtReverseLegend = new System.Windows.Forms.TextBox();
         this.lblReverseLegend = new System.Windows.Forms.Label();
         this.ofdCoin = new System.Windows.Forms.OpenFileDialog();
         this.txtExergue = new System.Windows.Forms.TextBox();
         this.lblExergue = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.lblDescription = new System.Windows.Forms.Label();
         this.txtWeight = new System.Windows.Forms.TextBox();
         this.lblWeight = new System.Windows.Forms.Label();
         this.txtDiamter = new System.Windows.Forms.TextBox();
         this.lblDiameter = new System.Windows.Forms.Label();
         this.txtDieAxis = new System.Windows.Forms.TextBox();
         this.lblDieAxis = new System.Windows.Forms.Label();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.cmbDealer = new System.Windows.Forms.ComboBox();
         this.txtDealer = new System.Windows.Forms.Label();
         this.lblPrice = new System.Windows.Forms.Label();
         this.cmbGrade = new System.Windows.Forms.ComboBox();
         this.lblGrade = new System.Windows.Forms.Label();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.cmbRicVolume = new System.Windows.Forms.ComboBox();
         this.cmbRicSection = new System.Windows.Forms.ComboBox();
         this.txtRicIndex = new System.Windows.Forms.TextBox();
         this.lblRic = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.cmbTitle = new System.Windows.Forms.ComboBox();
         this.cmbEndRuleYearEra = new System.Windows.Forms.ComboBox();
         this.cmbStartRuleYearEra = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtEndYear = new System.Windows.Forms.TextBox();
         this.txtStartYear = new System.Windows.Forms.TextBox();
         this.lnkObverseImage = new System.Windows.Forms.LinkLabel();
         this.picObverse = new System.Windows.Forms.PictureBox();
         this.lnkReverseImage = new System.Windows.Forms.LinkLabel();
         this.picReverse = new System.Windows.Forms.PictureBox();
         this.cmbEndMintingYearEra = new System.Windows.Forms.ComboBox();
         this.cmbStartMintingYearEra = new System.Windows.Forms.ComboBox();
         this.lblStartMintYear = new System.Windows.Forms.Label();
         this.lblEndMintingYear = new System.Windows.Forms.Label();
         this.txtEndMintingYear = new System.Windows.Forms.TextBox();
         this.txtStartMintingYear = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.picObverse)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.picReverse)).BeginInit();
         this.SuspendLayout();
         // 
         // cmbMaterial
         // 
         this.cmbMaterial.FormattingEnabled = true;
         this.cmbMaterial.Location = new System.Drawing.Point(321, 66);
         this.cmbMaterial.Name = "cmbMaterial";
         this.cmbMaterial.Size = new System.Drawing.Size(286, 21);
         this.cmbMaterial.TabIndex = 0;
         this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
         // 
         // txtCoinName
         // 
         this.txtCoinName.Location = new System.Drawing.Point(321, 10);
         this.txtCoinName.Name = "txtCoinName";
         this.txtCoinName.Size = new System.Drawing.Size(268, 20);
         this.txtCoinName.TabIndex = 1;
         this.txtCoinName.TextChanged += new System.EventHandler(this.txtCoinName_TextChanged);
         // 
         // lblCoinName
         // 
         this.lblCoinName.AutoSize = true;
         this.lblCoinName.Location = new System.Drawing.Point(277, 13);
         this.lblCoinName.Name = "lblCoinName";
         this.lblCoinName.Size = new System.Drawing.Size(38, 13);
         this.lblCoinName.TabIndex = 4;
         this.lblCoinName.Text = "Name:";
         // 
         // lblMaterial
         // 
         this.lblMaterial.AutoSize = true;
         this.lblMaterial.Location = new System.Drawing.Point(268, 70);
         this.lblMaterial.Name = "lblMaterial";
         this.lblMaterial.Size = new System.Drawing.Size(47, 13);
         this.lblMaterial.TabIndex = 5;
         this.lblMaterial.Text = "Material:";
         // 
         // cmbCoinType
         // 
         this.cmbCoinType.FormattingEnabled = true;
         this.cmbCoinType.Location = new System.Drawing.Point(321, 37);
         this.cmbCoinType.Name = "cmbCoinType";
         this.cmbCoinType.Size = new System.Drawing.Size(286, 21);
         this.cmbCoinType.TabIndex = 6;
         this.cmbCoinType.SelectedIndexChanged += new System.EventHandler(this.cmbCoinType_SelectedIndexChanged);
         // 
         // lblCoinType
         // 
         this.lblCoinType.AutoSize = true;
         this.lblCoinType.Location = new System.Drawing.Point(281, 41);
         this.lblCoinType.Name = "lblCoinType";
         this.lblCoinType.Size = new System.Drawing.Size(34, 13);
         this.lblCoinType.TabIndex = 7;
         this.lblCoinType.Text = "Type:";
         // 
         // cmbMint
         // 
         this.cmbMint.FormattingEnabled = true;
         this.cmbMint.Location = new System.Drawing.Point(321, 208);
         this.cmbMint.Name = "cmbMint";
         this.cmbMint.Size = new System.Drawing.Size(286, 21);
         this.cmbMint.TabIndex = 8;
         this.cmbMint.SelectedIndexChanged += new System.EventHandler(this.cmbMint_SelectedIndexChanged);
         // 
         // lblMint
         // 
         this.lblMint.AutoSize = true;
         this.lblMint.Location = new System.Drawing.Point(285, 212);
         this.lblMint.Name = "lblMint";
         this.lblMint.Size = new System.Drawing.Size(30, 13);
         this.lblMint.TabIndex = 9;
         this.lblMint.Text = "Mint:";
         // 
         // cmbIssuingAuthority
         // 
         this.cmbIssuingAuthority.FormattingEnabled = true;
         this.cmbIssuingAuthority.Location = new System.Drawing.Point(321, 96);
         this.cmbIssuingAuthority.Name = "cmbIssuingAuthority";
         this.cmbIssuingAuthority.Size = new System.Drawing.Size(286, 21);
         this.cmbIssuingAuthority.TabIndex = 10;
         this.cmbIssuingAuthority.SelectedIndexChanged += new System.EventHandler(this.cmbIssuingAuthority_SelectedIndexChanged);
         this.cmbIssuingAuthority.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbIssuingAuthority_KeyUp);
         // 
         // lblIssuingAuthority
         // 
         this.lblIssuingAuthority.AutoSize = true;
         this.lblIssuingAuthority.Location = new System.Drawing.Point(266, 100);
         this.lblIssuingAuthority.Name = "lblIssuingAuthority";
         this.lblIssuingAuthority.Size = new System.Drawing.Size(49, 13);
         this.lblIssuingAuthority.TabIndex = 11;
         this.lblIssuingAuthority.Text = "Emperor:";
         // 
         // txtObverseLegend
         // 
         this.txtObverseLegend.Location = new System.Drawing.Point(321, 237);
         this.txtObverseLegend.Name = "txtObverseLegend";
         this.txtObverseLegend.Size = new System.Drawing.Size(248, 20);
         this.txtObverseLegend.TabIndex = 12;
         this.txtObverseLegend.TextChanged += new System.EventHandler(this.txtObverseLegend_TextChanged);
         // 
         // lblObverseLegend
         // 
         this.lblObverseLegend.AutoSize = true;
         this.lblObverseLegend.Location = new System.Drawing.Point(246, 239);
         this.lblObverseLegend.Name = "lblObverseLegend";
         this.lblObverseLegend.Size = new System.Drawing.Size(69, 13);
         this.lblObverseLegend.TabIndex = 13;
         this.lblObverseLegend.Text = "Obv Legend:";
         // 
         // txtReverseLegend
         // 
         this.txtReverseLegend.Location = new System.Drawing.Point(321, 265);
         this.txtReverseLegend.Name = "txtReverseLegend";
         this.txtReverseLegend.Size = new System.Drawing.Size(248, 20);
         this.txtReverseLegend.TabIndex = 16;
         this.txtReverseLegend.TextChanged += new System.EventHandler(this.txtReverseLegend_TextChanged);
         // 
         // lblReverseLegend
         // 
         this.lblReverseLegend.AutoSize = true;
         this.lblReverseLegend.Location = new System.Drawing.Point(246, 267);
         this.lblReverseLegend.Name = "lblReverseLegend";
         this.lblReverseLegend.Size = new System.Drawing.Size(69, 13);
         this.lblReverseLegend.TabIndex = 17;
         this.lblReverseLegend.Text = "Rev Legend:";
         // 
         // ofdCoin
         // 
         this.ofdCoin.FileName = "openFileDialog1";
         this.ofdCoin.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdCoin_FileOk);
         // 
         // txtExergue
         // 
         this.txtExergue.Location = new System.Drawing.Point(321, 293);
         this.txtExergue.Name = "txtExergue";
         this.txtExergue.Size = new System.Drawing.Size(145, 20);
         this.txtExergue.TabIndex = 18;
         this.txtExergue.TextChanged += new System.EventHandler(this.txtExergue_TextChanged);
         // 
         // lblExergue
         // 
         this.lblExergue.AutoSize = true;
         this.lblExergue.Location = new System.Drawing.Point(266, 295);
         this.lblExergue.Name = "lblExergue";
         this.lblExergue.Size = new System.Drawing.Size(49, 13);
         this.lblExergue.TabIndex = 19;
         this.lblExergue.Text = "Exergue:";
         // 
         // txtDescription
         // 
         this.txtDescription.Location = new System.Drawing.Point(321, 322);
         this.txtDescription.Multiline = true;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(268, 131);
         this.txtDescription.TabIndex = 20;
         this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
         // 
         // lblDescription
         // 
         this.lblDescription.AutoSize = true;
         this.lblDescription.Location = new System.Drawing.Point(252, 324);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.Size = new System.Drawing.Size(63, 13);
         this.lblDescription.TabIndex = 21;
         this.lblDescription.Text = "Description:";
         // 
         // txtWeight
         // 
         this.txtWeight.Location = new System.Drawing.Point(729, 10);
         this.txtWeight.Name = "txtWeight";
         this.txtWeight.Size = new System.Drawing.Size(32, 20);
         this.txtWeight.TabIndex = 22;
         this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
         // 
         // lblWeight
         // 
         this.lblWeight.AutoSize = true;
         this.lblWeight.Location = new System.Drawing.Point(679, 12);
         this.lblWeight.Name = "lblWeight";
         this.lblWeight.Size = new System.Drawing.Size(44, 13);
         this.lblWeight.TabIndex = 23;
         this.lblWeight.Text = "Weight:";
         // 
         // txtDiamter
         // 
         this.txtDiamter.Location = new System.Drawing.Point(729, 37);
         this.txtDiamter.Name = "txtDiamter";
         this.txtDiamter.Size = new System.Drawing.Size(32, 20);
         this.txtDiamter.TabIndex = 24;
         this.txtDiamter.TextChanged += new System.EventHandler(this.txtDiamter_TextChanged);
         // 
         // lblDiameter
         // 
         this.lblDiameter.AutoSize = true;
         this.lblDiameter.Location = new System.Drawing.Point(671, 40);
         this.lblDiameter.Name = "lblDiameter";
         this.lblDiameter.Size = new System.Drawing.Size(52, 13);
         this.lblDiameter.TabIndex = 25;
         this.lblDiameter.Text = "Diameter:";
         // 
         // txtDieAxis
         // 
         this.txtDieAxis.Location = new System.Drawing.Point(729, 64);
         this.txtDieAxis.Name = "txtDieAxis";
         this.txtDieAxis.Size = new System.Drawing.Size(32, 20);
         this.txtDieAxis.TabIndex = 26;
         this.txtDieAxis.TextChanged += new System.EventHandler(this.txtDieAxis_TextChanged);
         // 
         // lblDieAxis
         // 
         this.lblDieAxis.AutoSize = true;
         this.lblDieAxis.Location = new System.Drawing.Point(675, 66);
         this.lblDieAxis.Name = "lblDieAxis";
         this.lblDieAxis.Size = new System.Drawing.Size(48, 13);
         this.lblDieAxis.TabIndex = 27;
         this.lblDieAxis.Text = "Die Axis:";
         // 
         // txtPrice
         // 
         this.txtPrice.Location = new System.Drawing.Point(729, 147);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(70, 20);
         this.txtPrice.TabIndex = 29;
         this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
         // 
         // cmbDealer
         // 
         this.cmbDealer.FormattingEnabled = true;
         this.cmbDealer.Location = new System.Drawing.Point(729, 119);
         this.cmbDealer.Name = "cmbDealer";
         this.cmbDealer.Size = new System.Drawing.Size(121, 21);
         this.cmbDealer.TabIndex = 30;
         this.cmbDealer.SelectedIndexChanged += new System.EventHandler(this.cmbDealer_SelectedIndexChanged);
         // 
         // txtDealer
         // 
         this.txtDealer.AutoSize = true;
         this.txtDealer.Location = new System.Drawing.Point(682, 122);
         this.txtDealer.Name = "txtDealer";
         this.txtDealer.Size = new System.Drawing.Size(41, 13);
         this.txtDealer.TabIndex = 31;
         this.txtDealer.Text = "Dealer:";
         // 
         // lblPrice
         // 
         this.lblPrice.AutoSize = true;
         this.lblPrice.Location = new System.Drawing.Point(689, 145);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(34, 13);
         this.lblPrice.TabIndex = 32;
         this.lblPrice.Text = "Price:";
         // 
         // cmbGrade
         // 
         this.cmbGrade.FormattingEnabled = true;
         this.cmbGrade.Location = new System.Drawing.Point(729, 91);
         this.cmbGrade.Name = "cmbGrade";
         this.cmbGrade.Size = new System.Drawing.Size(121, 21);
         this.cmbGrade.TabIndex = 33;
         this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);
         // 
         // lblGrade
         // 
         this.lblGrade.AutoSize = true;
         this.lblGrade.Location = new System.Drawing.Point(684, 95);
         this.lblGrade.Name = "lblGrade";
         this.lblGrade.Size = new System.Drawing.Size(39, 13);
         this.lblGrade.TabIndex = 34;
         this.lblGrade.Text = "Grade:";
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(840, 430);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 38;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(924, 430);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 39;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // cmbRicVolume
         // 
         this.cmbRicVolume.FormattingEnabled = true;
         this.cmbRicVolume.Location = new System.Drawing.Point(729, 174);
         this.cmbRicVolume.Name = "cmbRicVolume";
         this.cmbRicVolume.Size = new System.Drawing.Size(44, 21);
         this.cmbRicVolume.TabIndex = 40;
         this.cmbRicVolume.SelectedIndexChanged += new System.EventHandler(this.cmbRicVolume_SelectedIndexChanged);
         this.cmbRicVolume.SelectionChangeCommitted += new System.EventHandler(this.cmbRicVolume_SelectionChangeCommitted);
         this.cmbRicVolume.SelectedValueChanged += new System.EventHandler(this.cmbRicVolume_SelectedValueChanged);
         // 
         // cmbRicSection
         // 
         this.cmbRicSection.FormattingEnabled = true;
         this.cmbRicSection.Location = new System.Drawing.Point(776, 174);
         this.cmbRicSection.Name = "cmbRicSection";
         this.cmbRicSection.Size = new System.Drawing.Size(119, 21);
         this.cmbRicSection.TabIndex = 41;
         // 
         // txtRicIndex
         // 
         this.txtRicIndex.Location = new System.Drawing.Point(899, 175);
         this.txtRicIndex.Name = "txtRicIndex";
         this.txtRicIndex.Size = new System.Drawing.Size(100, 20);
         this.txtRicIndex.TabIndex = 42;
         // 
         // lblRic
         // 
         this.lblRic.AutoSize = true;
         this.lblRic.Location = new System.Drawing.Point(695, 172);
         this.lblRic.Name = "lblRic";
         this.lblRic.Size = new System.Drawing.Size(28, 13);
         this.lblRic.TabIndex = 43;
         this.lblRic.Text = "RIC:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(211, 129);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(104, 13);
         this.label5.TabIndex = 103;
         this.label5.Text = "IssuingAuthorityTitle:";
         // 
         // cmbTitle
         // 
         this.cmbTitle.FormattingEnabled = true;
         this.cmbTitle.Location = new System.Drawing.Point(321, 125);
         this.cmbTitle.Name = "cmbTitle";
         this.cmbTitle.Size = new System.Drawing.Size(226, 21);
         this.cmbTitle.TabIndex = 102;
         // 
         // cmbEndRuleYearEra
         // 
         this.cmbEndRuleYearEra.FormattingEnabled = true;
         this.cmbEndRuleYearEra.Location = new System.Drawing.Point(375, 181);
         this.cmbEndRuleYearEra.Name = "cmbEndRuleYearEra";
         this.cmbEndRuleYearEra.Size = new System.Drawing.Size(39, 21);
         this.cmbEndRuleYearEra.TabIndex = 100;
         // 
         // cmbStartRuleYearEra
         // 
         this.cmbStartRuleYearEra.FormattingEnabled = true;
         this.cmbStartRuleYearEra.Location = new System.Drawing.Point(375, 155);
         this.cmbStartRuleYearEra.Name = "cmbStartRuleYearEra";
         this.cmbStartRuleYearEra.Size = new System.Drawing.Size(39, 21);
         this.cmbStartRuleYearEra.TabIndex = 99;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(227, 154);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(88, 13);
         this.label2.TabIndex = 97;
         this.label2.Text = "Start Reign Year:";
         this.label2.Click += new System.EventHandler(this.label2_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(230, 181);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(85, 13);
         this.label1.TabIndex = 96;
         this.label1.Text = "End Reign Year:";
         // 
         // txtEndYear
         // 
         this.txtEndYear.Location = new System.Drawing.Point(321, 181);
         this.txtEndYear.Name = "txtEndYear";
         this.txtEndYear.Size = new System.Drawing.Size(50, 20);
         this.txtEndYear.TabIndex = 95;
         // 
         // txtStartYear
         // 
         this.txtStartYear.Location = new System.Drawing.Point(321, 155);
         this.txtStartYear.Name = "txtStartYear";
         this.txtStartYear.Size = new System.Drawing.Size(50, 20);
         this.txtStartYear.TabIndex = 94;
         // 
         // lnkObverseImage
         // 
         this.lnkObverseImage.AutoSize = true;
         this.lnkObverseImage.Location = new System.Drawing.Point(61, 163);
         this.lnkObverseImage.Name = "lnkObverseImage";
         this.lnkObverseImage.Size = new System.Drawing.Size(78, 13);
         this.lnkObverseImage.TabIndex = 105;
         this.lnkObverseImage.TabStop = true;
         this.lnkObverseImage.Text = "Obverse Photo";
         this.lnkObverseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkObverseImage_LinkClicked);
         // 
         // picObverse
         // 
         this.picObverse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.picObverse.Location = new System.Drawing.Point(28, 12);
         this.picObverse.Name = "picObverse";
         this.picObverse.Size = new System.Drawing.Size(145, 145);
         this.picObverse.TabIndex = 104;
         this.picObverse.TabStop = false;
         // 
         // lnkReverseImage
         // 
         this.lnkReverseImage.AutoSize = true;
         this.lnkReverseImage.Location = new System.Drawing.Point(63, 359);
         this.lnkReverseImage.Name = "lnkReverseImage";
         this.lnkReverseImage.Size = new System.Drawing.Size(75, 13);
         this.lnkReverseImage.TabIndex = 107;
         this.lnkReverseImage.TabStop = true;
         this.lnkReverseImage.Text = "ReversePhoto";
         this.lnkReverseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReverseImage_LinkClicked);
         // 
         // picReverse
         // 
         this.picReverse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.picReverse.Location = new System.Drawing.Point(28, 208);
         this.picReverse.Name = "picReverse";
         this.picReverse.Size = new System.Drawing.Size(145, 145);
         this.picReverse.TabIndex = 106;
         this.picReverse.TabStop = false;
         // 
         // cmbEndMintingYearEra
         // 
         this.cmbEndMintingYearEra.FormattingEnabled = true;
         this.cmbEndMintingYearEra.Location = new System.Drawing.Point(782, 228);
         this.cmbEndMintingYearEra.Name = "cmbEndMintingYearEra";
         this.cmbEndMintingYearEra.Size = new System.Drawing.Size(39, 21);
         this.cmbEndMintingYearEra.TabIndex = 113;
         // 
         // cmbStartMintingYearEra
         // 
         this.cmbStartMintingYearEra.FormattingEnabled = true;
         this.cmbStartMintingYearEra.Location = new System.Drawing.Point(782, 203);
         this.cmbStartMintingYearEra.Name = "cmbStartMintingYearEra";
         this.cmbStartMintingYearEra.Size = new System.Drawing.Size(39, 21);
         this.cmbStartMintingYearEra.TabIndex = 112;
         // 
         // lblStartMintYear
         // 
         this.lblStartMintYear.AutoSize = true;
         this.lblStartMintYear.Location = new System.Drawing.Point(629, 203);
         this.lblStartMintYear.Name = "lblStartMintYear";
         this.lblStartMintYear.Size = new System.Drawing.Size(94, 13);
         this.lblStartMintYear.TabIndex = 111;
         this.lblStartMintYear.Text = "Start Minting Year:";
         // 
         // lblEndMintingYear
         // 
         this.lblEndMintingYear.AutoSize = true;
         this.lblEndMintingYear.Location = new System.Drawing.Point(632, 229);
         this.lblEndMintingYear.Name = "lblEndMintingYear";
         this.lblEndMintingYear.Size = new System.Drawing.Size(91, 13);
         this.lblEndMintingYear.TabIndex = 110;
         this.lblEndMintingYear.Text = "End Minting Year:";
         // 
         // txtEndMintingYear
         // 
         this.txtEndMintingYear.Location = new System.Drawing.Point(729, 228);
         this.txtEndMintingYear.Name = "txtEndMintingYear";
         this.txtEndMintingYear.Size = new System.Drawing.Size(50, 20);
         this.txtEndMintingYear.TabIndex = 109;
         // 
         // txtStartMintingYear
         // 
         this.txtStartMintingYear.Location = new System.Drawing.Point(729, 202);
         this.txtStartMintingYear.Name = "txtStartMintingYear";
         this.txtStartMintingYear.Size = new System.Drawing.Size(50, 20);
         this.txtStartMintingYear.TabIndex = 108;
         // 
         // frmAddCoin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.ClientSize = new System.Drawing.Size(1014, 469);
         this.Controls.Add(this.cmbEndMintingYearEra);
         this.Controls.Add(this.cmbStartMintingYearEra);
         this.Controls.Add(this.lblStartMintYear);
         this.Controls.Add(this.lblEndMintingYear);
         this.Controls.Add(this.txtEndMintingYear);
         this.Controls.Add(this.txtStartMintingYear);
         this.Controls.Add(this.lnkReverseImage);
         this.Controls.Add(this.picReverse);
         this.Controls.Add(this.lnkObverseImage);
         this.Controls.Add(this.picObverse);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.cmbTitle);
         this.Controls.Add(this.cmbEndRuleYearEra);
         this.Controls.Add(this.cmbStartRuleYearEra);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtEndYear);
         this.Controls.Add(this.txtStartYear);
         this.Controls.Add(this.lblRic);
         this.Controls.Add(this.txtRicIndex);
         this.Controls.Add(this.cmbRicSection);
         this.Controls.Add(this.cmbRicVolume);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.lblGrade);
         this.Controls.Add(this.cmbGrade);
         this.Controls.Add(this.lblPrice);
         this.Controls.Add(this.txtDealer);
         this.Controls.Add(this.cmbDealer);
         this.Controls.Add(this.txtPrice);
         this.Controls.Add(this.lblDieAxis);
         this.Controls.Add(this.txtDieAxis);
         this.Controls.Add(this.lblDiameter);
         this.Controls.Add(this.txtDiamter);
         this.Controls.Add(this.lblWeight);
         this.Controls.Add(this.txtWeight);
         this.Controls.Add(this.lblDescription);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.lblExergue);
         this.Controls.Add(this.txtExergue);
         this.Controls.Add(this.lblReverseLegend);
         this.Controls.Add(this.txtReverseLegend);
         this.Controls.Add(this.lblObverseLegend);
         this.Controls.Add(this.txtObverseLegend);
         this.Controls.Add(this.lblIssuingAuthority);
         this.Controls.Add(this.cmbIssuingAuthority);
         this.Controls.Add(this.lblMint);
         this.Controls.Add(this.cmbMint);
         this.Controls.Add(this.lblCoinType);
         this.Controls.Add(this.cmbCoinType);
         this.Controls.Add(this.lblMaterial);
         this.Controls.Add(this.lblCoinName);
         this.Controls.Add(this.txtCoinName);
         this.Controls.Add(this.cmbMaterial);
         this.Name = "frmAddCoin";
         this.Text = "frmAddCoin";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddCoin_FormClosing);
         this.Load += new System.EventHandler(this.frmAddCoin_Load);
         ((System.ComponentModel.ISupportInitialize)(this.picObverse)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.picReverse)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox cmbMaterial;
      private System.Windows.Forms.TextBox txtCoinName;
      private System.Windows.Forms.Label lblCoinName;
      private System.Windows.Forms.Label lblMaterial;
      private System.Windows.Forms.ComboBox cmbCoinType;
      private System.Windows.Forms.Label lblCoinType;
      private System.Windows.Forms.ComboBox cmbMint;
      private System.Windows.Forms.Label lblMint;
      private System.Windows.Forms.ComboBox cmbIssuingAuthority;
      private System.Windows.Forms.Label lblIssuingAuthority;
      private System.Windows.Forms.TextBox txtObverseLegend;
      private System.Windows.Forms.Label lblObverseLegend;
      private System.Windows.Forms.TextBox txtReverseLegend;
      private System.Windows.Forms.Label lblReverseLegend;
      private System.Windows.Forms.OpenFileDialog ofdCoin;
      private System.Windows.Forms.TextBox txtExergue;
      private System.Windows.Forms.Label lblExergue;
      private System.Windows.Forms.TextBox txtDescription;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.TextBox txtWeight;
      private System.Windows.Forms.Label lblWeight;
      private System.Windows.Forms.TextBox txtDiamter;
      private System.Windows.Forms.Label lblDiameter;
      private System.Windows.Forms.TextBox txtDieAxis;
      private System.Windows.Forms.Label lblDieAxis;
      private System.Windows.Forms.TextBox txtPrice;
      private System.Windows.Forms.ComboBox cmbDealer;
      private System.Windows.Forms.Label txtDealer;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.ComboBox cmbGrade;
      private System.Windows.Forms.Label lblGrade;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.ComboBox cmbRicVolume;
      private System.Windows.Forms.ComboBox cmbRicSection;
      private System.Windows.Forms.TextBox txtRicIndex;
      private System.Windows.Forms.Label lblRic;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cmbTitle;
      private System.Windows.Forms.ComboBox cmbEndRuleYearEra;
      private System.Windows.Forms.ComboBox cmbStartRuleYearEra;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtEndYear;
      private System.Windows.Forms.TextBox txtStartYear;
      private System.Windows.Forms.LinkLabel lnkObverseImage;
      private System.Windows.Forms.PictureBox picObverse;
      private System.Windows.Forms.LinkLabel lnkReverseImage;
      private System.Windows.Forms.PictureBox picReverse;
      private System.Windows.Forms.ComboBox cmbEndMintingYearEra;
      private System.Windows.Forms.ComboBox cmbStartMintingYearEra;
      private System.Windows.Forms.Label lblStartMintYear;
      private System.Windows.Forms.Label lblEndMintingYear;
      private System.Windows.Forms.TextBox txtEndMintingYear;
      private System.Windows.Forms.TextBox txtStartMintingYear;
   }
}