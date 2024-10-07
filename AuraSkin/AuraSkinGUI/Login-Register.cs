using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuraSkinGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inits();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void inits()
        {
            loginForm.Visible = true;
            registerForm.Visible = false;
            loginForm.SubmitClicked += LoginForm_SubmitClicked;
            loginForm.DangKyClicked += LoginForm_DangKyClicked;
            registerForm.SubmitClicked += RegisterForm_SubmitClicked;
            registerForm.DangNhapClicked += RegisterForm_DangNhapClicked;
        }

        private void RegisterForm_DangNhapClicked(object sender, EventArgs e)
        {
            loginForm.Visible = true;
            registerForm.Visible = false;
        }

        private void RegisterForm_SubmitClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoginForm_DangKyClicked(object sender, EventArgs e)
        {
            registerForm.Visible = true;
            loginForm.Visible=false;
        }

        private void LoginForm_SubmitClicked(object sender, EventArgs e)
        {
            if(loginForm.UserName=="123"&&loginForm.Password=="123")
            {
                this.Hide();
                MainForm main=new MainForm();
                main.Username=loginForm.UserName;
                main.ShowDialog();
                this.Close();
            }    
        }
    }
}
