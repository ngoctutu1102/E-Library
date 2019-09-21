namespace DoAn1
{
    partial class UCTheLoai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgTheLoai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.btnThemTL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.btnXoaTL = new System.Windows.Forms.Button();
            this.btnSuaTL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTheLoai
            // 
            this.dgTheLoai.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheLoai.Location = new System.Drawing.Point(25, 259);
            this.dgTheLoai.Name = "dgTheLoai";
            this.dgTheLoai.Size = new System.Drawing.Size(725, 185);
            this.dgTheLoai.TabIndex = 1;
            this.dgTheLoai.DoubleClick += new System.EventHandler(this.dgTheLoai_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(43, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Thể Loại:";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(175, 126);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(200, 23);
            this.txtMaTL.TabIndex = 3;
            // 
            // btnThemTL
            // 
            this.btnThemTL.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemTL.FlatAppearance.BorderSize = 0;
            this.btnThemTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTL.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTL.ForeColor = System.Drawing.Color.White;
            this.btnThemTL.Location = new System.Drawing.Point(46, 193);
            this.btnThemTL.Name = "btnThemTL";
            this.btnThemTL.Size = new System.Drawing.Size(139, 39);
            this.btnThemTL.TabIndex = 5;
            this.btnThemTL.Text = "Thêm";
            this.btnThemTL.UseVisualStyleBackColor = false;
            this.btnThemTL.Click += new System.EventHandler(this.btnThemTL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(430, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Thể Loại:";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.Location = new System.Drawing.Point(550, 126);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(200, 23);
            this.txtTenTL.TabIndex = 3;
            // 
            // btnXoaTL
            // 
            this.btnXoaTL.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoaTL.FlatAppearance.BorderSize = 0;
            this.btnXoaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTL.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTL.ForeColor = System.Drawing.Color.White;
            this.btnXoaTL.Location = new System.Drawing.Point(611, 193);
            this.btnXoaTL.Name = "btnXoaTL";
            this.btnXoaTL.Size = new System.Drawing.Size(139, 39);
            this.btnXoaTL.TabIndex = 5;
            this.btnXoaTL.Text = "Xóa";
            this.btnXoaTL.UseVisualStyleBackColor = false;
            this.btnXoaTL.Click += new System.EventHandler(this.btnXoaTL_Click);
            // 
            // btnSuaTL
            // 
            this.btnSuaTL.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSuaTL.FlatAppearance.BorderSize = 0;
            this.btnSuaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTL.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTL.ForeColor = System.Drawing.Color.White;
            this.btnSuaTL.Location = new System.Drawing.Point(311, 193);
            this.btnSuaTL.Name = "btnSuaTL";
            this.btnSuaTL.Size = new System.Drawing.Size(139, 39);
            this.btnSuaTL.TabIndex = 6;
            this.btnSuaTL.Text = "Sửa";
            this.btnSuaTL.UseVisualStyleBackColor = false;
            this.btnSuaTL.Click += new System.EventHandler(this.btnSuaTL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(239, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 75);
            this.label3.TabIndex = 7;
            this.label3.Text = "THỂ LOẠI";
            // 
            // UCTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSuaTL);
            this.Controls.Add(this.btnXoaTL);
            this.Controls.Add(this.btnThemTL);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTheLoai);
            this.Name = "UCTheLoai";
            this.Size = new System.Drawing.Size(790, 470);
            this.Load += new System.EventHandler(this.UCTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Button btnThemTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Button btnXoaTL;
        private System.Windows.Forms.Button btnSuaTL;
        private System.Windows.Forms.Label label3;
    }
}
