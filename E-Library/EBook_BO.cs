using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1
{
    class EBook_BO
    {
        public DataTable DS()
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT* FROM EBook 
                                        ";
            DataTable tb = data.GetData(cmd);

            return tb;
        }

        public int Them(EBook_DTO Ebook)
        {
            DataAccess data = new DataAccess();

            string cmd = @"INSERT INTO  EBook(MaEbook,TenSach, MaTG ,MaTL, MaNXB, NamXB, FilePDF, HinhAnh, DinhDang, DungLuong
                                        )
                                        VALUES(@MaEbook,@TenSach ,@MaTG, @MaTL,@MaNXB,@NamXB,@FilePDF,@HinhAnh,@DinhDang,@DungLuong) ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@MaEbook",Ebook.MaEbook),
                new SqlParameter("@TenSach",Ebook.TenSach),
                new SqlParameter("@MaTG",Ebook.MaTG),
                new SqlParameter("@MaTL",Ebook.MaTL),
                new SqlParameter("@MaNXB",Ebook.MaNXB),
                new SqlParameter("@NamXB",Ebook.NamXB),
                new SqlParameter("@FilePDF",Ebook.FilePDF),
                new SqlParameter("@HinhAnh",Ebook.HinhAnh),
                new SqlParameter("@DinhDang",Ebook.DinhDang),
                new SqlParameter("@DungLuong",Ebook.DungLuong)
                

            };
            int result = data.AddData(cmd, parameter);
            return result;
        }

        public int Xoa(string MaEbook)
        {
            DataAccess data = new DataAccess();
            string cmd = @"DELETE FROM EBook WHERE MaEbook= @maebook                           
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@maebook",MaEbook)
            };
            return data.AddData(cmd, parameter);
        }

        public int Sua(EBook_DTO Ebook)
        {
            DataAccess data = new DataAccess();

            string cmd = @"UPDATE EBook SET TenSach=@TenSach, MaTG=@MaTG ,MaTL=@MaTL, MaNXB=@MaNXB, NamXB=@NamXB, FilePDF=@FilePDF, HinhAnh=@HinhAnh, DinhDang=@DinhDang, DungLuong=@DungLuong
                           
                           WHERE MaEbook=@MaEbook
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
               new SqlParameter("@MaEbook",Ebook.MaEbook),
                new SqlParameter("@TenSach",Ebook.TenSach),
                new SqlParameter("@MaTG",Ebook.MaTG),
                new SqlParameter("@MaTL",Ebook.MaTL),
                new SqlParameter("@MaNXB",Ebook.MaNXB),
                new SqlParameter("@NamXB",Ebook.NamXB),
                new SqlParameter("@FilePDF",Ebook.FilePDF),
                new SqlParameter("@HinhAnh",Ebook.HinhAnh),
                new SqlParameter("@DinhDang",Ebook.DinhDang),
                new SqlParameter("@DungLuong",Ebook.DungLuong)

            };
            return data.AddData(cmd, parameter);
        }


        //
        public DataTable DSTheLoai(string TheLoai)
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT TenSach,NamXB,TenTG,TenTL,TenNXB,HinhAnh,FilePDF FROM EBook,TacGia,TheLoai,NXB
                            WHERE EBook.MaTL = @theloai and EBook.MaTG = TacGia.MaTG 
                            and EBook.MaTL=TheLoai.MaTL and EBook.MaNXB=NXB.MaNXB";
            
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@theloai", TheLoai)
            };
            DataTable tb = data.GetData(cmd, parameter);

            return tb;
        }


        //Tìm kiếm
        public DataTable TimKiem(string TenSach)
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT TenSach,NamXB,TenTG,TenTL,TenNXB,HinhAnh,FilePDF FROM EBook,TacGia,TheLoai,NXB
                            WHERE EBook.TenSach= @tensach and EBook.MaTG = TacGia.MaTG 
                            and EBook.MaTL=TheLoai.MaTL and EBook.MaNXB=NXB.MaNXB";
            

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@tensach", TenSach)
            };
            DataTable tb = data.GetData(cmd, parameter);

            return tb;
        }
    }
}
