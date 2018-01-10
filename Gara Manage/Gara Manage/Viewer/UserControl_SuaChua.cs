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
            SChua();
        }
        private void mtn()
        {
            string sql = "select idTN from TIEPNHAN ";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMTNhan.DisplayMember = "idTN";
            cmbMTNhan.ValueMember = "idTN";
            cmbMTNhan.DataSource = dt;

        }
        private void Pt()
        {
            string sql = "select TENPT from PHUTUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, SQL.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPTung.DisplayMember = "TENPT";
            cmbPTung.ValueMember = "TENPT";
            cmbPTung.DataSource = dt;
        }
        private void SChua()
        {

        }
        DataTable tbSC = new DataTable();
        private void datatable()
        {
            // tạo cột trong dgv 
            tbSC.Columns.Add(cmbMTNhan.Text.ToString());
            tbSC.Columns.Add(cmbPTung.Text.ToString());
            tbSC.Columns.Add("Số Lượng");
            dgvSChua.DataSource = tbSC;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tbSC.Rows.Count; i++)
            {
                Button b = (Button)sender;
                DataRow r = tbSC.Rows[i];
                if (r[cmbMTNhan.Text].ToString().CompareTo(b.Text) == 0) // nếu món ăn trùng thì cộng dồn
                {
                    int sl = int.Parse(r["Số lượng"].ToString());
                    sl++;
                    r["Số lượng"] = sl;
                    return;
                }
            }
        }
    }
}
