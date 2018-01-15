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
            this.dgvDSo = new System.Windows.Forms.DataGridView();
            this.txtTDTThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDSThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPTTon = new System.Windows.Forms.DataGridView();
            this.cmbBCThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTTon)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvDSo);
            this.splitContainer1.Panel1.Controls.Add(this.txtTDTThang);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cmbDSThang);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Click += new System.EventHandler(this.splitContainer1_Panel1_Click);
            this.splitContainer1.Panel1MinSize = 35;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPTTon);
            this.splitContainer1.Panel2.Controls.Add(this.cmbBCThang);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.splitContainer1_Panel2_Click);
            this.splitContainer1.Panel2MinSize = 35;
            this.splitContainer1.Size = new System.Drawing.Size(596, 413);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvDSo
            // 
            this.dgvDSo.AllowUserToAddRows = false;
            this.dgvDSo.AllowUserToDeleteRows = false;
            this.dgvDSo.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSo.Location = new System.Drawing.Point(65, 110);
            this.dgvDSo.Name = "dgvDSo";
            this.dgvDSo.ReadOnly = true;
            this.dgvDSo.Size = new System.Drawing.Size(470, 249);
            this.dgvDSo.TabIndex = 5;
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
            this.cmbDSThang.SelectedIndexChanged += new System.EventHandler(this.cmbDSThang_SelectedIndexChanged);
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
            // dgvPTTon
            // 
            this.dgvPTTon.AllowUserToAddRows = false;
            this.dgvPTTon.AllowUserToDeleteRows = false;
            this.dgvPTTon.BackgroundColor = System.Drawing.Color.White;
            this.dgvPTTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTTon.Location = new System.Drawing.Point(52, 96);
            this.dgvPTTon.Name = "dgvPTTon";
            this.dgvPTTon.ReadOnly = true;
            this.dgvPTTon.Size = new System.Drawing.Size(470, 273);
            this.dgvPTTon.TabIndex = 8;
            // 
            // cmbBCThang
            // 
            this.cmbBCThang.FormattingEnabled = true;
            this.cmbBCThang.Location = new System.Drawing.Point(227, 52);
            this.cmbBCThang.Name = "cmbBCThang";
            this.cmbBCThang.Size = new System.Drawing.Size(145, 21);
            this.cmbBCThang.TabIndex = 2;
            this.cmbBCThang.SelectedIndexChanged += new System.EventHandler(this.cmbBCThang_SelectedIndexChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTDTThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDSThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBCThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSo;
        private System.Windows.Forms.DataGridView dgvPTTon;
    }
}
