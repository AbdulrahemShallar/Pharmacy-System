namespace Pharmacy_System.Report
{
    partial class UserControl_Billing_Movement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Billing_Movement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضالطلباتقيدالمعالجةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالطلباتالمنتهيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.From_label = new System.Windows.Forms.Label();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_label = new System.Windows.Forms.Label();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnabelDate_checkBox = new System.Windows.Forms.CheckBox();
            this.ReturnSeles_checkBox = new System.Windows.Forms.CheckBox();
            this.ReturnBuy_checkBox = new System.Windows.Forms.CheckBox();
            this.Seles_checkBox = new System.Windows.Forms.CheckBox();
            this.Buy_checkBox = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالطلباتقيدالمعالجةToolStripMenuItem,
            this.عرضالطلباتالمنتهيةToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 48);
            // 
            // عرضالطلباتقيدالمعالجةToolStripMenuItem
            // 
            this.عرضالطلباتقيدالمعالجةToolStripMenuItem.Name = "عرضالطلباتقيدالمعالجةToolStripMenuItem";
            this.عرضالطلباتقيدالمعالجةToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.عرضالطلباتقيدالمعالجةToolStripMenuItem.Text = "عرض الطلبات قيد المعالجة";
            // 
            // عرضالطلباتالمنتهيةToolStripMenuItem
            // 
            this.عرضالطلباتالمنتهيةToolStripMenuItem.Name = "عرضالطلباتالمنتهيةToolStripMenuItem";
            this.عرضالطلباتالمنتهيةToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.عرضالطلباتالمنتهيةToolStripMenuItem.Text = "عرض الطلبات المنتهية";
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(7, 82);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 43;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(7, 42);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 42;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Show_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.Show_dataGridView.Location = new System.Drawing.Point(7, 137);
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
            this.Show_dataGridView.TabIndex = 44;
            this.Show_dataGridView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 36);
            this.panel1.TabIndex = 50;
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
            this.Title_Label.Text = "حركة فواتير تجميعي";
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
            // From_label
            // 
            this.From_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(856, 50);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(93, 26);
            this.From_label.TabIndex = 55;
            this.From_label.Text = "من :";
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Enabled = false;
            this.From_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_dateTimePicker.Location = new System.Drawing.Point(650, 50);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.From_dateTimePicker.TabIndex = 56;
            this.From_dateTimePicker.ValueChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // To_label
            // 
            this.To_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.Location = new System.Drawing.Point(856, 92);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(93, 26);
            this.To_label.TabIndex = 55;
            this.To_label.Text = "إلى :";
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Enabled = false;
            this.To_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_dateTimePicker.Location = new System.Drawing.Point(650, 92);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.To_dateTimePicker.TabIndex = 56;
            this.To_dateTimePicker.ValueChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // EnabelDate_checkBox
            // 
            this.EnabelDate_checkBox.AutoSize = true;
            this.EnabelDate_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabelDate_checkBox.Location = new System.Drawing.Point(449, 54);
            this.EnabelDate_checkBox.Name = "EnabelDate_checkBox";
            this.EnabelDate_checkBox.Size = new System.Drawing.Size(181, 22);
            this.EnabelDate_checkBox.TabIndex = 57;
            this.EnabelDate_checkBox.Text = "تفعيل البحث عن طريق التاريخ";
            this.EnabelDate_checkBox.UseVisualStyleBackColor = true;
            this.EnabelDate_checkBox.CheckedChanged += new System.EventHandler(this.EnabelDate_checkBox_CheckedChanged);
            // 
            // ReturnSeles_checkBox
            // 
            this.ReturnSeles_checkBox.AutoSize = true;
            this.ReturnSeles_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnSeles_checkBox.Location = new System.Drawing.Point(307, 97);
            this.ReturnSeles_checkBox.Name = "ReturnSeles_checkBox";
            this.ReturnSeles_checkBox.Size = new System.Drawing.Size(87, 22);
            this.ReturnSeles_checkBox.TabIndex = 77;
            this.ReturnSeles_checkBox.Text = "مرتجع مبيع";
            this.ReturnSeles_checkBox.UseVisualStyleBackColor = true;
            this.ReturnSeles_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ReturnBuy_checkBox
            // 
            this.ReturnBuy_checkBox.AutoSize = true;
            this.ReturnBuy_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBuy_checkBox.Location = new System.Drawing.Point(407, 97);
            this.ReturnBuy_checkBox.Name = "ReturnBuy_checkBox";
            this.ReturnBuy_checkBox.Size = new System.Drawing.Size(91, 22);
            this.ReturnBuy_checkBox.TabIndex = 76;
            this.ReturnBuy_checkBox.Text = "مرتجع شراء";
            this.ReturnBuy_checkBox.UseVisualStyleBackColor = true;
            this.ReturnBuy_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Seles_checkBox
            // 
            this.Seles_checkBox.AutoSize = true;
            this.Seles_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seles_checkBox.Location = new System.Drawing.Point(511, 97);
            this.Seles_checkBox.Name = "Seles_checkBox";
            this.Seles_checkBox.Size = new System.Drawing.Size(51, 22);
            this.Seles_checkBox.TabIndex = 75;
            this.Seles_checkBox.Text = "مبيع";
            this.Seles_checkBox.UseVisualStyleBackColor = true;
            this.Seles_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Buy_checkBox
            // 
            this.Buy_checkBox.AutoSize = true;
            this.Buy_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_checkBox.Location = new System.Drawing.Point(575, 97);
            this.Buy_checkBox.Name = "Buy_checkBox";
            this.Buy_checkBox.Size = new System.Drawing.Size(55, 22);
            this.Buy_checkBox.TabIndex = 74;
            this.Buy_checkBox.Text = "شراء";
            this.Buy_checkBox.UseVisualStyleBackColor = true;
            this.Buy_checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
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
            // UserControl_Billing_Movement
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReturnSeles_checkBox);
            this.Controls.Add(this.ReturnBuy_checkBox);
            this.Controls.Add(this.Seles_checkBox);
            this.Controls.Add(this.Buy_checkBox);
            this.Controls.Add(this.EnabelDate_checkBox);
            this.Controls.Add(this.To_dateTimePicker);
            this.Controls.Add(this.From_dateTimePicker);
            this.Controls.Add(this.To_label);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Show_dataGridView);
            this.Name = "UserControl_Billing_Movement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Billing_Movement_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عرضالطلباتقيدالمعالجةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالطلباتالمنتهيةToolStripMenuItem;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.CheckBox EnabelDate_checkBox;
        private System.Windows.Forms.CheckBox ReturnSeles_checkBox;
        private System.Windows.Forms.CheckBox ReturnBuy_checkBox;
        private System.Windows.Forms.CheckBox Seles_checkBox;
        private System.Windows.Forms.CheckBox Buy_checkBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
