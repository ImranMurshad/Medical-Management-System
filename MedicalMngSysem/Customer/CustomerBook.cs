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
    public partial class CustomerBook : UserControl
    {
        public CustomerBook()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            lblID.Text = "";
            txtCustName.Text = "";
            txtAddress.Text = "";
            txtmobno.Text = "";
            //txtRequirement.Text = "";
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Customer ", con);
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
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }

                if (txtmobno.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtmobno.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "insert into tbl_Customer values(@name,@address,@mobno)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtCustName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Customer Required is Added");
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
                    string msg1 = "Data is Not Present";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    //txtCustName.Focus();
                    return;
                }
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }

                if (txtmobno.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtmobno.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "update tbl_Customer set name=@name,address=@address,mobno=@mobno where ID='"+lblID.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtCustName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Customer Required is Updated");
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
                    txtCustName.Text = row.Cells[1].Value.ToString();
                    txtAddress.Text = row.Cells[2].Value.ToString();
                    txtmobno.Text = row.Cells[3].Value.ToString();               

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
                string sql = "delete from tbl_Customer where ID=@ID";
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

        private void btnCustRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cbSearch.Items.Clear();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_Customer ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbSearch.Items.Add(dr["name"].ToString());
                    //custid = dr["ID"].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Customer where name='" + cbSearch.Text + "'", con);
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

        private void btnUserReq_Click(object sender, EventArgs e)
        {
            Customer.UserReqWindow obj = new Customer.UserReqWindow();
            obj.Show();
        }

    }
}
