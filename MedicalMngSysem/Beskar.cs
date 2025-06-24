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

namespace Beskar_Streel
{
    public partial class Beskar : UserControl
    {
        public Beskar()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            //chMSBar.Checked = false;
            //chMSFlatBar.Checked = false;
            //chMSScrape.Checked = false;
            //chMSSqureBar.Checked = false;
            cbCustName.Text = "";
            txtAddress.Text = "";
            txtGSTNo.Text = "";
            txtInvoiceNo.Text = "";
            txtChalanNo.Text = "";
            txtTotal.Text = "";
            txtp1.Text = "";
            txtc1.Text = "";
            txtq1.Text = "";
            txtr1.Text = "";
            txtsub1.Text = "";
            txtp2.Text = "";
            txtc2.Text = "";
            txtq2.Text = "";
            txtr2.Text = "";
            txtsub2.Text = "";
            txtp3.Text = "";
            txtc3.Text = "";
            txtq3.Text = "";
            txtr3.Text = "";
            txtsub3.Text = "";
            txtp4.Text = "";
            txtc4.Text = "";
            txtq4.Text = "";
            txtr4.Text = "";
            txtsub4.Text = "";
            txtp5.Text = "";
            txtc5.Text = "";
            txtq5.Text = "";
            txtr5.Text = "";
            txtsub5.Text = "";
            txtp6.Text = "";
            txtc6.Text = "";
            txtq6.Text = "";
            txtr6.Text = "";
            txtsub6.Text = "";
            
            txtSubTotal.Text = "";

            txtSGST.Text = "";
            txtcgstper.Text = "";
            txtCGST.Text = "";
            txtIGST.Text = "";
            txtigstper.Text = "";
            txtTotal.Text = "";
            txtTransport.Text = "";
            txtTotal.Text = "";
        }
        public static string NumberToWord(int number)
        {
            if (number == 0) return "Zero";

            if (number < 0) return "minus" + NumberToWord(Math.Abs(number));
            string word = "";
            if ((number / 1000000) > 0)
            {
                word += NumberToWord(number / 1000000) + "Million";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                word += NumberToWord(number / 1000) + "Thousand";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                word += NumberToWord(number / 100) + "Hundred";
                number %= 100;
            }
            if (number > 0)
            {
                if (word != "") word += "and";
                var unitsmap = new[] { " Zero", " One", " Two", " Three", " Four", " Five", " Six", " Seven", " Eight", " Nine", " Ten", " Eleven", " Twelve", " Thirteen", " Fourteen", " Fifteen", " Sixteen", " Seveb=nteen", " Eighteen", " Ninteen" };
                var tenmap = new[] { " Zero", " Ten", " Tweenty", " Thirty", " Fourth", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };

                if (number < 20)
                {
                    word += unitsmap[number];
                }
                else
                {
                    word += tenmap[number / 10];
                    if ((number % 10) > 0)
                    {
                        word += "-" + unitsmap[number % 10];
                    }
                }

            }
            return word;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(cbCustName.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 210));
            e.Graphics.DrawString(txtAddress.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(150, 270));
            e.Graphics.DrawString(txtGSTNo.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(165, 300));
            e.Graphics.DrawString(txtInvoiceNo.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(550, 220));
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            e.Graphics.DrawString(lblDate.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(700, 220));
            e.Graphics.DrawString(txtChalanNo.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(550, 255));
            e.Graphics.DrawString(lblDate.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(700, 260));
            e.Graphics.DrawString(txtTransport.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(575, 300));


