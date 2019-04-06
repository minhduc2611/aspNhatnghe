
SELECT MaHH, TenHH, TenLoai, TenCongTy, DonGia
FROM vHangHoa
WHERE DonGia BETWEEN 100 AND 1000

--Lấy hàng hóa chứa chữ ani
SELECT MaHH, TenHH, TenLoai, TenCongTy, DonGia
FROM vHangHoa
WHERE TenHH LIKE N'%ani%'


--Tạo view xem chi tiết hóa đơn
--ALTER : sửa
--CREATE VIEW vHoaDon AS
ALTER VIEW vHoaDon AS
SELECT cthd.*, TenHH, MoTaDonVi,
	cthd.DonGia * SoLuong as ThanhTien,
	hh.MaLoai, TenCongTy as NhaCungCap
FROM ChiTietHD cthd JOIN HangHoa hh ON cthd.MaHH = hh.MaHH
		JOIN Loai lo ON lo.MaLoai = hh.MaLoai
		JOIN NhaCungCap ncc ON ncc.MaNCC = hh.MaNCC

--Demo
SELECT * FROM vHoaDon WHERE MaHD = 10248

------------------STORE PROCEDURE---------------
--Viết store lấy hàng hóa theo loại và nhà cung cấp
CREATE PROC spLayHangHoa
	@MaLoai int, @MaNCC nvarchar(50)
AS BEGIN
	SELECT * FROM vHangHoa
	WHERE MaLoai = @MaLoai AND MaNCC = @MaNCC
END

--Demo trong SQL Server
EXEC spLayHangHoa 1001, 'NK'
EXECUTE spLayHangHoa 1002, 'SS'

--Viết store Thêm loại
CREATE PROC spThemLoai
	@MaLoai int OUTPUT,
	@TenLoai nvarchar(50),
	@Hinh nvarchar(50),
	@MoTa nvarchar(MAX)
AS BEGIN
	--Thêm
	INSERT INTO Loai(TenLoai, MoTa, Hinh)
		VALUES(@TenLoai, @MoTa, @Hinh)
	--Lấy giá trị vừa tăng
	SELECT @MaLoai = @@IDENTITY
END

--DEMO
DECLARE @Ma int
EXEC spThemLoai @Ma output, N'Xe máy điện', NULL, NULL
PRINT CONCAT(N'Vừa thêm loại có mã: ', @Ma)

---Lấy hàng hóa gần đúng theo tên hoặc mô tả
CREATE PROC spTimHangHoa
	@TuKhoa nvarchar(50)
AS BEGIN
	SELECT * FROM vHangHoa
	WHERE TenHH LIKE N'%' + @TuKhoa  + N'%'
		OR MoTa LIKE N'%' + @TuKhoa  + N'%'
END

--Demo
EXEC spTimHangHoa N'en'


--------FUNCTION-----
--Viết hàm tính doanh thu theo hàng hóa
CREATE FUNCTION fTinhDoanhThu
( 
	@MaHH int
)
RETURNS float
AS BEGIN
	--1. Khai báo biến giữ kết quả trả về
	DECLARE @Tong float
	--2. Tính toán
	SELECT @Tong = SUM(SoLuong * DonGia * (1 - GiamGia))
	FROM ChiTietHD WHERE MaHH = @MaHH
	--3. Trả về
	RETURN @Tong
END

--DEMO
SELECT dbo.fTinhDoanhThu(1001) --Lấy cho 1 hàng hóa có mã 1001
--lấy doanh thu của hàng hóa
SELECT hh.*, dbo.fTinhDoanhThu(MaHH) as TongDoanhThu
FROM vHangHoa hh


--Viết hàm tính doanh thu theo khách hàng từ ngày ... đến ngày
CREATE FUNCTION fTinhDoanhThuTheoKhachHang
( 
	@MaKH nvarchar(20),
	@TuNgay datetime,
	@DenNgay datetime
)
RETURNS float
AS BEGIN
	--1. Khai báo biến giữ kết quả trả về
	DECLARE @Tong float
	--2. Tính toán
	SELECT @Tong = SUM(SoLuong * DonGia * (1 - GiamGia))
	FROM ChiTietHD cthd JOIN HoaDon hd ON hd.MaHD = cthd.MaHD
	WHERE MaKH = @MaKH AND NgayDat BETWEEN @TuNgay AND @DenNgay
	--3. Trả về
	RETURN @Tong
END

--Demo lấy doanh thu của ANTON
SELECT dbo.fTinhDoanhThuTheoKhachHang(N'ANTON', 
					'1990-01-01', getdate())

-------------TRIGGER
--Viết trigger tự động tính tổng tiền hóa đơn khi
--thêm/xóa/sửa chi tiết hóa đơn

CREATE TRIGGER trgCapNhatTongTienHoaDon
	ON ChiTietHD AFTER INSERT, UPDATE, DELETE
AS BEGIN
	DECLARE @MaHD int;
	DECLARE @Tong float;
	--Lấy mã hóa đơn từ bảng Inserted hay Deleted
	WITH BangTam AS
	(
		SELECT MaHD FROM inserted
		UNION
		SELECT MaHD FROM deleted
	)

	SELECT @MaHD = MaHD FROM BangTam

	SELECT @Tong = SUM(SoLuong * DonGia * (1 - GiamGia))
	FROM ChiTietHD WHERE MaHD = @MaHD

	--cập nhật
	UPDATE HoaDon SET TongTien = @Tong
	WHERE MaHD = @MaHD
END
