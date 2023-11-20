namespace Pharmacy_System.UserControls
{
    partial class UserControl_Serch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Serch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton_Serch = new BrbVideoManager.Controls.RoundedButton();
            this.Serch_label3 = new System.Windows.Forms.Label();
            this.Serch_label2 = new System.Windows.Forms.Label();
            this.Serch_label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.roundedButton_Serch);
            this.panel1.Controls.Add(this.Serch_label3);
            this.panel1.Controls.Add(this.Serch_label2);
            this.panel1.Controls.Add(this.Serch_label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(407, 449);
            this.panel1.TabIndex = 3;
            // 
            // roundedButton_Serch
            // 
            this.roundedButton_Serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Serch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Serch.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Serch.BorderDownWidth = 1F;
            this.roundedButton_Serch.BorderOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(203)))));
            this.roundedButton_Serch.BorderOverWidth = 1F;
            this.roundedButton_Serch.BorderRadius = 50;
            this.roundedButton_Serch.BorderWidth = 1.75F;
            this.roundedButton_Serch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton_Serch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.roundedButton_Serch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(203)))));
            this.roundedButton_Serch.Font = new System.Drawing.Font("Tajawal", 11F);
            this.roundedButton_Serch.ForeColor = System.Drawing.Color.White;
            this.roundedButton_Serch.Location = new System.Drawing.Point(22, 377);
            this.roundedButton_Serch.Name = "roundedButton_Serch";
            this.roundedButton_Serch.Size = new System.Drawing.Size(101, 35);
            this.roundedButton_Serch.TabIndex = 5;
            this.roundedButton_Serch.Text = "بحث";
            this.roundedButton_Serch.UseVisualStyleBackColor = false;
            this.roundedButton_Serch.Click += new System.EventHandler(this.RoundedButton_Serch_Click);
            // 
            // Serch_label3
            // 
            this.Serch_label3.AutoEllipsis = true;
            this.Serch_label3.Font = new System.Drawing.Font("Tajawal", 12F);
            this.Serch_label3.ForeColor = System.Drawing.Color.Gray;
            this.Serch_label3.Location = new System.Drawing.Point(0, 227);
            this.Serch_label3.Name = "Serch_label3";
            this.Serch_label3.Size = new System.Drawing.Size(407, 138);
            this.Serch_label3.TabIndex = 2;
            this.Serch_label3.Text = resources.GetString("Serch_label3.Text");
            // 
            // Serch_label2
            // 
            this.Serch_label2.Font = new System.Drawing.Font("Tajawal Medium", 20F, System.Drawing.FontStyle.Bold);
            this.Serch_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.Serch_label2.Location = new System.Drawing.Point(3, 180);
            this.Serch_label2.Name = "Serch_label2";
            this.Serch_label2.Size = new System.Drawing.Size(407, 69);
            this.Serch_label2.TabIndex = 3;
            this.Serch_label2.Text = "سهولة البحث";
            // 
            // Serch_label1
            // 
            this.Serch_label1.Font = new System.Drawing.Font("Tajawal", 34F, System.Drawing.FontStyle.Bold);
            this.Serch_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.Serch_label1.Location = new System.Drawing.Point(0, 107);
            this.Serch_label1.Name = "Serch_label1";
            this.Serch_label1.Size = new System.Drawing.Size(407, 94);
            this.Serch_label1.TabIndex = 4;
            this.Serch_label1.Text = "البحث";
            // 
            // UserControl_Serch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Serch";
            this.Size = new System.Drawing.Size(407, 449);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BrbVideoManager.Controls.RoundedButton roundedButton_Serch;
        public System.Windows.Forms.Label Serch_label3;
        public System.Windows.Forms.Label Serch_label2;
        public System.Windows.Forms.Label Serch_label1;
    }
}
