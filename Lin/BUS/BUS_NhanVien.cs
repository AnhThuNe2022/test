using Lin.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lin.BUS
{
   public class BUS_NhanVien
    {
        DAO_NhanVien dao_nv;
        public BUS_NhanVien()
        {
            dao_nv = new DAO_NhanVien();
        }

        public void ListNV(DataGridView d)
        {
            d.DataSource = dao_nv.ListNhanVien();
        }

        public int themNV(Employee e)
        {
            int i = -1;
            try
            {
                dao_nv.themNV(e);

                i = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return i;
        }

        public int suaNV(Employee e)
        {
            int i = -1;
            try
            {
                if (dao_nv.timNV(e.EmployeeID) == null)
                {
                    i = 0;
                }
                else
                {
                    dao_nv.suaNV(e);
                    i = 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return i;
        }

        public int xoaNV(int maNV)
        {
            int i = -1;
            try
            {
                if (dao_nv.timNV(maNV) == null)
                {
                    i = 0;
                }
                else
                {
                    dao_nv.xoaNV(maNV);
                    i = 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return i;
        }
        //----------------------------- SP---------------------------------
        public int themNVSP(Employee e)
        {
            int i = -1;
            try
            {
                dao_nv.themNVSP(e);

                i = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return i;
        }
        public int xoaNVSP(int maNV)
        {
            int i = -1;
            try
            {
                if (dao_nv.timNV(maNV) == null)
                {
                    i = 0;
                }
                else
                {
                    dao_nv.xoaNVSP(maNV);
                    i = 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return i;
        }
        public int suaNVSP(Employee e)
        {
            int i = -1;
            try
            {
                if (dao_nv.timNV(e.EmployeeID) == null)
                {
                    i = 0;
                }
                else
                {
                    dao_nv.suaNVSP(e);
                    i = 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return i;
        }

        //------------------------Tìm kiếm ---------------------------
        public int timKiem(String kw, int chon, DataGridView gvnv)
        {
            int i = -1;
            try
            {
                var nv = dao_nv.timKiemTheoKw(kw, chon);
                    gvnv.DataSource = nv;
               
                if (gvnv.Rows.Count <= 0)
                    i = 0;
                else
                    i = 1;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return i;
        }

    }
}
