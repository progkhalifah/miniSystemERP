using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Accounting.BL.Accounts;

namespace System_Accounting.PL.Account
{
    public partial class frm_search : Form
    {
        public bool isOk = false;

        public frm_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            cls_account ca = new cls_account();
            dgv_results.DataSource = ca.search_in_Accounts(txt_search.Text);
            dgv_results.Columns[0].HeaderText = "رقم الحساب";
            dgv_results.Columns[1].Visible = false;
            dgv_results.Columns[2].HeaderText = "اسم الحساب";
            dgv_results.Columns[3].Visible = false;
            dgv_results.Columns[4].Visible = false;
            dgv_results.Columns[5].Visible = false;
            dgv_results.Columns[6].Visible = false;
            dgv_results.Columns[7].Visible = false;
            dgv_results.Columns[8].Visible = false;

        }

        private void dgv_results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isOk = true;
            Close();
        }

        
    }
}
