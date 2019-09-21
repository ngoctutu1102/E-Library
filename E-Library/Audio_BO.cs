using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn1
{
    class Audio_BO
    {
        public DataTable DS()
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT* FROM AudioBook 
                                        ";
            DataTable tb = data.GetData(cmd);

            return tb;
        }

        public int Them(Audio_DTO Audio)
        {
            DataAccess data = new DataAccess();

            string cmd = @"INSERT INTO  AudioBook(MaAudio,TenSach, MaTG ,MaTL, MaNXB, NamXB, FileAudio, HinhAnh, DinhDang, DungLuong,ThoiLuong,MCAudio
                                        )
                                        VALUES(@MaAudio,@TenSach ,@MaTG, @MaTL,@MaNXB,@NamXB,@FileAudio,@HinhAnh,@DinhDang,@DungLuong,@ThoiLuong,@MCAudio) ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@MaAudio",Audio.MaAudio),
                new SqlParameter("@TenSach",Audio.TenSach),
                new SqlParameter("@MaTG",Audio.MaTG),
                new SqlParameter("@MaTL",Audio.MaTL),
                new SqlParameter("@MaNXB",Audio.MaNXB),
                new SqlParameter("@NamXB",Audio.NamXB),
                new SqlParameter("@FileAudio",Audio.FileAudio),
                new SqlParameter("@HinhAnh",Audio.HinhAnh),
                new SqlParameter("@DinhDang",Audio.DinhDang),
                new SqlParameter("@DungLuong",Audio.DungLuong),
                 new SqlParameter("@ThoiLuong",Audio.ThoiLuong),
                new SqlParameter("@MCAudio",Audio.MCAudio)

            };
            int result = data.AddData(cmd, parameter);
            return result;
        }

        public int Xoa(string MaAudio)
        {
            DataAccess data = new DataAccess();
            string cmd = @"DELETE FROM AudioBook WHERE MaAudio= @maaudio                          
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@maaudio",MaAudio)
            };
            return data.AddData(cmd, parameter);
        }

        public int Sua(Audio_DTO Audio)
        {
            DataAccess data = new DataAccess();

            string cmd = @"UPDATE AudioBook SET TenSach=@TenSach, MaTG=@MaTG ,MaTL=@MaTL, MaNXB=@MaNXB, NamXB=@NamXB, FileAudio=@FileAudio, HinhAnh=@HinhAnh, DinhDang=@DinhDang, DungLuong=@DungLuong,ThoiLuong=@ThoiLuong,MCAudio=@MCAudio
                           
                           WHERE MaAudio=@MaAudio
                           ";
            SqlParameter[] parameter = new SqlParameter[]
            {
               new SqlParameter("@MaAudio",Audio.MaAudio),
                new SqlParameter("@TenSach",Audio.TenSach),
                new SqlParameter("@MaTG",Audio.MaTG),
                new SqlParameter("@MaTL",Audio.MaTL),
                new SqlParameter("@MaNXB",Audio.MaNXB),
                new SqlParameter("@NamXB",Audio.NamXB),
                new SqlParameter("@FileAudio",Audio.FileAudio),
                new SqlParameter("@HinhAnh",Audio.HinhAnh),
                new SqlParameter("@DinhDang",Audio.DinhDang),
                new SqlParameter("@DungLuong",Audio.DungLuong),
                 new SqlParameter("@ThoiLuong",Audio.ThoiLuong),
                new SqlParameter("@MCAudio",Audio.MCAudio)

            };
            return data.AddData(cmd, parameter);
        }

        //
        public DataTable DSTheLoai(string TheLoai)
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT TenSach,NamXB,TenTG,TenTL,TenNXB,HinhAnh,FileAudio FROM AudioBook,TacGia,TheLoai,NXB
                            WHERE AudioBook.MaTL = @theloai and AudioBook.MaTG = TacGia.MaTG 
                            and AudioBook.MaTL=TheLoai.MaTL and AudioBook.MaNXB=NXB.MaNXB";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@theloai", TheLoai)
            };
            DataTable tb = data.GetData(cmd, parameter);

            return tb;
        }

        public DataTable TimKiem(string TenSach)
        {
            DataAccess data = new DataAccess();

            string cmd = @"SELECT TenSach,NamXB,TenTG,TenTL,TenNXB,HinhAnh,FileAudio FROM AudioBook,TacGia,TheLoai,NXB
                            WHERE AudioBook.TenSach = @tensach and AudioBook.MaTG = TacGia.MaTG 
                            and AudioBook.MaTL=TheLoai.MaTL and AudioBook.MaNXB=NXB.MaNXB";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@tensach", TenSach)
            };
            DataTable tb = data.GetData(cmd, parameter);

            return tb;
        }
    }
}
