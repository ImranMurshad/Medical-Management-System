using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MedicalMngSysem
{
    public partial class Trancation : UserControl
    {
        public Trancation()
        {
            InitializeComponent();
        }

        private void btnAddtoCard_Click(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.Visible = true;
                //DataGridViewDataCustomer.Visible = false;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Sale_Product", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);



                TransactionReport cr = new TransactionReport();
                cr.Database.Tables["Sale_Product"].SetDataSource(dt);

                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
