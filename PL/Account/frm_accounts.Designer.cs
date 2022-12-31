
namespace System_Accounting.PL.Account
{
    partial class frm_accounts
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
            this.gp_account = new System.Windows.Forms.GroupBox();
            this.tv_account = new System.Windows.Forms.TreeView();
            this.gp_inputs = new System.Windows.Forms.GroupBox();
            this.txt_accbalance = new System.Windows.Forms.TextBox();
            this.txt_acccredit = new System.Windows.Forms.TextBox();
            this.txt_accdebit = new System.Windows.Forms.TextBox();
            this.txt_acclevel = new System.Windows.Forms.TextBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.txt_accparent = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.cb_acctype = new System.Windows.Forms.ComboBox();
            this.cb_report = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gp_account.SuspendLayout();
            this.gp_inputs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_account
            // 
            this.gp_account.Controls.Add(this.tv_account);
            this.gp_account.Location = new System.Drawing.Point(2, 10);
            this.gp_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_account.Name = "gp_account";
            this.gp_account.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_account.Size = new System.Drawing.Size(446, 593);
            this.gp_account.TabIndex = 0;
            this.gp_account.TabStop = false;
            this.gp_account.Text = "الدليل المحاسبي";
            // 
            // tv_account
            // 
            this.tv_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_account.Location = new System.Drawing.Point(3, 15);
            this.tv_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tv_account.Name = "tv_account";
            this.tv_account.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tv_account.RightToLeftLayout = true;
            this.tv_account.Size = new System.Drawing.Size(440, 576);
            this.tv_account.TabIndex = 0;
            this.tv_account.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_account_AfterSelect);
            // 
            // gp_inputs
            // 
            this.gp_inputs.Controls.Add(this.txt_accbalance);
            this.gp_inputs.Controls.Add(this.txt_acccredit);
            this.gp_inputs.Controls.Add(this.txt_accdebit);
            this.gp_inputs.Controls.Add(this.txt_acclevel);
            this.gp_inputs.Controls.Add(this.txt_accname);
            this.gp_inputs.Controls.Add(this.txt_accparent);
            this.gp_inputs.Controls.Add(this.txt_accno);
            this.gp_inputs.Controls.Add(this.label7);
            this.gp_inputs.Controls.Add(this.label6);
            this.gp_inputs.Controls.Add(this.label5);
            this.gp_inputs.Controls.Add(this.label4);
            this.gp_inputs.Controls.Add(this.label3);
            this.gp_inputs.Controls.Add(this.label2);
            this.gp_inputs.Controls.Add(this.label1);
            this.gp_inputs.Location = new System.Drawing.Point(453, 10);
            this.gp_inputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_inputs.Name = "gp_inputs";
            this.gp_inputs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gp_inputs.Size = new System.Drawing.Size(590, 343);
            this.gp_inputs.TabIndex = 1;
            this.gp_inputs.TabStop = false;
            this.gp_inputs.Text = "المدخلات";
            // 
            // txt_accbalance
            // 
            this.txt_accbalance.Location = new System.Drawing.Point(66, 280);
            this.txt_accbalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accbalance.Name = "txt_accbalance";
            this.txt_accbalance.Size = new System.Drawing.Size(330, 20);
            this.txt_accbalance.TabIndex = 7;
            this.txt_accbalance.Text = "0.00";
            // 
            // txt_acccredit
            // 
            this.txt_acccredit.Location = new System.Drawing.Point(66, 233);
            this.txt_acccredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_acccredit.Name = "txt_acccredit";
            this.txt_acccredit.Size = new System.Drawing.Size(330, 20);
            this.txt_acccredit.TabIndex = 6;
            this.txt_acccredit.Text = "0.00";
            // 
            // txt_accdebit
            // 
            this.txt_accdebit.Location = new System.Drawing.Point(66, 193);
            this.txt_accdebit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accdebit.Name = "txt_accdebit";
            this.txt_accdebit.Size = new System.Drawing.Size(330, 20);
            this.txt_accdebit.TabIndex = 5;
            this.txt_accdebit.Text = "0.00";
            // 
            // txt_acclevel
            // 
            this.txt_acclevel.Location = new System.Drawing.Point(66, 150);
            this.txt_acclevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_acclevel.Name = "txt_acclevel";
            this.txt_acclevel.Size = new System.Drawing.Size(330, 20);
            this.txt_acclevel.TabIndex = 4;
            // 
            // txt_accname
            // 
            this.txt_accname.Location = new System.Drawing.Point(66, 114);
            this.txt_accname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.Size = new System.Drawing.Size(330, 20);
            this.txt_accname.TabIndex = 3;
            // 
            // txt_accparent
            // 
            this.txt_accparent.Location = new System.Drawing.Point(66, 76);
            this.txt_accparent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accparent.Name = "txt_accparent";
            this.txt_accparent.Size = new System.Drawing.Size(330, 20);
            this.txt_accparent.TabIndex = 2;
            // 
            // txt_accno
            // 
            this.txt_accno.AllowDrop = true;
            this.txt_accno.Location = new System.Drawing.Point(136, 37);
            this.txt_accno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(260, 20);
            this.txt_accno.TabIndex = 1;
            this.txt_accno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "رصيد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "دائن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "مدين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "مستوى الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الحساب الأب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_tag);
            this.groupBox3.Controls.Add(this.cb_acctype);
            this.groupBox3.Controls.Add(this.cb_report);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(453, 358);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(590, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(427, 31);
            this.txt_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(48, 20);
            this.txt_tag.TabIndex = 14;
            this.txt_tag.Visible = false;
            this.txt_tag.TextChanged += new System.EventHandler(this.txt_tag_TextChanged);
            // 
            // cb_acctype
            // 
            this.cb_acctype.FormattingEnabled = true;
            this.cb_acctype.Location = new System.Drawing.Point(66, 76);
            this.cb_acctype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_acctype.Name = "cb_acctype";
            this.cb_acctype.Size = new System.Drawing.Size(330, 21);
            this.cb_acctype.TabIndex = 9;
            // 
            // cb_report
            // 
            this.cb_report.FormattingEnabled = true;
            this.cb_report.Location = new System.Drawing.Point(66, 30);
            this.cb_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_report.Name = "cb_report";
            this.cb_report.Size = new System.Drawing.Size(330, 21);
            this.cb_report.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "نوع الحساب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "التقرير";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_exit);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.btn_save);
            this.groupBox4.Controls.Add(this.btn_new);
            this.groupBox4.Location = new System.Drawing.Point(453, 522);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(590, 81);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(5, 27);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(109, 42);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(119, 27);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 42);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(234, 27);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 42);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(348, 27);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 42);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(462, 27);
            this.btn_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(109, 42);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "أضافة";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 613);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gp_inputs);
            this.Controls.Add(this.gp_account);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_accounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات";
            this.Load += new System.EventHandler(this.frm_accounts_Load);
            this.gp_account.ResumeLayout(false);
            this.gp_inputs.ResumeLayout(false);
            this.gp_inputs.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_account;
        private System.Windows.Forms.TreeView tv_account;
        private System.Windows.Forms.GroupBox gp_inputs;
        private System.Windows.Forms.TextBox txt_accbalance;
        private System.Windows.Forms.TextBox txt_acccredit;
        private System.Windows.Forms.TextBox txt_accdebit;
        private System.Windows.Forms.TextBox txt_acclevel;
        private System.Windows.Forms.TextBox txt_accname;
        private System.Windows.Forms.TextBox txt_accparent;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_acctype;
        private System.Windows.Forms.ComboBox cb_report;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_tag;
    }
}