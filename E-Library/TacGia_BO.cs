using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1
{
    class TacGia_BO
    {
        public DataTable DS()
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT* FROM TacGia
                                        ";
            DataTable tb = data.GetData(cmd);

            return tb;
        }

        public int Them(TacGia_DTO tgDTO)
        {
            DataAccess data = new DataAccess();

            string cmd = @"INSERT INTO  TacGia(MaTG,TenTG,TieuSu)
                                        VALUES(@matg,@tentg,@tieusu ) ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@matg",tgDTO.MaTG),
                new SqlParameter("@tentg",tgDTO.TenTG),
                new SqlParameter("@tieusu",tgDTO.TieuSu)

            };
            int result = data.AddData(cmd, parameter);
            return result;
        }

        public int Xoa(string MaTG)
        {
            DataAccess data = new DataAccess();
            string cmd = @"DELETE FROM TacGia WHERE MaTG= @matg                           
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@matg",MaTG)
            };
            return data.AddData(cmd, parameter);
        }

        public int Sua(TacGia_DTO tgDTO)
        {
            DataAccess data = new DataAccess();

            string cmd = @"UPDATE TacGia SET TenTG = @tentg, TieuSu=@tieusu
                           
                           WHERE MaTG = @matg  ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@matg",tgDTO.MaTG),
               new SqlParameter("@tentg",tgDTO.TenTG),
                new SqlParameter("@tieusu",tgDTO.TieuSu)



            };
            return data.AddData(cmd, parameter);
        }
    }
}
