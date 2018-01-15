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
       
        private void PT()
        {
            string sql = "select TENPT,idPT from PHUTUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPT.DisplayMember = "idPT";
            cmbPT.ValueMember = "idPT";
            cmbPT.DataSource = dt;

        }
        private void btnThem_Click(object sender, EventArgs e)

        {
            string sql = "insert into NHAPPHUTUNG(SLNHAP,idPT,NGAYNHAP) values (@SL,@idPT,GETDATE())";
            SqlCommand cm = new SqlCommand();
            cm.Connection = SQL.Connection;
            cm.CommandText = sql;
            cm.Parameters.Add("@SL", SqlDbType.Int).Value = numSLuong.Value;
            cm.Parameters.Add("@idPT", SqlDbType.Int).Value = int.Parse(cmbPT.SelectedValue.ToString());
            
            cm.ExecuteNonQuery();
            dgvPTung.Refresh();
            dgvPTung.Update();
            show();
            MessageBox.Show("Cập Nhật Thành Công ^_^ ");
        }
        private void show()
        {
            string sql = "select a.idPT,a.NGAYNHAP,SLNHAP,b.SLTON from NHAPPHUTUNG a,PHUTUNG b where a.idPT = b.idPt";
            SqlCommand cm = new SqlCommand(sql, SQL.Connection);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvPTung.DataSource = dt;
            PT();
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
