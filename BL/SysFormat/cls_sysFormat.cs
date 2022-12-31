using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Accounting.DAL;

namespace System_Accounting.BL.SysFormat
{
    internal class cls_sysFormat
    {


        DataTable dt;
        ConnectionDatabase con;

        #region cash
        public DataTable Get_All_Cash(int accno)
        {

            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cash_test", SqlDbType.Int);
            para[0].Value = accno;
            dt = con.selectData("Get_All_Cash", para);
            con.closeConnection();
            return dt;
        }
        public DataTable Get_All_Cashes()
        {

            con = new ConnectionDatabase();
            con.openConnection();
            dt = con.selectData("get_All_Cashes", null);
            con.closeConnection();
            return dt;

        
        }
        

        public DataTable get_Cash_Accno(string cashname)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@C_ACC_Name", SqlDbType.NVarChar, 50);
            para[0].Value = cashname;
            dt = con.selectData("get_Cash_Accno", para);
            con.closeConnection();
            return dt;
        }

        public void add_Cash(int accno, string accname, int test)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@acc_no", SqlDbType.Int);
            para[0].Value = accno;
            para[1] = new SqlParameter("@acc_Name", SqlDbType.NVarChar,30);
            para[1].Value = accname;
            para[2] = new SqlParameter("@test", SqlDbType.Int);
            para[2].Value = test;
            con.excuteCmd("Cash_Add", para);
            con.closeConnection();
        }

        public void delete_Cash(int accno, int test)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@acc_no", SqlDbType.Int);
            para[0].Value = accno;
            para[1] = new SqlParameter("@test", SqlDbType.Int);
            para[1].Value = test;
            con.excuteCmd("Cash_Delete", para);
            con.closeConnection();
        }

        
        #endregion

        #region Currency

        public DataTable Get_All_Currencies()
        {

            con = new ConnectionDatabase();
            con.openConnection();
            dt = con.selectData("Get_All_Currency", null);
            con.closeConnection();
            return dt;
        }


        public void add_Currencies(string curr_Name, string curr_Ename, string curr_Symbol , double curr_Exch, string curr_Part, int curr_Type)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@curr_Name", SqlDbType.NVarChar, 20);
            para[0].Value = curr_Name;
            para[1] = new SqlParameter("@curr_Ename", SqlDbType.NVarChar, 20);
            para[1].Value = curr_Ename;
            para[2] = new SqlParameter("@curr_Symbol", SqlDbType.NVarChar, 3);
            para[2].Value = curr_Symbol;
            para[3] = new SqlParameter("@curr_Exch", SqlDbType.Decimal);
            para[3].Value = curr_Exch;
            para[4] = new SqlParameter("@curr_Part", SqlDbType.NVarChar, 20);
            para[4].Value = curr_Part;
            para[5] = new SqlParameter("@curr_Type", SqlDbType.Int);
            para[5].Value = curr_Type;
            con.excuteCmd("Currency_Add", para);
            con.closeConnection();
        }

        public void update_Currencies(int accno, string curr_Name, string curr_Ename, string curr_Symbol , double curr_Exch, string curr_Part, int curr_Type)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@curr_No", SqlDbType.Int);
            para[0].Value = accno;
            para[1] = new SqlParameter("@curr_Name", SqlDbType.NVarChar, 20);
            para[1].Value = curr_Name;
            para[2] = new SqlParameter("@curr_Ename", SqlDbType.NVarChar, 20);
            para[2].Value = curr_Ename;
            para[3] = new SqlParameter("@curr_Symbol", SqlDbType.NVarChar, 3);
            para[3].Value = curr_Symbol;
            para[4] = new SqlParameter("@curr_Exch", SqlDbType.Decimal);
            para[4].Value = curr_Exch;
            para[5] = new SqlParameter("@curr_Part", SqlDbType.NVarChar, 20);
            para[5].Value = curr_Part;
            para[6] = new SqlParameter("@curr_Type", SqlDbType.Int);
            para[6].Value = curr_Type;
            con.excuteCmd("Currency_Update", para);
            con.closeConnection();
        }
        
        public void delete_Currencies(int accno)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@curr_No", SqlDbType.Int);
            para[0].Value = accno;
            con.excuteCmd("Currency_Delete", para);
            con.closeConnection();
        }


        public DataTable get_Curr_Exch(string curr_name)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@curr_Name", SqlDbType.NVarChar,20);
            para[0].Value = curr_name;
            dt = con.selectData("get_Curr_Exch", para);
            con.closeConnection();
            return dt;
        }


        #endregion


    }
}
