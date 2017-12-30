namespace Gara_Manage.Viewer
{
    partial class UserControl_NhapKho
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
            this.btnXNhan = new System.Windows.Forms.Button();
            this.dgvPTung = new System.Windows.Forms.DataGridView();
            this.dgvPTung_clnSTTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPTung_clnPTung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPTung_clnNVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPTung_clnSLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numDGia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXNhan
            // 
            this.btnXNhan.Location = new System.Drawing.Point(530, 304);
            this.btnXNhan.Name = "btnXNhan";
            this.btnXNhan.Size = new System.Drawing.Size(55, 55);
            this.btnXNhan.TabIndex = 6;
            this.btnXNhan.Text = "Xác nhận";
            this.btnXNhan.UseVisualStyleBackColor = true;
            // 
            // dgvPTung
            // 
            this.dgvPTung.AllowUserToAddRows = false;
            this.dgvPTung.BackgroundColor = System.Drawing.Color.White;
            this.dgvPTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPTung_clnSTTu,
            this.dgvPTung_clnPTung,
            this.dgvPTung_clnNVien,
            this.dgvPTung_clnSLuong});
            this.dgvPTung.Location = new System.Drawing.Point(12, 83);
            this.dgvPTung.Name = "dgvPTung";
            this.dgvPTung.ReadOnly = true;
            this.dgvPTung.Size = new System.Drawing.Size(509, 314);
            this.dgvPTung.TabIndex = 4;
            this.dgvPTung.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // dgvPTung_clnSTTu
            // 
            this.dgvPTung_clnSTTu.HeaderText = "STT";
            this.dgvPTung_clnSTTu.Name = "dgvPTung_clnSTTu";
            this.dgvPTung_clnSTTu.ReadOnly = true;
            this.dgvPTung_clnSTTu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPTung_clnSTTu.Width = 50;
            // 
            // dgvPTung_clnPTung
            // 
            this.dgvPTung_clnPTung.HeaderText = "Phụ tùng";
            this.dgvPTung_clnPTung.Name = "dgvPTung_clnPTung";
            this.dgvPTung_clnPTung.ReadOnly = true;
            this.dgvPTung_clnPTung.Width = 200;
            // 
            // dgvPTung_clnNVien
            // 
            this.dgvPTung_clnNVien.HeaderText = "Nhân viên";
            this.dgvPTung_clnNVien.Name = "dgvPTung_clnNVien";
            this.dgvPTung_clnNVien.ReadOnly = true;
            this.dgvPTung_clnNVien.Width = 120;
            // 
            // dgvPTung_clnSLuong
            // 
            this.dgvPTung_clnSLuong.HeaderText = "Số lượng";
            this.dgvPTung_clnSLuong.Name = "dgvPTung_clnSLuong";
            this.dgvPTung_clnSLuong.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phụ tùng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số lượng";
            // 
            // numSLuong
            // 
            this.numSLuong.Location = new System.Drawing.Point(360, 12);
            this.numSLuong.Name = "numSLuong";
            this.numSLuong.Size = new System.Drawing.Size(75, 20);
            this.numSLuong.TabIndex = 2;
            this.numSLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(477, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(530, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 55);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đơn giá";
            // 
            // numDGia
            // 
            this.numDGia.Location = new System.Drawing.Point(360, 45);
            this.numDGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDGia.Name = "numDGia";
            this.numDGia.Size = new System.Drawing.Size(75, 20);
            this.numDGia.TabIndex = 13;
            this.numDGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserControl_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numDGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPTung);
            this.Controls.Add(this.btnXNhan);
            this.Name = "UserControl_NhapKho";
            this.Size = new System.Drawing.Size(596, 413);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXNhan;
        private System.Windows.Forms.DataGridView dgvPTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPTung_clnSTTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPTung_clnPTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPTung_clnNVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPTung_clnSLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDGia;
    }
}
