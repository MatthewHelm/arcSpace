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
   public partial class frmTitle : Form
   {
      IssuingAuthorityTitle objTitle;
      List<IssuingAuthorityTitle> lstTitle;

      private BindingSource bnsTitle;

      public frmTitle()
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         bnsTitle = new BindingSource();

         lstTitle = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleList();

         bnsTitle.DataSource = lstTitle;

         InitializeComponent();

         bnvTitle.BindingSource = bnsTitle;

         txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsTitle, "Issuing_Authority_Title", true));
         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsTitle, "Description", true));
      }

      private void frmTitle_Load(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         objTitle = BusinessLayer<IssuingAuthorityTitle>.ReturnCurrentTypeObject(bnsTitle);
         this.SetLocation();

         this.Text = "Add/Modify/Delete Title";
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<IssuingAuthorityTitle>.recordSaveType)
         {
            case BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.InsertObject:
               IssuingAuthorityTitle_BL.InsertIssuingAuthorityTitle(objTitle);
               break;
            case BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject:
               objTitle = (IssuingAuthorityTitle) bnsTitle.Current;
               IssuingAuthorityTitle_BL.UpdateIssuingAuthorityTitle(objTitle);
               break;
         }

         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         lstTitle = IssuingAuthorityTitle_BL.GetIssuingAuthorityTitleList();
         bnsTitle.DataSource = lstTitle;
         bnvTitle.BindingSource = bnsTitle;
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.InsertObject;
         objTitle = (IssuingAuthorityTitle) bnsTitle.Current;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         objTitle = BusinessLayer<IssuingAuthorityTitle>.ReturnCurrentTypeObject(bnsTitle);
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         objTitle = (IssuingAuthorityTitle) bnsTitle.Current;
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         objTitle = (IssuingAuthorityTitle) bnsTitle.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
         objTitle = (IssuingAuthorityTitle) bnsTitle.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         IssuingAuthorityTitle_BL.DeleteIssuingAuthorityTitle(objTitle);
         objTitle = (IssuingAuthorityTitle)bnsTitle.Current;
         BusinessLayer<IssuingAuthorityTitle>.recordSaveType = BusinessLayer<IssuingAuthorityTitle>.ObjectSaveType.UpdateObject;
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

      private void lblDescription_Click(object sender, EventArgs e)
      {

      }
   }
}
