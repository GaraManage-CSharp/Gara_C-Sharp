﻿namespace Gara_Manage.Viewer
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
            this.label2 = new System.Windows.Forms.Label();
            this.numSLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXNhan
            // 
            this.btnXNhan.Location = new System.Drawing.Point(454, 138);
            this.btnXNhan.Name = "btnXNhan";
            this.btnXNhan.Size = new System.Drawing.Size(131, 70);
            this.btnXNhan.TabIndex = 6;
            this.btnXNhan.Text = "Xác nhận";
            this.btnXNhan.UseVisualStyleBackColor = true;
            this.btnXNhan.Click += new System.EventHandler(this.btnXNhan_Click);
            // 
            // dgvPTung
            // 
            this.dgvPTung.AllowUserToAddRows = false;
            this.dgvPTung.AllowUserToDeleteRows = false;
            this.dgvPTung.BackgroundColor = System.Drawing.Color.White;
            this.dgvPTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTung.Location = new System.Drawing.Point(12, 14);
            this.dgvPTung.Name = "dgvPTung";
            this.dgvPTung.ReadOnly = true;
            this.dgvPTung.Size = new System.Drawing.Size(433, 338);
            this.dgvPTung.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số lượng";
            // 
            // numSLuong
            // 
            this.numSLuong.Location = new System.Drawing.Point(510, 14);
            this.numSLuong.Name = "numSLuong";
            this.numSLuong.Size = new System.Drawing.Size(75, 20);
            this.numSLuong.TabIndex = 2;
            this.numSLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(454, 53);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 66);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UserControl_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPTung);
            this.Controls.Add(this.btnXNhan);
            this.Name = "UserControl_NhapKho";
            this.Size = new System.Drawing.Size(596, 369);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXNhan;
        private System.Windows.Forms.DataGridView dgvPTung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSLuong;
        private System.Windows.Forms.Button btnThem;
    }
}
