USE [eStore20]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190514121054_AddLoai', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190514121640_UpdateLoai', N'2.1.4-rtm-31024')
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (6, N'Living Room Furniture', N'livingroom', N'li.pjs', 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (7, N'Bedroom Furniture', N'Bedroom Furniture', N'Bedroom Furniture', 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (9, N'Home Furniture', N'Home', N'Home', 0)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (11, N'WorkPlace Furniture', N'work', N'work', 0)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (12, N'School Furniture', N'School', N'School', 0)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (13, N'Dining Room Furniture', N'Dining Room Furniture', N'Dining Room Furniture', 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (14, N'Kitchen Furniture', N'Kitchen Furniture', N'Kitchen Furniture', 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (15, N'Baby Furniture', N'Baby Furniture', N'Baby Furniture', 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (17, N'Desk', N'Desks', N'Desks', 11)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (18, N'Chairs & Seating', N'Chairs & Seating', N'Chairs & Seating', 11)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (19, N'Boardroom Furniture', N'Boardroom Furniture', N'Boardroom Furniture', 11)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (20, N'Storage', N'Storage', N'Storage', 11)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (21, N'desks', N'desks', N'desks', 12)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (22, N'chairs', N'chairs', N'chairs', 12)
SET IDENTITY_INSERT [dbo].[Loai] OFF
