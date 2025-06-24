namespace MedicalMngSysem.Product
{
    partial class StockWindow
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
            this.stock1 = new MedicalMngSysem.Stock();
            this.SuspendLayout();
            // 
            // stock1
            // 
            this.stock1.AutoScroll = true;
            this.stock1.BackColor = System.Drawing.Color.White;
            this.stock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock1.Location = new System.Drawing.Point(0, 0);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(1346, 723);
            this.stock1.TabIndex = 0;
            // 
            // StockWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 723);
            this.Controls.Add(this.stock1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Stock stock1;
    }
}