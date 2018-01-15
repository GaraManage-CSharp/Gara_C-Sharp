namespace Gara_Manage.Viewer
{
    partial class UserControl_QuanLy_PhuTung
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.numGTien = new System.Windows.Forms.NumericUpDown();
            this.txtPTTung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvPTung = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbxDVT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm phụ tùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phụ tùng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(479, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numGTien
            // 
            this.numGTien.Location = new System.Drawing.Point(374, 35);
            this.numGTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numGTien.Name = "numGTien";
            this.numGTien.Size = new System.Drawing.Size(65, 20);
            this.numGTien.TabIndex = 2;
            this.numGTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPTTung
            // 
            this.txtPTTung.Location = new System.Drawing.Point(90, 36);
            this.txtPTTung.Name = "txtPTTung";
            this.txtPTTung.Size = new System.Drawing.Size(95, 20);
            this.txtPTTung.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(45, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tra cứu và chỉnh sữa phụ tùng";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(479, 121);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 7;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(90, 118);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(349, 20);
            this.txtLoc.TabIndex = 5;
            this.txtLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên phụ tùng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(479, 293);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 75);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvPTung
            // 
            this.dgvPTung.AllowUserToAddRows = false;
            this.dgvPTung.AllowUserToDeleteRows = false;
            this.dgvPTung.BackgroundColor = System.Drawing.Color.White;
            this.dgvPTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTung.Location = new System.Drawing.Point(26, 154);
            this.dgvPTung.Name = "dgvPTung";
            this.dgvPTung.ReadOnly = true;
            this.dgvPTung.Size = new System.Drawing.Size(413, 223);
            this.dgvPTung.TabIndex = 8;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(479, 38);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 20;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Visible = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbxDVT
            // 
            this.cbxDVT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxDVT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxDVT.FormattingEnabled = true;
            this.cbxDVT.Items.AddRange(new object[] {
            "Cái",
            "Hộp",
            "Mét"});
            this.cbxDVT.Location = new System.Drawing.Point(233, 34);
            this.cbxDVT.Name = "cbxDVT";
            this.cbxDVT.Size = new System.Drawing.Size(75, 21);
            this.cbxDVT.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "DVT";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(479, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 75);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UserControl_QuanLy_PhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDVT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dgvPTung);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numGTien);
            this.Controls.Add(this.txtPTTung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_QuanLy_PhuTung";
            this.Size = new System.Drawing.Size(582, 380);
            ((System.ComponentModel.ISupportInitialize)(this.numGTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numGTien;
        private System.Windows.Forms.TextBox txtPTTung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvPTung;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cbxDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
    }
}
