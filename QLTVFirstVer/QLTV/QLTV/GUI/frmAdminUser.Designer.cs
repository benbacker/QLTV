namespace Desktop.GUI
{
    partial class frmAdminUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUser));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.groupControl_TTDG = new DevExpress.XtraEditors.GroupControl();
            this.btn_ThemLoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.tb_HoTenAdmin = new System.Windows.Forms.TextBox();
            this.tb_Passwork = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Lamlai = new System.Windows.Forms.Button();
            this.bt_CNDL = new System.Windows.Forms.Button();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Diachi = new System.Windows.Forms.TextBox();
            this.dt_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.tb_NhapTT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_ThongTinTimKiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBt_SuaTT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_XuatCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Thoat = new System.Windows.Forms.ToolStripButton();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.cl_IDAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HoTenAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgaySinhAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UserNameAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_DiaChiAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_EmailAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).BeginInit();
            this.groupControl_TTDG.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(832, 758);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(832, 758);
            this.navigationPane1.TabIndex = 1;
            this.navigationPane1.Text = "Tìm kiếm thông tin độc giả";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm tài khoản admin";
            this.navigationPage2.Controls.Add(this.navigationFrame1);
            this.navigationPage2.Controls.Add(this.groupControl_TTDG);
            this.navigationPage2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(726, 688);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(4);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.SelectedPage = null;
            this.navigationFrame1.Size = new System.Drawing.Size(726, 0);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // groupControl_TTDG
            // 
            this.groupControl_TTDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl_TTDG.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.Appearance.Options.UseFont = true;
            this.groupControl_TTDG.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.AppearanceCaption.Options.UseFont = true;
            this.groupControl_TTDG.AutoSize = true;
            this.groupControl_TTDG.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_TTDG.CaptionImageOptions.Image")));
            this.groupControl_TTDG.Controls.Add(this.btn_ThemLoaiSach);
            this.groupControl_TTDG.Controls.Add(this.tb_HoTenAdmin);
            this.groupControl_TTDG.Controls.Add(this.tb_Passwork);
            this.groupControl_TTDG.Controls.Add(this.label10);
            this.groupControl_TTDG.Controls.Add(this.label1);
            this.groupControl_TTDG.Controls.Add(this.bt_Lamlai);
            this.groupControl_TTDG.Controls.Add(this.bt_CNDL);
            this.groupControl_TTDG.Controls.Add(this.cb_ChucVu);
            this.groupControl_TTDG.Controls.Add(this.tb_Email);
            this.groupControl_TTDG.Controls.Add(this.tb_Diachi);
            this.groupControl_TTDG.Controls.Add(this.dt_Ngaysinh);
            this.groupControl_TTDG.Controls.Add(this.tb_User);
            this.groupControl_TTDG.Controls.Add(this.label6);
            this.groupControl_TTDG.Controls.Add(this.label5);
            this.groupControl_TTDG.Controls.Add(this.label4);
            this.groupControl_TTDG.Controls.Add(this.label3);
            this.groupControl_TTDG.Controls.Add(this.label2);
            this.groupControl_TTDG.Location = new System.Drawing.Point(0, 0);
            this.groupControl_TTDG.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_TTDG.Name = "groupControl_TTDG";
            this.groupControl_TTDG.Size = new System.Drawing.Size(722, 750);
            this.groupControl_TTDG.TabIndex = 0;
            this.groupControl_TTDG.Text = "Thông tin admin";
            // 
            // btn_ThemLoaiSach
            // 
            this.btn_ThemLoaiSach.Location = new System.Drawing.Point(582, 184);
            this.btn_ThemLoaiSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemLoaiSach.Name = "btn_ThemLoaiSach";
            this.btn_ThemLoaiSach.Size = new System.Drawing.Size(116, 34);
            this.btn_ThemLoaiSach.TabIndex = 35;
            this.btn_ThemLoaiSach.Text = "Đổi mật khẩu";
            this.btn_ThemLoaiSach.Click += new System.EventHandler(this.btn_ThemLoaiSach_Click);
            // 
            // tb_HoTenAdmin
            // 
            this.tb_HoTenAdmin.Location = new System.Drawing.Point(146, 73);
            this.tb_HoTenAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tb_HoTenAdmin.Name = "tb_HoTenAdmin";
            this.tb_HoTenAdmin.Size = new System.Drawing.Size(428, 36);
            this.tb_HoTenAdmin.TabIndex = 0;
            // 
            // tb_Passwork
            // 
            this.tb_Passwork.Location = new System.Drawing.Point(146, 180);
            this.tb_Passwork.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Passwork.Name = "tb_Passwork";
            this.tb_Passwork.Size = new System.Drawing.Size(428, 36);
            this.tb_Passwork.TabIndex = 2;
            this.tb_Passwork.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(4, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tài khoản:";
            // 
            // bt_Lamlai
            // 
            this.bt_Lamlai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Lamlai.Image = ((System.Drawing.Image)(resources.GetObject("bt_Lamlai.Image")));
            this.bt_Lamlai.Location = new System.Drawing.Point(391, 492);
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
            this.bt_CNDL.Location = new System.Drawing.Point(112, 492);
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
            // cb_ChucVu
            // 
            this.cb_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên",
            "Kế toán"});
            this.cb_ChucVu.Location = new System.Drawing.Point(146, 390);
            this.cb_ChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(428, 37);
            this.cb_ChucVu.TabIndex = 12;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(146, 337);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(428, 36);
            this.tb_Email.TabIndex = 11;
            // 
            // tb_Diachi
            // 
            this.tb_Diachi.Location = new System.Drawing.Point(146, 286);
            this.tb_Diachi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Diachi.Name = "tb_Diachi";
            this.tb_Diachi.Size = new System.Drawing.Size(428, 36);
            this.tb_Diachi.TabIndex = 10;
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dt_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Ngaysinh.Location = new System.Drawing.Point(146, 240);
            this.dt_Ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(428, 36);
            this.dt_Ngaysinh.TabIndex = 9;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(146, 124);
            this.tb_User.Margin = new System.Windows.Forms.Padding(4);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(428, 36);
            this.tb_User.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(4, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Tìm kiếm thông tin độc giả";
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(4);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(701, 684);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.groupControl3.Size = new System.Drawing.Size(709, 684);
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
            "Email",
            "Tài khoản"});
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
            this.groupControl2.Controls.Add(this.dgv_DuLieu);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(840, 63);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1198, 685);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Dữ liệu admin";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBt_SuaTT,
            this.toolStripSeparator1,
            this.toolStripBt_Xoa,
            this.toolStripSeparator2,
            this.toolStripBt_XuatCSV,
            this.toolStripSeparator4,
            this.toolStripBt_Reset,
            this.toolStripSeparator5,
            this.toolStripBt_Thoat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 40);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1198, 35);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripBt_SuaTT
            // 
            this.toolStripBt_SuaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_SuaTT.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_SuaTT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_SuaTT.Image")));
            this.toolStripBt_SuaTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_SuaTT.Name = "toolStripBt_SuaTT";
            this.toolStripBt_SuaTT.Size = new System.Drawing.Size(169, 32);
            this.toolStripBt_SuaTT.Text = "Sữa thông tin";
            this.toolStripBt_SuaTT.Click += new System.EventHandler(this.toolStripBt_SuaTT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
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
            this.toolStripBt_Reset.Click += new System.EventHandler(this.toolStripBt_Reset_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
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
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_IDAdmin,
            this.cl_HoTenAdmin,
            this.cl_NgaySinhAdmin,
            this.cl_UserNameAdmin,
            this.cl_DiaChiAdmin,
            this.cl_EmailAdmin,
            this.cl_QuyenHan});
            this.dgv_DuLieu.Location = new System.Drawing.Point(0, 81);
            this.dgv_DuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.Size = new System.Drawing.Size(1198, 604);
            this.dgv_DuLieu.TabIndex = 0;
            this.dgv_DuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DuLieu_CellClick);
            // 
            // cl_IDAdmin
            // 
            this.cl_IDAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_IDAdmin.DataPropertyName = "IDAdmin";
            this.cl_IDAdmin.FillWeight = 228.4264F;
            this.cl_IDAdmin.HeaderText = "STT";
            this.cl_IDAdmin.Name = "cl_IDAdmin";
            // 
            // cl_HoTenAdmin
            // 
            this.cl_HoTenAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_HoTenAdmin.DataPropertyName = "HoTenAdmin";
            this.cl_HoTenAdmin.FillWeight = 35.7868F;
            this.cl_HoTenAdmin.HeaderText = "Tên Admin";
            this.cl_HoTenAdmin.Name = "cl_HoTenAdmin";
            this.cl_HoTenAdmin.Width = 200;
            // 
            // cl_NgaySinhAdmin
            // 
            this.cl_NgaySinhAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_NgaySinhAdmin.DataPropertyName = "NgaySinhAdmin";
            this.cl_NgaySinhAdmin.FillWeight = 35.7868F;
            this.cl_NgaySinhAdmin.HeaderText = "Ngày sinh";
            this.cl_NgaySinhAdmin.Name = "cl_NgaySinhAdmin";
            this.cl_NgaySinhAdmin.Width = 150;
            // 
            // cl_UserNameAdmin
            // 
            this.cl_UserNameAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_UserNameAdmin.DataPropertyName = "UserNameAdmin";
            this.cl_UserNameAdmin.HeaderText = "Tài khoản";
            this.cl_UserNameAdmin.Name = "cl_UserNameAdmin";
            this.cl_UserNameAdmin.Width = 200;
            // 
            // cl_DiaChiAdmin
            // 
            this.cl_DiaChiAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_DiaChiAdmin.DataPropertyName = "DiaChiAdmin";
            this.cl_DiaChiAdmin.HeaderText = "Địa chỉ";
            this.cl_DiaChiAdmin.Name = "cl_DiaChiAdmin";
            this.cl_DiaChiAdmin.Width = 250;
            // 
            // cl_EmailAdmin
            // 
            this.cl_EmailAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_EmailAdmin.DataPropertyName = "EmailAdmin";
            this.cl_EmailAdmin.HeaderText = "Email";
            this.cl_EmailAdmin.Name = "cl_EmailAdmin";
            this.cl_EmailAdmin.Width = 150;
            // 
            // cl_QuyenHan
            // 
            this.cl_QuyenHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_QuyenHan.DataPropertyName = "QuyenHan";
            this.cl_QuyenHan.HeaderText = "Chức vụ";
            this.cl_QuyenHan.Name = "cl_QuyenHan";
            this.cl_QuyenHan.Width = 180;
            // 
            // frmAdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 758);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.navigationPane1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminUser";
            this.Text = "Thông tin tài khoản admin";
            this.Load += new System.EventHandler(this.frmAdminUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).EndInit();
            this.groupControl_TTDG.ResumeLayout(false);
            this.groupControl_TTDG.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraEditors.GroupControl groupControl_TTDG;
        private System.Windows.Forms.TextBox tb_HoTenAdmin;
        private System.Windows.Forms.TextBox tb_Passwork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Lamlai;
        private System.Windows.Forms.Button bt_CNDL;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Diachi;
        private System.Windows.Forms.DateTimePicker dt_Ngaysinh;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox tb_NhapTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ThongTinTimKiem;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripBt_SuaTT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBt_XuatCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBt_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripBt_Thoat;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_IDAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HoTenAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgaySinhAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserNameAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DiaChiAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_EmailAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_QuyenHan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBt_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_ThemLoaiSach;
    }
}