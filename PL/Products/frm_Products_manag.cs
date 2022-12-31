using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Accounting.PL.Products
{
    public partial class frm_Products_manag : Form
    {

        BL.Products.cls_Products prd = new BL.Products.cls_Products();

        public frm_Products_manag()
        {
            InitializeComponent();

            retrive_all_product();

        }

        void retrive_all_product()
        {
            this.dgv_all_prdoucts.DataSource = prd.Get_All_Prodcuts();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.Search_Product(txt_search.Text);
            this.dgv_all_prdoucts.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Add_Products addProduct = new frm_Add_Products();
            addProduct.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلاً حذف المنتج","عملية حذف المنتج",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.Delete_Product(dgv_all_prdoucts.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح"," عملية حذف",MessageBoxButtons.OK, MessageBoxIcon.Information);
                retrive_all_product();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Add_Products add_Products = new frm_Add_Products();
            add_Products.txt_ref.Text = this.dgv_all_prdoucts.CurrentRow.Cells[0].Value.ToString();
            add_Products.txt_desc.Text = this.dgv_all_prdoucts.CurrentRow.Cells[1].Value.ToString();
            add_Products.txt_quantity.Text = this.dgv_all_prdoucts.CurrentRow.Cells[2].Value.ToString();
            add_Products.txt_price.Text= this.dgv_all_prdoucts.CurrentRow.Cells[3].Value.ToString();
            add_Products.cm_categories.Text = this.dgv_all_prdoucts.CurrentRow.Cells[4].Value.ToString();
            add_Products.Text = "تعديل المنتج"+" "+this.dgv_all_prdoucts.CurrentRow.Cells[1].Value.ToString();
            add_Products.btn_save.Text = "تعديل";
            add_Products.state = "update";
            add_Products.txt_ref.ReadOnly = true;
            byte[] image = (byte[])prd.Get_Image_Product(this.dgv_all_prdoucts.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            add_Products.img_selected.Image = Image.FromStream(ms);
            add_Products.ShowDialog();
            retrive_all_product();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Preview frm_Preview = new frm_Preview();

            byte[] image = (byte[])prd.Get_Image_Product(this.dgv_all_prdoucts.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm_Preview.img_preview.Image = Image.FromStream(ms);

            frm_Preview.ShowDialog();
        }
    }
}
