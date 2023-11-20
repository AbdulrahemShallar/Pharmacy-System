namespace Pharmacy_System.Report
{
    partial class UserControl_Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Journal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_label = new System.Windows.Forms.Label();
            this.From_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowAll_checkBox = new System.Windows.Forms.CheckBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_dateTimePicker.Location = new System.Drawing.Point(499, 5);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(148, 26);
            this.To_dateTimePicker.TabIndex = 63;
            this.To_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_dateTimePicker.Location = new System.Drawing.Point(733, 5);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(143, 26);
            this.From_dateTimePicker.TabIndex = 64;
            this.From_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // To_label
            // 
            this.To_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.Location = new System.Drawing.Point(653, 6);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(74, 26);
            this.To_label.TabIndex = 61;
            this.To_label.Text = "إلى :";
            // 
            // From_label
            // 
            this.From_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(882, 6);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(74, 26);
            this.From_label.TabIndex = 62;
            this.From_label.Text = "من :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ShowAll_checkBox);
            this.panel1.Controls.Add(this.To_dateTimePicker);
            this.panel1.Controls.Add(this.To_label);
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.From_dateTimePicker);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Controls.Add(this.From_label);
            this.panel1.Controls.Add(this.Refresh_Button);
            this.panel1.Controls.Add(this.Print_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 36);
            this.panel1.TabIndex = 60;
            // 
            // ShowAll_checkBox
            // 
            this.ShowAll_checkBox.AutoSize = true;
            this.ShowAll_checkBox.Checked = true;
            this.ShowAll_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAll_checkBox.Font = new System.Drawing.Font("Tajawal", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll_checkBox.Location = new System.Drawing.Point(400, 8);
            this.ShowAll_checkBox.Name = "ShowAll_checkBox";
            this.ShowAll_checkBox.Size = new System.Drawing.Size(80, 20);
            this.ShowAll_checkBox.TabIndex = 61;
            this.ShowAll_checkBox.Text = "إظهار الكل";
            this.ShowAll_checkBox.UseVisualStyleBackColor = true;
            this.ShowAll_checkBox.CheckedChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            this.Title_Label.Text = "دفتر يومية";
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
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(240, 2);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 57;
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(281, 2);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 58;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
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
            this.Show_dataGridView.Location = new System.Drawing.Point(7, 43);
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
            this.Show_dataGridView.Size = new System.Drawing.Size(954, 498);
            this.Show_dataGridView.TabIndex = 59;
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
            // UserControl_Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Show_dataGridView);
            this.Name = "UserControl_Journal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Journal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.CheckBox ShowAll_checkBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
