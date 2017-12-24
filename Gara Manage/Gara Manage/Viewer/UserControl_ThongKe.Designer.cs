namespace Gara_Manage.Viewer
{
    partial class UserControl_ThongKe
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_DThu_Tim = new System.Windows.Forms.Button();
            this.lstvDTThang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTDTThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDSThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstvBCThang = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBCThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_BCao_Tim = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_DThu_Tim);
            this.splitContainer1.Panel1.Controls.Add(this.lstvDTThang);
            this.splitContainer1.Panel1.Controls.Add(this.txtTDTThang);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cmbDSThang);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 35;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_BCao_Tim);
            this.splitContainer1.Panel2.Controls.Add(this.lstvBCThang);
            this.splitContainer1.Panel2.Controls.Add(this.cmbBCThang);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2MinSize = 35;
            this.splitContainer1.Size = new System.Drawing.Size(596, 413);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_DThu_Tim
            // 
            this.btn_DThu_Tim.Location = new System.Drawing.Point(389, 45);
            this.btn_DThu_Tim.Name = "btn_DThu_Tim";
            this.btn_DThu_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_DThu_Tim.TabIndex = 6;
            this.btn_DThu_Tim.Text = "Tìm";
            this.btn_DThu_Tim.UseVisualStyleBackColor = true;
            // 
            // lstvDTThang
            // 
            this.lstvDTThang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvDTThang.FullRowSelect = true;
            this.lstvDTThang.GridLines = true;
            this.lstvDTThang.Location = new System.Drawing.Point(65, 98);
            this.lstvDTThang.Name = "lstvDTThang";
            this.lstvDTThang.Size = new System.Drawing.Size(470, 249);
            this.lstvDTThang.TabIndex = 5;
            this.lstvDTThang.UseCompatibleStateImageBehavior = false;
            this.lstvDTThang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hiệu xe";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng tiếp nhận";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tỉ lệ";
            // 
            // txtTDTThang
            // 
            this.txtTDTThang.Enabled = false;
            this.txtTDTThang.Location = new System.Drawing.Point(226, 75);
            this.txtTDTThang.Name = "txtTDTThang";
            this.txtTDTThang.Size = new System.Drawing.Size(157, 20);
            this.txtTDTThang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng doanh thu";
            // 
            // cmbDSThang
            // 
            this.cmbDSThang.FormattingEnabled = true;
            this.cmbDSThang.Location = new System.Drawing.Point(227, 45);
            this.cmbDSThang.Name = "cmbDSThang";
            this.cmbDSThang.Size = new System.Drawing.Size(156, 21);
            this.cmbDSThang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(249, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh số";
            // 
            // lstvBCThang
            // 
            this.lstvBCThang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstvBCThang.FullRowSelect = true;
            this.lstvBCThang.GridLines = true;
            this.lstvBCThang.Location = new System.Drawing.Point(65, 79);
            this.lstvBCThang.Name = "lstvBCThang";
            this.lstvBCThang.Size = new System.Drawing.Size(470, 273);
            this.lstvBCThang.TabIndex = 3;
            this.lstvBCThang.UseCompatibleStateImageBehavior = false;
            this.lstvBCThang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phụ tùng";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 173;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tồn đầu";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 79;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Phát sinh";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 85;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tồn cuối";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 69;
            // 
            // cmbBCThang
            // 
            this.cmbBCThang.FormattingEnabled = true;
            this.cmbBCThang.Location = new System.Drawing.Point(227, 52);
            this.cmbBCThang.Name = "cmbBCThang";
            this.cmbBCThang.Size = new System.Drawing.Size(145, 21);
            this.cmbBCThang.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(238, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Báo cáo tồn";
            // 
            // btn_BCao_Tim
            // 
            this.btn_BCao_Tim.Location = new System.Drawing.Point(389, 50);
            this.btn_BCao_Tim.Name = "btn_BCao_Tim";
            this.btn_BCao_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_BCao_Tim.TabIndex = 7;
            this.btn_BCao_Tim.Text = "Tìm";
            this.btn_BCao_Tim.UseVisualStyleBackColor = true;
            // 
            // UserControl_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl_ThongKe";
            this.Size = new System.Drawing.Size(596, 413);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvDTThang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtTDTThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDSThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvBCThang;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cmbBCThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DThu_Tim;
        private System.Windows.Forms.Button btn_BCao_Tim;
    }
}
