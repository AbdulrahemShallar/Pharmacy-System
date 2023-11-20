namespace Pharmacy_System.UserControls
{
    partial class BackUpDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpDate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn__Create = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn__Create);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 206);
            this.panel1.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(662, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // btn__Create
            // 
            this.btn__Create.BackColor = System.Drawing.Color.Transparent;
            this.btn__Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn__Create.BackgroundImage")));
            this.btn__Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn__Create.FlatAppearance.BorderSize = 0;
            this.btn__Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn__Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn__Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__Create.Location = new System.Drawing.Point(320, 76);
            this.btn__Create.Name = "btn__Create";
            this.btn__Create.Size = new System.Drawing.Size(78, 75);
            this.btn__Create.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn__Create, "إنشاء نسخة إحتياطية للبيانات");
            this.btn__Create.UseVisualStyleBackColor = false;
            this.btn__Create.Click += new System.EventHandler(this.Btn__Create_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.Color.White;
            this.btn_Restore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Restore.BackgroundImage")));
            this.btn_Restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.ForeColor = System.Drawing.Color.White;
            this.btn_Restore.Location = new System.Drawing.Point(320, 251);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(78, 75);
            this.btn_Restore.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Restore, "إستعادة نسخة إحتياطية للبيانات");
            this.btn_Restore.UseVisualStyleBackColor = false;
            this.btn_Restore.Click += new System.EventHandler(this.Btn_Restore_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 209);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "النسخ الإحتياطي والإستعادة :";
            // 
            // BackUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.label1);
            this.Name = "BackUpDate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(700, 360);
            this.Load += new System.EventHandler(this.BackUpDate_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn__Create;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Label label1;
    }
}
