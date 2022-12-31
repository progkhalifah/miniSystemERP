using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Accounting.PL.Journals;
using System_Accounting.PL.PointOfSales;

namespace System_Accounting.PL
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        } // end of Load

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Account.frm_accounts fa = new PL.Account.frm_accounts();
            fa.Show();
        }

        private void الصناديقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_cash frm_Cash = new SysFormat.frm_cash();
            frm_Cash.Text = "الصناديق";
            frm_Cash.gp_cash.Text = "الصناديق";
            frm_Cash.txt_function.Text = "1";
            frm_Cash.Show();
        }

        private void البنوكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_cash frm_Cash = new SysFormat.frm_cash();
            frm_Cash.Text = "البنوك";
            frm_Cash.gp_cash.Text = "البنوك";
            frm_Cash.txt_function.Text = "2";
            frm_Cash.ShowDialog();
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.SysFormat.frm_Currencies frm_Currencies = new PL.SysFormat.frm_Currencies();
            frm_Currencies.ShowDialog();

        }

        private void قيداليوميةالعامToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.Journals.frm_journals fj = new frm_journals();
            fj.ShowDialog();

        }

        private void سندالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Bonds.frm_Bounds fb = new Bonds.frm_Bounds();
            fb.Text = "سند صرف";
            fb.gp_bonds.Text = "بيانات سند الصرف";
            fb.txt_btype.Text = "2";
            fb.ShowDialog();
        }

        private void سندالقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Bonds.frm_Bounds fb = new Bonds.frm_Bounds();
            fb.Text = "سند قبض";
            fb.gp_bonds.Text = "بيانات سند القبض";
            fb.txt_btype.Text = "3";
            fb.ShowDialog();
        }

        private void إضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Products.frm_Add_Products products = new Products.frm_Add_Products();
            products.ShowDialog();
        }

        private void إدارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Products.frm_Products_manag frm_Products_Manag = new PL.Products.frm_Products_manag();
            frm_Products_Manag.ShowDialog();
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Inventory.frm_Categories frm_inventory = new Inventory.frm_Categories();
            frm_inventory.ShowDialog();
        }

        

        private void المبيعاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.PointOfSales.frm_Orders frm_Orders = new PointOfSales.frm_Orders();
            frm_Orders.ShowDialog();
        }

        private void البحثعنفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.PointOfSales.frm_Order_List frm_Order_List = new frm_Order_List();
            frm_Order_List.ShowDialog();
        }




    }
}
