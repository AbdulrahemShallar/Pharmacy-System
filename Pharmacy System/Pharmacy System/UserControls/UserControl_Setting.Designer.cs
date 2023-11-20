namespace Pharmacy_System.UserControls
{
    partial class UserControl_Setting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Setting));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.User_button = new System.Windows.Forms.Button();
            this.ShortCut_button = new System.Windows.Forms.Button();
            this.Reference_button = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.User_button);
            this.flowLayoutPanel1.Controls.Add(this.ShortCut_button);
            this.flowLayoutPanel1.Controls.Add(this.Reference_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 473);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.FlowLayoutPanel1_SizeChanged);
            // 
            // User_button
            // 
            this.User_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_button.BackgroundImage")));
            this.User_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_button.FlatAppearance.BorderSize = 0;
            this.User_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.User_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.User_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_button.Font = new System.Drawing.Font("Tajawal", 8.5F);
            this.User_button.ForeColor = System.Drawing.Color.DimGray;
            this.User_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.User_button.Location = new System.Drawing.Point(377, 3);
            this.User_button.Name = "User_button";
            this.User_button.Size = new System.Drawing.Size(76, 80);
            this.User_button.TabIndex = 6;
            this.User_button.Text = "مستخدمين";
            this.User_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.User_button.UseVisualStyleBackColor = true;
            this.User_button.Click += new System.EventHandler(this.AccountCard_button_Click);
            // 
            // ShortCut_button
            // 
            this.ShortCut_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShortCut_button.BackgroundImage")));
            this.ShortCut_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShortCut_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShortCut_button.FlatAppearance.BorderSize = 0;
            this.ShortCut_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.ShortCut_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ShortCut_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortCut_button.Font = new System.Drawing.Font("Tajawal", 8.5F);
            this.ShortCut_button.ForeColor = System.Drawing.Color.DimGray;
            this.ShortCut_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShortCut_button.Location = new System.Drawing.Point(295, 3);
            this.ShortCut_button.Name = "ShortCut_button";
            this.ShortCut_button.Size = new System.Drawing.Size(76, 80);
            this.ShortCut_button.TabIndex = 7;
            this.ShortCut_button.Text = "إختصارات";
            this.ShortCut_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShortCut_button.UseVisualStyleBackColor = true;
            // 
            // Reference_button
            // 
            this.Reference_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reference_button.BackgroundImage")));
            this.Reference_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reference_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reference_button.FlatAppearance.BorderSize = 0;
            this.Reference_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.Reference_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Reference_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reference_button.Font = new System.Drawing.Font("Tajawal", 8.5F);
            this.Reference_button.ForeColor = System.Drawing.Color.DimGray;
            this.Reference_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reference_button.Location = new System.Drawing.Point(213, 3);
            this.Reference_button.Name = "Reference_button";
            this.Reference_button.Size = new System.Drawing.Size(76, 80);
            this.Reference_button.TabIndex = 8;
            this.Reference_button.Text = "تنبيه الصلاحية";
            this.Reference_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reference_button.UseVisualStyleBackColor = true;
            this.Reference_button.Click += new System.EventHandler(this.Reference_button_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // UserControl_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tajawal", 8.5F);
            this.Name = "UserControl_Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(456, 473);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button User_button;
        private System.Windows.Forms.Button ShortCut_button;
        private System.Windows.Forms.Button Reference_button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
