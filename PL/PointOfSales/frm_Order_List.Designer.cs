namespace System_Accounting.PL.PointOfSales
{
    partial class frm_Order_List
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
            this.dgv_all_orders = new System.Windows.Forms.DataGridView();
            this.txt_search_order = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_all_orders);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 667);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            // 
            // dgv_all_orders
            // 
            this.dgv_all_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all_orders.Location = new System.Drawing.Point(6, 19);
            this.dgv_all_orders.Name = "dgv_all_orders";
            this.dgv_all_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_all_orders.Size = new System.Drawing.Size(1180, 637);
            this.dgv_all_orders.TabIndex = 0;
            // 
            // txt_search_order
            // 
            this.txt_search_order.Location = new System.Drawing.Point(480, 38);
            this.txt_search_order.Name = "txt_search_order";
            this.txt_search_order.Size = new System.Drawing.Size(321, 20);
            this.txt_search_order.TabIndex = 3;
            this.txt_search_order.TextChanged += new System.EventHandler(this.txt_search_order_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "قم بإدخال كلمة البحث";
            // 
            // frm_Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 819);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_search_order);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Order_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فواتير المبيعات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_all_orders;
        private System.Windows.Forms.TextBox txt_search_order;
        private System.Windows.Forms.Label label1;
    }
}