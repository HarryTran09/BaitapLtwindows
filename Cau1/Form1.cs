using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1
{
    public partial class Form1 : Form
    {
        private int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ST98KNR\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvemployee.Rows.Add(reader.GetInt32(0), reader.GetString(5));
                }
            }
            conn.Close();
        }

        private void dgvemployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbid.Text = dgvemployee.Rows[idx].Cells[0].Value.ToString();
            tbname.Text = dgvemployee.Rows[idx].Cells[1].Value.ToString();
            dtpngaysinh.Text = dgvemployee.Rows[idx].Cells[2].Value.ToString();
            cbgtnam.Text = dgvemployee.Rows[idx].Cells[3].Value.ToString();
            cbdonvi.Text = dgvemployee.Rows[idx].Cells[4].Value.ToString();
            tbnoisinh.Text = dgvemployee.Rows[idx].Cells[5].Value.ToString();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-ST98KNR\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=sa";
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into customer values(" + tbid.Text + ", '" + tbname.Text + "', '" + dtpngaysinh.Text + "', '" + cbgtnam.Text + "', '" + cbdonvi.Text + "', '" + tbnoisinh.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvemployee.Rows.Add(tbid.Text, tbname.Text, dtpngaysinh.Text, cbgtnam.Text, cbdonvi.Text, tbnoisinh.Text);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-ST98KNR\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=sa";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name = '" + tbname.Text + "' where IdEmployee = " + tbid.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dgvemployee.CurrentCell.RowIndex;
            dgvemployee.Rows[idx].Cells[1].Value = tbname.Text;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-ST98KNR\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=sa";
            conn.Open();
            SqlCommand cmd = new SqlCommand(" delete from customer where IdEmployee= " + tbid.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dgvemployee.CurrentCell.RowIndex;
            dgvemployee.Rows.RemoveAt(index);
        }
    }
}
