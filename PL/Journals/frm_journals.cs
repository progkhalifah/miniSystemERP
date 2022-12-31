using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Accounting.BL.Journals;
using System_Accounting.PL.Account;

namespace System_Accounting.PL.Journals
{
    public partial class frm_journals : Form
    {

        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        BL.Journals.cls_Journals cj = new BL.Journals.cls_Journals();
        public frm_journals()
        {
            InitializeComponent();
            show();
        }


        void show()
        {

            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "curr_No";
            cb_currency.DisplayMember = "curr_Name";

        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_journals_Load(object sender, EventArgs e)
        {

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
                    txt_debit.Focus();
                }
            }

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

        void Enter_Row()
        {
            double td = Convert.ToDouble(txt_debit.Text) * Convert.ToDouble(txt_exch.Text);
            double tc = Convert.ToDouble(txt_credit.Text) * Convert.ToDouble(txt_exch.Text);
            dgv_journal.Rows.Add(txt_jno.Text, txt_accno.Text, txt_accname.Text, txt_debit.Text, txt_credit.Text, cb_currency.SelectedValue, cb_currency.Text, txt_exch.Text, txt_exp.Text, td, tc);
        }

        void Clear()
        {
            txt_accno.Text = "";
            txt_accno.Focus();
            txt_accname.Text = "";
            txt_debit.Text = "0.00";
            txt_credit.Text = "0.00";
            show();
            txt_exp.Text = "";

        }

