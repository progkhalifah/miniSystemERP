namespace System_Accounting.PL.PointOfSales
{
    partial class frm_search_customer
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
            this.dgv_all_customers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search_customers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_all_customers);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 716);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات البحث";
            // 
            // dgv_all_customers
            // 
            this.dgv_all_customers.AllowUserToAddRows = false;
            this.dgv_all_customers.AllowUserToDeleteRows = false;
            this.dgv_all_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_all_customers.Location = new System.Drawing.Point(3, 16);
            this.dgv_all_customers.Name = "dgv_all_customers";
            this.dgv_all_customers.ReadOnly = true;
            this.dgv_all_customers.Size = new System.Drawing.Size(1189, 697);
            this.dgv_all_customers.TabIndex = 0;
            this.dgv_all_customers.DoubleClick += new System.EventHandler(this.dgv_all_customers_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "البحث باسم اللاعب";
            // 
            // txt_search_customers
            // 
            this.txt_search_customers.Location = new System.Drawing.Point(160, 22);
            this.txt_search_customers.Name = "txt_search_customers";
            this.txt_search_customers.Size = new System.Drawing.Size(559, 20);
            this.txt_search_customers.TabIndex = 2;
            this.txt_search_customers.TextChanged += new System.EventHandler(this.txt_search_customers_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "اختار الطالب";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_search_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_search_customers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_search_customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث اسماء اللاعبين";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search_customers;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgv_all_customers;
    }
}