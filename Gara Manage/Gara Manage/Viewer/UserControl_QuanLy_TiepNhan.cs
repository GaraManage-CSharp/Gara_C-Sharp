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
            for (int i = 0; i < gARAOTODataSet.TIEPNHAN.Columns.Count; i++)
            {
                cmbLTheo.Items.Add(gARAOTODataSet.TIEPNHAN.Columns[i].ToString());
            }
            if (cmbLTheo.Items.Count != 0)
            {
                cmbLTheo.SelectedIndex = 0;
                Select();
            }
        }

        private void btnXNhan_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcomd = SQL.Connection.CreateCommand();                        //khởi tạo đối tượng truy vấn SQL
            sqlcomd.CommandText = setTextUpdate((int)numSLuong.Value);                  //lấy câu lệnh truy vấn
            sqlcomd.ExecuteNonQuery();                                                  //thực hiện truy vấn
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK); //xuất thông báo
        }
        private string setTextUpdate(int value)
        {
            return "ALTER trigger [dbo].[update_SLTTTNhan] \n" +
                    "on[dbo].[TIEPNHAN] \n" +
                    "for insert \n" +
                    "as \n" +
                    "begin \n" +
                    "   declare @quantity int \n" +
                    "   select @quantity = count(t.idTN) \n" +
                    "   from TIEPNHAN t, INSERTED i \n" +
                    "   where convert(date, t.NGAYNHAN, 103) = convert(date, getdate(), 103) \n" +
                    "   if @quantity = " + value + " \n" +
                    "   begin \n" +
                    "       rollback tran \n" +
                    "       raiserror(N'Lỗi', 16, 1) \n" +
                    "   end \n" +
                    "end";
        }   

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Select();
        }
        private void Select()
        {
            string comd; //dùng để chứa câu truy vấn SQL

            //đưa câu truy vấn vào comd
            switch (cmbLTheo.SelectedIndex)
            {
                case 0:
                    comd = getSelectSQL("");
                    break;
                case 1:
                    int id;
                    if (int.TryParse(txtLoc.Text,out id))
                    {
                        comd = getSelectSQL(" "+cmbLTheo.SelectedItem+" = " + id);
                    } else
                    {
                        MessageBox.Show("Mã tiếp nhận không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 8:
                    comd = getSelectSQL(" day(NGAYNHAN) = day('" + txtLoc.Text + "') and MONTH(NGAYNHAN) = MONTH('" + txtLoc.Text + "') and year(NGAYNHAN) = YEAR('" + txtLoc.Text + "')");
                    break;
                default:
                    comd = getSelectSQL(" "+cmbLTheo.SelectedItem.ToString()+" like N'%" + txtLoc.Text + "%' ");
                    break;
            }
            SqlCommand sqlcomd = new SqlCommand(comd, SQL.Connection);  // khởi tạo đối tượng truy vấn SQL
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcomd);         // 
            DataTable dt = new DataTable();                             // tạo đối tượng Datatable
            sqlda.Fill(dt);                                             // đổ dữ liệu vào Datatable
            dgvDLTNhan.DataSource = dt;                                 // hiển thị dữ liệu lên bảng
        }
        //hàm getSelectSQL dùng để lấy câu truy vấn SQL (chưa xài được)
        private string getSelectSQL(string item) //item là chuỗi điều kiện truyền vào
        {
            string initem = "select idTN as [Mã tiếp nhận],TENKH as [Khách hàng],t.DIACHI as [Địa chỉ], t.EMAIL as [Email],t.SDT as [Số điện thoại],BIENSO as [Biển số],TENHX as [Hiệu xe],NGAYNHAN as [Ngày nhận] " +
                    "from tiepnhan t, HIEUXE h " +
                    "where t.idHX=h.idHX ";
            return item.CompareTo("") == 0 ? initem : initem + " and " + item; //nếu chuỗi truyền vào là trống thì không cần thêm điều kiện
                                                                                //nếu chuỗi truyền vào không trống thì thêm điều kiện vào câu truy vấn
        }
        // chọn điều kiện lọc
        private void cmbLTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLTheo.SelectedIndex == 0) //nếu không có điều kiện lọc
            {
                txtLoc.Enabled = false;     //tắt chế độ nhập liệu
            }
            else
            {
                txtLoc.Enabled = true;
            }
        }
    }
}