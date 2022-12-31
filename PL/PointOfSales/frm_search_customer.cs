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
    public partial class frm_search_customer : Form
    {

        BL.PointOfSales.cls_order clo = new BL.PointOfSales.cls_order();

        public frm_search_customer()
        {
            InitializeComponent();
            retrive_all_customers();
        }

        void retrive_all_customers()
        {
            this.dgv_all_customers.DataSource = clo.Get_All_Customers();
            dgv_all_customers.Columns[0].Visible = false;
            dgv_all_customers.Columns[10].Visible = false;
        }

        private void txt_search_customers_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = clo.Search_All_Players(txt_search_customers.Text);
            this.dgv_all_customers.DataSource = dt;
        }

        private void dgv_all_customers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
