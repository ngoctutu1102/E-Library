USE [DoAn1_QLThuVien]
GO
ALTER TABLE [dbo].[EBook] DROP CONSTRAINT [FK_EBook_TheLoai]
GO
ALTER TABLE [dbo].[EBook] DROP CONSTRAINT [FK_EBook_TacGia]
GO
ALTER TABLE [dbo].[EBook] DROP CONSTRAINT [FK_EBook_NXB]
GO
ALTER TABLE [dbo].[AudioBook] DROP CONSTRAINT [FK_AudioBook_TheLoai]
GO
ALTER TABLE [dbo].[AudioBook] DROP CONSTRAINT [FK_AudioBook_TacGia]
GO
ALTER TABLE [dbo].[AudioBook] DROP CONSTRAINT [FK_AudioBook_NXB]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 12/14/2018 6:20:32 PM ******/
DROP TABLE [dbo].[TheLoai]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 12/14/2018 6:20:32 PM ******/
DROP TABLE [dbo].[TacGia]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 12/14/2018 6:20:32 PM ******/
DROP TABLE [dbo].[NXB]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/14/2018 6:20:32 PM ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[EBook]    Script Date: 12/14/2018 6:20:32 PM ******/
DROP TABLE [dbo].[EBook]
GO
/****** Object:  Table [dbo].[AudioBook]    Script Date: 12/14/2018 6:20:32 PM ******/
DROP TABLE [dbo].[AudioBook]
GO
/****** Object:  Table [dbo].[AudioBook]    Script Date: 12/14/2018 6:20:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AudioBook](
	[MaAudio] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](100) NULL,
	[MaTG] [nchar](10) NOT NULL,
	[MaTL] [nchar](10) NOT NULL,
	[MaNXB] [nchar](10) NOT NULL,
	[NamXB] [nchar](10) NULL,
	[FileAudio] [nvarchar](max) NOT NULL,
	[HinhAnh] [nvarchar](max) NOT NULL,
	[DinhDang] [nchar](10) NULL,
	[DungLuong] [nchar](10) NULL,
	[ThoiLuong] [nchar](10) NULL,
	[MCAudio] [nchar](20) NULL,
 CONSTRAINT [PK_AudioBook] PRIMARY KEY CLUSTERED 
(
	[MaAudio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EBook]    Script Date: 12/14/2018 6:20:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EBook](
	[MaEbook] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[MaTG] [nchar](10) NOT NULL,
	[MaTL] [nchar](10) NOT NULL,
	[MaNXB] [nchar](10) NOT NULL,
	[NamXB] [nchar](10) NULL,
	[FilePDF] [nvarchar](max) NOT NULL,
	[DinhDang] [nchar](10) NOT NULL,
	[DungLuong] [nchar](10) NULL,
	[HinhAnh] [nvarchar](max) NULL,
 CONSTRAINT [PK_EBook] PRIMARY KEY CLUSTERED 
(
	[MaEbook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/14/2018 6:20:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nchar](100) NOT NULL,
	[SDT] [nchar](20) NOT NULL,
	[UserNV] [nchar](50) NOT NULL,
	[PassNV] [nchar](20) NOT NULL,
	[ThongTin] [text] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 12/14/2018 6:20:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nchar](100) NOT NULL,
	[Email] [nchar](100) NOT NULL,
	[Thongtin] [text] NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 12/14/2018 6:20:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [nchar](10) NOT NULL,
	[TenTG] [nchar](50) NOT NULL,
	[TieuSu] [text] NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 12/14/2018 6:20:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTL] [nchar](10) NOT NULL,
	[TenTL] [nchar](100) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AudioBook] ([MaAudio], [TenSach], [MaTG], [MaTL], [MaNXB], [NamXB], [FileAudio], [HinhAnh], [DinhDang], [DungLuong], [ThoiLuong], [MCAudio]) VALUES (N'A01       ', N'Cô gái đến từ hôm qua', N'TG01      ', N'TL01      ', N'NXB01     ', N'2007      ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Cô gái đến từ hôm qua - C1.2 - Ý đồ đen tối.mp3', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\co-gai-den-tu-hom-qua-nguyen-nhat-anh.jpg', N'mp3       ', N'9MB       ', N'13p       ', N'MC                  ')
INSERT [dbo].[AudioBook] ([MaAudio], [TenSach], [MaTG], [MaTL], [MaNXB], [NamXB], [FileAudio], [HinhAnh], [DinhDang], [DungLuong], [ThoiLuong], [MCAudio]) VALUES (N'A02       ', N'Hương Mật Tựa Khói Sương', N'TG14      ', N'TL01      ', N'NXB04     ', N'2010      ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Hương Mật Tựa Khói Sương - Chương 3&4.mp3', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\huong-mat-tua-khoi-suong.jpg', N'mp3       ', N'20MB      ', N'22p       ', N'MC                  ')
INSERT [dbo].[EBook] ([MaEbook], [TenSach], [MaTG], [MaTL], [MaNXB], [NamXB], [FilePDF], [DinhDang], [DungLuong], [HinhAnh]) VALUES (N'E01       ', N'Bảy bước đến mùa hè', N'TG01      ', N'TL01      ', N'NXB01     ', N'2015      ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Bay-buoc-toi-mua-he-nguyen-nhat-anh.pdf', N'pdf       ', N'170       ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\bay-buoc-toi-mua-he.jpg')
INSERT [dbo].[EBook] ([MaEbook], [TenSach], [MaTG], [MaTL], [MaNXB], [NamXB], [FilePDF], [DinhDang], [DungLuong], [HinhAnh]) VALUES (N'E02       ', N'Bên Nhau Trọn Đời', N'TG11      ', N'TL01      ', N'NXB02     ', N'2014      ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Ben-nhau-tron-doi.pdf', N'PDF       ', N'171       ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Ben-nhau-tron-doi.jpg')
INSERT [dbo].[EBook] ([MaEbook], [TenSach], [MaTG], [MaTL], [MaNXB], [NamXB], [FilePDF], [DinhDang], [DungLuong], [HinhAnh]) VALUES (N'E03       ', N'Đắc Nhân Tâm', N'TG02      ', N'TL04      ', N'NXB01     ', N'2013      ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Dac-Nhan-Tam.pdf', N'PDF       ', N'322       ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Dac-nhan-tam.jpg')
INSERT [dbo].[EBook] ([MaEbook], [TenSach], [MaTG], [MaTL], [MaNXB], [NamXB], [FilePDF], [DinhDang], [DungLuong], [HinhAnh]) VALUES (N'E04       ', N'Ngữ Pháp Tiếng Hàn', N'TG16      ', N'TL08      ', N'NXB09     ', N'2012      ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\Ngu-phap-tieng-han-co-ban.pdf', N'PDF       ', N'202       ', N'D:\1. FHQ 16110CL6\Học Kỳ 5\Đồ Án 1\ThuVienDienTu\file_goc_773353-1.png')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [UserNV], [PassNV], [ThongTin]) VALUES (N'NV01      ', N'PhamThiHa                                                                                           ', N'0123456789          ', N'HaPham                                            ', N'123456              ', N'phamha@gmail.com')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [UserNV], [PassNV], [ThongTin]) VALUES (N'NV02      ', N'NgocTuTu                                                                                            ', N'01234140698         ', N'tutu1102                                          ', N'123456              ', N'ngoctutu1102@gmail.com')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB01     ', N'NXB Trẻ                                                                                             ', N'nxbtre@gmail.com                                                                                    ', N'Q1,TP HCM')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB02     ', N'Bách Việt Books                                                                                     ', N'http://bachvietbooks.com.vn/                                                                        ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB03     ', N'NXB Kim Đồng                                                                                        ', N'cnkimdong@nxbkimdong.com.vn                                                                         ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB04     ', N'CTY Cổ Phần Văn Việt                                                                                ', N'thongtincongtyvn@gmail.com                                                                          ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB05     ', N'Alpha Books                                                                                         ', N'info@alphabooks.vn                                                                                  ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB06     ', N' Nhã Nam                                                                                            ', N'info@nhanam.vn                                                                                      ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB07     ', N'DinhTiBooks                                                                                         ', N'info@dinhtibooks.com.vn                                                                             ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB08     ', N'NXB Văn Học                                                                                         ', N'tonghopvanhoc@vnn.vn                                                                                ', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [Email], [Thongtin]) VALUES (N'NXB09     ', N'Đang Cập Nhật                                                                                       ', N'#####                                                                                               ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG01      ', N'Nguyễn Ngọc Ánh                                   ', N'')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG02      ', N'Dale Carnegie                                     ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG03      ', N'Nguyên Hồng                                       ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG04      ', N'Tô Hoài                                           ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG05      ', N'Huyền Lê                                          ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG06      ', N'Đào Duy Anh                                       ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG07      ', N'Fujiko F.Fujio                                    ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG08      ', N'Robin Sharma                                      ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG09      ', N'Alan Phan                                         ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG10      ', N'Max H.Bazerman                                    ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG11      ', N'Cố Mạn                                            ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG12      ', N'Ngô Thừa Ân                                       ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG13      ', N'Cecil B.Currey                                    ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG14      ', N'Điện Tuyến                                        ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG15      ', N'Nhiều Tác Giả                                     ', NULL)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [TieuSu]) VALUES (N'TG16      ', N'Đang Cập Nhật                                     ', NULL)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL01      ', N'Văn Học                                                                                             ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL02      ', N'Kinh Tế                                                                                             ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL03      ', N'Chuyên Nghành                                                                                       ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL04      ', N'Kỹ Năng Sống                                                                                        ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL05      ', N'Thiếu Nhi                                                                                           ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL06      ', N'Văn Hóa - Nghệ Thuật                                                                                ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL07      ', N'Truyện Tranh                                                                                        ')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL08      ', N'Ngoại Ngữ                                                                                           ')
ALTER TABLE [dbo].[AudioBook]  WITH CHECK ADD  CONSTRAINT [FK_AudioBook_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[AudioBook] CHECK CONSTRAINT [FK_AudioBook_NXB]
GO
ALTER TABLE [dbo].[AudioBook]  WITH CHECK ADD  CONSTRAINT [FK_AudioBook_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[AudioBook] CHECK CONSTRAINT [FK_AudioBook_TacGia]
GO
ALTER TABLE [dbo].[AudioBook]  WITH CHECK ADD  CONSTRAINT [FK_AudioBook_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[AudioBook] CHECK CONSTRAINT [FK_AudioBook_TheLoai]
GO
ALTER TABLE [dbo].[EBook]  WITH CHECK ADD  CONSTRAINT [FK_EBook_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[EBook] CHECK CONSTRAINT [FK_EBook_NXB]
GO
ALTER TABLE [dbo].[EBook]  WITH CHECK ADD  CONSTRAINT [FK_EBook_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[EBook] CHECK CONSTRAINT [FK_EBook_TacGia]
GO
ALTER TABLE [dbo].[EBook]  WITH CHECK ADD  CONSTRAINT [FK_EBook_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[EBook] CHECK CONSTRAINT [FK_EBook_TheLoai]
GO
