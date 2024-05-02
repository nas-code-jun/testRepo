using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace NikandrovTestApp
{
    static public class DBase
    {
        static public string connectionstring = @"database=test;datasource=localhost;user=root;pwd=1342";

        static public MySqlConnection myconnect;
        static public MySqlCommand mycommand;
        static public MySqlDataAdapter myadapter;


        static public DataTable dtLogin = new DataTable();

        static public bool connect()
        {
            try
            {
                myconnect = new MySqlConnection(connectionstring);
                myconnect.Open();
                mycommand = new MySqlCommand();
                mycommand.Connection = myconnect;
                myadapter = new MySqlDataAdapter();
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public bool disConnect()
        {
            try
            {
                myconnect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public bool auth(string login, string pass)
        {
            try
            {
                mycommand.CommandText = @"SELECT id FROM test.people WHERE (login = '" + login + "') AND (password = '" + pass + "');";
                Console.WriteLine("SELECT id FROM test.people WHERE (login = '" + login + "') AND (password = '" + pass + "');");
                if (mycommand.ExecuteScalar() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        static public void getLogin()
        {
            try
            {
                mycommand.CommandText = "SELECT * FROM test.people;";
                dtLogin.Clear();
                myadapter = new MySqlDataAdapter(mycommand);
                myadapter.Fill(dtLogin);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
