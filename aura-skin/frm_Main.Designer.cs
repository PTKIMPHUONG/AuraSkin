namespace aura_skin
{
    partial class frm_Main
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
            this.btn_Exit = new System.Windows.Forms.Label();
            this.wizardControl1 = new Syncfusion.Windows.Forms.Tools.WizardControl();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_sidebar = new GradientPanelRadiusControl.GradientRadiusPanel();
            this.pnl_UserInfo = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.pnl_main = new GradientPanelRadiusControl.GradientRadiusPanel();
            this.btn_Minize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1.GridBagLayout)).BeginInit();
            this.wizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_sidebar)).BeginInit();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_UserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_main)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(1135, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(40, 45);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "X";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // wizardControl1
            // 
            // 
            // 
            // 
            this.wizardControl1.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.BackButton.Location = new System.Drawing.Point(333, 468);
            this.wizardControl1.BackButton.Name = "backButton";
            this.wizardControl1.BackButton.Text = "<< Back";
            this.wizardControl1.Banner = null;
            this.wizardControl1.BannerPanel = this.gradientPanel1;
            // 
            // 
            // 
            this.wizardControl1.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.CancelButton.Location = new System.Drawing.Point(253, 468);
            this.wizardControl1.CancelButton.Name = "cancelButton";
            this.wizardControl1.CancelButton.Text = "Cancel";
            this.wizardControl1.Controls.Add(this.wizardContainer1);
            this.wizardControl1.Controls.Add(this.gradientPanel1);
            this.wizardControl1.Description = null;
            // 
            // 
            // 
            this.wizardControl1.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.FinishButton.Location = new System.Drawing.Point(488, 468);
            this.wizardControl1.FinishButton.Name = "finishButton";
            this.wizardControl1.FinishButton.Text = "Finish";
            // 
            // 
            // 
            this.wizardControl1.GridBagLayout.ContainerControl = this.wizardControl1;
            // 
            // 
            // 
            this.wizardControl1.HelpButton.Location = new System.Drawing.Point(568, 468);
            this.wizardControl1.HelpButton.Name = "helpButton";
            this.wizardControl1.HelpButton.Text = "Help";
            this.wizardControl1.Location = new System.Drawing.Point(230, 428);
            this.wizardControl1.Name = "wizardControl1";
            // 
            // 
            // 
            this.wizardControl1.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.NextButton.Location = new System.Drawing.Point(408, 468);
            this.wizardControl1.NextButton.Name = "nextButton";
            this.wizardControl1.NextButton.Text = "Next >>";
            this.wizardControl1.SelectedWizardPage = null;
            this.wizardControl1.Size = new System.Drawing.Size(648, 496);
            this.wizardControl1.TabIndex = 4;
            this.wizardControl1.Title = null;
            this.wizardControl1.WizardPageContainer = this.wizardContainer1;
            this.wizardControl1.WizardPages = new Syncfusion.Windows.Forms.Tools.WizardControlPage[0];
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(648, 70);
            this.gradientPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.Location = new System.Drawing.Point(0, 70);
            this.wizardContainer1.Name = "wizardContainer1";
            this.wizardContainer1.Size = new System.Drawing.Size(648, 385);
            this.wizardContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(427, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is the title of the Wizard Page.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "This is the description of the Wizard Page.";
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_sidebar.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.PowderBlue);
            this.pnl_sidebar.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.pnl_sidebar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_sidebar.Controls.Add(this.pnl_UserInfo);
            this.pnl_sidebar.Location = new System.Drawing.Point(5, 5);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Radius = 20;
            this.pnl_sidebar.Size = new System.Drawing.Size(339, 854);
            this.pnl_sidebar.TabIndex = 4;
            // 
            // pnl_UserInfo
            // 
            this.pnl_UserInfo.AutoSize = true;
            this.pnl_UserInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_UserInfo.Border = new System.Windows.Forms.Padding(12);
            this.pnl_UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_UserInfo.CornerRadius = 10;
            this.pnl_UserInfo.Location = new System.Drawing.Point(-3, 0);
            this.pnl_UserInfo.Name = "pnl_UserInfo";
            this.pnl_UserInfo.Size = new System.Drawing.Size(342, 120);
            this.pnl_UserInfo.TabIndex = 0;
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Gainsboro, System.Drawing.Color.MistyRose);
            this.pnl_main.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_main.Controls.Add(this.btn_Minize);
            this.pnl_main.Controls.Add(this.btn_Exit);
            this.pnl_main.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_main.Location = new System.Drawing.Point(350, 5);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Radius = 15;
            this.pnl_main.Size = new System.Drawing.Size(1181, 854);
            this.pnl_main.TabIndex = 6;
            // 
            // btn_Minize
            // 
            this.btn_Minize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minize.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Minize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Minize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Minize.Location = new System.Drawing.Point(1089, -14);
            this.btn_Minize.Name = "btn_Minize";
            this.btn_Minize.Size = new System.Drawing.Size(40, 59);
            this.btn_Minize.TabIndex = 5;
            this.btn_Minize.Text = "-";
            this.btn_Minize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Minize.Click += new System.EventHandler(this.lblMinize_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_main);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GradientColor1 = System.Drawing.Color.White;
            this.GradientColor2 = System.Drawing.Color.White;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1.GridBagLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_sidebar)).EndInit();
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_UserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_main)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btn_Exit;
        private Syncfusion.Windows.Forms.Tools.WizardControl wizardControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GradientPanelRadiusControl.GradientRadiusPanel pnl_sidebar;
        private GradientPanelRadiusControl.GradientRadiusPanel pnl_main;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt pnl_UserInfo;
        private System.Windows.Forms.Label btn_Minize;
    }
}