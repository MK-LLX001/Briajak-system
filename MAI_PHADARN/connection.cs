using System.Data.SqlClient;
namespace MAI_PHADARN
{
    internal class connection
    {

        public string sql = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODE\\C#\\MAI_PHADARN\\MAI_PHADARN\\Database_Mai.mdf;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void connect()
        {
            conn.ConnectionString = sql;
            conn.Open();
        }
    }
}
