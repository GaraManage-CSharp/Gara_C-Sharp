namespace Gara_Manage.Viewer
{
    partial class UserControl_QuanLy_TiepNhan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstvPTung = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.cmbLTheo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng tối đa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi số lượng tiếp nhận trong ngày";
            // 
            // numSLuong
            // 
            this.numSLuong.Location = new System.Drawing.Point(113, 41);
            this.numSLuong.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numSLuong.Name = "numSLuong";
            this.numSLuong.Size = new System.Drawing.Size(120, 20);
            this.numSLuong.TabIndex = 2;
            this.numSLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSLuong.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnXNhan
            // 
            this.btnXNhan.Location = new System.Drawing.Point(301, 38);
            this.btnXNhan.Name = "btnXNhan";
            this.btnXNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXNhan.TabIndex = 2;
            this.btnXNhan.Text = "Xác nhận";
            this.btnXNhan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(45, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dữ liệu tiếp nhận";
            // 
            // lstvPTung
            // 
            this.lstvPTung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstvPTung.FullRowSelect = true;
            this.lstvPTung.GridLines = true;
            this.lstvPTung.Location = new System.Drawing.Point(3, 189);
            this.lstvPTung.Name = "lstvPTung";
            this.lstvPTung.Size = new System.Drawing.Size(574, 179);
            this.lstvPTung.TabIndex = 7;
            this.lstvPTung.UseCompatibleStateImageBehavior = false;
            this.lstvPTung.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã tiếp nhận";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khách hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại sữa chữa";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Biển số xe";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hiệu xe";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 57;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nhân viên";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày nhận";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 67;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngày sữa";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(502, 131);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(273, 118);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(166, 20);
            this.txtLoc.TabIndex = 4;
            // 
            // cmbLTheo
            // 
            this.cmbLTheo.CausesValidation = false;
            this.cmbLTheo.Items.AddRange(new object[] {
            "",
            "Mã tiếp nhận",
            "Khách hàng",
            "Loại sữa chữa",
            "Biển số xe",
            "Hiệu xe",
            "Nhân viên",
            "Ngày nhận",
            "Ngày sữa"});
            this.cmbLTheo.Location = new System.Drawing.Point(83, 118);
            this.cmbLTheo.Name = "cmbLTheo";
            this.cmbLTheo.Size = new System.Drawing.Size(181, 21);
            this.cmbLTheo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lọc theo";
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(273, 156);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(166, 21);
            this.cmbLoc.TabIndex = 5;
            // 
            // UserControl_QuanLy_TiepNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbLoc);
            this.Controls.Add(this.lstvPTung);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.cmbLTheo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXNhan);
            this.Controls.Add(this.numSLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_QuanLy_TiepNhan";
            this.Size = new System.Drawing.Size(582, 380);
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSLuong;
        private System.Windows.Forms.Button btnXNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstvPTung;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.ComboBox cmbLTheo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cmbLoc;
    }
}
