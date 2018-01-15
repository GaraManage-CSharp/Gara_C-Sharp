using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gara_Manage.Viewer
{
    public partial class UserControl_ThongKe : UserControl
    {
        public UserControl_ThongKe()
        {
            InitializeComponent();
            show();
        }

        private void btn_DThu_Tim_Click(object sender, EventArgs e)
        {
            string sql = " ALTER proc[dbo].[tkdoanhso] (@nam int, @thang int) " +
            " as " +
            " select x.TENHX, [so luot sua]= count(t.idTN), [tongtien]= sum(h.TONGTIEN), [ti le %]= 100 * sum(h.TONGTIEN) / (select sum(tongtien) from HOADON) " +
            " from HIEUXE x, TIEPNHAN t, HOADON h " +
            " where x.idHX=t.idHX and t.idTN=h.idTN and year(ngay)=@nam and month(ngay)=@thang " +
            " group by x.TENHX " +
            " GO ";

            SqlCommand cm = new SqlCommand();
            cm.Connection = SQL.Connection;
            DataTable dt = (DataTable)dgvDSo.DataSource;
            DataRow r = dt.Rows[dgvDSo.CurrentRow.Index];
            cm.CommandText = sql;
            show();
        }
        private void show()
        {
            string sql = " select * from HOADON ";
            SqlCommand cm = new SqlCommand(sql, SQL.Connection);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDSo.DataSource = dt; 
        }
        private void dtthang()
        {
            string sql = " ALTER function [dbo].[dtThang](@thang int, @nam int)" +
                            " returns table" +
                            " as" +
                            " return select DT = (case when sum(h.TONGTIEN) is not null then sum(h.TONGTIEN) else 0 end) " +
                            " from HOADON h" +

                            " where year(ngay) = @nam and month(ngay)= @thang" +
                            " GO";
        }
        private void tongdoanhthu()
        {
         
        }
      
    }        

}
