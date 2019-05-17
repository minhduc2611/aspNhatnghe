USE [eStore20]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190514121054_AddLoai', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190514121640_UpdateLoai', N'2.1.4-rtm-31024')
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (1, N'Home Furniture', N'Home', N'Home', 0)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (2, N'WorkPlace Furniture', N'work', N'work', 0)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (3, N'School Furniture', N'School', N'School', 0)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (4, N'Living Room Furniture', N'livingroom', N'li.pjs', 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (5, N'Bedroom Furniture', N'Bedroom Furniture', N'Bedroom Furniture', 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (6, N'Dining Room Furniture', N'Dining Room Furniture', N'Dining Room Furniture', 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (7, N'Kitchen Furniture', N'Kitchen Furniture', N'Kitchen Furniture', 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (8, N'Baby Furniture', N'Baby Furniture', N'Baby Furniture', 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (9, N'Desk', N'Desks', N'Desks', 2)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (10, N'Chairs & Seating', N'Chairs & Seating', N'Chairs & Seating', 2)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (11, N'Boardroom Furniture', N'Boardroom Furniture', N'Boardroom Furniture', 2)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (12, N'Storage', N'Storage', N'Storage', 2)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (13, N'desks', N'desks', N'desks', 3)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (14, N'chairs', N'chairs', N'chairs', 3)
SET IDENTITY_INSERT [dbo].[Loai] OFF
