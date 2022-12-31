using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Accounting.PL.Account;

namespace System_Accounting.PL.Bonds
{
    public partial class frm_Bounds : Form
    {

        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        BL.Bonds.cls_Bonds cb = new BL.Bonds.cls_Bonds();
        BL.Journals.cls_Journals cj = new BL.Journals.cls_Journals();

        public frm_Bounds()
        {
            InitializeComponent();
        }

        void show()
        {
            
            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "curr_No";
            cb_currency.DisplayMember = "curr_Name";

            cb_cash.DataSource = sf.Get_All_Cashes();
            cb_cash.ValueMember = "c_acc_No";
            cb_cash.DisplayMember = "C_ACC_Name";

        }

        void clear()
        {
            dtp_bdate.Value = DateTime.Now;
            txt_note.Text = string.Empty;
            chk_post.Checked = false;
            dgv_journal.Rows.Clear();
        }

        private void frm_Bounds_Load(object sender, EventArgs e)
        {
            txt_user.Text = Program.uname;
            show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sf.get_Curr_Exch(cb_currency.Text);
            if (dt.Rows.Count > 0)
            {
                txt_exch.Text = dt.Rows[0][2].ToString();
                txt_note.Focus();
            }
        }

        private void cb_cash_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sf.get_Cash_Accno(cb_cash.Text);
            if (dt.Rows.Count > 0)
            {
                txt_cash_accno.Text = dt.Rows[0][0].ToString();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_bno.Text = cb.generate_Bno(Convert.ToInt32(txt_btype.Text)).Rows[0][0].ToString();

            txt_jno.Text = cj.Generate_Jno().Rows[0][0].ToString();

            show();
            clear();
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
                    txt_accname.Text = fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
                    txt_amount.Focus();
                }
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_accno.Text == "")
            {
                MessageBox.Show("يجب اختيار رقم الحساب", "تنبية",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txt_amount.Text == "0.00")
            {
                MessageBox.Show("يجب إدخال المبلغ أولاً", "تنبية",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txt_exch.Text == "0.00")
            {
                MessageBox.Show("يجب اختيار عملة الصنف", "تنبية",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgv_journal.Rows.Count ; i++)
            {
                if (dgv_journal.Rows[i].Cells[1].Value.ToString() == txt_accno.Text)
                {
                    MessageBox.Show("رقم الحساب موجود موسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            double ta = 0.00;
            ta = Convert.ToDouble(txt_amount.Text)*Convert.ToDouble(txt_exch.Text);


            dgv_journal.Rows.Add(txt_bno.Text, txt_accno.Text, txt_accname.Text, txt_amount.Text, 
                cb_currency.SelectedValue, cb_currency.Text, 
                txt_exch.Text, txt_exp.Text, ta);

            total_Amount();
            row_Clear();


        }

        private void total_Amount()
        {
            double ta = 0.00;
            for (int i = 0; i < dgv_journal.Rows.Count; i++)
            {
                ta = ta + Convert.ToDouble(dgv_journal.Rows[i].Cells[8].Value.ToString());

            }

            txt_Tamount.Text = ta.ToString();

        }

        void row_Clear()
        {
            txt_accno.Text = "";
            txt_accname.Text = "";
            txt_amount.Text = "0.00";
            txt_exp.Text = "";
            
            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "curr_No";
            cb_currency.DisplayMember = "curr_Name";
        }

        void edit_Row()
        {
            txt_accno.Text = dgv_journal.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_journal.CurrentRow.Cells[2].Value.ToString();
            txt_amount.Text = dgv_journal.CurrentRow.Cells[3].Value.ToString();
            cb_currency.SelectedValue = dgv_journal.CurrentRow.Cells[4].Value.ToString();
            txt_exch.Text = dgv_journal.CurrentRow.Cells[6].Value.ToString();
            txt_exp.Text = dgv_journal.CurrentRow.Cells[7].Value.ToString();
            dgv_journal.Rows.RemoveAt(dgv_journal.CurrentRow.Index);

        }

        private void dgv_journal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            edit_Row();
            total_Amount();

        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_journal.Rows.RemoveAt(dgv_journal.CurrentRow.Index);
            total_Amount();
        }

        private void تعديلالملفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_Row();
            total_Amount();
        }


        void bond_Hdr_Add()
        {

            int bpost = 0;
            if (chk_post.Checked == true)
            {
                bpost = 1;
            }
            else
            {
                bpost = 0;
            }

            DateTime adate = DateTime.Now;

            int txtbankno = 0;
            int userno = 1002;

            cb.bond_Hdr_Add(Convert.ToInt32(txt_bno.Text),Convert.ToDateTime(dtp_bdate.Value),txt_note.Text,Convert.ToInt32(txt_btype.Text),
                bpost,Convert.ToDouble(txt_Tamount.Text),Convert.ToInt32(txt_cash_accno.Text),txtbankno,userno,adate, Convert.ToInt32(txt_jno.Text));
        }

        void bond_Details_Add()
        {
            for (int i = 0; i < dgv_journal.Rows.Count; i++)
            {
                int accno = Convert.ToInt32(dgv_journal.Rows[i].Cells[1].Value);
                double amount = Convert.ToDouble(dgv_journal.Rows[i].Cells[3].Value);
                string note = dgv_journal.Rows[i].Cells[7].Value.ToString();
                int currno = Convert.ToInt32(dgv_journal.Rows[i].Cells[4].Value);
                double cexch = Convert.ToDouble(dgv_journal.Rows[i].Cells[6].Value);
                int bno = Convert.ToInt32(dgv_journal.Rows[i].Cells[0].Value);
                cb.bond_Details_Add(accno, amount, note, currno, cexch, bno);

            }

        }

        void journal_Hdr_Add()
        {
            int jtype = 1;

            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }
            double bal = 0;
            DateTime adate = DateTime.Now;

            cj.journal_Hdr_Add(Convert.ToInt32(txt_jno.Text), Convert.ToDateTime(dtp_bdate.Value), jtype, txt_note.Text, jpost,
                Convert.ToDouble(txt_Tamount.Text), Convert.ToDouble(txt_Tamount.Text), bal, 1002, adate, 
                Convert.ToInt32(cb_currency.SelectedValue), Convert.ToDouble(txt_exch.Text), Convert.ToInt32(txt_btype.Text));
        }

        void journal_Details_Add()
        {
            if (txt_btype.Text == "2")
            {

                // من حساب الطرف الاخر


                // الي حساب الصندوق
                for (int i = 0; i < dgv_journal.Rows.Count; i++)
                {
                    cj.Journal_Details_Add(Convert.ToInt32(
                        dgv_journal.Rows[i].Cells[1].Value),
                        Convert.ToDouble(dgv_journal.Rows[i].Cells[8].Value),
                        0,
                        dgv_journal.Rows[i].Cells[7].Value.ToString(),
                        Convert.ToInt32(txt_jno.Text)
                        );
                }

                cj.Journal_Details_Add(Convert.ToInt32(txt_cash_accno.Text),0,Convert.ToDouble(txt_Tamount.Text),txt_note.Text, Convert.ToInt32(txt_jno.Text));
                
            }
            else
            {

                // من حساب الصندوق


                // الي حساب الطرف الاخر
                for (int i = 0; i < dgv_journal.Rows.Count; i++)
                {
                    cj.Journal_Details_Add(Convert.ToInt32(
                        dgv_journal.Rows[i].Cells[1].Value),
                        0,
                        Convert.ToDouble(dgv_journal.Rows[i].Cells[3].Value),
                        dgv_journal.Rows[i].Cells[7].Value.ToString(),
                        Convert.ToInt32(txt_jno.Text)
                        );
                }

                cj.Journal_Details_Add( Convert.ToInt32(txt_cash_accno.Text), Convert.ToDouble(txt_Tamount.Text), 0,txt_note.Text, Convert.ToInt32(txt_jno.Text));

            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bond_Hdr_Add();
                bond_Details_Add();
                journal_Hdr_Add();
                journal_Details_Add();
                MessageBox.Show("تمت عملية الحفظ بنجاح","حفظ السند",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("يجب التحقق من البيانات التي قمت بادخالها","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txt_bound_no.Text = txt_search.Text;
        }


        void show_bond_hdr()
        {
            DataTable dt = new DataTable();
            dt = cb.show_Bond_Hdr(Convert.ToInt32(txt_bound_no.Text));
            if (dt.Rows.Count > 0)
            {
                txt_bno.Text = dt.Rows[0][0].ToString();
                dtp_bdate.Text = dt.Rows[0][1].ToString();
                txt_btype.Text = dt.Rows[0][3].ToString();
                txt_jno.Text = dt.Rows[0][13].ToString();
                txt_note.Text = dt.Rows[0][4].ToString();
                if (dt.Rows[0][3].ToString() == "1")
                {
                    chk_post.Checked = true;
                }
                else
                {
                    chk_post.Checked = false;
                }
                cb_cash.SelectedValue = dt.Rows[0][6];
                txt_Tamount.Text = dt.Rows[0][5].ToString();
                txt_user.Text = dt.Rows[0][9].ToString();
                
            }
        }

        void show_bond_details()
        {

            DataTable dt = new DataTable();
            dt = cb.show_Bond_Details(Convert.ToInt32(txt_bound_no.Text));
            if (dt.Rows.Count > 0)
            {
                dgv_journal.Rows.Clear();
                int i = 0;
                dgv_journal.RowCount = dt.Rows.Count;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    dgv_journal.Rows[i].Cells[0].Value = dt.Rows[j][7].ToString();
                    dgv_journal.Rows[i].Cells[1].Value = dt.Rows[j][0].ToString();
                    dgv_journal.Rows[i].Cells[2].Value = dt.Rows[j][1].ToString();
                    dgv_journal.Rows[i].Cells[3].Value = dt.Rows[j][2].ToString();
                    dgv_journal.Rows[i].Cells[4].Value = dt.Rows[j][3].ToString();
                    dgv_journal.Rows[i].Cells[5].Value = dt.Rows[j][5].ToString();
                    dgv_journal.Rows[i].Cells[6].Value = dt.Rows[j][6].ToString();
                    dgv_journal.Rows[i].Cells[7].Value = dt.Rows[j][3].ToString();
                    dgv_journal.Rows[i].Cells[8].Value = Convert.ToDouble(dt.Rows[j][2]) * Convert.ToDouble(dt.Rows[j][6]);

                    i++;

                }

            }

        }


        private void txt_bound_no_TextChanged(object sender, EventArgs e)
        {

            try
            {
                show_bond_hdr();
                show_bond_details();
            }
            catch (Exception)
            {

                throw;
            }

            
        }


        void bond_Hdr_Edit()
        {

            int bpost = 0;
            if (chk_post.Checked == true)
            {
                bpost = 1;
            }
            else
            {
                bpost = 0;
            }

            DateTime adate = DateTime.Now;

            int txtbankno = 0;
            int userno = 1002;

            cb.bond_Hdr_Edit(Convert.ToInt32(txt_bno.Text), Convert.ToDateTime(dtp_bdate.Value), txt_note.Text, Convert.ToInt32(txt_btype.Text),
                bpost, Convert.ToDouble(txt_Tamount.Text), Convert.ToInt32(txt_cash_accno.Text), txtbankno, userno, adate, Convert.ToInt32(txt_jno.Text));
        }

        void bond_Details_Del()
        {
            cb.Bond_Details_Delete(Convert.ToInt32(txt_bno.Text));
        }

        void journal_Hdr_Del()
        {
            cj.delete_journal_header(Convert.ToInt32(txt_bno.Text));
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                bond_Hdr_Edit();
                bond_Details_Del();
                bond_Details_Add();
                journal_Hdr_Del();
                journal_Hdr_Add();
                journal_Details_Add();
                MessageBox.Show("تمت عملية التعديل بنجاح بنجاح", "حذف السند", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("يجب التحقق من البيانات التي قمت بادخالها", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل متأكد من حذف هذا السند", "تنبية!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cj.delete_journal_header(Convert.ToInt32(txt_jno.Text));
                    cb.Bond_Hdr_Delete(Convert.ToInt32(txt_bno.Text));
                    show();
                    clear();
                    txt_bno.Text = "0";
                    txt_jno.Text = "0";
                    MessageBox.Show("تمت عملية الحذف بنجاح", "حذف سند", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! "+" "+ex);
            }
        }

        void get_Max_Number()
        {
           txt_bound_no.Text = cb.Get_Bond_Max(Convert.ToInt32(txt_btype.Text)).Rows[0][0].ToString();
        }

        void get_Min_Number()
        {
            txt_bound_no.Text = cb.Get_Bond_Min(Convert.ToInt32(txt_btype.Text)).Rows[0][0].ToString();
        }


        private void btn_first_Click(object sender, EventArgs e)
        {
            get_Min_Number();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            get_Max_Number();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int Bmax = Convert.ToInt32(cb.Get_Bond_Max(Convert.ToInt32(txt_btype.Text)).Rows[0][0]);
            if (Convert.ToInt32(txt_bound_no.Text) == Bmax)
            {
                MessageBox.Show("هذا هو أخر سند","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_bound_no.Text = (Convert.ToInt32(txt_bound_no.Text)+1).ToString();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int Bmin = Convert.ToInt32(cb.Get_Bond_Min(Convert.ToInt32(txt_btype.Text)).Rows[0][0]);
            if (Convert.ToInt32(txt_bound_no.Text) == Bmin)
            {
                MessageBox.Show("هذا هو أول سند", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_bound_no.Text = (Convert.ToInt32(txt_bound_no.Text) - 1).ToString();
            }
        }
    }
}
