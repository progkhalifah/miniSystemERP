using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Accounting.BL.SysFormat;
using System_Accounting.PL.Account;

namespace System_Accounting.PL.SysFormat
{
    public partial class frm_cash : Form
    {

        cls_sysFormat sf = new cls_sysFormat();
        

        public frm_cash()
        {
            InitializeComponent();
            
        }

        void show()
        {

            dgv_cash.DataSource = sf.Get_All_Cash(Convert.ToInt32(txt_function.Text));
            dgv_cash.Columns[0].HeaderText = "رقم الحساب";
            dgv_cash.Columns[1].HeaderText = "اسم الحساب";

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_accno.Text = String.Empty;
            acc_name.Text = String.Empty;
            txt_accno.Enabled = true;
            txt_accno.Focus();
        }

        private void txt_accno_KeyDown(object sender, KeyEventArgs e)
        {
            frm_search fs = new frm_search();

            if (e.KeyCode == Keys.Enter)
            {
                fs.txt_search.Text = txt_accno.Text;
                fs.ShowDialog();
                if (fs.isOk == true)
                {
                    txt_accno.Text = fs.dgv_results.CurrentRow.Cells[0].Value.ToString();
                    acc_name.Text = fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
                    btn_save.Focus();
                }
                else
                {
                    MessageBox.Show("there is someting worng","Oops!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                sf.add_Cash(Convert.ToInt32(txt_accno.Text), acc_name.Text, Convert.ToInt32(txt_function.Text));
                show();
                MessageBox.Show("تمت عملية الحفظ بنجاح","عملية الحفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("تاكد من البيانات انها صحيحة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.Yes)
            {
                sf.delete_Cash(Convert.ToInt32(txt_accno.Text), Convert.ToInt32(txt_function));
                show();
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_cash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_accno.Text = dgv_cash.CurrentRow.Cells[0].Value.ToString();
            txt_function.Text = dgv_cash.CurrentRow.Cells[2].Value.ToString();

        }

       
    }
}
