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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void ManageRoom_Click(object sender, EventArgs e)
        {
            ManageRoom mr = new ManageRoom();
            this.Hide();
            mr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            this.Hide();
            ns.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageStudent ms = new ManageStudent();
            ms.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAttendence aa = new AddAttendence();
            aa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewAttend va = new ViewAttend();
            va.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HostelFees hs = new HostelFees();
            hs.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessBill mb = new MessBill();
            mb.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admission am = new Admission();
            am.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
            ReportDash ra = new ReportDash();
            ra.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

    }
}
