using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcs.arcSpace.Support_Classes;
using bcs.arcSpace.Business_Layer;

namespace bcs.arcSpace.arcSpaceWinform
{
   public partial class frmAddCoin : Form
   {

      private List<Material> lstMaterial;
      private List<IssuingAuthority> lstAuthority;
      private List<Mint> lstMint;
      private List<Grade> lstGrade;
      private List<Coin_Type> lstCoinType;
      private List<RIC> lstRicVolume;
      private List<RIC> lstRicSection;
      private List<IssuingAuthorityTitle> lstTitle;
      private List<Era> lstEra;


     private IssuingAuthorityName objIssuingAuthorityName;
     private List<IssuingAuthorityName> lstIssuingAuthorityName;

     

      private Coin objCoin;

      private BindingSource bnsMaterial;
      private BindingSource bnsAuthority;
      private BindingSource bnsMint;
      private BindingSource bnsGrade;
      private BindingSource bnsCoinType;
      private BindingSource bnsRicVolume;
      private BindingSource bnsRicSection;
      private BindingSource bnsTitle;
      private BindingSource bnsEndRuleYearEra;
      private BindingSource bnsStartRuleYearEra;
      private BindingSource bnsStartMintingYearEra;
      private BindingSource bnsEndMintingYearEra;


      DataGridView pDgv;

      bool DataHasChanged;

      public frmAddCoin(DataGridView dgv)
      {
         pDgv = dgv;
         InitializeComponent();
      }

