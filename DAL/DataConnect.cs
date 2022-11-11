using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataConnect
    {
        protected string strConn =
            "Data Source=LAPTOP-9FFCD11F;Initial Catalog=WhoWantToBeAMillionaire;User ID=sa;Password=binbo123";
        protected SqlConnection con = null;

        public void OpenConnection()
        {
            if (con == null) con = new SqlConnection(strConn);
            if (con.State == ConnectionState.Closed) con.Open();
        }

        public void DisconnectDB()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
    }
}