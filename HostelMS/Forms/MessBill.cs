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
    public partial class MessBill : Form
    {
        DBConnection db = new DBConnection();
        public MessBill()
        {
            InitializeComponent();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtid.Text != " ")
                {
                    DataTable dt = db.GetTableData("Select  Name, RoomID, Class from NewStud where ID = '" + txtid.Text + "'");

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
        public void clearAll()
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtroom.Text = string.Empty;
            txtcls.Text = string.Empty;
            txtbill.Text = string.Empty;
            txtamt.Text = string.Empty;
            txtdue.Text = string.Empty;
            Month.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtbill.Text))
            {
                errorProvider1.SetError(txtbill, "Enter Bill no");
                return;
            }
            else
            {
                errorProvider1.SetError(txtbill, string.Empty);
            }
            if (string.IsNullOrEmpty(txtamt.Text))
            {
                errorProvider2.SetError(txtamt, "Enter amount");
                return;
            }
            else
            {
                errorProvider2.SetError(txtamt, string.Empty);
            }
            int Id = int.Parse(txtid.Text);
            Int32 room = Int32.Parse(txtroom.Text);
            Int32 bill = Int32.Parse(txtbill.Text);
            int amt = int.Parse(txtamt.Text);
            int due = int.Parse(txtbill.Text);
            db.SqlQuery("insert into MessBill (Mbill, StudID, Name, RoomID, Class, Month, Amount, D_Amount) values ('" + txtbill.Text + "', '" + txtid.Text + "','" + txtname.Text + "','" + txtroom.Text + "', '" + txtcls.Text + "','" + Month.Text + "','" + txtamt.Text + "','" + txtdue.Text + "')");
            MessageBox.Show("Data Recorded!");
            clearAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 79, 85, 89);
        }

        private void MessBill_Load(object sender, EventArgs e)
        {

        }

       
        }
    }

