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
    public partial class MessBillReport : Form
    {
        public MessBillReport()
        {
            InitializeComponent();
        }

        private void MessBillReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MessDataSet.MessBill' table. You can move, or remove it, as needed.
            
        }

        private void AddRoombtn_Click(object sender, EventArgs e)
        {
            this.MessBillTableAdapter.Fill(this.MessDataSet.MessBill);

            this.reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportDash a = new ReportDash();
            a.Show();
            this.Hide();

        }
    }
}
