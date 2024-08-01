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
    public partial class Admission : Form
    {
        DBConnection db = new DBConnection();
        public Admission()
        {
            InitializeComponent();
        }

        private void svbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                errorProvider1.SetError(txtname, "Enter Name!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtclass.Text.Trim()))
            {
                errorProvider2.SetError(txtclass, "Enter Class!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtclass, string.Empty);
            }
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                errorProvider3.SetError(comboBox1, "Enter Room No!");
                return;
            }
            else
            {
                errorProvider3.SetError(comboBox1, string.Empty);
            }
            if (txtid.Text != "" && txtname.Text != "" && txtclass.Text != "" && comboBox1.Text != "" && leaveDatePicker.Text != "" && adDatePicker.Text != "")
            {
                try
                {
                    int id = int.Parse(txtid.Text);
                    Int32 roomno = Int32.Parse(comboBox1.Text);
                }
                catch(FormatException) { }

           
            try
            {
                db.SqlQuery("Insert into Admission(ID, Name, Class, RoomNo, AdDate, LDate) values('" + txtid.Text + "','" + txtname.Text + "','" + txtclass.Text + "','" + comboBox1.Text + "', '"+adDatePicker.Text+"', '"+leaveDatePicker.Text+"')");
                MessageBox.Show("Student Admited Successfully!");
            }
            catch (SqlException) { }

            clearAll();
        }
            else
            {
                MessageBox.Show("Please fill the empty fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            getMaxId();
        }
        private void Admission_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetTableData("Select RoomID from Room where Available='Yes' and Alloted = 'No'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Int64 room = Int64.Parse(dt.Rows[i][0].ToString());
                comboBox1.Items.Add(room);

            }
            getMaxId();
        }
        void getMaxId()
        {
            txtid.Text = db.GetAutoID("Select MAX(ID) from Admission").ToString();
        }
        public void clearAll()
        {
            
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            adDatePicker.Text = string.Empty;
            txtclass.Text = string.Empty;
            leaveDatePicker.Text = string.Empty;
            comboBox1.SelectedIndex = -1;


        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }
    }
}
