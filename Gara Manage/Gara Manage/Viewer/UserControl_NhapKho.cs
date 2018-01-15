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
            cmbPT.DisplayMember = "TENPT";
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

            MAIN.Flag.FlagNhapKho = true;
        }
        private void show()
        {
            string sql = "select a.idPT,b.TenPT,a.NGAYNHAP,SLNHAP from NHAPPHUTUNG a,PHUTUNG b where a.idPT = b.idPt and day(a.NGAYNHAP) = day(getdate()) and month(a.NGAYNHAP) = month(getdate()) and year(a.NGAYNHAP) = year(getdate())";
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

        private void UserControl_NhapKho_Click(object sender, EventArgs e)
        {
            if (MAIN.Flag.FlagQuanLyPhuTungNhapKho)
            {
                PT();
                MAIN.Flag.FlagQuanLyPhuTungNhapKho = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string comd = "delete NHAPPHUTUNG where idPT = @idPT and NGAYNHAP = @NGAYNHAP";
            DataTable dt = (DataTable)dgvPTung.DataSource;
            DataRow dr = dt.Rows[dgvPTung.CurrentRow.Index];
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = comd;
            cmd.Parameters.Add("@idPT", SqlDbType.Int).Value = int.Parse(dr[0].ToString());
            cmd.Parameters.Add("@NGAYNHAP", SqlDbType.SmallDateTime).Value = DateTime.Parse(dr["NGAYNHAP"].ToString());
            cmd.ExecuteNonQuery();
            dt.Rows.RemoveAt(dgvPTung.CurrentRow.Index);
            MAIN.Flag.FlagNhapKho = true;
        }
    }
}
