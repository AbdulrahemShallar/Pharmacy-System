namespace Pharmacy_System.Report
{
    partial class UserControl_Profit_and_loss
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Profit_and_loss));
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_label = new System.Windows.Forms.Label();
            this.From_label = new System.Windows.Forms.Label();
            this.ItemName_label = new System.Windows.Forms.Label();
            this.ItemName_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReturnSeles_checkBox = new System.Windows.Forms.CheckBox();
            this.ReturnBuy_checkBox = new System.Windows.Forms.CheckBox();
            this.Seles_checkBox = new System.Windows.Forms.CheckBox();
            this.Buy_checkBox = new System.Windows.Forms.CheckBox();
            this.EnabelDate_checkBox = new System.Windows.Forms.CheckBox();
            this.Total_label = new System.Windows.Forms.Label();
            this.textTotal_label = new System.Windows.Forms.Label();
            this.Loss_label = new System.Windows.Forms.Label();
            this.textLoss_label = new System.Windows.Forms.Label();
            this.Gain_label = new System.Windows.Forms.Label();
            this.textGain_label = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Enabled = false;
            this.To_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_dateTimePicker.Location = new System.Drawing.Point(421, 80);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.To_dateTimePicker.TabIndex = 65;
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Enabled = false;
            this.From_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_dateTimePicker.Location = new System.Drawing.Point(421, 46);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.From_dateTimePicker.TabIndex = 66;
            // 
            // To_label
            // 
            this.To_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.Location = new System.Drawing.Point(627, 80);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(93, 26);
            this.To_label.TabIndex = 63;
            this.To_label.Text = "إلى :";
            // 
            // From_label
            // 
            this.From_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(627, 46);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(93, 26);
            this.From_label.TabIndex = 64;
            this.From_label.Text = "من :";
            // 
            // ItemName_label
            // 
            this.ItemName_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_label.Location = new System.Drawing.Point(854, 6);
            this.ItemName_label.Name = "ItemName_label";
            this.ItemName_label.Size = new System.Drawing.Size(100, 23);
            this.ItemName_label.TabIndex = 62;
            this.ItemName_label.Text = "اسم المادة :";
            // 
            // ItemName_comboBox
            // 
            this.ItemName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_comboBox.FormattingEnabled = true;
            this.ItemName_comboBox.Location = new System.Drawing.Point(552, 3);
            this.ItemName_comboBox.Name = "ItemName_comboBox";
            this.ItemName_comboBox.Size = new System.Drawing.Size(296, 26);
            this.ItemName_comboBox.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Controls.Add(this.ItemName_comboBox);
            this.panel1.Controls.Add(this.ItemName_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 36);
            this.panel1.TabIndex = 60;
            // 
            // Title_Label
            // 
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title_Label.Font = new System.Drawing.Font("Tajawal", 11F);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(37, 0);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(196, 36);
            this.Title_Label.TabIndex = 8;
            this.Title_Label.Text = "ارباح وخسائر";
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
            // Show_dataGridView
            // 
            this.Show_dataGridView.AllowUserToAddRows = false;
            this.Show_dataGridView.AllowUserToDeleteRows = false;
            this.Show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Show_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Show_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.Show_dataGridView.Location = new System.Drawing.Point(6, 141);
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
            this.Show_dataGridView.Size = new System.Drawing.Size(954, 400);
            this.Show_dataGridView.TabIndex = 59;
            this.Show_dataGridView.TabStop = false;
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(6, 86);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 58;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(6, 46);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 57;
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReturnSeles_checkBox);
            this.groupBox1.Controls.Add(this.ReturnBuy_checkBox);
            this.groupBox1.Controls.Add(this.Seles_checkBox);
            this.groupBox1.Controls.Add(this.Buy_checkBox);
            this.groupBox1.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(750, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 96);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع الفاتورة";
            // 
            // ReturnSeles_checkBox
            // 
            this.ReturnSeles_checkBox.AutoSize = true;
            this.ReturnSeles_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnSeles_checkBox.Location = new System.Drawing.Point(13, 53);
            this.ReturnSeles_checkBox.Name = "ReturnSeles_checkBox";
            this.ReturnSeles_checkBox.Size = new System.Drawing.Size(87, 22);
            this.ReturnSeles_checkBox.TabIndex = 87;
            this.ReturnSeles_checkBox.Text = "مرتجع مبيع";
            this.ReturnSeles_checkBox.UseVisualStyleBackColor = true;
            this.ReturnSeles_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ReturnBuy_checkBox
            // 
            this.ReturnBuy_checkBox.AutoSize = true;
            this.ReturnBuy_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBuy_checkBox.Location = new System.Drawing.Point(111, 53);
            this.ReturnBuy_checkBox.Name = "ReturnBuy_checkBox";
            this.ReturnBuy_checkBox.Size = new System.Drawing.Size(91, 22);
            this.ReturnBuy_checkBox.TabIndex = 86;
            this.ReturnBuy_checkBox.Text = "مرتجع شراء";
            this.ReturnBuy_checkBox.UseVisualStyleBackColor = true;
            this.ReturnBuy_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Seles_checkBox
            // 
            this.Seles_checkBox.AutoSize = true;
            this.Seles_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seles_checkBox.Location = new System.Drawing.Point(49, 25);
            this.Seles_checkBox.Name = "Seles_checkBox";
            this.Seles_checkBox.Size = new System.Drawing.Size(51, 22);
            this.Seles_checkBox.TabIndex = 85;
            this.Seles_checkBox.Text = "مبيع";
            this.Seles_checkBox.UseVisualStyleBackColor = true;
            this.Seles_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Buy_checkBox
            // 
            this.Buy_checkBox.AutoSize = true;
            this.Buy_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_checkBox.Location = new System.Drawing.Point(147, 25);
            this.Buy_checkBox.Name = "Buy_checkBox";
            this.Buy_checkBox.Size = new System.Drawing.Size(55, 22);
            this.Buy_checkBox.TabIndex = 84;
            this.Buy_checkBox.Text = "شراء";
            this.Buy_checkBox.UseVisualStyleBackColor = true;
            this.Buy_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // EnabelDate_checkBox
            // 
            this.EnabelDate_checkBox.AutoSize = true;
            this.EnabelDate_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabelDate_checkBox.Location = new System.Drawing.Point(440, 113);
            this.EnabelDate_checkBox.Name = "EnabelDate_checkBox";
            this.EnabelDate_checkBox.Size = new System.Drawing.Size(181, 22);
            this.EnabelDate_checkBox.TabIndex = 90;
            this.EnabelDate_checkBox.Text = "تفعيل البحث عن طريق التاريخ";
            this.EnabelDate_checkBox.UseVisualStyleBackColor = true;
            this.EnabelDate_checkBox.CheckedChanged += new System.EventHandler(this.EnabelDate_checkBox_CheckedChanged);
            // 
            // Total_label
            // 
            this.Total_label.BackColor = System.Drawing.Color.White;
            this.Total_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(153, 104);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(128, 23);
            this.Total_label.TabIndex = 103;
            this.Total_label.Text = "0";
            // 
            // textTotal_label
            // 
            this.textTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal_label.Location = new System.Drawing.Point(287, 105);
            this.textTotal_label.Name = "textTotal_label";
            this.textTotal_label.Size = new System.Drawing.Size(111, 23);
            this.textTotal_label.TabIndex = 102;
            this.textTotal_label.Text = "الإجمالي :";
            // 
            // Loss_label
            // 
            this.Loss_label.BackColor = System.Drawing.Color.White;
            this.Loss_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loss_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loss_label.Location = new System.Drawing.Point(153, 74);
            this.Loss_label.Name = "Loss_label";
            this.Loss_label.Size = new System.Drawing.Size(128, 23);
            this.Loss_label.TabIndex = 101;
            this.Loss_label.Text = "0";
            // 
            // textLoss_label
            // 
            this.textLoss_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoss_label.Location = new System.Drawing.Point(287, 78);
            this.textLoss_label.Name = "textLoss_label";
            this.textLoss_label.Size = new System.Drawing.Size(111, 23);
            this.textLoss_label.TabIndex = 100;
            this.textLoss_label.Text = "الخسارة :";
            // 
            // Gain_label
            // 
            this.Gain_label.BackColor = System.Drawing.Color.White;
            this.Gain_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gain_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gain_label.Location = new System.Drawing.Point(153, 46);
            this.Gain_label.Name = "Gain_label";
            this.Gain_label.Size = new System.Drawing.Size(128, 23);
            this.Gain_label.TabIndex = 99;
            this.Gain_label.Text = "0";
            // 
            // textGain_label
            // 
            this.textGain_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGain_label.Location = new System.Drawing.Point(287, 49);
            this.textGain_label.Name = "textGain_label";
            this.textGain_label.Size = new System.Drawing.Size(111, 23);
            this.textGain_label.TabIndex = 98;
            this.textGain_label.Text = "الربح :";
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
            // UserControl_Profit_and_loss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.textTotal_label);
            this.Controls.Add(this.Loss_label);
            this.Controls.Add(this.textLoss_label);
            this.Controls.Add(this.Gain_label);
            this.Controls.Add(this.textGain_label);
            this.Controls.Add(this.EnabelDate_checkBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.To_dateTimePicker);
            this.Controls.Add(this.From_dateTimePicker);
            this.Controls.Add(this.To_label);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Show_dataGridView);
            this.Name = "UserControl_Profit_and_loss";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Profit_and_loss_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label ItemName_label;
        private System.Windows.Forms.ComboBox ItemName_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ReturnSeles_checkBox;
        private System.Windows.Forms.CheckBox ReturnBuy_checkBox;
        private System.Windows.Forms.CheckBox Seles_checkBox;
        private System.Windows.Forms.CheckBox Buy_checkBox;
        private System.Windows.Forms.CheckBox EnabelDate_checkBox;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Label textTotal_label;
        private System.Windows.Forms.Label Loss_label;
        private System.Windows.Forms.Label textLoss_label;
        private System.Windows.Forms.Label Gain_label;
        private System.Windows.Forms.Label textGain_label;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
