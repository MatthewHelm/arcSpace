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
   public partial class frmCoinTypeMaintenance : Form
   {
      Coin_Type objCoinType;
      List<Coin_Type> lstCoinType;

      private BindingSource bnsCoinTypeMaintenance;

      public frmCoinTypeMaintenance()
      {
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
         bnsCoinTypeMaintenance = new BindingSource();
         lstCoinType = Coin_Type_BL.GetCoinTypeList();
         bnsCoinTypeMaintenance.DataSource = lstCoinType;
         InitializeComponent();
         bnvCoinTypeMaintenance.BindingSource = bnsCoinTypeMaintenance;
         this.txtCoinType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsCoinTypeMaintenance, "Coin_Type_Name", true));
         this.txtCoinTypeDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsCoinTypeMaintenance, "Coin_Type_Desc", true));
      }

      private void frmCoinTypeMaintenance_Load(object sender, EventArgs e)
      {
         objCoinType = BusinessLayer<Coin_Type>.ReturnCurrentTypeObject(bnsCoinTypeMaintenance);
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
         this.SetLocation();
      }

      private void btnSaveRecord_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<Coin_Type>.recordSaveType)
         {
            case BusinessLayer<Coin_Type>.ObjectSaveType.InsertObject:
//               objCoinType = (Coin_Type) bnsCoinTypeMaintenance.Current;
               Coin_Type_BL.InsertCoinType(objCoinType);
               break;
            case BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject:
               objCoinType = (Coin_Type) bnsCoinTypeMaintenance.Current;
               Coin_Type_BL.UpdateCoinType(objCoinType); 
               break;
         }

         lstCoinType = Coin_Type_BL.GetCoinTypeList();
         bnsCoinTypeMaintenance.DataSource = lstCoinType;
         bnvCoinTypeMaintenance.BindingSource = bnsCoinTypeMaintenance;
      }

      private void bnvAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.InsertObject;
         objCoinType = (Coin_Type) bnsCoinTypeMaintenance.Current;
      }

      private void bnvFirstItem_Click(object sender, EventArgs e)
      {
         bnsCoinTypeMaintenance.MoveFirst();
         objCoinType = BusinessLayer<Coin_Type>.ReturnCurrentTypeObject(bnsCoinTypeMaintenance);
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
      }

      private void bnvDeleteItem_Click(object sender, EventArgs e)
      {
         Coin_Type_BL.DeleteCoinType(objCoinType);
         objCoinType = (Coin_Type)bnsCoinTypeMaintenance.Current;
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
      }


      private void bnvLastItem_Click(object sender, EventArgs e)
      {
         objCoinType = (Coin_Type)bnsCoinTypeMaintenance.Current;
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
      }

      private void bnvPreviousItem_Click(object sender, EventArgs e)
      {
         objCoinType = (Coin_Type)bnsCoinTypeMaintenance.Current;
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
      }

      private void bnvNextItem_Click(object sender, EventArgs e)
      {
         objCoinType = (Coin_Type)bnsCoinTypeMaintenance.Current;
         BusinessLayer<Coin_Type>.recordSaveType = BusinessLayer<Coin_Type>.ObjectSaveType.UpdateObject;
      }

      private void btnCancelRecord_Click(object sender, EventArgs e)
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
