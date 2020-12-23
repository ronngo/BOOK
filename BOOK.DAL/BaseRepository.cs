using System.Data;
using System.Data.SqlClient;

namespace PXUK16.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Data Source=VAN-BINH;Initial Catalog=Book;Integrated Security=True");
        }
    }
}
