namespace Pharmacy_System.UserControls
{
    partial class Get_User
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.btn_Cansole = new System.Windows.Forms.Button();
            this.btn_Serch = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.cb_UserType = new System.Windows.Forms.ComboBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Close.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Close.Location = new System.Drawing.Point(461, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 51;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.AutoSize = true;
            this.lbl_Title1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbl_Title1.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Title1.Location = new System.Drawing.Point(335, 30);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(144, 23);
            this.lbl_Title1.TabIndex = 55;
            this.lbl_Title1.Text = "بحث عن موظف :";
            // 
            // btn_Cansole
            // 
            this.btn_Cansole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btn_Cansole.FlatAppearance.BorderSize = 0;
            this.btn_Cansole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cansole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cansole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btn_Cansole.Location = new System.Drawing.Point(0, 202);
            this.btn_Cansole.Name = "btn_Cansole";
            this.btn_Cansole.Size = new System.Drawing.Size(245, 56);
            this.btn_Cansole.TabIndex = 50;
            this.btn_Cansole.Text = "&إلغاء";
            this.btn_Cansole.UseVisualStyleBackColor = false;
            this.btn_Cansole.Click += new System.EventHandler(this.Btn_Cansole_Click);
            // 
            // btn_Serch
            // 
            this.btn_Serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(186)))), ((int)(((byte)(24)))));
            this.btn_Serch.FlatAppearance.BorderSize = 0;
            this.btn_Serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Serch.ForeColor = System.Drawing.Color.White;
            this.btn_Serch.Location = new System.Drawing.Point(245, 202);
            this.btn_Serch.Name = "btn_Serch";
            this.btn_Serch.Size = new System.Drawing.Size(245, 56);
            this.btn_Serch.TabIndex = 49;
            this.btn_Serch.Text = "&بحث";
            this.btn_Serch.UseVisualStyleBackColor = false;
            this.btn_Serch.Click += new System.EventHandler(this.Btn_Serch_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(321, 148);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 19);
            this.lbl_Password.TabIndex = 52;
            this.lbl_Password.Text = "كلمة المرور :";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_UserName.ForeColor = System.Drawing.Color.Black;
            this.lbl_UserName.Location = new System.Drawing.Point(357, 112);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(61, 19);
            this.lbl_UserName.TabIndex = 53;
            this.lbl_UserName.Text = "الإسم :";
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_UserType.ForeColor = System.Drawing.Color.Black;
            this.lbl_UserType.Location = new System.Drawing.Point(301, 77);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(117, 19);
            this.lbl_UserType.TabIndex = 54;
            this.lbl_UserType.Text = "نوع المستخدم :";
            // 
            // cb_UserType
            // 
            this.cb_UserType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cb_UserType.ForeColor = System.Drawing.Color.DimGray;
            this.cb_UserType.FormattingEnabled = true;
            this.cb_UserType.Items.AddRange(new object[] {
            "مدير",
            "موظف"});
            this.cb_UserType.Location = new System.Drawing.Point(79, 69);
            this.cb_UserType.MaxLength = 50;
            this.cb_UserType.Name = "cb_UserType";
            this.cb_UserType.Size = new System.Drawing.Size(201, 27);
            this.cb_UserType.TabIndex = 46;
            this.cb_UserType.Text = "موظف";
            this.cb_UserType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Box_KeyPress);
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_UserName.ForeColor = System.Drawing.Color.DimGray;
            this.txt_UserName.Location = new System.Drawing.Point(79, 106);
            this.txt_UserName.MaxLength = 50;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(201, 27);
            this.txt_UserName.TabIndex = 47;
            this.txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Box_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Password.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Password.Location = new System.Drawing.Point(79, 142);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(201, 27);
            this.txt_Password.TabIndex = 48;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Box_KeyPress);
            // 
            // Get_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Title1);
            this.Controls.Add(this.btn_Cansole);
            this.Controls.Add(this.btn_Serch);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.cb_UserType);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Password);
            this.Name = "Get_User";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(490, 259);
            this.Load += new System.EventHandler(this.Get_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.Button btn_Cansole;
        private System.Windows.Forms.Button btn_Serch;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.ComboBox cb_UserType;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
    }
}
