using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HostelMS.Reports;

namespace HostelMS.Forms
{
    public partial class ReportDash : Form
    {
        public ReportDash()
        {
            InitializeComponent();
        }

        private void ManageRoom_Click(object sender, EventArgs e)
        {
            RoomAvailability ra = new RoomAvailability();
            ra.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdmissionReport ar = new AdmissionReport();
            this.Hide();
            ar.Show();
        }

        private void NewStudent_Click(object sender, EventArgs e)
        {
            FeesReport fr = new FeesReport();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessBillReport mr = new MessBillReport();
            mr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

       
    }
}
