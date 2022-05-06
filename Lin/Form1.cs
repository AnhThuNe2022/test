using Lin.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gVNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        BUS_NhanVien bus_nv;
        private void Form1_Load(object sender, EventArgs e)
        {
            bus_nv = new BUS_NhanVien();
            bus_nv.ListNV(this.gVNV);
        }

        private String[] tachTu(String w)
        {
            int k = w.LastIndexOf(' ');
            String[] s =
            { w.Substring(k)
            , w.Substring(0,k)
        };

             return s;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
                Employee em = new Employee();
            try
            {
                em.FirstName = this.tachTu(this.txtHoten.Text)[0];
                em.LastName = this.tachTu(this.txtHoten.Text)[1];
                em.BirthDate = DateTime.Parse(this.dtpNgaySinh.Text);
                em.Address = this.txtDiaChi.Text;
                em.HomePhone = this.txtDienThoai.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không được để trống các ô");
            }

            if (bus_nv.themNV(em) == 1)
            {
                MessageBox.Show("Thêm thành công");
                bus_nv.ListNV(this.gVNV);
            }
               
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.EmployeeID = int.Parse(this.gVNV.CurrentRow.Cells[0].Value.ToString());
            em.FirstName = this.txtHoten.Text.Substring(0, txtHoten.Text.IndexOf(' '));
            em.LastName = this.txtHoten.Text.Substring(txtHoten.Text.IndexOf(' '));
            em.BirthDate = DateTime.Parse(this.dtpNgaySinh.Text);
            em.Address = this.txtDiaChi.Text;
            em.HomePhone = this.txtDienThoai.Text;


            int k = bus_nv.suaNV(em);
            if (k == 1)
            {
                MessageBox.Show("Sửa thành công");
                bus_nv.ListNV(gVNV);
            }    
            else if(k == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }

        }

        private void gVNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < gVNV.Rows.Count)
            {  
                // Họ tên
                if (this.gVNV.Rows[e.RowIndex].Cells["LastName"].Value is null && this.gVNV.Rows[e.RowIndex].Cells["FirstName"] is null)
                    this.txtHoten.Text = string.Empty;
                else if (this.gVNV.Rows[e.RowIndex].Cells["LastName"].Value is null)
                    this.txtHoten.Text = this.gVNV.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                else if (this.gVNV.Rows[e.RowIndex].Cells["FirstName"] is null)
                    this.txtHoten.Text = this.gVNV.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                else
                   this.txtHoten.Text = this.gVNV.Rows[e.RowIndex].Cells["LastName"].Value.ToString()
                           + " " + this.gVNV.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                //Điện Thoại
                if (this.gVNV.Rows[e.RowIndex].Cells["HomePhone"].Value is null)
                    this.txtDienThoai.Text = string.Empty;
                else
                    this.txtDienThoai.Text = this.gVNV.Rows[e.RowIndex].Cells["HomePhone"].Value.ToString();
                //Địa chỉ
                if (this.gVNV.Rows[e.RowIndex].Cells["Address"].Value is null)
                    this.txtDiaChi.Text = string.Empty;
                else
                this.txtDiaChi.Text = this.gVNV.Rows[e.RowIndex].Cells["Address"].Value.ToString();

                // Ngày SInh
                if (this.gVNV.Rows[e.RowIndex].Cells["Birthdate"].Value is null)
                    this.dtpNgaySinh.Text = string.Empty;
                else
                this.dtpNgaySinh.Text = this.gVNV.Rows[e.RowIndex].Cells["Birthdate"].Value.ToString();


            }
       

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(this.gVNV.CurrentRow.Cells[0].Value.ToString());
            int k = bus_nv.xoaNV(maNV);
            if (k == 1)
            {
                MessageBox.Show("Xóa thành công");
                bus_nv.ListNV(gVNV);
            }
            else if (k == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void gVNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVienSP f = new NhanVienSP();
            Employee em = new Employee();
            em.EmployeeID = int.Parse(this.gVNV.CurrentRow.Cells[0].Value.ToString());
              em.LastName = this.gVNV.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            em.FirstName = this.gVNV.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            em.Address = this.gVNV.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            em.HomePhone = this.gVNV.Rows[e.RowIndex].Cells["HomePhone"].Value.ToString();
            f.setEmployee(em);
            f.Show();
           
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemNV f = new TimKiemNV();
            f.Show();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            bus_nv.ListNV(this.gVNV);
        }
    }
}
