namespace Pharmacy_System.Report
{
    partial class UserControl_Material_inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Material_inventory));
            this.StoreName_comboBox = new System.Windows.Forms.ComboBox();
            this.StoreNamelabel = new System.Windows.Forms.Label();
            this.ItemName_label = new System.Windows.Forms.Label();
            this.ItemName_comboBox = new System.Windows.Forms.ComboBox();
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.textamountIn_label = new System.Windows.Forms.Label();
            this.amountIn_label = new System.Windows.Forms.Label();
            this.textamountOut_label = new System.Windows.Forms.Label();
            this.amountOut_label = new System.Windows.Forms.Label();
            this.textamountTotal_label = new System.Windows.Forms.Label();
            this.amountTotal_label = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreName_comboBox
            // 
            this.StoreName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName_comboBox.FormattingEnabled = true;
            this.StoreName_comboBox.Location = new System.Drawing.Point(471, 101);
            this.StoreName_comboBox.Name = "StoreName_comboBox";
            this.StoreName_comboBox.Size = new System.Drawing.Size(340, 26);
            this.StoreName_comboBox.TabIndex = 77;
            this.StoreName_comboBox.TextChanged += new System.EventHandler(this.CompoBox_TextChange);
            // 
            // StoreNamelabel
            // 
            this.StoreNamelabel.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNamelabel.Location = new System.Drawing.Point(826, 102);
            this.StoreNamelabel.Name = "StoreNamelabel";
            this.StoreNamelabel.Size = new System.Drawing.Size(124, 23);
            this.StoreNamelabel.TabIndex = 76;
            this.StoreNamelabel.Text = "اسم المستودع :";
            // 
            // ItemName_label
            // 
            this.ItemName_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_label.Location = new System.Drawing.Point(850, 61);
            this.ItemName_label.Name = "ItemName_label";
            this.ItemName_label.Size = new System.Drawing.Size(100, 23);
            this.ItemName_label.TabIndex = 75;
            this.ItemName_label.Text = "اسم المادة :";
            // 
            // ItemName_comboBox
            // 
            this.ItemName_comboBox.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_comboBox.FormattingEnabled = true;
            this.ItemName_comboBox.Location = new System.Drawing.Point(471, 55);
            this.ItemName_comboBox.Name = "ItemName_comboBox";
            this.ItemName_comboBox.Size = new System.Drawing.Size(340, 26);
            this.ItemName_comboBox.TabIndex = 74;
            this.ItemName_comboBox.SelectedIndexChanged += new System.EventHandler(this.ItemName_comboBox_SelectedIndexChanged);
            this.ItemName_comboBox.TextChanged += new System.EventHandler(this.CompoBox_TextChange);
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
            this.Show_dataGridView.Location = new System.Drawing.Point(3, 142);
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
            this.Show_dataGridView.TabIndex = 73;
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
            this.panel1.TabIndex = 70;
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
            this.Title_Label.Text = "جرد المواد";
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
            // Print_Button
            // 
            this.Print_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print_Button.BackgroundImage")));
            this.Print_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Print_Button.FlatAppearance.BorderSize = 0;
            this.Print_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Button.Location = new System.Drawing.Point(3, 87);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(35, 34);
            this.Print_Button.TabIndex = 72;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.BackgroundImage")));
            this.Refresh_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Location = new System.Drawing.Point(3, 47);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(35, 34);
            this.Refresh_Button.TabIndex = 71;
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // textamountIn_label
            // 
            this.textamountIn_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textamountIn_label.Location = new System.Drawing.Point(290, 54);
            this.textamountIn_label.Name = "textamountIn_label";
            this.textamountIn_label.Size = new System.Drawing.Size(111, 23);
            this.textamountIn_label.TabIndex = 78;
            this.textamountIn_label.Text = "الكمية الداخلة :";
            // 
            // amountIn_label
            // 
            this.amountIn_label.BackColor = System.Drawing.Color.White;
            this.amountIn_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountIn_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountIn_label.Location = new System.Drawing.Point(156, 51);
            this.amountIn_label.Name = "amountIn_label";
            this.amountIn_label.Size = new System.Drawing.Size(128, 23);
            this.amountIn_label.TabIndex = 79;
            this.amountIn_label.Text = "0";
            // 
            // textamountOut_label
            // 
            this.textamountOut_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textamountOut_label.Location = new System.Drawing.Point(290, 82);
            this.textamountOut_label.Name = "textamountOut_label";
            this.textamountOut_label.Size = new System.Drawing.Size(111, 23);
            this.textamountOut_label.TabIndex = 80;
            this.textamountOut_label.Text = "الكمية الخارجة :";
            // 
            // amountOut_label
            // 
            this.amountOut_label.BackColor = System.Drawing.Color.White;
            this.amountOut_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountOut_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOut_label.Location = new System.Drawing.Point(156, 81);
            this.amountOut_label.Name = "amountOut_label";
            this.amountOut_label.Size = new System.Drawing.Size(128, 23);
            this.amountOut_label.TabIndex = 81;
            this.amountOut_label.Text = "0";
            // 
            // textamountTotal_label
            // 
            this.textamountTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textamountTotal_label.Location = new System.Drawing.Point(290, 111);
            this.textamountTotal_label.Name = "textamountTotal_label";
            this.textamountTotal_label.Size = new System.Drawing.Size(111, 23);
            this.textamountTotal_label.TabIndex = 82;
            this.textamountTotal_label.Text = "الكمية الحالية :";
            // 
            // amountTotal_label
            // 
            this.amountTotal_label.BackColor = System.Drawing.Color.White;
            this.amountTotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTotal_label.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTotal_label.Location = new System.Drawing.Point(156, 110);
            this.amountTotal_label.Name = "amountTotal_label";
            this.amountTotal_label.Size = new System.Drawing.Size(128, 23);
            this.amountTotal_label.TabIndex = 83;
            this.amountTotal_label.Text = "0";
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
            // UserControl_Material_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountTotal_label);
            this.Controls.Add(this.textamountTotal_label);
            this.Controls.Add(this.amountOut_label);
            this.Controls.Add(this.textamountOut_label);
            this.Controls.Add(this.amountIn_label);
            this.Controls.Add(this.textamountIn_label);
            this.Controls.Add(this.StoreName_comboBox);
            this.Controls.Add(this.StoreNamelabel);
            this.Controls.Add(this.ItemName_label);
            this.Controls.Add(this.ItemName_comboBox);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Show_dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Material_inventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(964, 545);
            this.Load += new System.EventHandler(this.UserControl_Material_inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox StoreName_comboBox;
        private System.Windows.Forms.Label StoreNamelabel;
        private System.Windows.Forms.Label ItemName_label;
        private System.Windows.Forms.ComboBox ItemName_comboBox;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.Label textamountIn_label;
        private System.Windows.Forms.Label amountIn_label;
        private System.Windows.Forms.Label textamountOut_label;
        private System.Windows.Forms.Label amountOut_label;
        private System.Windows.Forms.Label textamountTotal_label;
        private System.Windows.Forms.Label amountTotal_label;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
