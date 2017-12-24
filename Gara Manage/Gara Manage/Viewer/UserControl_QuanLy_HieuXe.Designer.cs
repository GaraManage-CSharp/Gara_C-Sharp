namespace Gara_Manage.Viewer
{
    partial class UserControl_QuanLy_HieuXe
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
            this.btnSua = new System.Windows.Forms.Button();
            this.lstvPTung = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(467, 215);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 75);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // lstvPTung
            // 
            this.lstvPTung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvPTung.FullRowSelect = true;
            this.lstvPTung.GridLines = true;
            this.lstvPTung.Location = new System.Drawing.Point(49, 161);
            this.lstvPTung.Name = "lstvPTung";
            this.lstvPTung.Size = new System.Drawing.Size(368, 207);
            this.lstvPTung.TabIndex = 5;
            this.lstvPTung.UseCompatibleStateImageBehavior = false;
            this.lstvPTung.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hiệu xe";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hiệu xe";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 364;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(45, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tra cứu và chỉnh sữa hiệu xe";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(319, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtHXe
            // 
            this.txtHXe.Location = new System.Drawing.Point(79, 40);
            this.txtHXe.Name = "txtHXe";
            this.txtHXe.Size = new System.Drawing.Size(181, 20);
            this.txtHXe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hiệu xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thêm hiệu xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hiệu xe";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(319, 115);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(79, 117);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(181, 20);
            this.txtTim.TabIndex = 3;
            // 
            // UserControl_QuanLy_HieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lstvPTung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_QuanLy_HieuXe";
            this.Size = new System.Drawing.Size(582, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListView lstvPTung;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}
