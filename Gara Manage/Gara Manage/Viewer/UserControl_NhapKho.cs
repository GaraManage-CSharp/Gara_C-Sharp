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
            
            show();


        }
       
        private void btnThem_Click(object sender, EventArgs e)

        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = SQL.Connection;
            DataTable dt = (DataTable)dgvPTung.DataSource;
            DataRow dr = dt.Rows[dgvPTung.CurrentRow.Index];
            cm.CommandText = updatetable();
            cm.Parameters.Add("@SLTON", SqlDbType.Int).Value = numSLuong.Value;
            cm.Parameters.Add("@idPT", SqlDbType.Int).Value = int.Parse(dr["idPT"].ToString());
            cm.ExecuteNonQuery();
            dgvPTung.Refresh();
            dgvPTung.Update();
            show();
            MessageBox.Show("Cập Nhật Thành Công ^_^ ");
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
        private string updatetable()
        {
            return " update PHUTUNG set SLTON = SLTON + @SLTON where  idPT = @idPT ";
        }

        private void btnXNhan_Click(object sender, EventArgs e)
        {
        
        }
    }
}
