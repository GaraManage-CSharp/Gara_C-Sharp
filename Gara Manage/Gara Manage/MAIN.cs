using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gara_Manage
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            SqlCommand comd = SQL.Connection.CreateCommand();
            comd.CommandText = "set dateformat dmy";
            comd.ExecuteNonQuery();

        }

        private void MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Connection.Close();
        }
    }
}
