using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_System
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();
            setLanguage(Classes.Class_Languag.getLanguag());
        }
        public bool isTrue = false;
        int Qunter = 1;
        private void Exit_Button_Click(object sender, EventArgs e) => Application.Exit();

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (UserName_textbox.Text != "" )
            {  
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name from [User] where [Name] = '" + UserName_textbox.Text + "' and [Password] = '" + Password_textbox.Text + "' and [Enable] = 'True' ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                try
                {
                    if (dataTable.Rows[0][0].ToString() != "")
                    {
                        isTrue = true;
                        Form_Main.set_Organizer_Name(dataTable.Rows[0][0].ToString());
                        this.Close(); ;
                    }
                    else
                    {
                        if (Qunter <= 3)
                        {
                            MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة\nالرجاء المحاولة مرة اخرى.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Qunter++;
                        }
                        else
                        {
                            MessageBox.Show("لقد نفذت محاولات تسجيل الدخول الرجاء المحاولة لاحقا.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
                catch
                {
                    if (Qunter < 3)
                    {
                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة\nالرجاء المحاولة مرة اخرى.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Qunter++;
                    }
                    else
                    {
                        MessageBox.Show("لقد نفذت محاولات تسجيل الدخول الرجاء المحاولة لاحقا.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            else {
                MessageBox.Show("الرجاء ادخال الاسم والكلمة المرور.","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void Password_textbox_OnValueChanged(object sender, EventArgs e)
        {
            Password_textbox.isPassword = true;
        }
        public void setLanguage(String Languagename)
        {

            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    Title_label.Text = "تسجيل الدخول";
                    UserName_textbox.Text = "اسم المستخدم";
                    Password_textbox.Text = "كلمة المرور";
                    Login_Button.Text = "تسجيل الدخول";
                    Forget_LinkLabel.Text = "نسيت كلمة المرور";
                    Forget_LinkLabel.Location = new Point(216, 258);
                    break;
                case "إنكليزي":
                case "English":
                    Title_label.Text = "Sign in";
                    UserName_textbox.Text = "User Name";
                    Password_textbox.Text = "Password";
                    Login_Button.Text = "Sign in";
                    Forget_LinkLabel.Text = "Forgot your password";
                    Forget_LinkLabel.Location = new Point(155, 258);
                    break;
            }
        }

        private void Forget_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UserName_textbox.Text != "")
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "Add_UserMssage";
                    sqlCommand.Parameters.Add("@User_Name", SqlDbType.NVarChar, 50).Value = UserName_textbox.Text;
                    sqlCommand.Parameters.Add("@Message", SqlDbType.NVarChar, 250).Value = "طلب من المسخدم " + UserName_textbox.Text + "\nنسيت كلمة المرور.";
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("تم ارسال رسالة الإى المشرف الخاص بكم.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                catch
                {
                    MessageBox.Show("حصل خطأ ما الرجاء المحاولة لاحقا.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();

                }
            }
            else
                MessageBox.Show("يجب ادخال اسم المستخدم على الاقل.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
