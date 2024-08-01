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
    public partial class ViewAttend : Form
    {
        DBConnection db = new DBConnection();

        public ViewAttend()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

       

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }
            if (MessageBox.Show("Do you want to delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.SqlQuery("Delete Attendence Where StudID =" + txtid.Text);
                MessageBox.Show("Data Deleted Successfully!");
                db.FillGrid(dataGridView1, "Select * from Attendence");
            }
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
           // (dataGridView1.DataSource as DataTable).DefaultView.RowFilter=String.Format("Name Like '%" + txtname.Text + "%'");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("convert(StudID, 'System.String') Like '{0}'", txtid.Text);
           
        }

        private void ViewAttend_Load(object sender, EventArgs e)
        {
            db.FillGrid(dataGridView1, "Select * from Attendence");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
             txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["StudID"].FormattedValue.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
        }

        }

     

        

       
    
}
