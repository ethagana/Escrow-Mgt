using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DPUruNet;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscrowManagement
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        internal void loginRslt(bool succ)
        {
            if (succ)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                frmMain.Text = "VerID - " + GlobalVar.usrnme + " Logged in";
                GlobalVar.mainfrm = frmMain;
                this.Hide();
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            ReaderCollection readers = ReaderCollection.GetReaders();
            if (readers.Count == 0)
            {
                XtraMessageBox.Show("Kindly connect a Digital Persona compatible Fingerprint Reader and try again",
                    "User Registraion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (!String.IsNullOrEmpty(txtEmail.Text))
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    GlobalVar.loginfrm = this;
                    SplashScreenManager.ShowForm(typeof(frmWait));
                    SplashScreenManager.Default.SetWaitFormDescription("Logging In...");
                    Thread trdGetData = new Thread(new ThreadStart(login));
                    trdGetData.Start();
                }
                else
                {
                    XtraMessageBox.Show("Kindly enter a VALID work email ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Kindly enter your work email ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void login()
        {
            if (GlobalVar.checkConn())
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("x-api-key", GlobalVar.api_key);
                        client.Headers.Add("x-task", "elogin");
                        client.Headers.Add("x-email", txtEmail.Text);


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

                                foreach (var itm in arrRslt)
                                {
                                    GlobalVar.fid = itm["fid"].ToString();
                                    GlobalVar.usrid = itm["id"].ToString();
                                    GlobalVar.usrnme = itm["names"].ToString();
                                    GlobalVar.access_lvl = Convert.ToInt32(itm["access_lvl"].ToString());

                                }

                                GlobalVar.fp_digit = arrRslt[0].Value<int>("fp_index");
                                GlobalVar.fp_hex = arrRslt[0].Value<string>("fp");

                                frmVerBiometrics verbiofrm = new frmVerBiometrics();
                                verbiofrm.loadTemp(GlobalVar.usrnme, arrRslt[0].Value<string>("fp"), arrRslt[0].Value<int>("fp_index"));
                                verbiofrm.ShowDialog();
                            }

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
                XtraMessageBox.Show(GlobalVar.no_conn_msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Invoke((MethodInvoker)delegate
                {

                    SplashScreenManager.CloseForm();
                });
            }
        }

        private bool IsValidEmail(string strIn)
        {
            try
            {
                string address = new MailAddress(strIn).Address;

                return true;
            }
            catch (FormatException)
            {
                //address is invalid
            }

            return false;
        }
    }
}