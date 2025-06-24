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
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            lblID.Text = "";
            txtSrNo.Text = "";
            txtCode.Text = "";
            txtMName.Text = "";
            txtRate.Text = "";
            txtqty.Text = "";
            txtLockerNo.Text = "";
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Stock ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                dataGridView1.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "insert into tbl_Stock values(@srno,@code,@mname,@indate,@exdate,@rate,@qty,@lockno)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@srno", txtSrNo.Text);
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@mname", txtMName.Text);
                cmd.Parameters.AddWithValue("@indate", dateTimePickerInDate.Text);
                cmd.Parameters.AddWithValue("@exdate", dateTimePickerEDate.Text);
                cmd.Parameters.AddWithValue("@rate", txtRate.Text);
                cmd.Parameters.AddWithValue("@qty", txtqty.Text);
                cmd.Parameters.AddWithValue("@lockno", txtLockerNo.Text);


                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Inserted");
                ClearData();
                LoadData();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "")
                {
                    MessageBox.Show("Select Medicen or data in table");
                 //   txtQuntity.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "update tbl_Stock set srno=@srno,code=@code,mname=@mname,indate=@indate,exdate=@exdate,rate=@rate,qty=@qty,lockno=@lockno where ID='"+lblID.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@srno", txtSrNo.Text);
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@mname", txtMName.Text);
                cmd.Parameters.AddWithValue("@indate", dateTimePickerInDate.Text);
                cmd.Parameters.AddWithValue("@exdate", dateTimePickerEDate.Text);
                cmd.Parameters.AddWithValue("@rate", txtRate.Text);
                cmd.Parameters.AddWithValue("@qty", txtqty.Text);
                cmd.Parameters.AddWithValue("@lockno", txtLockerNo.Text);


                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Updated");
                ClearData();
                LoadData();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    lblID.Text = row.Cells[0].Value.ToString();
                    txtSrNo.Text = row.Cells[1].Value.ToString();
                    txtCode.Text = row.Cells[2].Value.ToString();
                    txtMName.Text = row.Cells[3].Value.ToString();
                    dateTimePickerInDate.Text = row.Cells[4].Value.ToString();
                    dateTimePickerEDate.Text = row.Cells[5].Value.ToString();
                    txtRate.Text = row.Cells[6].Value.ToString();
                    txtqty.Text = row.Cells[7].Value.ToString();
                    txtLockerNo.Text = row.Cells[8].Value.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "")
                {
                    MessageBox.Show("Select Medicen or data in table");
                    //   txtQuntity.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "delete from tbl_Stock where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", lblID.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Deleted");
                LoadData();
                ClearData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchType.Text == "Sr no.")
            {
                try
                {
                    cbSearchData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select srno from tbl_Stock", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbSearchData.Items.Add(dr[0].ToString());
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

            if (cbSearchType.Text == "Code")
            {
                try
                {
                    cbSearchData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select code from tbl_Stock", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbSearchData.Items.Add(dr[0].ToString());
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

            if (cbSearchType.Text == "Medicine Name")
            {
                try
                {
                    cbSearchData.Items.Clear();
                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    //DataTable donater = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select mname from tbl_Stock", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbSearchData.Items.Add(dr[0].ToString());
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchType.Text == "Sr no.")
            {
                try
                {
                    if (cbSearchData.Text == "")
                    {
                        string msg1 = "Data is not Present";
                        string msg2 = "Add Product";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        cbSearchData.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Stock where srno='" + cbSearchData.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    dataGridView1.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (cbSearchType.Text == "Code")
            {
                try
                {
                    if (cbSearchData.Text == "")
                    {
                        string msg1 = "Data is not Present";
                        string msg2 = "Add Product";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        cbSearchData.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Stock where code='" + cbSearchData.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    dataGridView1.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (cbSearchType.Text == "Medicine Name")
            {
                try
                {
                    if (cbSearchData.Text == "")
                    {
                        string msg1 = "Data is not Present";
                        string msg2 = "Add Product";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        cbSearchData.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Stock where mname='" + cbSearchData.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    dataGridView1.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }   
    }
}
