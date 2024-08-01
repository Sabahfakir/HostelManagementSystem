using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HostelMS.Forms;

namespace HostelMS
{
    public partial class Login : Form
    {
        DBConnection db = new DBConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usertxtbox1.Text == "" || passtxtbox2.Text == "") {
                MessageBox.Show(" Missing Fiedls");
            }
            DataTable dt = db.GetTableData("Select  count(*) from Login where Username = '" + usertxtbox1.Text + "' and Password = '" + passtxtbox2.Text + "'");
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        
    }
}
