using DevExpress.XtraEditors;
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
    public partial class ucFinailzeEscrows : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable tblEscrows_Disputed = new DataTable();
        DataTable tblEscrows_Processed = new DataTable();

        int card_pos = 0;

        bool id_ver = false;

        string eid = null;

        ArrayList escrws = new ArrayList();
        ArrayList mrk_Decs = new ArrayList();
        ArrayList mrk_Rsn = new ArrayList();

        public ucFinailzeEscrows()
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

        private void ucFinailzeEscrows_Load(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(frmWait));
                SplashScreenManager.Default.SetWaitFormDescription("Fetching Processed Escrows...");
            }
            catch
            {

            }
            Thread trdGetEscs = new Thread(new ThreadStart(loadFData));
            trdGetEscs.Start();
        }

        internal void getFPVer(bool ver)
        {
            id_ver = ver;
        }

        private void loadFData()
        {
            if (GlobalVar.checkConn())
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("x-api-key", GlobalVar.api_key);
                        client.Headers.Add("x-task", "getProEscrows");
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

                            if (!rslt.Equals("0"))
                            {
                                var arrRslt = JArray.Parse(rslt);

                                tblEscrows_Disputed.Rows.Clear();
                                tblEscrows_Processed.Rows.Clear();
                                escrws.Clear();
                                mrk_Decs.Clear();
                                mrk_Rsn.Clear();

                                foreach (var itm in arrRslt)
                                {
                                    if (!itm["sec_override"].ToString().Equals("0") && !itm["sec_override"].ToString().Equals("1"))
                                    {
                                        tblEscrows_Disputed.Rows.Add(new object[] { itm["reg_on"].ToString(), itm["email"].ToString() + " - "+itm["tel"].ToString(),
                                        itm["pri_override"].ToString().Equals("0") ? Properties.Resources.declined : Properties.Resources.approved, itm["acc"].ToString(), itm["trans_id"].ToString(),
                                        itm["recpt"].ToString(),itm["curr"].ToString() + " "+itm["trans_amt"].ToString(),
                                        itm["rej_reason"].ToString()});

                                        escrws.Add(itm["tid"]);
                                        mrk_Decs.Add(itm["pri_override"]);
                                        mrk_Rsn.Add(itm["pri_reason"]);
                                    }
                                    else
                                    {
                                        tblEscrows_Processed.Rows.Add(new object[] { itm["reg_on"].ToString(),itm["sec_override"].ToString().Equals("1") ?
                                            Properties.Resources.approved : Properties.Resources.declined,
                                            itm["email"].ToString() + " - "+itm["tel"].ToString(), itm["recpt"].ToString(),itm["curr"].ToString() + " "+
                                            itm["trans_amt"].ToString() });
                                    }

                                }

                                grdEscrowsAA.DataSource = tblEscrows_Disputed;
                                grdEscrowsFI.DataSource = tblEscrows_Processed;

                                grdEscrowsAA.RefreshDataSource();
                                grdEscrowsFI.RefreshDataSource();
                            }
                            else
                            {
                                XtraMessageBox.Show("No Escrows Registered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

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

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            tmrRefresh.Enabled = false;

            try
            {
                SplashScreenManager.ShowForm(typeof(frmWait));
                SplashScreenManager.Default.SetWaitFormDescription("Refreshing Processed Escrows...");
            }
            catch { }
            Thread trdGetEscs = new Thread(new ThreadStart(loadFData));
            trdGetEscs.Start();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            eid = escrws[e.RowHandle].ToString();
            txtDTel.Text = tblEscrows_Disputed.Rows[e.RowHandle]["Recepient"].ToString();
            string amt = tblEscrows_Disputed.Rows[e.RowHandle]["Amount Escrowed"].ToString();
            string rej_reason = tblEscrows_Disputed.Rows[e.RowHandle]["Release Rejection Reason"].ToString();
            memRej.Text = "Transaction Amount " + amt + "\r\n\r\nReason Given - " + rej_reason;
            string[] arr1 = tblEscrows_Disputed.Rows[e.RowHandle]["Requester"].ToString().Split('-');
            //txtSender.Text = arr1[0].Trim();
            txtSTel.Text = arr1[1].Trim();
            memOveride.Text = Convert.ToInt32(mrk_Decs[e.RowHandle].ToString()) == 0 ? "REJECTED \r\n\r\n" + mrk_Rsn[e.RowHandle].ToString() : "APPROVED \r\n\r\n" + mrk_Rsn[e.RowHandle].ToString();
            cmdFinalize.Enabled = true;
        }

        private void cmdFinalize_Click(object sender, EventArgs e)
        {
            if (rgpSecOverride.SelectedIndex >= 0)
            {
                if (!String.IsNullOrEmpty(memSecOveride.Text))
                {
                    memSecOveride.Text = GlobalVar.ToTitleCase(memSecOveride.Text);

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
                            Thread trdregEscrw = new Thread(new ThreadStart(regData));
                            trdregEscrw.Start();
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("Identity verification failure, Override process terminated", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Kindly select if you have Approved or Rejected this Escrow transaction", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void regData()
        {
            if (GlobalVar.checkConn())
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("x-api-key", GlobalVar.api_key);
                        client.Headers.Add("x-task", "regOvrEscrow2");
                        client.Headers.Add("x-fid", GlobalVar.fid);
                        client.Headers.Add("x-eid", eid);
                        client.Headers.Add("x-uid", GlobalVar.usrid);
                        client.Headers.Add("x-ost", rgpSecOverride.SelectedIndex == 0 ? "1" : "0");
                        client.Headers.Add("x-orsn", memSecOveride.Text);

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
                                    XtraMessageBox.Show("Final Escrow override registered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    id_ver = false;

                                    //Refresh the lists
                                    tmrRefresh.Enabled = false;

                                    clearText();

                                    try
                                    {
                                        SplashScreenManager.ShowForm(typeof(frmWait));
                                        SplashScreenManager.Default.SetWaitFormDescription("Refreshing Processed Escrows...");
                                    }
                                    catch { }

                                    Thread trdGetEscs = new Thread(new ThreadStart(loadFData));
                                    trdGetEscs.Start();
                                }
                                else
                                {
                                    //Registration not successful
                                    XtraMessageBox.Show("Final Escrow override NOT registered", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void clearText()
        {
            txtDTel.Text = "";
            txtSTel.Text = "";

            memOveride.Text = "";
            memRej.Text = "";
            memSecOveride.Text = "";

            rgpSecOverride.SelectedIndex = 0;

            cmdFinalize.Enabled = false;
        }

        private void memSecOveride_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (memSecOveride.Text.Length == 160)
                {
                    XtraMessageBox.Show("Your decision has to 160 characters or less", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }
    }
}
