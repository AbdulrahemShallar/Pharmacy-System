namespace Pharmacy_System.Report
{
    partial class UserControl_Damaged_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Damaged_items));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriceTotal_label = new System.Windows.Forms.Label();
            this.textPriceTotal_label = new System.Windows.Forms.Label();
            this.Total_label = new System.Windows.Forms.Label();
            this.textTotal_label = new System.Windows.Forms.Label();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
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
            this.panel1.Controls.Add(this.PriceTotal_label);
            this.panel1.Controls.Add(this.textPriceTotal_label);
            this.panel1.Controls.Add(this.Total_label);
            this.panel1.Controls.Add(this.textTotal_label);
            this.panel1.Controls.Add(this.Refresh_Button);
            this.panel1.Controls.Add(this.Print_Button);
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.Title_pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 36);
            this.panel1.TabIndex = 60;
            // 
            // PriceTotal_label
            // 
            this.PriceTotal_label.BackColor = System.Drawing.Color.White;
            this.PriceTotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTotal_label.Location = new System.Drawing.Point(346, 8);
            this.PriceTotal_label.Name = "PriceTotal_label";
            this.PriceTotal_label.Size = new System.Drawing.Size(128, 23);
            this.PriceTotal_label.TabIndex = 85;
            this.PriceTotal_label.Text = "0";
            // 
            // textPriceTotal_label
            // 
            this.textPriceTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriceTotal_label.Location = new System.Drawing.Point(480, 8);
            this.textPriceTotal_label.Name = "textPriceTotal_label";
            this.textPriceTotal_label.Size = new System.Drawing.Size(180, 23);
            this.textPriceTotal_label.TabIndex = 84;
            this.textPriceTotal_label.Text = "مجموع قيمة المواد التالفة :";
            // 
            // Total_label
            // 
            this.Total_label.BackColor = System.Drawing.Color.White;
            this.Total_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(666, 8);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(128, 23);
            this.Total_label.TabIndex = 83;
            this.Total_label.Text = "0";
            // 
            // textTotal_label
            // 
            this.textTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal_label.Location = new System.Drawing.Point(800, 8);
            this.textTotal_label.Name = "textTotal_label";
            this.textTotal_label.Size = new System.Drawing.Size(161, 23);
            this.textTotal_label.TabIndex = 82;
            this.textTotal_label.Text = "مجموع الكميات التالفة :";
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(281, 0);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 55;
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(240, 1);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 56;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
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
            this.Title_Label.Text = "المواد التالفة";
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
            this.Show_dataGridView.Location = new System.Drawing.Point(7, 44);
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
            this.Show_dataGridView.Size = new System.Drawing.Size(954, 499);
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
            // UserControl_Damaged_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Show_dataGridView);
            this.Name = "UserControl_Damaged_items";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Damaged_items_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.Label PriceTotal_label;
        private System.Windows.Forms.Label textPriceTotal_label;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Label textTotal_label;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
