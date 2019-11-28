using bcs.arcSpace.Business_Layer;
using bcs.arcSpace.Global_Layer;
using bcs.arcSpace.Support_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bcs.arcSpace.arcSpaceWinform
{
    public partial class frmMain : Form
    {
        public BindingSource bs;
        public List<CoinDisplaySet> lstCoinDisplaySet;
        private BindingSource bnsPeriod;
//        private List<Period> lstPeriod;
        private List<XlReportAndLabel> lstRL;
//        private List<XlReportAndLabel> lstRptAndLabel;
        private List<ArcNode> lstArcNode;
        private string newFullPath;

        private string fullPath;
        
        public frmMain()
        {
            string exeDir = System.IO.Path.GetDirectoryName("bcs.arcSpace.arcSpaceWinform\\bcs.arcSpace.arcSpaceWinform");

            fullPath = System.IO.Path.Combine(exeDir, "Resources\\constantine dynasty.ico");

            fullPath = System.IO.Path.Combine(exeDir, "Resources\\constantine dynasty.ico");

            InitializeComponent();
            bs = new BindingSource();
            bnsPeriod = new BindingSource(); 

            ImageList arcImageList = new ImageList();
            fullPath = "..\\" + fullPath;

            string icoDir = System.IO.Path.GetDirectoryName(fullPath);

            newFullPath = System.IO.Path.GetFullPath("constantine dynasty.ico");

            lstArcNode = Business_Layer.ArcNode_BL.GetArcNodeObjectsForTreeView();

            this.StartPosition = FormStartPosition.Manual;
            this.Left = Globals.frmMainX;
            
            this.Top = Globals.frmMainY;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddCoin f = new frmAddCoin(dgvCoins);
            f.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCoin_Click(object sender, EventArgs e)
        {
            frmAddCoin f = new frmAddCoin(dgvCoins);
            f.Show();
        }

        private void btnAmdMint_Click(object sender, EventArgs e)
        {
            frmMint f = new frmMint();
            f.Show();
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            frmIssuingAuthorityReign f = new frmIssuingAuthorityReign();
            f.Show();
        }

        private void btnCoinType_Click(object sender, EventArgs e)
        {
            frmCoinTypeMaintenance f = new frmCoinTypeMaintenance();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            frmGrade f = new frmGrade();
            f.Show();
        }

        private void btnIssuingAuthorityName_Click(object sender, EventArgs e)
        {
            frmIssuingAuthorityName f = new frmIssuingAuthorityName();
            f.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmMaterial f = new frmMaterial();
            f.Show();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            frmArcPeriod f = new bcs.arcSpace.arcSpaceWinform.frmArcPeriod();
            f.Show();
        }

        private void btnPrintLabels_Click(object sender, EventArgs e)     // mch 12/23/2018
        {
            if (dgvCoins.SelectedRows.Count > 0)
            {
                frmPrintingLabels p = new frmPrintingLabels();   // put frmPrintingLabels here  mch 01/26/2019
                int[] iArr = new int[dgvCoins.SelectedRows.Count];
                for (int i = 0; i < dgvCoins.SelectedRows.Count; i++)
                {
                    iArr[i] = (int)dgvCoins.Rows[dgvCoins.SelectedRows[i].Index].Cells[(int)Globals.DGVCOLNAMES.coinId].Value;
                }
                List<XlReportAndLabel> lstRL = Business_Layer.XlReportAndLabel_BL.GetCoinsForReporting(iArr);

                Application_Layer.LabelBuilder.CreateLabels(lstRL);
            }
        }

        private void btnRicSection_Click(object sender, EventArgs e)
        {
            frmRicSection f = new frmRicSection();
            f.Show();
        }

        private void btnRicVolume_Click(object sender, EventArgs e)
        {
            frmRicVolume f = new frmRicVolume();
            f.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //frmTest1 f = new frmTest1();
            //   f.Show();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            frmTitle f = new frmTitle();
            f.Show();
        }

        private void btnIssuingAuthorityReign_Click(object sender, EventArgs e)  // This is actually btnIssuingAuthorityReign
        {
            frmIssuingAuthorityReign f = new frmIssuingAuthorityReign();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvCoins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCoins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCoins_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (e.ColumnIndex == -1))
            {
                dgvCoins.Rows[e.RowIndex].Selected = true;
                //if (Control.ModifierKeys == Keys.Control)
                //{
                //    dgvCoins.Rows[e.RowIndex].Selected = true;         // !dgvCoins.Rows[e.RowIndex].Selected
                //    dgvCoins.Rows[e.RowIndex].Selected = true;
                //}
                //else
                //{
                //    dgvCoins.Rows[e.RowIndex].Selected = true;
                //}
            }
        }

        private void dgvCoins_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs m_event_args = (MouseEventArgs)e;

            if (m_event_args.Button.ToString() == "Left")
            {
                int idx, coin_id;
                int selectedRowCount = dgvCoins.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount > 0)
                {
                    idx = dgvCoins.SelectedRows[0].Index;
                    coin_id = (int)dgvCoins.Rows[idx].Cells[2].Value;
                }
                else
                {
                    return;
                }
                Coin objCoin = Coin_BL.GetCoin(coin_id);   // mch 10052019
                frmModifyCoin f = new frmModifyCoin(objCoin, dgvCoins);
                f.ShowDialog();                     
            }
            else
            {
                if (m_event_args.Button.ToString() == "Right")
                {
                    frmHistoricalPerspective hp = new frmHistoricalPerspective();
                    hp.ShowDialog();
                }
            }
        }

        private void dgvCoins_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvCoins.Rows[e.RowIndex].Height = 140;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            frmMain_Load(this, e);
        }

        /// <summary>
        ///   THIS IS IMPORTANT:  I REALLY  NEED TO CLEAN THIS UP TO LOOK OOP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmMain_Load(object sender, EventArgs e)  // mch 02/20/2019
        {
            ImageList myImageList = new ImageList();

            int k = 0;

            if (trvCoinCollection.Nodes[0].Nodes.Count == 0)
            {
                TreeNode root = trvCoinCollection.Nodes[0];

                trvCoinCollection.ImageList = myImageList;

                List<Period> lstPeriod = Period_BL.GetPeriodsHavingCoins();

                string currentEmperor = null;
                List<ArcNode> lstArcNode = null;

                //      lstArcNode = ArcNode_BL.GetArcNodeObjectsForTreeView();   // mch 03/17/2019

                for (int j = 0; j < lstPeriod.Count; j++)
                {
                    int z = 0;
                    lstArcNode = ArcNode_BL.GetArcNodeObjectsForTreeView(lstPeriod[j].Period_Id);    // mch 03/19/2019 put breakpoint here.

                    k = 0;
                    TreeNode n1 = null;
                    TreeNode n2 = null;
                    TreeNode n3 = null;
                    ArcNode cNode = lstArcNode[k];

                    n1 = new TreeNode(cNode.Period_Name);         // This is the period here mch 10/04/2019
                    root.Nodes.Add(n1);
                    while (k < lstArcNode.Count)
                    {
                        cNode = lstArcNode[k];

                        while (((ArcNode)cNode).Issuing_Authority_Name != currentEmperor)
                        {
                            n2 = new TreeNode(((ArcNode)cNode).Issuing_Authority_Name);
                            n1.Nodes.Add(n2);
                            currentEmperor = cNode.Issuing_Authority_Name;

                            while ((k < lstArcNode.Count) && (lstArcNode[k].Issuing_Authority_Name == cNode.Issuing_Authority_Name))
                            {
                                cNode = lstArcNode[k];

                                System.IO.MemoryStream mStrmImage = new System.IO.MemoryStream(cNode.Obverse_Image);
                                PictureBox pb = new PictureBox();  //System.IO.
                                Image newImage = ((Image)System.Drawing.Image.FromStream(mStrmImage)).GetThumbnailImage(16, 16, null, new IntPtr());

                                n3 = new TreeNode(cNode.Formatted_Ric_Index);

                                myImageList.Images.Add(newImage);
                                trvCoinCollection.ImageList = myImageList;

                                int ImageIdx = trvCoinCollection.ImageList.Images.Count;

                                n3.SelectedImageIndex = ImageIdx - 1;  //  mch 03/10/2019 Test

                                n3.Tag = cNode;

                                n2.Nodes.Add(n3);

                                k++;
                            }
                        }
                    }

                    trvCoinCollection.ImageList = myImageList;  // mch 03/10/2019 Test
                }
            }

            lstCoinDisplaySet = CoinDisplaySet_BL.GetCoinDisplaySetList();

            bs.DataSource = lstCoinDisplaySet;

            dgvCoins.DataSource = bs;

            bnvCoinCollection.BindingSource = bs;

            dgvCoins.AllowUserToAddRows = false;

            System.Collections.IList list = dgvCoins.Rows;
            for (int i = 0; i < list.Count; i++)   // mch.  09/17/2017
            {
                DataGridViewRow r = (DataGridViewRow)list[i];
                int cId = (Int32)r.Cells[2].Value;
                int ricIndexId = RIC_BL.GetRicIndexByCoinId(cId);
                RIC objRic = RIC_BL.GetRicReferenceByRicIndexId(ricIndexId);
                string ricLabel = RIC_BL.GetRicReferenceLabel(objRic);
                r.Cells[7].Value = ricLabel;
            }

            dgvCoins.AutoResizeColumns();
            dgvCoins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < dgvCoins.Columns.Count; i++)
            {
                if (dgvCoins.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvCoins.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
            // mch. 01.06.2018. Load LogicalTreeView here.
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tabCollection_Click(object sender, EventArgs e)
        {
        }

        private void tabConfiguration_Enter(object sender, EventArgs e)
        {
        }

        private void tabConfiguration_Selecting(object sender, TabControlCancelEventArgs e)
        {
        }

        private void trvCoinCollection_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void trvCoinCollection_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
        }

        private void trvCoinCollection_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void TabMaintenance_Click(object sender, EventArgs e)
        {
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SpcMaintenance_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void btnExitViaReports_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExitViaMaintenance_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExitViaConfiguration_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}