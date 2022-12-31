namespace System_Accounting.PL.Products
{
    partial class frm_Add_Products
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.img_selected = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cm_categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_selected)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.img_selected);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ref);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cm_categories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "تحديد ملف الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // img_selected
            // 
            this.img_selected.Image = global::System_Accounting.Properties.Resources.no_img_avaliable;
            this.img_selected.Location = new System.Drawing.Point(440, 303);
            this.img_selected.Name = "img_selected";
            this.img_selected.Size = new System.Drawing.Size(203, 83);
            this.img_selected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_selected.TabIndex = 11;
            this.img_selected.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "صورة المنتج";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(440, 262);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(203, 20);
            this.txt_price.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ثمن المنتج";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(440, 209);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(203, 20);
            this.txt_quantity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "الكمية المخزنة";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(438, 146);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(203, 36);
            this.txt_desc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف المنتج";
            // 
            // txt_ref
            // 
            this.txt_ref.Location = new System.Drawing.Point(438, 97);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(203, 20);
            this.txt_ref.TabIndex = 0;
            this.txt_ref.Validated += new System.EventHandler(this.txt_ref_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "معرف المنتج";
            // 
            // cm_categories
            // 
            this.cm_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_categories.FormattingEnabled = true;
            this.cm_categories.Location = new System.Drawing.Point(438, 42);
            this.cm_categories.Name = "cm_categories";
            this.cm_categories.Size = new System.Drawing.Size(203, 21);
            this.cm_categories.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_save.Location = new System.Drawing.Point(398, 456);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 44);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "موافق";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(283, 456);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 44);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_Add_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 520);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_selected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox txt_price;
        public System.Windows.Forms.TextBox txt_quantity;
        public System.Windows.Forms.TextBox txt_desc;
        public System.Windows.Forms.TextBox txt_ref;
        public System.Windows.Forms.ComboBox cm_categories;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.PictureBox img_selected;
    }
}