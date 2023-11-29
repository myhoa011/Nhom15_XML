drop database if exists dbQUANLYTHUETRANGPHUC
go
create database dbQUANLYTHUETRANGPHUC
go
use dbQUANLYTHUETRANGPHUC
go
CREATE TABLE NhanVien(
	MaNV varchar(30) primary key,
	TenNV nvarchar(50) NOT NULL,
	DiaChi nvarchar(200) NOT NULL,
	SDT varchar(10) NOT NULL,
	Email varchar(50) NOT NULL
)
go
CREATE TABLE TaiKhoan(
	MaNV varchar(30) PRIMARY KEY,
	MatKhau varchar(50) NOT NULL,
	Quyen int NOT NULL,
	CONSTRAINT FK_NVTK FOREIGN KEY (maNV) REFERENCES NhanVien(maNV)
	on update cascade
	on delete cascade
)
go
CREATE TABLE DanhMuc(
	MaDM int primary key,
	TenDM nvarchar(50) NOT NULL
)

CREATE TABLE TrangPhuc(
	MaTP varchar(30) primary key,
	TenTP nvarchar(50) NOT NULL,
	donGia int NULL,
	soLuong int NULL,
	MaDM int CONSTRAINT FK_DMTP FOREIGN KEY REFERENCES DanhMuc(MaDM)
	on update cascade
	on delete cascade 
)

go
CREATE TABLE HoaDon(
	MaHD varchar(30) ,
	MaNV varchar(30) NOT NULL 
	CONSTRAINT FK_NVHD FOREIGN KEY REFERENCES NhanVien(MaNV)
	on update cascade
	on delete cascade,
	TenKH nvarchar(50) NOT NULL,
	NgayTao nvarchar(25) NULL,
	NgayThue nvarchar(25) NULL,
	NgayTra nvarchar(25) NULL,
	TongTien int NULL,
	CONSTRAINT PK_HoaDon PRIMARY KEY (MaHD)
)

go
CREATE TABLE ChiTietHoaDon(
	maDH varchar(30)  not null CONSTRAINT FK_DH FOREIGN KEY REFERENCES HoaDon(MaHD)
	on update cascade
	on delete cascade,
	MaTP varchar(30)  not null CONSTRAINT FK_SPDH FOREIGN KEY REFERENCES TrangPhuc(MaTP)
	on update cascade
	on delete cascade,
	soLuongDat int not null
		CONSTRAINT check_SoLuongDat check(soLuongDat >=0 ),
	donGia money  not null
		CONSTRAINT check_DonGia check( donGia>=0),
	PRIMARY KEY (maDH, MaTP)
)
go
INSERT INTO DanhMuc values
(1, N'Trang phục trẻ em'),
(2, N'Trang phục người lớn')
go
INSERT INTO TrangPhuc values
('TP01', N'Trang phục dân tộc Thái', 100000, 20, 2),
('TP02', N'Trang phục dân tộc Mường', 120000, 15, 2),
('TP03', N'Trang phục áo bà ba', 50000, 30, 2),
('TP04', N'Áo cử nhân mầm non', 80000, 10, 1),
('TP05', N'Áo dài trẻ em', 100000, 12, 1)
go
INSERT INTO NhanVien values
('NV01', N'Lê Văn A', N'34 Điện Biên Phủ', '0123456789', 'myhoa@gmail.com'),
('NV02', N'Nguyễn Ngọc B', N'50 Phan Thanh', '0258963147', 'camly@gmail.com'),
('NV03', N'Võ Bích C', N'48 Cao Thắng', '0123654789', 'bichtram@gmail.com')
go
INSERT INTO TaiKhoan values
('NV01', '123', 1),
('NV02', '321', 1),
('NV03', '321', 2)
go
INSERT INTO HoaDon values
('HD01', 'NV02', N'Đặng Thị Mỹ Hòa', '21/11/2023', '21/11/2023', '24/11/2023', 800000)
go
INSERT INTO ChiTietHoaDon values
('HD01', 'TP02', 5, 120000),
('HD01', 'TP01', 2, 100000)
