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
            Fill_cmbLTheo();
            cmbLTheo.SelectedIndex = 0;
            Select();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTCong.Text.CompareTo("")==0)
            {
                MessageBox.Show("Vui lòng điền tiền công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            } else
            {
                if (btnThem.Text.CompareTo("Thêm") == 0)
                {
                    try
                    {
                        string comd = getInsertString(txtTCong.Text, (int)numGTien.Value);
                        SqlCommand cmd = SQL.Connection.CreateCommand();
                        cmd.CommandText = comd;
                        cmd.ExecuteNonQuery();
                        txtTCong.Text = "";
                        numGTien.Value = 0;
                        Select();
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tiền công này đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    try
                    {
                        DataTable dt = (DataTable) dgvTCong.DataSource;
                        DataRow dr = dt.Rows[dgvTCong.CurrentRow.Index];
                        string comd = getUpdateString(txtTCong.Text, numGTien.Value.ToString(), dr[0].ToString());
                        SqlCommand cmd = SQL.Connection.CreateCommand();
                        cmd.CommandText = comd;
                        cmd.ExecuteNonQuery();
                        dr[1] = txtTCong.Text;
                        dr[2] = numGTien.Value.ToString();
                        btnThem.Text = "Thêm";
                        txtTCong.Text = "";
                        numGTien.Value = 0;
                        dgvTCong.Enabled = true;
                        btnLMoi.Enabled = true;
                        btnLoc.Enabled = true;
                        btnSua.Enabled = true;
                        txtLoc.Enabled = true;
                        cmbLTheo.Enabled = true;
                        label4.Text = "Thêm tiền công";
                        MessageBox.Show("Chỉnh sữa thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tiền công này đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void Fill_cmbLTheo()
        {
            GARAOTODataSet gARAOTODataSet = new GARAOTODataSet();
            cmbLTheo.Items.Add("");
            cmbLTheo.Items.Add(gARAOTODataSet.TIENCONG.idTCColumn.ToString());
            cmbLTheo.Items.Add(gARAOTODataSet.TIENCONG.TENTCColumn.ToString());
            cmbLTheo.Items.Add(gARAOTODataSet.TIENCONG.GIAColumn.ToString());
        }
        private string getInsertString(string name, int value)
        {
            return "insert into TIENCONG(TENTC,GIA) values (N'" + name + "'," + value + ")";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Select();
        }
        private string getSelectTienCong(string s)
        {
            string comd = "select idTC, TENTC, GIA from TIENCONG";
            return s.CompareTo("") == 0 ? comd : comd + " where " + s;
        }

        private void cmbLTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLTheo.SelectedIndex ==0)
            {
                txtLoc.Enabled = false;
            } else
            {
                txtLoc.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvTCong.DataSource;
            DataRow dr = dt.Rows[dgvTCong.CurrentRow.Index];
            txtTCong.Text = dr[1].ToString();
            numGTien.Value = int.Parse(dr[2].ToString());
            btnThem.Text = "Xác nhận";
            dgvTCong.Enabled = false;
            btnLMoi.Enabled = false;
            btnLoc.Enabled = false;
            btnSua.Enabled = false;
            txtLoc.Enabled = false;
            cmbLTheo.Enabled = false;
            label4.Text = "Sữa tiền công";
        }
        private string getUpdateString(string s,string s1, string value)
        {
            return "update TIENCONG set TENTC = N'" + s + "', GIA = " +s1+ " where idTC = "+ value;
        }
        private void Select ()
        {
            int i;
            string comd;
            switch (cmbLTheo.SelectedIndex)
            {
                case 0:
                    comd = getSelectTienCong("");
                    break;
                case 2:
                    comd = getSelectTienCong(cmbLTheo.SelectedItem.ToString() + " like " + "N'" + txtLoc.Text + "%'");
                    break;
                default:
                    if (int.TryParse(txtLoc.Text, out i))
                    {
                        comd = getSelectTienCong(cmbLTheo.SelectedItem.ToString() + " = " + i.ToString());
                    }
                    else
                    {
                        MessageBox.Show(cmbLTheo.SelectedItem.ToString() + " Không hợp lệ", "Thông bào.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
            }
            DataTable dt = new DataTable();
            SqlDataAdapter sqldap = new SqlDataAdapter(comd, SQL.Connection);
            sqldap.Fill(dt);
            dgvTCong.DataSource = dt;
        }

        private void btnLMoi_Click(object sender, EventArgs e)
        {
            Select();
        }
    }
    
    
}
