using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;


namespace Gara_Manage.Viewer
{
    public partial class UserComtrol_TiepNhan : UserControl
    {
        GARAOTOEntities test;
        public UserComtrol_TiepNhan()
        {
            InitializeComponent();
            test = new GARAOTOEntities();
            tIEPNHANBindingSource.DataSource = test.TIEPNHAN.ToList();
            LoadHieuXe();
        }

        private int getIdHX(string value)
        {
            string s = "";
            foreach(char c in value)
            {
                if (c != ',')
                {
                    s += c;
                }
                else
                {
                    break;
                }
            }
            return int.Parse(s);
        }

        private void btnTNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTKHang.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập tên khách hàng.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                var tn = new TIEPNHAN();
                tn.TENKH = txtTKHang.Text;
                tn.NGAYNHAN = dteNNhan.Value;
                if (txtSDThoai.Text.Length == 0)
                {
                    tn.SDT = null;
                }else
                {
                    if(txtSDThoai.Text.Length == 10 || txtSDThoai.Text.Length == 11)
                    {
                        tn.SDT = txtSDThoai.Text;
                    } else
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (txtEmail.Text.Length == 0)
                {
                    tn.EMAIL = null;
                } else
                {
                    tn.EMAIL = txtEmail.Text;
                }

                if (txtDChi.Text.Length == 0)
                {
                    tn.DIACHI = null;
                } else
                {
                    tn.DIACHI = txtDChi.Text;

                }
                
                if (cbxHXe.SelectedIndex == 0)
                {
                    tn.BIENSO = null;
                } else
                {
                        tn.BIENSO = txtBSXe.Text;
                }
                tn.idHX = getIdHX(cbxHXe.SelectedItem.ToString());
                test.TIEPNHAN.Add(tn);
                test.SaveChanges();
                tIEPNHANBindingSource.Add(tn);
                tIEPNHANBindingSource.EndEdit();
                txtBSXe.Clear();
                txtDChi.Clear();
                txtEmail.Clear();
                txtSDThoai.Clear();
                txtTKHang.Clear();
                cbxHXe.SelectedIndex = 0;
                MAIN.Flag.FlagTiepNhanSuaChua = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                test.TIEPNHAN.Remove(tIEPNHANBindingSource.Current as TIEPNHAN);
                tIEPNHANBindingSource.RemoveCurrent();
                test.SaveChangesAsync();
            }
        }

        private void txtSDThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void LoadHieuXe()
        {
            DbSet<HIEUXE> db = test.HIEUXE;
            cbxHXe.Items.Clear();
            foreach(HIEUXE hx in db)
            {
                cbxHXe.Items.Add(hx.idHX + ", " + hx.TENHX);
            }
            if (cbxHXe.Items.Count != 0)
            {
                cbxHXe.SelectedIndex = 0;
            }
        }

        private void cbxHXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxHXe.SelectedIndex == 0)
            {
                txtBSXe.Enabled = false;
            }
            else
            {
                txtBSXe.Enabled = true;
            }
        }

        private void UserComtrol_TiepNhan_Click(object sender, EventArgs e)
        {
            if (MAIN.Flag.FlagQuanLyHieuXe)
            {
                LoadHieuXe();
                MAIN.Flag.FlagQuanLyHieuXe = false;
            }
        }
    }
}