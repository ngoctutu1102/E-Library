using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1
{
    class DangNhap_BO
    {
        public DataTable DangNhap(DangNhap_DTO DN)
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT UserNV , PassNV FROM NhanVien WHERE UserNV=@tendn AND PassNV=@matkhau";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@tendn",DN.TenDN),
                new SqlParameter("@matkhau",DN.MatKhau)
            };
            DataTable tb = data.GetData(cmd, parameter);

            return tb; 
        }
    }
}
