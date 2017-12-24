namespace Gara_Manage.Viewer
{
    partial class UserControl_QuanLy_TienCong
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
            this.txtTCong = new System.Windows.Forms.TextBox();
            this.numGTien = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.lsttvLoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLTheo = new System.Windows.Forms.ComboBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.numLoc = new System.Windows.Forms.NumericUpDown();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá tiền";
            // 
            // txtTCong
            // 
            this.txtTCong.Location = new System.Drawing.Point(79, 40);
            this.txtTCong.Name = "txtTCong";
            this.txtTCong.Size = new System.Drawing.Size(181, 20);
            this.txtTCong.TabIndex = 1;
            // 
            // numGTien
            // 
            this.numGTien.Location = new System.Drawing.Point(315, 41);
            this.numGTien.Name = "numGTien";
            this.numGTien.Size = new System.Drawing.Size(120, 20);
            this.numGTien.TabIndex = 2;
            this.numGTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(479, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lsttvLoc
            // 
            this.lsttvLoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsttvLoc.FullRowSelect = true;
            this.lsttvLoc.GridLines = true;
            this.lsttvLoc.Location = new System.Drawing.Point(83, 189);
            this.lsttvLoc.Name = "lsttvLoc";
            this.lsttvLoc.Size = new System.Drawing.Size(356, 179);
            this.lsttvLoc.TabIndex = 8;
            this.lsttvLoc.UseCompatibleStateImageBehavior = false;
            this.lsttvLoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã tiền công";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tiền công";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 243;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 109;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(479, 293);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 75);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lọc theo";
            // 
            // cmbLTheo
            // 
            this.cmbLTheo.FormattingEnabled = true;
            this.cmbLTheo.Items.AddRange(new object[] {
            "",
            "Mã tiền công",
            "Tiền công",
            "Giá tiền công"});
            this.cmbLTheo.Location = new System.Drawing.Point(83, 118);
            this.cmbLTheo.Name = "cmbLTheo";
            this.cmbLTheo.Size = new System.Drawing.Size(181, 21);
            this.cmbLTheo.TabIndex = 4;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(273, 118);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(166, 20);
            this.txtLoc.TabIndex = 5;
            // 
            // numLoc
            // 
            this.numLoc.Location = new System.Drawing.Point(273, 155);
            this.numLoc.Name = "numLoc";
            this.numLoc.Size = new System.Drawing.Size(166, 20);
            this.numLoc.TabIndex = 6;
            this.numLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(479, 132);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 7;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(45, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thêm tiền công";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(45, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tra cứu và chỉnh sữa tiền công";
            // 
            // btnLMoi
            // 
            this.btnLMoi.Location = new System.Drawing.Point(479, 189);
            this.btnLMoi.Name = "btnLMoi";
            this.btnLMoi.Size = new System.Drawing.Size(75, 75);
            this.btnLMoi.TabIndex = 9;
            this.btnLMoi.Text = "Làm mới";
            this.btnLMoi.UseVisualStyleBackColor = true;
            // 
            // UserControl_QuanLy_TienCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLMoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.numLoc);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.cmbLTheo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lsttvLoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numGTien);
            this.Controls.Add(this.txtTCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_QuanLy_TienCong";
            this.Size = new System.Drawing.Size(582, 380);
            ((System.ComponentModel.ISupportInitialize)(this.numGTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCong;
        private System.Windows.Forms.NumericUpDown numGTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lsttvLoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLTheo;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.NumericUpDown numLoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLMoi;
    }
}
