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

        private void Form1_Load(object sender, EventArgs e)
        {
            if(DB.connect())
            {
                MessageBox.Show("Yes");
            } else MessageBox.Show("No");
        }
    }
}
