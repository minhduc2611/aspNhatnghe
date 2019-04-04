-- chon batabase lam viec

USE QLnhanvien;

-- them moi don vi

INSERT INTO DonVi(Ma_Don_vi,Ten_Don_vi) VALUES ('PHCNS',N'Phong Hanh chinh nhan su')

--lay danh sach don vi 

SELECT * FROM DonVi;


-- them nhan vien 

INSERT INTO NhanVien (Ho_Ten, Gioi_Tinh, CMND, Ngay_Sinh, Luong, Ma_Don_vi) VALUES (N'Pham Kim Oanh', 'false', '321465654','1974-09-15', '30000000' ,'PHCNS' )
SELECT * FROM NhanVien;

-- lay nhan vien nu (giotinh = false) co luong >20tr
SELECT Ma_Nhan_Vien, Ho_Ten,Luong ,Ma_Don_vi,
 YEAR(GETDATE())- YEAR(Ngay_Sinh) as Tuoi
 FROM NhanVien
 WHERE Gioi_Tinh = 'false' AND Luong > 0


 -- Tim nhan vien co chu "Le"

 SELECT *
 FROM  NhanVien
 WHERE Ho_Ten LIKE N'Le%'


  -- Tim nhan vien co chu "Le"

 SELECT  Ma_Nhan_Vien, Ho_Ten,Luong ,NV.Ma_Don_vi , Ten_Don_vi
 FROM  NhanVien as NV JOIN DonVi as DV
	ON NV.Ma_Don_vi = DV.Ma_Don_vi
 WHERE Ho_Ten LIKE N'Le%'


 -- vi du ve gom nhom , THONG KE 

 SELECT
		MAX(Luong) as Luong_Lon_Nhat,
		AVG( YEAR(GETDATE())-YEAR(Ngay_Sinh) ) as Tuoi_Trung_Binh,
		COUNT(*) as So_Luong_Nhan_Vien
 From NhanVien

  -- vi du ve gom nhieu nhom hon , THONG KE , chi lay "tuoi trung binh" <40

 SELECT
		MAX(Luong) as Luong_Lon_Nhat,
		AVG( YEAR(GETDATE())-YEAR(Ngay_Sinh) ) as Tuoi_Trung_Binh,
		COUNT(*) as So_Luong_Nhan_Vien
 From NhanVien
 GROUP BY Ma_Don_vi -- dua theo tung ma don vi
 HAVING AVG( YEAR(GETDATE())-YEAR(Ngay_Sinh) ) <40 -- having dung cho gom nhom
