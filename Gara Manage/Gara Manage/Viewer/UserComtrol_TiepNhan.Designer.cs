﻿namespace Gara_Manage.Viewer
{
    partial class UserComtrol_TiepNhan
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
            this.components = new System.ComponentModel.Container();
            this.cbxHXe = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tIEPNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTNhan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBSXe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDThoai = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIENSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYNHANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dteNNhan = new System.Windows.Forms.DateTimePicker();
            this.txtTKHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tIEPNHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxHXe
            // 
            this.cbxHXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxHXe.FormattingEnabled = true;
            this.cbxHXe.Location = new System.Drawing.Point(126, 114);
            this.cbxHXe.Name = "cbxHXe";
            this.cbxHXe.Size = new System.Drawing.Size(282, 21);
            this.cbxHXe.TabIndex = 33;
            this.cbxHXe.SelectedIndexChanged += new System.EventHandler(this.cbxHXe_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(126, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // tIEPNHANBindingSource
            // 
            this.tIEPNHANBindingSource.DataMember = "TIEPNHAN";
            this.tIEPNHANBindingSource.DataSource = typeof(Gara_Manage.GARAOTODataSet);
            // 
            // txtDChi
            // 
            this.txtDChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDChi.Location = new System.Drawing.Point(126, 37);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(282, 20);
            this.txtDChi.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ngày nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(35, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hiệu xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(35, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(32, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên khách hàng";
            // 
            // btnTNhan
            // 
            this.btnTNhan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTNhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTNhan.Location = new System.Drawing.Point(440, 24);
            this.btnTNhan.Name = "btnTNhan";
            this.btnTNhan.Size = new System.Drawing.Size(96, 96);
            this.btnTNhan.TabIndex = 36;
            this.btnTNhan.Text = "Tiếp nhận";
            this.btnTNhan.UseVisualStyleBackColor = true;
            this.btnTNhan.Click += new System.EventHandler(this.btnTNhan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(32, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Biển số xe";
            // 
            // txtBSXe
            // 
            this.txtBSXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBSXe.Location = new System.Drawing.Point(126, 141);
            this.txtBSXe.Name = "txtBSXe";
            this.txtBSXe.Size = new System.Drawing.Size(282, 20);
            this.txtBSXe.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(32, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Số điện thoại";
            // 
            // txtSDThoai
            // 
            this.txtSDThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDThoai.Location = new System.Drawing.Point(126, 89);
            this.txtSDThoai.Name = "txtSDThoai";
            this.txtSDThoai.Size = new System.Drawing.Size(282, 20);
            this.txtSDThoai.TabIndex = 32;
            this.txtSDThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDThoai_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTN,
            this.tENKHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.bIENSODataGridViewTextBoxColumn,
            this.nGAYNHANDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tIEPNHANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(596, 220);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // idTN
            // 
            this.idTN.DataPropertyName = "idTN";
            this.idTN.HeaderText = "idTN";
            this.idTN.Name = "idTN";
            this.idTN.ReadOnly = true;
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            this.tENKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bIENSODataGridViewTextBoxColumn
            // 
            this.bIENSODataGridViewTextBoxColumn.DataPropertyName = "BIENSO";
            this.bIENSODataGridViewTextBoxColumn.HeaderText = "BIENSO";
            this.bIENSODataGridViewTextBoxColumn.Name = "bIENSODataGridViewTextBoxColumn";
            this.bIENSODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYNHANDataGridViewTextBoxColumn
            // 
            this.nGAYNHANDataGridViewTextBoxColumn.DataPropertyName = "NGAYNHAN";
            this.nGAYNHANDataGridViewTextBoxColumn.HeaderText = "NGAYNHAN";
            this.nGAYNHANDataGridViewTextBoxColumn.Name = "nGAYNHANDataGridViewTextBoxColumn";
            this.nGAYNHANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dteNNhan
            // 
            this.dteNNhan.Enabled = false;
            this.dteNNhan.Location = new System.Drawing.Point(126, 167);
            this.dteNNhan.Name = "dteNNhan";
            this.dteNNhan.Size = new System.Drawing.Size(282, 20);
            this.dteNNhan.TabIndex = 40;
            // 
            // txtTKHang
            // 
            this.txtTKHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTKHang.Location = new System.Drawing.Point(126, 11);
            this.txtTKHang.Name = "txtTKHang";
            this.txtTKHang.Size = new System.Drawing.Size(282, 20);
            this.txtTKHang.TabIndex = 29;
            // 
            // UserComtrol_TiepNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dteNNhan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTNhan);
            this.Controls.Add(this.txtBSXe);
            this.Controls.Add(this.cbxHXe);
            this.Controls.Add(this.txtSDThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDChi);
            this.Controls.Add(this.txtTKHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UserComtrol_TiepNhan";
            this.Size = new System.Drawing.Size(596, 413);
            this.Click += new System.EventHandler(this.UserComtrol_TiepNhan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tIEPNHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxHXe;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTNhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBSXe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDThoai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dteNNhan;
        private System.Windows.Forms.BindingSource tIEPNHANBindingSource;
        private System.Windows.Forms.TextBox txtTKHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIENSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYNHANDataGridViewTextBoxColumn;
    }
}
