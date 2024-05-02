using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbconnect;

namespace NikandrovTestApp
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();  
        }
        static public string name;
        private void Form1_Load(object sender, EventArgs e)
        {
            if(DBase.connect())
            {
                DBase.getLogin();
                LoginComboBox.DataSource = DBase.dtLogin;
                LoginComboBox.DisplayMember = "login";
                LoginComboBox.ValueMember = "id";

                //MessageBox.Show("Connected!");
            } else MessageBox.Show("Not connected!");

            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if(DBase.disConnect())
            {
                this.Close();
            }
            
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DBase.auth(LoginComboBox.Text, PassTextBox.Text));
            //if(DBase.auth(LoginComboBox.Text, PassTextBox.Text))
            //{
            //    name = LoginComboBox.Text;
            //    MessageBox.Show("ok");
            //}
            //else
            //{
            //    name = "";
            //    MessageBox.Show("password incorrect");
            //}
        }
    }
}
