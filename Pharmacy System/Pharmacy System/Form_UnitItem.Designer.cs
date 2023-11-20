namespace Pharmacy_System
{
    partial class Form_UnitItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UnitItem));
            this.Name_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.NameValue_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IDValue_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimaized_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cansel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimaized_button)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Name_label.Location = new System.Drawing.Point(101, 144);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(175, 26);
            this.Name_label.TabIndex = 11;
            this.Name_label.Text = "الإسم :";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_label
            // 
            this.ID_label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.ID_label.Location = new System.Drawing.Point(101, 67);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(179, 26);
            this.ID_label.TabIndex = 10;
            this.ID_label.Text = "رقم المعرف :";
            this.ID_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameValue_Textbox
            // 
            this.NameValue_Textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.NameValue_Textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.NameValue_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.NameValue_Textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.NameValue_Textbox.BorderThickness = 3;
            this.NameValue_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameValue_Textbox.Font = new System.Drawing.Font("Tajawal", 10F);
            this.NameValue_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameValue_Textbox.isPassword = false;
            this.NameValue_Textbox.Location = new System.Drawing.Point(30, 174);
            this.NameValue_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.NameValue_Textbox.Name = "NameValue_Textbox";
            this.NameValue_Textbox.Size = new System.Drawing.Size(246, 38);
            this.NameValue_Textbox.TabIndex = 1;
            this.NameValue_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IDValue_Textbox
            // 
            this.IDValue_Textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.IDValue_Textbox.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.IDValue_Textbox.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.IDValue_Textbox.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.IDValue_Textbox.BorderThickness = 3;
            this.IDValue_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDValue_Textbox.Enabled = false;
            this.IDValue_Textbox.Font = new System.Drawing.Font("Tajawal", 10F);
            this.IDValue_Textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.IDValue_Textbox.isPassword = false;
            this.IDValue_Textbox.Location = new System.Drawing.Point(30, 97);
            this.IDValue_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.IDValue_Textbox.Name = "IDValue_Textbox";
            this.IDValue_Textbox.Size = new System.Drawing.Size(246, 38);
            this.IDValue_Textbox.TabIndex = 0;
            this.IDValue_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Controls.Add(this.Minimaized_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 38);
            this.panel1.TabIndex = 4;
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title_Label.Font = new System.Drawing.Font("Mudir MT", 10F);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(72, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(185, 38);
            this.Title_Label.TabIndex = 4;
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_Label.TextChanged += new System.EventHandler(this.Title_Label_TextChanged);
            // 
            // Title_pictureBox
            // 
            this.Title_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title_pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title_pictureBox.Location = new System.Drawing.Point(257, 0);
            this.Title_pictureBox.Name = "Title_pictureBox";
            this.Title_pictureBox.Size = new System.Drawing.Size(38, 38);
            this.Title_pictureBox.TabIndex = 7;
            this.Title_pictureBox.TabStop = false;
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.White;
            this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
            this.Exit_Button.ImageActive = null;
            this.Exit_Button.Location = new System.Drawing.Point(2, 5);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(29, 30);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Zoom = 10;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Minimaized_button
            // 
            this.Minimaized_button.BackColor = System.Drawing.Color.White;
            this.Minimaized_button.Image = ((System.Drawing.Image)(resources.GetObject("Minimaized_button.Image")));
            this.Minimaized_button.ImageActive = null;
            this.Minimaized_button.Location = new System.Drawing.Point(37, 5);
            this.Minimaized_button.Name = "Minimaized_button";
            this.Minimaized_button.Size = new System.Drawing.Size(29, 30);
            this.Minimaized_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimaized_button.TabIndex = 4;
            this.Minimaized_button.TabStop = false;
            this.Minimaized_button.Zoom = 10;
            this.Minimaized_button.Click += new System.EventHandler(this.Minimaized_button_Click);
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
            this.Cansel_button.Location = new System.Drawing.Point(35, 235);
            this.Cansel_button.Name = "Cansel_button";
            this.Cansel_button.Size = new System.Drawing.Size(107, 47);
            this.Cansel_button.TabIndex = 3;
            this.Cansel_button.Text = "إلغاء";
            this.Cansel_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cansel_button.UseVisualStyleBackColor = false;
            this.Cansel_button.Click += new System.EventHandler(this.Cansel_button_Click);
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
            this.Save_button.Location = new System.Drawing.Point(145, 235);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(107, 47);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "حفظ";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.Save_button;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.Cansel_button;
            // 
            // Form_UnitItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(295, 299);
            this.Controls.Add(this.Cansel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.NameValue_Textbox);
            this.Controls.Add(this.IDValue_Textbox);
            this.Font = new System.Drawing.Font("Mudir MT", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_UnitItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UnitItem";
            this.Load += new System.EventHandler(this.Form_UnitItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimaized_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ID_label;
        private Bunifu.Framework.UI.BunifuMetroTextbox NameValue_Textbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox IDValue_Textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private Bunifu.Framework.UI.BunifuImageButton Exit_Button;
        private Bunifu.Framework.UI.BunifuImageButton Minimaized_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cansel_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}