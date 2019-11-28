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
   public partial class frmMaterial : Form
   {
      Material objMaterial;
      List<Material> lstMaterial;

      private BindingSource bnsMaterial;

      public frmMaterial()
      {

         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.UpdateObject;
         bnsMaterial = new BindingSource();

         lstMaterial = Material_BL.GetMaterialList();

         bnsMaterial.DataSource = lstMaterial;

         InitializeComponent();

         bnvMaterial.BindingSource = bnsMaterial;

         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMaterial, "Material_Description", true));
         txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMaterial, "Material_Notes", true));
      }

      private void frmMaterial_Load(object sender, EventArgs e)
      {
         objMaterial = BusinessLayer<Material>.ReturnCurrentTypeObject(bnsMaterial);
         this.SetLocation();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<Material>.recordSaveType)
         {
            case BusinessLayer<Material>.ObjectSaveType.InsertObject:
               Material_BL.InsertMaterial(objMaterial);
               break;
            case BusinessLayer<Material>.ObjectSaveType.UpdateObject:
               objMaterial = (Material) bnsMaterial.Current;
               Material_BL.UpdateMaterial(objMaterial);
               break;
         }

         lstMaterial = Material_BL.GetMaterialList();
         bnsMaterial.DataSource = lstMaterial;
         bnvMaterial.BindingSource = bnsMaterial;
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.InsertObject;
         objMaterial = (Material) bnsMaterial.Current;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.UpdateObject;
         objMaterial = BusinessLayer<Material>.ReturnCurrentTypeObject(bnsMaterial);
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.UpdateObject;
         objMaterial = (Material) bnsMaterial.Current;
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.UpdateObject;
         objMaterial = (Material) bnsMaterial.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.UpdateObject;
         objMaterial = (Material) bnsMaterial.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Material>.recordSaveType = BusinessLayer<Material>.ObjectSaveType.UpdateObject;
         Material_BL.DeleteMaterial(objMaterial);
         objMaterial = (Material)bnsMaterial.Current;
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

         this.Text = "Add/Modify/Delete Materials";
      }

   }
}
