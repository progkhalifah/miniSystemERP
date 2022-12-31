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

namespace System_Accounting.PL.SysFormat
{
    public partial class frm_Currencies : Form
    {

        cls_sysFormat sf = new cls_sysFormat();

        public frm_Currencies()
        {
            InitializeComponent();
            get_all_currencies();
        }

        void get_all_currencies()
        {
           dgv_currencies.DataSource = sf.Get_All_Currencies();
            dgv_currencies.Columns[0].HeaderText = "رقم العملة";
            dgv_currencies.Columns[1].HeaderText = "اسم العملة";
            dgv_currencies.Columns[2].Visible = false;
            dgv_currencies.Columns[3].Visible = false;
            dgv_currencies.Columns[4].Visible = false;
            dgv_currencies.Columns[5].Visible = false;
            dgv_currencies.Columns[6].Visible = false;

        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            clearnce();

        }


        void clearnce()
        {
            foreach (var c in gb_inputs.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                    ((TextBox)c).Enabled = true;

                }
            }

            txt_accname.Focus();
            rb_local.Enabled = true;
            rb_forgin.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int ctype = 0;
                if (rb_local.Checked == true)
                {
                    ctype = 1;
                }else
                {
                    ctype = 2;
                }
                
                sf.add_Currencies(txt_accname.Text, txt_ecname.Text, txt_symbol.Text ,Convert.ToDouble(txt_exch.Text), txt_part.Text, ctype);
                get_all_currencies();
                MessageBox.Show("تم حفظ العملة بنجاح..","تم الحفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم حفظ البيانات يوجد هناك خطأ"+ex,"تنبية!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }

        private void dgv_currencies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearnce();
            txt_accname.Text = dgv_currencies.CurrentRow.Cells[1].Value.ToString();
            txt_ecname.Text = dgv_currencies.CurrentRow.Cells[2].Value.ToString();
            txt_symbol.Text = dgv_currencies.CurrentRow.Cells[3].Value.ToString();
            txt_exch.Text = dgv_currencies.CurrentRow.Cells[4].Value.ToString();
            txt_part.Text = dgv_currencies.CurrentRow.Cells[5].Value.ToString();
            if (dgv_currencies.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                rb_local.Checked = true;
            }
            else
            {
                rb_forgin.Checked = true;
            }

        } // end of dgv_currencies

        private void btn_edit_Click(object sender, EventArgs e)
        {

            try
            {
                int ctype = 0;
                if (rb_local.Checked == true)
                {
                    ctype = 1;
                }
                else
                {
                    ctype = 2;
                }
                int cno = 0;
                cno = Convert.ToInt32(dgv_currencies.CurrentRow.Cells[0].Value);
                sf.update_Currencies( cno ,txt_accname.Text, txt_ecname.Text, txt_symbol.Text, Convert.ToDouble(txt_exch.Text), txt_part.Text, ctype);
                get_all_currencies();
                MessageBox.Show("تم التعديل العملة بنجاح..", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم حفظ البيانات يوجد هناك خطأ" + ex, "تنبية!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حذف هذا العملة ؟","تنبية !",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    sf.delete_Currencies(Convert.ToInt32(dgv_currencies.CurrentRow.Cells[0].Value));
                    Show();
                    get_all_currencies();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تمت عملية الحذف بنجاح"+ex, "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }


            
        }
    }
}
