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
   public partial class frmArcPeriod : Form
   {
      private Period objPeriod;
      private List<Period> lstPeriod;
      private List<Era> lstEra;

      private BindingSource bnsArcPeriod;
      private BindingSource bnsStartPeriodYearEra;
      private BindingSource bnsEndPeriodYearEra;


      public frmArcPeriod()
      {

         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         bnsArcPeriod = new BindingSource();
         lstPeriod = Period_BL.GetPeriodList();
         bnsArcPeriod.DataSource = lstPeriod;
         InitializeComponent();
         bnvArcPeriod.BindingSource = bnsArcPeriod;

         txtArcPeriodName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsArcPeriod, "Period_Name", true));
         txtArcPeriodDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsArcPeriod, "Period_Description", true));

         txtStartYear.DataBindings.Add("Text", bnsArcPeriod, "Start_Year", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty, "0");
         txtEndYear.DataBindings.Add("Text", bnsArcPeriod, "End_Year", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty, "0");

         //  InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<Period>.recordSaveType)
         {
            case BusinessLayer<Period>.ObjectSaveType.InsertObject:
               Period_BL.InsertPeriod(objPeriod);
               break;

            case BusinessLayer<Period>.ObjectSaveType.UpdateObject:
               objPeriod = (Period)bnsArcPeriod.Current;
               Period_BL.UpdatePeriod(objPeriod);
               break;
         }
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         lstPeriod = Period_BL.GetPeriodList();
         bnsArcPeriod.DataSource = lstPeriod;
         bnvArcPeriod.BindingSource = bnsArcPeriod;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         Period_BL.DeletePeriod(objPeriod);
         objPeriod = (Period)bnsArcPeriod.Current;
      }

      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.InsertObject;
         objPeriod = (Period)bnsArcPeriod.Current;
      }

      private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         objPeriod = (Period)bnsArcPeriod.Current;
      }

      private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         objPeriod = (Period)bnsArcPeriod.Current;
      }

      private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         objPeriod = (Period)bnsArcPeriod.Current;
      }

      private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
      {
         bnsArcPeriod.MoveFirst();
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;
         objPeriod = BusinessLayer<Period>.ReturnCurrentTypeObject(bnsArcPeriod);
      }

      private void label3_Click(object sender, EventArgs e)
      {

      }




      private void BindCmbStartPeriodYearEra()
      {
         bnsStartPeriodYearEra = new BindingSource();
         lstEra = Era_BL.GetEraList();
         bnsStartPeriodYearEra.DataSource = lstEra;
         cmbStartPeriodYearEra.DataSource = bnsStartPeriodYearEra.DataSource;
         cmbStartPeriodYearEra.DisplayMember = "Era_Name";
         cmbStartPeriodYearEra.ValueMember = "Era_Id";
         return;
      }

      private void BindCmbEndPeriodYearEra()
      {
         bnsEndPeriodYearEra = new BindingSource();
         lstEra = Era_BL.GetEraList();
         bnsEndPeriodYearEra.DataSource = lstEra;
         cmbEndPeriodYearEra.DataSource = bnsEndPeriodYearEra.DataSource;
         cmbEndPeriodYearEra.DisplayMember = "Era_Name";
         cmbEndPeriodYearEra.ValueMember = "Era_Id";
         return;
      }

      private void frmArcPeriod_Load(object sender, EventArgs e)
      {

         string item = null;
         int idx = 0;

         this.BindCmbStartPeriodYearEra();
         this.BindCmbEndPeriodYearEra();

         this.objPeriod = BusinessLayer<Period>.ReturnCurrentTypeObject(bnsArcPeriod);
         BusinessLayer<Period>.recordSaveType = BusinessLayer<Period>.ObjectSaveType.UpdateObject;

         item = Era_BL.GetEraGivenId(lstEra, this.objPeriod.Start_Era_Id);
         idx = cmbStartPeriodYearEra.FindString(item);
         cmbStartPeriodYearEra.SelectedIndex = idx;

         item = Era_BL.GetEraGivenId(lstEra, this.objPeriod.End_Era_Id);
         idx = cmbEndPeriodYearEra.FindString(item);
         cmbEndPeriodYearEra.SelectedIndex = idx;

         this.Text = "Add/Modify/Delete Period";
      }

      private void label4_Click(object sender, EventArgs e)
      {

      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

   }
}
