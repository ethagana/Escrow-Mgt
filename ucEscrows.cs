using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscrowManagement
{
    public partial class ucEscrows : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable tblEscrows_Disputed = new DataTable();
        DataTable tblEscrows_Processed = new DataTable();

        int card_pos = 0;

        bool id_ver = false;

        string eid = null;

        ArrayList escrws = new ArrayList();

        public ucEscrows()
        {
            InitializeComponent();

            tblEscrows_Disputed.Columns.Add("Date of Request", typeof(string));
            tblEscrows_Disputed.Columns.Add("Requester", typeof(string));
            tblEscrows_Disputed.Columns.Add("Status", typeof(Image));
            tblEscrows_Disputed.Columns.Add("Acc Number", typeof(string));
            tblEscrows_Disputed.Columns.Add("Transaction ID", typeof(string));
            tblEscrows_Disputed.Columns.Add("Recepient", typeof(string));
            tblEscrows_Disputed.Columns.Add("Amount Escrowed", typeof(string));
            tblEscrows_Disputed.Columns.Add("Release Rejection Reason", typeof(string));

            tblEscrows_Processed.Columns.Add("Date Processed", typeof(string));
            tblEscrows_Processed.Columns.Add("Status", typeof(Image));
            tblEscrows_Processed.Columns.Add("Requester", typeof(string));
            tblEscrows_Processed.Columns.Add("Recepient", typeof(string));
            tblEscrows_Processed.Columns.Add("Amount Escrowed", typeof(string));
        }

        private void ucEscrows_Load(object sender, EventArgs e)
        {
            getEscrwData();
        }

        private void getEscrwData()
        {
            SplashScreenManager.ShowForm(typeof(frmWait));
            SplashScreenManager.Default.SetWaitFormDescription("Fetching Escrows...");
            Thread trdGetEscs = new Thread(new ThreadStart(getEscrows));
            trdGetEscs.Start();
        }

        internal void getFPVer(bool ver)
        {
            id_ver = ver;
        }

        private void getEscrows()
        {
            if (GlobalVar.checkConn())
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("x-api-key", GlobalVar.api_key);
                        client.Headers.Add("x-task", "getEscrows");
                        client.Headers.Add("x-fid", GlobalVar.fid);


                        byte[] response =
                           client.UploadValues(GlobalVar.conn_url, new NameValueCollection()
                           {
                                {"task", "getData"}
                           });

                        String rslt = Encoding.UTF8.GetString(response);

                        Debug.WriteLine(rslt);

                        this.Invoke((MethodInvoker)delegate
                        {

                            SplashScreenManager.CloseForm();

                            tblEscrows_Disputed.Rows.Clear();
                            tblEscrows_Processed.Rows.Clear();
                            escrws.Clear();

                            if (!rslt.Equals("0"))
                            {
                                var arrRslt = JArray.Parse(rslt);

                                /*tblEscrows_Disputed.Rows.Clear();
                                tblEscrows_Processed.Rows.Clear();
                                escrws.Clear();*/

                                foreach (var itm in arrRslt)
                                {
                                    if (itm["approved"].ToString().Equals("0"))
                                    {
                                        tblEscrows_Disputed.Rows.Add(new object[] { itm["trans_date"].ToString(), itm["email"].ToString() + " - "+itm["tel"].ToString(),
                                            Properties.Resources.declined, itm["acc"].ToString(), itm["trans_id"].ToString(),
                                            itm["recpt"].ToString(),itm["curr"].ToString() + " "+itm["trans_amt"].ToString(),
                                            itm["rej_reason"].ToString()});

                                        escrws.Add(itm["tid"]);
                                    }
                                    else
                                    {
                                        tblEscrows_Processed.Rows.Add(new object[] { itm["trans_date"].ToString(),Properties.Resources.approved,
                                            itm["email"].ToString() + " - "+itm["tel"].ToString(), itm["recpt"].ToString(),itm["curr"].ToString() + " "+
                                            itm["trans_amt"].ToString() });
                                    }

                                }

                                grdEscDisputed.DataSource = tblEscrows_Disputed;
                                grdEscProcessed.DataSource = tblEscrows_Processed;

                                grdEscDisputed.RefreshDataSource();
                                grdEscProcessed.RefreshDataSource();
                            }
                            else
                            {
                                XtraMessageBox.Show("No Escrows Registered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            grdEscDisputed.DataSource = tblEscrows_Disputed;
                            grdEscProcessed.DataSource = tblEscrows_Processed;

                            grdEscDisputed.RefreshDataSource();
                            grdEscProcessed.RefreshDataSource();

                            tmrRefresh.Enabled = true;

                            tmrRefresh.Start();


                        });


                    }
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message, "Error getting data");
                }
            }
            else
            {
                this.Invoke((MethodInvoker)delegate { SplashScreenManager.CloseForm(); });
                XtraMessageBox.Show(GlobalVar.no_conn_msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            eid = escrws[e.RowHandle].ToString();
            txtDteEscrReq.Text = tblEscrows_Disputed.Rows[e.RowHandle]["Date of Request"].ToString();
            txtDisputee.Text = tblEscrows_Disputed.Rows[e.RowHandle]["Recepient"].ToString();
            txtAmt.Text = tblEscrows_Disputed.Rows[e.RowHandle]["Amount Escrowed"].ToString();
            txtRejRsn.Text = tblEscrows_Disputed.Rows[e.RowHandle]["Release Rejection Reason"].ToString();
            string[] arr1 = tblEscrows_Disputed.Rows[e.RowHandle]["Requester"].ToString().Split('-');
            txtSender.Text = arr1[0].Trim();
            txtTel.Text = arr1[1].Trim();
            cmdOveride.Enabled = true;
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            tmrRefresh.Enabled = false;

            try
            {
                SplashScreenManager.ShowForm(typeof(frmWait));
                SplashScreenManager.Default.SetWaitFormDescription("Refreshing Escrows...");
            }
            catch { }
            Thread trdGetEscs = new Thread(new ThreadStart(getEscrows));
            trdGetEscs.Start();
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            if (layoutView1.RecordCount > 1)
            {
                if (card_pos < layoutView1.RecordCount)
                {
                    card_pos++;
                    layoutView1.MoveNext();
                }
                else
                {
                    card_pos = 0;
                    layoutView1.MoveFirst();
                }
            }
            else
            {
                tmrScroll.Enabled = false;
            }
        }

        private void cmdOveride_Click(object sender, EventArgs e)
        {
            LoginUserControl myControl = new LoginUserControl();
            if (XtraDialog.Show(myControl, "Override Capture", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RadioGroup rgp = (RadioGroup)myControl.Controls[0].Controls[5];
                MemoEdit memReason = (MemoEdit)myControl.Controls[0].Controls[7];

                if (valData(memReason.Text, rgp.SelectedIndex))
                {
                    //Verify Identity
                    frmVerBiometrics verbiofrm = new frmVerBiometrics();
                    verbiofrm.loadTemp(GlobalVar.usrnme, GlobalVar.fp_hex, GlobalVar.fp_digit);
                    verbiofrm.ShowDialog();

                    if (id_ver)
                    {
                        if (XtraMessageBox.Show("Register my Decision?", this.Text,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SplashScreenManager.ShowForm(typeof(frmWait));
                            SplashScreenManager.Default.SetWaitFormDescription("Registering...");
                            Thread trdregEscrw = new Thread(new ThreadStart(() => regData(rgp.SelectedIndex == 0 ? true : false, memReason.Text)));
                            trdregEscrw.Start();
                        }
                        
                    }
                    else
                    {
                        XtraMessageBox.Show("Identity verification failure, Override process terminated", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void regData(bool apprvd,string rsn)
        {
            if (GlobalVar.checkConn())
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("x-api-key", GlobalVar.api_key);
                        client.Headers.Add("x-task", "regOvrEscrow1");
                        client.Headers.Add("x-fid", GlobalVar.fid);
                        client.Headers.Add("x-eid", eid);
                        client.Headers.Add("x-dtel", txtDisputee.Text);
                        client.Headers.Add("x-uid", GlobalVar.usrid);
                        client.Headers.Add("x-ost", apprvd ? "1" : "0");
                        client.Headers.Add("x-orsn", GlobalVar.ToTitleCase(rsn));

                        byte[] response =
                           client.UploadValues(GlobalVar.conn_url, new NameValueCollection()
                           {
                                {"task", "getData"}
                           });

                        String rslt = Encoding.UTF8.GetString(response);

                        Debug.WriteLine(rslt);

                        this.Invoke((MethodInvoker)delegate
                        {

                            SplashScreenManager.CloseForm();

                            if (!rslt.Equals("x"))
                            {
                                if (rslt.Equals("1"))
                                {
                                    //Registration successful
                                    XtraMessageBox.Show("Escrow override registered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    id_ver = true;

                                    //Refresh the lists
                                    getEscrwData();
                                }
                                else
                                {
                                    //Registration not successful
                                    XtraMessageBox.Show("Escrow override NOT registered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Escrow already evaluated", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            


                        });


                    }
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message, "Error registering override");
                }
            }
            else
            {
                XtraMessageBox.Show(GlobalVar.no_conn_msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool valData(string reason, int apprvd)
        {
            if (apprvd > -1)
            {
                if (!String.IsNullOrEmpty(reason))
                {
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Kindly give the reason for your override decision", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Kindly select the override decision", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        private void txtRejRsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (txtRejRsn.Text.Length == 160)
                {
                    XtraMessageBox.Show("Your decision has to be 160 characters or Less", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    e.Handled = true;
                }
            }
        }
    }

    public class LoginUserControl : XtraUserControl
    {
        public LoginUserControl()
        {
            LayoutControl lc = new LayoutControl();
            lc.Dock = DockStyle.Fill;
            LabelControl lblFrom = new LabelControl();
            lblFrom.Text = "Reason for Decision";
            LabelControl lblRsn = new LabelControl();
            lblRsn.Text = "Override Decision";

            RadioGroup rgp = new RadioGroup();
            MemoEdit memReason = new MemoEdit();


            rgp.Properties.Items.AddRange(new RadioGroupItem[] { new RadioGroupItem(0, "Approve"), new RadioGroupItem(1, "Decline") });

            lc.AddItem("Rsn", lblRsn);
            lc.AddItem(String.Empty, rgp).TextVisible = false;
            lc.AddItem("From", lblFrom);
            lc.AddItem(String.Empty, memReason).TextVisible = false;


            this.Controls.Add(lc);
            this.Height = 210;
            this.Dock = DockStyle.Top;

        }
    }
}
