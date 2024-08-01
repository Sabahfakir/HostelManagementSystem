using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HostelMS.Forms;

namespace HostelMS.Reports
{
    public partial class RoomAvailability : Form
    {
        public RoomAvailability()
        {
            InitializeComponent();
        }

        private void RoomAvailability_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'AdminDataSet.Admission' table. You can move, or remove it, as needed.
            this.AdmissionTableAdapter.Fill(this.AdminDataSet.Admission);
            // TODO: This line of code loads data into the 'roomDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.roomDataSet.Room);
            // TODO: This line of code loads data into the 'roomDataSet.Room1' table. You can move, or remove it, as needed.



        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void AddRoombtn_Click_1(object sender, EventArgs e)
        {

            this.roomDataSet.EnforceConstraints = false;
            this.room1TableAdapter.Fill(this.roomDataSet.Room1, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportDash a = new ReportDash();
            a.Show();
            this.Hide();
        }

      

    }
}
