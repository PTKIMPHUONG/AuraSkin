namespace aura_skin
{
    partial class frm_QuenMatKhau
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
            this.quenMatKhauPanel1 = new QuenMatKhauControl.QuenMatKhauPanel();
            this.SuspendLayout();
            // 
            // quenMatKhauPanel1
            // 
            this.quenMatKhauPanel1.Location = new System.Drawing.Point(12, 12);
            this.quenMatKhauPanel1.Name = "quenMatKhauPanel1";
            this.quenMatKhauPanel1.Size = new System.Drawing.Size(638, 326);
            this.quenMatKhauPanel1.TabIndex = 0;
            // 
            // frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 350);
            this.Controls.Add(this.quenMatKhauPanel1);
            this.Name = "frm_QuenMatKhau";
            this.Text = "frm_QuenMatKhau";
            this.ResumeLayout(false);

        }

        #endregion

        private QuenMatKhauControl.QuenMatKhauPanel quenMatKhauPanel1;
    }
}