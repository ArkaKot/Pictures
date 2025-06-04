namespace Pictures
{
    partial class DetailImage
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.tbCreateDate = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbwidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nazwa";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(12, 46);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(45, 13);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Rozmiar";
            this.lbSize.UseWaitCursor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 13);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(80, 43);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(100, 20);
            this.tbSize.TabIndex = 3;
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(12, 80);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(57, 13);
            this.lbCreateDate.TabIndex = 4;
            this.lbCreateDate.Text = "Utworzony";
            // 
            // tbCreateDate
            // 
            this.tbCreateDate.Location = new System.Drawing.Point(80, 77);
            this.tbCreateDate.Name = "tbCreateDate";
            this.tbCreateDate.ReadOnly = true;
            this.tbCreateDate.Size = new System.Drawing.Size(100, 20);
            this.tbCreateDate.TabIndex = 5;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(12, 113);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(57, 13);
            this.lbWidth.TabIndex = 6;
            this.lbWidth.Text = "Szerokość";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(12, 142);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(57, 13);
            this.lbHeight.TabIndex = 7;
            this.lbHeight.Text = "Wysokość";
            // 
            // tbwidth
            // 
            this.tbwidth.Location = new System.Drawing.Point(80, 110);
            this.tbwidth.Name = "tbwidth";
            this.tbwidth.ReadOnly = true;
            this.tbwidth.Size = new System.Drawing.Size(100, 20);
            this.tbwidth.TabIndex = 10;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(80, 139);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 11;
            // 
            // DetailImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 176);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbwidth);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.tbCreateDate);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbName);
            this.MaximumSize = new System.Drawing.Size(218, 215);
            this.MinimumSize = new System.Drawing.Size(218, 215);
            this.Name = "DetailImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szczegóły";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.TextBox tbCreateDate;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbwidth;
        private System.Windows.Forms.TextBox tbHeight;
    }
}