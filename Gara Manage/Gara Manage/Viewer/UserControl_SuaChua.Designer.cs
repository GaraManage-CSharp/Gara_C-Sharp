namespace Gara_Manage
{
    partial class UserControl_SuaChua
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPTung = new System.Windows.Forms.Label();
            this.lblSLuong = new System.Windows.Forms.Label();
            this.numSLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbPTung = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXNhan = new System.Windows.Forms.Button();
            this.cmbMTNhan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTTien = new System.Windows.Forms.TextBox();
            this.lstvPTung = new System.Windows.Forms.ListView();
            this.colMPTung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTPTung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNSXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tiếp nhận";
            // 
            // lblPTung
            // 
            this.lblPTung.AutoSize = true;
            this.lblPTung.Location = new System.Drawing.Point(14, 41);
            this.lblPTung.Name = "lblPTung";
            this.lblPTung.Size = new System.Drawing.Size(50, 13);
            this.lblPTung.TabIndex = 3;
            this.lblPTung.Text = "Phụ tùng";
            // 
            // lblSLuong
            // 
            this.lblSLuong.AutoSize = true;
            this.lblSLuong.Location = new System.Drawing.Point(289, 41);
            this.lblSLuong.Name = "lblSLuong";
            this.lblSLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSLuong.TabIndex = 5;
            this.lblSLuong.Text = "Số lượng";
            // 
            // numSLuong
            // 
            this.numSLuong.Location = new System.Drawing.Point(344, 39);
            this.numSLuong.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numSLuong.Name = "numSLuong";
            this.numSLuong.Size = new System.Drawing.Size(66, 20);
            this.numSLuong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(431, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cmbPTung
            // 
            this.cmbPTung.FormattingEnabled = true;
            this.cmbPTung.Location = new System.Drawing.Point(90, 33);
            this.cmbPTung.Name = "cmbPTung";
            this.cmbPTung.Size = new System.Drawing.Size(193, 21);
            this.cmbPTung.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(522, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 75);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(522, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 75);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXNhan
            // 
            this.btnXNhan.Location = new System.Drawing.Point(375, 351);
            this.btnXNhan.Name = "btnXNhan";
            this.btnXNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXNhan.TabIndex = 10;
            this.btnXNhan.Text = "Xác nhận";
            this.btnXNhan.UseVisualStyleBackColor = true;
            // 
            // cmbMTNhan
            // 
            this.cmbMTNhan.FormattingEnabled = true;
            this.cmbMTNhan.Location = new System.Drawing.Point(90, 6);
            this.cmbMTNhan.Name = "cmbMTNhan";
            this.cmbMTNhan.Size = new System.Drawing.Size(193, 21);
            this.cmbMTNhan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thành tiền";
            // 
            // txtTTien
            // 
            this.txtTTien.Enabled = false;
            this.txtTTien.Location = new System.Drawing.Point(98, 354);
            this.txtTTien.Name = "txtTTien";
            this.txtTTien.Size = new System.Drawing.Size(177, 20);
            this.txtTTien.TabIndex = 9;
            this.txtTTien.TabStop = false;
            // 
            // lstvPTung
            // 
            this.lstvPTung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMPTung,
            this.colTPTung,
            this.colNSXuat,
            this.colSLuong,
            this.colDGia});
            this.lstvPTung.Location = new System.Drawing.Point(17, 83);
            this.lstvPTung.Name = "lstvPTung";
            this.lstvPTung.Size = new System.Drawing.Size(489, 244);
            this.lstvPTung.TabIndex = 16;
            this.lstvPTung.UseCompatibleStateImageBehavior = false;
            this.lstvPTung.View = System.Windows.Forms.View.Details;
            // 
            // colMPTung
            // 
            this.colMPTung.Text = "Mã phụ tùng";
            this.colMPTung.Width = 80;
            // 
            // colTPTung
            // 
            this.colTPTung.Text = "Tên phụ tùng";
            this.colTPTung.Width = 150;
            // 
            // colNSXuat
            // 
            this.colNSXuat.Text = "Nhà sản xuất";
            this.colNSXuat.Width = 110;
            // 
            // colSLuong
            // 
            this.colSLuong.Text = "Số lượng";
            this.colSLuong.Width = 75;
            // 
            // colDGia
            // 
            this.colDGia.Text = "Đơn giá";
            this.colDGia.Width = 70;
            // 
            // UserControl_SuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstvPTung);
            this.Controls.Add(this.txtTTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMTNhan);
            this.Controls.Add(this.btnXNhan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cmbPTung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSLuong);
            this.Controls.Add(this.lblSLuong);
            this.Controls.Add(this.lblPTung);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_SuaChua";
            this.Size = new System.Drawing.Size(612, 413);
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPTung;
        private System.Windows.Forms.Label lblSLuong;
        private System.Windows.Forms.NumericUpDown numSLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbPTung;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXNhan;
        private System.Windows.Forms.ComboBox cmbMTNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTTien;
        private System.Windows.Forms.ListView lstvPTung;
        private System.Windows.Forms.ColumnHeader colMPTung;
        private System.Windows.Forms.ColumnHeader colTPTung;
        private System.Windows.Forms.ColumnHeader colNSXuat;
        private System.Windows.Forms.ColumnHeader colSLuong;
        private System.Windows.Forms.ColumnHeader colDGia;
    }
}
