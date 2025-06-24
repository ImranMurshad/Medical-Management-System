using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MedicalMngSysem
{
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        int bid = Bill.bid;
        private void PrintBill_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Sale_Product where bid='" + bid + "'", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                DataTable dt1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select * from Sale where ID='" + bid + "'", con);
                //SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='15'", con);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt1);

                DataTable dt2 = new DataTable();
                SqlCommand cmd2 = new SqlCommand("select * from tbl_CompanyDetails", con);
                //SqlCommand cmd1 = new SqlCommand("select * from Sale_Product where saleid='15'", con);
                dr = new SqlDataAdapter(cmd2);
                dr.Fill(dt2);


               Report.Bill cr = new Report.Bill();
                cr.Database.Tables["Sale_Product"].SetDataSource(dt);
                cr.Database.Tables["Sale"].SetDataSource(dt1);
                cr.Database.Tables["tbl_CompanyDetails"].SetDataSource(dt2);

                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
