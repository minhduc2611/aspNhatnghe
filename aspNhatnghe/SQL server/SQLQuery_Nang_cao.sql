/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (10) [MaHD] 
      ,[MaKH]
      ,[TongTien]
  FROM [eStore20].[dbo].[HoaDon]

  select MaHD,MaKH,TongTien
  FROM HoaDon
  WHERE MaHD = 10248