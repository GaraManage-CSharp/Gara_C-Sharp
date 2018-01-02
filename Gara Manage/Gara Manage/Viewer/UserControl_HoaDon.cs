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
            Fill();
        }
        private void commboMTNhan_Load()
        { 
            string sql = "select h.idTN, tenkh, tongtien from TIEPNHAN t, hoadon h where t.idtn=h.idtn";
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader red = cmd.ExecuteReader(); // ExecuteReader() xài khi câu truy vấn trả về bảng
            int i = 0;
            while (red.Read())
            {
                cmbMTNhan.Items.Add("{" + " "+ red.GetValue(0) + ", " + red.GetValue(1) + ", " + red.GetValue(2)+" }");
            }
            cmbMTNhan.SelectedIndex = 0;
            txtNTNhan.Text = XuLyChuoi(cmbMTNhan.SelectedItem.ToString()).ToString();

        }
        
        private int XuLyChuoi(string xl)
        {
            int i = 0;
            for(int j = 2; xl.ElementAt(j) >= '0' && xl.ElementAt(j) <= '9'; j++)
            {
                    i = i * 10 + xl.ElementAt(j)-'0';
            }
            return i;
        }
        private void Fill()
        {
            string sql = "select h.idTN, tenkh, tongtien from TIEPNHAN t, hoadon h where t.idtn=h.idtn";
            SqlCommand sqlcomd = new SqlCommand(sql, SQL.Connection);
            SqlDataAdapter sqldap = new SqlDataAdapter(sql,SQL.Connection);
            DataTable dt = new DataTable();
            sqldap.Fill(dt);
            dgvPTung.DataSource = dt;
        }
    }

  
}
