namespace Pharmacy_System
{
    partial class Form_MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MessageBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimaized_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimaized_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(561, 36);
            this.panel1.TabIndex = 60;
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title_Label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(328, 0);
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
            this.Title_pictureBox.Location = new System.Drawing.Point(524, 0);
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
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 187);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 64;
            // 
            // Form_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(561, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_MessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_MessageBox_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimaized_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private Bunifu.Framework.UI.BunifuImageButton Exit_Button;
        private Bunifu.Framework.UI.BunifuImageButton Minimaized_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}