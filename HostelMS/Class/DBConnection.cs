using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostelMS
{
    class DBConnection
    {
        SqlConnection con;
        public DBConnection()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\sabah fakir\OneDrive\Documents\Visual Programming\MajorProject\HostelMS\HostelMS\Database\Hostel.mdf;Integrated Security=True;User Instance=True");
            con.Open();
        }
        public DataTable GetTableData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void SqlQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public int GetAutoID(string sql)
        {
            int i = 1;
            try
            {
                DataTable dt = GetTableData(sql);
                if (dt.Rows.Count >= 1)
                {
                    i = (int.Parse(dt.Rows[0][0].ToString()) + 1);
                }
                else
                    i = 1;
            }
            catch
            {
                i = 1;
            }
            return i;
        }
        public void FillGrid(DataGridView dv, string sql)
        {
            DataTable dt = GetTableData(sql);
            dv.DataSource = dt;


        }
    }
}
