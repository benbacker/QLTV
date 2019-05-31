namespace Desktop.GUI
{
    partial class frmPasssWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasssWork));
            this.label1 = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_CNDL = new System.Windows.Forms.Button();
            this.TickYes = new System.Windows.Forms.PictureBox();
            this.tbPassWork = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.Tick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TickYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tài khoản:";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lbTaiKhoan.Location = new System.Drawing.Point(332, 49);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(125, 29);
            this.lbTaiKhoan.TabIndex = 18;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu củ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(38, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(38, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // bt_CNDL
            // 
            this.bt_CNDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CNDL.Image = ((System.Drawing.Image)(resources.GetObject("bt_CNDL.Image")));
            this.bt_CNDL.Location = new System.Drawing.Point(178, 270);
            this.bt_CNDL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(195, 52);
            this.bt_CNDL.TabIndex = 32;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            this.bt_CNDL.Click += new System.EventHandler(this.bt_CNDL_Click);
            // 
            // TickYes
            // 
            this.TickYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TickYes.Image = ((System.Drawing.Image)(resources.GetObject("TickYes.Image")));
            this.TickYes.Location = new System.Drawing.Point(533, 216);
            this.TickYes.Name = "TickYes";
            this.TickYes.Size = new System.Drawing.Size(36, 36);
            this.TickYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TickYes.TabIndex = 26;
            this.TickYes.TabStop = false;
            // 
            // tbPassWork
            // 
            this.tbPassWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassWork.Location = new System.Drawing.Point(280, 158);
            this.tbPassWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassWork.Name = "tbPassWork";
            this.tbPassWork.Size = new System.Drawing.Size(247, 34);
            this.tbPassWork.TabIndex = 30;
            this.tbPassWork.UseSystemPasswordChar = true;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(280, 100);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(247, 34);
            this.tbPass.TabIndex = 29;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPwd.Location = new System.Drawing.Point(280, 216);
            this.tbNewPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.Size = new System.Drawing.Size(247, 34);
            this.tbNewPwd.TabIndex = 31;
            this.tbNewPwd.UseSystemPasswordChar = true;
            this.tbNewPwd.TextChanged += new System.EventHandler(this.tbNewPwd_TextChanged);
            // 
            // Tick
            // 
            this.Tick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Tick.Image = ((System.Drawing.Image)(resources.GetObject("Tick.Image")));
            this.Tick.Location = new System.Drawing.Point(533, 100);
            this.Tick.Name = "Tick";
            this.Tick.Size = new System.Drawing.Size(36, 36);
            this.Tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tick.TabIndex = 33;
            this.Tick.TabStop = false;
            // 
            // frmPasssWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 347);
            this.Controls.Add(this.Tick);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbPassWork);
            this.Controls.Add(this.TickYes);
            this.Controls.Add(this.bt_CNDL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasssWork";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frmPasssWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TickYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_CNDL;
        private System.Windows.Forms.PictureBox TickYes;
        private System.Windows.Forms.TextBox tbPassWork;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.PictureBox Tick;
    }
}