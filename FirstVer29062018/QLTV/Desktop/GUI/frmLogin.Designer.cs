namespace Desktop.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_passwork = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_user.Font = new System.Drawing.Font("Candara", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_user.Location = new System.Drawing.Point(38, 142);
            this.tb_user.Multiline = true;
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(452, 68);
            this.tb_user.TabIndex = 0;
            this.tb_user.Text = "Username";
            this.tb_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_user_MouseClick);
            // 
            // tb_passwork
            // 
            this.tb_passwork.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_passwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passwork.Font = new System.Drawing.Font("Candara", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwork.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_passwork.Location = new System.Drawing.Point(38, 258);
            this.tb_passwork.Multiline = true;
            this.tb_passwork.Name = "tb_passwork";
            this.tb_passwork.Size = new System.Drawing.Size(452, 64);
            this.tb_passwork.TabIndex = 1;
            this.tb_passwork.Text = "Passwork";
            this.tb_passwork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_passwork_MouseClick);
            this.tb_passwork.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_passwork_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Location = new System.Drawing.Point(28, 358);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(149, 66);
            this.btn_login.TabIndex = 3;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 472);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_passwork);
            this.Controls.Add(this.tb_user);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.Tag = "";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_passwork;
        private System.Windows.Forms.Button btn_login;
    }
}