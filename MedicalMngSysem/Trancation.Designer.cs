namespace MedicalMngSysem
{
    partial class Trancation
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
            this.btnAddtoCard = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnAddtoCard
            // 
            this.btnAddtoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            this.btnAddtoCard.FlatAppearance.BorderSize = 0;
            this.btnAddtoCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddtoCard.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCard.Location = new System.Drawing.Point(96, 123);
            this.btnAddtoCard.Name = "btnAddtoCard";
            this.btnAddtoCard.Size = new System.Drawing.Size(187, 56);
            this.btnAddtoCard.TabIndex = 73;
            this.btnAddtoCard.Text = "VIEW";
            this.btnAddtoCard.UseVisualStyleBackColor = false;
            this.btnAddtoCard.Click += new System.EventHandler(this.btnAddtoCard_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(45, 213);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1137, 502);
            this.crystalReportViewer1.TabIndex = 74;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Trancation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnAddtoCard);
            this.Name = "Trancation";
            this.Size = new System.Drawing.Size(1196, 752);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddtoCard;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
