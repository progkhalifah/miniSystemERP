namespace System_Accounting.PL.Bonds
{
    partial class frm_Bounds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Bounds));
            this.تعديلالملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_enter = new System.Windows.Forms.Button();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_exch = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.gp_ctrl = new System.Windows.Forms.GroupBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_Tamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.حذفصفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.gp_jh = new System.Windows.Forms.GroupBox();
            this.txt_jno = new System.Windows.Forms.TextBox();
            this.txt_btype = new System.Windows.Forms.TextBox();
            this.txt_cash_accno = new System.Windows.Forms.TextBox();
            this.cb_cash = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.chk_post = new System.Windows.Forms.CheckBox();
            this.txt_bound_no = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.dtp_bdate = new System.Windows.Forms.DateTimePicker();
            this.txt_bno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gb_inputs = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gp_bonds = new System.Windows.Forms.GroupBox();
            this.dgv_journal = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp_ctrl.SuspendLayout();
            this.gp_jh.SuspendLayout();
            this.cMenuStrip.SuspendLayout();
            this.gb_inputs.SuspendLayout();
            this.gp_bonds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_journal)).BeginInit();
            this.SuspendLayout();
            // 
            // تعديلالملفToolStripMenuItem
            // 
            this.تعديلالملفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلالملفToolStripMenuItem.Image")));
            this.تعديلالملفToolStripMenuItem.Name = "تعديلالملفToolStripMenuItem";
            this.تعديلالملفToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.تعديلالملفToolStripMenuItem.Text = "تعديل صف";
            this.تعديلالملفToolStripMenuItem.Click += new System.EventHandler(this.تعديلالملفToolStripMenuItem_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.Image")));
            this.btn_enter.Location = new System.Drawing.Point(6, 48);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(44, 33);
            this.btn_enter.TabIndex = 21;
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // cb_currency
            // 
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Location = new System.Drawing.Point(293, 55);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(134, 21);
            this.cb_currency.TabIndex = 20;
            this.cb_currency.SelectedIndexChanged += new System.EventHandler(this.cb_currency_SelectedIndexChanged);
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(56, 56);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(163, 20);
            this.txt_exp.TabIndex = 19;
            // 
            // txt_accname
            // 
            this.txt_accname.Location = new System.Drawing.Point(634, 56);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.ReadOnly = true;
            this.txt_accname.Size = new System.Drawing.Size(275, 20);
            this.txt_accname.TabIndex = 18;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(437, 56);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(191, 20);
            this.txt_amount.TabIndex = 17;
            this.txt_amount.Text = "0.00";
            // 
            // txt_exch
            // 
            this.txt_exch.Location = new System.Drawing.Point(225, 56);
            this.txt_exch.Name = "txt_exch";
            this.txt_exch.ReadOnly = true;
            this.txt_exch.Size = new System.Drawing.Size(62, 20);
            this.txt_exch.TabIndex = 16;
            this.txt_exch.Text = "0.00";
            // 
            // txt_accno
            // 
            this.txt_accno.Location = new System.Drawing.Point(915, 56);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(167, 20);
            this.txt_accno.TabIndex = 9;
            this.txt_accno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accno_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "البيان";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "المبلغ";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(38, 13);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 55);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(135, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 55);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(231, 13);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 55);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // gp_ctrl
            // 
            this.gp_ctrl.Controls.Add(this.txt_user);
            this.gp_ctrl.Controls.Add(this.label13);
            this.gp_ctrl.Controls.Add(this.btn_exit);
            this.gp_ctrl.Controls.Add(this.btn_delete);
            this.gp_ctrl.Controls.Add(this.btn_edit);
            this.gp_ctrl.Controls.Add(this.btn_save);
            this.gp_ctrl.Controls.Add(this.btn_new);
            this.gp_ctrl.Controls.Add(this.txt_Tamount);
            this.gp_ctrl.Controls.Add(this.label12);
            this.gp_ctrl.Location = new System.Drawing.Point(12, 633);
            this.gp_ctrl.Name = "gp_ctrl";
            this.gp_ctrl.Size = new System.Drawing.Size(1088, 80);
            this.gp_ctrl.TabIndex = 7;
            this.gp_ctrl.TabStop = false;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(887, 46);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(105, 20);
            this.txt_user.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(998, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "المستخدم";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(324, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 55);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(418, 13);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 55);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_Tamount
            // 
            this.txt_Tamount.Location = new System.Drawing.Point(887, 14);
            this.txt_Tamount.Name = "txt_Tamount";
            this.txt_Tamount.ReadOnly = true;
            this.txt_Tamount.Size = new System.Drawing.Size(105, 20);
            this.txt_Tamount.TabIndex = 3;
            this.txt_Tamount.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(998, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "إجمالي السند";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(768, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "اسم الحساب";
            // 
            // حذفصفToolStripMenuItem
            // 
            this.حذفصفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفصفToolStripMenuItem.Image")));
            this.حذفصفToolStripMenuItem.Name = "حذفصفToolStripMenuItem";
            this.حذفصفToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.حذفصفToolStripMenuItem.Text = "حذف صف";
            this.حذفصفToolStripMenuItem.Click += new System.EventHandler(this.حذفصفToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "العملة";
            // 
            // gp_jh
            // 
            this.gp_jh.Controls.Add(this.txt_jno);
            this.gp_jh.Controls.Add(this.txt_btype);
            this.gp_jh.Controls.Add(this.txt_cash_accno);
            this.gp_jh.Controls.Add(this.cb_cash);
            this.gp_jh.Controls.Add(this.label8);
            this.gp_jh.Controls.Add(this.btn_search);
            this.gp_jh.Controls.Add(this.txt_search);
            this.gp_jh.Controls.Add(this.chk_post);
            this.gp_jh.Controls.Add(this.txt_bound_no);
            this.gp_jh.Controls.Add(this.btn_prev);
            this.gp_jh.Controls.Add(this.btn_first);
            this.gp_jh.Controls.Add(this.btn_next);
            this.gp_jh.Controls.Add(this.btn_last);
            this.gp_jh.Controls.Add(this.txt_note);
            this.gp_jh.Controls.Add(this.dtp_bdate);
            this.gp_jh.Controls.Add(this.txt_bno);
            this.gp_jh.Controls.Add(this.label3);
            this.gp_jh.Controls.Add(this.label2);
            this.gp_jh.Controls.Add(this.label1);
            this.gp_jh.Location = new System.Drawing.Point(8, 39);
            this.gp_jh.Name = "gp_jh";
            this.gp_jh.Size = new System.Drawing.Size(1088, 108);
            this.gp_jh.TabIndex = 4;
            this.gp_jh.TabStop = false;
            // 
            // txt_jno
            // 
            this.txt_jno.Location = new System.Drawing.Point(384, 13);
            this.txt_jno.Name = "txt_jno";
            this.txt_jno.Size = new System.Drawing.Size(83, 20);
            this.txt_jno.TabIndex = 23;
            this.txt_jno.Text = "0";
            // 
            // txt_btype
            // 
            this.txt_btype.Location = new System.Drawing.Point(473, 13);
            this.txt_btype.Name = "txt_btype";
            this.txt_btype.Size = new System.Drawing.Size(83, 20);
            this.txt_btype.TabIndex = 22;
            // 
            // txt_cash_accno
            // 
            this.txt_cash_accno.Location = new System.Drawing.Point(411, 53);
            this.txt_cash_accno.Name = "txt_cash_accno";
            this.txt_cash_accno.ReadOnly = true;
            this.txt_cash_accno.Size = new System.Drawing.Size(87, 20);
            this.txt_cash_accno.TabIndex = 22;
            this.txt_cash_accno.Text = "0.00";
            // 
            // cb_cash
            // 
            this.cb_cash.FormattingEnabled = true;
            this.cb_cash.Location = new System.Drawing.Point(504, 52);
            this.cb_cash.Name = "cb_cash";
            this.cb_cash.Size = new System.Drawing.Size(179, 21);
            this.cb_cash.TabIndex = 22;
            this.cb_cash.SelectedIndexChanged += new System.EventHandler(this.cb_cash_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "الصندوق";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(24, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(106, 53);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(232, 20);
            this.txt_search.TabIndex = 15;
            // 
            // chk_post
            // 
            this.chk_post.AutoSize = true;
            this.chk_post.Location = new System.Drawing.Point(355, 53);
            this.chk_post.Name = "chk_post";
            this.chk_post.Size = new System.Drawing.Size(50, 17);
            this.chk_post.TabIndex = 14;
            this.chk_post.Text = "مرحل";
            this.chk_post.UseVisualStyleBackColor = true;
            // 
            // txt_bound_no
            // 
            this.txt_bound_no.Location = new System.Drawing.Point(106, 20);
            this.txt_bound_no.Name = "txt_bound_no";
            this.txt_bound_no.ReadOnly = true;
            this.txt_bound_no.Size = new System.Drawing.Size(137, 20);
            this.txt_bound_no.TabIndex = 13;
            this.txt_bound_no.Text = "0";
            this.txt_bound_no.TextChanged += new System.EventHandler(this.txt_bound_no_TextChanged);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.Location = new System.Drawing.Point(65, 17);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(35, 23);
            this.btn_prev.TabIndex = 12;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.Image")));
            this.btn_first.Location = new System.Drawing.Point(19, 17);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(40, 23);
            this.btn_first.TabIndex = 11;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(249, 17);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(40, 23);
            this.btn_next.TabIndex = 10;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.Location = new System.Drawing.Point(296, 17);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(43, 23);
            this.btn_last.TabIndex = 9;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(737, 53);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(251, 20);
            this.txt_note.TabIndex = 5;
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Location = new System.Drawing.Point(562, 13);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_bdate.TabIndex = 4;
            // 
            // txt_bno
            // 
            this.txt_bno.Location = new System.Drawing.Point(849, 14);
            this.txt_bno.Name = "txt_bno";
            this.txt_bno.ReadOnly = true;
            this.txt_bno.Size = new System.Drawing.Size(143, 20);
            this.txt_bno.TabIndex = 3;
            this.txt_bno.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1010, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "البيان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ السند";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(994, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند";
            // 
            // cMenuStrip
            // 
            this.cMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفصفToolStripMenuItem,
            this.تعديلالملفToolStripMenuItem});
            this.cMenuStrip.Name = "cMenuStrip";
            this.cMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cMenuStrip.Size = new System.Drawing.Size(131, 48);
            // 
            // gb_inputs
            // 
            this.gb_inputs.Controls.Add(this.btn_enter);
            this.gb_inputs.Controls.Add(this.cb_currency);
            this.gb_inputs.Controls.Add(this.txt_exp);
            this.gb_inputs.Controls.Add(this.txt_accname);
            this.gb_inputs.Controls.Add(this.txt_amount);
            this.gb_inputs.Controls.Add(this.txt_exch);
            this.gb_inputs.Controls.Add(this.txt_accno);
            this.gb_inputs.Controls.Add(this.label11);
            this.gb_inputs.Controls.Add(this.label10);
            this.gb_inputs.Controls.Add(this.label9);
            this.gb_inputs.Controls.Add(this.label7);
            this.gb_inputs.Controls.Add(this.label6);
            this.gb_inputs.Controls.Add(this.label5);
            this.gb_inputs.Location = new System.Drawing.Point(8, 153);
            this.gb_inputs.Name = "gb_inputs";
            this.gb_inputs.Size = new System.Drawing.Size(1088, 108);
            this.gb_inputs.TabIndex = 5;
            this.gb_inputs.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "الصرف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(972, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "رقم الحساب";
            // 
            // gp_bonds
            // 
            this.gp_bonds.Controls.Add(this.dgv_journal);
            this.gp_bonds.Location = new System.Drawing.Point(8, 267);
            this.gp_bonds.Name = "gp_bonds";
            this.gp_bonds.Size = new System.Drawing.Size(1088, 360);
            this.gp_bonds.TabIndex = 6;
            this.gp_bonds.TabStop = false;
            // 
            // dgv_journal
            // 
            this.dgv_journal.AllowUserToAddRows = false;
            this.dgv_journal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_journal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4});
            this.dgv_journal.ContextMenuStrip = this.cMenuStrip;
            this.dgv_journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_journal.Location = new System.Drawing.Point(3, 16);
            this.dgv_journal.Name = "dgv_journal";
            this.dgv_journal.Size = new System.Drawing.Size(1082, 341);
            this.dgv_journal.TabIndex = 0;
            this.dgv_journal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_journal_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "رقم السند";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم الحساب";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الحساب";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "المبلغ";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "رقم العملة";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العملة";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الصرف";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "البيان";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "إجمالي المبلغ";
            this.Column4.Name = "Column4";
            // 
            // frm_Bounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 753);
            this.Controls.Add(this.gp_ctrl);
            this.Controls.Add(this.gp_jh);
            this.Controls.Add(this.gb_inputs);
            this.Controls.Add(this.gp_bonds);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Bounds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_Bounds_Load);
            this.gp_ctrl.ResumeLayout(false);
            this.gp_ctrl.PerformLayout();
            this.gp_jh.ResumeLayout(false);
            this.gp_jh.PerformLayout();
            this.cMenuStrip.ResumeLayout(false);
            this.gb_inputs.ResumeLayout(false);
            this.gb_inputs.PerformLayout();
            this.gp_bonds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_journal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem تعديلالملفToolStripMenuItem;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.ComboBox cb_currency;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.TextBox txt_accname;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_exch;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox gp_ctrl;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_Tamount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem حذفصفToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.CheckBox chk_post;
        private System.Windows.Forms.TextBox txt_bound_no;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.DateTimePicker dtp_bdate;
        private System.Windows.Forms.TextBox txt_bno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cMenuStrip;
        private System.Windows.Forms.GroupBox gb_inputs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_journal;
        private System.Windows.Forms.TextBox txt_cash_accno;
        private System.Windows.Forms.ComboBox cb_cash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_jno;
        public System.Windows.Forms.GroupBox gp_bonds;
        public System.Windows.Forms.GroupBox gp_jh;
        public System.Windows.Forms.TextBox txt_btype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}