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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKhHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKhHang);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lượt tiếp nhận";
            // 
            // dgvKhHang
            // 
            this.dgvKhHang.AllowUserToAddRows = false;
            this.dgvKhHang.AllowUserToDeleteRows = false;
            this.dgvKhHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhHang.Location = new System.Drawing.Point(21, 19);
            this.dgvKhHang.Name = "dgvKhHang";
            this.dgvKhHang.ReadOnly = true;
            this.dgvKhHang.Size = new System.Drawing.Size(513, 175);
            this.dgvKhHang.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(23, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(19, 19);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(515, 148);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(121, 218);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Lập hóa đơn";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(372, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa hóa đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UserControl_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_HoaDon";
            this.Size = new System.Drawing.Size(604, 439);
            this.Click += new System.EventHandler(this.UserControl_HoaDon_Click);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvKhHang;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnXoa;
    }
}
