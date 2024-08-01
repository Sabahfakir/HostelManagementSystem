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
    public partial class FeesReport : Form
    {
        public FeesReport()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void FeesReport_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'feeDataSet.HostelFees' table. You can move, or remove it, as needed.
            this.hostelFeesTableAdapter.Fill(this.feeDataSet.HostelFees);

        
        }

        private void AddRoombtn_Click(object sender, EventArgs e)
        {
            this.feeDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'feeDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.feeDataSet.DataTable1,comboBox1.SelectedValue.ToString());
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
