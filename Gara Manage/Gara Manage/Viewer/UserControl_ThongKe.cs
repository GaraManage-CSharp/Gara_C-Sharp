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
    public partial class UserControl_ThongKe : UserControl
    {
        public UserControl_ThongKe()
        {
            InitializeComponent();
            LoadCmbBCDS();
            LoadCmbBCPT();
        }

        private void LoadCmbBCDS()
        {
            cmbDSThang.Items.Clear();
            string comd = "select distinct month(NGAY),year(NGAY) from HOADON";
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = comd;
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                cmbDSThang.Items.Add(red.GetInt32(0) + "/" + red.GetInt32(1));
            }
            red.Close();
            if (cmbDSThang.Items.Count != 0)
            {
                cmbDSThang.SelectedIndex = 0;
            }
        }
        private void LoadCmbBCPT()
        {
            cmbBCThang.Items.Clear();
            string comd = "select distinct month(NGAY),year(NGAY) from CTSC";
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = comd;
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                cmbBCThang.Items.Add(red.GetInt32(0) + "/" + red.GetInt32(1));
            }
            red.Close();
            if (cmbBCThang.Items.Count != 0)
            {
                cmbBCThang.SelectedIndex = 0;
            }
        }

        private int getMonth(string value)
        {
            string s = "";
            foreach(char c in value)
            {
                if(c != '/')
                {
                    s += c;
                } else
                {
                    break;
                }
            }
            return int.Parse(s);
        }

        private int getYear(string value)
        {
            string s = "";
            int len = value.Length - 1;
            while (value.ElementAt(len) != '/')
            {
                s = value.ElementAt(len) + s;
                len--;
            }
            return int.Parse(s);
        }

        private void SelectBCDS()
        {
            int tongtien = 0;
            string comd = "select t.idTN , t.TENKH, t.BIENSO,h.TONGTIEN from HOADON h, TIEPNHAN t where t.idTN = h.idTN and month(h.NGAY) = @THANG and year(h.NGAY) = @NAM";
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = comd;
            cmd.Parameters.Add("@THANG", SqlDbType.Int).Value = getMonth(cmbDSThang.SelectedItem.ToString());
            cmd.Parameters.Add("@NAM", SqlDbType.Int).Value = getYear(cmbDSThang.SelectedItem.ToString());
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dgvDSo.DataSource = dt;
            DataRowCollection rows = dt.Rows;
            foreach (DataRow dr in rows)
            {
                int tt = int.Parse(dr["TONGTIEN"].ToString());
                tongtien += tt;
            }
            txtTDTThang.Text = string.Format("{0:0,000} VNĐ", tongtien);
        }

        private void cmbDSThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBCDS();
        }

        private void SelectBCPT()
        {
            string comd = "exec BCPTtonghop @THANG, @NAM";
            SqlCommand cmd = SQL.Connection.CreateCommand();
            cmd.CommandText = comd;
            cmd.Parameters.Add("@THANG", SqlDbType.Int).Value = getMonth(cmbBCThang.SelectedItem.ToString());
            cmd.Parameters.Add("@NAM", SqlDbType.Int).Value = getYear(cmbBCThang.SelectedItem.ToString());
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dgvPTTon.DataSource = dt;
        }

        private void cmbBCThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBCPT();
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            if (MAIN.Flag.FlagHoaDonBaoCao)
            {
                LoadCmbBCDS();
                MAIN.Flag.FlagHoaDonBaoCao = false;
            }
        }

        private void splitContainer1_Panel2_Click(object sender, EventArgs e)
        {
            if (MAIN.Flag.FlagQuanLyPhuTungBaoCao || MAIN.Flag.FlagNhapKho || MAIN.Flag.FlagSuaChua)
            {
                LoadCmbBCPT();
                MAIN.Flag.FlagQuanLyPhuTungBaoCao = false;
                MAIN.Flag.FlagNhapKho = false;
                MAIN.Flag.FlagSuaChua = false;
            }
        }
    }
}
