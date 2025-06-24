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
using MedicalMngSysem.Report;

namespace ElectronicShop.Report
{
    public partial class ReportMaster : UserControl
    {
        public ReportMaster()
        {
            InitializeComponent();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchType.Text == "Bill No.")
            {
                lblDate.Visible = false;
                lblto.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

                try
                {
                    cbSearchData.Text = "";
                    cbSearchData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select bno from tbl_BillData ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //lblpid.Text = dr["ID"].ToString();
                    while (dr.Read())
                    {
                        cbSearchData.Items.Add(dr["bno"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            if (cbSearchType.Text == "Customer Name")
            {
                lblDate.Visible = false;
                lblto.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

                try
                {
                    cbSearchData.Text = "";
                    cbSearchData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select cname from tbl_BillData ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //lblpid.Text = dr["ID"].ToString();
                    while (dr.Read())
                    {
                        cbSearchData.Items.Add(dr["cname"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            if (cbSearchType.Text == "Mobile No.")
            {
                lblDate.Visible = false;
                lblto.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

                try
                {
                    cbSearchData.Text = "";
                    cbSearchData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select mobno from tbl_BillData ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //lblpid.Text = dr["ID"].ToString();
                    while (dr.Read())
                    {
                        cbSearchData.Items.Add(dr["mobno"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            if (cbSearchType.Text == "Date Vise")
            {
                lblDate.Visible = true;
                lblto.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchType.Text == "Bill No.")
            {
                try
                {
                    if (cbSearchData.Text == "")
                    {
                        string msg1 = "Please select Bill ID";
                        string msg2 = "Bill Master";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        cbSearchData.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_BillData where bno='" + cbSearchData.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewAddProduct.DataSource = dt;
                    con.Close();
                    dataGridViewAddProduct.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);

                    con.Open();
                    string sql = "select count(*) from tbl_BillData where bno='" + cbSearchData.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int cnt = (int)cmd.ExecuteScalar();
                    lblcnt.Text = cnt.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (cbSearchType.Text == "Customer Name")
            {
                try
                {
                    if (cbSearchData.Text == "")
                    {
                        string msg1 = "Please select Customer Name";
                        string msg2 = "Bill Master";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        cbSearchData.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_BillData where cname='" + cbSearchData.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewAddProduct.DataSource = dt;
                    con.Close();
                    dataGridViewAddProduct.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);

                    con.Open();
                    string sql = "select count(*) from tbl_BillData where cname='" + cbSearchData.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int cnt = (int)cmd.ExecuteScalar();
                    lblcnt.Text = cnt.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


            if (cbSearchType.Text == "Mobile No.")
            {
                try
                {
                    if (cbSearchData.Text == "")
                    {
                        string msg1 = "Please select Customer Name";
                        string msg2 = "Bill Master";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        cbSearchData.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_BillData where mobno='" + cbSearchData.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewAddProduct.DataSource = dt;
                    con.Close();
                    dataGridViewAddProduct.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);

                    con.Open();
                    string sql = "select count(*) from tbl_BillData where mobno='" + cbSearchData.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int cnt = (int)cmd.ExecuteScalar();
                    lblcnt.Text = cnt.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (cbSearchType.Text == "Date Vise")
            {
                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_BillData where date between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewAddProduct.DataSource = dt;
                    con.Close();
                    dataGridViewAddProduct.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);

                    con.Open();
                    string sql = "select count(*) from tbl_BillData where date between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int cnt = (int)cmd.ExecuteScalar();
                    lblcnt.Text = cnt.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_BillData", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                string sql = "select count(*) from tbl_BillData";
                SqlCommand cmd = new SqlCommand(sql, con);
                int cnt = (int)cmd.ExecuteScalar();
                lblcnt.Text = cnt.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static int bid;

        private void dataGridViewAddProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblBID.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells["bno"].Value.ToString();
            btnPrint.Enabled = true;
            //btnPrintFullPage.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lblBID.Text == "")
            {
                string msg1 = "Please select Data";
                string msg2 = "Bill Master";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                //cbSearchData.Focus();
                btnPrint.Enabled = false;
                return;
            }
            else
            {
                bid = Convert.ToInt32(lblBID.Text);
                BillPrint ob = new BillPrint();
                ob.Show();
            }
        }

        private void btnPrintFullPage_Click(object sender, EventArgs e)
        {
            if (lblBID.Text == "")
            {
                string msg1 = "Please select Data";
                string msg2 = "Bill Master";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                //cbSearchData.Focus();
                btnPrint.Enabled = false;
                return;
            }
            else
            {
                bid = Convert.ToInt32(lblBID.Text);
              // PrintFullPageWindow  ob = new PrintFullPageWindow();
               // ob.Show();
            }
        }
    }
}
