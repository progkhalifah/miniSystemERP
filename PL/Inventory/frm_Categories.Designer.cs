namespace System_Accounting.PL.Inventory
{
    partial class frm_Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Categories));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_no_categ = new System.Windows.Forms.TextBox();
            this.txt_name_categ = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_firs = new System.Windows.Forms.Button();
            this.txt_position = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_newno = new System.Windows.Forms.Button();
            this.btn_save_categ = new System.Windows.Forms.Button();
            this.btn_update_categ = new System.Windows.Forms.Button();
            this.btn_delete_categ = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_category);
            this.groupBox1.Controls.Add(this.txt_position);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_last);
            this.groupBox1.Controls.Add(this.btn_prev);
            this.groupBox1.Controls.Add(this.btn_firs);
            this.groupBox1.Controls.Add(this.txt_name_categ);
            this.groupBox1.Controls.Add(this.txt_no_categ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الأصناف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "معرف الصنف :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(877, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "أسم الصنف :";
            // 
            // txt_no_categ
            // 
            this.txt_no_categ.Location = new System.Drawing.Point(685, 104);
            this.txt_no_categ.Name = "txt_no_categ";
            this.txt_no_categ.ReadOnly = true;
            this.txt_no_categ.Size = new System.Drawing.Size(180, 20);
            this.txt_no_categ.TabIndex = 2;
            // 
            // txt_name_categ
            // 
            this.txt_name_categ.Location = new System.Drawing.Point(654, 145);
            this.txt_name_categ.Multiline = true;
            this.txt_name_categ.Name = "txt_name_categ";
            this.txt_name_categ.Size = new System.Drawing.Size(213, 28);
            this.txt_name_categ.TabIndex = 3;
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(698, 217);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(67, 23);
            this.btn_next.TabIndex = 16;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.Location = new System.Drawing.Point(627, 217);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(65, 23);
            this.btn_last.TabIndex = 15;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.Location = new System.Drawing.Point(818, 217);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(63, 23);
            this.btn_prev.TabIndex = 14;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_firs
            // 
            this.btn_firs.Image = ((System.Drawing.Image)(resources.GetObject("btn_firs.Image")));
            this.btn_firs.Location = new System.Drawing.Point(887, 217);
            this.btn_firs.Name = "btn_firs";
            this.btn_firs.Size = new System.Drawing.Size(60, 23);
            this.btn_firs.TabIndex = 13;
            this.btn_firs.UseVisualStyleBackColor = true;
            this.btn_firs.Click += new System.EventHandler(this.btn_firs_Click);
            // 
            // txt_position
            // 
            this.txt_position.AutoSize = true;
            this.txt_position.Location = new System.Drawing.Point(776, 222);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(24, 13);
            this.txt_position.TabIndex = 17;
            this.txt_position.Text = "7/6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_delete_categ);
            this.groupBox2.Controls.Add(this.btn_update_categ);
            this.groupBox2.Controls.Add(this.btn_save_categ);
            this.groupBox2.Controls.Add(this.btn_newno);
            this.groupBox2.Location = new System.Drawing.Point(12, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btn_newno
            // 
            this.btn_newno.Location = new System.Drawing.Point(877, 33);
            this.btn_newno.Name = "btn_newno";
            this.btn_newno.Size = new System.Drawing.Size(75, 23);
            this.btn_newno.TabIndex = 0;
            this.btn_newno.Text = "جديد";
            this.btn_newno.UseVisualStyleBackColor = true;
            this.btn_newno.Click += new System.EventHandler(this.btn_newno_Click);
            // 
            // btn_save_categ
            // 
            this.btn_save_categ.Enabled = false;
            this.btn_save_categ.Location = new System.Drawing.Point(796, 33);
            this.btn_save_categ.Name = "btn_save_categ";
            this.btn_save_categ.Size = new System.Drawing.Size(75, 23);
            this.btn_save_categ.TabIndex = 1;
            this.btn_save_categ.Text = "أضافة";
            this.btn_save_categ.UseVisualStyleBackColor = true;
            this.btn_save_categ.Click += new System.EventHandler(this.btn_save_categ_Click);
            // 
            // btn_update_categ
            // 
            this.btn_update_categ.Location = new System.Drawing.Point(715, 33);
            this.btn_update_categ.Name = "btn_update_categ";
            this.btn_update_categ.Size = new System.Drawing.Size(75, 23);
            this.btn_update_categ.TabIndex = 2;
            this.btn_update_categ.Text = "تعديل";
            this.btn_update_categ.UseVisualStyleBackColor = true;
            this.btn_update_categ.Click += new System.EventHandler(this.btn_update_categ_Click);
            // 
            // btn_delete_categ
            // 
            this.btn_delete_categ.Location = new System.Drawing.Point(634, 33);
            this.btn_delete_categ.Name = "btn_delete_categ";
            this.btn_delete_categ.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_categ.TabIndex = 3;
            this.btn_delete_categ.Text = "حذف";
            this.btn_delete_categ.UseVisualStyleBackColor = true;
            this.btn_delete_categ.Click += new System.EventHandler(this.btn_delete_categ_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(553, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "إغلاق";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(6, 12);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.Size = new System.Drawing.Size(612, 323);
            this.dgv_category.TabIndex = 18;
            // 
            // frm_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_name_categ;
        private System.Windows.Forms.TextBox txt_no_categ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Label txt_position;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_firs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_delete_categ;
        private System.Windows.Forms.Button btn_update_categ;
        private System.Windows.Forms.Button btn_save_categ;
        private System.Windows.Forms.Button btn_newno;
    }
}