namespace Gara_Manage.Viewer
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
            this.bttnLMoi = new System.Windows.Forms.Button();
            this.dgvSChua = new System.Windows.Forms.DataGridView();
            this.clidTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSChua)).BeginInit();
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(522, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 75);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(522, 252);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 75);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXNhan
            // 
            this.btnXNhan.Location = new System.Drawing.Point(375, 351);
            this.btnXNhan.Name = "btnXNhan";
            this.btnXNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXNhan.TabIndex = 11;
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
            this.label3.Location = new System.Drawing.Point(25, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thành tiền";
            // 
            // txtTTien
            // 
            this.txtTTien.Enabled = false;
            this.txtTTien.Location = new System.Drawing.Point(118, 353);
            this.txtTTien.Name = "txtTTien";
            this.txtTTien.Size = new System.Drawing.Size(177, 20);
            this.txtTTien.TabIndex = 10;
            this.txtTTien.TabStop = false;
            // 
            // bttnLMoi
            // 
            this.bttnLMoi.Location = new System.Drawing.Point(522, 81);
            this.bttnLMoi.Name = "bttnLMoi";
            this.bttnLMoi.Size = new System.Drawing.Size(75, 75);
            this.bttnLMoi.TabIndex = 6;
            this.bttnLMoi.Text = "Làm mới";
            this.bttnLMoi.UseVisualStyleBackColor = true;
            // 
            // dgvSChua
            // 
            this.dgvSChua.AllowUserToAddRows = false;
            this.dgvSChua.AllowUserToDeleteRows = false;
            this.dgvSChua.BackgroundColor = System.Drawing.Color.White;
            this.dgvSChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidTN,
            this.clPT,
            this.clSL});
            this.dgvSChua.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvSChua.Location = new System.Drawing.Point(3, 81);
            this.dgvSChua.Name = "dgvSChua";
            this.dgvSChua.ReadOnly = true;
            this.dgvSChua.Size = new System.Drawing.Size(489, 246);
            this.dgvSChua.TabIndex = 5;
            // 
            // clidTN
            // 
            this.clidTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clidTN.HeaderText = "idTN";
            this.clidTN.Name = "clidTN";
            this.clidTN.ReadOnly = true;
            // 
            // clPT
            // 
            this.clPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPT.HeaderText = "Phụ Tùng";
            this.clPT.Name = "clPT";
            this.clPT.ReadOnly = true;
            // 
            // clSL
            // 
            this.clSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSL.HeaderText = "Số Lượng";
            this.clSL.Name = "clSL";
            this.clSL.ReadOnly = true;
            // 
            // UserControl_SuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvSChua);
            this.Controls.Add(this.bttnLMoi);
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
            this.Load += new System.EventHandler(this.UserControl_SuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSChua)).EndInit();
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
        private System.Windows.Forms.Button bttnLMoi;
        private System.Windows.Forms.DataGridView dgvSChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSL;
    }
}
