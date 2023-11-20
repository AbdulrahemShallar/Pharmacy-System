namespace Pharmacy_System
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Login_Button = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.Forget_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_picturebox = new System.Windows.Forms.PictureBox();
            this.UserName_picturebox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Tajawal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(319, 242);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(95, 39);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "تسجيل الدخول";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Title_label
            // 
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title_label.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(319, 0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(133, 63);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "تسجيل الدخول";
            this.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Forget_LinkLabel
            // 
            this.Forget_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Forget_LinkLabel.AutoSize = true;
            this.Forget_LinkLabel.DisabledLinkColor = System.Drawing.Color.Gray;
            this.Forget_LinkLabel.Font = new System.Drawing.Font("Tajawal", 9F);
            this.Forget_LinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.Forget_LinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.Forget_LinkLabel.Location = new System.Drawing.Point(216, 258);
            this.Forget_LinkLabel.Name = "Forget_LinkLabel";
            this.Forget_LinkLabel.Size = new System.Drawing.Size(97, 16);
            this.Forget_LinkLabel.TabIndex = 3;
            this.Forget_LinkLabel.TabStop = true;
            this.Forget_LinkLabel.Text = "نسيت كلمة المرور";
            this.Forget_LinkLabel.VisitedLinkColor = System.Drawing.Color.Gray;
            this.Forget_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forget_LinkLabel_LinkClicked);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Location = new System.Drawing.Point(3, 2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(25, 25);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Controls.Add(this.Title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 63);
            this.panel1.TabIndex = 23;
            // 
            // UserName_textbox
            // 
            this.UserName_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_textbox.Font = new System.Drawing.Font("Tajawal", 10F);
            this.UserName_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName_textbox.HintText = "اسم المستخدم";
            this.UserName_textbox.isPassword = false;
            this.UserName_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.UserName_textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.UserName_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.UserName_textbox.LineThickness = 3;
            this.UserName_textbox.Location = new System.Drawing.Point(99, 102);
            this.UserName_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.UserName_textbox.Name = "UserName_textbox";
            this.UserName_textbox.Size = new System.Drawing.Size(275, 33);
            this.UserName_textbox.TabIndex = 0;
            this.UserName_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_textbox.Font = new System.Drawing.Font("Tajawal", 10F);
            this.Password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_textbox.HintText = "كلمة المرور";
            this.Password_textbox.isPassword = false;
            this.Password_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.Password_textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.Password_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(192)))));
            this.Password_textbox.LineThickness = 3;
            this.Password_textbox.Location = new System.Drawing.Point(99, 159);
            this.Password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(275, 33);
            this.Password_textbox.TabIndex = 1;
            this.Password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_textbox.OnValueChanged += new System.EventHandler(this.Password_textbox_OnValueChanged);
            // 
            // Password_picturebox
            // 
            this.Password_picturebox.BackColor = System.Drawing.Color.White;
            this.Password_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password_picturebox.Image = global::Pharmacy_System.Properties.Resources.password_Blue;
            this.Password_picturebox.Location = new System.Drawing.Point(381, 159);
            this.Password_picturebox.Name = "Password_picturebox";
            this.Password_picturebox.Size = new System.Drawing.Size(33, 33);
            this.Password_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Password_picturebox.TabIndex = 27;
            this.Password_picturebox.TabStop = false;
            // 
            // UserName_picturebox
            // 
            this.UserName_picturebox.BackColor = System.Drawing.Color.White;
            this.UserName_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserName_picturebox.Image = global::Pharmacy_System.Properties.Resources.user_Blue;
            this.UserName_picturebox.Location = new System.Drawing.Point(381, 102);
            this.UserName_picturebox.Name = "UserName_picturebox";
            this.UserName_picturebox.Size = new System.Drawing.Size(33, 33);
            this.UserName_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserName_picturebox.TabIndex = 26;
            this.UserName_picturebox.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 308);
            this.Controls.Add(this.Password_picturebox);
            this.Controls.Add(this.UserName_picturebox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.UserName_textbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Forget_LinkLabel);
            this.Controls.Add(this.Login_Button);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Password_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.LinkLabel Forget_LinkLabel;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_textbox;
        private System.Windows.Forms.PictureBox UserName_picturebox;
        private System.Windows.Forms.PictureBox Password_picturebox;
    }
}