namespace Pharmacy_System.Report
{
    partial class UserControl_Account_statement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Account_statement));
            this.Total_label = new System.Windows.Forms.Label();
            this.textTotal_label = new System.Windows.Forms.Label();
            this.TotalMastPay_label = new System.Windows.Forms.Label();
            this.textTotalMastPay_label = new System.Windows.Forms.Label();
            this.TotalNeed_label = new System.Windows.Forms.Label();
            this.textTotalNeed_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sersh_button = new System.Windows.Forms.Button();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.AccuntName_label = new System.Windows.Forms.Label();
            this.AccuntName_comboBox = new System.Windows.Forms.ComboBox();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.EnabelDate_checkBox = new System.Windows.Forms.CheckBox();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_label = new System.Windows.Forms.Label();
            this.From_label = new System.Windows.Forms.Label();
            this.Statment_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROV_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rest_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resolved_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payed_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceType_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefType_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymantMethod_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToAccount_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumber_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperType_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Total_label
            // 
            this.Total_label.BackColor = System.Drawing.Color.White;
            this.Total_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(714, 115);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(128, 26);
            this.Total_label.TabIndex = 105;
            this.Total_label.Text = "0";
            // 
            // textTotal_label
            // 
            this.textTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal_label.Location = new System.Drawing.Point(848, 117);
            this.textTotal_label.Name = "textTotal_label";
            this.textTotal_label.Size = new System.Drawing.Size(111, 27);
            this.textTotal_label.TabIndex = 104;
            this.textTotal_label.Text = "الرصيد الحالي:";
            // 
            // TotalMastPay_label
            // 
            this.TotalMastPay_label.BackColor = System.Drawing.Color.White;
            this.TotalMastPay_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMastPay_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMastPay_label.Location = new System.Drawing.Point(714, 80);
            this.TotalMastPay_label.Name = "TotalMastPay_label";
            this.TotalMastPay_label.Size = new System.Drawing.Size(128, 26);
            this.TotalMastPay_label.TabIndex = 103;
            this.TotalMastPay_label.Text = "0";
            // 
            // textTotalMastPay_label
            // 
            this.textTotalMastPay_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalMastPay_label.Location = new System.Drawing.Point(848, 81);
            this.textTotalMastPay_label.Name = "textTotalMastPay_label";
            this.textTotalMastPay_label.Size = new System.Drawing.Size(111, 27);
            this.textTotalMastPay_label.TabIndex = 102;
            this.textTotalMastPay_label.Text = "مجموع دائن :";
            // 
            // TotalNeed_label
            // 
            this.TotalNeed_label.BackColor = System.Drawing.Color.White;
            this.TotalNeed_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalNeed_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNeed_label.Location = new System.Drawing.Point(714, 45);
            this.TotalNeed_label.Name = "TotalNeed_label";
            this.TotalNeed_label.Size = new System.Drawing.Size(128, 26);
            this.TotalNeed_label.TabIndex = 101;
            this.TotalNeed_label.Text = "0";
            // 
            // textTotalNeed_label
            // 
            this.textTotalNeed_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalNeed_label.Location = new System.Drawing.Point(848, 45);
            this.textTotalNeed_label.Name = "textTotalNeed_label";
            this.textTotalNeed_label.Size = new System.Drawing.Size(111, 27);
            this.textTotalNeed_label.TabIndex = 100;
            this.textTotalNeed_label.Text = "مجووع مدين:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Sersh_button);
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Controls.Add(this.AccuntName_label);
            this.panel1.Controls.Add(this.AccuntName_comboBox);
            this.panel1.Controls.Add(this.Print_Button);
            this.panel1.Controls.Add(this.Refresh_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 42);
            this.panel1.TabIndex = 98;
            // 
            // Sersh_button
            // 
            this.Sersh_button.BackgroundImage = global::Pharmacy_System.Properties.Resources.search;
            this.Sersh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sersh_button.FlatAppearance.BorderSize = 0;
            this.Sersh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sersh_button.Location = new System.Drawing.Point(511, 2);
            this.Sersh_button.Name = "Sersh_button";
            this.Sersh_button.Size = new System.Drawing.Size(35, 39);
            this.Sersh_button.TabIndex = 111;
            this.Sersh_button.UseVisualStyleBackColor = true;
            this.Sersh_button.Click += new System.EventHandler(this.Sersh_button_Click);
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title_Label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(37, 0);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(167, 42);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.Text = "كشف حساب";
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
            this.Title_pictureBox.Size = new System.Drawing.Size(37, 42);
            this.Title_pictureBox.TabIndex = 7;
            this.Title_pictureBox.TabStop = false;
            // 
            // AccuntName_label
            // 
            this.AccuntName_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuntName_label.Location = new System.Drawing.Point(861, 8);
            this.AccuntName_label.Name = "AccuntName_label";
            this.AccuntName_label.Size = new System.Drawing.Size(100, 27);
            this.AccuntName_label.TabIndex = 89;
            this.AccuntName_label.Text = "الحساب :";
            // 
            // AccuntName_comboBox
            // 
            this.AccuntName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuntName_comboBox.FormattingEnabled = true;
            this.AccuntName_comboBox.Location = new System.Drawing.Point(563, 6);
            this.AccuntName_comboBox.Name = "AccuntName_comboBox";
            this.AccuntName_comboBox.Size = new System.Drawing.Size(292, 26);
            this.AccuntName_comboBox.TabIndex = 88;
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(252, 2);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 39);
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
            this.Refresh_Button.Size = new System.Drawing.Size(35, 39);
            this.Refresh_Button.TabIndex = 85;
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // EnabelDate_checkBox
            // 
            this.EnabelDate_checkBox.AutoSize = true;
            this.EnabelDate_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabelDate_checkBox.Location = new System.Drawing.Point(386, 122);
            this.EnabelDate_checkBox.Name = "EnabelDate_checkBox";
            this.EnabelDate_checkBox.Size = new System.Drawing.Size(181, 22);
            this.EnabelDate_checkBox.TabIndex = 110;
            this.EnabelDate_checkBox.Text = "تفعيل البحث عن طريق التاريخ";
            this.EnabelDate_checkBox.UseVisualStyleBackColor = true;
            this.EnabelDate_checkBox.CheckedChanged += new System.EventHandler(this.EnabelDate_checkBox_CheckedChanged);
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Enabled = false;
            this.To_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_dateTimePicker.Location = new System.Drawing.Point(367, 85);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.To_dateTimePicker.TabIndex = 108;
            this.To_dateTimePicker.ValueChanged += new System.EventHandler(this.Sersh_button_Click);
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Enabled = false;
            this.From_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_dateTimePicker.Location = new System.Drawing.Point(367, 48);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.From_dateTimePicker.TabIndex = 109;
            this.From_dateTimePicker.ValueChanged += new System.EventHandler(this.Sersh_button_Click);
            // 
            // To_label
            // 
            this.To_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.Location = new System.Drawing.Point(573, 81);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(93, 30);
            this.To_label.TabIndex = 106;
            this.To_label.Text = "إلى :";
            // 
            // From_label
            // 
            this.From_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(573, 53);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(93, 30);
            this.From_label.TabIndex = 107;
            this.From_label.Text = "من :";
            // 
            // Statment_Column
            // 
            this.Statment_Column.HeaderText = "البيان";
            this.Statment_Column.Name = "Statment_Column";
            this.Statment_Column.ReadOnly = true;
            this.Statment_Column.Width = 56;
            // 
            // ROV_Column
            // 
            this.ROV_Column.HeaderText = "الرصيد";
            this.ROV_Column.Name = "ROV_Column";
            this.ROV_Column.ReadOnly = true;
            this.ROV_Column.Width = 62;
            // 
            // Rest_Column
            // 
            this.Rest_Column.HeaderText = "الباقي";
            this.Rest_Column.Name = "Rest_Column";
            this.Rest_Column.ReadOnly = true;
            this.Rest_Column.Width = 58;
            // 
            // Resolved_Column
            // 
            this.Resolved_Column.HeaderText = "الحسم";
            this.Resolved_Column.Name = "Resolved_Column";
            this.Resolved_Column.ReadOnly = true;
            this.Resolved_Column.Width = 63;
            // 
            // Payed_Column
            // 
            this.Payed_Column.HeaderText = "المدفوع";
            this.Payed_Column.Name = "Payed_Column";
            this.Payed_Column.ReadOnly = true;
            this.Payed_Column.Width = 69;
            // 
            // Value_Column
            // 
            this.Value_Column.HeaderText = "القيمة";
            this.Value_Column.Name = "Value_Column";
            this.Value_Column.ReadOnly = true;
            this.Value_Column.Width = 61;
            // 
            // InvoiceType_Column
            // 
            this.InvoiceType_Column.HeaderText = "نوع الفاتورة";
            this.InvoiceType_Column.Name = "InvoiceType_Column";
            this.InvoiceType_Column.ReadOnly = true;
            this.InvoiceType_Column.Width = 83;
            // 
            // RefType_Column
            // 
            this.RefType_Column.HeaderText = "نوع الوصل";
            this.RefType_Column.Name = "RefType_Column";
            this.RefType_Column.ReadOnly = true;
            this.RefType_Column.Width = 80;
            // 
            // PaymantMethod_Column
            // 
            this.PaymantMethod_Column.HeaderText = "طريقة الدفع";
            this.PaymantMethod_Column.Name = "PaymantMethod_Column";
            this.PaymantMethod_Column.ReadOnly = true;
            this.PaymantMethod_Column.Width = 88;
            // 
            // ToAccount_Column
            // 
            this.ToAccount_Column.HeaderText = "إلى حساب";
            this.ToAccount_Column.Name = "ToAccount_Column";
            this.ToAccount_Column.ReadOnly = true;
            this.ToAccount_Column.Width = 78;
            // 
            // ItemNumber_Column
            // 
            this.ItemNumber_Column.HeaderText = "عدد البنود";
            this.ItemNumber_Column.Name = "ItemNumber_Column";
            this.ItemNumber_Column.ReadOnly = true;
            this.ItemNumber_Column.Width = 77;
            // 
            // OperType_Column
            // 
            this.OperType_Column.HeaderText = "نوع العملية";
            this.OperType_Column.Name = "OperType_Column";
            this.OperType_Column.ReadOnly = true;
            this.OperType_Column.Width = 85;
            // 
            // Reference_Column
            // 
            this.Reference_Column.HeaderText = "رقم مرجعي";
            this.Reference_Column.Name = "Reference_Column";
            this.Reference_Column.ReadOnly = true;
            this.Reference_Column.Width = 82;
            // 
            // Date_Column
            // 
            this.Date_Column.HeaderText = "التاريخ";
            this.Date_Column.Name = "Date_Column";
            this.Date_Column.ReadOnly = true;
            this.Date_Column.Width = 59;
            // 
            // Show_dataGridView
            // 
            this.Show_dataGridView.AllowUserToAddRows = false;
            this.Show_dataGridView.AllowUserToDeleteRows = false;
            this.Show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Show_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Column,
            this.Reference_Column,
            this.OperType_Column,
            this.ItemNumber_Column,
            this.ToAccount_Column,
            this.PaymantMethod_Column,
            this.RefType_Column,
            this.InvoiceType_Column,
            this.Value_Column,
            this.Payed_Column,
            this.Resolved_Column,
            this.Rest_Column,
            this.ROV_Column,
            this.Statment_Column});
            this.Show_dataGridView.Location = new System.Drawing.Point(3, 149);
            this.Show_dataGridView.Name = "Show_dataGridView";
            this.Show_dataGridView.ReadOnly = true;
            this.Show_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Show_dataGridView.Size = new System.Drawing.Size(954, 391);
            this.Show_dataGridView.TabIndex = 99;
            this.Show_dataGridView.TabStop = false;
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
            // UserControl_Account_statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnabelDate_checkBox);
            this.Controls.Add(this.To_dateTimePicker);
            this.Controls.Add(this.From_dateTimePicker);
            this.Controls.Add(this.To_label);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.textTotal_label);
            this.Controls.Add(this.TotalMastPay_label);
            this.Controls.Add(this.textTotalMastPay_label);
            this.Controls.Add(this.TotalNeed_label);
            this.Controls.Add(this.textTotalNeed_label);
            this.Controls.Add(this.Show_dataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl_Account_statement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 629);
            this.Load += new System.EventHandler(this.UserControl_Account_statement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Label textTotal_label;
        private System.Windows.Forms.Label TotalMastPay_label;
        private System.Windows.Forms.Label textTotalMastPay_label;
        private System.Windows.Forms.Label TotalNeed_label;
        private System.Windows.Forms.Label textTotalNeed_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.Label AccuntName_label;
        private System.Windows.Forms.ComboBox AccuntName_comboBox;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.CheckBox EnabelDate_checkBox;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statment_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROV_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rest_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resolved_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payed_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceType_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefType_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymantMethod_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToAccount_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperType_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Column;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.Button Sersh_button;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
