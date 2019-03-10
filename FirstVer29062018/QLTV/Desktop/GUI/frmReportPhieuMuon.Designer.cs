namespace Desktop.GUI
{
    partial class frmReportPhieuMuon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_Nam = new System.Windows.Forms.TextBox();
            this.tb_Thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_TaoBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.BaoCaoTinhHinhMuonSachDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTinhHinhMuonSachDTOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Nam
            // 
            this.tb_Nam.Location = new System.Drawing.Point(334, 74);
            this.tb_Nam.Multiline = true;
            this.tb_Nam.Name = "tb_Nam";
            this.tb_Nam.Size = new System.Drawing.Size(117, 25);
            this.tb_Nam.TabIndex = 4;
            this.tb_Nam.TextChanged += new System.EventHandler(this.tb_Nam_TextChanged);
            // 
            // tb_Thang
            // 
            this.tb_Thang.Location = new System.Drawing.Point(107, 74);
            this.tb_Thang.Multiline = true;
            this.tb_Thang.Name = "tb_Thang";
            this.tb_Thang.Size = new System.Drawing.Size(117, 25);
            this.tb_Thang.TabIndex = 1;
            this.tb_Thang.TextChanged += new System.EventHandler(this.tb_Thang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(314, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo thống kê tình hình mượn sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thống kê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ID,
            this.cl_Thang,
            this.cl_Nam,
            this.cl_Muon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(641, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 437);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem trước báo cáo thống kê tính hình phiếu mượn";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "rpBaoCao";
            reportDataSource2.Value = this.BaoCaoTinhHinhMuonSachDTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Desktop.Report.rpTinhHinhMuonSach.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "Report/rpTinhHinhMuonSach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_TaoBaoCao
            // 
            this.btn_TaoBaoCao.Location = new System.Drawing.Point(496, 71);
            this.btn_TaoBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaoBaoCao.Name = "btn_TaoBaoCao";
            this.btn_TaoBaoCao.Size = new System.Drawing.Size(91, 28);
            this.btn_TaoBaoCao.TabIndex = 35;
            this.btn_TaoBaoCao.Text = "Tạo báo cáo";
            this.btn_TaoBaoCao.Click += new System.EventHandler(this.btn_TaoBaoCao_Click);
            // 
            // BaoCaoTinhHinhMuonSachDTOBindingSource
            // 
            this.BaoCaoTinhHinhMuonSachDTOBindingSource.DataSource = typeof(Data.DTO.BaoCaoTinhHinhMuonSachDTO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_TaoBaoCao);
            this.groupBox1.Controls.Add(this.tb_Nam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Thang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê tình hình mượn sách";
            // 
            // cl_ID
            // 
            this.cl_ID.DataPropertyName = "IDCTBCMuonSach";
            this.cl_ID.HeaderText = "STT";
            this.cl_ID.Name = "cl_ID";
            // 
            // cl_Thang
            // 
            this.cl_Thang.DataPropertyName = "Thang";
            this.cl_Thang.HeaderText = "Tháng";
            this.cl_Thang.Name = "cl_Thang";
            // 
            // cl_Nam
            // 
            this.cl_Nam.DataPropertyName = "Nam";
            this.cl_Nam.HeaderText = "Năm";
            this.cl_Nam.Name = "cl_Nam";
            // 
            // cl_Muon
            // 
            this.cl_Muon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_Muon.DataPropertyName = "TongSoLuotMuon";
            this.cl_Muon.HeaderText = "Tổng số lượt mượn";
            this.cl_Muon.Name = "cl_Muon";
            // 
            // frmReportPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportPhieuMuon";
            this.Text = "frmReportPhieuMuon";
            this.Load += new System.EventHandler(this.frmReportPhieuMuon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTinhHinhMuonSachDTOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Nam;
        private System.Windows.Forms.TextBox tb_Thang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BaoCaoTinhHinhMuonSachDTOBindingSource;
        private DevExpress.XtraEditors.SimpleButton btn_TaoBaoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Muon;
    }
}