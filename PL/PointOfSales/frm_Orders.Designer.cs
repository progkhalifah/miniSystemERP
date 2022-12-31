namespace System_Accounting.PL.PointOfSales
{
    partial class frm_Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_order = new System.Windows.Forms.DateTimePicker();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_order_desc = new System.Windows.Forms.TextBox();
            this.txt_order_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.photo_customer = new System.Windows.Forms.PictureBox();
            this.btn_select_customer = new System.Windows.Forms.Button();
            this.txt_customer_phone = new System.Windows.Forms.TextBox();
            this.txt_customer_branch = new System.Windows.Forms.TextBox();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.txt_cusomter_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_product_total_amount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_product_discount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_product_quantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_product_amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_product_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_order_del_row = new System.Windows.Forms.Button();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالسطرالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_search_products = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_order_print = new System.Windows.Forms.Button();
            this.btn_order_save = new System.Windows.Forms.Button();
            this.btn_order_no = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_customer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_order);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_order_desc);
            this.groupBox1.Controls.Add(this.txt_order_no);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // dtp_order
            // 
            this.dtp_order.Location = new System.Drawing.Point(144, 176);
            this.dtp_order.Name = "dtp_order";
            this.dtp_order.Size = new System.Drawing.Size(328, 20);
            this.dtp_order.TabIndex = 15;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(144, 225);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(328, 20);
            this.txt_username.TabIndex = 14;
            // 
            // txt_order_desc
            // 
            this.txt_order_desc.Location = new System.Drawing.Point(144, 89);
            this.txt_order_desc.Multiline = true;
            this.txt_order_desc.Name = "txt_order_desc";
            this.txt_order_desc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_order_desc.Size = new System.Drawing.Size(328, 52);
            this.txt_order_desc.TabIndex = 12;
            // 
            // txt_order_no
            // 
            this.txt_order_no.Location = new System.Drawing.Point(279, 43);
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.ReadOnly = true;
            this.txt_order_no.Size = new System.Drawing.Size(193, 20);
            this.txt_order_no.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم البائع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ البيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.photo_customer);
            this.groupBox2.Controls.Add(this.btn_select_customer);
            this.groupBox2.Controls.Add(this.txt_customer_phone);
            this.groupBox2.Controls.Add(this.txt_customer_branch);
            this.groupBox2.Controls.Add(this.txt_customer_name);
            this.groupBox2.Controls.Add(this.txt_cusomter_no);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(595, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // photo_customer
            // 
            this.photo_customer.Location = new System.Drawing.Point(6, 39);
            this.photo_customer.Name = "photo_customer";
            this.photo_customer.Size = new System.Drawing.Size(218, 206);
            this.photo_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_customer.TabIndex = 19;
            this.photo_customer.TabStop = false;
            // 
            // btn_select_customer
            // 
            this.btn_select_customer.Location = new System.Drawing.Point(230, 39);
            this.btn_select_customer.Name = "btn_select_customer";
            this.btn_select_customer.Size = new System.Drawing.Size(85, 27);
            this.btn_select_customer.TabIndex = 15;
            this.btn_select_customer.Text = "ooo";
            this.btn_select_customer.UseVisualStyleBackColor = true;
            this.btn_select_customer.Click += new System.EventHandler(this.btn_select_customer_Click);
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.Location = new System.Drawing.Point(241, 225);
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.ReadOnly = true;
            this.txt_customer_phone.Size = new System.Drawing.Size(273, 20);
            this.txt_customer_phone.TabIndex = 18;
            // 
            // txt_customer_branch
            // 
            this.txt_customer_branch.Location = new System.Drawing.Point(241, 159);
            this.txt_customer_branch.Name = "txt_customer_branch";
            this.txt_customer_branch.ReadOnly = true;
            this.txt_customer_branch.Size = new System.Drawing.Size(273, 20);
            this.txt_customer_branch.TabIndex = 17;
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Location = new System.Drawing.Point(241, 105);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.ReadOnly = true;
            this.txt_customer_name.Size = new System.Drawing.Size(273, 20);
            this.txt_customer_name.TabIndex = 16;
            // 
            // txt_cusomter_no
            // 
            this.txt_cusomter_no.Location = new System.Drawing.Point(321, 43);
            this.txt_cusomter_no.Name = "txt_cusomter_no";
            this.txt_cusomter_no.ReadOnly = true;
            this.txt_cusomter_no.Size = new System.Drawing.Size(193, 20);
            this.txt_cusomter_no.TabIndex = 15;
            this.txt_cusomter_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cusomter_no_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "رقم العميل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "الاسم الشخصي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "الفرع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "رقم الهاتف";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_product_total_amount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_product_discount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_product_price);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_product_quantity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_product_amount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_product_name);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_product_no);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_order_del_row);
            this.groupBox3.Controls.Add(this.dgv_products);
            this.groupBox3.Controls.Add(this.btn_search_products);
            this.groupBox3.Location = new System.Drawing.Point(12, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1193, 367);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(1112, 23);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(5);
            this.label14.Size = new System.Drawing.Size(75, 27);
            this.label14.TabIndex = 25;
            this.label14.Text = "رقم المنتج";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_total_amount
            // 
            this.txt_product_total_amount.Location = new System.Drawing.Point(6, 49);
            this.txt_product_total_amount.Name = "txt_product_total_amount";
            this.txt_product_total_amount.ReadOnly = true;
            this.txt_product_total_amount.Size = new System.Drawing.Size(262, 20);
            this.txt_product_total_amount.TabIndex = 24;
            this.txt_product_total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(6, 23);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5);
            this.label15.Size = new System.Drawing.Size(262, 27);
            this.label15.TabIndex = 23;
            this.label15.Text = "المبلغ الأجمالي";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_discount
            // 
            this.txt_product_discount.Location = new System.Drawing.Point(264, 49);
            this.txt_product_discount.MaxLength = 3;
            this.txt_product_discount.Name = "txt_product_discount";
            this.txt_product_discount.Size = new System.Drawing.Size(167, 20);
            this.txt_product_discount.TabIndex = 22;
            this.txt_product_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_product_discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_discount_KeyDown);
            this.txt_product_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_discount_KeyPress);
            this.txt_product_discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_product_discount_KeyUp);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(264, 23);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(167, 27);
            this.label16.TabIndex = 21;
            this.label16.Text = "الخصم (%)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_price
            // 
            this.txt_product_price.Location = new System.Drawing.Point(429, 49);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.ReadOnly = true;
            this.txt_product_price.Size = new System.Drawing.Size(150, 20);
            this.txt_product_price.TabIndex = 20;
            this.txt_product_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(429, 23);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5);
            this.label17.Size = new System.Drawing.Size(150, 27);
            this.label17.TabIndex = 19;
            this.label17.Text = "المبلغ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_quantity
            // 
            this.txt_product_quantity.Location = new System.Drawing.Point(578, 49);
            this.txt_product_quantity.MaxLength = 8;
            this.txt_product_quantity.Name = "txt_product_quantity";
            this.txt_product_quantity.Size = new System.Drawing.Size(129, 20);
            this.txt_product_quantity.TabIndex = 18;
            this.txt_product_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_product_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_quantity_KeyDown);
            this.txt_product_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_quantity_KeyPress);
            this.txt_product_quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_product_quantity_KeyUp);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(578, 23);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(129, 27);
            this.label12.TabIndex = 17;
            this.label12.Text = "الكمية";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_amount
            // 
            this.txt_product_amount.Location = new System.Drawing.Point(705, 49);
            this.txt_product_amount.MaxLength = 8;
            this.txt_product_amount.Name = "txt_product_amount";
            this.txt_product_amount.Size = new System.Drawing.Size(122, 20);
            this.txt_product_amount.TabIndex = 16;
            this.txt_product_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_product_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_amount_KeyDown);
            this.txt_product_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_amount_KeyPress);
            this.txt_product_amount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_product_amount_KeyUp);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(705, 23);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(122, 27);
            this.label13.TabIndex = 15;
            this.label13.Text = "السعر";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(826, 49);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.ReadOnly = true;
            this.txt_product_name.Size = new System.Drawing.Size(189, 20);
            this.txt_product_name.TabIndex = 14;
            this.txt_product_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_name_KeyDown);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(826, 23);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(189, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "اسم المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_no
            // 
            this.txt_product_no.Location = new System.Drawing.Point(1014, 49);
            this.txt_product_no.Name = "txt_product_no";
            this.txt_product_no.ReadOnly = true;
            this.txt_product_no.Size = new System.Drawing.Size(100, 20);
            this.txt_product_no.TabIndex = 12;
            this.txt_product_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(1014, 23);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(100, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "رقم المنتج";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(42, 312);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(193, 20);
            this.txt_total.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "المجموع";
            // 
            // btn_order_del_row
            // 
            this.btn_order_del_row.Enabled = false;
            this.btn_order_del_row.Location = new System.Drawing.Point(1048, 315);
            this.btn_order_del_row.Name = "btn_order_del_row";
            this.btn_order_del_row.Size = new System.Drawing.Size(127, 33);
            this.btn_order_del_row.TabIndex = 1;
            this.btn_order_del_row.Text = "حذف السطر المحدد";
            this.btn_order_del_row.UseVisualStyleBackColor = true;
            // 
            // dgv_products
            // 
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.ColumnHeadersVisible = false;
            this.dgv_products.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_products.Location = new System.Drawing.Point(6, 75);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(1181, 224);
            this.dgv_products.TabIndex = 0;
            this.dgv_products.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_products_RowsRemoved);
            this.dgv_products.DoubleClick += new System.EventHandler(this.dgv_products_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفالسطرالحاليToolStripMenuItem,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 76);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // حذفالسطرالحاليToolStripMenuItem
            // 
            this.حذفالسطرالحاليToolStripMenuItem.Name = "حذفالسطرالحاليToolStripMenuItem";
            this.حذفالسطرالحاليToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حذفالسطرالحاليToolStripMenuItem.Text = "حذف السطر الحالي";
            this.حذفالسطرالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالحاليToolStripMenuItem_Click);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // btn_search_products
            // 
            this.btn_search_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_products.Location = new System.Drawing.Point(1112, 49);
            this.btn_search_products.Name = "btn_search_products";
            this.btn_search_products.Size = new System.Drawing.Size(75, 20);
            this.btn_search_products.TabIndex = 26;
            this.btn_search_products.Text = "ooo";
            this.btn_search_products.UseVisualStyleBackColor = true;
            this.btn_search_products.Click += new System.EventHandler(this.btn_search_products_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 748);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_order_print
            // 
            this.btn_order_print.Enabled = false;
            this.btn_order_print.Location = new System.Drawing.Point(584, 748);
            this.btn_order_print.Name = "btn_order_print";
            this.btn_order_print.Size = new System.Drawing.Size(127, 33);
            this.btn_order_print.TabIndex = 12;
            this.btn_order_print.Text = "طباعة الفاتورة";
            this.btn_order_print.UseVisualStyleBackColor = true;
            // 
            // btn_order_save
            // 
            this.btn_order_save.Enabled = false;
            this.btn_order_save.Location = new System.Drawing.Point(451, 748);
            this.btn_order_save.Name = "btn_order_save";
            this.btn_order_save.Size = new System.Drawing.Size(127, 33);
            this.btn_order_save.TabIndex = 13;
            this.btn_order_save.Text = "حفظ الفاتورة";
            this.btn_order_save.UseVisualStyleBackColor = true;
            this.btn_order_save.Click += new System.EventHandler(this.btn_order_save_Click);
            // 
            // btn_order_no
            // 
            this.btn_order_no.Location = new System.Drawing.Point(318, 748);
            this.btn_order_no.Name = "btn_order_no";
            this.btn_order_no.Size = new System.Drawing.Size(127, 33);
            this.btn_order_no.TabIndex = 14;
            this.btn_order_no.Text = "فاتورة بيع جديدة";
            this.btn_order_no.UseVisualStyleBackColor = true;
            this.btn_order_no.Click += new System.EventHandler(this.btn_order_no_Click);
            // 
            // frm_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 820);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_order_print);
            this.Controls.Add(this.btn_order_save);
            this.Controls.Add(this.btn_order_no);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Orders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المبيعات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_customer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_order_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_order_del_row;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_order_print;
        private System.Windows.Forms.Button btn_order_save;
        private System.Windows.Forms.Button btn_order_no;
        private System.Windows.Forms.DateTimePicker dtp_order;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_order_desc;
        private System.Windows.Forms.Button btn_select_customer;
        private System.Windows.Forms.PictureBox photo_customer;
        public System.Windows.Forms.TextBox txt_customer_phone;
        public System.Windows.Forms.TextBox txt_customer_branch;
        public System.Windows.Forms.TextBox txt_customer_name;
        public System.Windows.Forms.TextBox txt_cusomter_no;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_product_total_amount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_product_discount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_product_quantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_product_amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_product_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_search_products;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالحاليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
    }
}