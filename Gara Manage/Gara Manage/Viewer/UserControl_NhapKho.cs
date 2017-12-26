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
    public partial class UserControl_NhapKho : UserControl
    {
        int i = 0;
        public UserControl_NhapKho()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPTung.Rows[dgvPTung.CurrentRow.Index].Cells[0].Value=i++;
        }
    }
}
