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
            commboMTNhan_Load();
        }
        private void commboMTNhan_Load()
        {
            Fill_cmbMTNhan();
            if(cmbMTNhan.Items.Count!=0)
            {
                cmbMTNhan.SelectedIndex = 0;
            }
        }
        private void Fill_cmbMTNhan()
        {
            string sql =  "select h.idTN, tenkh, tongtien from TIEPNHAN t, hoadon h where t.idtn=h.idtn and TinhTien = 0";
            cmbMTNhan.Items.Clear();
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader red = cmd.ExecuteReader(); // ExecuteReader() xài khi câu truy vấn trả về bảng
            while (red.Read())
            {
                cmbMTNhan.Items.Add(red.GetValue(0) + ", " + red.GetValue(1) + ", " + red.GetValue(2));
            }
            red.Close();
        }
        
        private void cmbMTNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_dgvPTung();
            Fill_Info();
        }
        private int catID(string s)
        {
            int value = 0;
            for(int i=0; char.IsNumber(s.ElementAt<char>(i));i++)
            {
                value = value * 10 + s.ElementAt<char>(i) - '0';
            }
            return value;
        }
        private void Fill_dgvPTung()
        {
            if (cmbMTNhan.Text.CompareTo("") == 0)
                return;

            string sql = " select [Tên phụ tùng] = tenpt, [Số lượng] = c.SL, [Đơn giá] = GiaBan, [Thành tiền] = thanhtien" +
                         " from TIEPNHAN t, HOADON h, PHUTUNG p, CTSC c" +
                         " where t.idTN = h.idTN and c.idTN = h.idTN and c.idPT = p.idPT and h.idTN = " + catID(cmbMTNhan.SelectedItem.ToString());
            SqlCommand sqlcomd = new SqlCommand(sql, SQL.Connection);
            SqlDataAdapter sqldap = new SqlDataAdapter(sqlcomd);
            DataTable dt = new DataTable();
            sqldap.Fill(dt);
            dgvPTung.DataSource = dt;
        }

        private void btnLMoi_Click(object sender, EventArgs e)
        {
            Fill_cmbMTNhan();
            if (cmbMTNhan.Items.Count != 0)
            {
                cmbMTNhan.SelectedIndex = 0;
            }

        }
        private void Fill_Info()
        {
            if (cmbMTNhan.Text.CompareTo("") == 0)
                return;

            string comd = "select ngaynhan, tenkh, bienso, tentc, gia , tongtien" +
                          " from TIEPNHAN t, TIENCONG ti, HOADON h, CTSC c" +
                          " where t.idTN = h.idTN and c.idTN = h.idTN and ti.idTC = c.idTC and h.idTN = " + catID(cmbMTNhan.SelectedItem.ToString());
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = comd;
            SqlDataReader red = cmd.ExecuteReader();
            red.Read();
            txtNTNhan.Text = red.GetSqlDateTime(0).Value.ToString();
            txtTKHang.Text = red.GetString(1);
            txtBSXe.Text = red.GetString(2);
            txtTCong.Text = red.GetString(3) + ", " + red.GetInt64(4);
            txtTTien.Text = string.Format("{0: 0 000.000} VND",red.GetDouble(5));
            red.Close();
        }

        private void UserControl_HoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXHDon_Click(object sender, EventArgs e)
        {
            if(cmbMTNhan.Text.CompareTo("")==0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else
            {
                string nof = "\nKhách hàng: "+txtTKHang.Text+ "\nBiển số xe: "+txtBSXe.Text+ "\nTổng tiền: " +txtTTien.Text;
                DialogResult a =MessageBox.Show(nof,"Xuất hóa đơn", MessageBoxButtons.OKCancel);
                if(a == DialogResult.OK)
                {
                    string comd = "update HOADON set TinhTien = 1 where idTN = " + catID(cmbMTNhan.SelectedItem.ToString());
                    SqlCommand cmd = SQL.Connection.CreateCommand();
                    cmd.CommandText = comd;
                    cmd.ExecuteNonQuery();
                    cmbMTNhan.Items.Remove(cmbMTNhan.SelectedItem);
                    cmbMTNhan.Text = "";
                    txtTTien.Clear();
                    txtTKHang.Clear();
                    txtTCong.Clear();
                    txtNTNhan.Clear();
                    txtBSXe.Clear();
                    dgvPTung.DataSource = null;
                    if (cmbMTNhan.Items.Count != 0)
                    {
                        cmbMTNhan.Text = cmbMTNhan.Items[0].ToString();
                        cmbMTNhan.SelectedIndex = 0;
                    }
                }
            }
        }
    }


}
