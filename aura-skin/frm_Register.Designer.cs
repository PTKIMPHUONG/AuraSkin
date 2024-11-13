namespace aura_skin
{
    partial class frm_Register
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
            this.btn_Exit = new System.Windows.Forms.Label();
            this.chk_HienThiPass = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lbl_DangKyForm = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btn_DangNhap = new GradientButtonRadiusControl.GradientRadiusButton();
            this.txt_password = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txt_tenDangNhap = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_Logo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txt_email = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chk_HienThiPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Exit.Location = new System.Drawing.Point(499, 21);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 29);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // chk_HienThiPass
            // 
            this.chk_HienThiPass.AccessibilityEnabled = true;
            this.chk_HienThiPass.AutoSize = true;
            this.chk_HienThiPass.BeforeTouchSize = new System.Drawing.Size(172, 26);
            this.chk_HienThiPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_HienThiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chk_HienThiPass.ForeColor = System.Drawing.Color.White;
            this.chk_HienThiPass.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.chk_HienThiPass.Location = new System.Drawing.Point(277, 506);
            this.chk_HienThiPass.Name = "chk_HienThiPass";
            this.chk_HienThiPass.Size = new System.Drawing.Size(172, 26);
            this.chk_HienThiPass.TabIndex = 17;
            this.chk_HienThiPass.Text = "Hiển thị mật khẩu";
            this.chk_HienThiPass.CheckStateChanged += new System.EventHandler(this.chk_HienThiPass_CheckStateChanged);
            // 
            // lbl_DangKyForm
            // 
            this.lbl_DangKyForm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DangKyForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_DangKyForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_DangKyForm.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_DangKyForm.Location = new System.Drawing.Point(176, 704);
            this.lbl_DangKyForm.Name = "lbl_DangKyForm";
            this.lbl_DangKyForm.Size = new System.Drawing.Size(180, 20);
            this.lbl_DangKyForm.TabIndex = 16;
            this.lbl_DangKyForm.Text = "Đăng nhập tài khoản";
            this.lbl_DangKyForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DangKyForm.Click += new System.EventHandler(this.lbl_DangKyForm_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BorderColor = System.Drawing.Color.MediumBlue;
            this.btn_DangNhap.CornerRadius = 10;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.GradientColor1 = System.Drawing.Color.DarkCyan;
            this.btn_DangNhap.GradientColor2 = System.Drawing.Color.RoyalBlue;
            this.btn_DangNhap.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_DangNhap.Location = new System.Drawing.Point(158, 584);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(250, 55);
            this.btn_DangNhap.Style.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.TabIndex = 15;
            this.btn_DangNhap.Text = "Đăng Ký";
            // 
            // txt_password
            // 
            this.txt_password.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_password.Location = new System.Drawing.Point(92, 439);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(371, 28);
            this.txt_password.TabIndex = 14;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_tenDangNhap.Location = new System.Drawing.Point(92, 188);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(371, 28);
            this.txt_tenDangNhap.TabIndex = 13;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_MatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_MatKhau.Location = new System.Drawing.Point(87, 398);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(101, 26);
            this.lbl_MatKhau.TabIndex = 12;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_TenDangNhap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(87, 148);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(156, 26);
            this.lbl_TenDangNhap.TabIndex = 11;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Logo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Logo.Location = new System.Drawing.Point(158, 35);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(215, 58);
            this.lbl_Logo.TabIndex = 10;
            this.lbl_Logo.Text = "Đăng ký";
            // 
            // txt_email
            // 
            this.txt_email.BeforeTouchSize = new System.Drawing.Size(371, 28);
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_email.Location = new System.Drawing.Point(92, 312);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(371, 28);
            this.txt_email.TabIndex = 19;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_email.Location = new System.Drawing.Point(87, 272);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(68, 26);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email";
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 750);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.chk_HienThiPass);
            this.Controls.Add(this.lbl_DangKyForm);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.lbl_Logo);
            this.Controls.Add(this.btn_Exit);
            this.GradientColor1 = System.Drawing.Color.MediumSlateBlue;
            this.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(77)))), ((int)(((byte)(155)))));
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Register";
            ((System.ComponentModel.ISupportInitialize)(this.chk_HienThiPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_Exit;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chk_HienThiPass;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbl_DangKyForm;
        private GradientButtonRadiusControl.GradientRadiusButton btn_DangNhap;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_password;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_tenDangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbl_Logo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_email;
        private System.Windows.Forms.Label lbl_email;
    }
}