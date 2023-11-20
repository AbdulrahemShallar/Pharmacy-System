namespace Pharmacy_System
{
    partial class Form_Replay
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
            this.Fill_panel.Size = new System.Drawing.Size(502, 267);
            this.Fill_panel.TabIndex = 0;
            // 
            // Form_Replay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 267);
            this.Controls.Add(this.Fill_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Replay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Replay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fill_panel;
    }
}