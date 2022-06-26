create database QLBanHang
use QLBanHang

create table LoaiSanPham(
	MaLoai char(3) not null primary key,
	TenLoai nvarchar(50) not null
)

create table SanPham(
	MaSP char(4) not null primary key,
	TenSP nvarchar(50) not null,
	MaLoai char(3),
	SoLuong int,
	DonGia int
	foreign key (MaLoai) references LoaiSanPham(MaLoai)
)

insert into LoaiSanPham values
	(1, N'Quần'),
	(2, N'Áo')

insert into SanPham values
	(1, N'Quần dài',1,10, 100000),
	(2, N'Quần đùi',1,15, 80000),
	(3, N'Áo cộc',2,17, 40000),
	(4, N'Áo ba lỗ',2,20, 50000)


select * from LoaiSanPham
select * from SanPham