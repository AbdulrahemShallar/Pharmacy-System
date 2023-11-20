namespace Pharmacy_System
{
    partial class Form_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Store));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimaized_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.StoreName_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.StoreNameValue_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IDValue_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Note_label = new System.Windows.Forms.Label();
            this.NoteValue_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Cansel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimaized_button)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 36);
            this.panel1.TabIndex = 8;
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title_Label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(86, 0);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(196, 36);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title_pictureBox
            // 
            this.Title_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title_pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title_pictureBox.Location = new System.Drawing.Point(282, 0);
            this.Title_pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Title_pictureBox.Name = "Title_pictureBox";
            this.Title_pictureBox.Size = new System.Drawing.Size(37, 36);
            this.Title_pictureBox.TabIndex = 7;
            this.Title_pictureBox.TabStop = false;
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.White;
            this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
            this.Exit_Button.ImageActive = null;
            this.Exit_Button.Location = new System.Drawing.Point(3, 4);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(28, 28);
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
            this.Minimaized_button.Location = new System.Drawing.Point(36, 4);
            this.Minimaized_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Minimaized_button.Name = "Minimaized_button";
            this.Minimaized_button.Size = new System.Drawing.Size(28, 28);
            this.Minimaized_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimaized_button.TabIndex = 4;
            this.Minimaized_button.TabStop = false;
            this.Minimaized_button.Zoom = 10;
            this.Minimaized_button.Click += new System.EventHandler(this.Minimaized_button_Click);
            // 
            // StoreName_label
            // 
            this.StoreName_label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.StoreName_label.Location = new System.Drawing.Point(58, 121);
            this.StoreName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreName_label.Name = "StoreName_label";
            this.StoreName_label.Size = new System.Drawing.Size(193, 24);
            this.StoreName_label.TabIndex = 23;
            this.StoreName_label.Text = "اسم المستودع :";
            this.StoreName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_label
            // 
            this.ID_label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.ID_label.Location = new System.Drawing.Point(58, 54);
            this.ID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(193, 24);
            this.ID_label.TabIndex = 22;
            this.ID_label.Text = "رقم المعرف :";
            this.ID_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StoreNameValue_Textbox
            // 
            this.StoreNameValue_Textbox.AllowDrop = true;
            this.StoreNameValue_Textbox.AutoScroll = true;
            this.StoreNameValue_Textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.StoreNameValue_Textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.StoreNameValue_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.StoreNameValue_Textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.StoreNameValue_Textbox.BorderThickness = 3;
            this.StoreNameValue_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StoreNameValue_Textbox.Font = new System.Drawing.Font("Tajawal", 11F);
            this.StoreNameValue_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StoreNameValue_Textbox.isPassword = false;
            this.StoreNameValue_Textbox.Location = new System.Drawing.Point(58, 149);
            this.StoreNameValue_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.StoreNameValue_Textbox.Name = "StoreNameValue_Textbox";
            this.StoreNameValue_Textbox.Size = new System.Drawing.Size(193, 35);
            this.StoreNameValue_Textbox.TabIndex = 1;
            this.StoreNameValue_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.IDValue_Textbox.Font = new System.Drawing.Font("Tajawal", 11F);
            this.IDValue_Textbox.ForeColor = System.Drawing.Color.Black;
            this.IDValue_Textbox.isPassword = false;
            this.IDValue_Textbox.Location = new System.Drawing.Point(58, 82);
            this.IDValue_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.IDValue_Textbox.Name = "IDValue_Textbox";
            this.IDValue_Textbox.Size = new System.Drawing.Size(193, 35);
            this.IDValue_Textbox.TabIndex = 0;
            this.IDValue_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Note_label
            // 
            this.Note_label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Note_label.Location = new System.Drawing.Point(58, 188);
            this.Note_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Note_label.Name = "Note_label";
            this.Note_label.Size = new System.Drawing.Size(193, 24);
            this.Note_label.TabIndex = 25;
            this.Note_label.Text = "ملاحظة : ";
            this.Note_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoteValue_Textbox
            // 
            this.NoteValue_Textbox.AllowDrop = true;
            this.NoteValue_Textbox.AutoScroll = true;
            this.NoteValue_Textbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.NoteValue_Textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.NoteValue_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.NoteValue_Textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.NoteValue_Textbox.BorderThickness = 3;
            this.NoteValue_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoteValue_Textbox.Font = new System.Drawing.Font("Tajawal", 11F);
            this.NoteValue_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoteValue_Textbox.isPassword = false;
            this.NoteValue_Textbox.Location = new System.Drawing.Point(58, 216);
            this.NoteValue_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteValue_Textbox.Name = "NoteValue_Textbox";
            this.NoteValue_Textbox.Size = new System.Drawing.Size(193, 35);
            this.NoteValue_Textbox.TabIndex = 2;
            this.NoteValue_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Cansel_button.Location = new System.Drawing.Point(34, 282);
            this.Cansel_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cansel_button.Name = "Cansel_button";
            this.Cansel_button.Size = new System.Drawing.Size(108, 45);
            this.Cansel_button.TabIndex = 4;
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
            this.Save_button.Location = new System.Drawing.Point(143, 282);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(108, 45);
            this.Save_button.TabIndex = 3;
            this.Save_button.Text = "حفظ";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.Cansel_button;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.Save_button;
            // 
            // Form_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 335);
            this.Controls.Add(this.Cansel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Note_label);
            this.Controls.Add(this.NoteValue_Textbox);
            this.Controls.Add(this.StoreName_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.StoreNameValue_Textbox);
            this.Controls.Add(this.IDValue_Textbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tajawal Light", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Store";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Store";
            this.Load += new System.EventHandler(this.Form_Store_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimaized_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private Bunifu.Framework.UI.BunifuImageButton Exit_Button;
        private Bunifu.Framework.UI.BunifuImageButton Minimaized_button;
        private System.Windows.Forms.Label StoreName_label;
        private System.Windows.Forms.Label ID_label;
        private Bunifu.Framework.UI.BunifuMetroTextbox StoreNameValue_Textbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox IDValue_Textbox;
        private System.Windows.Forms.Label Note_label;
        private Bunifu.Framework.UI.BunifuMetroTextbox NoteValue_Textbox;
        private System.Windows.Forms.Button Cansel_button;
        private System.Windows.Forms.Button Save_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}