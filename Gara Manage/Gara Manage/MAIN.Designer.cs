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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếpNhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụTừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhụTùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiLoạiPhụTùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáPhụTùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệuXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHiệuXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáHiệuXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiHiệuXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themTiềnCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáTiềnCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiTiềnCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoSốLượngPhụTùngTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaChữaToolStripMenuItem,
            this.phụTừngToolStripMenuItem,
            this.hiệuXeToolStripMenuItem,
            this.tiềnCôngToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sửaChữaToolStripMenuItem
            // 
            this.sửaChữaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiếpNhậnToolStripMenuItem});
            this.sửaChữaToolStripMenuItem.Name = "sửaChữaToolStripMenuItem";
            this.sửaChữaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sửaChữaToolStripMenuItem.Text = "Sửa chữa";
            // 
            // tiếpNhậnToolStripMenuItem
            // 
            this.tiếpNhậnToolStripMenuItem.Name = "tiếpNhậnToolStripMenuItem";
            this.tiếpNhậnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tiếpNhậnToolStripMenuItem.Text = "Tiếp nhận";
            // 
            // phụTừngToolStripMenuItem
            // 
            this.phụTừngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmPhụTùngToolStripMenuItem,
            this.thayĐổiLoạiPhụTùngToolStripMenuItem,
            this.xoáPhụTùngToolStripMenuItem});
            this.phụTừngToolStripMenuItem.Name = "phụTừngToolStripMenuItem";
            this.phụTừngToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.phụTừngToolStripMenuItem.Text = "Phụ tùng";
            // 
            // thêmPhụTùngToolStripMenuItem
            // 
            this.thêmPhụTùngToolStripMenuItem.Name = "thêmPhụTùngToolStripMenuItem";
            this.thêmPhụTùngToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.thêmPhụTùngToolStripMenuItem.Text = "Thêm phụ tùng";
            // 
            // thayĐổiLoạiPhụTùngToolStripMenuItem
            // 
            this.thayĐổiLoạiPhụTùngToolStripMenuItem.Name = "thayĐổiLoạiPhụTùngToolStripMenuItem";
            this.thayĐổiLoạiPhụTùngToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.thayĐổiLoạiPhụTùngToolStripMenuItem.Text = "Thay đổi loại phụ tùng";
            // 
            // xoáPhụTùngToolStripMenuItem
            // 
            this.xoáPhụTùngToolStripMenuItem.Name = "xoáPhụTùngToolStripMenuItem";
            this.xoáPhụTùngToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.xoáPhụTùngToolStripMenuItem.Text = "Xoá phụ tùng";
            // 
            // hiệuXeToolStripMenuItem
            // 
            this.hiệuXeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHiệuXeToolStripMenuItem,
            this.xoáHiệuXeToolStripMenuItem,
            this.thayĐổiHiệuXeToolStripMenuItem});
            this.hiệuXeToolStripMenuItem.Name = "hiệuXeToolStripMenuItem";
            this.hiệuXeToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.hiệuXeToolStripMenuItem.Text = "Hiệu xe";
            // 
            // thêmHiệuXeToolStripMenuItem
            // 
            this.thêmHiệuXeToolStripMenuItem.Name = "thêmHiệuXeToolStripMenuItem";
            this.thêmHiệuXeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.thêmHiệuXeToolStripMenuItem.Text = "Thêm hiệu xe";
            // 
            // xoáHiệuXeToolStripMenuItem
            // 
            this.xoáHiệuXeToolStripMenuItem.Name = "xoáHiệuXeToolStripMenuItem";
            this.xoáHiệuXeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.xoáHiệuXeToolStripMenuItem.Text = "Xoá hiệu xe";
            // 
            // thayĐổiHiệuXeToolStripMenuItem
            // 
            this.thayĐổiHiệuXeToolStripMenuItem.Name = "thayĐổiHiệuXeToolStripMenuItem";
            this.thayĐổiHiệuXeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.thayĐổiHiệuXeToolStripMenuItem.Text = "Thay đổi hiệu xe";
            // 
            // tiềnCôngToolStripMenuItem
            // 
            this.tiềnCôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTiềnCôngToolStripMenuItem,
            this.xoáTiềnCôngToolStripMenuItem,
            this.thayĐổiTiềnCôngToolStripMenuItem});
            this.tiềnCôngToolStripMenuItem.Name = "tiềnCôngToolStripMenuItem";
            this.tiềnCôngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tiềnCôngToolStripMenuItem.Text = "Tiền công";
            // 
            // themTiềnCôngToolStripMenuItem
            // 
            this.themTiềnCôngToolStripMenuItem.Name = "themTiềnCôngToolStripMenuItem";
            this.themTiềnCôngToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.themTiềnCôngToolStripMenuItem.Text = "Thêm tiền công";
            // 
            // xoáTiềnCôngToolStripMenuItem
            // 
            this.xoáTiềnCôngToolStripMenuItem.Name = "xoáTiềnCôngToolStripMenuItem";
            this.xoáTiềnCôngToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.xoáTiềnCôngToolStripMenuItem.Text = "Xoá tiền công";
            // 
            // thayĐổiTiềnCôngToolStripMenuItem
            // 
            this.thayĐổiTiềnCôngToolStripMenuItem.Name = "thayĐổiTiềnCôngToolStripMenuItem";
            this.thayĐổiTiềnCôngToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.thayĐổiTiềnCôngToolStripMenuItem.Text = "Thay đổi tiền công";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoDoanhThuToolStripMenuItem,
            this.báoCáoSốLượngPhụTùngTồnToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.báoCáoToolStripMenuItem.Text = "Khác";
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            this.báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            this.báoCáoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            // 
            // báoCáoSốLượngPhụTùngTồnToolStripMenuItem
            // 
            this.báoCáoSốLượngPhụTùngTồnToolStripMenuItem.Name = "báoCáoSốLượngPhụTùngTồnToolStripMenuItem";
            this.báoCáoSốLượngPhụTùngTồnToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.báoCáoSốLượngPhụTùngTồnToolStripMenuItem.Text = "Báo cáo số lượng phụ tùng tồn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gara_Manage.Properties.Resources.MAIN_BG_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 643);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAIN";
            this.Text = "Quản lý gara";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiếpNhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụTừngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmPhụTùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiLoạiPhụTùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáPhụTùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệuXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHiệuXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáHiệuXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiHiệuXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themTiềnCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáTiềnCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiTiềnCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoSốLượngPhụTùngTồnToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

