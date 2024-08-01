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
    public partial class ManageRoom : Form
    {
        DBConnection con = new DBConnection();
        public ManageRoom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
            
        }
        public void clearAll() {
            txtRoomno1.Text = string.Empty;
            txtRoomno2.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            labelRoom2.Visible = false;
            labelRoom1.Visible = false;

        }

        private void AddRoombtn_Click(object sender, EventArgs e)
        {       
            if (txtRoomno1.Text.Length > 3)
            {
                MessageBox.Show("Invalid Room ID");
            }
            else
            {
                DataTable dt = con.GetTableData("Select * from Room where RoomID = " + txtRoomno1.Text + "");
                if (dt.Rows.Count == 0)
                {
                    string status, avail;
                    if (checkBox1.Checked)
                    {
                        avail = "No";
                        status = "Yes";
                    }
                    else
                    {
                        avail = "Yes";
                        status = "No";
                    }
                    labelRoom1.Visible = false;
                    con.SqlQuery("Insert into Room(RoomID, Alloted, Available) values ('" + txtRoomno1.Text + "','" + status + "','" + avail + "')");
                    MessageBox.Show("Room Added !");
                    con.FillGrid(dataGridView1, "Select * from Room");
                }
                else
                {
                    MessageBox.Show("Room already exists");
                    
                }
                
            }
            clearAll();
           
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {

            DataTable dt = con.GetTableData("Select * from Room where RoomID = " + txtRoomno2.Text + "");
            if (dt.Rows.Count == 0)
            {
                labelRoom2.Text = "No room exist!";
                labelRoom2.Visible = true;
                checkBox2.Checked = false;

            }
            else
            {
                labelRoom2.Text = "Room found!";
                labelRoom2.Visible = true;
                if (dt.Rows[0][1].ToString() == "Yes")
                {
                    checkBox2.Checked = true;
                }

                else
                {
                    checkBox2.Checked = false;

                }

            }
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            string status, avail;
            if (checkBox2.Checked)
            {
                status = "Yes";
                avail = "No";
            }
            else
            {
                avail = "Yes";
                status = "No";
            }
            con.SqlQuery("Update Room set Alloted='" + status + "', Available ='"+avail+"' where RoomID=" + txtRoomno2.Text + "");
            MessageBox.Show("Room Updated!");
            con.FillGrid(dataGridView1, "Select * from Room");
            clearAll();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (labelRoom2.Text == "Room found!")
            {
                try
                {
                    MessageBox.Show("Do you want to delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    con.SqlQuery("Delete from Room where RoomID=" + txtRoomno2.Text + "");
                    MessageBox.Show("Room Deleted!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Cannot delete this room as it is alloted to a student. Update room status of student to delete this room ");
                }
                
                con.FillGrid(dataGridView1, "Select * from Room");

            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void ManageRoom_Load(object sender, EventArgs e)
        {
            con.FillGrid(dataGridView1, "Select * from Room");
            labelRoom1.Visible = false;
            labelRoom2.Visible = false;
        }
    }
}
