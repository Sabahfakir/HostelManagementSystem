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
    public partial class AddAttendence : Form
    {
        DBConnection db = new DBConnection();
        public AddAttendence()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard s = new Dashboard();
            s.Show();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtname.Text)){
                errorProvider1.SetError(txtname, "Enter Name");
                return;
            }
            else{
                errorProvider1.SetError(txtname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtid.Text))
            {
                errorProvider2.SetError(txtid, "Enter ID");
                return;
            }
            else
            {
                errorProvider2.SetError(txtid, string.Empty);
            }
            if (string.IsNullOrEmpty(txtcls.Text))
            {
                errorProvider3.SetError(txtcls, "Enter Class");
                return;
            }
            else
            {
                errorProvider3.SetError(txtcls, string.Empty);
            }
            if (string.IsNullOrEmpty(txtroom.Text))
            {
                errorProvider4.SetError(txtroom, "Enter Name1");
                return;
            }
            else
            {
                errorProvider4.SetError(txtroom, string.Empty);
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider5.SetError(comboBox1, "Select options");
                return;
            }
            else
            {
                errorProvider5.SetError(comboBox1, string.Empty);
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                errorProvider6.SetError(comboBox2, "Select options");
                return;
            }
            else
            {
                errorProvider6.SetError(comboBox1, string.Empty);
            }
            int Id = int.Parse(txtid.Text);
            Int32 room = Int32.Parse(txtroom.Text);
            db.SqlQuery("Insert into Attendence(StudID, Name, Class, RoomNo, Date, Absence, OnLeave, Reason) values('" + txtid.Text + "', '" + txtname.Text + "',  '" + txtcls.Text + "',  '" + txtroom.Text + "',  '" + CindatePicker.Text + "', '" + comboBox1.Text + "',  '" + comboBox2.Text + "', '" + Reason.Text + "')");
            MessageBox.Show("Attendence Recorded!");
            clearAll();

        }
        public void clearAll() {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtcls.Text = string.Empty;
            txtroom.Text = string.Empty;
            CindatePicker.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            Reason.Text = string.Empty;

        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtid.Text != " ")
                {
                    DataTable dt = db.GetTableData("Select Name, RoomID,Class from NewStud where ID='" + txtid.Text + "' ");
                    if (dt.Rows.Count != 0)
                    {
                        txtname.Text = dt.Rows[0][0].ToString();
                        txtroom.Text = dt.Rows[0][1].ToString();
                        txtcls.Text = dt.Rows[0][2].ToString();
                    }
                }
                else
                {
                    clearAll();
                    MessageBox.Show("No Record Exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void AddAttendence_Load(object sender, EventArgs e)
        {

        }
        
    }
}
