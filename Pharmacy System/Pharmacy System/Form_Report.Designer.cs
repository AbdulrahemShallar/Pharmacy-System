namespace Pharmacy_System
{
    partial class Form_Report
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
            this.Fill_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Fill_panel
            // 
            this.Fill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill_panel.Location = new System.Drawing.Point(0, 0);
            this.Fill_panel.Name = "Fill_panel";
            this.Fill_panel.Size = new System.Drawing.Size(964, 545);
            this.Fill_panel.TabIndex = 0;
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 545);
            this.Controls.Add(this.Fill_panel);
            this.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fill_panel;
    }
}