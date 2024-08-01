using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using HostelMS.Forms;

namespace HostelMS.Reports
{
    public partial class AdmissionReport : Form
    {
        public AdmissionReport()
        {
            InitializeComponent();
        }

        private void AddRoombtn_Click(object sender, EventArgs e)
        {
            this.AdmissionTableAdapter.FilterDate(this.AdminDataSet.Admission, dateTimePicker1.Value,dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void AdmissionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AdminDataSet.Admission' table. You can move, or remove it, as needed.
            this.AdmissionTableAdapter.Fill(this.AdminDataSet.Admission);
            // TODO: This line of code loads data into the 'AdminDataSet.Admission' table. You can move, or remove it, as needed.
            //this.AdmissionTableAdapter.Fill(this.AdminDataSet.Admission);

            //this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportDash a = new ReportDash();
            a.Show();
            this.Hide();
        }

    }

        
    }

