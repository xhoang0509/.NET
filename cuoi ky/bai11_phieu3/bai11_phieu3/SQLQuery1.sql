create database QuanLyDanhMucSanPham
use QuanLyDanhMucSanPham
go

create table LoaiSanPham(
	MaLoaiSanPham int not null primary key,
	TenLoaiSanPham nvarchar(255)
)

create table SanPham(
	MaSanPham int not null primary key,
	TenSanPham nvarchar(255),
	SoLuong int,
	DonGia int,
	MaLoaiSanPham int,
	foreign key (MaLoaiSanPham) references LoaiSanPham(MaLoaiSanPham)
)

go
insert into LoaiSanPham values
	(1, N'Quần'),
	(2, N'Áo')

insert into SanPham values
	(1, N'Quần bò', 10, 100000, 1),
	(2, N'Quần âu', 15, 150000, 1),
	(3, N'Áo sơ mi', 13, 90000, 2),
	(4, N'Áo phông', 8, 50000, 2)

select * from LoaiSanPham
select * from SanPham