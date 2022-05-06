
namespace Lin
{
    partial class TimKiemNV
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
            System.Windows.Forms.Button BTTim;
            this.gVNV = new System.Windows.Forms.DataGridView();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.rbMa = new System.Windows.Forms.RadioButton();
            this.rbHo = new System.Windows.Forms.RadioButton();
            this.rbTen = new System.Windows.Forms.RadioButton();
            BTTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gVNV
            // 
            this.gVNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVNV.Location = new System.Drawing.Point(12, 270);
            this.gVNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gVNV.Name = "gVNV";
            this.gVNV.RowHeadersWidth = 62;
            this.gVNV.RowTemplate.Height = 28;
            this.gVNV.Size = new System.Drawing.Size(813, 331);
            this.gVNV.TabIndex = 2;
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(185, 78);
            this.hoTenNhanVienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(46, 17);
            this.hoTenNhanVienLabel.TabIndex = 4;
            this.hoTenNhanVienLabel.Text = "Nhập:";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(239, 78);
            this.txtKeyWords.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(410, 22);
            this.txtKeyWords.TabIndex = 5;
            // 
            // rbMa
            // 
            this.rbMa.AutoSize = true;
            this.rbMa.Checked = true;
            this.rbMa.Location = new System.Drawing.Point(121, 121);
            this.rbMa.Name = "rbMa";
            this.rbMa.Size = new System.Drawing.Size(147, 21);
            this.rbMa.TabIndex = 6;
            this.rbMa.TabStop = true;
            this.rbMa.Text = "Tìm Kiếm Theo Mã";
            this.rbMa.UseVisualStyleBackColor = true;
            // 
            // rbHo
            // 
            this.rbHo.AutoSize = true;
            this.rbHo.Location = new System.Drawing.Point(341, 121);
            this.rbHo.Name = "rbHo";
            this.rbHo.Size = new System.Drawing.Size(146, 21);
            this.rbHo.TabIndex = 7;
            this.rbHo.Text = "Tìm Kiếm Theo Họ";
            this.rbHo.UseVisualStyleBackColor = true;
            // 
            // rbTen
            // 
            this.rbTen.AutoSize = true;
            this.rbTen.Location = new System.Drawing.Point(584, 121);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(153, 21);
            this.rbTen.TabIndex = 8;
            this.rbTen.Text = "Tìm Kiếm Theo Tên";
            this.rbTen.UseVisualStyleBackColor = true;
            // 
            // BTTim
            // 
            BTTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTTim.Location = new System.Drawing.Point(339, 187);
            BTTim.Name = "BTTim";
            BTTim.Size = new System.Drawing.Size(148, 31);
            BTTim.TabIndex = 9;
            BTTim.Text = "Tìm";
            BTTim.UseVisualStyleBackColor = true;
            BTTim.Click += new System.EventHandler(this.BTTim_Click);
            // 
            // TimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 647);
            this.Controls.Add(BTTim);
            this.Controls.Add(this.rbTen);
            this.Controls.Add(this.rbHo);
            this.Controls.Add(this.rbMa);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.gVNV);
            this.Name = "TimKiemNV";
            this.Text = "TimKiemNV";
            this.Load += new System.EventHandler(this.TimKiemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gVNV;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.RadioButton rbMa;
        private System.Windows.Forms.RadioButton rbHo;
        private System.Windows.Forms.RadioButton rbTen;
    }
}