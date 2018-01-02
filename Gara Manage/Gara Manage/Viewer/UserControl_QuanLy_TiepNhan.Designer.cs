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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.cmbLTheo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDLTNhan = new System.Windows.Forms.DataGridView();
            this.select_TiepNhanTableAdapter = new Gara_Manage.GARAOTODataSetTableAdapters.select_TiepNhanTableAdapter();
            this.ngàyNhậnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biểnSốXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiệuXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốĐiệnThoạiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.địaChỉDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênKháchHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãTiếpNhậnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectTiepNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gARAOTODataSet = new Gara_Manage.GARAOTODataSet();
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLTNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTiepNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARAOTODataSet)).BeginInit();
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
            this.numSLuong.TabIndex = 1;
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
            this.btnXNhan.Click += new System.EventHandler(this.btnXNhan_Click);
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
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(482, 115);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.Enabled = false;
            this.txtLoc.Location = new System.Drawing.Point(291, 117);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(166, 20);
            this.txtLoc.TabIndex = 4;
            // 
            // cmbLTheo
            // 
            this.cmbLTheo.CausesValidation = false;
            this.cmbLTheo.Location = new System.Drawing.Point(83, 118);
            this.cmbLTheo.Name = "cmbLTheo";
            this.cmbLTheo.Size = new System.Drawing.Size(181, 21);
            this.cmbLTheo.TabIndex = 3;
            this.cmbLTheo.SelectedIndexChanged += new System.EventHandler(this.cmbLTheo_SelectedIndexChanged);
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
            // dgvDLTNhan
            // 
            this.dgvDLTNhan.AllowUserToAddRows = false;
            this.dgvDLTNhan.AllowUserToDeleteRows = false;
            this.dgvDLTNhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDLTNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDLTNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãTiếpNhậnDataGridViewTextBoxColumn,
            this.tênKháchHàngDataGridViewTextBoxColumn,
            this.địaChỉDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn17,
            this.sốĐiệnThoạiDataGridViewTextBoxColumn,
            this.hiệuXeDataGridViewTextBoxColumn,
            this.biểnSốXeDataGridViewTextBoxColumn,
            this.ngàyNhậnDataGridViewTextBoxColumn});
            this.dgvDLTNhan.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDLTNhan.Location = new System.Drawing.Point(20, 145);
            this.dgvDLTNhan.Name = "dgvDLTNhan";
            this.dgvDLTNhan.ReadOnly = true;
            this.dgvDLTNhan.Size = new System.Drawing.Size(537, 217);
            this.dgvDLTNhan.TabIndex = 7;
            // 
            // select_TiepNhanTableAdapter
            // 
            this.select_TiepNhanTableAdapter.ClearBeforeFill = true;
            // 
            // ngàyNhậnDataGridViewTextBoxColumn
            // 
            this.ngàyNhậnDataGridViewTextBoxColumn.DataPropertyName = "Ngày nhận";
            this.ngàyNhậnDataGridViewTextBoxColumn.HeaderText = "Ngày nhận";
            this.ngàyNhậnDataGridViewTextBoxColumn.Name = "ngàyNhậnDataGridViewTextBoxColumn";
            this.ngàyNhậnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biểnSốXeDataGridViewTextBoxColumn
            // 
            this.biểnSốXeDataGridViewTextBoxColumn.DataPropertyName = "Biển số xe";
            this.biểnSốXeDataGridViewTextBoxColumn.HeaderText = "Biển số xe";
            this.biểnSốXeDataGridViewTextBoxColumn.Name = "biểnSốXeDataGridViewTextBoxColumn";
            this.biểnSốXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hiệuXeDataGridViewTextBoxColumn
            // 
            this.hiệuXeDataGridViewTextBoxColumn.DataPropertyName = "Hiệu xe";
            this.hiệuXeDataGridViewTextBoxColumn.HeaderText = "Hiệu xe";
            this.hiệuXeDataGridViewTextBoxColumn.Name = "hiệuXeDataGridViewTextBoxColumn";
            this.hiệuXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốĐiệnThoạiDataGridViewTextBoxColumn
            // 
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.DataPropertyName = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.Name = "sốĐiệnThoạiDataGridViewTextBoxColumn";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn17.HeaderText = "Email";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // địaChỉDataGridViewTextBoxColumn
            // 
            this.địaChỉDataGridViewTextBoxColumn.DataPropertyName = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.Name = "địaChỉDataGridViewTextBoxColumn";
            this.địaChỉDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênKháchHàngDataGridViewTextBoxColumn
            // 
            this.tênKháchHàngDataGridViewTextBoxColumn.DataPropertyName = "Tên khách hàng";
            this.tênKháchHàngDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tênKháchHàngDataGridViewTextBoxColumn.Name = "tênKháchHàngDataGridViewTextBoxColumn";
            this.tênKháchHàngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãTiếpNhậnDataGridViewTextBoxColumn
            // 
            this.mãTiếpNhậnDataGridViewTextBoxColumn.DataPropertyName = "Mã tiếp nhận";
            this.mãTiếpNhậnDataGridViewTextBoxColumn.HeaderText = "Mã tiếp nhận";
            this.mãTiếpNhậnDataGridViewTextBoxColumn.Name = "mãTiếpNhậnDataGridViewTextBoxColumn";
            this.mãTiếpNhậnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectTiepNhanBindingSource
            // 
            this.selectTiepNhanBindingSource.DataMember = "select_TiepNhan";
            this.selectTiepNhanBindingSource.DataSource = this.gARAOTODataSet;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.gARAOTODataSet;
            this.bindingSource1.Position = 0;
            // 
            // gARAOTODataSet
            // 
            this.gARAOTODataSet.DataSetName = "GARAOTODataSet";
            this.gARAOTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserControl_QuanLy_TiepNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDLTNhan);
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
            this.Load += new System.EventHandler(this.UserControl_QuanLy_TiepNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLTNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTiepNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARAOTODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSLuong;
        private System.Windows.Forms.Button btnXNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.ComboBox cmbLTheo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDLTNhan;
        private System.Windows.Forms.BindingSource tIEPNHANBindingSource;
        private System.Windows.Forms.BindingSource gARAOTODataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIENSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYNHANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private GARAOTODataSetTableAdapters.select_TiepNhanTableAdapter select_TiepNhanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãTiếpNhậnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênKháchHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn địaChỉDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốĐiệnThoạiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiệuXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biểnSốXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyNhậnDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource selectTiepNhanBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GARAOTODataSet gARAOTODataSet;
    }
}
