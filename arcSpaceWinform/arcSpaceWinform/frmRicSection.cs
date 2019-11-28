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
   public partial class frmRicSection : Form
   {
      private List<RIC> lstRic;
      private List<RIC> lstRicVolume;
      private RIC objRic;
      private RIC objRicVolume;

      private BindingSource bsRic;
      private BindingSource bnsRicVolume;

      private string item;
      private int idx;

      public frmRicSection()
      {
         InitializeComponent();
      }

      private void frmRicSection_Load(object sender, EventArgs e)
      {
         item = null;
         idx = 0;

         this.BindCmbRicVolume();

         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;

         bsRic = new BindingSource();

         lstRic = RIC_BL.GetRicSectionList();

         bsRic.DataSource = lstRic;

         bnvRic.BindingSource = bsRic;

         txtRicSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRic, "Ric_Section", true));
         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRic, "Ric_Section_Description", true));

         objRic = BusinessLayer<RIC>.ReturnCurrentTypeObject(bsRic);

         if (lstRic.Count != 0)
         {
            item = RIC_BL.GetRicVolumeGivenId(lstRicVolume, objRic.Ric_Volume_Id);
            idx = cmbRicVolume.FindString(item);
            cmbRicVolume.SelectedIndex = idx;
         }

         this.SetLocation();

      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<RIC>.recordSaveType)
         {
            case BusinessLayer<RIC>.ObjectSaveType.InsertObject:
               objRic.Ric_Volume_Id = (int) cmbRicVolume.SelectedValue;   // The volume id has not been set.  This is where it gets assigned.
               RIC_BL.InsertRicSection(objRic);
               break;
            case BusinessLayer<RIC>.ObjectSaveType.UpdateObject:
               objRic = (RIC) bsRic.Current;
               RIC_BL.UpdateRicSection(objRic);
               break;
         }

         lstRic = RIC_BL.GetRicSectionList();
         bsRic.DataSource = lstRic;
         bnvRic.BindingSource = bsRic;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = BusinessLayer<RIC>.ReturnCurrentTypeObject(bsRic);
         this.SetCmbRicVolume();
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = (RIC)bsRic.Current;
         this.SetCmbRicVolume();
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = (RIC)bsRic.Current;
         this.SetCmbRicVolume();
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         objRic = (RIC) bsRic.Current;
         this.SetCmbRicVolume();
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.InsertObject;
         objRic = (RIC)bsRic.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<RIC>.recordSaveType = BusinessLayer<RIC>.ObjectSaveType.UpdateObject;
         RIC_BL.DeleteRicSection(objRic);
         objRic = (RIC) bsRic.Current;
         this.SetCmbRicVolume();
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

      private void SetLocation()
      {
         Point stndrdPoint = new Point();

         stndrdPoint.X = 200;
         stndrdPoint.Y = 250;

         this.Location = stndrdPoint;
      }

      public void SetCmbRicVolume()
      {
         if (lstRic.Count != 0)
         {
            item = RIC_BL.GetRicVolumeGivenId(lstRicVolume, objRic.Ric_Volume_Id);
            idx = cmbRicVolume.FindString(item);
            cmbRicVolume.SelectedIndex = idx;
         }
      }
   }
}
