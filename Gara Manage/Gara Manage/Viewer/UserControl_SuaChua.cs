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
    public partial class UserControl_SuaChua : UserControl
    {
        public UserControl_SuaChua()
        {
            InitializeComponent();
        }

        private void UserControl_SuaChua_Load(object sender, EventArgs e)
        {
            mtn();
            Pt();
            TC();
            show();
        }
        private void TC()
        {
            string sql = "select TENTC,idTC from TIENCONG ";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTC.DisplayMember = "idTC";
            cmbTC.ValueMember = "idTC";
            cmbTC.DataSource = dt;

        }
        private void mtn()
        {
            string sql = "select idTN, tenkh from TIEPNHAN ";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMTNhan.DisplayMember = "idTN";
            cmbMTNhan.ValueMember = "idTN";
            cmbMTNhan.DataSource = dt;

        }
        private void Pt()
        {
            string sql = "select TENPT,idPT from PHUTUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPTung.DisplayMember = "idPT";
            cmbPTung.ValueMember = "idPT";
            cmbPTung.DataSource = dt;
        }

        DataTable tbSC = new DataTable();
        //private void datatable()
        //{
        //    // tạo cột trong dgv 
        //    tbSC.Columns.Add(cmbMTNhan.Text.ToString());
        //    tbSC.Columns.Add(cmbPTung.Text.ToString());
        //    tbSC.Columns.Add("Số Lượng");
        //    dgvSChua.DataSource   = tbSC;
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = " insert into CTSC(idTN,SL,idPT, idTC,Ngay) values (@idTN,@SL,@idPT,@idTC,GETDATE())  exec thanhtien";
                SqlCommand cm = new SqlCommand();
                cm.Connection = SQL.Connection;
                cm.Parameters.Add("@idTN", SqlDbType.Int).Value = int.Parse(cmbMTNhan.SelectedValue.ToString());
                cm.Parameters.Add("@SL", SqlDbType.BigInt).Value = numSLuong.Value;
                cm.Parameters.Add("@idPT", SqlDbType.Int).Value = int.Parse(cmbPTung.SelectedValue.ToString());
                cm.Parameters.Add("@idTC", SqlDbType.Int).Value = int.Parse(cmbTC.SelectedValue.ToString());
                cm.CommandText = sql;
                cm.ExecuteNonQuery();
                dgvSChua.Refresh();
                dgvSChua.Update();
                show();
                TinhTien();
            }
            catch
            {
                MessageBox.Show("Lỗi Nhé ^^");
            }
        }
        private void show()
        {
            string sql = "select c.idCTSC,c.idTN,p.idPT, p.TENPT, p.GIABAN, c.SL, ti.TENTC,ti.GIA,c.THANHTIEN" +
                " from PHUTUNG p, CTSC c, TIEPNHAN t , TIENCONG ti" +

                " where p.idPT = c.idPT and c.idTN = t.idTN and ti.idTC = c.idTC and t.idTN = @idTN";
            SqlCommand cm = new SqlCommand(sql, SQL.Connection);
            cm.Parameters.Add("@idTN", SqlDbType.Int).Value = int.Parse(cmbMTNhan.SelectedValue.ToString());
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSChua.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete CTSC where idCTSC = @idCTSC";

            SqlCommand cm = new SqlCommand();
            cm.Connection = SQL.Connection;
            DataTable dt = (DataTable)dgvSChua.DataSource;
            DataRow dr = dt.Rows[dgvSChua.CurrentRow.Index];
            cm.CommandText = sql;
            cm.Parameters.Add("@idCTSC", SqlDbType.Int).Value = int.Parse(dr["idCTSC"].ToString());
            cm.ExecuteNonQuery();
            dgvSChua.Refresh();
            dgvSChua.Update();
            show();
            TinhTien();
        }

        private void btnXNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất Hóa Đơn Thành Công");
        }

        private void cmbMTNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
            TinhTien();
        }
        private void TinhTien()
        {
            DataTable dt = (DataTable)dgvSChua.DataSource;
            int tongtien = 0;
            DataRowCollection rows = dt.Rows;
            foreach (DataRow dr in rows)
            {
                tongtien += int.Parse(dr["THANHTIEN"].ToString());
            }
            txtTTien.Text = tongtien.ToString();
        }
    }
    
}
    

