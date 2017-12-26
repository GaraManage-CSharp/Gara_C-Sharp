using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Gara_Manage.Viewer
{
    public partial class UserControl_QuanLy_TiepNhan : UserControl
    {
        
        public UserControl_QuanLy_TiepNhan()
        {
            InitializeComponent();
            Select();
        }

        private void btnXNhan_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcomd= SQL.Connection.CreateCommand();
            sqlcomd.CommandText = setTextUpdate((int)numSLuong.Value);
            sqlcomd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công.","Thông báo",MessageBoxButtons.OK);
        }
        private string setTextUpdate(int value)
        {
            return "ALTER trigger [dbo].[update_SLTTTNhan] "+
                    "on[dbo].[TIEPNHAN] "+
                    "for insert "+
                    "as "+
                    "begin "+
                        "declare @quantity int "+
                        "select @quantity = count(t.idTN) "+
                        "from TIEPNHAN t, INSERTED i "+
                        "where convert(date, t.NGAYNHAN, 103) = convert(date, getdate(), 103) "+
                        "if @quantity = "+value+" "+
                        "begin "+
                            "rollback tran "+
                            "raiserror(N'Lỗi', 16, 1) "+
                        "end "+
                    "end";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Select();
        }
        private void Select()
        {
            string comd;
            switch (cmbLTheo.SelectedIndex)
            {
                case 1:
                    comd = getSelectSQL(" idtn = " + int.Parse(txtLoc.Text));
                    break;
                case 2:
                    comd = getSelectSQL(" tenkh like '" + txtLoc.Text + "%' ");
                    break;
                case 4:
                    comd = getSelectSQL(" bienso like '" + txtLoc.Text + "' ");
                    break;
                case 5:
                    comd = getSelectSQL(" tenhx like '" + txtLoc.Text + "%' ");
                    break;
                case 7:
                    comd = getSelectSQL(" CONVERT(date, NGAYNHAN,103) = CONVERT(date,'" + txtLoc.Text + "',103) ");
                    break;
                default:
                    comd = getSelectSQL("");
                    break;
            }
            SqlCommand sqlcomd = new SqlCommand(comd, SQL.Connection);
            sqlcomd.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcomd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dgvDLTNhan.DataSource = dt;
        }
        private string getSelectSQL(string item)
        {
            string initem = "select idTN as [Mã tiếp nhận],TENKH as [Khách hàng],N'Loại tiếp nhận' as [Loại tiếp nhận],BIENSO as [Biển số],TENHX as [Hiệu xe],N'Nhân viên' as [Nhân viên],NGAYNHAN as [Ngày nhận],N'Ngày sữa' as [Ngày sữa] " +
                    "from tiepnhan t, HIEUXE h " +
                    "where t.idHX=h.idHX ";
            return item.CompareTo("") == 0 ? initem : initem + " and " + item;
        }

        private void cmbLTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLTheo.SelectedIndex==0)
            {
                txtLoc.Enabled = false;
            } else
            {
                txtLoc.Enabled = true;
            }
        }
    }
}
