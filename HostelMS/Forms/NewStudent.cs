using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HostelMS.Forms
{
    public partial class NewStudent : Form
    {
        DBConnection db = new DBConnection();
        public NewStudent()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

       
        public void ClearAll()
        {
            txtmobno.Text = string.Empty;
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtadd.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtclass.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            malerbtn.Checked = false;
            femalerbtn.Checked = false;
            txtroom.Text = string.Empty;
          

        }
        private void svbtn_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtmobno.Text.Trim()))
            {
                errorProvider2.SetError(txtmobno, "Enter Mobile number!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtmobno, string.Empty);
            }

            if (string.IsNullOrEmpty(txtadd.Text.Trim()))
            {
                errorProvider3.SetError(txtadd, "Enter Address!");
                return;
            }
            else
            {
                errorProvider3.SetError(txtadd, string.Empty);
            }
            
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                errorProvider5.SetError(txtemail, "Enter Email!");
                return;
            }
            else
            {
                errorProvider5.SetError(txtemail, string.Empty);
            }
           
            if (string.IsNullOrEmpty(dateTimePicker1.Text.Trim()))
            {
                errorProvider7.SetError(dateTimePicker1, "Enter Address!");
                return;
            }
            else
            {
                errorProvider7.SetError(dateTimePicker1, string.Empty);
            }
            if (malerbtn.Checked == false && femalerbtn.Checked == false) {
                errorProvider8.SetError(femalerbtn, "Select Gender!");
                return;
            }

            else
            {
                errorProvider8.SetError(femalerbtn, string.Empty);
            }
            if (txtmobno.Text.Length < 10 || txtmobno.Text.Length > 10) {
                MessageBox.Show("Mobile number should be 10 digit");
            }
            
           
            if (txtid.Text != "" && txtname.Text != "" && txtmobno.Text != "" & txtadd.Text != "" && txtemail.Text != "" && txtclass.Text != "" && dateTimePicker1.Text != "" && (malerbtn.Checked != true || femalerbtn.Checked != true) )
            {
                string gender;
                if (malerbtn.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {

                    int id = int.Parse(txtid.Text);
                    Int64 mob = Int64.Parse(txtmobno.Text);
                    Int32 roomno = Int32.Parse(txtroom.Text);
                }
                
                catch(FormatException){}

                try
                {
                    db.SqlQuery("Insert into NewStud(Id, Name, MobileNo,Address,DOB,Email,Class,Gender,RoomID) values('" + txtid.Text + "','" + txtname.Text + "','" + txtmobno.Text + "','" + txtadd.Text + "','" + dateTimePicker1.Text + "','" + txtemail.Text + "','" + txtclass.Text + "','" + gender + "','" +txtroom.Text + "')");
                    MessageBox.Show("Student Registered Successfully!");
                }
                catch (SqlException) { }

                ClearAll();
            }
            else
            {
                MessageBox.Show("Please fill the empty fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

       
        private void clrbtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        public static bool CheckInt(string input) {
            int temp;
            return int.TryParse(input, out temp); 
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetTableData("select * from Admission where ID ='" + txtid.Text + "' ");
            if (dt.Rows.Count != 0)
            {
                txtname.Text = dt.Rows[0][1].ToString();
                txtclass.Text = dt.Rows[0][2].ToString();
                txtroom.Text = dt.Rows[0][3].ToString();
            }
            else
            {
                ClearAll();
                MessageBox.Show("No record exist!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {

        }

       
    }
}
