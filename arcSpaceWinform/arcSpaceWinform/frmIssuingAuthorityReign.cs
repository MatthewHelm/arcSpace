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
   public partial class frmIssuingAuthorityReign : Form
   {

      private IssuingAuthorityReign objIssuingAuthorityReign;

      private List<Period> lstPeriod;
      private List<Era> lstEra;
      private List<IssuingAuthorityTitle> lstTitle;
      private List<IssuingAuthorityName> lstIssuingAuthorityName;

      private List<IssuingAuthorityReign> lstIssuingAuthorityReign;

      private BindingSource bnsIssuingAuthorityReign;
      private BindingSource bnsPeriod;
      private BindingSource bnsStartRuleYearEra;
      private BindingSource bnsEndRuleYearEra;
      private BindingSource bnsTitle;
      private BindingSource bnsIssuingAuthorityName;

   //   private BindingSource bnsIssuingAuthorityReign;

      public frmIssuingAuthorityReign()
      {
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;
         bnsIssuingAuthorityReign = new BindingSource();
         bnsIssuingAuthorityName = new BindingSource();

         lstIssuingAuthorityReign = IssuingAuthorityReign_BL.GetIssuingAuthorityReignList();
         bnsIssuingAuthorityReign.DataSource = lstIssuingAuthorityReign;

         lstIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameList();
         bnsIssuingAuthorityName.DataSource = lstIssuingAuthorityName;

         InitializeComponent();

         bnvIssuingAuthorityReign.BindingSource = bnsIssuingAuthorityReign;

         txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsIssuingAuthorityReign, "Issuing_Authority_Full_Name", true));
         txtBiography.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsIssuingAuthorityReign, "Issuing_Authority_Reign_Biography", true));

         txtStartYear.DataBindings.Add("Text", bnsIssuingAuthorityReign, "Reign_Start_Year", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty, "0");
         txtStartYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsIssuingAuthorityReign, "Reign_Start_Era_Id", true));
         txtEndYear.DataBindings.Add("Text", bnsIssuingAuthorityReign, "Reign_End_Year", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty, "0");
         txtStartYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsIssuingAuthorityReign, "Reign_End_Era_Id", true));
      }

      private void frmIssuingAuthorityReign_Load(object sender, EventArgs e)
      {
         string item = null;
         int idx = 0;

         this.objIssuingAuthorityReign = BusinessLayer<IssuingAuthorityReign>.ReturnCurrentTypeObject(bnsIssuingAuthorityReign);
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;

         IssuingAuthority tmpIssuingAuthority;
         IssuingAuthorityName tmpIssuingAuthorityName;

         this.BindCmbPeriod();
         this.BindCmbStartRuleYearEra();
         this.BindCmbEndRuleYearEra();
         this.BindCmbTitle();
         this.BindCmbIssuingAuthorityName();

         item = Period_BL.GetPeriodGivenId(lstPeriod, this.objIssuingAuthorityReign.Period_Id);
         idx = cmbPeriod.FindString(item);
         cmbPeriod.SelectedIndex = idx;

         item = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleGivenId(lstTitle, this.objIssuingAuthorityReign.Issuing_Authority_Title_Id);
         idx = cmbTitle.FindString(item);
         cmbTitle.SelectedIndex = idx;

         tmpIssuingAuthority = IssuingAuthority_BL.GetIssuingAuthorityObject(this.objIssuingAuthorityReign.Issuing_Authority_Id);
         tmpIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameObject(tmpIssuingAuthority.Issuing_Authority_Name_Id);

         item = tmpIssuingAuthorityName.Issuing_Authority_Name;
         idx = cmbIssuingAuthorityName.FindString(item);
         cmbIssuingAuthorityName.SelectedIndex = idx;

         if (!(string.IsNullOrEmpty(tmpIssuingAuthorityName.Issuing_Authority_Full_Name.Trim())))
         {
            item = tmpIssuingAuthorityName.Issuing_Authority_Full_Name;
            txtFullName.Text = item;
         }

         item = Era_BL.GetEraGivenId(lstEra, this.objIssuingAuthorityReign.Reign_Start_Era_Id);
         idx = cmbStartRuleYearEra.FindString(item);
         cmbStartRuleYearEra.SelectedIndex = idx;

         item = Era_BL.GetEraGivenId(lstEra, this.objIssuingAuthorityReign.Reign_End_Era_Id);
         idx = cmbEndRuleYearEra.FindString(item);
         cmbEndRuleYearEra.SelectedIndex = idx;

         this.SetLocation();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<IssuingAuthority>.recordSaveType)
         {
            case BusinessLayer<IssuingAuthority>.ObjectSaveType.InsertObject:
               IssuingAuthorityReign_BL.InsertIssuingAuthorityReign(objIssuingAuthorityReign);
               break;
            case BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject:
               objIssuingAuthorityReign = (IssuingAuthorityReign) bnsIssuingAuthorityReign.Current;
               IssuingAuthorityReign_BL.UpdateIssuingAuthorityReign(objIssuingAuthorityReign);
               break;
         }

         lstIssuingAuthorityReign = IssuingAuthorityReign_BL.GetIssuingAuthorityReignList();
         bnsIssuingAuthorityReign.DataSource = lstIssuingAuthorityReign;
         bnvIssuingAuthorityReign.BindingSource = bnsIssuingAuthorityReign;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityReign = BusinessLayer<IssuingAuthorityReign>.ReturnCurrentTypeObject(bnsIssuingAuthorityReign);
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.InsertObject;
         objIssuingAuthorityReign = (IssuingAuthorityReign) bnsIssuingAuthorityReign.Current;
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityReign = (IssuingAuthorityReign) bnsIssuingAuthorityReign.Current;
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityReign = (IssuingAuthorityReign) bnsIssuingAuthorityReign.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityReign = (IssuingAuthorityReign) bnsIssuingAuthorityReign.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         IssuingAuthorityReign_BL.DeleteIssuingAuthorityReign(objIssuingAuthorityReign);
         objIssuingAuthorityReign = (IssuingAuthorityReign) bnsIssuingAuthorityReign.Current;

         BusinessLayer<IssuingAuthority>.recordSaveType = BusinessLayer<IssuingAuthority>.ObjectSaveType.UpdateObject;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void SetLocation()
      {
         Point stndrdPoint = new Point();

         stndrdPoint.X = 200;
         stndrdPoint.Y = 250;

         this.Location = stndrdPoint;
      }


      private void BindCmbPeriod()
      {
         bnsPeriod = new BindingSource();
         lstPeriod = Period_BL.GetPeriodList();
         bnsPeriod.DataSource = lstPeriod;
         cmbPeriod.DataSource = bnsPeriod.DataSource;
         cmbPeriod.DisplayMember = "Period_Name";
         cmbPeriod.ValueMember = "Period_Id";
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

      private void BindCmbIssuingAuthorityName()
      {
         bnsIssuingAuthorityName = new BindingSource();
         lstIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameList();
         bnsIssuingAuthorityName.DataSource = lstIssuingAuthorityName;
         cmbIssuingAuthorityName.DataSource = bnsIssuingAuthorityName.DataSource;
         cmbIssuingAuthorityName.DisplayMember = "Issuing_Authority_Name";
         cmbIssuingAuthorityName.ValueMember = "Issuing_Authority_Name_Id";
         return;
      }

      private void cmbIssuingAuthorityName_SelectedValueChanged(object sender, EventArgs e)
      {
      }

      private void cmbPeriod_SelectedValueChanged(object sender, EventArgs e)
      {
      }

      private void LblPeriod_Click(object sender, EventArgs e)
      {
      }

      private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
      {
      }

      private void label5_Click(object sender, EventArgs e)
      {
      }

      private void label2_Click(object sender, EventArgs e)
      {
      }

      private void label1_Click(object sender, EventArgs e)
      {
      }

      private void lblNotesAboutReign_Click(object sender, EventArgs e)
      {
      }

      private void label6_Click(object sender, EventArgs e)
      {
      }

      private void lblBiography_Click(object sender, EventArgs e)
      {
      }

      private void lblFullName_Click(object sender, EventArgs e)
      {
      }

      private void lblName_Click(object sender, EventArgs e)
      {
      }

      private void cmbTitle_DisplayMemberChanged(object sender, EventArgs e)
      {
      }
   }
}
