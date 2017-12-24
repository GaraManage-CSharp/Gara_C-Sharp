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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTPTung = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phụ tùng";
            // 
            // cmbTPTung
            // 
            this.cmbTPTung.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbTPTung.FormattingEnabled = true;
            this.cmbTPTung.ItemHeight = 13;
            this.cmbTPTung.Location = new System.Drawing.Point(76, 17);
            this.cmbTPTung.Name = "cmbTPTung";
            this.cmbTPTung.Size = new System.Drawing.Size(204, 21);
            this.cmbTPTung.Sorted = true;
            this.cmbTPTung.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // numSLuong
            // 
            this.numSLuong.Location = new System.Drawing.Point(391, 18);
            this.numSLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSLuong.Name = "numSLuong";
            this.numSLuong.Size = new System.Drawing.Size(66, 20);
            this.numSLuong.TabIndex = 2;
            this.numSLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(509, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(23, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 318);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phụ tùng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhân viên";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(529, 184);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 55);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(529, 294);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 55);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLMoi
            // 
            this.btnLMoi.Location = new System.Drawing.Point(529, 88);
            this.btnLMoi.Name = "btnLMoi";
            this.btnLMoi.Size = new System.Drawing.Size(55, 55);
            this.btnLMoi.TabIndex = 5;
            this.btnLMoi.Text = "Làm mới";
            this.btnLMoi.UseVisualStyleBackColor = true;
            // 
            // UserControl_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTPTung);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_NhapKho";
            this.Size = new System.Drawing.Size(596, 413);
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTPTung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLMoi;
    }
}
