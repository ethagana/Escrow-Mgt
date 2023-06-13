
namespace EscrowManagement
{
    partial class ucFinailzeEscrows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdEscrowsAA = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.memOveride = new DevExpress.XtraEditors.MemoEdit();
            this.memRej = new DevExpress.XtraEditors.MemoEdit();
            this.txtSTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.memSecOveride = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rgpSecOverride = new DevExpress.XtraEditors.RadioGroup();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdFinalize = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grdEscrowsFI = new DevExpress.XtraGrid.GridControl();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEscrowsAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memOveride.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRej.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDTel.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memSecOveride.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgpSecOverride.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEscrowsFI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grdEscrowsAA);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escrows Awaiting Approval";
            // 
            // grdEscrowsAA
            // 
            this.grdEscrowsAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEscrowsAA.Location = new System.Drawing.Point(3, 17);
            this.grdEscrowsAA.MainView = this.gridView1;
            this.grdEscrowsAA.Name = "grdEscrowsAA";
            this.grdEscrowsAA.Size = new System.Drawing.Size(319, 528);
            this.grdEscrowsAA.TabIndex = 0;
            this.grdEscrowsAA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdEscrowsAA;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.memOveride);
            this.groupBox2.Controls.Add(this.memRej);
            this.groupBox2.Controls.Add(this.txtSTel);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.txtDTel);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Location = new System.Drawing.Point(333, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reasons for Escrow Dispute";
            // 
            // memOveride
            // 
            this.memOveride.Location = new System.Drawing.Point(7, 183);
            this.memOveride.Name = "memOveride";
            this.memOveride.Size = new System.Drawing.Size(394, 65);
            this.memOveride.TabIndex = 2;
            // 
            // memRej
            // 
            this.memRej.Location = new System.Drawing.Point(7, 91);
            this.memRej.Name = "memRej";
            this.memRej.Size = new System.Drawing.Size(394, 65);
            this.memRej.TabIndex = 2;
            // 
            // txtSTel
            // 
            this.txtSTel.Location = new System.Drawing.Point(207, 41);
            this.txtSTel.Name = "txtSTel";
            this.txtSTel.Size = new System.Drawing.Size(194, 20);
            this.txtSTel.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(207, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Sender Tel";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 162);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(132, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Override Decision Given";
            // 
            // txtDTel
            // 
            this.txtDTel.Location = new System.Drawing.Point(7, 41);
            this.txtDTel.Name = "txtDTel";
            this.txtDTel.Size = new System.Drawing.Size(194, 20);
            this.txtDTel.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 70);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Reason for Rejection";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Disputee Tel";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.memSecOveride);
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.rgpSecOverride);
            this.groupBox3.Location = new System.Drawing.Point(332, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finalize Decision";
            // 
            // memSecOveride
            // 
            this.memSecOveride.Location = new System.Drawing.Point(7, 112);
            this.memSecOveride.Name = "memSecOveride";
            this.memSecOveride.Properties.MaxLength = 160;
            this.memSecOveride.Size = new System.Drawing.Size(403, 64);
            this.memSecOveride.TabIndex = 2;
            this.memSecOveride.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memSecOveride_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Reason for decision";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Escrow Status";
            // 
            // rgpSecOverride
            // 
            this.rgpSecOverride.Location = new System.Drawing.Point(7, 41);
            this.rgpSecOverride.Name = "rgpSecOverride";
            this.rgpSecOverride.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Approve"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Reject")});
            this.rgpSecOverride.Size = new System.Drawing.Size(403, 35);
            this.rgpSecOverride.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cmdFinalize);
            this.groupBox4.Location = new System.Drawing.Point(331, 460);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 89);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Command";
            // 
            // cmdFinalize
            // 
            this.cmdFinalize.Enabled = false;
            this.cmdFinalize.Location = new System.Drawing.Point(6, 20);
            this.cmdFinalize.Name = "cmdFinalize";
            this.cmdFinalize.Size = new System.Drawing.Size(404, 53);
            this.cmdFinalize.TabIndex = 0;
            this.cmdFinalize.Text = "Finalize Decision";
            this.cmdFinalize.Click += new System.EventHandler(this.cmdFinalize_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.grdEscrowsFI);
            this.groupBox5.Location = new System.Drawing.Point(756, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 545);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Escrows Finalized";
            // 
            // grdEscrowsFI
            // 
            this.grdEscrowsFI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEscrowsFI.Location = new System.Drawing.Point(3, 17);
            this.grdEscrowsFI.MainView = this.layoutView1;
            this.grdEscrowsFI.Name = "grdEscrowsFI";
            this.grdEscrowsFI.Size = new System.Drawing.Size(294, 525);
            this.grdEscrowsFI.TabIndex = 0;
            this.grdEscrowsFI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 600000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.grdEscrowsFI;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // ucFinailzeEscrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucFinailzeEscrows";
            this.Size = new System.Drawing.Size(1059, 555);
            this.Load += new System.EventHandler(this.ucFinailzeEscrows_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEscrowsAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memOveride.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRej.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDTel.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memSecOveride.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgpSecOverride.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEscrowsFI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grdEscrowsAA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.MemoEdit memSecOveride;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rgpSecOverride;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton cmdFinalize;
        private DevExpress.XtraEditors.MemoEdit memOveride;
        private DevExpress.XtraEditors.MemoEdit memRej;
        private DevExpress.XtraEditors.TextEdit txtSTel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtDTel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl grdEscrowsFI;
        private System.Windows.Forms.Timer tmrRefresh;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
