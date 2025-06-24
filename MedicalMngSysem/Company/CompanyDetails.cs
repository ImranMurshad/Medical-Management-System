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

namespace Genral_Software
{
    public partial class CompanyDetails : UserControl
    {
        public CompanyDetails()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            txtCName.Text = "";
            txtAddress.Text = "";
            txtmobno.Text = "";
            txtBCode.Text = "";
            txtBname.Text = "";
            txtbno.Text = "";
            txtEmail.Text = "";
            txtgstno.Text = "";
            lblID.Text = "";
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_CompanyDetails ", con);
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
        }
        int cnt = 0;
        public void CheckData()
        {
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection con = new SqlConnection(constring);
            //DataTable donater = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_CompanyDetails ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ++cnt;              
            }
            con.Close();
        }
        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            CheckData();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckData();
            if (dataGridViewAddProduct.Rows != null && dataGridViewAddProduct.Rows.Count == 0)
            {
                string msg1 = "Please Click on Show all Data Button";
                string msg2 = "Company Details Master";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                //txtCName.Focus();
                return;
            }
            if(cnt>1)
            {
                string msg1 = "Company Details is All ready added\n If you want to add new Company or update company data ";
                string msg2 = "Company Details Master";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                //txtCName.Focus();
                return;
            }
            
            try
            {
                if (txtCName.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCName.Focus();
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

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_CompanyDetails values(@cname,@address,@mobno,@gstno,@bname,@bno,@bcode,@email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cname", txtCName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                cmd.Parameters.AddWithValue("@gstno", txtgstno.Text);
                cmd.Parameters.AddWithValue("@bname", txtBname.Text);
                cmd.Parameters.AddWithValue("@bno", txtbno.Text);
                cmd.Parameters.AddWithValue("@bcode", txtBCode.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Company Details Added Successfuly !!!");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cnt = 1;
        }

        private void dataGridViewAddProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblID.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCName.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmobno.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtgstno.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBname.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbno.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBCode.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtEmail.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (lblID.Text == "")
                {
                    string msg1 = "Data is not Present";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    //txtName.Focus();
                    return;
                }
                if (txtCName.Text == "")
                {
                    string msg1 = "Please Insert Empty Filed";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCName.Focus();
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

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "update tbl_CompanyDetails set cname=@cname,address=@address,mobno=@mobno,gstno=@gstno,bname=@bname,bno=@bno,bcode=@bcode,email=@email where ID='" + lblID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cname", txtCName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                cmd.Parameters.AddWithValue("@gstno", txtgstno.Text);
                cmd.Parameters.AddWithValue("@bname", txtBname.Text);
                cmd.Parameters.AddWithValue("@bno", txtbno.Text);
                cmd.Parameters.AddWithValue("@bcode", txtBCode.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Company Details Updated Successfuly !!!");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cnt = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "")
                {
                    string msg1 = "Data is Not Present";
                    string msg2 = "Customer Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    //txtIname.Focus();
                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete tbl_CompanyDetails where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", lblID.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Company Details Deleted");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cnt = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
