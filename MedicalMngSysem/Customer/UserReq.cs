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

namespace Genral_Software.Customer
{
    public partial class UserReq : UserControl
    {
        public UserReq()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            txtCustName.Text = "";
            txtmobno.Text = "";
            txtproname.Text = "";
            txtDescrip.Text = "";
            lblID.Text = "";
            cbapprove.Text = "";
            cbSearch.Text = "";
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Requirement where approve='No'", con);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Coustomer Name";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }
                if (txtmobno.Text == "")
                {
                    string msg1 = "Please Insert Mobile No.";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtmobno.Focus();
                    return;
                }
                if (txtDescrip.Text == "")
                {
                    string msg1 = "Please Insert Description";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtDescrip.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_Requirement values(@custname,@mobno,@product,@descrip,@date,@approve)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@custname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                cmd.Parameters.AddWithValue("@product", txtproname.Text);
                cmd.Parameters.AddWithValue("@descrip", txtDescrip.Text);

                cmd.Parameters.AddWithValue("@date", Calender.Text);
                cmd.Parameters.AddWithValue("@approve", "No");

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Inserted");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();
                lblaprrove.Visible = false;
                cbapprove.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtmobno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewAddProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblID.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustName.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            // txtqt.Text = DGAddtoCard.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtmobno.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtproname.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescrip.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            Calender.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblaprrove.Visible = true;
            cbapprove.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustName.Text == "")
                {
                    string msg1 = "Please Insert Coustomer Name";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCustName.Focus();
                    return;
                }
                if (txtmobno.Text == "")
                {
                    string msg1 = "Please Insert Mobile No.";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtmobno.Focus();
                    return;
                }
                if (txtDescrip.Text == "")
                {
                    string msg1 = "Please Insert Description";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtDescrip.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "update tbl_Requirement set custname=@custname,mobno=@mobno,product=@product,descrip=@descrip,date=@date,approve=@approve where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", lblID.Text);
                cmd.Parameters.AddWithValue("@custname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                cmd.Parameters.AddWithValue("@product", txtproname.Text);
                cmd.Parameters.AddWithValue("@descrip", txtDescrip.Text);

                cmd.Parameters.AddWithValue("@date", Calender.Text);
                cmd.Parameters.AddWithValue("@approve", cbapprove.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Updated");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();
                lblaprrove.Visible = false;
                cbapprove.Visible = false;

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
                    string msg1 = "Please Select Data from table";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);

                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete tbl_Requirement where uid=@uid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@uid", lblID.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Deleted");
                ClearData();
                LoadData();
                dataGridViewAddProduct.Update();
                dataGridViewAddProduct.Refresh();
                lblaprrove.Visible = false;
                cbapprove.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSearch.Text == "")
                {
                    string msg1 = "Please Insert Customer Name";
                    string msg2 = "User Requirement";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    cbSearch.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Requirement where custname='" + cbSearch.Text + "' and approve='No'", con);
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
            lblaprrove.Visible = false;
            cbapprove.Visible = false;
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearData();
            lblaprrove.Visible = false;
            cbapprove.Visible = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Requirement where approve='No'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
                lblaprrove.Visible = false;
                cbapprove.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                SqlCommand cmd = new SqlCommand("select * from tbl_Requirement where approve='No' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbSearch.Items.Add(dr["custname"].ToString());
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

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
