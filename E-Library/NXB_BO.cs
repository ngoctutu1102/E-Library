using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1
{
    class NXB_BO
    {
        public DataTable DS()
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT MaNXB , TenNXB,Email,ThongTin FROM NXB 
                                        ";
            DataTable tb = data.GetData(cmd);

            return tb;
        }

        public int Them(NXB_DTO NXB)
        {
            DataAccess data = new DataAccess();

            string cmd = @"INSERT INTO  NXB(MaNXB,TenNXB ,Email, 
                                        ThongTin)
                                        VALUES(@manxb,@tennxb ,@email, @thongtin) ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@manxb",NXB.MaNXB),
                new SqlParameter("@tennxb",NXB.TenNXB),
                new SqlParameter("@email",NXB.EmailNXB),
                new SqlParameter("@thongtin",NXB.ThongTinNXB)
                
            };
            int result = data.AddData(cmd, parameter);
            return result;
        }

        public int Xoa(string MaNXB)
        {
            DataAccess data = new DataAccess();
            string cmd = @"DELETE FROM NXB WHERE MaNXB= @manxb                           
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@manxb",MaNXB)
            };
            return data.AddData(cmd, parameter);
        }

        public int Sua(NXB_DTO nxbDTO)
        {
            DataAccess data = new DataAccess();

            string cmd = @"UPDATE NXB SET ThongTin = @thongtin,TenNXB = @tennxb, Email = @email
                           
                           WHERE MaNXB = @manxb 
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
               new SqlParameter("@manxb",nxbDTO.MaNXB),
                new SqlParameter("@tennxb",nxbDTO.TenNXB),
                new SqlParameter("@thongtin",nxbDTO.ThongTinNXB),
                new SqlParameter("@email",nxbDTO.EmailNXB)
                
            };
            return data.AddData(cmd, parameter);
        }

    }
}
