using DevExpress.XtraEditors;
using DPCtlUruNet;
using DPUruNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscrowManagement
{
    public partial class frmVerBiometrics : DevExpress.XtraEditors.XtraForm
    {
        private IdentificationControl identificationControl;

        private const int DPFJ_PROBABILITY_ONE = 0x7fffffff;

        private Dictionary<string, Fmd> fmds = new Dictionary<string, Fmd>();

        private string usr_nme;

        private int fpdigit;

        public frmVerBiometrics()
        {
            InitializeComponent();
        }

        internal void loadTemp(string usrnme, string fp_hex, int fp_digit)
        {
            usr_nme = usrnme;

            fpdigit = fp_digit;

            byte[] cfptemp = Convert.FromBase64String(fp_hex);

            Fmd fptemp = Importer.ImportFmd
                                (cfptemp, Constants.Formats.Fmd.ISO, Constants.Formats.Fmd.ISO).Data;

            fmds.Add(usrnme, fptemp);
        }

        private void configControl()
        {
            ReaderCollection readers = ReaderCollection.GetReaders();

            int thresholdScore = DPFJ_PROBABILITY_ONE * 1 / 100000;

            identificationControl = new IdentificationControl(readers[0], fmds.Values, thresholdScore, 1,
                Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

            identificationControl.Location = new Point(3, 3);
            identificationControl.Name = "identificationControl";
            identificationControl.Size = new Size(397, 128);
            identificationControl.TabIndex = 0;
            identificationControl.OnIdentify += new IdentificationControl.FinishIdentification(this.identificationControl_OnIdentify);

            // Be sure to set the maximum number of matches you want returned.
            identificationControl.MaximumResult = 1;

            this.Controls.Add(identificationControl);

            identificationControl.StartIdentification();

            this.Size = new Size(397, 128);

            remindUsrFingertoEnroll(fpdigit);

        }

        private void identificationControl_OnIdentify(IdentificationControl IdentificationControl, IdentifyResult IdentificationResult)
        {
            if (IdentificationResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
            {
                if (IdentificationResult.Indexes == null)
                {
                    if (IdentificationResult.ResultCode == Constants.ResultCode.DP_INVALID_PARAMETER)
                    {
                        //MessageBox.Show("Warning: Fake finger was detected.");
                        XtraMessageBox.Show("Warning: Fake finger was detected.", this.Text,
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (IdentificationResult.ResultCode == Constants.ResultCode.DP_NO_DATA)
                    {
                        //MessageBox.Show("");
                        XtraMessageBox.Show("No Finger Detected", this.Text,
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                if (IdentificationResult.Indexes.Length > 0)
                {
                    //Client Verified
                    XtraMessageBox.Show("User Verified as " + usr_nme, this.Text,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (GlobalVar.loginfrm.Visible)
                        {
                            //Process Login
                            GlobalVar.loginfrm.loginRslt(true);
                            //GlobalVal.loginFrm.Hide();
                        }
                        else if(GlobalVar.mainfrm.Controls.Count > 1)
                        {
                            if(GlobalVar.mainfrm.Controls[0].Name.Equals("ucEscrows"))
                            {
                                GlobalVar.ucEscrw.getFPVer(true);
                            }
                            else if (GlobalVar.mainfrm.Controls[0].Name.Equals("ucFinailzeEscrows"))
                            {
                                GlobalVar.ucfzEscrw.getFPVer(true);
                            }
                        }
                    });


                    tmrClose.Start();


                }
                else
                {
                    //Client not verified
                    XtraMessageBox.Show("User is not " + usr_nme, this.Text,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tmrClose.Start();

                    //Close the form
                }
            }
        }

        private void remindUsrFingertoEnroll(int fingerPosition)
        {
            if (fingerPosition == 0)
            {
                XtraMessageBox.Show("Request Placement of Right Hand Thumb", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 1)
            {
                XtraMessageBox.Show("Request Placement of Right Hand Index Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 2)
            {
                XtraMessageBox.Show("Request Placement of Right Hand Middle Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 3)
            {
                XtraMessageBox.Show("Request Placement of Right Hand Ring Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 4)
            {
                XtraMessageBox.Show("Request Placement of Right Hand Pinky Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 5)
            {
                XtraMessageBox.Show("Request Placement of Left Hand Thumb", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 6)
            {
                XtraMessageBox.Show("Request Placement of Left Hand Index Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 7)
            {
                XtraMessageBox.Show("Request Placement of Left Hand Middle Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 8)
            {
                XtraMessageBox.Show("Request Placement of Left Hand Ring Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fingerPosition == 9)
            {
                XtraMessageBox.Show("Request Placement of Left Hand Pinky Finger", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            tmrClose.Stop();

            this.Hide();

            this.Close();
        }

        private void frmVerBiometrics_Shown(object sender, EventArgs e)
        {
            configControl();
        }

        private void frmVerBiometrics_FormClosing(object sender, FormClosingEventArgs e)
        {
            identificationControl.StopIdentification();
        }
    }
}