namespace Desktop.GUI
{
    partial class frmThemTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTacGia));
            this.groupControl_ThemTacGia = new DevExpress.XtraEditors.GroupControl();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_CNDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThemTacGia)).BeginInit();
            this.groupControl_ThemTacGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_ThemTacGia
            // 
            this.groupControl_ThemTacGia.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_ThemTacGia.Appearance.Options.UseFont = true;
            this.groupControl_ThemTacGia.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_ThemTacGia.AppearanceCaption.Options.UseFont = true;
            this.groupControl_ThemTacGia.AutoSize = true;
            this.groupControl_ThemTacGia.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_TTDG.CaptionImageOptions.Image")));
            this.groupControl_ThemTacGia.Controls.Add(this.dt_NgaySinh);
            this.groupControl_ThemTacGia.Controls.Add(this.label1);
            this.groupControl_ThemTacGia.Controls.Add(this.tb_TenTacGia);
            this.groupControl_ThemTacGia.Controls.Add(this.label2);
            this.groupControl_ThemTacGia.Controls.Add(this.bt_CNDL);
            this.groupControl_ThemTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_ThemTacGia.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl_ThemTacGia.Location = new System.Drawing.Point(0, 0);
            this.groupControl_ThemTacGia.Name = "groupControl_ThemTacGia";
            this.groupControl_ThemTacGia.Size = new System.Drawing.Size(550, 310);
            this.groupControl_ThemTacGia.TabIndex = 1;
            this.groupControl_ThemTacGia.Text = "Thông tin tác giả";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgaySinh.Location = new System.Drawing.Point(151, 142);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(340, 30);
            this.dt_NgaySinh.TabIndex = 22;
            this.dt_NgaySinh.ValueChanged += new System.EventHandler(this.dt_NgaySinh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày sinh:";
            // 
            // tb_TenTacGia
            // 
            this.tb_TenTacGia.Location = new System.Drawing.Point(151, 55);
            this.tb_TenTacGia.Name = "tb_TenTacGia";
            this.tb_TenTacGia.Size = new System.Drawing.Size(340, 30);
            this.tb_TenTacGia.TabIndex = 20;
            this.tb_TenTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TenTacGia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả:";
            // 
            // bt_CNDL
            // 
            this.bt_CNDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CNDL.Image = ((System.Drawing.Image)(resources.GetObject("bt_CNDL.Image")));
            this.bt_CNDL.Location = new System.Drawing.Point(198, 225);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(142, 42);
            this.bt_CNDL.TabIndex = 14;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            this.bt_CNDL.Click += new System.EventHandler(this.bt_CNDL_Click);
            // 
            // frmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 310);
            this.Controls.Add(this.groupControl_ThemTacGia);
            this.Name = "frmThemTacGia";
            this.Text = "frmThemTacGia";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThemTacGia)).EndInit();
            this.groupControl_ThemTacGia.ResumeLayout(false);
            this.groupControl_ThemTacGia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_ThemTacGia;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_CNDL;
    }
}