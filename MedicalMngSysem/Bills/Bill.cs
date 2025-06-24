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
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
        }
        public void ClearAllData()
        {
            clearDataOfAddToCard();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            cbCustName.Text = "";
            txtAddress.Text = "";
            txtmobno.Text = "";
           
            txtSubTotal.Text = "0";
            txtDiscount.Text = "0";
            txtFinalTotal.Text = "0";
        }
        public void clearDataOfAddToCard()
        {
            dataGridView1.Refresh();
            cbPData.Text = "";
            lblsrno.Text = "";
            lblexdate.Text = "";
            lblrate.Text = "";
            txtqty.Text = "";
            lblAstock.Text = "";
           // txtTotal.Text = "";

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection con = new SqlConnection(constring);
            //DataTable donater = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Stock where mname='" + cbPData.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblsrno.Text = dr["srno"].ToString();
                lblexdate.Text = dr["exdate"].ToString();
                lblrate.Text = dr["rate"].ToString();
                lblAstock.Text=dr["qty"].ToString();
                lblpid.Text=dr["ID"].ToString();

            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            
        }
        int cnt = 0;
        private void btnAddtoCard_Click(object sender, EventArgs e)
        {
            if (cbPData.Text == "")
            {
                string msg1 = "Please Select Product";
                string msg2 = "Product Data";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                cbPData.Focus();
                return;
            }
            if (txtqty.Text == "")
            {
                string msg1 = "Please Insert Quntity";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtqty.Focus();
                return;
            }
            double aqty = 0, qty1 = 0;
            aqty = Convert.ToDouble(lblAstock.Text);
            qty1 = Convert.ToDouble(txtqty.Text);
            if (aqty < qty1)
            {
                string msg1 = "Stock is Not Available!!! \nPlease Insert Valid Qty";
                string msg2 = "Product Data";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtqty.Focus();
                return;
            }   
            cnt++;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = cnt.ToString();
            dataGridView1.Rows[n].Cells[1].Value = cbPData.Text;
            dataGridView1.Rows[n].Cells[2].Value = lblsrno.Text;
            dataGridView1.Rows[n].Cells[3].Value = lblrate.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtqty.Text;
           // dataGridView1.Rows[n].Cells[5].Value = txtRate.Text;
           double  rate = double.Parse(lblrate.Text);
          double  qty = double.Parse(txtqty.Text);
           double temp = qty * rate;

            dataGridView1.Rows[n].Cells[5].Value = temp.ToString();
          double  total = double.Parse(txtSubTotal.Text);

            total = total + temp;
            txtSubTotal.Text = total.ToString();
            try
            {
                int q1, q2, q3;
                q1 = Convert.ToInt32(lblAstock.Text);
                q2 = Convert.ToInt32(txtqty.Text);
                q3 = q1 - q2;

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string sql1 = "update tbl_Stock set qty=@qty where ID=@ID";
                SqlCommand cmd2 = new SqlCommand(sql1, con);
                cmd2.Parameters.AddWithValue("@ID", lblpid.Text);
                cmd2.Parameters.AddWithValue("@qty", q3);
                //aqt = q3;
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            clearDataOfAddToCard();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbPData.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblsrno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblrate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtRate.Text = dataGridViewAddToCard.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private int rowIndex = 0;
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                this.dataGridView1.Rows[e.RowIndex].Selected = true;

                this.rowIndex = e.RowIndex;

                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];

                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);

                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                cnt--;

                double p, q, temp, total;
                p = double.Parse(lblrate.Text);
                q = double.Parse(txtqty.Text);
                temp = p * q;
                total = Convert.ToDouble(txtSubTotal.Text);
                total = total - temp;
                txtSubTotal.Text = total.ToString();

            }
            this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            clearDataOfAddToCard();
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }
        int lastid;
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string srno, pname, sno, rate, amt, gwt,qty,stot;               
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Sale(total)values(@total) select @@identity;", con);
                cmd.Parameters.AddWithValue("@total", txtFinalTotal.Text);
                lastid = int.Parse(cmd.ExecuteScalar().ToString());
                for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
                {
                    sno = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    pname = dataGridView1.Rows[row].Cells[1].Value.ToString();
                    srno = dataGridView1.Rows[row].Cells[2].Value.ToString();
                    rate = dataGridView1.Rows[row].Cells[3].Value.ToString();
                   // qty =double.Parse( dataGridView1.Rows[row].Cells[4].Value.ToString());
                    qty = dataGridView1.Rows[row].Cells[4].Value.ToString();
                    stot = dataGridView1.Rows[row].Cells[5].Value.ToString();
                    SqlCommand cmd1 = new SqlCommand("insert into Sale_Product(bid,date,name,address,mobno,sno,pname,rate,qty,stotal,discount,ftotal)values(@bid,@date,@name,@address,@mobno,@sno,@pname,@rate,@qty,@stotal,@discount,@ftotal)", con);
                    cmd1.Parameters.AddWithValue("@bid", lastid);
                    cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(CalenderBill.Text));
                    cmd1.Parameters.AddWithValue("@name", cbCustName.Text);
                    cmd1.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd1.Parameters.AddWithValue("@mobno", txtmobno.Text);
                    cmd1.Parameters.AddWithValue("@sno", sno);
                    cmd1.Parameters.AddWithValue("@pname", pname);
                    //cmd1.Parameters.AddWithValue("@srno", srno);                  
                    cmd1.Parameters.AddWithValue("@rate", rate);
                    cmd1.Parameters.AddWithValue("@qty", qty);
                    cmd1.Parameters.AddWithValue("@stotal", stot);
                    cmd1.Parameters.AddWithValue("@discount", txtDiscount.Text);
                    cmd1.Parameters.AddWithValue("@ftotal", txtFinalTotal.Text);
                    cmd1.ExecuteNonQuery();
                }
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_BillData values(@bno,@date,@cname,@address,@mobno,@ftotal)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@bno", lastid);
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(CalenderBill.Text));
                cmd.Parameters.AddWithValue("@cname", cbCustName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                cmd.Parameters.AddWithValue("@ftotal", txtFinalTotal.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Record inserted");            
            bid = lastid;
            PrintBill obj = new PrintBill();
            obj.Show();
            ClearAllData();
            clearDataOfAddToCard();
        }
        public static int bid;

        private void btnProRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cbPData.Items.Clear();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select mname from tbl_Stock ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbPData.Items.Add(dr[0].ToString());
                }
                cbPData.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbPData.AutoCompleteSource = AutoCompleteSource.ListItems;

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
                cbCustName.Items.Clear();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_Customer ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbCustName.Items.Add(dr["name"].ToString());
                    //custid = dr["ID"].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cbCustName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCustName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer.UserReqWindow obj = new Customer.UserReqWindow();
       //     CustomerBook obj1 = new CustomerBook();
            obj.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Product.StockWindow obj = new Product.StockWindow();
            obj.Show(); 
        }

        private void cbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection con = new SqlConnection(constring);
            //DataTable donater = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Customer where name='" + cbCustName.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //txtAddress.Text = dr["address"].ToString();
                txtmobno.Text = dr["mobno"].ToString();
               txtAddress.Text=dr["address"].ToString();          

            }
            con.Close();
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
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
        double subtot = 0, dis = 0, ftot = 0;
        private void txtFinalTotal_TextChanged(object sender, EventArgs e)
        {
            subtot = Convert.ToDouble(txtSubTotal.Text);
            dis = Convert.ToDouble(txtDiscount.Text);
           

            ftot = subtot - dis;
            txtFinalTotal.Text = ftot.ToString(); 
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
