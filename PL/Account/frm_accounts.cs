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
    public partial class frm_accounts : Form
    {

        cls_account ca = new cls_account();

        public frm_accounts()
        {
            InitializeComponent();
            full_cb();
            
        } // end of frm_accounts

        private void frm_accounts_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end btn of exit


        private void create_Node()
        {
            TreeNode tn;
            tv_account.Nodes.Clear();
            DataView dv = new DataView(ca.Get_All_Account());
            dv.RowFilter = "acc_Parent_No=0";
            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode(drv["acc_No"].ToString()+ " " + drv["acc_Aname"].ToString());
                tn.Tag = drv["acc_No"].ToString();
                tv_account.Nodes.Add(tn);

            }

            foreach (TreeNode tnode in tv_account.Nodes)
            {
                node_Child(tnode);
            }

        } // end of create Node

        private void node_Child(TreeNode nd)
        {
            TreeNode ctn ;
            DataView dv = new DataView(ca.Get_All_Account());
            dv.RowFilter = "acc_Parent_No="+Convert.ToInt32(nd.Tag);
            foreach (DataRowView drv in dv)
            {
                ctn = new TreeNode(drv["acc_No"].ToString() + " " + drv["acc_Aname"].ToString());
                ctn.Tag = drv["acc_No"].ToString();
                nd.Nodes.Add(ctn);
                node_Child(ctn);
            }

        } // end of Node Child



        void full_cb()
        {
            create_Node();
            cb_report.DataSource = ca.Get_All_FinalAcc();
            cb_report.ValueMember = "acc_Rep_No";
            cb_report.DisplayMember = "acc_Rep_Aname";

            cb_acctype.DataSource = ca.Get_All_TypeAcc();
            cb_acctype.ValueMember = "acc_Type_No";
            cb_acctype.DisplayMember = "acc_Type_Aname";
        } // end of void

        private void tv_account_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_tag.Text = tv_account.SelectedNode.Tag.ToString();
            
        } // end of function

        private void txt_tag_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ca.Get_Alone_Account(Convert.ToInt32(txt_tag.Text));
            if (dt.Rows.Count>0)
            {
                txt_accno.Text = dt.Rows[0][0].ToString();
                txt_accparent.Text = dt.Rows[0][1].ToString();
                txt_accname.Text = dt.Rows[0][2].ToString();
                txt_acclevel.Text = dt.Rows[0][5].ToString();
                txt_accdebit.Text = dt.Rows[0][6].ToString();
                txt_acccredit.Text = dt.Rows[0][7].ToString();
                txt_accbalance.Text = dt.Rows[0][8].ToString();
                cb_report.SelectedValue = dt.Rows[0][4].ToString();
                cb_acctype.SelectedValue = dt.Rows[0][3].ToString();
            }



        } // end of function 


        void clearnce()
        {
            foreach (var c in gp_inputs.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                   // ((TextBox)c).Enabled = true;
                }
            } // end of foreach
        } // end of function


        private void btn_new_Click(object sender, EventArgs e)
        {

            clearnce();

            txt_accno.Focus();
            btn_save.Enabled = true;
            cb_acctype.Enabled = true;
            cb_report.Enabled = true;


        } // end of function

        private void txt_accno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        } // end of function

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                ca.Account_Add(Convert.ToInt32(txt_accno.Text),Convert.ToInt32(txt_accparent.Text),txt_accname.Text.ToString(),Convert.ToInt32(txt_acclevel.Text),
                    Convert.ToDouble(txt_accdebit.Text),Convert.ToDouble(txt_acccredit.Text),Convert.ToDouble(txt_accbalance.Text),
                    Convert.ToInt32(cb_report.SelectedValue),Convert.ToInt32(cb_acctype.SelectedValue));
                create_Node();
                MessageBox.Show("تمت عملية الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_save.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("هناك خطأ..يجب تصحيح الخطأ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        } // end of function

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ca.Account_Test(Convert.ToInt32(txt_accno.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب مرتبط بحسابات فرعية ولا يمكن تعديلة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt1 = new DataTable();
            dt1 = ca.Journal_Test(Convert.ToInt32(txt_accno.Text));
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب قد أجريت علية عملية محسابية ولا يمكن تعديلة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                ca.Account_Update(Convert.ToInt32(txt_accno.Text), Convert.ToInt32(txt_accparent.Text), txt_accname.Text.ToString(), Convert.ToInt32(txt_acclevel.Text),
                    Convert.ToDouble(txt_accdebit.Text), Convert.ToDouble(txt_acccredit.Text), Convert.ToDouble(txt_accbalance.Text),
                    Convert.ToInt32(cb_report.SelectedValue), Convert.ToInt32(cb_acctype.SelectedValue));
                create_Node();
                MessageBox.Show("تمت عملية الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_save.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("هناك خطأ..يجب تصحيح الخطأ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        } // end of function

        private void btn_delete_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = ca.Account_Test(Convert.ToInt32(txt_accno.Text));
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("هذا الحساب مرتبط بحسابات فرعية ولا يمكن حذفه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt1 = new DataTable();
            dt1 = ca.Journal_Test(Convert.ToInt32(txt_accno.Text));
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب قد أجريت علية عملية محسابية ولا يمكن حذفه", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل تريد حذف هذا الحساب","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                try
                {
                    ca.Account_Delete(Convert.ToInt32(txt_accno.Text));
                    create_Node();
                    clearnce();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    clearnce();
                    MessageBox.Show("هناك خطأ..يجب تصحيح الخطأ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            } 
            
        } // end of function
    }
}
