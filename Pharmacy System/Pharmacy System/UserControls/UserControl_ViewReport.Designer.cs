namespace Pharmacy_System.UserControls
{
    partial class UserControl_ViewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ViewReport));
            this.Report_label1 = new System.Windows.Forms.Label();
            this.Report_label2 = new System.Windows.Forms.Label();
            this.Report_label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton_Report = new BrbVideoManager.Controls.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Report_label1
            // 
            resources.ApplyResources(this.Report_label1, "Report_label1");
            this.Report_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.Report_label1.Name = "Report_label1";
            // 
            // Report_label2
            // 
            resources.ApplyResources(this.Report_label2, "Report_label2");
            this.Report_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.Report_label2.Name = "Report_label2";
            // 
            // Report_label3
            // 
            resources.ApplyResources(this.Report_label3, "Report_label3");
            this.Report_label3.ForeColor = System.Drawing.Color.Gray;
            this.Report_label3.Name = "Report_label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.roundedButton_Report);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // roundedButton_Report
            // 
            this.roundedButton_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Report.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Report.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Report.BorderDownWidth = 1F;
            this.roundedButton_Report.BorderOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(203)))));
            this.roundedButton_Report.BorderOverWidth = 1F;
            this.roundedButton_Report.BorderRadius = 50;
            this.roundedButton_Report.BorderWidth = 1.75F;
            this.roundedButton_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton_Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(203)))));
            resources.ApplyResources(this.roundedButton_Report, "roundedButton_Report");
            this.roundedButton_Report.ForeColor = System.Drawing.Color.White;
            this.roundedButton_Report.Name = "roundedButton_Report";
            this.roundedButton_Report.UseVisualStyleBackColor = false;
            this.roundedButton_Report.Click += new System.EventHandler(this.RoundedButton_Report_Click);
            // 
            // UserControl_ViewReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Report_label3);
            this.Controls.Add(this.Report_label2);
            this.Controls.Add(this.Report_label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_ViewReport";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Report_label1;
        public System.Windows.Forms.Label Report_label2;
        public System.Windows.Forms.Label Report_label3;
        private BrbVideoManager.Controls.RoundedButton roundedButton_Report;
    }
}
