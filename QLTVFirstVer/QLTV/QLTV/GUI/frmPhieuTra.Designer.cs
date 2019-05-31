namespace Desktop.GUI
{
    partial class frmPhieuTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.groupControl_TTPT = new DevExpress.XtraEditors.GroupControl();
            this.btn_XoaListSach = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChonSachVaoList = new DevExpress.XtraEditors.SimpleButton();
            this.listbox_TenDauSach = new System.Windows.Forms.ListBox();
            this.dgv_DuLieuTra = new System.Windows.Forms.DataGridView();
            this.cl_IDCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_IDPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenNguoiTra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Lamlai = new System.Windows.Forms.Button();
            this.bt_CNDL = new System.Windows.Forms.Button();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.tb_NhapTT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_ThongTinTimKiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBt_XuatCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Thoat = new System.Windows.Forms.ToolStripButton();
            this.dgv_DuLieuPT = new System.Windows.Forms.DataGridView();
            this.cl_IDTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NguoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenSachTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripBt_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTPT)).BeginInit();
            this.groupControl_TTPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuTra)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuPT)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationPane1.Appearance.Options.UseBackColor = true;
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(4);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(828, 747);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(828, 747);
            this.navigationPane1.TabIndex = 4;
            this.navigationPane1.Text = "Tìm kiếm thông tin độc giả";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm phiếu trả";
            this.navigationPage2.Controls.Add(this.navigationFrame1);
            this.navigationPage2.Controls.Add(this.groupControl_TTPT);
            this.navigationPage2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(722, 677);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(4);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.SelectedPage = null;
            this.navigationFrame1.Size = new System.Drawing.Size(722, 0);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // groupControl_TTPT
            // 
            this.groupControl_TTPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_TTPT.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTPT.Appearance.Options.UseFont = true;
            this.groupControl_TTPT.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTPT.AppearanceCaption.Options.UseFont = true;
            this.groupControl_TTPT.AutoSize = true;
            this.groupControl_TTPT.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_TTPT.CaptionImageOptions.Image")));
            this.groupControl_TTPT.Controls.Add(this.btn_XoaListSach);
            this.groupControl_TTPT.Controls.Add(this.btn_ChonSachVaoList);
            this.groupControl_TTPT.Controls.Add(this.listbox_TenDauSach);
            this.groupControl_TTPT.Controls.Add(this.dgv_DuLieuTra);
            this.groupControl_TTPT.Controls.Add(this.dt_NgayTra);
            this.groupControl_TTPT.Controls.Add(this.label1);
            this.groupControl_TTPT.Controls.Add(this.tb_TenNguoiTra);
            this.groupControl_TTPT.Controls.Add(this.label2);
            this.groupControl_TTPT.Controls.Add(this.bt_Lamlai);
            this.groupControl_TTPT.Controls.Add(this.bt_CNDL);
            this.groupControl_TTPT.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl_TTPT.Location = new System.Drawing.Point(0, 0);
            this.groupControl_TTPT.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_TTPT.Name = "groupControl_TTPT";
            this.groupControl_TTPT.Size = new System.Drawing.Size(744, 724);
            this.groupControl_TTPT.TabIndex = 0;
            this.groupControl_TTPT.Text = "Thông tin phiếu trả";
            // 
            // btn_XoaListSach
            // 
            this.btn_XoaListSach.Location = new System.Drawing.Point(553, 410);
            this.btn_XoaListSach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaListSach.Name = "btn_XoaListSach";
            this.btn_XoaListSach.Size = new System.Drawing.Size(144, 32);
            this.btn_XoaListSach.TabIndex = 28;
            this.btn_XoaListSach.Text = "Xóa khỏi danh sách";
            this.btn_XoaListSach.Click += new System.EventHandler(this.btn_XoaListSach_Click);
            // 
            // btn_ChonSachVaoList
            // 
            this.btn_ChonSachVaoList.Location = new System.Drawing.Point(553, 228);
            this.btn_ChonSachVaoList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChonSachVaoList.Name = "btn_ChonSachVaoList";
            this.btn_ChonSachVaoList.Size = new System.Drawing.Size(144, 32);
            this.btn_ChonSachVaoList.TabIndex = 27;
            this.btn_ChonSachVaoList.Text = "Chọn sách";
            this.btn_ChonSachVaoList.Click += new System.EventHandler(this.btn_ChonSachVaoList_Click);
            // 
            // listbox_TenDauSach
            // 
            this.listbox_TenDauSach.FormattingEnabled = true;
            this.listbox_TenDauSach.ItemHeight = 29;
            this.listbox_TenDauSach.Location = new System.Drawing.Point(20, 410);
            this.listbox_TenDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.listbox_TenDauSach.Name = "listbox_TenDauSach";
            this.listbox_TenDauSach.Size = new System.Drawing.Size(524, 149);
            this.listbox_TenDauSach.TabIndex = 26;
            // 
            // dgv_DuLieuTra
            // 
            this.dgv_DuLieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_IDCuonSach,
            this.cl_IDPhieuMuon,
            this.cl_TenCuonSach,
            this.cl_TinhTrang});
            this.dgv_DuLieuTra.Location = new System.Drawing.Point(20, 204);
            this.dgv_DuLieuTra.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DuLieuTra.Name = "dgv_DuLieuTra";
            this.dgv_DuLieuTra.Size = new System.Drawing.Size(525, 198);
            this.dgv_DuLieuTra.TabIndex = 25;
            // 
            // cl_IDCuonSach
            // 
            this.cl_IDCuonSach.DataPropertyName = "IDCuonSach";
            this.cl_IDCuonSach.HeaderText = "STT";
            this.cl_IDCuonSach.Name = "cl_IDCuonSach";
            // 
            // cl_IDPhieuMuon
            // 
            this.cl_IDPhieuMuon.DataPropertyName = "IDPhieuMuon";
            this.cl_IDPhieuMuon.HeaderText = "IDPhieuMuon";
            this.cl_IDPhieuMuon.Name = "cl_IDPhieuMuon";
            // 
            // cl_TenCuonSach
            // 
            this.cl_TenCuonSach.DataPropertyName = "TenDauSach";
            this.cl_TenCuonSach.HeaderText = "Tên cuốn sách";
            this.cl_TenCuonSach.Name = "cl_TenCuonSach";
            this.cl_TenCuonSach.Width = 250;
            // 
            // cl_TinhTrang
            // 
            this.cl_TinhTrang.DataPropertyName = "TinhTrang";
            this.cl_TinhTrang.HeaderText = "Tình trạng";
            this.cl_TinhTrang.Name = "cl_TinhTrang";
            this.cl_TinhTrang.Width = 180;
            // 
            // dt_NgayTra
            // 
            this.dt_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayTra.Location = new System.Drawing.Point(201, 114);
            this.dt_NgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dt_NgayTra.Name = "dt_NgayTra";
            this.dt_NgayTra.Size = new System.Drawing.Size(343, 36);
            this.dt_NgayTra.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày trả:";
            // 
            // tb_TenNguoiTra
            // 
            this.tb_TenNguoiTra.Location = new System.Drawing.Point(201, 68);
            this.tb_TenNguoiTra.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TenNguoiTra.Name = "tb_TenNguoiTra";
            this.tb_TenNguoiTra.Size = new System.Drawing.Size(343, 36);
            this.tb_TenNguoiTra.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // bt_Lamlai
            // 
            this.bt_Lamlai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Lamlai.Image = ((System.Drawing.Image)(resources.GetObject("bt_Lamlai.Image")));
            this.bt_Lamlai.Location = new System.Drawing.Point(357, 603);
            this.bt_Lamlai.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Lamlai.Name = "bt_Lamlai";
            this.bt_Lamlai.Size = new System.Drawing.Size(125, 52);
            this.bt_Lamlai.TabIndex = 15;
            this.bt_Lamlai.Text = "Làm lại";
            this.bt_Lamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Lamlai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Lamlai.UseVisualStyleBackColor = true;
            this.bt_Lamlai.Click += new System.EventHandler(this.bt_Lamlai_Click);
            // 
            // bt_CNDL
            // 
            this.bt_CNDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CNDL.Image = ((System.Drawing.Image)(resources.GetObject("bt_CNDL.Image")));
            this.bt_CNDL.Location = new System.Drawing.Point(39, 603);
            this.bt_CNDL.Margin = new System.Windows.Forms.Padding(4);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(189, 52);
            this.bt_CNDL.TabIndex = 14;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            this.bt_CNDL.Click += new System.EventHandler(this.bt_CNDL_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Tìm kiếm thông tin phiếu trả";
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(4);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(722, 677);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.bt_TimKiem);
            this.groupControl3.Controls.Add(this.tb_NhapTT);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.cbb_ThongTinTimKiem);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(709, 747);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm thông tin:";
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_TimKiem.Image")));
            this.bt_TimKiem.Location = new System.Drawing.Point(213, 278);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(200, 53);
            this.bt_TimKiem.TabIndex = 4;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // tb_NhapTT
            // 
            this.tb_NhapTT.Location = new System.Drawing.Point(281, 194);
            this.tb_NhapTT.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NhapTT.Name = "tb_NhapTT";
            this.tb_NhapTT.Size = new System.Drawing.Size(355, 36);
            this.tb_NhapTT.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(19, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhập thông tin:";
            // 
            // cbb_ThongTinTimKiem
            // 
            this.cbb_ThongTinTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ThongTinTimKiem.FormattingEnabled = true;
            this.cbb_ThongTinTimKiem.Items.AddRange(new object[] {
            "Họ và tên",
            "Tên sách"});
            this.cbb_ThongTinTimKiem.Location = new System.Drawing.Point(281, 117);
            this.cbb_ThongTinTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_ThongTinTimKiem.Name = "cbb_ThongTinTimKiem";
            this.cbb_ThongTinTimKiem.Size = new System.Drawing.Size(355, 37);
            this.cbb_ThongTinTimKiem.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(19, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin tìm kiếm:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Controls.Add(this.dgv_DuLieuPT);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(837, 64);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1192, 683);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Dữ liệu độc giả";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBt_XuatCSV,
            this.toolStripSeparator1,
            this.toolStripBt_Xoa,
            this.toolStripSeparator4,
            this.toolStripBt_Reset,
            this.toolStripSeparator6,
            this.toolStripBt_Thoat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 40);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1192, 35);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripBt_XuatCSV
            // 
            this.toolStripBt_XuatCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_XuatCSV.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_XuatCSV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_XuatCSV.Image")));
            this.toolStripBt_XuatCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_XuatCSV.Name = "toolStripBt_XuatCSV";
            this.toolStripBt_XuatCSV.Size = new System.Drawing.Size(126, 32);
            this.toolStripBt_XuatCSV.Text = "Xuất CSV";
            this.toolStripBt_XuatCSV.Click += new System.EventHandler(this.toolStripBt_XuatCSV_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripBt_Reset
            // 
            this.toolStripBt_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Reset.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Reset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Reset.Image")));
            this.toolStripBt_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Reset.Name = "toolStripBt_Reset";
            this.toolStripBt_Reset.Size = new System.Drawing.Size(164, 32);
            this.toolStripBt_Reset.Text = "Reset dữ liệu";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripBt_Thoat
            // 
            this.toolStripBt_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Thoat.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Thoat.Image")));
            this.toolStripBt_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Thoat.Name = "toolStripBt_Thoat";
            this.toolStripBt_Thoat.Size = new System.Drawing.Size(95, 32);
            this.toolStripBt_Thoat.Text = "Thoát";
            this.toolStripBt_Thoat.Click += new System.EventHandler(this.toolStripBt_Thoat_Click);
            // 
            // dgv_DuLieuPT
            // 
            this.dgv_DuLieuPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DuLieuPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieuPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_IDTacGia,
            this.cl_NguoiTra,
            this.cl_TenSachTra,
            this.cl_HanTra,
            this.cl_SoNgayMuon,
            this.cl_TienPhat});
            this.dgv_DuLieuPT.Location = new System.Drawing.Point(0, 81);
            this.dgv_DuLieuPT.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DuLieuPT.Name = "dgv_DuLieuPT";
            this.dgv_DuLieuPT.Size = new System.Drawing.Size(1192, 598);
            this.dgv_DuLieuPT.TabIndex = 0;
            // 
            // cl_IDTacGia
            // 
            this.cl_IDTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_IDTacGia.DataPropertyName = "IDCTPhieuTra";
            this.cl_IDTacGia.FillWeight = 228.4264F;
            this.cl_IDTacGia.HeaderText = "STT";
            this.cl_IDTacGia.Name = "cl_IDTacGia";
            this.cl_IDTacGia.Width = 120;
            // 
            // cl_NguoiTra
            // 
            this.cl_NguoiTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_NguoiTra.DataPropertyName = "HoTenDG";
            this.cl_NguoiTra.HeaderText = "Tên người trả";
            this.cl_NguoiTra.Name = "cl_NguoiTra";
            this.cl_NguoiTra.Width = 220;
            // 
            // cl_TenSachTra
            // 
            this.cl_TenSachTra.DataPropertyName = "TenDauSach";
            this.cl_TenSachTra.HeaderText = "Tên sách";
            this.cl_TenSachTra.Name = "cl_TenSachTra";
            this.cl_TenSachTra.Width = 350;
            // 
            // cl_HanTra
            // 
            this.cl_HanTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_HanTra.DataPropertyName = "NgayTra";
            this.cl_HanTra.HeaderText = "ngày trả";
            this.cl_HanTra.Name = "cl_HanTra";
            this.cl_HanTra.Width = 130;
            // 
            // cl_SoNgayMuon
            // 
            this.cl_SoNgayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_SoNgayMuon.DataPropertyName = "SoNgayMuon";
            this.cl_SoNgayMuon.HeaderText = "Số ngày mượn";
            this.cl_SoNgayMuon.Name = "cl_SoNgayMuon";
            this.cl_SoNgayMuon.Width = 250;
            // 
            // cl_TienPhat
            // 
            this.cl_TienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_TienPhat.DataPropertyName = "TienPhat";
            dataGridViewCellStyle2.Format = "#,###";
            this.cl_TienPhat.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_TienPhat.HeaderText = "Tiền phạt kì này";
            this.cl_TienPhat.Name = "cl_TienPhat";
            this.cl_TienPhat.Width = 250;
            // 
            // toolStripBt_Xoa
            // 
            this.toolStripBt_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Xoa.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Xoa.Image")));
            this.toolStripBt_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Xoa.Name = "toolStripBt_Xoa";
            this.toolStripBt_Xoa.Size = new System.Drawing.Size(76, 32);
            this.toolStripBt_Xoa.Text = "Xóa";
            this.toolStripBt_Xoa.Click += new System.EventHandler(this.toolStripBt_Xoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // frmPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 747);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.navigationPane1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuTra";
            this.Text = "Phiếu trả";
            this.Load += new System.EventHandler(this.frmPhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTPT)).EndInit();
            this.groupControl_TTPT.ResumeLayout(false);
            this.groupControl_TTPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuTra)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraEditors.GroupControl groupControl_TTPT;
        private DevExpress.XtraEditors.SimpleButton btn_ChonSachVaoList;
        private System.Windows.Forms.ListBox listbox_TenDauSach;
        private System.Windows.Forms.DataGridView dgv_DuLieuTra;
        private System.Windows.Forms.DateTimePicker dt_NgayTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenNguoiTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Lamlai;
        private System.Windows.Forms.Button bt_CNDL;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox tb_NhapTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ThongTinTimKiem;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripBt_XuatCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBt_Reset;
        private System.Windows.Forms.ToolStripButton toolStripBt_Thoat;
        private System.Windows.Forms.DataGridView dgv_DuLieuPT;
        private DevExpress.XtraEditors.SimpleButton btn_XoaListSach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_IDCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_IDPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_IDTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NguoiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenSachTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TienPhat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBt_Xoa;
    }
}