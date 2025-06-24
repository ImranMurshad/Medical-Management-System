namespace ElectronicShop.Report
{
    partial class ReportMaster
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
            this.lblBID = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dataGridViewAddProduct = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchData = new System.Windows.Forms.ComboBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.lblMobno = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.ForeColor = System.Drawing.Color.Black;
            this.lblBID.Location = new System.Drawing.Point(972, 269);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(27, 24);
            this.lblBID.TabIndex = 198;
            this.lblBID.Text = "ID";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1014, 604);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(184, 55);
            this.btnPrint.TabIndex = 197;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(799, 604);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(184, 55);
            this.btnShowAll.TabIndex = 196;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dataGridViewAddProduct
            // 
            this.dataGridViewAddProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProduct.Location = new System.Drawing.Point(67, 327);
            this.dataGridViewAddProduct.Name = "dataGridViewAddProduct";
            this.dataGridViewAddProduct.RowTemplate.Height = 24;
            this.dataGridViewAddProduct.Size = new System.Drawing.Size(1131, 260);
            this.dataGridViewAddProduct.TabIndex = 195;
            this.dataGridViewAddProduct.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddProduct_RowHeaderMouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(555, 253);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(184, 55);
            this.btnSearch.TabIndex = 194;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearchData
            // 
            this.cbSearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbSearchData.FormattingEnabled = true;
            this.cbSearchData.Items.AddRange(new object[] {
            "Bill No.",
            "Customer Name",
            "Mobile No.",
            "Date Vise"});
            this.cbSearchData.Location = new System.Drawing.Point(645, 146);
            this.cbSearchData.Name = "cbSearchData";
            this.cbSearchData.Size = new System.Drawing.Size(345, 30);
            this.cbSearchData.TabIndex = 193;
            // 
            // cbSearchType
            // 
            this.cbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Bill No.",
            "Customer Name",
            "Mobile No.",
            "Date Vise"});
            this.cbSearchType.Location = new System.Drawing.Point(402, 146);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(221, 30);
            this.cbSearchType.TabIndex = 192;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // lblMobno
            // 
            this.lblMobno.AutoSize = true;
            this.lblMobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobno.ForeColor = System.Drawing.Color.Black;
            this.lblMobno.Location = new System.Drawing.Point(286, 149);
            this.lblMobno.Name = "lblMobno";
            this.lblMobno.Size = new System.Drawing.Size(110, 24);
            this.lblMobno.TabIndex = 191;
            this.lblMobno.Text = "Select Type";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.Black;
            this.lblto.Location = new System.Drawing.Point(617, 208);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(37, 24);
            this.lblto.TabIndex = 190;
            this.lblto.Text = "TO";
            this.lblto.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(675, 208);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(226, 28);
            this.dateTimePicker2.TabIndex = 189;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(402, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 28);
            this.dateTimePicker1.TabIndex = 188;
            this.dateTimePicker1.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(286, 208);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 24);
            this.lblDate.TabIndex = 187;
            this.lblDate.Text = "Select Date";
            this.lblDate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 37);
            this.label7.TabIndex = 186;
            this.label7.Text = "Bill Receipt Master";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 199;
            this.label1.Text = "Total Count : ";
            // 
            // lblcnt
            // 
            this.lblcnt.AutoSize = true;
            this.lblcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnt.ForeColor = System.Drawing.Color.Black;
            this.lblcnt.Location = new System.Drawing.Point(226, 620);
            this.lblcnt.Name = "lblcnt";
            this.lblcnt.Size = new System.Drawing.Size(20, 24);
            this.lblcnt.TabIndex = 200;
            this.lblcnt.Text = "0";
            // 
            // ReportMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblcnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBID);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridViewAddProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchData);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.lblMobno);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label7);
            this.Name = "ReportMaster";
            this.Size = new System.Drawing.Size(1276, 805);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dataGridViewAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchData;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label lblMobno;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcnt;
    }
}
