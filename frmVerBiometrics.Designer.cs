
namespace EscrowManagement
{
    partial class frmVerBiometrics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerBiometrics));
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrClose
            // 
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // frmVerBiometrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmVerBiometrics.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "frmVerBiometrics";
            this.Text = "Verify Biometrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerBiometrics_FormClosing);
            this.Shown += new System.EventHandler(this.frmVerBiometrics_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrClose;
    }
}