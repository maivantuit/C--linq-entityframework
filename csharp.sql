create database KiemTra4THCShape
go
use KiemTra4THCShape
go
create table KhachHang(
	MaKH int primary key,
	TenKH nvarchar(50),
	Tuoi int,
	DiaChi nvarchar(50)
)
insert into KhachHang(MaKH,TenKH,Tuoi,DiaChi) values (1,N'Mai Văn Tú',30,N'Thanh Long Đà Nẵng')
insert into KhachHang(MaKH,TenKH,Tuoi,DiaChi) values (2,N'Khánh Nhi',30,N'TP HCM')
insert into KhachHang(MaKH,TenKH,Tuoi,DiaChi) values (3,N'Hồng Đào',25,N'TP HCM')
insert into KhachHang(MaKH,TenKH,Tuoi,DiaChi) values (4,N'Xuân Quỳnh',31,N'TP HCM')

go
create table DatHang(
	MaKH int foreign key references KhachHang(MaKH),
	MaDH int primary key,
	TenDH nvarchar(50),
	DiachiDatHang nvarchar(50),
	NgayDat date 
)
insert into DatHang(MaKH, MaDH,TenDH,DiachiDatHang,NgayDat) values(1,1,N'DatHang1',N'Thanh Long Đà Nẵng','12/29/2017')
insert into DatHang(MaKH, MaDH,TenDH,DiachiDatHang,NgayDat) values(1,2,N'DatHang2',N'Thanh Long Đà Nẵng','12/30/2017')
insert into DatHang(MaKH, MaDH,TenDH,DiachiDatHang,NgayDat) values(1,3,N'DatHang3',N'Thanh Long Đà Nẵng','12/29/2017')
insert into DatHang(MaKH, MaDH,TenDH,DiachiDatHang,NgayDat) values(1,4,N'DatHang4',N'Thanh Long Đà Nẵng','12/30/2017')