        void Total_Bal()
        {

            double TD = 0;
            double TC = 0;

            for (int i = 0; i < dgv_journal.Rows.Count; i++)
            {
                TD = TD + Convert.ToDouble(dgv_journal.Rows[i].Cells[9].Value);
                TC = TC + Convert.ToDouble(dgv_journal.Rows[i].Cells[10].Value);
            }

            txt_Tdebit.Text = TD.ToString("0.00");
            txt_Tcredit.Text = TC.ToString("0.00");
            txt_Delf.Text = (TD - TC).ToString("0.00");

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {

            if (txt_accno.Text == "")
            {
                MessageBox.Show("يجب اختيار رقم الحساب", "تنبية!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Convert.ToDouble(txt_debit.Text) == 0.00 && Convert.ToDouble(txt_credit.Text) == 0.00)
            {
                MessageBox.Show("لا يوجد مبلغ في طرف القيد..! يرجى ادخال المبلغ", "تنبية!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ( txt_debit.Text == "")
            {
                txt_debit.Text = "0.00";
            }
            else if (txt_credit.Text == "")
            {
                txt_credit.Text = "0.00";
            }

            if (Convert.ToDouble(txt_exch.Text) == 0.00)
            {
                MessageBox.Show("يرجى اختيار العملة لطرف القيد", "تنبية!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            for (int i = 0; i < dgv_journal.Rows.Count; i++)
            {

                if (dgv_journal.Rows[i].Cells[1].Value.ToString() == txt_accno.Text)
                {
                    MessageBox.Show("لا يمكن تكرار حساب معين", "تنبية!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    return;
                }
            }

            //Entering data into DataGridView
            Enter_Row();
            // Clear Data from TextBoxes
            Clear();
            // Calculating Total of Debit and Credit Balances
            Total_Bal();


        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_journal.Rows.RemoveAt(dgv_journal.CurrentRow.Index);
            Total_Bal();
        } // end of delete row

        private void dgv_journal_DoubleClick(object sender, EventArgs e)
        {
            txt_accno.Text = dgv_journal.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_journal.CurrentRow.Cells[2].Value.ToString();
            txt_debit.Text = dgv_journal.CurrentRow.Cells[3].Value.ToString();
            txt_credit.Text = dgv_journal.CurrentRow.Cells[4].Value.ToString();
            cb_currency.SelectedValue = dgv_journal.CurrentRow.Cells[5].Value.ToString();
            txt_exch.Text = dgv_journal.CurrentRow.Cells[7].Value.ToString();
            txt_exp.Text = dgv_journal.CurrentRow.Cells[8].Value.ToString();
            dgv_journal.Rows.RemoveAt(dgv_journal.CurrentRow.Index);
            Total_Bal();

        }

        private void تعديلالملفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_accno.Text = dgv_journal.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_journal.CurrentRow.Cells[2].Value.ToString();
            txt_debit.Text = dgv_journal.CurrentRow.Cells[3].Value.ToString();
            txt_credit.Text = dgv_journal.CurrentRow.Cells[4].Value.ToString();
            cb_currency.SelectedValue = dgv_journal.CurrentRow.Cells[5].Value.ToString();
            txt_exch.Text = dgv_journal.CurrentRow.Cells[7].Value.ToString();
            txt_exp.Text = dgv_journal.CurrentRow.Cells[8].Value.ToString();
            dgv_journal.Rows.RemoveAt(dgv_journal.CurrentRow.Index);
            Total_Bal();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {


            txt_jno.Text = cj.Generate_Jno().Rows[0][0].ToString();
            txt_note.Text = "";
            show();
            Clear();
            dgv_journal.Rows.Clear();
            Total_Bal();

        } // end of new click


        void journal_Header_Add()
        {
            DateTime jdate = Convert.ToDateTime(dtp_jdate.Value.ToLongDateString());
            DateTime adate = DateTime.Now;
            int jno = Convert.ToInt32(cj.get_User_No(Program.uname).Rows[0][0].ToString());
            int jtype = 0;
            if (rb_general.Checked == true)
            {
                jtype = 1;
            }
            if (rb_wait.Checked == true)
            {
                jtype = 4;
            }
            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }

            int ptype = 1; 

            cj.journal_Hdr_Add(Convert.ToInt32(txt_jno.Text), jdate, jtype, txt_note.Text, jpost, Convert.ToDouble(txt_Tdebit.Text),
                Convert.ToDouble(txt_Tcredit.Text), Convert.ToDouble(txt_Delf.Text), jno, adate,
                Convert.ToInt32(cb_currency.SelectedValue), Convert.ToDouble(txt_exch.Text), ptype);

        }


        void journal_Details_Add()
        {
            for (int i = 0; i < dgv_journal.Rows.Count; i++)
            {
                if (dgv_journal.Rows.Count > 0)
                {
                    int accno = Convert.ToInt32(dgv_journal.Rows[i].Cells[1].Value.ToString());
                    double accdeb = Convert.ToDouble(dgv_journal.Rows[i].Cells[3].Value.ToString());
                    double accred = Convert.ToDouble(dgv_journal.Rows[i].Cells[4].Value.ToString());
                    string accnote = dgv_journal.Rows[i].Cells[8].Value.ToString();
                    int jno = Convert.ToInt32(dgv_journal.Rows[i].Cells[0].Value.ToString());
                    cj.Journal_Details_Add(accno, accdeb, accred, accnote, jno);
                }
            }
        }

        void journal_Header_Update()
        {
            DateTime jdate = Convert.ToDateTime(dtp_jdate.Value.ToLongDateString());
            DateTime edate = DateTime.Now;
            int jno = Convert.ToInt32(cj.get_User_No(Program.uname).Rows[0][0].ToString());
            int jtype = 0;
            if (rb_general.Checked == true)
            {
                jtype = 1;
            }
            if (rb_wait.Checked == true)
            {
                jtype = 4;
            }
            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }
            cj.journal_Hdr_Update(Convert.ToInt32(txt_jno.Text), jdate, jtype, txt_note.Text, jpost, Convert.ToDouble(txt_Tdebit.Text),
                Convert.ToDouble(txt_Tcredit.Text), Convert.ToDouble(txt_Delf.Text), jno, edate,
                Convert.ToInt32(cb_currency.SelectedValue), Convert.ToDouble(txt_exch.Text));
        }

        /*void journal_Details_Update()
        {
            for (int i = 0; i < dgv_journal.Rows.Count; i++)
            {
                if (dgv_journal.Rows.Count > 0)
                {
                    int accno = Convert.ToInt32(dgv_journal.Rows[i].Cells[1].Value.ToString());
                    double accdeb = Convert.ToDouble(dgv_journal.Rows[i].Cells[3].Value.ToString());
                    double accred = Convert.ToDouble(dgv_journal.Rows[i].Cells[4].Value.ToString());
                    string accnote = dgv_journal.Rows[i].Cells[8].Value.ToString();
                    int jno = Convert.ToInt32(dgv_journal.Rows[i].Cells[0].Value.ToString());
                    cj.Journal_Details_Update(accno, accdeb, accred, accnote, jno);
                }
            }
        }*/

        private void btn_save_Click(object sender, EventArgs e)
        {
            //---------------
            journal_Header_Add();
            journal_Details_Add();
            show();
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txt_jo_no.Text = txt_search.Text;
        }

        private void txt_jo_no_TextChanged(object sender, EventArgs e)
        {
            // Get data from tbl Journal Header
            DataTable dt1 = new DataTable();
            dt1 = cj.show_journal_header(Convert.ToInt32(txt_jo_no.Text));


            if (dt1.Rows.Count > 0)
            {
                txt_jno.Text = dt1.Rows[0][0].ToString();
                dtp_jdate.Text = dt1.Rows[0][1].ToString();
                if (dt1.Rows[0][3].ToString() == "1")
                {
                    rb_general.Checked = true;
                }

                if (dt1.Rows[0][3].ToString() == "4")
                {
                    rb_wait.Checked = true;
                }

                txt_note.Text = dt1.Rows[0][2].ToString();
                if (dt1.Rows[0][4].ToString() == "1")
                {
                    chk_post.Checked = true;
                }
                else
                {
                    chk_post.Checked = false;
                }

                cb_currency.SelectedValue = Convert.ToInt32(dt1.Rows[0][12].ToString());
                txt_exch.Text = dt1.Rows[0][14].ToString();
                txt_Tdebit.Text = dt1.Rows[0][5].ToString();
                txt_Tcredit.Text = dt1.Rows[0][6].ToString();
                txt_Delf.Text = dt1.Rows[0][7].ToString();
                txt_ptype.Text = dt1.Rows[0][16].ToString();
            }
            else
            {

                cleare_Data();

            }

            // Get Data from tbl Journal Details
            DataTable dt2 = new DataTable();
            dt2 = cj.show_journal_details(Convert.ToInt32(txt_jo_no.Text));
            if (dt2.Rows.Count > 0)
            {
                dgv_journal.Rows.Clear();
                int i = 0;
                dgv_journal.RowCount = dt2.Rows.Count;
                for (int j = 0; j < dgv_journal.Rows.Count; j++)
                {
                    dgv_journal.Rows[i].Cells[0].Value = dt2.Rows[j][5].ToString();
                    dgv_journal.Rows[i].Cells[1].Value = dt2.Rows[j][0].ToString();
                    dgv_journal.Rows[i].Cells[2].Value = dt2.Rows[j][1].ToString();
                    dgv_journal.Rows[i].Cells[3].Value = dt2.Rows[j][2].ToString();
                    dgv_journal.Rows[i].Cells[4].Value = dt2.Rows[j][3].ToString();
                    dgv_journal.Rows[i].Cells[5].Value = dt1.Rows[0][12].ToString();
                    dgv_journal.Rows[i].Cells[6].Value = dt1.Rows[0][13].ToString();
                    dgv_journal.Rows[i].Cells[7].Value = dt1.Rows[0][14].ToString();
                    dgv_journal.Rows[i].Cells[8].Value = dt2.Rows[j][4].ToString();
                    dgv_journal.Rows[i].Cells[9].Value = Convert.ToDouble(dt2.Rows[j][2].ToString()) * Convert.ToDouble(dt1.Rows[0][14].ToString());
                    dgv_journal.Rows[i].Cells[10].Value = Convert.ToDouble(dt2.Rows[j][3].ToString()) * Convert.ToDouble(dt1.Rows[0][14].ToString());
                    i++;

                }
            }
            else
            {
                dgv_journal.Rows.Clear();
                MessageBox.Show("رقم القيد اللذي تبحث عنه غير موجود..! أدخل رقم صحيح","تنبية!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cleare_Data()
        {
            txt_jno.Text = "0";
            dtp_jdate.Value = DateTime.Now;
            rb_general.Checked = true;
            chk_post.Checked = false;
            txt_note.Text = string.Empty;
            txt_Tdebit.Text = "0.00";
            txt_Tcredit.Text = "0.00";
            txt_Delf.Text = "0.00";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_ptype.Text == "سند صرف" || txt_ptype.Text == "سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية صرف أو قبض","تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chk_post.Checked == true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن تعديلة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToDouble(txt_Delf.Text) != 0.00 && rb_general.Checked == true)
                {
                    MessageBox.Show("القيد المحاسبي غير متوازن", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(Convert.ToDouble(txt_Delf.Text) == 0.00 || (Convert.ToDouble(txt_Delf.Text) != 0.00 && rb_wait.Checked == true))
                {

                    journal_Header_Update();
                    cj.delete_journal_Details(Convert.ToInt32(txt_jo_no.Text));
                    journal_Details_Add();
                    show();
                    MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("يجب التاكد من البيانات التي تريد تعديلها", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }

            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ptype.Text == "سند صرف" || txt_ptype.Text == "سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية صرف أو قبض لا يمكن حذفه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chk_post.Checked == true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن حذفه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("هل تريد حذف القيد المحاسبي","تنبية حذف !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    cj.delete_journal_Details(Convert.ToInt32(txt_jo_no.Text));
                    cj.delete_journal_header(Convert.ToInt32(txt_jo_no.Text));
                    cleare_Data();
                    dgv_journal.Rows.Clear();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يجب التاكد من البيانات التي تريد تعديلها", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void btn_firs_Click(object sender, EventArgs e)
        {
            txt_jo_no.Text = cj.get_Journal_First().Rows[0][0].ToString();

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            txt_jo_no.Text = cj.get_Journal_Last().Rows[0][0].ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int jmax = Convert.ToInt32(cj.get_Journal_Last().Rows[0][0].ToString());

            if (Convert.ToInt32(txt_jo_no.Text) == jmax)
            {
                MessageBox.Show("هذا أخر قيد محاسبي", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_jo_no.Text = (Convert.ToInt32(txt_jo_no.Text) + 1).ToString();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int jmin = Convert.ToInt32(cj.get_Journal_First().Rows[0][0].ToString());

            if (Convert.ToInt32(txt_jo_no.Text) == jmin)
            {
                MessageBox.Show("هذا أول قيد محاسبي", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_jo_no.Text = (Convert.ToInt32(txt_jo_no.Text) - 1).ToString();
            }
        }

    }
}
