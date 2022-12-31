using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Accounting.DAL;

namespace System_Accounting.BL.Accounts
{
    internal class cls_account
    {
        DataTable dt;
        ConnectionDatabase con;
        public DataTable Get_All_FinalAcc()
        {

            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            dt = con.selectData("Get_All_AccReport", null);


            return dt;
        }

        public DataTable Get_All_TypeAcc()
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            dt = con.selectData("Get_All_AccType", null);

            return dt;
            
        }

        public DataTable Get_All_Account()
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            dt = con.selectData("Get_All_Accounts", null);

            return dt;

        }

        public DataTable Get_Alone_Account(int accno)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;
            dt = con.selectData("Get_Account_Alone", para);
            con.closeConnection();

            return dt;
        }

        public void Account_Add(int accno, int accparent, string accname, int acclevel, double debit, double credit, double bal, int rep, int atype)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@acc_Parent_No", SqlDbType.Int);
            para[1].Value = accparent;

            para[2] = new SqlParameter("@acc_Aname", SqlDbType.NVarChar,50);
            para[2].Value = accname;

            para[5] = new SqlParameter("@acc_Level", SqlDbType.Int);
            para[5].Value = acclevel;

            para[6] = new SqlParameter("@acc_Debit", SqlDbType.Decimal);
            para[6].Value = debit;

            para[7] = new SqlParameter("@acc_Credit", SqlDbType.Decimal);
            para[7].Value = credit;

            para[8] = new SqlParameter("@acc_Balance", SqlDbType.Decimal);
            para[8].Value = bal;

            para[3] = new SqlParameter("@acc_Type", SqlDbType.Int);
            para[3].Value = atype;

            para[4] = new SqlParameter("@acc_Report", SqlDbType.Int);
            para[4].Value = rep;
            con.excuteCmd("Account_Add", para);
            con.closeConnection();
            



        }

        public void Account_Update(int accno, int accparent, string accname, int acclevel, double debit, double credit, double bal, int rep, int atype)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@acc_Parent_No", SqlDbType.Int);
            para[1].Value = accparent;

            para[2] = new SqlParameter("@acc_Aname", SqlDbType.NVarChar,50);
            para[2].Value = accname;

            para[5] = new SqlParameter("@acc_Level", SqlDbType.Int);
            para[5].Value = acclevel;

            para[6] = new SqlParameter("@acc_Debit", SqlDbType.Decimal);
            para[6].Value = debit;

            para[7] = new SqlParameter("@acc_Credit", SqlDbType.Decimal);
            para[7].Value = credit;

            para[8] = new SqlParameter("@acc_Balance", SqlDbType.Decimal);
            para[8].Value = bal;

            para[3] = new SqlParameter("@acc_Type", SqlDbType.Int);
            para[3].Value = atype;

            para[4] = new SqlParameter("@acc_Report", SqlDbType.Int);
            para[4].Value = rep;
            con.excuteCmd("Account_Update", para);
            con.closeConnection();
            

        }


        public void Account_Delete(int accno)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;
            con.excuteCmd("Account_Delete", para);
            con.closeConnection();

        }

        public DataTable Account_Test(int accno)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;
            dt = con.selectData("Account_test", para);
            con.closeConnection();

            return dt;

        }

        public DataTable Journal_Test(int accno)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;
            dt = con.selectData("Journal_Test", para);
            con.closeConnection();

            return dt;

        }

        public DataTable search_in_Accounts(string txt)
        {
            con = new ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@txt", SqlDbType.NVarChar,15);
            para[0].Value = txt;
            dt = con.selectData("search_in_accounts", para);
            con.closeConnection();

            return dt;

        }


    }
}
