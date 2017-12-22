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
            tabTNhan.Controls.Add(new UserComtrol_TiepNhan());
            tabSChua.Controls.Add(new UserControl_SuaChua());
            tabHDon.Controls.Add(new UserControl_HoaDon());
            tabNKho.Controls.Add(new UserControl_NhapKho());
        }
    }
}
