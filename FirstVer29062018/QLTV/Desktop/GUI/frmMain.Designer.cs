namespace Desktop.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_TDG = new DevExpress.XtraBars.BarButtonItem();
            this.btn_User = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DSach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LSach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PSach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CTPSach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TGia = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CTTGia = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Admin = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MuonSach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TraSach = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_TDGia = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbon_DGia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_Sach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_TGia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_Admin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_TTMTra = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_BCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_TKiem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_QDinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedfMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btn_BaoCaoMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BaoCaoTra = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedfMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_TDG,
            this.btn_User,
            this.btn_DSach,
            this.btn_Sach,
            this.btn_LSach,
            this.btn_PSach,
            this.btn_CTPSach,
            this.btn_TGia,
            this.btn_CTTGia,
            this.btn_Admin,
            this.btn_MuonSach,
            this.btn_TraSach,
            this.btn_BaoCaoMuon,
            this.btn_BaoCaoTra});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbon_TDGia,
            this.ribbon_TTMTra,
            this.ribbon_BCao,
            this.ribbon_TKiem,
            this.ribbon_QDinh});
            this.ribbon.Size = new System.Drawing.Size(974, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_TDG
            // 
            this.btn_TDG.Caption = "Thẻ độc giả";
            this.btn_TDG.Id = 1;
            this.btn_TDG.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TDG.ImageOptions.LargeImage")));
            this.btn_TDG.Name = "btn_TDG";
            this.btn_TDG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TDG_ItemClick);
            // 
            // btn_User
            // 
            this.btn_User.Caption = "User";
            this.btn_User.Id = 2;
            this.btn_User.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_User.ImageOptions.LargeImage")));
            this.btn_User.Name = "btn_User";
            // 
            // btn_DSach
            // 
            this.btn_DSach.Caption = "Đầu sách";
            this.btn_DSach.Id = 3;
            this.btn_DSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DSach.ImageOptions.LargeImage")));
            this.btn_DSach.Name = "btn_DSach";
            // 
            // btn_Sach
            // 
            this.btn_Sach.Caption = "Sách";
            this.btn_Sach.Id = 4;
            this.btn_Sach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Sach.ImageOptions.LargeImage")));
            this.btn_Sach.Name = "btn_Sach";
            this.btn_Sach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Sach_ItemClick);
            // 
            // btn_LSach
            // 
            this.btn_LSach.Caption = "Loại sách";
            this.btn_LSach.Id = 5;
            this.btn_LSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_LSach.ImageOptions.LargeImage")));
            this.btn_LSach.Name = "btn_LSach";
            // 
            // btn_PSach
            // 
            this.btn_PSach.Caption = "Phiếu sách";
            this.btn_PSach.Id = 6;
            this.btn_PSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PSach.ImageOptions.LargeImage")));
            this.btn_PSach.Name = "btn_PSach";
            // 
            // btn_CTPSach
            // 
            this.btn_CTPSach.Caption = "Chi tiết phiếu sách";
            this.btn_CTPSach.Id = 7;
            this.btn_CTPSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_CTPSach.ImageOptions.LargeImage")));
            this.btn_CTPSach.Name = "btn_CTPSach";
            // 
            // btn_TGia
            // 
            this.btn_TGia.Caption = "Tác giả";
            this.btn_TGia.Id = 8;
            this.btn_TGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TGia.ImageOptions.LargeImage")));
            this.btn_TGia.Name = "btn_TGia";
            this.btn_TGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TGia_ItemClick);
            // 
            // btn_CTTGia
            // 
            this.btn_CTTGia.Caption = "Chi tiết tác giả";
            this.btn_CTTGia.Id = 9;
            this.btn_CTTGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_CTTGia.ImageOptions.LargeImage")));
            this.btn_CTTGia.Name = "btn_CTTGia";
            // 
            // btn_Admin
            // 
            this.btn_Admin.Caption = "Admin";
            this.btn_Admin.Id = 10;
            this.btn_Admin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Admin.ImageOptions.LargeImage")));
            this.btn_Admin.Name = "btn_Admin";
            // 
            // btn_MuonSach
            // 
            this.btn_MuonSach.Caption = "Mượn sách";
            this.btn_MuonSach.Id = 11;
            this.btn_MuonSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_MuonSach.ImageOptions.LargeImage")));
            this.btn_MuonSach.Name = "btn_MuonSach";
            this.btn_MuonSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MuonSach_ItemClick);
            // 
            // btn_TraSach
            // 
            this.btn_TraSach.Caption = "Trả sách";
            this.btn_TraSach.Id = 12;
            this.btn_TraSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TraSach.ImageOptions.LargeImage")));
            this.btn_TraSach.Name = "btn_TraSach";
            this.btn_TraSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TraSach_ItemClick);
            // 
            // ribbon_TDGia
            // 
            this.ribbon_TDGia.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbon_DGia,
            this.ribbon_Sach,
            this.ribbon_TGia,
            this.ribbon_Admin});
            this.ribbon_TDGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbon_TDGia.ImageOptions.Image")));
            this.ribbon_TDGia.Name = "ribbon_TDGia";
            this.ribbon_TDGia.Text = "Quản lí";
            // 
            // ribbon_DGia
            // 
            this.ribbon_DGia.ItemLinks.Add(this.btn_TDG);
            this.ribbon_DGia.Name = "ribbon_DGia";
            this.ribbon_DGia.Text = "Độc giả";
            // 
            // ribbon_Sach
            // 
            this.ribbon_Sach.ItemLinks.Add(this.btn_Sach);
            this.ribbon_Sach.Name = "ribbon_Sach";
            this.ribbon_Sach.Text = "Sách";
            // 
            // ribbon_TGia
            // 
            this.ribbon_TGia.ItemLinks.Add(this.btn_TGia);
            this.ribbon_TGia.ItemLinks.Add(this.btn_CTTGia);
            this.ribbon_TGia.Name = "ribbon_TGia";
            this.ribbon_TGia.Text = "Tác giả";
            // 
            // ribbon_Admin
            // 
            this.ribbon_Admin.ItemLinks.Add(this.btn_Admin);
            this.ribbon_Admin.Name = "ribbon_Admin";
            this.ribbon_Admin.Text = "Admin";
            // 
            // ribbon_TTMTra
            // 
            this.ribbon_TTMTra.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbon_TTMTra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbon_TTMTra.ImageOptions.Image")));
            this.ribbon_TTMTra.Name = "ribbon_TTMTra";
            this.ribbon_TTMTra.Text = "Thông tin mượn trả";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_MuonSach);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lí mượn sách";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_TraSach);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Quản lí trả";
            // 
            // ribbon_BCao
            // 
            this.ribbon_BCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbon_BCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbon_BCao.ImageOptions.Image")));
            this.ribbon_BCao.Name = "ribbon_BCao";
            this.ribbon_BCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_BaoCaoMuon);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_BaoCaoTra);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Báo cáo";
            // 
            // ribbon_TKiem
            // 
            this.ribbon_TKiem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbon_TKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbon_TKiem.ImageOptions.Image")));
            this.ribbon_TKiem.Name = "ribbon_TKiem";
            this.ribbon_TKiem.Text = "Tìm kiếm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbon_QDinh
            // 
            this.ribbon_QDinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbon_QDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbon_QDinh.ImageOptions.Image")));
            this.ribbon_QDinh.Name = "ribbon_QDinh";
            this.ribbon_QDinh.Text = "Quy định";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 549);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(974, 31);
            // 
            // xtraTabbedfMain
            // 
            this.xtraTabbedfMain.MdiParent = this;
            // 
            // btn_BaoCaoMuon
            // 
            this.btn_BaoCaoMuon.Caption = "Báo cáo phiếu mượn";
            this.btn_BaoCaoMuon.Id = 13;
            this.btn_BaoCaoMuon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_BaoCaoMuon.Name = "btn_BaoCaoMuon";
            this.btn_BaoCaoMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BaoCaoMuon_ItemClick);
            // 
            // btn_BaoCaoTra
            // 
            this.btn_BaoCaoTra.Caption = "Báo cáo phiếu trả";
            this.btn_BaoCaoTra.Id = 15;
            this.btn_BaoCaoTra.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btn_BaoCaoTra.Name = "btn_BaoCaoTra";
            this.btn_BaoCaoTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BaoCaoTra_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 580);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Tag = "";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedfMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_TDG;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_TDGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_DGia;
        private DevExpress.XtraBars.BarButtonItem btn_User;
        private DevExpress.XtraBars.BarButtonItem btn_DSach;
        private DevExpress.XtraBars.BarButtonItem btn_Sach;
        private DevExpress.XtraBars.BarButtonItem btn_LSach;
        private DevExpress.XtraBars.BarButtonItem btn_PSach;
        private DevExpress.XtraBars.BarButtonItem btn_CTPSach;
        private DevExpress.XtraBars.BarButtonItem btn_TGia;
        private DevExpress.XtraBars.BarButtonItem btn_CTTGia;
        private DevExpress.XtraBars.BarButtonItem btn_Admin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_Sach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_TGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_Admin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_TTMTra;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_BCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_TKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_QDinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedfMain;
        private DevExpress.XtraBars.BarButtonItem btn_MuonSach;
        private DevExpress.XtraBars.BarButtonItem btn_TraSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_BaoCaoMuon;
        private DevExpress.XtraBars.BarButtonItem btn_BaoCaoTra;
    }
}