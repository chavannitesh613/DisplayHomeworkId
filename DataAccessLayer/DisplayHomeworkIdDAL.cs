using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DisplayHomeworkIdDAL
    {
       
            public SqlDataReader DisplayHomeworkId(Teacher teacher)
            {

                string constr = ConfigurationManager.ConnectionStrings["ProCon"].ConnectionString;
                string querytext = "sp_DisplayHomeworkId";
                SqlConnection conn = null;
                SqlCommand cmd = null;



                try
                {
                    conn = new SqlConnection(constr);
                    cmd = new SqlCommand(querytext, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TeacherId", teacher.TeacherId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    return reader;

                    conn.Close();

                }

                catch (Exception ex)
                {
                   throw ex;
                }
            }
        }
    }

