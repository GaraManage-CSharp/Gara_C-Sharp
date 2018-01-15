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
    public partial class UserControl_QuanLy_HieuXe : UserControl
    {

        GARAOTOEntities5 test;
        private bool fl;
        public UserControl_QuanLy_HieuXe()
        {
            InitializeComponent();
            fl = false;
        }

        private void UserControl_QuanLy_HieuXe_Load(object sender, EventArgs e)
        {
            txtHXe.Enabled = true;
            txtTim.Enabled = true;
            test = new GARAOTOEntities5();
            hIEUXEBindingSource.DataSource = test.HIEUXEs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                var hx = new HIEUXE();
                hx.TENHX = txtHXe.Text;
                test.HIEUXEs.Add(hx);
                test.SaveChangesAsync();
                dataGridView1.DataSource = new GARAOTOEntities5().HIEUXEs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hIEUXEBindingSource.ResetBindings(false);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dataGridView1.DataSource = hIEUXEBindingSource;
            }
            else
            {
                if (char.IsNumber(txtTim.Text.ElementAt(0)))
                {
                    var query = from o in hIEUXEBindingSource.DataSource as List<HIEUXE>
                                where o.idHX == int.Parse(txtTim.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
                else
                {
                    var query = from o in hIEUXEBindingSource.DataSource as List<HIEUXE>
                                where o.TENHX.Contains(txtTim.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                test.HIEUXEs.Remove(hIEUXEBindingSource.Current as HIEUXE);
                hIEUXEBindingSource.RemoveCurrent();
                test.SaveChangesAsync();
            }
        }
    }
}
