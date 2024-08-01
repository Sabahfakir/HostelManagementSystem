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
    public partial class ManageStudent : Form
    {
        DBConnection con = new DBConnection();
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }
        public void clearAll()
        {
            txtmobno.Text = string.Empty;
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtadd.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtclass.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            txtgender.Text = string.Empty;
            txtroom.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }
        private void srchbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = con.GetTableData("select * from NewStud where Id ='" + txtid.Text + "' ");
            if (dt.Rows.Count != 0)
            {

                txtgender.Text = dt.Rows[0][7].ToString();
                txtname.Text = dt.Rows[0][1].ToString();
                txtmobno.Text = dt.Rows[0][2].ToString();
                txtadd.Text = dt.Rows[0][3].ToString();
                dateTimePicker1.Text = dt.Rows[0][4].ToString();
                txtemail.Text = dt.Rows[0][5].ToString();
                txtclass.Text = dt.Rows[0][6].ToString();
                txtroom.Text = dt.Rows[0][8].ToString();
                comboBox1.Text = dt.Rows[0][9].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("No record exist!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                con.GetTableData("delete from NewStud where ID = '" + txtid.Text + "'");
                MessageBox.Show("Record Deleted!");
                clearAll();
            }
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            Int64 mobile = Int64.Parse(txtmobno.Text);
            Int32 roomno = Int32.Parse(txtroom.Text);
            con.SqlQuery("Update NewStud set Name ='" + txtname.Text + "', MobileNo = '" + mobile + "', Address ='" + txtadd.Text + "', DOB ='" + dateTimePicker1.Text + "',Email ='" + txtemail.Text + "',Gender ='" + txtgender.Text + "', Class ='" + txtclass.Text + "', RoomID = '" + txtroom.Text + "',Status ='" + comboBox1.Text + "' where ID = '" + id + "' Update Room set Alloted='" + comboBox1.Text + "' where RoomID ='" + roomno + "' ");
           string aval;
            if (comboBox1.Text == "Yes")
            {
                aval = "No";
                
            }
            else{
            aval = "Yes";
            }
            con.SqlQuery("Update Room set Available = '"+aval+"'where RoomID = '"+id+"' ");
            MessageBox.Show("Record Updated!");
            clearAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
