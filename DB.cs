using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dbconnect
{
    class DB
    {
        static public string connectionstring = @"database=uslugi;datasource=localhost;user=root;pwd=1342";
        
        static public MySqlConnection myconnect;
        static public MySqlCommand mycommand;
        static public MySqlDataAdapter myadapter;

        static public bool connect ()
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
    }
}
