namespace Gara_Manage.Viewer
{
    partial class UserControl_HoaDon
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
            this.cmbMTNhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNTNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTKHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBSXe = new System.Windows.Forms.TextBox();
            this.btnXHDon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTTien = new System.Windows.Forms.TextBox();
            this.btnLMoi = new System.Windows.Forms.Button();
            this.dgvPTung = new System.Windows.Forms.DataGridView();
            this.txtTCong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tiếp nhận";
            // 
            // cmbMTNhan
            // 
            this.cmbMTNhan.FormattingEnabled = true;
            this.cmbMTNhan.Location = new System.Drawing.Point(121, 14);
            this.cmbMTNhan.Name = "cmbMTNhan";
            this.cmbMTNhan.Size = new System.Drawing.Size(179, 21);
            this.cmbMTNhan.TabIndex = 1;
            this.cmbMTNhan.SelectedIndexChanged += new System.EventHandler(this.cmbMTNhan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày tiếp nhận";
            // 
            // txtNTNhan
            // 
            this.txtNTNhan.Enabled = false;
            this.txtNTNhan.Location = new System.Drawing.Point(391, 14);
            this.txtNTNhan.Name = "txtNTNhan";
            this.txtNTNhan.ShortcutsEnabled = false;
            this.txtNTNhan.Size = new System.Drawing.Size(171, 20);
            this.txtNTNhan.TabIndex = 2;
            this.txtNTNhan.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtTKHang
            // 
            this.txtTKHang.Enabled = false;
            this.txtTKHang.Location = new System.Drawing.Point(121, 48);
            this.txtTKHang.Name = "txtTKHang";
            this.txtTKHang.Size = new System.Drawing.Size(179, 20);
            this.txtTKHang.TabIndex = 3;
            this.txtTKHang.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biển số xe";
            // 
            // txtBSXe
            // 
            this.txtBSXe.Enabled = false;
            this.txtBSXe.Location = new System.Drawing.Point(391, 48);
            this.txtBSXe.Name = "txtBSXe";
            this.txtBSXe.Size = new System.Drawing.Size(171, 20);
            this.txtBSXe.TabIndex = 4;
            this.txtBSXe.TabStop = false;
            // 
            // btnXHDon
            // 
            this.btnXHDon.Location = new System.Drawing.Point(422, 366);
            this.btnXHDon.Name = "btnXHDon";
            this.btnXHDon.Size = new System.Drawing.Size(94, 23);
            this.btnXHDon.TabIndex = 9;
            this.btnXHDon.Text = "Xuất hoá đơn";
            this.btnXHDon.UseVisualStyleBackColor = true;
            this.btnXHDon.Click += new System.EventHandler(this.btnXHDon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền";
            // 
            // txtTTien
            // 
            this.txtTTien.Enabled = false;
            this.txtTTien.Location = new System.Drawing.Point(121, 390);
            this.txtTTien.Name = "txtTTien";
            this.txtTTien.Size = new System.Drawing.Size(179, 20);
            this.txtTTien.TabIndex = 8;
            this.txtTTien.TabStop = false;
            // 
            // btnLMoi
            // 
            this.btnLMoi.Location = new System.Drawing.Point(261, 78);
            this.btnLMoi.Name = "btnLMoi";
            this.btnLMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLMoi.TabIndex = 5;
            this.btnLMoi.Text = "Làm mới";
            this.btnLMoi.UseVisualStyleBackColor = true;
            this.btnLMoi.Click += new System.EventHandler(this.btnLMoi_Click);
            // 
            // dgvPTung
            // 
            this.dgvPTung.AllowUserToAddRows = false;
            this.dgvPTung.BackgroundColor = System.Drawing.Color.White;
            this.dgvPTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTung.Location = new System.Drawing.Point(17, 109);
            this.dgvPTung.Name = "dgvPTung";
            this.dgvPTung.ReadOnly = true;
            this.dgvPTung.Size = new System.Drawing.Size(564, 251);
            this.dgvPTung.TabIndex = 6;
            // 
            // txtTCong
            // 
            this.txtTCong.Enabled = false;
            this.txtTCong.Location = new System.Drawing.Point(121, 366);
            this.txtTCong.Name = "txtTCong";
            this.txtTCong.Size = new System.Drawing.Size(179, 20);
            this.txtTCong.TabIndex = 7;
            this.txtTCong.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tiền công";
            // 
            // UserControl_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTCong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPTung);
            this.Controls.Add(this.btnLMoi);
            this.Controls.Add(this.txtTTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXHDon);
            this.Controls.Add(this.txtBSXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTKHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNTNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMTNhan);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_HoaDon";
            this.Size = new System.Drawing.Size(596, 413);
            this.Load += new System.EventHandler(this.UserControl_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMTNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNTNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTKHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBSXe;
        private System.Windows.Forms.Button btnXHDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTTien;
        private System.Windows.Forms.Button btnLMoi;
        private System.Windows.Forms.DataGridView dgvPTung;
        private System.Windows.Forms.TextBox txtTCong;
        private System.Windows.Forms.Label label6;
    }
}
