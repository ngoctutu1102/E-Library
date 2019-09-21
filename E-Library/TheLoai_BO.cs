using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1
{
    class TheLoai_BO
    {
        public DataTable DS()
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT MaTL , TenTL FROM TheLoai
                                        ";
            DataTable tb = data.GetData(cmd);

            return tb;
        }

        public int Them(TheLoai_DTO tlDTO)
        {
            DataAccess data = new DataAccess();

            string cmd = @"INSERT INTO  TheLoai(MaTL,TenTL)
                                        VALUES(@matl,@tentl ) ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@matl",tlDTO.MaTL),
                new SqlParameter("@tentl",tlDTO.TenTL)
               

            };
            int result = data.AddData(cmd, parameter);
            return result;
        }

        public int Xoa(string MaTL)
        {
            DataAccess data = new DataAccess();
            string cmd = @"DELETE FROM TheLoai WHERE MaTL= @matl                           
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@matl",MaTL)
            };
            return data.AddData(cmd, parameter);
        }

        public int Sua(TheLoai_DTO tlDTO)
        {
            DataAccess data = new DataAccess();

            string cmd = @"UPDATE TheLoai SET TenTL = @tentl
                           
                           WHERE MaTL = @matl  ";
            SqlParameter[] parameter = new SqlParameter[]
            {
               new SqlParameter("@matl",tlDTO.MaTL),
                new SqlParameter("@tentl",tlDTO.TenTL)
                

            };
            return data.AddData(cmd, parameter);
        }
    }
}