      private void frmAddCoin_Load(object sender, EventArgs e)
      {

         lstEra = Era_BL.GetEraList();


         this.BindCmbMaterial();
         this.BindCmbIssuingAuthority();
         this.BindCmbMint();
         this.BindCmbGrade();
         this.BindCmbCoinType();
         this.BindCmbRicVolume();
         this.BindCmbRicSection();
         this.BindCmbTitle();
         this.BindCmbStartRuleYearEra();
         this.BindCmbEndRuleYearEra();

         this.InitializeRicVolumeAndRicSection();

         cmbMaterial.DropDownWidth = 25;
         cmbMaterial.TabIndex = 0;
         cmbMaterial.SelectionLength = 0;
         cmbMaterial.DropDownStyle = ComboBoxStyle.DropDown;

         DataHasChanged = false;

         txtStartYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsAuthority, "Start_Year"));
         txtEndYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsAuthority, "End_Year"));

         this.Text  = "Add Coin";

      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         byte[] byteArray = new byte[txtExergue.Text.Length];
         bool insertSuccessful = false;

         objCoin = new Coin();

         objCoin.Coin_Name = txtCoinName.Text;
         objCoin.Coin_Type_Id = Convert.ToInt32(cmbCoinType.SelectedValue);
         objCoin.Material_Id = Convert.ToInt32(cmbMaterial.SelectedValue);
         objCoin.Issuing_Authority_Reign_Id = Convert.ToInt32(cmbIssuingAuthority.SelectedValue);
         objCoin.Mint_Id = Convert.ToInt32(cmbMint.SelectedValue);
         objCoin.Obverse_Legend = txtObverseLegend.Text;
         objCoin.Reverse_Legend = txtReverseLegend.Text;
         objCoin.Exergue = txtExergue.Text;
         objCoin.Coin_Description = txtDescription.Text;
         objCoin.Weight = Convert.ToDecimal(txtWeight.Text);
         objCoin.Diameter = Convert.ToDecimal(txtDiamter.Text);
         objCoin.Die_Axis = Convert.ToInt32(txtDieAxis.Text);
         objCoin.Grade_Id = Convert.ToInt32(cmbGrade.SelectedValue);
         objCoin.Dealer_Id = 1;
         objCoin.Price = Convert.ToDecimal(txtPrice.Text);
         objCoin.Obverse_Image = Coin_BL.ConvertImageToByteArray(picObverse.Image);
         objCoin.Reverse_Image = Coin_BL.ConvertImageToByteArray(picReverse.Image);
   //      objCoin.

         objCoin.Ric_Volume_Id = (int) cmbRicVolume.SelectedValue;
         objCoin.Ric_Section_Id = (int)cmbRicSection.SelectedValue;
         objCoin.Ric_Index = txtRicIndex.Text;

         // lstCoin[0].Mint_Id = (int) cmbMint.SelectedValue;

         objCoin.Start_Minting_Year = Convert.ToInt32(txtStartYear.Text);
         objCoin.End_Minting_Year = Convert.ToInt32(txtEndYear);
         objCoin.Start_Minting_Year_Era = Convert.ToInt32(cmbStartMintingYearEra.SelectedValue);
         objCoin.End_Minting_Year_Era = Convert.ToInt32(cmbEndMintingYearEra.SelectedValue);


         insertSuccessful = Coin_BL.InsertCoin(objCoin);
         this.Close();
      }

      private void frmAddCoin_FormClosing(object sender, FormClosingEventArgs e)
      {
         List<CoinDisplaySet> lstCoinDisplaySet = CoinDisplaySet_BL.GetCoinDisplaySetList();
         BindingSource bs = new BindingSource();
         bs.DataSource = lstCoinDisplaySet;
         pDgv.DataSource = bs.DataSource;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         if (DataHasChanged)
         {
            // message box goes here.
         }
         this.Close();
         DataHasChanged = false;
      }

      private void lnkObverseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         this.LoadPictureBox(picObverse);
      }

      private void lnkReverseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         this.LoadPictureBox(picReverse);
      }


      private void txtCoinName_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbCoinType_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbIssuingAuthority_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbMint_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtObverseLegend_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtReverseLegend_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtExergue_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtDescription_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtWeight_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtDiamter_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtDieAxis_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbDealer_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void txtPrice_TextChanged(object sender, EventArgs e)
      {
         DataHasChanged = true;
      }

      private void cmbRicVolume_SelectedValueChanged(object sender, EventArgs e)
      {

      }

      private void cmbRicVolume_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void cmbRicVolume_SelectionChangeCommitted(object sender, EventArgs e)
      {
         this.AlignRicVolumeAndRicSelection();
      }


      #region Special purpose methods

      private void BindCmbMaterial()
      {
         bnsMaterial = new BindingSource();
         lstMaterial = Material_BL.GetMaterialList();
         bnsMaterial.DataSource = lstMaterial;
         cmbMaterial.DataSource = bnsMaterial.DataSource;
         cmbMaterial.DisplayMember = "Material_Description";
         cmbMaterial.ValueMember = "Material_Id";
         return;
      }

      private void BindCmbIssuingAuthority()
      {
         bnsAuthority = new BindingSource();
         lstAuthority = IssuingAuthority_BL.GetIssuingAuthorityList();
         bnsAuthority.DataSource = lstAuthority;
         cmbIssuingAuthority.DataSource = bnsAuthority.DataSource;
         cmbIssuingAuthority.DisplayMember = "Issuing_Authority_Name";
         cmbIssuingAuthority.ValueMember = "Issuing_Authority_Reign_Id";
         return;
      }

      private void BindCmbMint()
      {
         bnsMint = new BindingSource();
         lstMint = Mint_BL.GetMintList();
         bnsMint.DataSource = lstMint;
         cmbMint.DataSource = bnsMint.DataSource;
         cmbMint.DisplayMember = "Mint_Name";
         cmbMint.ValueMember = "Mint_Id";
         return;
      }

      private void BindCmbGrade()
      {
         bnsGrade = new BindingSource();
         lstGrade = Grade_BL.GetGradeList();
         bnsGrade.DataSource = lstGrade;
         cmbGrade.DataSource = bnsGrade.DataSource;
         cmbGrade.DisplayMember = "Grade_Code";
         cmbGrade.ValueMember = "Grade_Id";
         return;
      }

      private void BindCmbCoinType()
      {
         bnsCoinType = new BindingSource();
         lstCoinType = Coin_Type_BL.GetCoinTypeList();
         bnsCoinType.DataSource = lstCoinType;
         cmbCoinType.DataSource = bnsCoinType.DataSource;
         cmbCoinType.DisplayMember = "Coin_Type_Name";
         cmbCoinType.ValueMember = "Coin_Type_Id";
         return;
      }

      private void BindCmbRicVolume()
      {
         bnsRicVolume = new BindingSource();
         lstRicVolume = RIC_BL.GetRicVolumeList();
         bnsRicVolume.DataSource = lstRicVolume;
         cmbRicVolume.DataSource = bnsRicVolume.DataSource;
         cmbRicVolume.DisplayMember = "Ric_Volume";
         cmbRicVolume.ValueMember = "Ric_Volume_Id";
         return;
      }

      private void BindCmbRicSection()
      {
         bnsRicSection = new BindingSource();
         lstRicSection = RIC_BL.GetRicSectionList();
         bnsRicSection.DataSource = lstRicSection;
         cmbRicSection.DataSource = bnsRicSection.DataSource;
         cmbRicSection.DisplayMember = "Ric_Section";
         cmbRicSection.ValueMember = "Ric_Section_Id";
         return;
      }


      private void BindCmbTitle()
      {
         bnsTitle = new BindingSource();
         lstTitle = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleList();
         bnsTitle.DataSource = lstTitle;
         cmbTitle.DataSource = bnsTitle.DataSource;
         cmbTitle.DisplayMember = "Issuing_Authority_Title";
         cmbTitle.ValueMember = "Title_Id";
         return;
      }



      private void BindCmbStartRuleYearEra()
      {
         bnsStartRuleYearEra = new BindingSource();
         lstEra = Era_BL.GetEraList();
         bnsStartRuleYearEra.DataSource = lstEra;
         cmbStartRuleYearEra.DataSource = bnsStartRuleYearEra.DataSource;
         cmbStartRuleYearEra.DisplayMember = "Era_Name";
         cmbStartRuleYearEra.ValueMember = "Era_Id";
         return;
      }


      private void BindCmbStartMintingYearEra()
      {
         bnsStartRuleYearEra = new BindingSource();
         lstEra = Era_BL.GetEraList();
         bnsStartMintingYearEra.DataSource = lstEra;
         cmbStartMintingYearEra.DataSource = bnsStartRuleYearEra.DataSource;
         cmbStartMintingYearEra.DisplayMember = "Era_Name";
         cmbStartMintingYearEra.ValueMember = "Era_Id";
         return;
      }


      private void BindCmbEndRuleYearEra()
      {
         bnsEndRuleYearEra = new BindingSource();
         lstEra = Era_BL.GetEraList();
         bnsEndRuleYearEra.DataSource = lstEra;
         cmbEndRuleYearEra.DataSource = bnsEndRuleYearEra.DataSource;
         cmbEndRuleYearEra.DisplayMember = "Era_Name";
         cmbEndRuleYearEra.ValueMember = "Era_Id";
         return;
      }



      private void LoadPictureBox(PictureBox picBox)
      {
         OpenFileDialog ofd = new OpenFileDialog();
         ofd.Filter = "images| *.JPG; *.PNG; *.GJF"; // you can add any other image type
         if (ofd.ShowDialog() == DialogResult.OK)
         {
               // mch 02/25/2019    mchTest
          //  picBox.SizeMode = PictureBoxSizeMode.AutoSize;
            picBox.Size = new Size(175, 175);
            picBox.Image = Image.FromFile(ofd.FileName);
            DataHasChanged = true;
         }
      }

      private void AlignRicVolumeAndRicSelection()
      {
         Coin c = new Coin();
         c.Ric_Volume_Id = (int)cmbRicVolume.SelectedValue;
         List<RIC> lstRic = RIC_BL.GetRicSectionList(c);

         bnsRicSection = null;  // mch 09/17/2017

         if ((lstRic != null) && lstRic.Count != 0)
         {
            bnsRicSection = new BindingSource();
            bnsRicSection.DataSource = lstRic;
            cmbRicSection.DataSource = bnsRicSection.DataSource;
         }

      }

      private void InitializeRicVolumeAndRicSection()
      {
         int idx;
         idx = cmbRicVolume.FindString("I");
         cmbRicVolume.SelectedIndex = idx;
         this.AlignRicVolumeAndRicSelection();
      }

      #endregion Special purpose methods


      #region Unused methods

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

      private void cmbIssuingAuthority_KeyUp(object sender, KeyEventArgs e)
      {
         cmbIssuingAuthority.SelectionStart = cmbIssuingAuthority.Text.Length;
         cmbIssuingAuthority.SelectionLength = 0;
      }

      private void ofdCoin_FileOk(object sender, CancelEventArgs e)
      {

      }




      #endregion Unused methods

      private void label2_Click(object sender, EventArgs e)
      {

      }
   }
}
