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
    public partial class UserControl_QuanLy_PhuTung : UserControl
    {
        public UserControl_QuanLy_PhuTung()
        {
            InitializeComponent();
            load_tblPhuTung();
        }

        

        private void load_tblPhuTung()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqldap = new SqlDataAdapter("select * from phutung", SQL.Connection);
            sqldap.Fill(dt);
            dgvPTung.DataSource = dt;
            
            txtPTTung.Text = "";
            numGTien.Value = 0;
            txtLoc.Text = "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sqldap = new SqlDataAdapter("select * from phutung where tenPT like N'%" + txtLoc.Text + "%'", SQL.Connection);
                sqldap.Fill(dt);
                dgvPTung.DataSource = dt;

                txtPTTung.Text = "";
                numGTien.Value = 0;
                txtLoc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiểm tra dữ liệu nhập
            if (txtPTTung.Text == "" || numGTien.Value < 1 || cbxDVT.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập có lỗi", "Lỗi");
                return;
            }

            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();
                cmd.CommandText = "insert into PHUTUNG values(@tenPT,@DVT, @giaPT,0)";
                cmd.Parameters.Add("@tenPT", SqlDbType.NVarChar);
                cmd.Parameters.Add("@DVT", SqlDbType.NVarChar);
                cmd.Parameters.Add("@giaPT", SqlDbType.BigInt);

                cmd.Parameters["@tenPT"].Value = txtPTTung.Text;
                cmd.Parameters["@DVT"].Value = cbxDVT.Text;
                cmd.Parameters["@giaPT"].Value = numGTien.Value;

                cmd.ExecuteNonQuery();

                MessageBox.Show("đã thêm phụ tùng");

                txtPTTung.Text = "";
                numGTien.Value = 0;

                load_tblPhuTung();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // kiểm tra dữ liệu nhập
            if (txtPTTung.Text == "" || numGTien.Value < 1)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi", "Lỗi");
                return;
            }

            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();
                cmd.CommandText = "UPDATE PHUTUNG set tenPT=@tenPT,DVT=@DVT, GIABAN=@giaPT where idPT= @id";
                cmd.Parameters.Add("@tenPT", SqlDbType.NVarChar);
                cmd.Parameters.Add("@DVT", SqlDbType.NVarChar);
                cmd.Parameters.Add("@giaPT", SqlDbType.BigInt);
                cmd.Parameters.Add("@id", SqlDbType.Int);

                DataTable dt = (DataTable)dgvPTung.DataSource;
                DataRow dr = dt.Rows[dgvPTung.CurrentRow.Index];

                cmd.Parameters["@tenPT"].Value = txtPTTung.Text;
                cmd.Parameters["@DVT"].Value = cbxDVT.Text;
                cmd.Parameters["@giaPT"].Value = numGTien.Value;
                cmd.Parameters["@id"].Value = int.Parse(dr[0].ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("đã sửa phụ tùng");

                txtPTTung.Text = "";
                cbxDVT.Text = "";
                numGTien.Value = 0;
                btnThem.Visible = true;
                btnXacNhan.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("không thê sửa phụ tùng");
            }

            load_tblPhuTung();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvPTung.DataSource;
                DataRow dr = dt.Rows[dgvPTung.CurrentRow.Index];
                txtPTTung.Text = dr[1].ToString();
                cbxDVT.Text = dr[2].ToString();
                numGTien.Value = int.Parse(dr[3].ToString());

                btnXacNhan.Visible = true;
                btnThem.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sqldap = new SqlDataAdapter("select * from phutung where tenPT like N'%" + txtLoc.Text + "%'", SQL.Connection);
                sqldap.Fill(dt);
                dgvPTung.DataSource = dt;

                //txtPTTung.Text = "";
                //numGTien.Value = 0;
                //txtLoc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = SQL.Connection.CreateCommand();
                cmd.CommandText = "DELETE PHUTUNG where idPT= @id --and @id not in(select distinct idpt from ctsc)";
                
                cmd.Parameters.Add("@id", SqlDbType.Int);

                DataTable dt = (DataTable)dgvPTung.DataSource;
                DataRow dr = dt.Rows[dgvPTung.CurrentRow.Index];

                cmd.Parameters["@id"].Value = int.Parse(dr[0].ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("đã xóa phụ tùng");

                txtPTTung.Text = "";
                cbxDVT.Text = "";
                numGTien.Value = 0;
                btnThem.Visible = true;
                btnXacNhan.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("không xóa sửa phụ tùng");
            }

            load_tblPhuTung();
        }


        //void check_btnDVT(string nameDVT)
        //{
        //    bool TonTai = false;

        //    for(int i=0; i<cbxDVT.Items.Count; i++)
        //    {
        //        if(nameDVT == cbxDVT.Items[i].ToString())
        //        {
        //            TonTai = true;
        //        }
        //    }
        //    if(TonTai == false)
        //    {
        //        cbxDVT.Items.Add(new object[] { nameDVT});
        //    }
        //}

        //private void cbxDVT_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Enter:
        //            {
        //                check_btnDVT(cbxDVT.Text);
        //                break;
        //            }
        //    }
        //}
    }
    
    
}
