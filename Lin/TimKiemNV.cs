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
    public partial class TimKiemNV : Form
    {
        public TimKiemNV()
        {
            InitializeComponent();
        }
        BUS_NhanVien bus_nv;
        private void TimKiemNV_Load(object sender, EventArgs e)
        {
            bus_nv = new BUS_NhanVien();
        }

        private void BTTim_Click(object sender, EventArgs e)
        {
            int chon;
            if (this.rbHo.Checked == true)
                chon = 2;
            else if (this.rbMa.Checked == true)
                chon = 1;
            else
                chon = 3;

            int i = bus_nv.timKiem(this.txtKeyWords.Text, chon, this.gVNV);
            if(i == -1)
            {
                MessageBox.Show("Lỗi tìm không thành công");
            }
            else if(i == 0)
            {
                MessageBox.Show("Không có nhân viên nào được tìm thấy");
            }
            

        }
    }
}
