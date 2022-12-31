using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Accounting.BL.Users
{
    internal class Login
    {

        public DataTable loginTest(string user, string password)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@U_Name", SqlDbType.NVarChar,20);
            para[0].Value = user;
            para[1] = new SqlParameter("@U_Password", SqlDbType.NVarChar,20);
            para[1].Value = password;

            DataTable dt = new DataTable();
            dt = con.selectData("login_test",para);
            con.closeConnection();
            return dt;

        }


    }
}
