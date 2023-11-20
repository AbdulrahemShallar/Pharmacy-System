namespace Pharmacy_System.Report
{
    partial class UserControl_Material_Movement_Synthesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Material_Movement_Synthesis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.EnabelDate_checkBox = new System.Windows.Forms.CheckBox();
            this.StoreName_comboBox = new System.Windows.Forms.ComboBox();
            this.StoreNamelabel = new System.Windows.Forms.Label();
            this.ItemName_label = new System.Windows.Forms.Label();
            this.ItemName_comboBox = new System.Windows.Forms.ComboBox();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.From_label = new System.Windows.Forms.Label();
            this.To_label = new System.Windows.Forms.Label();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 51;
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
            this.Title_Label.Text = "حركة مادة تجميعي";
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
            // EnabelDate_checkBox
            // 
            this.EnabelDate_checkBox.AutoSize = true;
            this.EnabelDate_checkBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabelDate_checkBox.Location = new System.Drawing.Point(369, 90);
            this.EnabelDate_checkBox.Name = "EnabelDate_checkBox";
            this.EnabelDate_checkBox.Size = new System.Drawing.Size(181, 22);
            this.EnabelDate_checkBox.TabIndex = 69;
            this.EnabelDate_checkBox.Text = "تفعيل البحث عن طريق التاريخ";
            this.EnabelDate_checkBox.UseVisualStyleBackColor = true;
            this.EnabelDate_checkBox.CheckedChanged += new System.EventHandler(this.EnabelDate_checkBox_CheckedChanged);
            // 
            // StoreName_comboBox
            // 
            this.StoreName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName_comboBox.FormattingEnabled = true;
            this.StoreName_comboBox.Location = new System.Drawing.Point(369, 47);
            this.StoreName_comboBox.Name = "StoreName_comboBox";
            this.StoreName_comboBox.Size = new System.Drawing.Size(183, 26);
            this.StoreName_comboBox.TabIndex = 64;
            this.StoreName_comboBox.TextChanged += new System.EventHandler(this.CompoBox_TextChange);
            // 
            // StoreNamelabel
            // 
            this.StoreNamelabel.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNamelabel.Location = new System.Drawing.Point(558, 50);
            this.StoreNamelabel.Name = "StoreNamelabel";
            this.StoreNamelabel.Size = new System.Drawing.Size(124, 23);
            this.StoreNamelabel.TabIndex = 63;
            this.StoreNamelabel.Text = "اسم المستودع :";
            // 
            // ItemName_label
            // 
            this.ItemName_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_label.Location = new System.Drawing.Point(862, 50);
            this.ItemName_label.Name = "ItemName_label";
            this.ItemName_label.Size = new System.Drawing.Size(100, 23);
            this.ItemName_label.TabIndex = 62;
            this.ItemName_label.Text = "اسم المادة :";
            // 
            // ItemName_comboBox
            // 
            this.ItemName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_comboBox.FormattingEnabled = true;
            this.ItemName_comboBox.Location = new System.Drawing.Point(688, 47);
            this.ItemName_comboBox.Name = "ItemName_comboBox";
            this.ItemName_comboBox.Size = new System.Drawing.Size(168, 26);
            this.ItemName_comboBox.TabIndex = 61;
            this.ItemName_comboBox.TextChanged += new System.EventHandler(this.CompoBox_TextChange);
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(3, 84);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 59;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(3, 44);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 58;
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
            this.Show_dataGridView.Location = new System.Drawing.Point(3, 139);
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
            this.Show_dataGridView.TabIndex = 60;
            this.Show_dataGridView.TabStop = false;
            // 
            // From_label
            // 
            this.From_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(267, 47);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(93, 26);
            this.From_label.TabIndex = 66;
            this.From_label.Text = "من :";
            // 
            // To_label
            // 
            this.To_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.Location = new System.Drawing.Point(267, 89);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(93, 26);
            this.To_label.TabIndex = 65;
            this.To_label.Text = "إلى :";
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Enabled = false;
            this.From_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_dateTimePicker.Location = new System.Drawing.Point(61, 47);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.From_dateTimePicker.TabIndex = 68;
            this.From_dateTimePicker.ValueChanged += new System.EventHandler(this.From_dateTimePicker_ValueChanged);
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Enabled = false;
            this.To_dateTimePicker.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_dateTimePicker.Location = new System.Drawing.Point(61, 89);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.To_dateTimePicker.TabIndex = 67;
            this.To_dateTimePicker.ValueChanged += new System.EventHandler(this.To_dateTimePicker_ValueChanged);
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
            // UserControl_Material_Movement_Synthesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnabelDate_checkBox);
            this.Controls.Add(this.To_dateTimePicker);
            this.Controls.Add(this.From_dateTimePicker);
            this.Controls.Add(this.To_label);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.StoreName_comboBox);
            this.Controls.Add(this.StoreNamelabel);
            this.Controls.Add(this.ItemName_label);
            this.Controls.Add(this.ItemName_comboBox);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Show_dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Material_Movement_Synthesis";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Material_Movement_Synthesis_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.CheckBox EnabelDate_checkBox;
        private System.Windows.Forms.ComboBox StoreName_comboBox;
        private System.Windows.Forms.Label StoreNamelabel;
        private System.Windows.Forms.Label ItemName_label;
        private System.Windows.Forms.ComboBox ItemName_comboBox;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
