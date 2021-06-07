create database truongmamnon
go

use truongmamnon
go

create table users
(
	username nvarchar(20) primary key,
	pass nvarchar(20),
	quyen int,
)

create table nhanvien 
(
	manv nvarchar(10) primary key,
	hotennv nvarchar(30),
	gioitinh nvarchar(10),
	ngaysinh smalldatetime,
	chucvu nvarchar(20),
	chungminhthu nvarchar(20), 
	dantoc nvarchar(20), 
	sodienthoai nvarchar(20),
	diachi nvarchar(50),
)

create table hocsinh
(
	mahs nvarchar(10) primary key,
	hotenhs nvarchar(30),
	gioitinh nvarchar(10),
	ngaysinh smalldatetime,
	dantoc nvarchar(20),
	hotenbo nvarchar(30),
	sdtbo nvarchar(20),
	hotenme nvarchar(30),
	sdtme nvarchar(20),

)

create table namhoc
(
	namhoc nvarchar(10) primary key,
	tennamhoc nvarchar(20),
	ngaybatdau smalldatetime,
	ngayketthuc smalldatetime,
)

create table khoi
(
	tenkhoi nvarchar(10) primary key,
	namhoc nvarchar(10) foreign key references namhoc,
)


create table lop
(
	malop nvarchar(10) primary key,
	tenlop nvarchar(10),
	tenkhoi nvarchar(10) foreign key references khoi,
	namhoc nvarchar(10) foreign key references namhoc,
)


create table hocsinhlop
(
	mahs nvarchar(10) primary key foreign key references hocsinh ,
	malop nvarchar(10) foreign key references lop,
	tenkhoi nvarchar(10) foreign key references khoi,
	namhoc nvarchar (10) foreign key references namhoc,
)



create table gvlop
(
	manv nvarchar(10) primary key foreign key references nhanvien,
	malop nvarchar(10) foreign key references lop,
	tenkhoi nvarchar(10) foreign key references khoi,
	namhoc nvarchar (10) foreign key references namhoc,
)


create table phicoban
(
	namhoc nvarchar(10) primary key foreign key references namhoc,
	luongcoban int,
	hocphicoban int,
)

create table luongnv
(
	mathanhtoan int primary key identity,
	manv nvarchar(10)foreign key references nhanvien, 
	luongcoban int ,
	phucap int,
	thuong int,
	kyluat int,
	tongluong float,
	thang int,
	namhoc nvarchar(10) foreign key references namhoc,
	tinhtrang int, /*Đã trả - Chưa trả*/
	ghichu nvarchar(50),
)


create table hocphi
(	
	mathanhtoan int primary key identity,
	mahs nvarchar(10) foreign key references hocsinh,
	hocphicoban int,
	hogiadinh nvarchar(20), /*Hộ bt - Hộ nghèo - Hộ cận nghèo*/
	tonghocphi float,
	namhoc nvarchar(10) foreign key references namhoc, 
	tinhtrang int,
)

insert into hocsinh values 
('HS1','Hoang','Nam','2019-02-03','Kinh','Dung','03923914','Thuy','9252929229'),
('HS2','Dung','Nam','2020-03-03','Kinh','Hung','03923913','Hang','9292929229'),
('HS3','Ngoc','Nam','2020-03-03','Kinh','Hung','03923913','Hang','9292929229')
insert into nhanvien values 
('GV01','Thu Trang', 'Nu','1999-06-06','Giao vien','122294325','Kinh','01234565','Bac Giang' )
insert into users values
('luan','luan',1), 
('admin','admin',0)
insert into nhanvien values ('nv01','HTT','nu',1999-09-28,'Giao vien','123456789','Kinh','0123456789','Bac Giang')
insert into hocsinh values ('hs01','TVTH','nam',2017-30-08,'Kinh','TQH','032456456','PTT','02456654')
insert into namhoc values ('2021','nam hoc 2020-2021',2020-08-01,2021-06-01)
insert into khoi values ('4 tuoi','2021')
insert into lop values ('4t1','4t thu 1','4 tuoi','2021')
insert into hocsinhlop values ('hs01','4t1','4 tuoi','2021')
insert into gvlop values ('nv01','4t1','4 tuoi','2021') 

