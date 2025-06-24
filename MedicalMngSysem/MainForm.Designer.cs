namespace MedicalMngSysem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMini = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnShopDetails = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCustomerBook = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dashboard1 = new MedicalMngSysem.Dashboard();
            this.reportMaster1 = new ElectronicShop.Report.ReportMaster();
            this.companyDetails1 = new Genral_Software.CompanyDetails();
            this.bill1 = new MedicalMngSysem.Bill();
            this.stock1 = new MedicalMngSysem.Stock();
            this.customerBook1 = new MedicalMngSysem.CustomerBook();
            this.aboutUs1 = new MedicalMngSysem.AboutUs();
            this.trancation1 = new MedicalMngSysem.Trancation();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.panelMini);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAboutUs);
            this.panel1.Controls.Add(this.btnShopDetails);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnCustomerBook);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 757);
            this.panel1.TabIndex = 3;
            // 
            // panelMini
            // 
            this.panelMini.BackColor = System.Drawing.Color.White;
            this.panelMini.Location = new System.Drawing.Point(0, 149);
            this.panelMini.Name = "panelMini";
            this.panelMini.Size = new System.Drawing.Size(10, 64);
            this.panelMini.TabIndex = 18;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::MedicalMngSysem.Properties.Resources.icons8_Logout_24px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 597);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(246, 64);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::MedicalMngSysem.Properties.Resources.icons8_about_16px;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 533);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(246, 64);
            this.btnAboutUs.TabIndex = 16;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnShopDetails
            // 
            this.btnShopDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShopDetails.FlatAppearance.BorderSize = 0;
            this.btnShopDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnShopDetails.ForeColor = System.Drawing.Color.White;
            this.btnShopDetails.Image = global::MedicalMngSysem.Properties.Resources.icons8_Female_User_Update_24px;
            this.btnShopDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopDetails.Location = new System.Drawing.Point(0, 469);
            this.btnShopDetails.Name = "btnShopDetails";
            this.btnShopDetails.Size = new System.Drawing.Size(246, 64);
            this.btnShopDetails.TabIndex = 21;
            this.btnShopDetails.Text = "Shop Details Master";
            this.btnShopDetails.UseVisualStyleBackColor = true;
            this.btnShopDetails.Click += new System.EventHandler(this.btnShopDetails_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Image = global::MedicalMngSysem.Properties.Resources.icons8_rupee_24px;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 405);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(246, 64);
            this.btnTransaction.TabIndex = 15;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnBill
            // 
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::MedicalMngSysem.Properties.Resources.icons8_report_file_24px;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 341);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(246, 64);
            this.btnBill.TabIndex = 20;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCustomerBook
            // 
            this.btnCustomerBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerBook.FlatAppearance.BorderSize = 0;
            this.btnCustomerBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnCustomerBook.ForeColor = System.Drawing.Color.White;
            this.btnCustomerBook.Image = global::MedicalMngSysem.Properties.Resources.icons8_attendance_24px;
            this.btnCustomerBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerBook.Location = new System.Drawing.Point(0, 277);
            this.btnCustomerBook.Name = "btnCustomerBook";
            this.btnCustomerBook.Size = new System.Drawing.Size(246, 64);
            this.btnCustomerBook.TabIndex = 13;
            this.btnCustomerBook.Text = "Customer Book";
            this.btnCustomerBook.UseVisualStyleBackColor = true;
            this.btnCustomerBook.Click += new System.EventHandler(this.btnCustomerBook_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::MedicalMngSysem.Properties.Resources.icons8_add_16px;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 213);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(246, 64);
            this.btnStock.TabIndex = 12;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::MedicalMngSysem.Properties.Resources.icons8_dashboard_layout_24px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 149);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(246, 64);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Dashboard";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MedicalMngSysem.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 91);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(573, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Medical Shop Management System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(517, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 34);
            this.label10.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1287, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, Admin";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dashboard1);
            this.panelData.Controls.Add(this.reportMaster1);
            this.panelData.Controls.Add(this.companyDetails1);
            this.panelData.Controls.Add(this.bill1);
            this.panelData.Controls.Add(this.stock1);
            this.panelData.Controls.Add(this.customerBook1);
            this.panelData.Controls.Add(this.aboutUs1);
            this.panelData.Controls.Add(this.trancation1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(246, 91);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1347, 666);
            this.panelData.TabIndex = 5;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1347, 666);
            this.dashboard1.TabIndex = 6;
            // 
            // reportMaster1
            // 
            this.reportMaster1.BackColor = System.Drawing.Color.White;
            this.reportMaster1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportMaster1.Location = new System.Drawing.Point(0, 0);
            this.reportMaster1.Name = "reportMaster1";
            this.reportMaster1.Size = new System.Drawing.Size(1347, 666);
            this.reportMaster1.TabIndex = 5;
            // 
            // companyDetails1
            // 
            this.companyDetails1.AutoScroll = true;
            this.companyDetails1.BackColor = System.Drawing.Color.White;
            this.companyDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyDetails1.Location = new System.Drawing.Point(0, 0);
            this.companyDetails1.Name = "companyDetails1";
            this.companyDetails1.Size = new System.Drawing.Size(1347, 666);
            this.companyDetails1.TabIndex = 4;
            // 
            // bill1
            // 
            this.bill1.AutoScroll = true;
            this.bill1.BackColor = System.Drawing.Color.White;
            this.bill1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill1.Location = new System.Drawing.Point(0, 0);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(1347, 666);
            this.bill1.TabIndex = 3;
            // 
            // stock1
            // 
            this.stock1.AutoScroll = true;
            this.stock1.BackColor = System.Drawing.Color.White;
            this.stock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock1.Location = new System.Drawing.Point(0, 0);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(1347, 666);
            this.stock1.TabIndex = 2;
            // 
            // customerBook1
            // 
            this.customerBook1.AutoScroll = true;
            this.customerBook1.BackColor = System.Drawing.Color.White;
            this.customerBook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBook1.Location = new System.Drawing.Point(0, 0);
            this.customerBook1.Name = "customerBook1";
            this.customerBook1.Size = new System.Drawing.Size(1347, 666);
            this.customerBook1.TabIndex = 1;
            // 
            // aboutUs1
            // 
            this.aboutUs1.BackColor = System.Drawing.Color.White;
            this.aboutUs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUs1.Location = new System.Drawing.Point(0, 0);
            this.aboutUs1.Name = "aboutUs1";
            this.aboutUs1.Size = new System.Drawing.Size(1347, 666);
            this.aboutUs1.TabIndex = 0;
            // 
            // trancation1
            // 
            this.trancation1.BackColor = System.Drawing.Color.White;
            this.trancation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trancation1.Location = new System.Drawing.Point(0, 0);
            this.trancation1.Name = "trancation1";
            this.trancation1.Size = new System.Drawing.Size(1347, 666);
            this.trancation1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1593, 757);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnCustomerBook;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label2;
        private AboutUs aboutUs1;
        private Stock stock1;
        private CustomerBook customerBook1;
        private Trancation trancation1;
        private System.Windows.Forms.Button btnBill;
        private Bill bill1;
        private System.Windows.Forms.Button btnShopDetails;
        private Genral_Software.CompanyDetails companyDetails1;
        private ElectronicShop.Report.ReportMaster reportMaster1;
        private Dashboard dashboard1;
    }
}