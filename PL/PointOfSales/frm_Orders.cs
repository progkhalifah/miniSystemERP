using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Accounting.PL.PointOfSales
{
    public partial class frm_Orders : Form
    {

        BL.PointOfSales.cls_order clo = new BL.PointOfSales.cls_order();
        DataTable dt = new DataTable();

        public frm_Orders()
        {
            InitializeComponent();

            createDataTable();
            resizeDataGrideView();
            txt_username.Text = Program.username;


        }

        private void btn_order_no_Click(object sender, EventArgs e)
        {
            //int generate_no = Convert.ToInt32();
            txt_order_no.Text = clo.Get_Last_ID().Rows[0][0].ToString();
            txt_order_desc.Focus();
            btn_order_save.Enabled = true;
            btn_order_del_row.Enabled = true;
            btn_order_no.Enabled =false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_customer_Click(object sender, EventArgs e)
        {

            frm_search_customer search_customer = new frm_search_customer();
            search_customer.ShowDialog();
            if (search_customer.dgv_all_customers.CurrentRow.Cells[10].Value is DBNull)
            {
                MessageBox.Show("هذا العميل لا يوجد لديه صورة","عذراً",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cusomter_no.Text = search_customer.dgv_all_customers.CurrentRow.Cells[0].Value.ToString();
                txt_customer_name.Text = search_customer.dgv_all_customers.CurrentRow.Cells[1].Value.ToString();
                txt_customer_phone.Text = search_customer.dgv_all_customers.CurrentRow.Cells[4].Value.ToString();
                txt_customer_branch.Text = search_customer.dgv_all_customers.CurrentRow.Cells[7].Value.ToString();
                photo_customer.Image = null;
                return;
            }
            txt_cusomter_no.Text = search_customer.dgv_all_customers.CurrentRow.Cells[0].Value.ToString();
            txt_customer_name.Text = search_customer.dgv_all_customers.CurrentRow.Cells[1].Value.ToString();
            txt_customer_phone.Text = search_customer.dgv_all_customers.CurrentRow.Cells[4].Value.ToString();
            txt_customer_branch.Text = search_customer.dgv_all_customers.CurrentRow.Cells[7].Value.ToString();
            byte[] customer_photo = (byte[]) search_customer.dgv_all_customers.CurrentRow.Cells[10].Value;
            MemoryStream ms = new MemoryStream(customer_photo);
            photo_customer.Image = Image.FromStream(ms);

        } // end of btn

        void createDataTable()
        {
            dt.Columns.Add("رقم المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("سعر المنتج");
            dt.Columns.Add("كمية المنتج");
            dt.Columns.Add("مبلغ المنتج");
            dt.Columns.Add("نسبة الخصم (%)");
            dt.Columns.Add("المبلغ الأجمالي");

            dgv_products.DataSource = dt;

            // Add Button into Data Grid View
             
            /*DataGridViewButtonColumn btn_dgv = new DataGridViewButtonColumn();
            btn_dgv.HeaderText = "اختيار المنتج";
            btn_dgv.Text = "البحث";


            btn_dgv.UseColumnTextForButtonValue = true;
            dgv_products.Columns.Insert(0,btn_dgv);*/


        } // end of create data table


        void resizeDataGrideView()
        {



            this.dgv_products.RowHeadersWidth = 73;
   /*         DataGridViewColumn column0 = this.dgv_products.Columns[0];
            column0.Width = 100;
            DataGridViewColumn column1 = dgv_products.Columns[1];
            column1.Width = 189;
            DataGridViewColumn column2 = dgv_products.Columns[2];
            column2.Width = 122;
            DataGridViewColumn column3 = dgv_products.Columns[3];
            column3.Width = 129;
            DataGridViewColumn column4 = dgv_products.Columns[4];
            column4.Width = 150;
            DataGridViewColumn column5 = dgv_products.Columns[5];
            column5.Width = 167;
            DataGridViewColumn column6 = dgv_products.Columns[6];
            column6.Width = 262;*/
/*
            this.dgv_products.Columns[0].Width = 100;
            this.dgv_products.Columns[1].Width = 189;
            this.dgv_products.Columns[2].Width = 122;
            this.dgv_products.Columns[3].Width = 129;
            this.dgv_products.Columns[4].Width = 150;
            this.dgv_products.Columns[5].Width = 167;
            this.dgv_products.Columns[6].Width = 262;*/

        }

        private void btn_search_products_Click(object sender, EventArgs e)
        {
            clearBoxes();
            frm_Product_List frmproductlist = new frm_Product_List();
            frmproductlist.ShowDialog();
            txt_product_no.Text = frmproductlist.dgv_product_list.CurrentRow.Cells[0].Value.ToString();
            txt_product_name.Text = frmproductlist.dgv_product_list.CurrentRow.Cells[1].Value.ToString();
            txt_product_amount.Text = frmproductlist.dgv_product_list.CurrentRow.Cells[3].Value.ToString();
            txt_product_quantity.Focus();

        }


        



        // This code for EditText Product Quantity

        private void txt_product_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void txt_product_quantity_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotalAmount();
        }


        private void txt_product_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_product_quantity.Text != string.Empty)
            {
                txt_product_discount.Focus();
            }
        }

        // This code end of EditText Prodct Quantity
        
        
        
        // This code for EditText Product Discount

        private void txt_product_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }
        }
        private void txt_product_discount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalAmount();
        }

        private void txt_product_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (clo.Verify_Quantity(txt_product_no.Text, Convert.ToInt32(txt_product_quantity.Text)).Rows.Count < 1 )
                {
                    MessageBox.Show("كمية هذا المنتج غير متوفرة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                for (int i = 0; i < dgv_products.Rows.Count - 1; i++)
                {
                    if (dgv_products.Rows[i].Cells[0].Value.ToString() == txt_product_no.Text)
                    {
                        MessageBox.Show("هذا المنتج موجود بالفعل في قائمة الطلبات","المنتج", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    

                }

                

                DataRow dr = dt.NewRow();

                dr[0] = txt_product_no.Text ;
                dr[1] = txt_product_name.Text;
                dr[2] = txt_product_amount.Text;
                dr[3] = txt_product_quantity.Text;
                dr[4] = txt_product_price.Text;
                dr[5] = txt_product_discount.Text;
                dr[6] = txt_product_total_amount.Text;

                dt.Rows.Add(dr);

                dgv_products.DataSource = dt;
                clearBoxes();
                btn_search_products.Focus();

                rowsTotal();
            }



        }
        // This end of code EditText Product Discount

        #region
        void clearBoxes()
        {
            txt_product_no.Clear();
            txt_product_name.Clear();
            txt_product_amount.Clear();
            txt_product_quantity.Clear();
            txt_product_price.Clear();
            txt_product_discount.Clear();
            txt_product_total_amount.Clear();
        }

        void clear_all_frmPointOfSales()
        {
            clearBoxes();
            txt_cusomter_no.Clear();
            txt_customer_name.Clear();
            txt_customer_branch.Clear();
            txt_customer_phone.Clear();
            photo_customer.Image = null;

            txt_order_no.Clear();
            txt_order_desc.Clear();
            txt_username.Clear();
            dtp_order.ResetText();

            txt_total.Clear();

            dt.Clear();
            dgv_products.DataSource = null;

            btn_order_save.Enabled = false;
            btn_order_no.Enabled = true;

            
        }

        #endregion





        void calculateAmount()
        {

            if (txt_product_amount.Text != String.Empty && txt_product_quantity.Text != String.Empty)
            {
                txt_product_price.Text = (Convert.ToDouble(txt_product_amount.Text) * Convert.ToInt32(txt_product_quantity.Text)).ToString();

            }


        }// end of void


        void calculateTotalAmount()
        {
            if (txt_product_discount.Text != string.Empty && txt_product_price.Text != string.Empty)
            {
                double discount = Convert.ToDouble(txt_product_discount.Text);
                double amount = Convert.ToDouble(txt_product_price.Text);
                double totalAmount = amount - (amount * (discount / 100));

                txt_product_total_amount.Text = totalAmount.ToString();
            }
            
        }





        // this EditText Product Amount \\
        private void txt_product_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }

        }

        private void txt_product_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_product_amount.Text != string.Empty)
            {
                txt_product_quantity.Focus();
            }


        }// end of code



        private void txt_product_amount_KeyUp(object sender, KeyEventArgs e)
        {

            calculateAmount();
            calculateTotalAmount();

        }

        private void dgv_products_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_product_no.Text = dgv_products.CurrentRow.Cells[0].Value.ToString();
                txt_product_name.Text = dgv_products.CurrentRow.Cells[1].Value.ToString();
                txt_product_amount.Text = dgv_products.CurrentRow.Cells[2].Value.ToString();
                txt_product_quantity.Text = dgv_products.CurrentRow.Cells[3].Value.ToString();
                txt_product_price.Text = dgv_products.CurrentRow.Cells[4].Value.ToString();
                txt_product_discount.Text = dgv_products.CurrentRow.Cells[5].Value.ToString();
                txt_product_total_amount.Text = dgv_products.CurrentRow.Cells[6].Value.ToString();
                dgv_products.Rows.RemoveAt(dgv_products.CurrentRow.Index);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void dgv_products_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rowsTotal();
        }

        void rowsTotal()
        {
            txt_total.Text = (
                    from DataGridViewRow row in dgv_products.Rows
                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[6].FormattedValue)
                    ).Sum().ToString();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_products_DoubleClick(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_products.Rows.RemoveAt(dgv_products.CurrentRow.Index);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dgv_products.Refresh();
            }
            catch (Exception)
            {

                throw;
            }

            /*try
            {
                for (int i = 0; i < dgv_products.Rows.Count - 1; i++)
                {
                    dgv_products.Rows.RemoveAt(dgv_products.Rows[i].Index);
                }
            }
            catch (Exception)
            {

                throw;
            }

*/
            
        }

        private void txt_product_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                clearBoxes();
                frm_Product_List frmproductlist = new frm_Product_List();
                frmproductlist.ShowDialog();
                txt_product_no.Text = frmproductlist.dgv_product_list.CurrentRow.Cells[0].Value.ToString();
                txt_product_name.Text = frmproductlist.dgv_product_list.CurrentRow.Cells[1].Value.ToString();
                txt_product_amount.Text = frmproductlist.dgv_product_list.CurrentRow.Cells[3].Value.ToString();
                txt_product_quantity.Focus();
            }
        }

        private void btn_order_save_Click(object sender, EventArgs e)
        {

            if (txt_order_no.Text == String.Empty   )
            {
                MessageBox.Show("ينبغي أضافة فاتورة أولاً ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_cusomter_no.Text == String.Empty)
            {
                MessageBox.Show("ينبغي أضافة لاعب أولاً ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgv_products.Rows.Count < 1)
            {
                MessageBox.Show("لائحة المنتجات فارغة الرجاء أضافة منتج", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            // this code for order 
            clo.Add_Order(Convert.ToInt32(txt_order_no.Text), Convert.ToDateTime(dtp_order.Value),
                Convert.ToInt32(txt_cusomter_no.Text), txt_order_desc.Text, txt_username.Text);

            // this code for order detials 
            for (int i = 0; i < dgv_products.Rows.Count -1 ; i++)
            {
                clo.Add_Order_Details(dgv_products.Rows[i].Cells[0].Value.ToString(),
                                      Convert.ToInt32(txt_order_no.Text),
                                      Convert.ToInt32(dgv_products.Rows[i].Cells[3].Value),
                                      dgv_products.Rows[i].Cells[2].Value.ToString(),
                                      Convert.ToInt32(dgv_products.Rows[i].Cells[5].Value),
                                      dgv_products.Rows[i].Cells[4].Value.ToString(),
                                      dgv_products.Rows[i].Cells[6].Value.ToString()
                    );
            }
            clear_all_frmPointOfSales();
            MessageBox.Show("تمت عملية الحفظ الفاتورة بنجاح","عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void txt_cusomter_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                frm_search_customer search_customer = new frm_search_customer();
                search_customer.ShowDialog();
                if (search_customer.dgv_all_customers.CurrentRow.Cells[10].Value is DBNull)
                {
                    MessageBox.Show("هذا العميل لا يوجد لديه صورة", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cusomter_no.Text = search_customer.dgv_all_customers.CurrentRow.Cells[0].Value.ToString();
                    txt_customer_name.Text = search_customer.dgv_all_customers.CurrentRow.Cells[1].Value.ToString();
                    txt_customer_phone.Text = search_customer.dgv_all_customers.CurrentRow.Cells[4].Value.ToString();
                    txt_customer_branch.Text = search_customer.dgv_all_customers.CurrentRow.Cells[7].Value.ToString();
                    photo_customer.Image = null;
                    return;
                }
                txt_cusomter_no.Text = search_customer.dgv_all_customers.CurrentRow.Cells[0].Value.ToString();
                txt_customer_name.Text = search_customer.dgv_all_customers.CurrentRow.Cells[1].Value.ToString();
                txt_customer_phone.Text = search_customer.dgv_all_customers.CurrentRow.Cells[4].Value.ToString();
                txt_customer_branch.Text = search_customer.dgv_all_customers.CurrentRow.Cells[7].Value.ToString();
                byte[] customer_photo = (byte[])search_customer.dgv_all_customers.CurrentRow.Cells[10].Value;
                MemoryStream ms = new MemoryStream(customer_photo);
                photo_customer.Image = Image.FromStream(ms);
            }

            
        }












        // this End of EditText Product Amount \\





    }
}
