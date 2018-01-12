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
    public partial class UserControl_QuanLy_TienCong : UserControl
    {
        public UserControl_QuanLy_TienCong()
        {
            InitializeComponent();
            load_tblTienCong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiểm tra dữ liệu nhập
            if(txtTienCong.Text == "" || numGTien.Value < 1)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi", "Lỗi");
                return;
            }

            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();
                cmd.CommandText = "insert into TIENCONG values(@tenTC, @giaTC)";
                cmd.Parameters.Add("@tenTC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@giaTC", SqlDbType.BigInt);

                cmd.Parameters["@tenTC"].Value = txtTienCong.Text;
                cmd.Parameters["@giaTC"].Value = numGTien.Value;

                cmd.ExecuteNonQuery();

                MessageBox.Show("đã thêm phụ tùng");

                txtTienCong.Text = "";
                numGTien.Value = 0;

                load_tblTienCong();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvTCong.DataSource;
                DataRow dr = dt.Rows[dgvTCong.CurrentRow.Index];
                txtTienCong.Text = dr[1].ToString();
                numGTien.Value = int.Parse(dr[2].ToString());

                btnXacNhan.Visible = true;
                btnThem.Visible = false;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //btnThem.Text = "Xác nhận";
            //dgvTCong.Enabled = false;
            //btnLMoi.Enabled = false;
            //btnLoc.Enabled = false;
            //btnSua.Enabled = false;
            //txtLoc.Enabled = false;
            //cmbLTheo.Enabled = false;
            //label4.Text = "Sữa tiền công";
        }
        private string getUpdateString(string s,string s1, string value)
        {
            return "update TIENCONG set TENTC = N'" + s + "', GIA = " +s1+ " where idTC = "+ value;
        }

        /// <summary>
        /// load bảng tiền công
        /// </summary>
        private void  load_tblTienCong()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqldap = new SqlDataAdapter("select * from tiencong", SQL.Connection);
            sqldap.Fill(dt);
            dgvTCong.DataSource = dt;

            txtTienCong.Text = "";
            numGTien.Value = 0;
            txtLoc.Text = "";
        }

        private void btnLMoi_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            

            // kiểm tra dữ liệu nhập
            if (txtTienCong.Text == "" || numGTien.Value < 1)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi", "Lỗi");
                return;
            }

            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();

                // nếu tiền công có idTC trong CTSC thì không xóa
                cmd.CommandText = "UPDATE TIENCONG set tenTC=@tenTC, GIA=@giaTC where idtc= @id  and @id not in (select distinct idtc from ctsc)";
                cmd.Parameters.Add("@tenTC", SqlDbType.NVarChar);
                cmd.Parameters.Add("@giaTC", SqlDbType.BigInt);
                cmd.Parameters.Add("@id", SqlDbType.Int);

                DataTable dt = (DataTable)dgvTCong.DataSource;
                DataRow dr = dt.Rows[dgvTCong.CurrentRow.Index];

                cmd.Parameters["@tenTC"].Value = txtTienCong.Text;
                cmd.Parameters["@giaTC"].Value = numGTien.Value;
                cmd.Parameters["@id"].Value = int.Parse(dr[0].ToString());

                cmd.ExecuteNonQuery();

                dgvTCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                //MessageBox.Show("đã sửa phụ tùng");



            }
            catch (Exception ex)
            {
                
                MessageBox.Show("không thể sửa tiền công: "+"'" + txtTienCong.Text +"'");
            }

            load_tblTienCong();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
           try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sqldap = new SqlDataAdapter("select * from tiencong where tenTC like N'%" + txtLoc.Text + "%'", SQL.Connection);
                sqldap.Fill(dt);
                dgvTCong.DataSource = dt;

                txtTienCong.Text = "";
                numGTien.Value = 0;
                txtLoc.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
    
    
}
