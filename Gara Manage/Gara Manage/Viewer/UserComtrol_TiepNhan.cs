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
            tIEPNHANBindingSource.DataSource = test.TIEPNHANs.ToList();
        }

        private void btnTNhan_Click(object sender, EventArgs e)
        {
            //tIEPNHANBindingSource.EndEdit();
            //test.SaveChangesAsync();

            //BindingSource bds = (BindingSource)dataGridView1.DataSource;
            //List<TIEPNHAN> lst = (List<TIEPNHAN>)bds.DataSource;
            
            TIEPNHAN tn = new TIEPNHAN();
            tn.SDT = txtSDThoai.Text;
            tn.NGAYNHAN = dteNNhan.Value;
            tn.TENKH = txtTKHang.Text;
            tn.EMAIL = txtEmail.Text;
            tn.DIACHI = txtDChi.Text;
            tn.BIENSO = txtBSXe.Text;
            test.TIEPNHANs.Add(tn);
            tIEPNHANBindingSource.Add(tn);
            tIEPNHANBindingSource.MoveLast();
            tIEPNHANBindingSource.EndEdit();
            test.SaveChanges();
            txtBSXe.Focus();
            txtDChi.Focus();
            txtEmail.Focus();
            txtSDThoai.Focus();
            txtTKHang.Focus();
            //tIEPNHANBindingSource.EndEdit();
            //lst.Add(tn);
            //tIEPNHANBindingSource.Add(tn);
        }
    }
}
