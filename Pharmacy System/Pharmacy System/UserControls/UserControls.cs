using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pharmacy_System.UserControls
{
    public partial class UserControls : UserControl
    {
       public int id=0;
        public bool EnabelState = true;
        private static UserControls _instance;
        public static UserControls Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControls();
                return _instance;
            }
        }
        public UserControls()
        {
            InitializeComponent();
        }
        private void Clear_Button()
        {
            btn_Enable.BackColor = btn_Add.BackColor = btn_Delete.BackColor = btn_Update.BackColor
                 = Color.FromArgb(61, 58, 69);
        }
        private void Clear_Text()
        {
            UserName_textBox.Text = Password_textBox.Text = PasswordCheck_textBox.Text =Email_textBox.Text  =FullName_textBox.Text = IT_comboBox.Text =  "";
            ItemImage_pictureBox.Image = null;
            Enabel_bunifuSwitch.Value = true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Clear_Button();
            Clear_Text();
            id = Get_Id();
            set_ITName();
            lbl_Title.Text = "إضافة مستخدم :";
            btn_Add.BackColor = Color.FromArgb(48, 175, 153);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Clear_Button();
            Clear_Text();
            EnabelState = true;
            MyMessgeBox my = new MyMessgeBox("get_user");
            my.ShowDialog();
            if(id < 0)
                ((Form)this.TopLevelControl).Close();
            lbl_Title.Text = "إلغاء تفعيل مستخدم:";
            btn_Delete.BackColor = Color.FromArgb(220, 130, 122);
            Text_Lode(this.id);
            set_ReadOnli();
        }
        
     
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Clear_Button();
            Clear_Text();
            set_ITName();
            MyMessgeBox my = new MyMessgeBox("get_user");
            my.ShowDialog();
            if (id < 0)
                ((Form)this.TopLevelControl).Close();
            lbl_Title.Text = "تعديل مستخدم :";
            btn_Update.BackColor = Color.FromArgb(248, 208, 126);
            Text_Lode(this.id);
            set_ReadOnli();
        }
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            Clear_Button();
            Clear_Text();
            EnabelState = false;
            MyMessgeBox my = new MyMessgeBox("get_user");
            my.ShowDialog();
            if (id < 0)
                ((Form)this.TopLevelControl).Close();
            lbl_Title.Text = "تفعيل مستخدم :";
            btn_Enable.BackColor = Color.FromArgb(77, 148, 196);
            Text_Lode(this.id);
            set_ReadOnli();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
        private void set_ITName()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Class_Connection.con))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name from [User] where User_Type = 'مدير' and [Enable] = 'True'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                IT_comboBox.ValueMember = "Name";
                IT_comboBox.DataSource = dataTable;
                sqlConnection.Close();


            }
        }
        private void set_ReadOnli()
        {
            if (lbl_Title.Text == "إضافة مستخدم :")
            {
                UserName_textBox.Enabled = Password_textBox.Enabled = PasswordCheck_textBox.Enabled = Email_textBox.Enabled =
                    FullName_textBox.Enabled = IT_comboBox.Enabled = AddImage_button.Enabled = true;
                Enabel_bunifuSwitch.Value = true;
                UserType_comboBox.Enabled = true;
            }
            else if (lbl_Title.Text == "إلغاء تفعيل مستخدم:")
            {
                UserName_textBox.Enabled = Password_textBox.Enabled = PasswordCheck_textBox.Enabled = Email_textBox.Enabled =
                    FullName_textBox.Enabled = IT_comboBox.Enabled = AddImage_button.Enabled = false;
                Enabel_bunifuSwitch.Value = false;
                UserType_comboBox.Enabled = false;
            }
            else if (lbl_Title.Text == "تعديل مستخدم :")
            {
                UserName_textBox.Enabled = Password_textBox.Enabled = PasswordCheck_textBox.Enabled = Email_textBox.Enabled =
                    FullName_textBox.Enabled = IT_comboBox.Enabled = AddImage_button.Enabled = true;
                Enabel_bunifuSwitch.Value = true;
                UserType_comboBox.Enabled = true;
            }
            else if (lbl_Title.Text == "تفعيل مستخدم :")
            {
                UserName_textBox.Enabled = Password_textBox.Enabled = PasswordCheck_textBox.Enabled = Email_textBox.Enabled =
                    FullName_textBox.Enabled = IT_comboBox.Enabled = AddImage_button.Enabled = UserType_comboBox.Enabled = false;
                Enabel_bunifuSwitch.Value = true;

            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (lbl_Title.Text == "إضافة مستخدم :")
                Add_User();
            else if (lbl_Title.Text == "إلغاء تفعيل مستخدم:")
                Delete_User();
            else if (lbl_Title.Text == "تعديل مستخدم :")
                Update_User();
            else if (lbl_Title.Text == "تفعيل مستخدم :")
                Enable_User();
        }
        private void Add_User()
        {
            if (Cheak_Index())
                try
                {
                    if (UserType_comboBox.Text != "")
                        if (UserName_textBox.Text != "")
                            if (Password_textBox.Text != "")
                                if (Password_textBox.Text == PasswordCheck_textBox.Text)
                                    using (SqlConnection con = new SqlConnection(Class_Connection.con))
                                    {
                                        con.Open();
                                        SqlCommand com = new SqlCommand();
                                        com.Connection = con;
                                        com.CommandType = CommandType.StoredProcedure;
                                        com.CommandText = "Add_User";
                                        com.Parameters.Add("@ID", SqlDbType.Int).Value = this.id;
                                        com.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = UserName_textBox.Text;
                                        com.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = Password_textBox.Text;
                                        com.Parameters.Add("@Full_Name", SqlDbType.NVarChar, 50).Value = FullName_textBox.Text;
                                        com.Parameters.Add("@Date_Create", SqlDbType.DateTime).Value = System.DateTime.Now;
                                        com.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email_textBox.Text;
                                        com.Parameters.Add("@IT_Name", SqlDbType.NVarChar, 50).Value = IT_comboBox.Text;
                                        MemoryStream ms = new MemoryStream();
                                        if (ItemImage_pictureBox.Image != null)
                                        {
                                            ItemImage_pictureBox.Image.Save(ms, ItemImage_pictureBox.Image.RawFormat);
                                            byte[] img = ms.ToArray();
                                            com.Parameters.Add("@Image", SqlDbType.Image).Value = img;
                                        }
                                        else
                                        {
                                            ItemImage_pictureBox.Image = ItemImage_pictureBox.ErrorImage;
                                            ItemImage_pictureBox.Image.Save(ms, ItemImage_pictureBox.Image.RawFormat);
                                            byte[] img = ms.ToArray();
                                            com.Parameters.Add("@Image", SqlDbType.Image).Value = img;
                                        }
                                        com.Parameters.Add("@User_Type", SqlDbType.NVarChar, 50).Value = UserType_comboBox.Text;
                                        com.Parameters.Add("@Enabel", SqlDbType.Bit).Value = Enabel_bunifuSwitch.Value;
                                        com.ExecuteNonQuery();
                                        this.id = Get_Id();
                                        MessageBox.Show("تم الحفظ بنجاح !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Clear_Text();
                                    }
                                else
                                {
                                    MessageBox.Show("كلمة المرور غير متطابقة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Password_textBox.Text = PasswordCheck_textBox.Text = "";
                                }
                            else
                                MessageBox.Show("يجب كتابة كلمة المرور أولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("يجب إدخال إسم المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("يجب تحيد نوع المستخدم اولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
                catch { MessageBox.Show("القيم المدخل غير صحيح ؟", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show("إسم الموظف ونوعه موجودين مسبقاُ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Delete_User()
        {
            try
            {
                if (UserType_comboBox.Text != "")
                    if (UserName_textBox.Text != "")
                        if (Password_textBox.Text == PasswordCheck_textBox.Text || Password_textBox.Text != "")
                            using (SqlConnection con = new SqlConnection(Class_Connection.con))
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand();
                                com.Connection = con;
                                com.CommandType = CommandType.StoredProcedure;
                                com.CommandText = "Enable_User";
                                com.Parameters.Add("@User_Type", SqlDbType.NVarChar, 50).Value = UserType_comboBox.Text;
                                com.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = UserName_textBox.Text;
                                com.Parameters.Add("@PassWord", SqlDbType.NVarChar, 50).Value = Password_textBox.Text;
                                com.Parameters.Add("@Enabel", SqlDbType.Bit).Value = false;
                                com.ExecuteNonQuery();
                                MessageBox.Show("تم الإلغاء لتفعيل بنجاح !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear_Text();
                            }
                        else
                            MessageBox.Show("يجب إدخال كلمة مرور المستخدم اولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("يجب إدخال إسم المستخدم اولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("يجب إدخال نوع المستخدم اولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { MessageBox.Show("الرقم المدخل غير صحيح ؟", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void Update_User()
        {
            if (Cheak_Index())
                try
                {
                    if (UserType_comboBox.Text != "")
                        if (UserName_textBox.Text != "")
                            if (Password_textBox.Text != "")
                                if (Password_textBox.Text == PasswordCheck_textBox.Text)
                                    using (SqlConnection con = new SqlConnection(Class_Connection.con))
                                    {
                                        con.Open();
                                        SqlCommand com = new SqlCommand();
                                        com.Connection = con;
                                        com.CommandType = CommandType.StoredProcedure;
                                        com.CommandText = "Update_User";
                                        com.Parameters.Add("@ID", SqlDbType.Int).Value = this.id;
                                        com.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = UserName_textBox.Text;
                                        com.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = Password_textBox.Text;
                                        com.Parameters.Add("@Full_Name", SqlDbType.NVarChar, 50).Value = FullName_textBox.Text;
                                        com.Parameters.Add("@Date_Create", SqlDbType.DateTime).Value = System.DateTime.Now.ToString("dd/MM/yyyy");
                                        com.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email_textBox.Text;
                                        com.Parameters.Add("@IT_Name", SqlDbType.NVarChar, 50).Value = IT_comboBox.Text;
                                        MemoryStream ms = new MemoryStream();
                                        if (ItemImage_pictureBox.Image != null)
                                        {
                                            ItemImage_pictureBox.Image.Save(ms, ItemImage_pictureBox.Image.RawFormat);
                                            byte[] img = ms.ToArray();
                                            com.Parameters.Add("@Image", SqlDbType.Image).Value = img;
                                        }
                                        else
                                        {
                                            ItemImage_pictureBox.Image = ItemImage_pictureBox.ErrorImage;
                                            ItemImage_pictureBox.Image.Save(ms, ItemImage_pictureBox.Image.RawFormat);
                                            byte[] img = ms.ToArray();
                                            com.Parameters.Add("@Image", SqlDbType.Image).Value = img;
                                        }
                                        com.Parameters.Add("@User_Type", SqlDbType.NVarChar, 50).Value = UserType_comboBox.Text;
                                        com.Parameters.Add("@Enabel", SqlDbType.Bit).Value = Enabel_bunifuSwitch.Value;
                                        com.ExecuteNonQuery();
                                        MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Clear_Text();
                                    }
                                else
                                {
                                    MessageBox.Show("كلماتها المرور غير متطابقة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Password_textBox.Text = PasswordCheck_textBox.Text = "";
                                }
                            else MessageBox.Show("يجب كتابة كلمة المرور مسبقا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show("يجب كتابة إسم المستخدم اولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("يجب تحديد نوع المستخدم اولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { MessageBox.Show("الرقم المدخل غير صحيح ؟", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show("إسم الموظف ونوعه موجودين مسبقاُ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private int Get_Id()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Class_Connection.con))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select Max(Id) from [User]", sqlConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "")
                        return ((int.Parse(dt.Rows[0][0].ToString()) + 1));
                    else
                        return 1;
                }
            }
            catch { return 0; }
        }
        private void Enable_User()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Class_Connection.con))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "Enable_User";
                    com.Parameters.Add("@User_Type", SqlDbType.NVarChar, 50).Value = UserType_comboBox.Text;
                    com.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = UserName_textBox.Text;
                    com.Parameters.Add("@PassWord", SqlDbType.NVarChar, 50).Value = Password_textBox.Text;
                    com.Parameters.Add("@Enabel", SqlDbType.Bit).Value = true;
                    com.ExecuteNonQuery();
                    MessageBox.Show("تم التفعيل بنجاح ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { };
        }
        private void Text_Lode(int Id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Class_Connection.con))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from [User] where ID= " + Id + " ", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.id = Convert.ToInt16(dt.Rows[0]["Id"]);
                    UserType_comboBox.Text = dt.Rows[0]["User_Type"].ToString();
                    UserName_textBox.Text = dt.Rows[0]["Name"].ToString();
                    Password_textBox.Text = dt.Rows[0]["Password"].ToString();
                    FullName_textBox.Text = dt.Rows[0]["Full_Name"].ToString();
                    Email_textBox.Text = dt.Rows[0]["Email"].ToString();
                    IT_comboBox.Text = dt.Rows[0]["IT_Name"].ToString();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[0]["Image"]);
                        MemoryStream ms = new MemoryStream(img);
                        ItemImage_pictureBox.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                        ItemImage_pictureBox.Image = null;
                    }
                    UserType_comboBox.Text = dt.Rows[0]["User_Type"].ToString();
                    Enabel_bunifuSwitch.Value = (bool)dt.Rows[0]["Enable"];
                }
            }
            catch { return; }
        }
        private bool Cheak_Index()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Class_Connection.con))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from [User] where UsreName='" + UserName_textBox.Text + "' and UsreType='" + UserType_comboBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0]["Id"].ToString() != "")
                        return false;
                    else return true;
                }
            }
            catch { return true; }
        }
        private void UserControls_Load(object sender, EventArgs e)
        {
            btn_Add_Click(sender, e);
            UserType_comboBox.Focus();
        }
        private void Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)// اذا ضغط المستخدم على زر enterسوف ينتقل للحقل التالي 
                SendKeys.Send("{tab}");// نفذ تعليمة الindix
        }

        private void AddImage_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "مسار الصورة||*.JPG;*.PNG;*.GIF;(*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    ItemImage_pictureBox.Image = Image.FromFile(op.FileName);
                    SendKeys.Send("{tab}");
                }
            }
            catch
            {
                MessageBox.Show("ادخال خاطئ", "يجب ان تكون الصورة ذات الإمتدادت (JPG OR PNG)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lbl_Title_TextChanged(object sender, EventArgs e)
        {
            set_ReadOnli();
        }
    }
}
