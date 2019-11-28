using bcs.arcSpace.Business_Layer;
using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bcs.arcSpace.arcSpaceWinform
{
   public partial class frmIssuingAuthorityName : Form
   {
      private IssuingAuthorityName objIssuingAuthorityName;
      private List<IssuingAuthorityName> lstIssuingAuthorityName;

      private BindingSource bnsIssuingAuthorityName;

      public frmIssuingAuthorityName()
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         this.bnsIssuingAuthorityName = new BindingSource();

         this.lstIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameList();

         this.bnsIssuingAuthorityName.DataSource = this.lstIssuingAuthorityName;

         this.InitializeComponent();

         this.bnvIssuingAuthorityName.BindingSource = this.bnsIssuingAuthorityName;

         this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsIssuingAuthorityName, "Issuing_Authority_Name", true));
         this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsIssuingAuthorityName, "Issuing_Authority_Full_Name", true));
      }

      public frmIssuingAuthorityName(IssuingAuthorityName objIssuingAuthorityName)
      {
         this.txtName = new TextBox();
         this.txtFullName = new TextBox();

         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject;
         this.bnsIssuingAuthorityName = new BindingSource();

         this.InitializeComponent();

         if (objIssuingAuthorityName != null)
         {
            this.txtName.Text = objIssuingAuthorityName.Issuing_Authority_Name;
         }
      }

      private void frmIssuingAuthorityName_Load(object sender, EventArgs e)
      {
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<IssuingAuthorityName>.recordSaveType)
         {
            case BusinessLayer<IssuingAuthorityName>.ObjectSaveType.InsertObject:
               IssuingAuthorityName_BL.InsertIssuingAuthorityName(this.objIssuingAuthorityName);
               break;

            case BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject:
               this.objIssuingAuthorityName = (IssuingAuthorityName)this.bnsIssuingAuthorityName.Current;
               IssuingAuthorityName_BL.UpdateIssuingAuthorityName(this.objIssuingAuthorityName);
               break;
         }

         this.lstIssuingAuthorityName = IssuingAuthorityName_BL.GetIssuingAuthorityNameList();
         this.bnsIssuingAuthorityName.DataSource = this.lstIssuingAuthorityName;
         this.bnvIssuingAuthorityName.BindingSource = this.bnsIssuingAuthorityName;
      }


      private void txtFullName_TextChanged(object sender, EventArgs e)
      {
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.InsertObject;
         objIssuingAuthorityName = (IssuingAuthorityName) bnsIssuingAuthorityName.Current;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityName = BusinessLayer<IssuingAuthorityName>.ReturnCurrentTypeObject(bnsIssuingAuthorityName);
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityName = (IssuingAuthorityName) bnsIssuingAuthorityName.Current;
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityName = (IssuingAuthorityName) bnsIssuingAuthorityName.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject;
         objIssuingAuthorityName = (IssuingAuthorityName) bnsIssuingAuthorityName.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityName>.recordSaveType = BusinessLayer<IssuingAuthorityName>.ObjectSaveType.UpdateObject;
         IssuingAuthorityName_BL.DeleteIssuingAuthorityName(objIssuingAuthorityName);
         objIssuingAuthorityName = (IssuingAuthorityName) bnsIssuingAuthorityName.Current;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}