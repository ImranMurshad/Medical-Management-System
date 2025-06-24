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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnHome.Height;
            panelMini.Top = btnHome.Top;
            dashboard1.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnStock.Height;
            panelMini.Top = btnStock.Top;
            stock1.BringToFront();
        }

        private void btnCustomerBook_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnCustomerBook.Height;
            panelMini.Top = btnCustomerBook.Top;
            customerBook1.BringToFront();
        }

        private void btnAgencyDetails_Click(object sender, EventArgs e)
        {
           // panelMini.Height = btnAgencyDetails.Height;
          //  panelMini.Top = btnAgencyDetails.Top;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnTransaction.Height;
            panelMini.Top = btnTransaction.Top;
            reportMaster1.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnAboutUs.Height;
            panelMini.Top = btnAboutUs.Top;
            aboutUs1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnLogout.Height;
            panelMini.Top = btnLogout.Top;
            MessageBox.Show("Logout!!!");
            this.Hide();
            LoginForm ob = new LoginForm();
            ob.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnBill.Height;
            panelMini.Top = btnBill.Top;
            bill1.BringToFront();
        }

        private void btnShopDetails_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnShopDetails.Height;
            panelMini.Top = btnShopDetails.Top;
            companyDetails1.BringToFront();
        }
    }
}