            //if (chMSBar.Checked)
            //{
            //    e.Graphics.DrawString("MS Baars", new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 400));
            //    e.Graphics.DrawString(lblMSBarCode.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(400, 400));
            //  //  e.Graphics.DrawString(txtMSBarQty.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(475, 400));
            //   // e.Graphics.DrawString(txtMSBarRate.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(550, 400));
            //   // e.Graphics.DrawString(txtMSBarTotal.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 400));
            //}
            //if (chMSFlatBar.Checked)
            //{
            //    e.Graphics.DrawString("MS Baars", new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 440));
            //    e.Graphics.DrawString(lblMSFlatBarCode.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(400, 440));
            //    //e.Graphics.DrawString(txtMSFlatBarQty.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(475, 440));
            //    //e.Graphics.DrawString(txtMSFlatBarRate.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(550, 440));
            //    //e.Graphics.DrawString(txtMSFlatBarTotal.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 440));
            //}
            //if (chMSSqureBar.Checked)
            //{
            //    e.Graphics.DrawString("MS Flat Baars", new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 480));
            //    e.Graphics.DrawString(lblMSSqureBarCode.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(400, 480));
            //    //e.Graphics.DrawString(txtSqureQty.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(475, 480));
            //    //e.Graphics.DrawString(txtSqureRate.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(550, 480));
            //  //  e.Graphics.DrawString(txtSqureTotal.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 480));
            //}
            //if (chMSScrape.Checked)
            //{
            //    e.Graphics.DrawString("MS Squre Baars", new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 520));
            //    e.Graphics.DrawString(lblMSScrapeBarCode.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(400, 520));
            //    //e.Graphics.DrawString(txtScrapeQty.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(475, 520));
            //    //e.Graphics.DrawString(txtScrapeRate.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(550, 520));
            //    //e.Graphics.DrawString(txtScrapeTotal.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 520));
            //}
            e.Graphics.DrawString(txtSubTotal.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 625));
            e.Graphics.DrawString("-------------", new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(150, 730));
            e.Graphics.DrawString("Same Day", new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(150, 780));
            if (chCGST.Checked)
            {
                e.Graphics.DrawString(txtCGST.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 670));
            }
            if (chSGST.Checked)
            {
                e.Graphics.DrawString(txtSGST.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 710));
            }
            if (chIGST.Checked)
            {
                e.Graphics.DrawString(txtIGST.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 750));
            }
            e.Graphics.DrawString(txtTotal.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 785));

            //e.Graphics.DrawString(txtIGST.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 780));

            e.Graphics.DrawString(lblWord.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(165, 860));

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
                SqlCommand cmd = new SqlCommand("select name from tbl_Customer ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbCustName.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "select * from tbl_Customer where name='" + cbCustName.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                //  SqlCommand cmd = new SqlCommand(sql, con);
                int x = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    //lblCustID.Text = dr[0].ToString();
                    cbCustName.Text = dr[1].ToString();
                    txtAddress.Text = dr[2].ToString();
                    txtGSTNo.Text = dr[3].ToString();
                }
                else
                {
                    MessageBox.Show("Data not Availebel");
                }
                con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtc1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtq1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtr1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsub1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtc2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtq2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtr2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsub2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtc3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtq3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtr3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsub3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtc4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtc5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtc6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTransport_TextChanged(object sender, EventArgs e)
        {
            txtTransport.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtcgstper_TextChanged(object sender, EventArgs e)
        {
            double sub = 0, cg = 0, tcg = 0;
            if (txtcgstper.Text == "")
            {
                cg = 0;
            }
            else
            {
                sub = Convert.ToDouble(txtSubTotal.Text);
                cg = Convert.ToDouble(txtcgstper.Text);
                tcg = (sub * cg) / 100;
                txtCGST.Text = tcg.ToString();
                txtSGST.Text = tcg.ToString();
            }
        }

        private void txtigstper_TextChanged(object sender, EventArgs e)
        {
            double sub = 0, ig = 0, tcg = 0;
            if (txtigstper.Text == "")
            {
                ig = 0;
            }
            else
            {
                sub = Convert.ToDouble(txtSubTotal.Text);
                ig = Convert.ToDouble(txtigstper.Text);
                tcg = (sub * ig) / 100;
                txtIGST.Text = tcg.ToString();

            }
        }
        int lastid;
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (cbCustName.Text == "")
            {
                string msg1 = "Please Select customer Name";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                //txtInvoiceNo.Focus();
                return;
            }
            if (txtInvoiceNo.Text == "")
            {
                string msg1 = "Please Insert Invoice No.";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtInvoiceNo.Focus();
                return;
            }
            /*   if (txtChalanNo.Text == "")
               {
                   string msg1 = "Please Insert Chanlan No.";
                   string msg2 = "Add Product";
                   MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                   DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                   txtChalanNo.Focus();
                   return;
               }*/
            if (txtTransport.Text == "")
            {
                string msg1 = "Please Insert Transport";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtTransport.Focus();
                return;
            }
            if (txtSubTotal.Text == "")
            {
                string msg1 = "Please Enter sub total block";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtSubTotal.Focus();
                return;
            }
            if (chCGST.Checked)
            {
                if (txtcgstper.Text == "")
                {
                    string msg1 = "Please Enter CGST block";
                    string msg2 = "Add Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtcgstper.Focus();
                    return;
                }
            }
            if (txtTotal.Text == "")
            {
                string msg1 = "Please Enter total block";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtSubTotal.Focus();
                return;
            }
            //else
            //{
            //    if (txtigstper.Text == "")
            //    {
            //        string msg1 = "Please Enter IGST block";
            //        string msg2 = "Add Product";
            //        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            //        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
            //        txtigstper.Focus();
            //        return;
            //    }
            //}
            try{
            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_Bill values(@cname,@address,@gst,@ino,@chalanno,@trans,@p1,@c1,@q1,@r1,@sub1,@p2,@c2,@q2,@r2,@sub2,@p3,@c3,@q3,@r3,@sub3,@p4,@c4,@q4,@r4,@sub4,@p5,@c5,@q5,@r5,@sub5,@p6,@c6,@q6,@r6,@sub6,@subtotal,@cgstper,@cgst,@sgst,@igstper,@igst,@ftotal,@wtotal)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cname", cbCustName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@gst", txtGSTNo.Text);
                cmd.Parameters.AddWithValue("@ino", txtInvoiceNo.Text);
                cmd.Parameters.AddWithValue("@chalanno", txtChalanNo.Text);
                cmd.Parameters.AddWithValue("@trans", txtTransport.Text);
                cmd.Parameters.AddWithValue("@p1", txtp1.Text);
                cmd.Parameters.AddWithValue("@c1", txtc1.Text);
                cmd.Parameters.AddWithValue("@q1", txtq1.Text);
                cmd.Parameters.AddWithValue("@r1", txtr1.Text);
                cmd.Parameters.AddWithValue("@sub1", txtsub1.Text);
                cmd.Parameters.AddWithValue("@p2", txtp2.Text);
                cmd.Parameters.AddWithValue("@c2", txtc2.Text);
                cmd.Parameters.AddWithValue("@q2", txtq2.Text);
                cmd.Parameters.AddWithValue("@r2", txtr2.Text);
                cmd.Parameters.AddWithValue("@sub2", txtsub2.Text);
                cmd.Parameters.AddWithValue("@p3", txtp3.Text);
                cmd.Parameters.AddWithValue("@c3", txtc3.Text);
                cmd.Parameters.AddWithValue("@q3", txtq3.Text);
                cmd.Parameters.AddWithValue("@r3", txtr3.Text);
                cmd.Parameters.AddWithValue("@sub3", txtsub3.Text);
                cmd.Parameters.AddWithValue("@p4", txtp4.Text);
                cmd.Parameters.AddWithValue("@c4", txtc4.Text);
                cmd.Parameters.AddWithValue("@q4", txtq4.Text);
                cmd.Parameters.AddWithValue("@r4", txtr4.Text);
                cmd.Parameters.AddWithValue("@sub4", txtsub4.Text);
                cmd.Parameters.AddWithValue("@p5", txtp5.Text);
                cmd.Parameters.AddWithValue("@c5", txtc5.Text);
                cmd.Parameters.AddWithValue("@q5", txtq5.Text);
                cmd.Parameters.AddWithValue("@r5", txtr5.Text);
                cmd.Parameters.AddWithValue("@sub5", txtsub5.Text);
                cmd.Parameters.AddWithValue("@p6", txtp6.Text);
                cmd.Parameters.AddWithValue("@c6", txtc6.Text);
                cmd.Parameters.AddWithValue("@q6", txtq6.Text);
                cmd.Parameters.AddWithValue("@r6", txtr6.Text);
                cmd.Parameters.AddWithValue("@sub6", txtsub6.Text);
                cmd.Parameters.AddWithValue("@subtotal", txtSubTotal.Text);
                cmd.Parameters.AddWithValue("@cgstper", txtcgstper.Text);
                cmd.Parameters.AddWithValue("@cgst", txtCGST.Text);
                cmd.Parameters.AddWithValue("@sgst", txtSGST.Text);
                cmd.Parameters.AddWithValue("@igstper", txtigstper.Text);
                cmd.Parameters.AddWithValue("@igst", txtIGST.Text);
                cmd.Parameters.AddWithValue("@ftotal", txtTotal.Text);
                cmd.Parameters.AddWithValue("@wtotal", lblWord.Text);           
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Dowloaded");
               // bid = lastid;
               // PrintBill obj = new PrintBill();
               // obj.Show();
                    //ClearData();                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtsub1_TextChanged(object sender, EventArgs e)
        {
            if (txtp1.Text == "")
            {
                string msg1 = "Please Insert Name of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtp1.Focus();
                return;
            }
            if (txtc1.Text == "")
            {
                string msg1 = "Please Insert Code of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtc1.Focus();
                return;
            }
            if (txtq1.Text == "")
            {
                string msg1 = "Please Insert Quntity of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtq1.Focus();
                return;
            }
            if (txtr1.Text == "")
            {
                string msg1 = "Please Insert Rate of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtr1.Focus();
                return;
            }

            double q, r, t;
            q = Convert.ToDouble(txtq1.Text);
            r = Convert.ToDouble(txtr1.Text);
            t = q * r;
            txtsub1.Text = t.ToString();
        }

        private void txtsub2_TextChanged(object sender, EventArgs e)
        {
            if (txtp2.Text == "")
            {
                string msg1 = "Please Insert Name of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtp2.Focus();
                return;
            }
            if (txtc2.Text == "")
            {
                string msg1 = "Please Insert Code of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtc2.Focus();
                return;
            }
            if (txtq2.Text == "")
            {
                string msg1 = "Please Insert Quntity of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtq2.Focus();
                return;
            }
            if (txtr2.Text == "")
            {
                string msg1 = "Please Insert Rate of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtr2.Focus();
                return;
            }

            double q, r, t;
            q = Convert.ToDouble(txtq2.Text);
            r = Convert.ToDouble(txtr2.Text);
            t = q * r;
            txtsub2.Text = t.ToString();
        }

        private void txtsub3_TextChanged(object sender, EventArgs e)
        {
            if (txtp3.Text == "")
            {
                string msg1 = "Please Insert Name of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtp3.Focus();
                return;
            }
            if (txtc3.Text == "")
            {
                string msg1 = "Please Insert Code of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtc3.Focus();
                return;
            }
            if (txtq3.Text == "")
            {
                string msg1 = "Please Insert Quntity of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtq3.Focus();
                return;
            }
            if (txtr3.Text == "")
            {
                string msg1 = "Please Insert Rate of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtr3.Focus();
                return;
            }

            double q, r, t;
            q = Convert.ToDouble(txtq3.Text);
            r = Convert.ToDouble(txtr3.Text);
            t = q * r;
            txtsub3.Text = t.ToString();
        }

        private void txtsub4_TextChanged(object sender, EventArgs e)
        {
            if (txtp4.Text == "")
            {
                string msg1 = "Please Insert Name of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtp4.Focus();
                return;
            }
            if (txtc4.Text == "")
            {
                string msg1 = "Please Insert Code of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtc4.Focus();
                return;
            }
            if (txtq4.Text == "")
            {
                string msg1 = "Please Insert Quntity of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtq4.Focus();
                return;
            }
            if (txtr4.Text == "")
            {
                string msg1 = "Please Insert Rate of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtr4.Focus();
                return;
            }

            double q, r, t;
            q = Convert.ToDouble(txtq4.Text);
            r = Convert.ToDouble(txtr4.Text);
            t = q * r;
            txtsub4.Text = t.ToString();
        }

        private void txtsub5_TextChanged(object sender, EventArgs e)
        {
            if (txtp5.Text == "")
            {
                string msg1 = "Please Insert Name of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtp5.Focus();
                return;
            }
            if (txtc5.Text == "")
            {
                string msg1 = "Please Insert Code of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtc5.Focus();
                return;
            }
            if (txtq5.Text == "")
            {
                string msg1 = "Please Insert Quntity of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtq5.Focus();
                return;
            }
            if (txtr5.Text == "")
            {
                string msg1 = "Please Insert Rate of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtr5.Focus();
                return;
            }

            double q, r, t;
            q = Convert.ToDouble(txtq5.Text);
            r = Convert.ToDouble(txtr5.Text);
            t = q * r;
            txtsub5.Text = t.ToString();
        }

        private void txtsub6_TextChanged(object sender, EventArgs e)
        {
            if (txtp6.Text == "")
            {
                string msg1 = "Please Insert Name of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtp6.Focus();
                return;
            }
            if (txtc6.Text == "")
            {
                string msg1 = "Please Insert Code of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtc6.Focus();
                return;
            }
            if (txtq6.Text == "")
            {
                string msg1 = "Please Insert Quntity of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtq6.Focus();
                return;
            }
            if (txtr6.Text == "")
            {
                string msg1 = "Please Insert Rate of Product";
                string msg2 = "Add Product";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                txtr6.Focus();
                return;
            }

            double q, r, t;
            q = Convert.ToDouble(txtq6.Text);
            r = Convert.ToDouble(txtr6.Text);
            t = q * r;
            txtsub6.Text = t.ToString();
        }
      
      
        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            double s1 = 0,
                   s2 = 0,
                   s3 = 0,
                   s4 = 0,
                   s5 = 0,
                   s6 = 0,
                   subtot = 0;
             if (txtsub1.Text == "")
             {
                 s1 = 0;
             }
             else
             {               
                 s1 = Convert.ToDouble(txtsub1.Text);                 
             }
             if (txtsub2.Text == "")
             {
                 s2 = 0;
             }
             else
             {
                 s2 = Convert.ToDouble(txtsub2.Text);
             }
             if (txtsub3.Text == "")
             {
                 s3 = 0;
             }
             else
             {
                 s3 = Convert.ToDouble(txtsub3.Text);
             }
             if (txtsub4.Text == "")
             {
                 s4 = 0;
             }
             else
             {
                 s4 = Convert.ToDouble(txtsub4.Text);
             }
             if (txtsub5.Text == "")
             {
                 s5 = 0;
             }
             else
             {
                 s5 = Convert.ToDouble(txtsub5.Text);
             }
             if (txtsub6.Text == "")
             {
                 s6 = 0;
             }
             else
             {
                 s6 = Convert.ToDouble(txtsub6.Text);
             }
             subtot = s1 + s2 + s3 + s4 + s5 + s6;
             txtSubTotal.Text = subtot.ToString();
        }

        private void chCGST_CheckedChanged(object sender, EventArgs e)
        {
            if (chCGST.Checked)
            {
                chSGST.Checked = true;
                chIGST.Checked = false;
                chIGST.Enabled = false;
                txtCGST.Visible = true;
                txtSGST.Visible = true;
                txtIGST.Visible = false;
                txtigstper.Visible = false;
                txtcgstper.Visible = true;
            }
            else
            {
                chSGST.Checked = false;
                chIGST.Checked = true;
                chIGST.Enabled = true;
                txtCGST.Visible = false;
                txtSGST.Visible = false;
                txtIGST.Visible = true;
                txtigstper.Visible = true;
                txtcgstper.Visible = false;
            }
        }

        private void chIGST_CheckedChanged(object sender, EventArgs e)
        {
            if (chIGST.Checked)
            {
                chCGST.Enabled = false;
                chCGST.Checked = false;
                chSGST.Enabled = false;
                chSGST.Checked = false;
            }
            else
            {
                chCGST.Enabled = true;
                chCGST.Checked = true;
                chSGST.Enabled = true;
                chSGST.Checked = true;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
            if (chCGST.Checked)
            {


                double s1 = 0, c = 0, s = 0, f = 0;
                if (txtcgstper.Text == "")
                {
                    txtcgstper.Text = "0";
                    s1 = Convert.ToDouble(txtSubTotal.Text);
                    c = Convert.ToDouble(txtCGST.Text);
                    s = Convert.ToDouble(txtSGST.Text);
                    f = s1 + c + s;
                    int f1 = Convert.ToInt32(f);
                    txtTotal.Text = f.ToString();

                    lblWord.Text = NumberToWord(Convert.ToInt32(f1.ToString()));
                }
                else
                {
                    s1 = Convert.ToDouble(txtSubTotal.Text);
                    c = Convert.ToDouble(txtCGST.Text);
                    s = Convert.ToDouble(txtSGST.Text);
                    f = s1 + c + s;
                    int f1 = Convert.ToInt32(f);
                    txtTotal.Text = f.ToString();

                    lblWord.Text = NumberToWord(Convert.ToInt32(f1.ToString()));
                }


            }
            else
            {
                double s1 = 0, i = 0, f = 0;
                if (txtigstper.Text == "")
                {
                    txtigstper.Text = "0";
                    s1 = Convert.ToDouble(txtSubTotal.Text);
                    i = Convert.ToDouble(txtIGST.Text);

                    f = s1 + i;
                    int f1 = Convert.ToInt32(f);
                    txtTotal.Text = f.ToString();

                    lblWord.Text = NumberToWord(Convert.ToInt32(f1.ToString()));
                }
                else
                {
                    s1 = Convert.ToDouble(txtSubTotal.Text);
                    i = Convert.ToDouble(txtIGST.Text);

                    f = s1 + i;
                    int f1 = Convert.ToInt32(f);
                    txtTotal.Text = f.ToString();

                    lblWord.Text = NumberToWord(Convert.ToInt32(f1.ToString()));
                }


            }
        }
        }

    
}
