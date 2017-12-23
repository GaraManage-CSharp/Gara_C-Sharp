namespace Gara_Manage
{
    partial class MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                SQL.closeConnection();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTNhan = new System.Windows.Forms.TabPage();
            this.tabSChua = new System.Windows.Forms.TabPage();
            this.tabHDon = new System.Windows.Forms.TabPage();
            this.tabNKho = new System.Windows.Forms.TabPage();
            this.tabTKe = new System.Windows.Forms.TabPage();
            this.tabQLy = new System.Windows.Forms.TabPage();
            this.tabControl1_Control2 = new System.Windows.Forms.TabControl();
            this.tabQL_TC = new System.Windows.Forms.TabPage();
            this.tabQL_PT = new System.Windows.Forms.TabPage();
            this.tabQL_TN = new System.Windows.Forms.TabPage();
            this.tabQL_HX = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabQLy.SuspendLayout();
            this.tabControl1_Control2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTNhan);
            this.tabControl1.Controls.Add(this.tabSChua);
            this.tabControl1.Controls.Add(this.tabHDon);
            this.tabControl1.Controls.Add(this.tabNKho);
            this.tabControl1.Controls.Add(this.tabTKe);
            this.tabControl1.Controls.Add(this.tabQLy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(96, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTNhan
            // 
            this.tabTNhan.BackColor = System.Drawing.Color.Transparent;
            this.tabTNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabTNhan.ForeColor = System.Drawing.Color.Black;
            this.tabTNhan.Location = new System.Drawing.Point(4, 22);
            this.tabTNhan.Name = "tabTNhan";
            this.tabTNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTNhan.Size = new System.Drawing.Size(596, 413);
            this.tabTNhan.TabIndex = 0;
            this.tabTNhan.Text = "Tiếp nhận";
            // 
            // tabSChua
            // 
            this.tabSChua.Location = new System.Drawing.Point(4, 22);
            this.tabSChua.Name = "tabSChua";
            this.tabSChua.Padding = new System.Windows.Forms.Padding(3);
            this.tabSChua.Size = new System.Drawing.Size(596, 413);
            this.tabSChua.TabIndex = 5;
            this.tabSChua.Text = "Sửa chữa";
            this.tabSChua.UseVisualStyleBackColor = true;
            // 
            // tabHDon
            // 
            this.tabHDon.BackColor = System.Drawing.Color.Transparent;
            this.tabHDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHDon.ForeColor = System.Drawing.Color.Black;
            this.tabHDon.Location = new System.Drawing.Point(4, 22);
            this.tabHDon.Name = "tabHDon";
            this.tabHDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHDon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabHDon.Size = new System.Drawing.Size(596, 413);
            this.tabHDon.TabIndex = 2;
            this.tabHDon.Text = "Hoá đơn";
            // 
            // tabNKho
            // 
            this.tabNKho.Location = new System.Drawing.Point(4, 22);
            this.tabNKho.Name = "tabNKho";
            this.tabNKho.Size = new System.Drawing.Size(596, 413);
            this.tabNKho.TabIndex = 6;
            this.tabNKho.Text = "Nhập kho";
            this.tabNKho.UseVisualStyleBackColor = true;
            // 
            // tabTKe
            // 
            this.tabTKe.BackColor = System.Drawing.Color.Transparent;
            this.tabTKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabTKe.ForeColor = System.Drawing.Color.Black;
            this.tabTKe.Location = new System.Drawing.Point(4, 22);
            this.tabTKe.Name = "tabTKe";
            this.tabTKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKe.Size = new System.Drawing.Size(596, 413);
            this.tabTKe.TabIndex = 3;
            this.tabTKe.Text = "Thống kê";
            // 
            // tabQLy
            // 
            this.tabQLy.BackColor = System.Drawing.Color.White;
            this.tabQLy.Controls.Add(this.tabControl1_Control2);
            this.tabQLy.ForeColor = System.Drawing.Color.Black;
            this.tabQLy.Location = new System.Drawing.Point(4, 22);
            this.tabQLy.Name = "tabQLy";
            this.tabQLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLy.Size = new System.Drawing.Size(596, 413);
            this.tabQLy.TabIndex = 4;
            this.tabQLy.Text = "Quản lý";
            // 
            // tabControl1_Control2
            // 
            this.tabControl1_Control2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1_Control2.Controls.Add(this.tabQL_TC);
            this.tabControl1_Control2.Controls.Add(this.tabQL_PT);
            this.tabControl1_Control2.Controls.Add(this.tabQL_TN);
            this.tabControl1_Control2.Controls.Add(this.tabQL_HX);
            this.tabControl1_Control2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1_Control2.ItemSize = new System.Drawing.Size(61, 19);
            this.tabControl1_Control2.Location = new System.Drawing.Point(3, 3);
            this.tabControl1_Control2.Name = "tabControl1_Control2";
            this.tabControl1_Control2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1_Control2.SelectedIndex = 0;
            this.tabControl1_Control2.Size = new System.Drawing.Size(590, 407);
            this.tabControl1_Control2.TabIndex = 0;
            // 
            // tabQL_TC
            // 
            this.tabQL_TC.BackColor = System.Drawing.Color.White;
            this.tabQL_TC.Location = new System.Drawing.Point(4, 4);
            this.tabQL_TC.Name = "tabQL_TC";
            this.tabQL_TC.Padding = new System.Windows.Forms.Padding(3);
            this.tabQL_TC.Size = new System.Drawing.Size(582, 380);
            this.tabQL_TC.TabIndex = 0;
            this.tabQL_TC.Text = "Tiền công";
            // 
            // tabQL_PT
            // 
            this.tabQL_PT.BackColor = System.Drawing.Color.White;
            this.tabQL_PT.Location = new System.Drawing.Point(4, 4);
            this.tabQL_PT.Name = "tabQL_PT";
            this.tabQL_PT.Padding = new System.Windows.Forms.Padding(3);
            this.tabQL_PT.Size = new System.Drawing.Size(582, 380);
            this.tabQL_PT.TabIndex = 1;
            this.tabQL_PT.Text = "Phụ tùng";
            // 
            // tabQL_TN
            // 
            this.tabQL_TN.BackColor = System.Drawing.Color.White;
            this.tabQL_TN.ForeColor = System.Drawing.Color.Black;
            this.tabQL_TN.Location = new System.Drawing.Point(4, 4);
            this.tabQL_TN.Name = "tabQL_TN";
            this.tabQL_TN.Padding = new System.Windows.Forms.Padding(3);
            this.tabQL_TN.Size = new System.Drawing.Size(582, 380);
            this.tabQL_TN.TabIndex = 2;
            this.tabQL_TN.Text = "Tiếp nhận";
            // 
            // tabQL_HX
            // 
            this.tabQL_HX.BackColor = System.Drawing.Color.White;
            this.tabQL_HX.Location = new System.Drawing.Point(4, 4);
            this.tabQL_HX.Name = "tabQL_HX";
            this.tabQL_HX.Padding = new System.Windows.Forms.Padding(3);
            this.tabQL_HX.Size = new System.Drawing.Size(582, 380);
            this.tabQL_HX.TabIndex = 3;
            this.tabQL_HX.Text = "Hiệu xe";
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 439);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý gara";
            this.tabControl1.ResumeLayout(false);
            this.tabQLy.ResumeLayout(false);
            this.tabControl1_Control2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTNhan;
        private System.Windows.Forms.TabPage tabHDon;
        private System.Windows.Forms.TabPage tabTKe;
        private System.Windows.Forms.TabPage tabQLy;
        private System.Windows.Forms.TabControl tabControl1_Control2;
        private System.Windows.Forms.TabPage tabQL_TC;
        private System.Windows.Forms.TabPage tabQL_PT;
        private System.Windows.Forms.TabPage tabQL_TN;
        private System.Windows.Forms.TabPage tabQL_HX;
        private System.Windows.Forms.TabPage tabSChua;
        private System.Windows.Forms.TabPage tabNKho;
    }
}

