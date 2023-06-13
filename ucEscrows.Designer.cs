
namespace EscrowManagement
{
    partial class ucEscrows
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
            this.grdEscDisputed = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSender = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDteEscrReq = new DevExpress.XtraEditors.TextEdit();
            this.txtDisputee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRejRsn = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdOveride = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdEscProcessed = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEscDisputed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDteEscrReq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisputee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRejRsn.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEscProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grdEscDisputed);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escrows Disputed";
            // 
            // grdEscDisputed
            // 
            this.grdEscDisputed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEscDisputed.Location = new System.Drawing.Point(3, 17);
            this.grdEscDisputed.MainView = this.gridView1;
            this.grdEscDisputed.Name = "grdEscDisputed";
            this.grdEscDisputed.Size = new System.Drawing.Size(300, 510);
            this.grdEscDisputed.TabIndex = 0;
            this.grdEscDisputed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdEscDisputed;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.txtSender);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.txtAmt);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.txtDteEscrReq);
            this.groupBox2.Controls.Add(this.txtDisputee);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.txtRejRsn);
            this.groupBox2.Location = new System.Drawing.Point(321, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escrow Details";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 284);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Reason for Rejection";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(7, 247);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(316, 20);
            this.txtTel.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 226);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tel of Sender";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(7, 191);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(316, 20);
            this.txtSender.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 170);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Name of Sender";
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(7, 139);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(316, 20);
            this.txtAmt.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Amount Disputed";
            // 
            // txtDteEscrReq
            // 
            this.txtDteEscrReq.Location = new System.Drawing.Point(7, 41);
            this.txtDteEscrReq.Name = "txtDteEscrReq";
            this.txtDteEscrReq.Size = new System.Drawing.Size(316, 20);
            this.txtDteEscrReq.TabIndex = 1;
            // 
            // txtDisputee
            // 
            this.txtDisputee.Location = new System.Drawing.Point(7, 87);
            this.txtDisputee.Name = "txtDisputee";
            this.txtDisputee.Size = new System.Drawing.Size(316, 20);
            this.txtDisputee.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(134, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Date of Escrow Request";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Number of Disputee";
            // 
            // txtRejRsn
            // 
            this.txtRejRsn.Location = new System.Drawing.Point(7, 305);
            this.txtRejRsn.Name = "txtRejRsn";
            this.txtRejRsn.Properties.MaxLength = 160;
            this.txtRejRsn.Size = new System.Drawing.Size(316, 73);
            this.txtRejRsn.TabIndex = 9;
            this.txtRejRsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRejRsn_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmdOveride);
            this.groupBox3.Location = new System.Drawing.Point(321, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 98);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commands";
            // 
            // cmdOveride
            // 
            this.cmdOveride.Enabled = false;
            this.cmdOveride.Location = new System.Drawing.Point(7, 25);
            this.cmdOveride.Name = "cmdOveride";
            this.cmdOveride.Size = new System.Drawing.Size(316, 60);
            this.cmdOveride.TabIndex = 0;
            this.cmdOveride.Text = "Override";
            this.cmdOveride.Click += new System.EventHandler(this.cmdOveride_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.grdEscProcessed);
            this.groupBox4.Location = new System.Drawing.Point(660, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 530);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Escrows Processed";
            // 
            // grdEscProcessed
            // 
            this.grdEscProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEscProcessed.Location = new System.Drawing.Point(3, 17);
            this.grdEscProcessed.MainView = this.layoutView1;
            this.grdEscProcessed.Name = "grdEscProcessed";
            this.grdEscProcessed.Size = new System.Drawing.Size(308, 510);
            this.grdEscProcessed.TabIndex = 0;
            this.grdEscProcessed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.grdEscProcessed;
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
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 300000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // tmrScroll
            // 
            this.tmrScroll.Enabled = true;
            this.tmrScroll.Interval = 5000;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // ucEscrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucEscrows";
            this.Size = new System.Drawing.Size(977, 537);
            this.Load += new System.EventHandler(this.ucEscrows_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEscDisputed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDteEscrReq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisputee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRejRsn.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEscProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grdEscDisputed;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl grdEscProcessed;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSender;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAmt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDisputee;
        private DevExpress.XtraEditors.MemoEdit txtRejRsn;
        private DevExpress.XtraEditors.SimpleButton cmdOveride;
        private System.Windows.Forms.Timer tmrRefresh;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.Timer tmrScroll;
        private DevExpress.XtraEditors.TextEdit txtDteEscrReq;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
