using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System_Accounting.DAL
{
    internal class ConnectionDatabase
    {


        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();


        public ConnectionDatabase()
        {

            conn = new SqlConnection("Data Source =192.168.100.86; Initial Catalog = fnoonasia; User ID = sa; Password =Aa123");
            
        }


        public void openConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        } // end of open connection


        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        } // end of close connction

        // method to CRUD from database using stored procedure

        public void excuteCmd(string sp, SqlParameter[] para)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = conn;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.ExecuteNonQuery();

        } // end of excute Cmd


        // method to read data from database using stored procedure

        public DataTable selectData(string sp, SqlParameter[] para)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = conn;
            if (para != null)
            {
                for (int j = 0; j < para.Length; j++)
                {
                    cmd.Parameters.Add(para[j]);
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            return dt;
             
        } // end of select Data

    }
}
