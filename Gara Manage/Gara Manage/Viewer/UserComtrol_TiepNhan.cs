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
        private GARAOTOEntities test;
        public UserComtrol_TiepNhan()
        {
            InitializeComponent();
        }

        private void UserComtrol_TiepNhan_Load(object sender, EventArgs e)
        {
            test = new GARAOTOEntities();
            tIEPNHANBindingSource.DataSource = test.TIEPNHAN.ToList();
        }

        private void btnTNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var tn = new TIEPNHAN();
                tn.SDT = txtSDThoai.Text;
                tn.NGAYNHAN = DateTime.Now;
                tn.TENKH = txtTKHang.Text;
                tn.EMAIL = txtEmail.Text;
                tn.DIACHI = txtDChi.Text;
                tn.BIENSO = txtBSXe.Text;
                tn.idHX = int.Parse(cbxHXe.Text);
                test.TIEPNHAN.Add(tn);
                test.SaveChanges();
                var hd = new HOADON();
                hd.idTN = tn.idTN;
                hd.TONGTIEN = 0;
                hd.TinhTien = false;
                hd.NGAY = null;
                test.HOADON.Add(hd);
                test.SaveChanges();

                tIEPNHANBindingSource.Add(tn);
                tIEPNHANBindingSource.EndEdit();


                txtBSXe.Clear();
                txtDChi.Clear();
                txtEmail.Clear();
                txtSDThoai.Clear();
                txtTKHang.Clear();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}