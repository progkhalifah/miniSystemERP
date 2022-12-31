using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace System_Accounting.BL.Products
{
    internal class cls_Products
    {
        DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();



        public DataTable Get_All_Categories()
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();

            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("get_all_categories", null);
            con.closeConnection();

            return dt;

        }


        public void Add_Product(int id_cat, string id_product, string label_product, int quantity_inStock, double price, byte[] image_product)
        {

            con.openConnection();
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            para[0].Value = id_cat;

            para[1] = new SqlParameter("@id_product", SqlDbType.NVarChar, 50);
            para[1].Value = id_product;

            para[2] = new SqlParameter("@label_product", SqlDbType.NVarChar, 50);
            para[2].Value = label_product;

            para[3] = new SqlParameter("@quantity_inStock", SqlDbType.Int);
            para[3].Value = quantity_inStock;

            para[4] = new SqlParameter("@price", SqlDbType.Decimal);
            para[4].Value = price;

            para[5] = new SqlParameter("@image_product", SqlDbType.Image);
            para[5].Value = image_product;

            con.excuteCmd("add_products", para);
            con.closeConnection();

        }


        public DataTable Verfiy_Product(string ID)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();

            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            para[0].Value = ID;
            dt = con.selectData("verify_Product_ID", para);
            con.closeConnection();

            return dt;

        }

        public DataTable Get_All_Prodcuts()
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();

            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("get_all_products", null);
            con.closeConnection();

            return dt;

        }


        public DataTable Search_Product(string ID)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();

            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            para[0].Value = ID;
            dt = con.selectData("search_Product_ID", para);
            con.closeConnection();

            return dt;

        }

        public void Delete_Product(string ID)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();

            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            para[0].Value = ID;
            con.excuteCmd("delete_Product", para);
            con.closeConnection();


        }

        public DataTable Get_Image_Product(string ID)
        {

            DAL.ConnectionDatabase con = new DAL.ConnectionDatabase();

            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            para[0].Value = ID;
            dt = con.selectData("get_image_Product", para);
            con.closeConnection();

            return dt;

        }


        public void Update_Product(int id_cat, string id_product, string label_product, int quantity_inStock, double price, byte[] image_product)
        {

            con.openConnection();
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            para[0].Value = id_cat;

            para[1] = new SqlParameter("@id_product", SqlDbType.NVarChar, 50);
            para[1].Value = id_product;

            para[2] = new SqlParameter("@label_product", SqlDbType.NVarChar, 50);
            para[2].Value = label_product;

            para[3] = new SqlParameter("@quantity_inStock", SqlDbType.Int);
            para[3].Value = quantity_inStock;

            para[4] = new SqlParameter("@price", SqlDbType.Decimal);
            para[4].Value = price;

            para[5] = new SqlParameter("@image_product", SqlDbType.Image);
            para[5].Value = image_product;

            con.excuteCmd("update_products", para);
            con.closeConnection();

        }



    }
}
