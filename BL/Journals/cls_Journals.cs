using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Accounting.BL.Journals
{
    internal class cls_Journals
    {
        DataTable dt;

        public DataTable Generate_Jno()
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            dt = con.selectData("generate_Jno", null);
            con.closeConnection();
            return dt;
        }

        /// <summary>
        /// Get User Number
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public DataTable get_User_No(string uName)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@u_Name", SqlDbType.NVarChar, 10);
            para[0].Value = uName;
            dt = con.selectData("get_User_NO", para);
            con.closeConnection();
            return dt;
        }

    
        public void journal_Hdr_Add(int jno, DateTime jdate, int jType, string jnote, int jpost, double tdeb, double tdcred,double bal, int uadd, DateTime adate, int cno, double currexch, int ptype)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@j_No", SqlDbType.Int);
            para[0].Value = jno;
            para[1] = new SqlParameter("@j_Date", SqlDbType.DateTime);
            para[1].Value = jdate;
            para[2] = new SqlParameter("@j_Note", SqlDbType.NVarChar, 200);
            para[2].Value = jnote;
            para[3] = new SqlParameter("@j_Type", SqlDbType.Int);
            para[3].Value = jType;
            para[4] = new SqlParameter("@j_Post", SqlDbType.Int);
            para[4].Value = jpost;
            para[5] = new SqlParameter("@t_Debit", SqlDbType.Money);
            para[5].Value = tdeb;
            para[6] = new SqlParameter("@t_Credit", SqlDbType.Money);
            para[6].Value = tdcred;
            para[7] = new SqlParameter("@t_Balance", SqlDbType.Money);
            para[7].Value = bal;
            para[8] = new SqlParameter("@u_Add", SqlDbType.Int);
            para[8].Value = uadd;
            para[9] = new SqlParameter("@add_Date", SqlDbType.DateTime);
            para[9].Value = adate;
            para[10] = new SqlParameter("@curr_no", SqlDbType.Int);
            para[10].Value = cno;
            para[11] = new SqlParameter("@curr_exch", SqlDbType.Money);
            para[11].Value = currexch;
            para[12] = new SqlParameter("@p_no", SqlDbType.Int);
            para[12].Value = ptype;
            con.excuteCmd("Jorunal_Hdr_Add", para);
            con.closeConnection();
        }

        /// <summary>
        /// Journal Details Add
        /// </summary>
        /// <param name="accno"></param>
        /// <param name="accdebit"></param>
        /// <param name="acccredit"></param>
        /// <param name="accnote"></param>
        /// <param name="jno"></param>
        public void Journal_Details_Add (int accno, double accdebit, double acccredit, string accnote, int jno){
        
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;
            para[1] = new SqlParameter("@acc_Debit", SqlDbType.Money);
            para[1].Value = accdebit;
            para[2] = new SqlParameter("@acc_Credit", SqlDbType.Money);
            para[2].Value = acccredit;
            para[3] = new SqlParameter("@acc_Note", SqlDbType.NVarChar, 100);
            para[3].Value = accnote;
            para[4] = new SqlParameter("@j_No", SqlDbType.Int);
            para[4].Value = jno;
            con.excuteCmd("Jorunal_Details_Add", para);
            con.closeConnection();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jno"></param>
        /// <returns></returns>
        public DataTable show_journal_header(int jno)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@j_no",SqlDbType.Int);
            para[0].Value = jno;
            dt = con.selectData("show_journal_header",para);
            con.closeConnection();
            return dt;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jno"></param>
        /// <returns></returns>
        public DataTable show_journal_details(int jno)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@j_no",SqlDbType.Int);
            para[0].Value = jno;
            dt = con.selectData("show_journal_details",para);
            
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jno"></param>
        /// <param name="jdate"></param>
        /// <param name="jType"></param>
        /// <param name="jnote"></param>
        /// <param name="jpost"></param>
        /// <param name="tdeb"></param>
        /// <param name="tdcred"></param>
        /// <param name="bal"></param>
        /// <param name="uedit"></param>
        /// <param name="edate"></param>
        /// <param name="cno"></param>
        /// <param name="currexch"></param>
        public void journal_Hdr_Update(int jno, DateTime jdate, int jType, string jnote, int jpost, double tdeb, double tdcred, double bal, int uedit, DateTime edate, int cno, double currexch)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@j_No", SqlDbType.Int);
            para[0].Value = jno;
            para[1] = new SqlParameter("@j_Date", SqlDbType.DateTime);
            para[1].Value = jdate;
            para[2] = new SqlParameter("@j_Note", SqlDbType.NVarChar, 200);
            para[2].Value = jnote;
            para[3] = new SqlParameter("@j_Type", SqlDbType.Int);
            para[3].Value = jType;
            para[4] = new SqlParameter("@j_Post", SqlDbType.Int);
            para[4].Value = jpost;
            para[5] = new SqlParameter("@t_Debit", SqlDbType.Money);
            para[5].Value = tdeb;
            para[6] = new SqlParameter("@t_Credit", SqlDbType.Money);
            para[6].Value = tdcred;
            para[7] = new SqlParameter("@t_Balance", SqlDbType.Money);
            para[7].Value = bal;
            para[8] = new SqlParameter("@u_Edit", SqlDbType.Int);
            para[8].Value = uedit;
            para[9] = new SqlParameter("@edit_date", SqlDbType.DateTime);
            para[9].Value = edate;
            para[10] = new SqlParameter("@curr_no", SqlDbType.Int);
            para[10].Value = cno;
            para[11] = new SqlParameter("@curr_exch", SqlDbType.Money);
            para[11].Value = currexch;
            con.excuteCmd("Jorunal_Hdr_Update", para);
            con.closeConnection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accno"></param>
        /// <param name="accdebit"></param>
        /// <param name="acccredit"></param>
        /// <param name="accnote"></param>
        /// <param name="jno"></param>
        public void Journal_Details_Update(int accno, double accdebit, double acccredit, string accnote, int jno)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@acc_No", SqlDbType.Int);
            para[0].Value = accno;
            para[1] = new SqlParameter("@acc_Debit", SqlDbType.Money);
            para[1].Value = accdebit;
            para[2] = new SqlParameter("@acc_Credit", SqlDbType.Money);
            para[2].Value = acccredit;
            para[3] = new SqlParameter("@acc_Note", SqlDbType.NVarChar, 100);
            para[3].Value = accnote;
            para[4] = new SqlParameter("@j_No", SqlDbType.Int);
            para[4].Value = jno;
            con.excuteCmd("Jorunal_Details_Update", para);
            con.closeConnection();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jno"></param>
        /// <returns></returns>
        public void delete_journal_header(int jno)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@j_no", SqlDbType.Int);
            para[0].Value = jno;
            con.excuteCmd("Jonral_Hdr_Delete", para);
            con.closeConnection();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jno"></param>
        /// <returns></returns>
        public void delete_journal_Details(int jno)
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@j_no", SqlDbType.Int);
            para[0].Value = jno;
            con.excuteCmd("Jonral_Detials_Delete", para);

        }

        public DataTable get_Journal_First()
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            dt = con.selectData("Get_Journal_First", null);

            return dt;
        }

        public DataTable get_Journal_Last()
        {
            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();
            con.openConnection();
            dt = new DataTable();
            dt = con.selectData("Get_Journal_Last", null);

            return dt;
        }

         


    }
}
