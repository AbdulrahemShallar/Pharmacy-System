namespace Pharmacy_System.UserControls
{
    partial class Get_ID
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
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Cansole = new System.Windows.Forms.Button();
            this.btn_Serch = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lbl_Title1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Title1.Location = new System.Drawing.Point(281, 95);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(207, 23);
            this.lbl_Title1.TabIndex = 11;
            this.lbl_Title1.Text = "أدخل رقم الموظف :";
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Close.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Close.Location = new System.Drawing.Point(457, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // btn_Cansole
            // 
            this.btn_Cansole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btn_Cansole.FlatAppearance.BorderSize = 0;
            this.btn_Cansole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cansole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cansole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btn_Cansole.Location = new System.Drawing.Point(0, 204);
            this.btn_Cansole.Name = "btn_Cansole";
            this.btn_Cansole.Size = new System.Drawing.Size(245, 56);
            this.btn_Cansole.TabIndex = 9;
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
            this.btn_Serch.Location = new System.Drawing.Point(245, 204);
            this.btn_Serch.Name = "btn_Serch";
            this.btn_Serch.Size = new System.Drawing.Size(245, 56);
            this.btn_Serch.TabIndex = 8;
            this.btn_Serch.Text = "&بحث";
            this.btn_Serch.UseVisualStyleBackColor = false;
            this.btn_Serch.Click += new System.EventHandler(this.Btn_Serch_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Id.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Id.Location = new System.Drawing.Point(51, 90);
            this.txt_Id.MaxLength = 50;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(224, 32);
            this.txt_Id.TabIndex = 7;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // Get_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Title1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Cansole);
            this.Controls.Add(this.btn_Serch);
            this.Controls.Add(this.txt_Id);
            this.Name = "Get_ID";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(490, 259);
            this.Load += new System.EventHandler(this.Get_ID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Cansole;
        private System.Windows.Forms.Button btn_Serch;
        public System.Windows.Forms.TextBox txt_Id;
        public System.Windows.Forms.Label lbl_Title1;
    }
}
