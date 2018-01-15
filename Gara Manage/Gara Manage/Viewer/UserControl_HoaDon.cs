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
    public partial class UserControl_HoaDon : UserControl
    {
        
        public UserControl_HoaDon()
        {
            InitializeComponent();
            Load_KhHang();
            Load_HoaDon();
            
        }

        /// <summary>
        /// lấy ra những lượt tiếp nhân chưa được lập hóa đơn và đang có trong bảng CTSC
        /// </summary>
        void Load_KhHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqldap = new SqlDataAdapter("exec chonHD", SQL.Connection);
            sqldap.Fill(dt);
            dgvKhHang.DataSource = dt;
        }

        /// <summary>
        /// lấy ra các hóa đơn của ngày hôm nay
        /// </summary>
        void Load_HoaDon()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqldap = new SqlDataAdapter("exec loadtableHD", SQL.Connection);
            sqldap.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();
                cmd.CommandText = "insert into HOADON values (@idTN, getdate(), null)  exec tongtien";
                
                cmd.Parameters.Add("@idTN", SqlDbType.Int);

                DataTable dt = (DataTable)dgvKhHang.DataSource;
                DataRow dr = dt.Rows[dgvKhHang.CurrentRow.Index];

                
                cmd.Parameters["@idTN"].Value = int.Parse(dr[0].ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("đã thêm HD");

                Load_HoaDon();
                Load_KhHang();

                MAIN.Flag.FlagHoaDonSuaChua = true;
                MAIN.Flag.FlagHoaDonBaoCao = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("không thể thêm hóa đơn");
            }

           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();
                string comd = "delete HOADON where idHD = @idHD";

                cmd.CommandText = comd;

                DataTable dt = (DataTable)dgvHoaDon.DataSource;
                DataRow dr = dt.Rows[dgvHoaDon.CurrentRow.Index];

                cmd.Parameters.Add("@idHD", SqlDbType.Int).Value = int.Parse(dr[0].ToString());
                cmd.ExecuteNonQuery();


                Load_HoaDon();
                Load_KhHang();

                MAIN.Flag.FlagHoaDonBaoCao = true;
                MAIN.Flag.FlagHoaDonSuaChua = true;
            } catch
            {

            }
        }

        private void UserControl_HoaDon_Click(object sender, EventArgs e)
        {
            if (MAIN.Flag.FlagSuaChua)
            {
                Load_KhHang();
                MAIN.Flag.FlagSuaChua = false;
            }
        }
    }
}



