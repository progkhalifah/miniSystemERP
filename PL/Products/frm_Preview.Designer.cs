namespace System_Accounting.PL.Products
{
    partial class frm_Preview
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
            this.img_preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // img_preview
            // 
            this.img_preview.Location = new System.Drawing.Point(12, 12);
            this.img_preview.Name = "img_preview";
            this.img_preview.Size = new System.Drawing.Size(500, 459);
            this.img_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_preview.TabIndex = 0;
            this.img_preview.TabStop = false;
            // 
            // frm_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 483);
            this.Controls.Add(this.img_preview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Preview";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الصورة";
            ((System.ComponentModel.ISupportInitialize)(this.img_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox img_preview;
    }
}