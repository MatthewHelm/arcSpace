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
   public partial class frmGrade : Form
   {

      Grade objGrade;
      List<Grade> lstGrade;

      private BindingSource bnsGrade;

      public frmGrade()
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         bnsGrade = new BindingSource();

         lstGrade = Grade_BL.GetGradeList();

         bnsGrade.DataSource = lstGrade;

         InitializeComponent();


         bnvGrade.BindingSource = bnsGrade;

         txtGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsGrade, "Grade_Code", true));
         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsGrade, "Description", true));
      }

      private void frmGrade_Load(object sender, EventArgs e)
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         objGrade = BusinessLayer<Grade>.ReturnCurrentTypeObject(bnsGrade);
         this.SetLocation();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<Grade>.recordSaveType)
         {
            case BusinessLayer<Grade>.ObjectSaveType.InsertObject:
               Grade_BL.InsertGrade(objGrade);
               break;
            case BusinessLayer<Grade>.ObjectSaveType.UpdateObject:
               objGrade = (Grade)bnsGrade.Current;
               Grade_BL.UpdateGrade(objGrade);
               break;
         }

         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         lstGrade = Grade_BL.GetGradeList();
         bnsGrade.DataSource = lstGrade;
         bnvGrade.BindingSource = bnsGrade;

      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.InsertObject;
         objGrade = (Grade)bnsGrade.Current;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         objGrade = BusinessLayer<Grade>.ReturnCurrentTypeObject(bnsGrade);
      }


      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         objGrade = (Grade)bnsGrade.Current;
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         Grade_BL.DeleteGrade(objGrade);
         objGrade = (Grade)bnsGrade.Current;
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         objGrade = (Grade)bnsGrade.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Grade>.recordSaveType = BusinessLayer<Grade>.ObjectSaveType.UpdateObject;
         objGrade = (Grade)bnsGrade.Current;
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
