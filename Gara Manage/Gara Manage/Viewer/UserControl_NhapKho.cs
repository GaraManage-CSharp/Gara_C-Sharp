using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gara_Manage.Viewer
{
    public partial class UserControl_NhapKho : UserControl
    {
        int i = 0;
        public UserControl_NhapKho()
        {
            InitializeComponent();
            show();
        }


        /*private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPTung.Rows[dgvPTung.CurrentRow.Index].Cells[0].Value=i++;
        }*/


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    this.numSLuong = comboBox1.SelectedIndexChanged.ToString();

        }

        private void UserControl_NhapKho_Load(object sender, EventArgs e)
        {
            string sql = "select TENPT from PHUTUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TENPT";
            comboBox1.ValueMember = "TENPT";
            //numSLuong.ToString();
            show();


        }

        private void btnThem_Click(object sender, EventArgs e)

        {
           
        }
        private void show()
        {
            string sql = "select * from PHUTUNG";
            SqlCommand cm = new SqlCommand(sql, SQL.Connection);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvPTung.DataSource = dt;



        }
        private void updatetable()
        {
            try
            {
                SQL.Connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select idPT,SLTON from PHUTUNG", SQL.Connection);

                da.Fill(dt);
                dgvPTung.DataSource = dt;
                SQL.Connection.Close();
                dt.Columns["idPT"].ColumnName = "STT";
                dt.Columns["SLTON"].ColumnName = "Số lượng";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sql = "select TENPT from PHUTUNG";
            SqlCommand cm = new SqlCommand(sql, SQL.Connection);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBox1.DataSource = dt;
        }
    }
}
