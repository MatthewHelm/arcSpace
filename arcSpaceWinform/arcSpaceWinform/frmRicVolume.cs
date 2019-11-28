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
   public partial class frmRicVolume : Form
   {
      RIC objRic;
      List<RIC> lstRic;

      BindingSource bsRic;

      public frmRicVolume()
      {
         InitializeComponent();
      }

      private void frmRicVolume_Load(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;

         bsRic = new BindingSource();

         lstRic = RIC_BL.GetRicVolumeList();

         bsRic.DataSource = lstRic;

         bnvRic.BindingSource = bsRic;

         txtRicVolume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRic, "Ric_Volume", true));
         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRic, "Ric_Volume_Description", true));

         objRic = BusinessLayer<RIC>.ReturnCurrentTypeObject(bsRic);
         this.SetLocation();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<RIC>.recordSaveType)
         {
            case BusinessLayer<RIC>.ObjectSaveType.InsertObject:
               RIC_BL.InsertRicVolume(objRic);
               break;
            case BusinessLayer<RIC>.ObjectSaveType.UpdateObject:
               objRic = (RIC) bsRic.Current;
               RIC_BL.UpdateRicVolume(objRic);
               break;
         }

         lstRic = RIC_BL.GetRicVolumeList();
         bsRic.DataSource = lstRic;
         bnvRic.BindingSource = bsRic;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = BusinessLayer<RIC>.ReturnCurrentTypeObject(bsRic);
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = (RIC) bsRic.Current;
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = (RIC) bsRic.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = (RIC) bsRic.Current;
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.InsertObject;
         objRic = (RIC ) bsRic.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         RIC_BL.DeleteRicVolume(objRic);
         objRic = (RIC) bsRic.Current;
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
   }
}
