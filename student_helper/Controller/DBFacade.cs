using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Controller
{
    public class DBFacade
    {
        static string ConnectionString = "Server=ealdb1.eal.local;" + "Database=EJL02_DB;" + "User Id=ejl02_usr;" + "Password=Baz1nga3";
        List<Week> GetWeeks();

        public void AddEvent(int Week, string DayName, DateTime TimeStart, DateTime TimeEnd, string Teacher)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SQLStoredProcedure", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Week", Week));
                    cmd.Parameters.Add(new SqlParameter("@DayName", DayName));
                    cmd.Parameters.Add(new SqlParameter("@TimeStart", TimeStart));
                    cmd.Parameters.Add(new SqlParameter("@TimeEnd", TimeEnd));
                    cmd.Parameters.Add(new SqlParameter("@Teacher", Teacher));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    conn.Dispose();
                    conn.Close();
                }
            }
        }
    }
}
