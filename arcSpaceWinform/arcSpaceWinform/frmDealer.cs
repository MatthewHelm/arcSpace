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
   public partial class frmDealer : Form
   {

      private Dealer objDealer;
      private List<Dealer> lstDealer;
      private List<Country> lstCountry;

      private BindingSource bnsDealer;
      private BindingSource bnsStateProvince;
      private BindingSource bnsCountry;

      public frmDealer()
      {
         BusinessLayer<Dealer>.recordSaveType = BusinessLayer<Dealer>.ObjectSaveType.UpdateObject;
         bnsDealer = new BindingSource();

         lstDealer= Dealer_BL.GetDealerList();

         bnsDealer.DataSource = lstDealer;

         InitializeComponent();

         bnvDealer.BindingSource = bnsDealer;

         txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsDealer, "First_Name", true));
         txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsDealer, "Last_Name", true));
         txtBusinessName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsDealer, "Business_Name", true));
         txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsDealer, "Address1", true));
         txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsDealer, "Address2", true));
         txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bnsDealer, "City", true));

         this.Text = "Add/Modify/Delete Dealer";
      }



      private void BindCmbCountry()
      {
         bnsCountry = new BindingSource();

         /*
                  lstPeriod = Period_BL.GetPeriodList();
                  bnsPeriod.DataSource = lstPeriod;
                  cmbPeriod.DataSource = bnsPeriod.DataSource;
                  cmbPeriod.DisplayMember = "Period_Name";
                  cmbPeriod.ValueMember = "Period_Id";
         */
         
         return;
      }
   }
}
