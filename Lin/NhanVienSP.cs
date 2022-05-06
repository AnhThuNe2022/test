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
    public partial class NhanVienSP : Form
    {
        public NhanVienSP()
        {
            InitializeComponent();
        }
        BUS_NhanVien bus_nv;
        private Employee em;

        public void setEmployee(Employee e)
        {
            em = e;
        }
    
        private void NhanVienSP_Load(object sender, EventArgs e)
        {
            bus_nv = new BUS_NhanVien();
            this.txtTenNV.Text = this.em.FirstName;
            this.txtHoNV.Text = this.em.LastName;
            this.txtDienThoai.Text = this.em.HomePhone;
            this.txtMaNV.Text = this.em.EmployeeID.ToString();
            this.txtDiaChi.Text = this.em.Address;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            try
            {
                em.FirstName = this.txtTenNV.Text;
                em.LastName = this.txtHoNV.Text;
                em.Address = this.txtDiaChi.Text;
                em.HomePhone = this.txtDienThoai.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (bus_nv.themNVSP(em) == 1)
            {
                MessageBox.Show("Thêm thành công");
            }

            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            

            int k = bus_nv.xoaNV(int.Parse(this.txtMaNV.Text));
            if (k == 1)
            {
                MessageBox.Show("Xóa thành công");
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

        private void btSua_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.EmployeeID = int.Parse(this.txtMaNV.Text);
            em.FirstName = this.txtTenNV.Text;
            em.LastName = this.txtHoNV.Text;
            em.Address = this.txtDiaChi.Text;
            em.HomePhone = this.txtDienThoai.Text;


            int k = bus_nv.suaNVSP(em);
            if (k == 1)
            {
                MessageBox.Show("Sửa thành công");
       
            }
            else if (k == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
    }
}
