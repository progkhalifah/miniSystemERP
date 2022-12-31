using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Accounting.BL.Bonds
{
    internal class cls_Bonds
    {

        DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
        DataTable dt = new DataTable();

        public DataTable generate_Bno(int btype)
        {
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Btype", SqlDbType.Int);
            para[0].Value = btype;
            dt = con.selectData("generate_Bno", para);
            return dt;
        }


        public void bond_Hdr_Add(int bno, DateTime bdate, string bnote, int btype, int bpost, double amount, int cashno, int bankno, int uadd, DateTime adddate, int j_no)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@b_No", SqlDbType.Int);
            para[0].Value = bno;

            para[1] = new SqlParameter("@b_Date", SqlDbType.DateTime);
            para[1].Value = bdate;

            para[2] = new SqlParameter("@b_Note", SqlDbType.NVarChar, 200);
            para[2].Value = bnote;

            para[3] = new SqlParameter("@b_Type", SqlDbType.Int);
            para[3].Value = btype;

            para[4] = new SqlParameter("@b_Post", SqlDbType.Int);
            para[4].Value = bpost;

            para[5] = new SqlParameter("@acc_Balance", SqlDbType.Money);
            para[5].Value = amount;

            para[6] = new SqlParameter("@acc_Cash_No", SqlDbType.Int);
            para[6].Value = cashno;

            para[7] = new SqlParameter("@acc_Bank_No", SqlDbType.Int);
            para[7].Value = bankno;

            para[8] = new SqlParameter("@u_Add", SqlDbType.Int);
            para[8].Value = uadd;

            para[9] = new SqlParameter("@add_Date", SqlDbType.DateTime);
            para[9].Value = adddate;

            para[10] = new SqlParameter("@j_no", SqlDbType.Int);
            para[10].Value = j_no;



            con.excuteCmd("Bond_Hdr_Add", para);
            con.closeConnection();


        }

        public void bond_Details_Add(int accno, double amount, string bnote, int bcurr, double currexch, int bno)
        {
            con.openConnection();
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@Amount", SqlDbType.Money);
            para[1].Value = amount;

            para[2] = new SqlParameter("@b_Note", SqlDbType.NVarChar, 50);
            para[2].Value = bnote;

            para[3] = new SqlParameter("@b_Curr", SqlDbType.Int);
            para[3].Value = bcurr;

            para[4] = new SqlParameter("@curr_exch", SqlDbType.Money);
            para[4].Value = currexch;

            para[5] = new SqlParameter("@b_No", SqlDbType.Int);
            para[5].Value = bno;





            con.excuteCmd("Bond_Details_Add", para);
            con.closeConnection();


        }

        public DataTable show_Bond_Hdr(int bno)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@b_No", SqlDbType.Int);
            para[0].Value = bno;
            dt = con.selectData("show_Bond_Hdr", para);
            return dt;

        }

        public DataTable show_Bond_Details(int bno)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@b_No", SqlDbType.Int);
            para[0].Value = bno;
            dt = con.selectData("show_Bond_Details", para);
            return dt;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="bno"></param>
        /// <param name="bdate"></param>
        /// <param name="bnote"></param>
        /// <param name="btype"></param>
        /// <param name="bpost"></param>
        /// <param name="amount"></param>
        /// <param name="cashno"></param>
        /// <param name="bankno"></param>
        /// <param name="uadd"></param>
        /// <param name="adddate"></param>
        /// <param name="j_no"></param>
        public void bond_Hdr_Edit(int bno, DateTime bdate, string bnote, int btype, int bpost, double amount, int cashno, int bankno, int uadd, DateTime adddate, int j_no)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@b_No", SqlDbType.Int);
            para[0].Value = bno;

            para[1] = new SqlParameter("@b_Date", SqlDbType.DateTime);
            para[1].Value = bdate;

            para[2] = new SqlParameter("@b_Note", SqlDbType.NVarChar, 200);
            para[2].Value = bnote;

            para[3] = new SqlParameter("@b_Type", SqlDbType.Int);
            para[3].Value = btype;

            para[4] = new SqlParameter("@b_Post", SqlDbType.Int);
            para[4].Value = bpost;

            para[5] = new SqlParameter("@acc_Balance", SqlDbType.Money);
            para[5].Value = amount;

            para[6] = new SqlParameter("@acc_Cash_No", SqlDbType.Int);
            para[6].Value = cashno;

            para[7] = new SqlParameter("@acc_Bank_No", SqlDbType.Int);
            para[7].Value = bankno;

            para[8] = new SqlParameter("@u_Edit", SqlDbType.Int);
            para[8].Value = uadd;

            para[9] = new SqlParameter("@edit_Date", SqlDbType.DateTime);
            para[9].Value = adddate;

            para[10] = new SqlParameter("@j_no", SqlDbType.Int);
            para[10].Value = j_no;



            con.excuteCmd("Bond_Hdr_Update", para);
            con.closeConnection();


        }

        public void Bond_Details_Delete(int bno)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@b_No", SqlDbType.Int);
            para[0].Value = bno;
            con.excuteCmd("Bond_Detials_Delete", para);
            con.closeConnection();


        }


        public void Bond_Hdr_Delete(int bno)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@b_No", SqlDbType.Int);
            para[0].Value = bno;
            con.excuteCmd("Bond_Hdr_Delete", para);
            con.closeConnection();

        }

        public DataTable Get_Bond_Max(int btype)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@b_type", SqlDbType.Int);
            para[0].Value = btype;
            dt = con.selectData("get_bond_Max", para);
            con.closeConnection();

            return dt;
        }

        public DataTable Get_Bond_Min(int btype)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@b_type", SqlDbType.Int);
            para[0].Value = btype;
            dt = con.selectData("get_bond_Min", para);
            con.closeConnection();

            return dt;
        }

        

    }
}
