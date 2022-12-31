using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Accounting.PL.Products
{

    public partial class frm_Add_Products : Form
    {

        public string state = "add";
        BL.Products.cls_Products prd = new BL.Products.cls_Products();
        
        public frm_Add_Products()
        {
            InitializeComponent();
            cm_categories.DataSource = prd.Get_All_Categories();
            cm_categories.DisplayMember = "description_cat";
            cm_categories.ValueMember = "Id_cat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF; *.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img_selected.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                img_selected.Image.Save(ms, img_selected.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                prd.Add_Product(Convert.ToInt32(cm_categories.SelectedValue), txt_ref.Text, txt_desc.Text,
                    Convert.ToInt32(txt_quantity.Text), Convert.ToDouble(txt_price.Text), byteImage);

                MessageBox.Show("لقد تم حفظ المنتج بنجاح", "عملية اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MemoryStream ms = new MemoryStream();
                img_selected.Image.Save(ms, img_selected.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                prd.Update_Product(Convert.ToInt32(cm_categories.SelectedValue), txt_ref.Text, txt_desc.Text,
                    Convert.ToInt32(txt_quantity.Text), Convert.ToDouble(txt_price.Text), byteImage);

                MessageBox.Show("لقد تم تعديل المنتج بنجاح", "عملية تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txt_ref_Validated(object sender, EventArgs e)
        {

            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.Verfiy_Product(txt_ref.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقاً", "تنبية!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ref.Focus();
                    txt_ref.SelectionStart = 0;
                    txt_ref.SelectionLength = txt_ref.TextLength;
                }
            }



        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
