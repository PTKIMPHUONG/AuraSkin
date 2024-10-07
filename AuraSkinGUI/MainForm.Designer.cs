namespace AuraSkinGUI
{
    partial class MainForm
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnInfoUser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.AutoSize = true;
            this.pnContent.BackColor = System.Drawing.Color.White;
            this.pnContent.Location = new System.Drawing.Point(263, 12);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1507, 1029);
            this.pnContent.TabIndex = 1;
            // 
            // pnInfoUser
            // 
            this.pnInfoUser.BackColor = System.Drawing.Color.White;
            this.pnInfoUser.Location = new System.Drawing.Point(12, 12);
            this.pnInfoUser.Name = "pnInfoUser";
            this.pnInfoUser.Size = new System.Drawing.Size(245, 103);
            this.pnInfoUser.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1782, 1053);
            this.Controls.Add(this.pnInfoUser);
            this.Controls.Add(this.pnContent);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnInfoUser;
    }
}