﻿namespace MedicalMngSysem.Customer
{
    partial class UserReqWindow
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
            this.customerBook1 = new MedicalMngSysem.CustomerBook();
            this.SuspendLayout();
            // 
            // customerBook1
            // 
            this.customerBook1.AutoScroll = true;
            this.customerBook1.BackColor = System.Drawing.Color.White;
            this.customerBook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBook1.Location = new System.Drawing.Point(0, 0);
            this.customerBook1.Name = "customerBook1";
            this.customerBook1.Size = new System.Drawing.Size(1405, 620);
            this.customerBook1.TabIndex = 0;
            // 
            // UserReqWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 620);
            this.Controls.Add(this.customerBook1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserReqWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserReqWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomerBook customerBook1;

    }
}