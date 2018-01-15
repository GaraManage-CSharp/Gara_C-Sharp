using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gara_Manage
{
    public partial class MAIN : Form
    {
        private static FlagFrom flag;
        public MAIN()
        {
            InitializeComponent();
            flag = new FlagFrom();
            SqlCommand comd = SQL.Connection.CreateCommand();
            comd.CommandText = "set dateformat dmy";
            comd.ExecuteNonQuery();
        }

        internal static FlagFrom Flag { get => flag; set => flag = value; }

        private void MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Connection.Close();
        }

    }
}
