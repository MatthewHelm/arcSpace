using bcs.arcSpace.Business_Layer;
using bcs.arcSpace.Global_Layer;
using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bcs.arcSpace.arcSpaceWinform
{
   public partial class frmModifyCoin : Form
   {
      //Created following on 07/25/2019
      //******************************************************

      // List objects to fill comboboxes

      private List<IssuingAuthorityName> lstIssuingAuthorityName;
//      private List<IssuingAuthorityReign> lstIssuingAuthorityReign;

      //*******************************************************

      private List<Coin> lstCoin;
      private List<Material> lstMaterial;
      private List<IssuingAuthority> lstAuthority;


      private List<Coin_Type> lstCoinType;

      private List<Mint> lstMint;
      private List<Grade> lstGrade;
      private List<RIC> lstRicVolume;
      private List<RIC> lstRicSection;
      private List<IssuingAuthorityTitle> lstTitle;
      private List<Era> lstEra;

      private Coin coin;
      private BindingSource bnsModifyCoin;
      private BindingSource bnsModifyIssuingAuthorityReign;
      private BindingSource bnsCoinType;
      private BindingSource bnsMaterial;
      private BindingSource bnsMint;
      private BindingSource bnsRicVolume;
      private BindingSource bnsRicSection;
      private BindingSource bnsTitle;
      private BindingSource bnsStartRuleYearEra;
      private BindingSource bnsEndRuleYearEra;

      private DataGridView pDgv;

      /* working methods */
      private IssuingAuthorityReign objIssuingAuthorityReign;
 //     private IssuingAuthorityTitle objIssuingAuthorityTitle;
 //     private Ph
    //  private 
      private int tmpId;
      private string item;
      private int idx;



      public frmModifyCoin(Coin objCoin, DataGridView dgv)
      {
         coin = objCoin;
         InitializeComponent();

         lstCoin = Coin_BL.GetCoin(coin);
         objIssuingAuthorityReign = IssuingAuthorityReign_BL.GetIssuingAuthorityReign(lstCoin[0].Issuing_Authority_Reign_Id);

https://support.microsoft.com/en-us/help/13853/windows-lifecycle-fact-sheet
         pDgv = dgv;

         this.StartPosition = FormStartPosition.Manual;
         this.Left = Globals.frmMainX + 37;

         this.Top = Globals.frmMainY + 37;
      }

      private void frmModifyCoin_Load(object sender, EventArgs e)
      {
         item = null;
         idx = 0;
         lstCoin = Coin_BL.GetCoin(coin);


         // mch 10312019
         // Add status strip details later.
         //stsModifyCoin.Items.Add("Name: " + lstCoin[0].Coin_Name);

         //stsModifyCoin.Text = string.Empty;
         ////      stsModifyCoin.Items[1]
         //stsModifyCoin.RightToLeft = RightToLeft.Yes;
         //ToolStripStatusLabel tsl = new ToolStripStatusLabel("                                                             " + DateTime.Now.ToLongTimeString());
         //tsl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
         //   | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
         //   | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         //tsl.IsLink = false;
         //tsl.Spring = true;

         //tsl.Alignment = ToolStripItemAlignment.Right;


         //stsModifyCoin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsl });

         IssuingAuthorityReign objIssuingAuthorityReign = IssuingAuthorityReign_BL.GetIssuingAuthorityReign(coin.Issuing_Authority_Reign_Id);

         picReverse.BackgroundImageLayout = ImageLayout.Stretch;

         this.BindCmbCoinType();
         this.BindCmbMaterial();
         this.BindCmbIssuingAuthority();
         this.BindCmbMint();
         this.BindCmbGrade();
         this.BindCmbRicVolume();
         this.BindCmbRicSection();
         this.BindCmbTitle();
         this.BindCmbStartRuleYearEra();
         this.BindCmbEndRuleYearEra();
         this.BindCmbIssuingAuthorityName();
         this.BindCmbIssuingAuthorityReign();

         bnsModifyCoin = new BindingSource();
         bnsModifyCoin.DataSource = lstCoin;
         bnsModifyIssuingAuthorityReign = new BindingSource();

         bnsModifyIssuingAuthorityReign.DataSource = objIssuingAuthorityReign;

         txtObverseLegend.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Obverse_Legend", true));
         txtReverseLegend.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Reverse_Legend", true));
         txtExergue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Exergue", true));
         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Coin_Description", true));
         txtWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Weight", true));
         txtDiameter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Diameter", true));
         txtDieAxis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Die_Axis", true));
         txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Price", true));
         txtRicIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyCoin, "Ric_Index", true));
         txtStartYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyIssuingAuthorityReign, "Reign_Start_Year"));   // mch 05182019
         txtEndYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsModifyIssuingAuthorityReign, "Reign_End_Year"));

         // mch 10/06/2019
         picObverse.Size = new Size(172, 172);
         picObverse.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bnsModifyCoin, "Obverse_Image", true));
         picObverse.SizeMode = PictureBoxSizeMode.StretchImage; // PictureBoxSizeMode;

         picReverse.Size = new Size(172, 172);
         picReverse.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bnsModifyCoin, "Reverse_Image", true));

         cmbCoinType.DropDownStyle = ComboBoxStyle.DropDownList;

         // Kludgy solution
         item = Coin_Type_BL.GetCoinTypeGivenId(lstCoinType, lstCoin[0].Coin_Type_Id);
         idx = cmbCoinType.FindString(item);
         cmbCoinType.SelectedIndex = idx;

         item = Material_BL.GetMaterialGivenId(lstMaterial, lstCoin[0].Material_Id);
         item = item.Trim();
         idx = cmbMaterial.FindString(item.Trim());
         cmbMaterial.SelectedIndex = idx;

         /* see Changes 092019.txt  */
         IssuingAuthority objIssuingAuthority = IssuingAuthority_BL.GetIssuingAuthorityObject(objIssuingAuthorityReign.Issuing_Authority_Id);
         IssuingAuthorityName objIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameObject(objIssuingAuthority.Issuing_Authority_Name_Id);
         item = objIssuingAuthorityName.Issuing_Authority_Name;
         idx = cmbIssuingAuthorityName.FindString(item);
         cmbIssuingAuthorityName.SelectedIndex = idx;

         item = Mint_BL.GetMintGivenId(lstMint, lstCoin[0].Mint_Id);
         idx = cmbMint.FindString(item);
         cmbMint.SelectedIndex = idx;

         item = Grade_BL.GetGradeGivenId(lstGrade, lstCoin[0].Grade_Id);
         idx = cmbGrade.FindString(item);
         cmbGrade.SelectedIndex = idx;

         IssuingAuthorityTitle objIssuingAuthorityTitle = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleObject(objIssuingAuthorityReign.Issuing_Authority_Title_Id);
         item = objIssuingAuthorityTitle.Issuing_Authority_Title;

         idx = cmbTitle.FindString(item);
         cmbTitle.SelectedIndex = idx;

         idx = objIssuingAuthorityReign.Reign_Start_Era_Id;
         Era objEra = Era_BL.GetEra(idx);
         item = objEra.Era_Name;
  
         idx = cmbStartRuleYearEra.FindString(item);
         cmbStartRuleYearEra.SelectedIndex = idx;

         idx = objIssuingAuthorityReign.Reign_End_Era_Id;
         objEra = Era_BL.GetEra(idx);
         item = objEra.Era_Name;

         idx = cmbEndRuleYearEra.FindString(item);
         cmbEndRuleYearEra.SelectedIndex = idx;

         RIC objRic = RIC_BL.GetRicReference(lstCoin[0]);

         if (objRic != null)
         {
            item = RIC_BL.GetRicVolumeGivenId(lstRicVolume, objRic.Ric_Volume_Id);
            idx = cmbRicVolume.FindString(item);
            cmbRicVolume.SelectedIndex = idx;

            item = RIC_BL.GetRicSectionGivenId(lstRicSection, objRic.Ric_Section_Id);
            idx = cmbRicSection.FindString(item);
            cmbRicSection.SelectedIndex = idx;
         }
         else
         {
            this.InitializeRicVolumeAndRicSection();
         }
         this.Text = "Modify Coin";
         return;
      }

      private void AlignRicVolumeAndRicSelection()
      {
         Coin c = new Coin();
         c.Ric_Volume_Id = (int) cmbRicVolume.SelectedValue;
         List<RIC> lstRic = RIC_BL.GetRicSectionList(c);

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

      private void BindCmbByDataType<T, U, V>(List<T> lst)
      {
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

      private void BindCmbMaterial()
      {
         bnsMaterial = new BindingSource();
         lstMaterial = Material_BL.GetMaterialList();
         bnsMaterial.DataSource = lstMaterial;
         cmbMaterial.DataSource = bnsMaterial.DataSource;
         cmbMaterial.DisplayMember = "Material_Description";
         cmbMaterial.ValueMember = "Material_Id";
      }

      private void BindCmbMint()
      {
         bnsMint = new BindingSource();
         lstMint = Mint_BL.GetMintList();
         bnsMint.DataSource = lstMint;
         cmbMint.DataSource = bnsMint.DataSource;
         cmbMint.DisplayMember = "Mint_Name";
         cmbMint.ValueMember = "Mint_Id";
      }

      private void BindCmbIssuingAuthorityName()
      {
         lstIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameList();
         cmbIssuingAuthorityName.DataSource = lstIssuingAuthorityName;
         cmbIssuingAuthorityName.DisplayMember = "Issuing_Authority_Name";
         cmbIssuingAuthorityName.ValueMember = "Issuing_Authority_Name_Id";
      }

      private void BindCmbIssuingAuthorityReign()
      {
 //        lstIssuingAuthorityReign = IssuingAuthorityReign_BL.GetIssuingAuthorityReignList();
      }

      private void BindCmbIssuingAuthority()
      {
         lstAuthority = IssuingAuthority_BL.GetIssuingAuthorityList();
      }

      private void BindCmbGrade()
      {
         lstGrade = Grade_BL.GetGradeList();
         cmbGrade.DataSource = lstGrade;
         cmbGrade.DisplayMember = "Grade_Code";
         cmbGrade.ValueMember = "Grade_Id";
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
            picBox.SizeMode = PictureBoxSizeMode.AutoSize;
            picBox.Image = Image.FromFile(ofd.FileName);
         }
      }

      private void cmbCoinType_SelectedValueChanged(object sender, EventArgs e)
      {
      }


      /// <summary>
      /// THE WRONG COIN IS BEING UPDATED. FIX THIS.  mch 10/11/2019
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSave_Click(object sender, EventArgs e)
      {
         // Coin updates
         lstCoin[0].Coin_Type_Id = Convert.ToInt32(cmbCoinType.SelectedValue);
         lstCoin[0].Material_Id = (int) cmbMaterial.SelectedValue;
         lstCoin[0].Diameter = Convert.ToDecimal(txtDiameter.Text);
         lstCoin[0].Mint_Id = (int) cmbMint.SelectedValue;
         lstCoin[0].Grade_Id = (int) cmbGrade.SelectedValue;
         lstCoin[0].Obverse_Image = Coin_BL.ConvertImageToByteArray(picObverse.Image);
         lstCoin[0].Reverse_Image = Coin_BL.ConvertImageToByteArray(picReverse.Image);
         lstCoin[0].Coin_Description = txtDescription.Text;
         lstCoin[0].Mint_Id = ((int) cmbMint.SelectedValue);
         lstCoin[0].Obverse_Legend = txtObverseLegend.Text;
         lstCoin[0].Reverse_Legend = txtReverseLegend.Text;
         lstCoin[0].Exergue = txtExergue.Text;
         lstCoin[0].Coin_Description = txtDescription.Text;

         // Accessing appropriate IssuingAuthorityReign object
         tmpId = lstCoin[0].Issuing_Authority_Reign_Id;
         objIssuingAuthorityReign = IssuingAuthorityReign_BL.GetIssuingAuthorityReign(tmpId);

         // IssuingAuthorityReign updates
         if (!string.IsNullOrEmpty(txtStartYear.Text))
         {
            objIssuingAuthorityReign.Reign_Start_Year = Convert.ToInt32(txtStartYear.Text);
         }

         if (Convert.ToInt32(cmbStartRuleYearEra.SelectedValue) > 0)
         {
            objIssuingAuthorityReign.Reign_Start_Era_Id = ((int) cmbStartRuleYearEra.SelectedValue);
         }

         if (!string.IsNullOrEmpty(txtEndYear.Text))
         {
            objIssuingAuthorityReign.Reign_End_Year = Convert.ToInt32(txtEndYear.Text);
         }

         if (Convert.ToInt32(cmbEndRuleYearEra.SelectedValue) > 0)
         {
            objIssuingAuthorityReign.Reign_End_Era_Id = ((int) cmbEndRuleYearEra.SelectedValue);
         }

         if (Convert.ToInt32(cmbTitle.SelectedValue) > 0)
         {
            objIssuingAuthorityReign.Issuing_Authority_Title_Id = ((int) cmbTitle.SelectedValue);
         }



         // Setting RIC settings for update.
         if (!String.IsNullOrEmpty(Convert.ToString(cmbRicVolume.SelectedValue)) && !String.IsNullOrEmpty(Convert.ToString((cmbRicSection.SelectedValue))) && !String.IsNullOrEmpty(txtRicIndex.Text))
         {
            lstCoin[0].Ric_Volume_Id = (int) cmbRicVolume.SelectedValue;
            lstCoin[0].Ric_Section_Id = (int) cmbRicSection.SelectedValue;
            lstCoin[0].Ric_Index = txtRicIndex.Text;
         }

         Coin_BL.UpdateCoin(lstCoin[0]);
         IssuingAuthorityReign_BL.UpdateIssuingAuthorityReign(objIssuingAuthorityReign);   // mch 08122019
         btnCancel.Text = "Close";
      }

      private void picObverse_Click(object sender, EventArgs e)
      {
      }

      private void lnkObverseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         this.LoadPictureBox(picObverse);
      }

      private void lnkReverseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         this.LoadPictureBox(picReverse);
      }

      private void frmModifyCoin_FormClosing(object sender, FormClosingEventArgs e)
      {
         List<CoinDisplaySet> lstCoinDisplaySet = CoinDisplaySet_BL.GetCoinDisplaySetList();
         BindingSource bs = new BindingSource();
         bs.DataSource = lstCoinDisplaySet;
         pDgv.DataSource = bs.DataSource;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void cmbRicVolume_SelectionChangeCommitted(object sender, EventArgs e)
      {
         this.AlignRicVolumeAndRicSelection();
      }

      private void btnPrintLabel_Click(object sender, EventArgs e)
      {
      }

      private void btnPrintDetails_Click(object sender, EventArgs e)
      {
      }

      private void lblMaterial_Click(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthority_TextChanged(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthority_SelectedValueChanged(object sender, EventArgs e)
      {
      }

      private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
      {
         // mch 10/13/2019  fix this.
         //if (!string.IsNullOrEmpty(cmbTitle.SelectedItem.ToString()))
         //{

         //   tmpId = objIssuingAuthorityReign.Issuing_Authority_Title_Id;
         //   item = cmbTitle.SelectedItem.ToString();
         //   lstTitle = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleList();


         //   objIssuingAuthorityTitle = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleObject(tmpId);

         //   item = Grade_BL.GetGradeGivenId(lstGrade, lstCoin[0].Grade_Id);
         //   idx = cmbGrade.FindString(item);
         //   cmbGrade.SelectedIndex = idx;



         //}
      }

      private void cmbTitle_SelectedValueChanged(object sender, EventArgs e)
      {
         //if ((objIssuingAuthorityReign != (IssuingAuthorityReign) null) && (cmbTitle != null))
         //{
         //   // objIssuingAuthorityReign.Issuing_Authority_Title_Id = ((IssuingAuthorityTitle) cmbTitle.SelectedValue).Title_Id;
         //  objIssuingAuthorityReign.Issuing_Authority_Title_Id = ((int) cmbTitle.SelectedValue);
         //}
      }

      private void cmbTitle_ValueMemberChanged(object sender, EventArgs e)
      {

      }

      private void cmbTitle_TextUpdate(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_KeyDown(object sender, KeyEventArgs e)
      {
         int tmpId = -1;
         string newIssuingAuthorityName = null;

         if (e.KeyValue == (char) 13)
         {
            newIssuingAuthorityName = ((string) ((ComboBox) sender).Text).Trim();
            if (!(string.IsNullOrEmpty(newIssuingAuthorityName)))
            {
               tmpId = IssuingAuthorityName_BL.GetIssuingAuthorityNameIdFromListGivenName(lstIssuingAuthorityName, newIssuingAuthorityName);
            }

            if (tmpId == -1)
            {
               IssuingAuthorityName objIssuingAuthorityName = new IssuingAuthorityName();
               objIssuingAuthorityName.Issuing_Authority_Name = newIssuingAuthorityName;
               frmIssuingAuthorityName f = new frmIssuingAuthorityName(objIssuingAuthorityName);
               f.Show();
            }
         }
      }

      private void cmbIssuingAuthorityName_TextChanged(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_TextUpdate(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_ValueMemberChanged(object sender, EventArgs e)
      {

      }

      private void cmbIssuingAuthorityName_Leave(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_SelectedValueChanged(object sender, EventArgs e)
      {

      }

      private void cmbIssuingAuthorityName_DisplayMemberChanged(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_KeyUp(object sender, KeyEventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_SelectionChangeCommitted(object sender, EventArgs e)
      {
      }

      private void cmbIssuingAuthorityName_KeyPress(object sender, KeyPressEventArgs e)
      {
         int tmpId = -1;
         string UserEnteredIssuingAuthorityName = string.Empty;

         IssuingAuthorityName objIssuingAuthorityName1 = new IssuingAuthorityName();

         UserEnteredIssuingAuthorityName = ((string) ((ComboBox) sender).Text).Trim();

         if (e.KeyChar == (char) 13)
         {
            if (!(string.IsNullOrEmpty(UserEnteredIssuingAuthorityName)))
            {
               tmpId = IssuingAuthorityName_BL.GetIssuingAuthorityNameIdFromListGivenName(lstIssuingAuthorityName, UserEnteredIssuingAuthorityName);
            }

            if (tmpId == -1)
            {
               objIssuingAuthorityName1.Issuing_Authority_Name = UserEnteredIssuingAuthorityName;
               frmIssuingAuthorityName f = new frmIssuingAuthorityName(objIssuingAuthorityName1);
            }
         }
      }

      private void cmbIssuingAuthorityName_DataSourceChanged(object sender, EventArgs e)
      {
      }

      private void picReverse_Click(object sender, EventArgs e)
      {
      }

      private void label4_Click(object sender, EventArgs e)
      {
      }

      private void btnCancel_Leave(object sender, EventArgs e)
      {
         btnCancel.Text = "Cancel";
      }

      private void txtStartYear_TextChanged(object sender, EventArgs e)
      {
         objIssuingAuthorityReign.Reign_Start_Year = Convert.ToInt32(txtStartYear.Text);
      }
   }
}