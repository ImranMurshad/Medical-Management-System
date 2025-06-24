namespace MedicalMngSysem
{
    partial class CustomerBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtmobno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCustRefresh = new System.Windows.Forms.Button();
            this.btnUserReq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtAddress.Location = new System.Drawing.Point(215, 222);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(391, 105);
            this.txtAddress.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.Location = new System.Drawing.Point(49, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 24);
            this.label14.TabIndex = 56;
            this.label14.Text = "Address:-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label13.Location = new System.Drawing.Point(28, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 24);
            this.label13.TabIndex = 55;
            this.label13.Text = "Mobile No.:-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.Location = new System.Drawing.Point(28, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Customer Name:-";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(938, 527);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(187, 56);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "SHOW ALL";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnNewEntry.FlatAppearance.BorderSize = 0;
            this.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnNewEntry.ForeColor = System.Drawing.Color.White;
            this.btnNewEntry.Location = new System.Drawing.Point(4, 527);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(187, 56);
            this.btnNewEntry.TabIndex = 65;
            this.btnNewEntry.Text = "NEW ENTRY";
            this.btnNewEntry.UseVisualStyleBackColor = false;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(692, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 56);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(470, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 56);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(242, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 56);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(638, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 278);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(211, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 22);
            this.lblID.TabIndex = 68;
            this.lblID.Text = "ID";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCustName.Location = new System.Drawing.Point(215, 161);
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(391, 35);
            this.txtCustName.TabIndex = 171;
            // 
            // txtmobno
            // 
            this.txtmobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtmobno.Location = new System.Drawing.Point(215, 363);
            this.txtmobno.Multiline = true;
            this.txtmobno.Name = "txtmobno";
            this.txtmobno.Size = new System.Drawing.Size(391, 35);
            this.txtmobno.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 36);
            this.label7.TabIndex = 176;
            this.label7.Text = "Customer Master";
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(841, 158);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(284, 30);
            this.cbSearch.TabIndex = 216;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 24);
            this.label5.TabIndex = 215;
            this.label5.Text = "Select Customer Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1216, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 56);
            this.btnSearch.TabIndex = 214;
            this.btnSearch.Tag = "24";
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCustRefresh
            // 
            this.btnCustRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnCustRefresh.FlatAppearance.BorderSize = 0;
            this.btnCustRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustRefresh.ForeColor = System.Drawing.Color.White;
            this.btnCustRefresh.Image = global::MedicalMngSysem.Properties.Resources.icons8_refresh_24px;
            this.btnCustRefresh.Location = new System.Drawing.Point(1145, 157);
            this.btnCustRefresh.Name = "btnCustRefresh";
            this.btnCustRefresh.Size = new System.Drawing.Size(49, 33);
            this.btnCustRefresh.TabIndex = 217;
            this.btnCustRefresh.UseVisualStyleBackColor = false;
            this.btnCustRefresh.Click += new System.EventHandler(this.btnCustRefresh_Click);
            // 
            // btnUserReq
            // 
            this.btnUserReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnUserReq.FlatAppearance.BorderSize = 0;
            this.btnUserReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnUserReq.ForeColor = System.Drawing.Color.White;
            this.btnUserReq.Location = new System.Drawing.Point(1164, 528);
            this.btnUserReq.Name = "btnUserReq";
            this.btnUserReq.Size = new System.Drawing.Size(219, 55);
            this.btnUserReq.TabIndex = 218;
            this.btnUserReq.Tag = "21";
            this.btnUserReq.Text = "Customer Requirement";
            this.btnUserReq.UseVisualStyleBackColor = false;
            this.btnUserReq.Click += new System.EventHandler(this.btnUserReq_Click);
            // 
            // CustomerBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUserReq);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnCustRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmobno);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "CustomerBook";
            this.Size = new System.Drawing.Size(1415, 614);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtmobno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnCustRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUserReq;
    }
}
