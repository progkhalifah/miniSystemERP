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

namespace System_Accounting.PL.Inventory
{
    public partial class frm_Categories : Form
    {

        SqlConnection sqlconn = new SqlConnection("Data Source =192.168.100.86; Initial Catalog = fnoonasia; User ID = sa; Password =Aa123");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmb;


        public frm_Categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_cat as 'رقم الصنف', description_cat as 'اسم الصنف' from tbl_Categories", sqlconn);
            da.Fill(dt);
            dgv_category.DataSource = dt;
            txt_no_categ.DataBindings.Add("text", dt, "رقم الصنف");
            txt_name_categ.DataBindings.Add("text", dt, "اسم الصنف");
            bmb = this.BindingContext[dt];
            txt_position.Text = (bmb.Position+1) + " / " + bmb.Count;


        }

        public void setPosition()
        {
            txt_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_firs_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            setPosition();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            setPosition();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            setPosition();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            setPosition();
        }

        private void btn_newno_Click(object sender, EventArgs e)
        {

            bmb.AddNew();
            btn_newno.Enabled = false;
            btn_save_categ.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count- 1][0])+1;
            txt_no_categ.Text = id.ToString();
            txt_name_categ.Focus();

        }

        private void btn_save_categ_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmb = new SqlCommandBuilder(da);
            da.Update(dt);
            btn_newno.Enabled = true;
            btn_save_categ.Enabled = false;
            setPosition();
            MessageBox.Show("تمت اضافة الصنف بنجاح ","عملية أضافة !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_categ_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmb = new SqlCommandBuilder(da);
            da.Update(dt);
            btn_newno.Enabled = true;
            btn_save_categ.Enabled = false;
            setPosition();
            MessageBox.Show("تمت حذف الصنف بنجاح ", "عملية حذف !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_update_categ_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmb = new SqlCommandBuilder(da);
            da.Update(dt);
            btn_newno.Enabled = true;
            btn_save_categ.Enabled = false;
            setPosition();
            MessageBox.Show("تمت تعديل الصنف بنجاح ", "عملية تعديل !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
