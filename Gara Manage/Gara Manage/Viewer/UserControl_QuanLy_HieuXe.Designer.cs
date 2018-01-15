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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hIEUXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idHXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENHXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHXe
            // 
            this.txtHXe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hIEUXEBindingSource, "TENHX", true));
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
            // txtTim
            // 
            this.txtTim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hIEUXEBindingSource, "TENHX", true));
            this.txtTim.Location = new System.Drawing.Point(79, 117);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(338, 20);
            this.txtTim.TabIndex = 3;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHXDataGridViewTextBoxColumn,
            this.tENHXDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hIEUXEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(368, 207);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // hIEUXEBindingSource
            // 
            this.hIEUXEBindingSource.DataSource = typeof(Gara_Manage.HIEUXE);
            // 
            // idHXDataGridViewTextBoxColumn
            // 
            this.idHXDataGridViewTextBoxColumn.DataPropertyName = "idHX";
            this.idHXDataGridViewTextBoxColumn.HeaderText = "idHX";
            this.idHXDataGridViewTextBoxColumn.Name = "idHXDataGridViewTextBoxColumn";
            this.idHXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENHXDataGridViewTextBoxColumn
            // 
            this.tENHXDataGridViewTextBoxColumn.DataPropertyName = "TENHX";
            this.tENHXDataGridViewTextBoxColumn.HeaderText = "TENHX";
            this.tENHXDataGridViewTextBoxColumn.Name = "tENHXDataGridViewTextBoxColumn";
            this.tENHXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserControl_QuanLy_HieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_QuanLy_HieuXe";
            this.Size = new System.Drawing.Size(582, 380);
            this.Load += new System.EventHandler(this.UserControl_QuanLy_HieuXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hIEUXEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENHXDataGridViewTextBoxColumn;
    }
}
