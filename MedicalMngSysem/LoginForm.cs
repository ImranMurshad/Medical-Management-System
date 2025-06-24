using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalMngSysem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "Admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Log In Done Succesfully!!!");
                this.Hide();
                MainForm ob = new MainForm();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Check user and Password");
                txtUname.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
