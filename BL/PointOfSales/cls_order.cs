using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Accounting.BL.PointOfSales
{

    class cls_order
    {



        DataTable dt = new DataTable();
        DAL.ConnectionDatabase conn = new DAL.ConnectionDatabase();

        // get last id order
        public DataTable Get_Last_ID()
        {

            conn.openConnection();
            dt = conn.selectData("get_last_order_id", null);
            conn.closeConnection();

            return dt;

        }



        // get all customers
        public DataTable Get_All_Customers()
        {
            conn.openConnection();
            dt = conn.selectData("get_all_players", null);
            conn.closeConnection();
            return dt;
        }



        // search all players
        public DataTable Search_All_Players(string name_player)
        {

            conn.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@name_player", SqlDbType.NVarChar, 250);
            para[0].Value = name_player;
            dt = conn.selectData("search_all_players", para);
            conn.closeConnection();

            return dt;

        }


        public void Add_Order(int id_order, DateTime date_order, int stat_no_player, string description_order, string sales_man)
        {

            conn.openConnection();
            SqlParameter[] para = new SqlParameter[5];

            para[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            para[0].Value = id_order;

            para[1] = new SqlParameter("@Date_order", SqlDbType.DateTime);
            para[1].Value = date_order;

            para[2] = new SqlParameter("@stat_no_player", SqlDbType.Int);
            para[2].Value = stat_no_player;

            para[3] = new SqlParameter("@description_order", SqlDbType.NVarChar, 250);
            para[3].Value = description_order;

            para[4] = new SqlParameter("@sales_man", SqlDbType.NVarChar, 250);
            para[4].Value = sales_man;


            conn.excuteCmd("add_order", para);
            conn.closeConnection();

        } // end of Add Order



        public void Add_Order_Details(string id_product, int id_order, int quantity, string price, double discount, string amount, string total_amount)
        {

            conn.openConnection();
            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter("@ID_product", SqlDbType.NVarChar, 50);
            para[0].Value = id_product;

            para[1] = new SqlParameter("@ID_order", SqlDbType.Int);
            para[1].Value = id_order;

            para[2] = new SqlParameter("@quantity", SqlDbType.Int);
            para[2].Value = quantity;

            para[3] = new SqlParameter("@price", SqlDbType.NVarChar, 100);
            para[3].Value = price;

            para[4] = new SqlParameter("@dicount", SqlDbType.Float);
            para[4].Value = discount;

            para[5] = new SqlParameter("@amount", SqlDbType.NVarChar, 100);
            para[5].Value = amount;

            para[6] = new SqlParameter("@total_amount", SqlDbType.NVarChar, 100);
            para[6].Value = total_amount;

            conn.excuteCmd("add_order_details", para);
            conn.closeConnection();

        } // end of Add Order


        public DataTable Verify_Quantity(string id_product, int quantity_entered)
        {

            conn.openConnection();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ID_product", SqlDbType.NVarChar, 250);
            para[0].Value = id_product;
            
            para[1] = new SqlParameter("@quantity_entered", SqlDbType.Int);
            para[1].Value = quantity_entered;

            dt = conn.selectData("verify_quantity", para);
            conn.closeConnection();

            return dt;

        }


        // search all players
        public DataTable Search_All_Orders(string name_order)
        {

            conn.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@nameorder", SqlDbType.NVarChar, 250);
            para[0].Value = name_order;
            dt = conn.selectData("search_order_list", para);
            conn.closeConnection();

            return dt;

        }



    }



}
