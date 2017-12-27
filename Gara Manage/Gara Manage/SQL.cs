using System.Data.SqlClient;

namespace Gara_Manage
{
    class SQL
    {
        private static SqlConnection conn;
        /// <summary>
        /// Propertie trả về một đối tượng thuộc lớp SQLConnection
        /// Đối tượng sẽ mở kết nối khi được gọi ra lần đầu tiên từ lúc bắt đầu chương trình
        /// Chương trình sẽ trả đối tượng mà không cần mở kết nối lại cho những lần gọi sau
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                if (conn != null)
                {
                    return conn;
                }
                conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=GARAOTO;Persist Security Info=True;User ID=sa");
                conn.Open();
                return conn;
            }
        }
    }
}
