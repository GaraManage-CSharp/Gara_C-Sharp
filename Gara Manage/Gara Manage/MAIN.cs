﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }
    }
}
