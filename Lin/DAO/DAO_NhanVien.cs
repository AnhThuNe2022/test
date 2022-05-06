using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lin.DAO
{
    class DAO_NhanVien
    {
        NorthwindDataContext db;
        public DAO_NhanVien()
        {
            db = new NorthwindDataContext();
        }

        public dynamic ListNhanVien()
        {
            var nv = db.Employees.Select(p => new
            {
                p.EmployeeID,
                p.FirstName,
                p.LastName,
                p.BirthDate,
                p.HomePhone,
                p.Address
            });

            return nv;
        }

        public void themNV(Employee e)
        {
            Employee e1 = new Employee();
            e1.EmployeeID = e.EmployeeID;
            e1.FirstName = e.FirstName;
            e1.LastName = e.LastName;
            e1.BirthDate = e.BirthDate;
            e1.Address = e.Address;
            e1.HomePhone = e.HomePhone;

            db.Employees.InsertOnSubmit(e1);
            db.SubmitChanges();
        }

        public Employee timNV(int ma)
        {
            Employee e = db.Employees.FirstOrDefault(p => p.EmployeeID == ma);
            return e;
        }

        public void suaNV(Employee e)
        {
            Employee e1;
            e1 = timNV(e.EmployeeID);
            e1.FirstName = e.FirstName;
            e1.LastName = e.LastName;
            e1.HomePhone = e.HomePhone;
            e1.Address = e.Address;
            e1.BirthDate = e.BirthDate;
            db.SubmitChanges();
        }

        public void xoaNV(int maNV)
        {
            Employee e;
            e = timNV(maNV);
            db.Employees.DeleteOnSubmit(e);
            db.SubmitChanges();
        }


        //------------------ SP-------------------------

        public void themNVSP(Employee e)
        {
            db.themNV(e.LastName, e.FirstName, e.Address, e.HomePhone);
            db.SubmitChanges();
        }

        public void xoaNVSP(int maNV)
        {
            db.xoaNV(maNV);
            db.SubmitChanges();
        }
        public void suaNVSP(Employee e)
        { 
            db.suaNV(e.EmployeeID,e.LastName,e.FirstName,e.Address,e.HomePhone);
            db.SubmitChanges();
        }

        //-----------------------Tìm kiếm -------------------------
        public dynamic timKiemTheoKw(String kw, int chon)
        {

            if (chon == 1)
            {
                var nv = db.Employees.Where(p => p.EmployeeID.ToString() == kw).Select(p => new
                {
                    p.EmployeeID,
                    p.LastName,
                    p.FirstName,
                    p.Address,
                    p.HomePhone
                });
                return nv;
            }
            else if (chon == 2)
            {
                var nv = db.Employees.Where(p => p.LastName.Contains(kw)).Select(p => new
                {
                    p.EmployeeID,
                    p.LastName,
                    p.FirstName,
                    p.Address,
                    p.HomePhone
                });
                return nv;
            }
            else
            {
                var nv = db.Employees.Where(p => p.FirstName.Contains(kw)).Select(p => new
                {
                    p.EmployeeID,
                    p.LastName,
                    p.FirstName,
                    p.Address,
                    p.HomePhone
                });
                return nv;
            }

            
        }
    } 
}
