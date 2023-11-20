namespace Pharmacy_System.Report
{
    partial class UserControl_Account_balances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Account_balances));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TotalMastPay_label = new System.Windows.Forms.Label();
            this.textTotalMastPay_label = new System.Windows.Forms.Label();
            this.TotalNeed_label = new System.Windows.Forms.Label();
            this.textTotalNeed_label = new System.Windows.Forms.Label();
            this.AccuntType_comboBox = new System.Windows.Forms.ComboBox();
            this.AccuntType_label = new System.Windows.Forms.Label();
            this.AccuntName_label = new System.Windows.Forms.Label();
            this.AccuntName_comboBox = new System.Windows.Forms.ComboBox();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalMastPay_label
            // 
            this.TotalMastPay_label.BackColor = System.Drawing.Color.White;
            this.TotalMastPay_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMastPay_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMastPay_label.Location = new System.Drawing.Point(463, 48);
            this.TotalMastPay_label.Name = "TotalMastPay_label";
            this.TotalMastPay_label.Size = new System.Drawing.Size(128, 23);
            this.TotalMastPay_label.TabIndex = 95;
            this.TotalMastPay_label.Text = "0";
            // 
            // textTotalMastPay_label
            // 
            this.textTotalMastPay_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalMastPay_label.Location = new System.Drawing.Point(597, 49);
            this.textTotalMastPay_label.Name = "textTotalMastPay_label";
            this.textTotalMastPay_label.Size = new System.Drawing.Size(111, 23);
            this.textTotalMastPay_label.TabIndex = 94;
            this.textTotalMastPay_label.Text = "مجموع دائن :";
            // 
            // TotalNeed_label
            // 
            this.TotalNeed_label.BackColor = System.Drawing.Color.White;
            this.TotalNeed_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalNeed_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNeed_label.Location = new System.Drawing.Point(714, 48);
            this.TotalNeed_label.Name = "TotalNeed_label";
            this.TotalNeed_label.Size = new System.Drawing.Size(128, 23);
            this.TotalNeed_label.TabIndex = 93;
            this.TotalNeed_label.Text = "0";
            // 
            // textTotalNeed_label
            // 
            this.textTotalNeed_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalNeed_label.Location = new System.Drawing.Point(848, 51);
            this.textTotalNeed_label.Name = "textTotalNeed_label";
            this.textTotalNeed_label.Size = new System.Drawing.Size(111, 23);
            this.textTotalNeed_label.TabIndex = 92;
            this.textTotalNeed_label.Text = "مجموع مدين:";
            // 
            // AccuntType_comboBox
            // 
            this.AccuntType_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AccuntType_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AccuntType_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuntType_comboBox.FormattingEnabled = true;
            this.AccuntType_comboBox.Items.AddRange(new object[] {
            "مورد",
            "زبون",
            "حساب مرجعي"});
            this.AccuntType_comboBox.Location = new System.Drawing.Point(313, 5);
            this.AccuntType_comboBox.Name = "AccuntType_comboBox";
            this.AccuntType_comboBox.Size = new System.Drawing.Size(203, 26);
            this.AccuntType_comboBox.TabIndex = 91;
            this.AccuntType_comboBox.TextChanged += new System.EventHandler(this.CompoBox_TextChange);
            // 
            // AccuntType_label
            // 
            this.AccuntType_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuntType_label.Location = new System.Drawing.Point(522, 6);
            this.AccuntType_label.Name = "AccuntType_label";
            this.AccuntType_label.Size = new System.Drawing.Size(124, 23);
            this.AccuntType_label.TabIndex = 90;
            this.AccuntType_label.Text = "نوع الحساب :";
            // 
            // AccuntName_label
            // 
            this.AccuntName_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuntName_label.Location = new System.Drawing.Point(861, 7);
            this.AccuntName_label.Name = "AccuntName_label";
            this.AccuntName_label.Size = new System.Drawing.Size(100, 23);
            this.AccuntName_label.TabIndex = 89;
            this.AccuntName_label.Text = "الحساب :";
            // 
            // AccuntName_comboBox
            // 
            this.AccuntName_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AccuntName_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AccuntName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuntName_comboBox.FormattingEnabled = true;
            this.AccuntName_comboBox.Location = new System.Drawing.Point(652, 5);
            this.AccuntName_comboBox.Name = "AccuntName_comboBox";
            this.AccuntName_comboBox.Size = new System.Drawing.Size(203, 26);
            this.AccuntName_comboBox.TabIndex = 88;
            this.AccuntName_comboBox.TextChanged += new System.EventHandler(this.CompoBox_TextChange);
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(252, 2);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 86;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(211, 2);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 85;
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Show_dataGridView
            // 
            this.Show_dataGridView.AllowUserToAddRows = false;
            this.Show_dataGridView.AllowUserToDeleteRows = false;
            this.Show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Show_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Show_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.Show_dataGridView.Location = new System.Drawing.Point(3, 91);
            this.Show_dataGridView.Name = "Show_dataGridView";
            this.Show_dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Show_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Show_dataGridView.Size = new System.Drawing.Size(954, 452);
            this.Show_dataGridView.TabIndex = 87;
            this.Show_dataGridView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Controls.Add(this.AccuntName_label);
            this.panel1.Controls.Add(this.AccuntName_comboBox);
            this.panel1.Controls.Add(this.AccuntType_label);
            this.panel1.Controls.Add(this.AccuntType_comboBox);
            this.panel1.Controls.Add(this.Print_Button);
            this.panel1.Controls.Add(this.Refresh_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 36);
            this.panel1.TabIndex = 84;
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title_Label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(37, 0);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(167, 36);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.Text = "ارصدة الحسابات";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title_pictureBox
            // 
            this.Title_pictureBox.BackgroundImage = global::Pharmacy_System.Properties.Resources.Edit_Sales;
            this.Title_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title_pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Title_pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Title_pictureBox.Name = "Title_pictureBox";
            this.Title_pictureBox.Size = new System.Drawing.Size(37, 36);
            this.Title_pictureBox.TabIndex = 7;
            this.Title_pictureBox.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // UserControl_Account_balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalMastPay_label);
            this.Controls.Add(this.textTotalMastPay_label);
            this.Controls.Add(this.TotalNeed_label);
            this.Controls.Add(this.textTotalNeed_label);
            this.Controls.Add(this.Show_dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Account_balances";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Account_balances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TotalMastPay_label;
        private System.Windows.Forms.Label textTotalMastPay_label;
        private System.Windows.Forms.Label TotalNeed_label;
        private System.Windows.Forms.Label textTotalNeed_label;
        private System.Windows.Forms.ComboBox AccuntType_comboBox;
        private System.Windows.Forms.Label AccuntType_label;
        private System.Windows.Forms.Label AccuntName_label;
        private System.Windows.Forms.ComboBox AccuntName_comboBox;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
