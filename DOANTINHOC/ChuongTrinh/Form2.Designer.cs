namespace DOANTINHOC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_Xe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.btn_DXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 49);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Loại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 206);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(115, 44);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên Loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoai.Location = new System.Drawing.Point(182, 141);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(632, 32);
            this.txt_MaLoai.TabIndex = 25;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(847, 294);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(154, 75);
            this.btn_Them.TabIndex = 27;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(847, 397);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(154, 75);
            this.btn_Xoa.TabIndex = 28;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(847, 500);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(154, 75);
            this.btn_Sua.TabIndex = 29;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(41, 282);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(773, 291);
            this.dgv1.TabIndex = 31;
            this.dgv1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_RowEnter);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(284, 951);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(150, 40);
            this.btn_DangXuat.TabIndex = 17;
            this.btn_DangXuat.Text = "Đăng Xuất ";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Location = new System.Drawing.Point(595, 52);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(163, 63);
            this.btn_HoaDon.TabIndex = 20;
            this.btn_HoaDon.Text = "HOA DON";
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_Xe
            // 
            this.btn_Xe.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xe.Location = new System.Drawing.Point(343, 52);
            this.btn_Xe.Name = "btn_Xe";
            this.btn_Xe.Size = new System.Drawing.Size(163, 63);
            this.btn_Xe.TabIndex = 21;
            this.btn_Xe.Text = "Xe";
            this.btn_Xe.UseVisualStyleBackColor = true;
            this.btn_Xe.Click += new System.EventHandler(this.btn_Xe_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 91);
            this.label3.TabIndex = 33;
            this.label3.Text = "Loại Xe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_LoaiXe
            // 
            this.cbb_LoaiXe.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiXe.FormattingEnabled = true;
            this.cbb_LoaiXe.Items.AddRange(new object[] {
            "Xe Số",
            "Xe Côn",
            "Xe Tay Ga",
            "Xe MoTo(PKL)"});
            this.cbb_LoaiXe.Location = new System.Drawing.Point(182, 222);
            this.cbb_LoaiXe.Name = "cbb_LoaiXe";
            this.cbb_LoaiXe.Size = new System.Drawing.Size(632, 31);
            this.cbb_LoaiXe.TabIndex = 34;
            // 
            // btn_DXuat
            // 
            this.btn_DXuat.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DXuat.Location = new System.Drawing.Point(847, 191);
            this.btn_DXuat.Name = "btn_DXuat";
            this.btn_DXuat.Size = new System.Drawing.Size(154, 75);
            this.btn_DXuat.TabIndex = 35;
            this.btn_DXuat.Text = "Đăng Xuất";
            this.btn_DXuat.UseVisualStyleBackColor = true;
            this.btn_DXuat.Click += new System.EventHandler(this.btn_DXuat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 600);
            this.Controls.Add(this.btn_DXuat);
            this.Controls.Add(this.cbb_LoaiXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Xe);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_MaLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Xe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_Xe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_LoaiXe;
        private System.Windows.Forms.Button btn_DXuat;
    }
}