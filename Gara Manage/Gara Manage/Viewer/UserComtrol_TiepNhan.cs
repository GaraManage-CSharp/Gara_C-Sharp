using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Gara_Manage.Viewer
{
    public partial class UserComtrol_TiepNhan : UserControl
    {
        GARAOTOEntities test;
        public UserComtrol_TiepNhan()
        {
            InitializeComponent();
        }

        private void UserComtrol_TiepNhan_Load(object sender, EventArgs e)
        {
            txtDChi.Enabled = true;
            txtEmail.Enabled = true;
            dteNNhan.Enabled = true;
            txtTKHang.Enabled = true;
            txtBSXe.Enabled = true;
            txtSDThoai.Enabled = true;
            test = new GARAOTOEntities();
            tIEPNHANBindingSource.DataSource = test.TIEPNHAN.ToList();
        }

        private void btnTNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var tn = new TIEPNHAN();
                tn.SDT = txtSDThoai.Text;
                tn.NGAYNHAN = dteNNhan.Value;
                tn.TENKH = txtTKHang.Text;
                tn.EMAIL = txtEmail.Text;
                tn.DIACHI = txtDChi.Text;
                tn.BIENSO = txtBSXe.Text;
                tn.idHX = int.Parse(cbxHXe.Text);
                test.TIEPNHAN.Add(tn);
                test.SaveChangesAsync();
                dataGridView1.DataSource = new GARAOTOEntities().TIEPNHAN.ToList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}