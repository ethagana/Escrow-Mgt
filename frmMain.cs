using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EscrowManagement
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clearControls()
        {
            if (this.Controls.Count > 1)
            {
                if (GlobalVar.access_lvl == 1)
                {
                    GlobalVar.ucEscrw = null;
                }
                else if(GlobalVar.access_lvl == 2)
                {
                    GlobalVar.ucfzEscrw = null;
                }

                this.Controls.RemoveAt(0);
            }

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (GlobalVar.access_lvl == 1)
            {
                GlobalVar.ucEscrw = new ucEscrows() { Dock = DockStyle.Fill };
                this.Controls.Add(GlobalVar.ucEscrw);
            }
            else if(GlobalVar.access_lvl == 2)
            {
                GlobalVar.ucfzEscrw = new ucFinailzeEscrows() { Dock = DockStyle.Fill };
                this.Controls.Add(GlobalVar.ucfzEscrw);
            }

        }

        private void bbiEscrows_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clearControls();

            if (GlobalVar.access_lvl == 1)
            {
                GlobalVar.ucEscrw = new ucEscrows() { Dock = DockStyle.Fill };
                this.Controls.Add(GlobalVar.ucEscrw);
            }
            else if (GlobalVar.access_lvl == 2)
            {
                GlobalVar.ucfzEscrw = new ucFinailzeEscrows() { Dock = DockStyle.Fill };
                this.Controls.Add(GlobalVar.ucfzEscrw);
            }
        }
    }
}
