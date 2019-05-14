namespace Desktop.GUI
{
    partial class frmReportPhieuTra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BCSachTraTreDtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaoBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayLapBC = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDuLieu = new System.Windows.Forms.DataGridView();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_DayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BCSachTraTreDtosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(343, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo thống kê sách trả trễ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_TaoBaoCao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtNgayLapBC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê sách trả trễ";
            // 
            // btn_TaoBaoCao
            // 
            this.btn_TaoBaoCao.Location = new System.Drawing.Point(412, 40);
            this.btn_TaoBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaoBaoCao.Name = "btn_TaoBaoCao";
            this.btn_TaoBaoCao.Size = new System.Drawing.Size(91, 28);
            this.btn_TaoBaoCao.TabIndex = 35;
            this.btn_TaoBaoCao.Text = "Tạo báo cáo";
            this.btn_TaoBaoCao.Click += new System.EventHandler(this.btn_TaoBaoCao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày tháng năm:";
            // 
            // dtNgayLapBC
            // 
            this.dtNgayLapBC.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapBC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapBC.Location = new System.Drawing.Point(208, 40);
            this.dtNgayLapBC.Name = "dtNgayLapBC";
            this.dtNgayLapBC.Size = new System.Drawing.Size(179, 35);
            this.dtNgayLapBC.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvDuLieu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(3, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 360);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thống kê được";
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ID,
            this.cl_DayTime,
            this.cl_NgayTre});
            this.dgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuLieu.Location = new System.Drawing.Point(3, 27);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.Size = new System.Drawing.Size(587, 330);
            this.dgvDuLieu.TabIndex = 4;
            // 
            // cl_ID
            // 
            this.cl_ID.DataPropertyName = "IDBCSachTre";
            this.cl_ID.HeaderText = "STT";
            this.cl_ID.Name = "cl_ID";
            // 
            // cl_DayTime
            // 
            this.cl_DayTime.DataPropertyName = "NgayThangNam";
            this.cl_DayTime.HeaderText = "Ngày/Tháng/Năm";
            this.cl_DayTime.Name = "cl_DayTime";
            this.cl_DayTime.Width = 250;
            // 
            // cl_NgayTre
            // 
            this.cl_NgayTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_NgayTre.DataPropertyName = "SoNgayTraTre";
            this.cl_NgayTre.HeaderText = "Số ngày trễ";
            this.cl_NgayTre.Name = "cl_NgayTre";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RpvBaoCao);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(612, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 457);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem trước báo cáo thống kê sách trả trễ";
            // 
            // RpvBaoCao
            // 
            this.RpvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rpBaoCaoTra";
            reportDataSource1.Value = this.BCSachTraTreDtosBindingSource;
            this.RpvBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvBaoCao.LocalReport.ReportEmbeddedResource = "Desktop.Report.rpBaoCaoTraTre.rdlc";
            this.RpvBaoCao.LocalReport.ReportPath = "Report/rpBaoCaoTraTre.rdlc";
            this.RpvBaoCao.Location = new System.Drawing.Point(3, 31);
            this.RpvBaoCao.Name = "RpvBaoCao";
            this.RpvBaoCao.Size = new System.Drawing.Size(833, 423);
            this.RpvBaoCao.TabIndex = 0;
            // 
            // frmReportPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmReportPhieuTra";
            this.Text = "Báo cáo phiếu trả sách";
            this.Load += new System.EventHandler(this.frmReportPhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BCSachTraTreDtosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer RpvBaoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayLapBC;
        private System.Windows.Forms.DataGridView dgvDuLieu;
        private DevExpress.XtraEditors.SimpleButton btn_TaoBaoCao;
        private System.Windows.Forms.BindingSource BCSachTraTreDtosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgayTre;
    }
}