using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DisplayHomeworkIdBL
    {
        public SqlDataReader DisplayHomeworkId(Teacher teacher)
        {

            try
            {

                DisplayHomeworkIdDAL displayHomeworkIdDAL = new DisplayHomeworkIdDAL();
                return displayHomeworkIdDAL.DisplayHomeworkId(teacher);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
