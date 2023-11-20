namespace Pharmacy_System
{
    partial class Form_Input
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cansole_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.ItemName_label = new System.Windows.Forms.Label();
            this.ItemNameValue_comboBox = new System.Windows.Forms.ComboBox();
            this.Titel_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cansole_button
            // 
            this.Cansole_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cansole_button.FlatAppearance.BorderSize = 0;
            this.Cansole_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cansole_button.ForeColor = System.Drawing.Color.White;
            this.Cansole_button.Location = new System.Drawing.Point(0, 146);
            this.Cansole_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cansole_button.Name = "Cansole_button";
            this.Cansole_button.Size = new System.Drawing.Size(223, 50);
            this.Cansole_button.TabIndex = 5;
            this.Cansole_button.Text = "الغاء";
            this.Cansole_button.UseVisualStyleBackColor = false;
            this.Cansole_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Save_button.FlatAppearance.BorderSize = 0;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(224, 146);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(223, 50);
            this.Save_button.TabIndex = 6;
            this.Save_button.Text = "حفظ";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // ItemName_label
            // 
            this.ItemName_label.Location = new System.Drawing.Point(294, 62);
            this.ItemName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName_label.Name = "ItemName_label";
            this.ItemName_label.Size = new System.Drawing.Size(133, 37);
            this.ItemName_label.TabIndex = 4;
            this.ItemName_label.Text = "اسم الدواء : ";
            this.ItemName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemNameValue_comboBox
            // 
            this.ItemNameValue_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameValue_comboBox.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameValue_comboBox.FormattingEnabled = true;
            this.ItemNameValue_comboBox.Location = new System.Drawing.Point(32, 66);
            this.ItemNameValue_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemNameValue_comboBox.Name = "ItemNameValue_comboBox";
            this.ItemNameValue_comboBox.Size = new System.Drawing.Size(254, 30);
            this.ItemNameValue_comboBox.TabIndex = 3;
            // 
            // Titel_label
            // 
            this.Titel_label.Location = new System.Drawing.Point(212, 20);
            this.Titel_label.Name = "Titel_label";
            this.Titel_label.Size = new System.Drawing.Size(222, 27);
            this.Titel_label.TabIndex = 7;
            this.Titel_label.Text = "الرجاء تحديد الاسم الدواء  :";
            // 
            // Form_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 199);
            this.Controls.Add(this.Titel_label);
            this.Controls.Add(this.Cansole_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.ItemName_label);
            this.Controls.Add(this.ItemNameValue_comboBox);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Input";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Input_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cansole_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label ItemName_label;
        private System.Windows.Forms.ComboBox ItemNameValue_comboBox;
        private System.Windows.Forms.Label Titel_label;
    }
}