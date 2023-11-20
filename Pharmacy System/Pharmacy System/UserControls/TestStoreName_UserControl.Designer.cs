namespace Pharmacy_System.UserControls
{
    partial class TestStoreName_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestStoreName_UserControl));
            this.Save_button = new System.Windows.Forms.Button();
            this.Statrment_label = new System.Windows.Forms.Label();
            this.StoreName_comboBox = new System.Windows.Forms.ComboBox();
            this.Cansel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(129)))));
            this.Save_button.FlatAppearance.BorderSize = 0;
            this.Save_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.Save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Image = ((System.Drawing.Image)(resources.GetObject("Save_button.Image")));
            this.Save_button.Location = new System.Drawing.Point(235, 187);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(108, 45);
            this.Save_button.TabIndex = 57;
            this.Save_button.Text = "إختيار";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Statrment_label
            // 
            this.Statrment_label.Font = new System.Drawing.Font("Tajawal", 13F);
            this.Statrment_label.Location = new System.Drawing.Point(310, 96);
            this.Statrment_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Statrment_label.Name = "Statrment_label";
            this.Statrment_label.Size = new System.Drawing.Size(133, 24);
            this.Statrment_label.TabIndex = 59;
            this.Statrment_label.Text = "حدد مستودع :";
            this.Statrment_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StoreName_comboBox
            // 
            this.StoreName_comboBox.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName_comboBox.FormattingEnabled = true;
            this.StoreName_comboBox.Location = new System.Drawing.Point(92, 96);
            this.StoreName_comboBox.Name = "StoreName_comboBox";
            this.StoreName_comboBox.Size = new System.Drawing.Size(222, 29);
            this.StoreName_comboBox.TabIndex = 60;
            // 
            // Cansel_button
            // 
            this.Cansel_button.BackColor = System.Drawing.Color.Gray;
            this.Cansel_button.FlatAppearance.BorderSize = 0;
            this.Cansel_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Cansel_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Cansel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cansel_button.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Cansel_button.ForeColor = System.Drawing.Color.White;
            this.Cansel_button.Image = ((System.Drawing.Image)(resources.GetObject("Cansel_button.Image")));
            this.Cansel_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cansel_button.Location = new System.Drawing.Point(126, 187);
            this.Cansel_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cansel_button.Name = "Cansel_button";
            this.Cansel_button.Size = new System.Drawing.Size(108, 45);
            this.Cansel_button.TabIndex = 58;
            this.Cansel_button.Text = "إلغاء";
            this.Cansel_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cansel_button.UseVisualStyleBackColor = false;
            // 
            // TestStoreName_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StoreName_comboBox);
            this.Controls.Add(this.Cansel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Statrment_label);
            this.Name = "TestStoreName_UserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(502, 267);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label Statrment_label;
        private System.Windows.Forms.ComboBox StoreName_comboBox;
        private System.Windows.Forms.Button Cansel_button;
    }
}
