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
    public partial class frm_Order_List : Form
    {
        BL.PointOfSales.cls_order clo = new BL.PointOfSales.cls_order();
        public frm_Order_List()
        {
            InitializeComponent();
            dgv_all_orders.DataSource = clo.Search_All_Orders("");
        }

        private void txt_search_order_TextChanged(object sender, EventArgs e)
        {
            dgv_all_orders.DataSource = clo.Search_All_Orders(txt_search_order.Text);

        }



    }
}
