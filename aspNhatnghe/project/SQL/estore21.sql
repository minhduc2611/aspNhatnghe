USE [eStore20]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/21/2019 8:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 5/21/2019 8:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHh] [int] IDENTITY(1,1) NOT NULL,
	[TenHh] [nvarchar](50) NOT NULL,
	[Hinh] [nvarchar](150) NULL,
	[MoTa] [nvarchar](max) NULL,
	[DonGia] [float] NOT NULL,
	[GiamGia] [tinyint] NOT NULL,
	[MaLoai] [int] NOT NULL,
	[TenKhongDau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 5/21/2019 8:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Hinh] [nvarchar](max) NULL,
	[MaLoaiCha] [int] NOT NULL,
	[TenKhongDau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanQua]    Script Date: 5/21/2019 8:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanQua](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaQT] [int] NOT NULL,
	[MaHh] [int] NOT NULL,
	[MaKh] [nvarchar](max) NULL,
	[NgayNhan] [datetime2](7) NULL,
 CONSTRAINT [PK_NhanQua] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTang]    Script Date: 5/21/2019 8:58:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTang](
	[QuaTangId] [int] IDENTITY(1,1) NOT NULL,
	[TenQua] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[HanDung] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_QuaTang] PRIMARY KEY CLUSTERED 
(
	[QuaTangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190514121054_AddLoai', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190514121640_UpdateLoai', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190516112344_AddHangHoa', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190517034531_quatang', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190521120104_TenKhongDau', N'2.1.11-servicing-32099')
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (1, N'Carson Carrington Dragon', N'Palm-Canyon-Diana-Contemporary-Light-Brown-Wood-Nightstand-3f3413ff-c978-4124-958f-4fa400556fc5_600.jpg', N'The nightstand combines function and modern style. On a geometric silhouette, this oak veneered nightstand features two drawers with black triangle vinyl handles. The angled legs in black, supporting the nightstand while contrasting with the oak veneered finishing showcase the modern look. Constructed of engineered wood, the nightstand is built to last. The bedside table comes with two drawers for storing your bedroom essentials. The under clearance area allows you to dust as often to keep the area clean', 206258380, 20, 10, N'Carson-Carrington-Dragon')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (2, N'Thumbnail Simple Living ', N'Simple-Living-Crislana-Night-Stand-c2ad906e-6a08-41e4-8075-42aac0f31d33_600.jpg', N'Offer a contemporary urban look to your bedroom with this posh little nightstand. The sleek white exterior is sharply contrasted by the grey drawer fronts for a modern vibe. Store books and other bedside essentials in the two large drawers. Crafted of laminated particle board and solid wood legs, the night stand sits on top of contrasting black legs, which are angled outward for retro flair', 235151826, 23, 4, N'thumbnail-simple-living ')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (3, N'Simple Living Crislana', N'SimpleLivingCrislana.jpg', N'Give your decor a chic flair with this elegant chest. Four drawers provide ample room for clothes, bedding, and more. Featuring grey faux-concrete drawer fronts, clean lines, a sleek white exterior, and black legs and pulls, the chest provides a sophisticated addition to any space.', 491371790, 12, 4, N'simple-living-crislana')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (4, N' Nook Dining Set', N'NookDiningSet.jpg', N' Includes: One (1) Table, Two (2) Loveseat, and One (1) Corner Chair Grey or Blue or two-tone Beige fabric upholstery Leg finish: Walnut Materials: Solid Rubberwood, MDF, fabric, foam Loveseat seat dimensions: 16.5 inches high x 40.5 inches wide x 19 inches deep', 1930914476, 21, 4, N' nook-dining-set')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (5, N'The Gray Barn Latigo', N'TheGrayBarnLatigo.jpg', N'Vintage design with a bronze metal finish Includes metal slats and center supports legs Accommodates standard mattress 2 base-height options for your convenience 7 inch or 11 inch clearance under bed Foundation not required', 12312342, 12, 5, N'the-gray-barn-latigo')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (6, N'Giselle Antique Graceful Dark ', N'GiselleAntiqueGracefulDark.jpg', N'Constructed of sturdy iron Set includes headboard, footboard, set of rails, 3 metal slats Antique bronze finish', 35234523, 34, 5, N'giselle-antique-graceful-dark ')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [GiamGia], [MaLoai], [TenKhongDau]) VALUES (7, N'Metal Bed iNSPIRE', N'MetalBediNSPIRE.jpg', N'Give your decor a chic flair with this elegant chest. Four drawers provide ample room for clothes, bedding, and more. Featuring grey faux-concrete drawer fronts, clean lines, a sleek white exterior, and black legs and pulls, the chest provides a sophisticated addition to any space.', 1930914476, 32, 4, N'metal-bed-inspire')
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (1, N'Home Furniture', N'Home', N'Home', 0, N'Home-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (2, N'WorkPlace Furniture', N'work', N'work', 0, N'WorkPlace-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (3, N'School Furniture', N'School', N'School', 0, N'School-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (4, N'Living Room Furniture', N'livingroom', N'li.pjs', 1, N'Living-Room-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (5, N'Bedroom Furniture', N'Bedroom Furniture', N'Bedroom Furniture', 1, N'Bedroom-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (6, N'Dining Room Furniture', N'Dining Room Furniture', N'Dining Room Furniture', 1, N'Dining-Room-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (7, N'Kitchen Furniture', N'Kitchen Furniture', N'Kitchen Furniture', 1, N'Kitchen-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (8, N'Baby Furniture', N'Baby Furniture', N'Baby Furniture', 1, N'Baby-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (9, N'Desk', N'Desks', N'Desks', 2, N'Desk')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (10, N'Chairs & Seating', N'Chairs & Seating', N'Chairs & Seating', 2, N'Chairs-Seating')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (11, N'Boardroom Furniture', N'Boardroom Furniture', N'Boardroom Furniture', 2, N'Boardroom-Furniture')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (12, N'Storage', N'Storage', N'Storage', 2, N'Storage')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (13, N'Desks', N'desks', N'desks', 3, N'desks')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha], [TenKhongDau]) VALUES (14, N'Chairs', N'chairs', N'chairs', 3, N'chairs')
SET IDENTITY_INSERT [dbo].[Loai] OFF
ALTER TABLE [dbo].[HangHoa] ADD  DEFAULT (N'') FOR [TenKhongDau]
GO
ALTER TABLE [dbo].[Loai] ADD  DEFAULT (N'') FOR [TenKhongDau]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_Loai_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_Loai_MaLoai]
GO
ALTER TABLE [dbo].[NhanQua]  WITH CHECK ADD  CONSTRAINT [FK_NhanQua_HangHoa_MaHh] FOREIGN KEY([MaHh])
REFERENCES [dbo].[HangHoa] ([MaHh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanQua] CHECK CONSTRAINT [FK_NhanQua_HangHoa_MaHh]
GO
ALTER TABLE [dbo].[NhanQua]  WITH CHECK ADD  CONSTRAINT [FK_NhanQua_QuaTang_MaQT] FOREIGN KEY([MaQT])
REFERENCES [dbo].[QuaTang] ([QuaTangId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanQua] CHECK CONSTRAINT [FK_NhanQua_QuaTang_MaQT]
GO
