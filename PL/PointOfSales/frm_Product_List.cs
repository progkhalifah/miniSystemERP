using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Accounting.PL.PointOfSales
{
    public partial class frm_Product_List : Form
    {

        BL.Products.cls_Products clp = new BL.Products.cls_Products();
        DataTable dt;
        public frm_Product_List()
        {
            InitializeComponent();
            get_all_products();
        }

        void get_all_products()
        {
            dgv_product_list.DataSource = clp.Get_All_Prodcuts();

        }

        private void dgv_product_list_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
