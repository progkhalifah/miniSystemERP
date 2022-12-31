namespace System_Accounting.PL.SysFormat
{
    partial class frm_Currencies
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gb_inputs = new System.Windows.Forms.GroupBox();
            this.rb_forgin = new System.Windows.Forms.RadioButton();
            this.rb_local = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_part = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_exch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ecname = new System.Windows.Forms.TextBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_currencies = new System.Windows.Forms.GroupBox();
            this.dgv_currencies = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.gb_inputs.SuspendLayout();
            this.gp_currencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currencies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Location = new System.Drawing.Point(16, 586);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 129);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(255, 46);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(148, 57);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(14, 46);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(82, 57);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(147, 46);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 57);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(430, 46);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 57);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(572, 46);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(82, 57);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // gb_inputs
            // 
            this.gb_inputs.Controls.Add(this.rb_forgin);
            this.gb_inputs.Controls.Add(this.rb_local);
            this.gb_inputs.Controls.Add(this.label6);
            this.gb_inputs.Controls.Add(this.txt_part);
            this.gb_inputs.Controls.Add(this.label5);
            this.gb_inputs.Controls.Add(this.txt_exch);
            this.gb_inputs.Controls.Add(this.label4);
            this.gb_inputs.Controls.Add(this.txt_symbol);
            this.gb_inputs.Controls.Add(this.label3);
            this.gb_inputs.Controls.Add(this.txt_ecname);
            this.gb_inputs.Controls.Add(this.txt_accname);
            this.gb_inputs.Controls.Add(this.label2);
            this.gb_inputs.Controls.Add(this.label1);
            this.gb_inputs.Location = new System.Drawing.Point(16, 285);
            this.gb_inputs.Name = "gb_inputs";
            this.gb_inputs.Size = new System.Drawing.Size(700, 295);
            this.gb_inputs.TabIndex = 4;
            this.gb_inputs.TabStop = false;
            this.gb_inputs.Text = "المدخلات";
            // 
            // rb_forgin
            // 
            this.rb_forgin.AutoSize = true;
            this.rb_forgin.Enabled = false;
            this.rb_forgin.Location = new System.Drawing.Point(202, 251);
            this.rb_forgin.Name = "rb_forgin";
            this.rb_forgin.Size = new System.Drawing.Size(77, 17);
            this.rb_forgin.TabIndex = 15;
            this.rb_forgin.TabStop = true;
            this.rb_forgin.Text = "عملة أجنبية";
            this.rb_forgin.UseVisualStyleBackColor = true;
            // 
            // rb_local
            // 
            this.rb_local.AutoSize = true;
            this.rb_local.Enabled = false;
            this.rb_local.Location = new System.Drawing.Point(445, 253);
            this.rb_local.Name = "rb_local";
            this.rb_local.Size = new System.Drawing.Size(72, 17);
            this.rb_local.TabIndex = 14;
            this.rb_local.TabStop = true;
            this.rb_local.Text = "عملة محلية";
            this.rb_local.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "نوع العملة";
            // 
            // txt_part
            // 
            this.txt_part.Enabled = false;
            this.txt_part.Location = new System.Drawing.Point(65, 208);
            this.txt_part.Name = "txt_part";
            this.txt_part.Size = new System.Drawing.Size(466, 20);
            this.txt_part.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "الفكة";
            // 
            // txt_exch
            // 
            this.txt_exch.Enabled = false;
            this.txt_exch.Location = new System.Drawing.Point(65, 165);
            this.txt_exch.Name = "txt_exch";
            this.txt_exch.Size = new System.Drawing.Size(466, 20);
            this.txt_exch.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "الصرف";
            // 
            // txt_symbol
            // 
            this.txt_symbol.Enabled = false;
            this.txt_symbol.Location = new System.Drawing.Point(65, 118);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(466, 20);
            this.txt_symbol.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الرمز";
            // 
            // txt_ecname
            // 
            this.txt_ecname.Enabled = false;
            this.txt_ecname.Location = new System.Drawing.Point(65, 69);
            this.txt_ecname.Name = "txt_ecname";
            this.txt_ecname.Size = new System.Drawing.Size(466, 20);
            this.txt_ecname.TabIndex = 4;
            // 
            // txt_accname
            // 
            this.txt_accname.Enabled = false;
            this.txt_accname.Location = new System.Drawing.Point(65, 28);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.Size = new System.Drawing.Size(467, 20);
            this.txt_accname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الانجليزي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العملة";
            // 
            // gp_currencies
            // 
            this.gp_currencies.Controls.Add(this.dgv_currencies);
            this.gp_currencies.Location = new System.Drawing.Point(16, 5);
            this.gp_currencies.Name = "gp_currencies";
            this.gp_currencies.Size = new System.Drawing.Size(700, 274);
            this.gp_currencies.TabIndex = 3;
            this.gp_currencies.TabStop = false;
            this.gp_currencies.Text = "العملات";
            // 
            // dgv_currencies
            // 
            this.dgv_currencies.AllowUserToAddRows = false;
            this.dgv_currencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_currencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_currencies.Location = new System.Drawing.Point(3, 16);
            this.dgv_currencies.Name = "dgv_currencies";
            this.dgv_currencies.RowHeadersVisible = false;
            this.dgv_currencies.Size = new System.Drawing.Size(694, 255);
            this.dgv_currencies.TabIndex = 0;
            this.dgv_currencies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_currencies_CellClick);
            // 
            // frm_Currencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 727);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_inputs);
            this.Controls.Add(this.gp_currencies);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Currencies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملات";
            this.groupBox3.ResumeLayout(false);
            this.gb_inputs.ResumeLayout(false);
            this.gb_inputs.PerformLayout();
            this.gp_currencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox gb_inputs;
        private System.Windows.Forms.TextBox txt_ecname;
        private System.Windows.Forms.TextBox txt_accname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gp_currencies;
        private System.Windows.Forms.DataGridView dgv_currencies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_part;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_exch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_forgin;
        private System.Windows.Forms.RadioButton rb_local;
    }
}