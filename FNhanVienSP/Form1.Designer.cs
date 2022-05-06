
namespace FNhanVienSP
{
    partial class Form1
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
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dienThoaiLabel = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jj = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtHoNV);
            this.groupBox1.Controls.Add(this.jj);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.diaChiLabel);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.dienThoaiLabel);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(915, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(165, 60);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(115, 22);
            this.txtTenNV.TabIndex = 3;
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Location = new System.Drawing.Point(478, 68);
            this.diaChiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(55, 17);
            this.diaChiLabel.TabIndex = 6;
            this.diaChiLabel.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(576, 65);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(265, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // dienThoaiLabel
            // 
            this.dienThoaiLabel.AutoSize = true;
            this.dienThoaiLabel.Location = new System.Drawing.Point(478, 30);
            this.dienThoaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dienThoaiLabel.Name = "dienThoaiLabel";
            this.dienThoaiLabel.Size = new System.Drawing.Size(76, 17);
            this.dienThoaiLabel.TabIndex = 8;
            this.dienThoaiLabel.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(576, 30);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(265, 22);
            this.txtDienThoai.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // jj
            // 
            this.jj.AutoSize = true;
            this.jj.Location = new System.Drawing.Point(25, 29);
            this.jj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jj.Name = "jj";
            this.jj.Size = new System.Drawing.Size(101, 17);
            this.jj.TabIndex = 10;
            this.jj.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(165, 25);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(265, 22);
            this.txtMaNV.TabIndex = 11;
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(26, 65);
            this.hoTenNhanVienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(64, 17);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Tên NV :";
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(315, 59);
            this.txtHoNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(115, 22);
            this.txtHoNV.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Location = new System.Drawing.Point(262, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(338, 102);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(224, 25);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 71);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(116, 23);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 71);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(8, 23);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 71);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.Label jj;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label dienThoaiLabel;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
    }
}

