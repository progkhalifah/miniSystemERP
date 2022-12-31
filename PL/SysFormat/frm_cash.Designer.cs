namespace System_Accounting.PL.SysFormat
{
    partial class frm_cash
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
            this.gp_cash = new System.Windows.Forms.GroupBox();
            this.dgv_cash = new System.Windows.Forms.DataGridView();
            this.btn_display = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_function = new System.Windows.Forms.TextBox();
            this.acc_name = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gp_cash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cash)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_cash
            // 
            this.gp_cash.Controls.Add(this.dgv_cash);
            this.gp_cash.Location = new System.Drawing.Point(5, 12);
            this.gp_cash.Name = "gp_cash";
            this.gp_cash.Size = new System.Drawing.Size(700, 274);
            this.gp_cash.TabIndex = 0;
            this.gp_cash.TabStop = false;
            this.gp_cash.Text = "النقدية";
            // 
            // dgv_cash
            // 
            this.dgv_cash.AllowUserToAddRows = false;
            this.dgv_cash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cash.Location = new System.Drawing.Point(3, 16);
            this.dgv_cash.Name = "dgv_cash";
            this.dgv_cash.RowHeadersVisible = false;
            this.dgv_cash.Size = new System.Drawing.Size(694, 255);
            this.dgv_cash.TabIndex = 0;
            this.dgv_cash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cash_CellClick);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(255, 46);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(148, 57);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "عرض";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_function);
            this.groupBox2.Controls.Add(this.acc_name);
            this.groupBox2.Controls.Add(this.txt_accno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المدخلات";
            // 
            // txt_function
            // 
            this.txt_function.Location = new System.Drawing.Point(646, 25);
            this.txt_function.Name = "txt_function";
            this.txt_function.Size = new System.Drawing.Size(41, 20);
            this.txt_function.TabIndex = 6;
            this.txt_function.Visible = false;
            // 
            // acc_name
            // 
            this.acc_name.Enabled = false;
            this.acc_name.Location = new System.Drawing.Point(65, 69);
            this.acc_name.Name = "acc_name";
            this.acc_name.Size = new System.Drawing.Size(466, 20);
            this.acc_name.TabIndex = 4;
            // 
            // txt_accno
            // 
            this.txt_accno.Enabled = false;
            this.txt_accno.Location = new System.Drawing.Point(65, 28);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(467, 20);
            this.txt_accno.TabIndex = 3;
            this.txt_accno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الحساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_display);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Location = new System.Drawing.Point(5, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
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
            // frm_cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gp_cash);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cash";
            this.gp_cash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cash)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_cash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox acc_name;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.TextBox txt_function;
        public System.Windows.Forms.GroupBox gp_cash;
        private System.Windows.Forms.Button btn_display;
    }
}