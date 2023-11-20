using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace Pharmacy_System
{
    class Class_Connection
    {
        private string connection = "";
        public static string con;
        SqlConnection sqlConnection;

        public Class_Connection()
        {

           
        }
        public Class_Connection(bool X)
        {
            set_Connection();

        }
        public  string get_Connection()
        { return con; }
        public bool isAccountNameInList(SqlCommand sqlCommand,string textMessageFound)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                string ret = (Convert.ToInt32(sqlCommand.ExecuteScalar())).ToString();
                sqlConnection.Close();
                if (ret == null || ret == "0")
                    return true;
                else
                {
                    MessageBox.Show(textMessageFound, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(textMessageFound, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool IsNotFound(String Table_Name,String Where,string textMessageFounded)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select ID from " + Table_Name+" where "+Where;
                sqlConnection.Open();
                string ret = (Convert.ToInt32(sqlCommand.ExecuteScalar())).ToString();
                sqlConnection.Close();
                if (ret == null || ret == "0")
                    return true;
                else
                {
                    MessageBox.Show(textMessageFounded, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(textMessageFounded, "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        public void executeNonQuery (SqlCommand sqlCommand,string textMessageOk,string textMessageNo)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show(textMessageOk,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
                sqlConnection.Close();

        }
            catch
            {
                MessageBox.Show(textMessageNo,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
}
        public void executeNonQuery(SqlCommand sqlCommand)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

        }
            catch
            {
            }
        }
      
        public string getMaxID(string Table_Name)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select max(ID) from "+ Table_Name;
                sqlConnection.Open();
                  string ret= (Convert.ToInt32(sqlCommand.ExecuteScalar()) + 1).ToString();
                sqlConnection.Close();
                return ret;
            }
            catch { 
                return "1";
            }
        }
        public  void set_Connection()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(".//DataBaseNames.txt");
                //Read the first line of text
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line[0] == '$')
                    {
                        connection = "Data Source=(local);Initial Catalog=" + line.Substring(1) + ";Integrated Security=True";
                        break;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                con = connection;



                //Show Files Window for chose a database and back agin to Begin and change File database to $for the data Chose
                //try
                //{
                //    //Pass the filepath and filename to the StreamWriter Constructor
                //    StreamWriter sw = new StreamWriter(".//DataBaseNames.txt");
                //    //Write a line of text
                //    sw.WriteLine("Hello World!!");
                //    sw.Close();
                //}
                //catch (Exception e)
                //{

                //}

            }
            catch
            {
            }
        }
        public string get_Rov(String Name)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select ROV_Account from RovAccount where  Account_Name = '" + Name+"' ";
                sqlConnection.Open();
                string Rov = (Convert.ToDouble(sqlCommand.ExecuteScalar())).ToString();
                sqlConnection.Close();
                return Rov;
            }
            catch
            {
                return "0";
            }
        }
        public void Update_Rov(String Name,float ROV_Value)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "Update_ROVAccount";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = Name;
                sqlCommand.Parameters.Add("@ROV_Account", SqlDbType.Float).Value = ROV_Value;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
            }
        }

    }
}
