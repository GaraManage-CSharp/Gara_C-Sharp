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
                cmd.CommandText = "insert into HOADON (@idTN, getdate(), null)  exec tongtien";
                
                cmd.Parameters.Add("@idTN", SqlDbType.Int);

                DataTable dt = (DataTable)dgvKhHang.DataSource;
                DataRow dr = dt.Rows[dgvKhHang.CurrentRow.Index];

                
                cmd.Parameters["@idTN"].Value = int.Parse(dr[0].ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("đã sửa thêm HD");

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("không thê sửa phụ tùng");
            }

            Load_HoaDon();
            Load_KhHang();

        }

    }
}



