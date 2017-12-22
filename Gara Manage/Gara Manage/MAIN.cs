using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gara_Manage
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            tabTNhan.Controls.Add(new Viewer.UserComtrol_TiepNhan());
            tabSChua.Controls.Add(new Viewer.UserControl_SuaChua());
            tabHDon.Controls.Add(new Viewer.UserControl_HoaDon());
            tabNKho.Controls.Add(new Viewer.UserControl_NhapKho());
            tabTKe.Controls.Add(new Viewer.UserControl_ThongKe());
            tabQL_TC.Controls.Add(new Viewer.UserControl_QuanLy_TienCong());
            tabQL_PT.Controls.Add(new Viewer.UserControl_QuanLy_PhuTung());
            tabQL_TN.Controls.Add(new Viewer.UserControl_QuanLy_TiepNhan());
            tabQL_HX.Controls.Add(new Viewer.UserControl_QuanLy_HieuXe());
        }
    }
}
