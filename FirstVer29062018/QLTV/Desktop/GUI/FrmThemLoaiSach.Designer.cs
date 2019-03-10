namespace Desktop.GUI
{
    partial class FrmThemLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemLoaiSach));
            this.groupControl_ThemTheLoai = new DevExpress.XtraEditors.GroupControl();
            this.tb_ThemTheLoaiSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_CNDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThemTheLoai)).BeginInit();
            this.groupControl_ThemTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_ThemTheLoai
            // 
            this.groupControl_ThemTheLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_ThemTheLoai.Appearance.Options.UseFont = true;
            this.groupControl_ThemTheLoai.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_ThemTheLoai.AppearanceCaption.Options.UseFont = true;
            this.groupControl_ThemTheLoai.AutoSize = true;
            this.groupControl_ThemTheLoai.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_ThemTheLoai.CaptionImageOptions.Image")));
            this.groupControl_ThemTheLoai.Controls.Add(this.tb_ThemTheLoaiSach);
            this.groupControl_ThemTheLoai.Controls.Add(this.label2);
            this.groupControl_ThemTheLoai.Controls.Add(this.bt_CNDL);
            this.groupControl_ThemTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_ThemTheLoai.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl_ThemTheLoai.Location = new System.Drawing.Point(0, 0);
            this.groupControl_ThemTheLoai.Name = "groupControl_ThemTheLoai";
            this.groupControl_ThemTheLoai.Size = new System.Drawing.Size(434, 196);
            this.groupControl_ThemTheLoai.TabIndex = 1;
            this.groupControl_ThemTheLoai.Text = "Thông tin thể loại";
            // 
            // tb_ThemTheLoaiSach
            // 
            this.tb_ThemTheLoaiSach.Location = new System.Drawing.Point(136, 81);
            this.tb_ThemTheLoaiSach.Name = "tb_ThemTheLoaiSach";
            this.tb_ThemTheLoaiSach.Size = new System.Drawing.Size(248, 30);
            this.tb_ThemTheLoaiSach.TabIndex = 15;
            this.tb_ThemTheLoaiSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ThemTheLoaiSach_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại sách:";
            // 
            // bt_CNDL
            // 
            this.bt_CNDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CNDL.Image = ((System.Drawing.Image)(resources.GetObject("bt_CNDL.Image")));
            this.bt_CNDL.Location = new System.Drawing.Point(155, 133);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(142, 42);
            this.bt_CNDL.TabIndex = 14;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            this.bt_CNDL.Click += new System.EventHandler(this.bt_CNDL_Click);
            // 
            // FrmThemLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 196);
            this.Controls.Add(this.groupControl_ThemTheLoai);
            this.Name = "FrmThemLoaiSach";
            this.Text = "FrmThemLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThemTheLoai)).EndInit();
            this.groupControl_ThemTheLoai.ResumeLayout(false);
            this.groupControl_ThemTheLoai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_ThemTheLoai;
        private System.Windows.Forms.TextBox tb_ThemTheLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_CNDL;
    }
}