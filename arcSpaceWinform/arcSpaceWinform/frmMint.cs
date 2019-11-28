using bcs.arcSpace.Business_Layer;
using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bcs.arcSpace.arcSpaceWinform
{
   public partial class frmMint : Form
   {
      private Mint objMint;
      private List<Mint> lstMint;

      private BindingSource bnsMintMaintenance;

      public frmMint()
      {
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         bnsMintMaintenance = new BindingSource();
         lstMint = Mint_BL.GetMintList();
         bnsMintMaintenance.DataSource = lstMint;
         InitializeComponent();
         bnvMint.BindingSource = bnsMintMaintenance;

         txtMintName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMintMaintenance, "Mint_Name", true));
         txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMintMaintenance, "Description", true));
         txtMintLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMintMaintenance, "Mint_Location", true));
         txtServiceStartYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMintMaintenance, "Service_Start_Date", true));
         txtServiceEndYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMintMaintenance, "Service_End_Date", true));
         txtAbbreviations.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsMintMaintenance, "Mint_Abbreviations", true));
         return;
      }

      private void frmMint_Load(object sender, EventArgs e)
      {
         this.SetLocation();
         this.Text = "Add/Modify/Delete Mint";
      }


      private void lblServiceStartYear_Click(object sender, EventArgs e)
      {
      }

      private void btnSaveRecord_Click(object sender, EventArgs e)
      {
         switch (BusinessLayer<Mint>.recordSaveType)
         {
            case BusinessLayer<Mint>.ObjectSaveType.InsertObject:
               Mint_BL.InsertMint(objMint);
               break;

            case BusinessLayer<Mint>.ObjectSaveType.UpdateObject:
               objMint = (Mint) bnsMintMaintenance.Current;
               Mint_BL.UpdateMint(objMint);
               break;
         }

         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         lstMint = Mint_BL.GetMintList();
         bnsMintMaintenance.DataSource = lstMint;
         bnvMint.BindingSource = bnsMintMaintenance;
      }

      private void bnvDeleteItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         Mint_BL.DeleteMint(objMint);
         objMint = (Mint)bnsMintMaintenance.Current;
      }

      private void bnvAddNewItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.InsertObject;
         objMint = (Mint) bnsMintMaintenance.Current;
      }

      private void bnvLastItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         objMint = (Mint) bnsMintMaintenance.Current;
      }

      private void bnvNextItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         objMint = (Mint) bnsMintMaintenance.Current;
      }

      private void bnvPreviousItem_Click(object sender, EventArgs e)
      {
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         objMint = (Mint) bnsMintMaintenance.Current;
      }

      private void bnvFirstItem_Click(object sender, EventArgs e)
      {
         bnsMintMaintenance.MoveFirst();
         BusinessLayer<Mint>.recordSaveType = BusinessLayer<Mint>.ObjectSaveType.UpdateObject;
         objMint = BusinessLayer<Mint>.ReturnCurrentTypeObject(bnsMintMaintenance);
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