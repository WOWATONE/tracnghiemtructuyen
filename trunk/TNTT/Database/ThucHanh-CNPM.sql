GO 
USE master 
GO
if exists(select Name from SYSDATABASES where name = 'QLCHAMDIEMTRACNGHIEM')
	DROP DATABASE QLCHAMDIEMTRACNGHIEM
GO
CREATE DATABASE QLCHAMDIEMTRACNGHIEM
GO 
USE QLCHAMDIEMTRACNGHIEM

GO
CREATE TABLE KHOA
(
	idkhoa int identity(1,1),
	tenkhoa nvarchar(100) NOT NULL,
	makhoa varchar(10) NOT NULL,
	ghichu_khoa nvarchar(250) NULL,
	primary key (idkhoa)
)

GO
CREATE TABLE LOP
(
	idlop int identity(1,1),
	tenlop nvarchar(100) NOT NULL,
	malop nvarchar(10) NOT NULL,
	khoa_idkhoa int,
	primary key (idlop)
)

GO
CREATE TABLE SINHVIEN
(
	masinhvien varchar(10) NOT NULL,
	tensinhvien nvarchar(50) NULL,
	ngaysinh_sinhvien nvarchar(12) NOT NULL,
	diachi_sinhvien nvarchar(200) NULL,
	dienthoai_sinhvien nvarchar(14) NULL,
	email_sinhvien nvarchar(64) NULL,
	avartar_sinhvien image NULL,
	lop_idlop int NOT NULL,
	primary key (masinhvien)
)

GO
CREATE TABLE DANHSACHTHI
(
	sinhvien_masinhvien varchar(10) NOT NULL,
	phongthi_idphongthi int NOT NULL,
	diem float NOT NULL,
	thoigianvaophong datetime NOT NULL,
	thoigianketthuc datetime NOT NULL,
	primary key(sinhvien_masinhvien,phongthi_idphongthi)
)

GO
CREATE TABLE BOMON
(
	idbomon int identity(1,1),
	tenbomon nvarchar(50) not null,
	mabomon varchar(10) not null,
	ghichu_bomon nvarchar(200) null,
	khoa_idkhoa int not null,
	primary key(idbomon)
)

GO
CREATE TABLE DSMH
(
	idddsmh int identity(1,1),
	lop_idlop int not null,
	monhoc_idmonhoc int not null,
	giangvien_idgiangvien int not null,
	ngayhoc datetime not null,
	primary key(idddsmh)
)

GO
CREATE TABLE DSMONHOCLAI
(
	iddsmonhoclai varchar(10) not null,
	sinhvien_masinhvien varchar(10) not null,
	dsmh_idddsmh int NOT NULL,
	primary key(iddsmonhoclai)
)

GO
CREATE TABLE PHONGTHI
(
	idphongthi int identity(1,1),
	tenphongthi nvarchar(50) NOT NULL,
	maphongthi varchar(10) NOT NULL,
	matkhau nvarchar(100) NOT NULL,
	dsmh_idddsmh int NOT NULL,
	dethi_iddethi int not null,
	ngaythi datetime not null,
	thoigianthi varchar(10) not null,
	tinhtrang bit not null,
	idgiangvien int not null,
	tongthoigianthi int not null,
	primary key (idphongthi)
)

GO
CREATE TABLE MONHOC
(
	idmonhoc int identity(1,1),
	mamonhoc varchar(10) NOT NULL,
	tenmonhoc nvarchar(50) NOT NULL,
	ghichu_monhoc nvarchar(500) NULL,
	bomon_idbomon int NOT NULL,
	primary key(idmonhoc)
)

GO
CREATE TABLE DETHI
(
	iddethi int identity(1,1),
	madethi nvarchar(10),
	listidcauhoi ntext not null,
	monhoc_idmonhoc int not null,
	ngaytao datetime null,
	giangvien_idgiangvien int NOT NULL,
	primary key(iddethi)
)

GO 
CREATE TABLE GIANGVIEN
(
	idgiangvien int identity(1,1),
	magiangvien nvarchar(10) NOT NULL,
	matkhau nvarchar(100) not null,
	tengiangvien nvarchar(100) NOT NULL,
	diachi_giangvien nvarchar(200) NULL,
	dienthoai_giangvien nvarchar(14) NULL,
	email_giangvien nvarchar(100) NULL,
	avatar_giangvien image NULL,
	bomon_idbomon int NOT NULL,
	chucvu int not null,
	primary key(idgiangvien)
)

GO
CREATE TABLE NGANHANGCAUHOI
(
	idnganhangcauhoi int identity(1,1),
	monhoc_idmonhoc int NOT NULL,
	tieude nvarchar(MAX) null,
	chuong varchar(3) NOT NULL,
	phan nvarchar(2) NULL,
	capdo int NOT NULL,
	ngaytao datetime null,
	tinhtrang bit NOT NULL ,
	troncau bit not null,
	giangvien_idgiangvien int,	
	primary key (idnganhangcauhoi)
)

GO
CREATE TABLE CAUTRALOI
(
	idcautraloi int identity(1,1),
	NHCH_idnganhangcauhoi int NOT NULL,
	cautraloi nvarchar(200),
	dapan bit,
	primary key (idcautraloi)
	
)

---------- Khóa ngoại ----------
GO
ALTER TABLE CAUTRALOI WITH NOCHECK ADD FOREIGN KEY(NHCH_idnganhangcauhoi)
REFERENCES NGANHANGCAUHOI (idnganhangcauhoi)

GO
ALTER TABLE LOP WITH NOCHECK ADD FOREIGN KEY(khoa_idkhoa)
REFERENCES KHOA (idkhoa)

GO
ALTER TABLE SINHVIEN WITH NOCHECK ADD FOREIGN KEY(lop_idlop)
REFERENCES LOP (idlop)

GO
ALTER TABLE DANHSACHTHI WITH NOCHECK ADD FOREIGN KEY(phongthi_idphongthi)
REFERENCES PHONGTHI (idphongthi)

GO
ALTER TABLE BOMON WITH NOCHECK ADD FOREIGN KEY(khoa_idkhoa)
REFERENCES KHOA (idkhoa)

GO
ALTER TABLE DSMH WITH NOCHECK ADD FOREIGN KEY(lop_idlop)
REFERENCES LOP (idlop)

GO
ALTER TABLE DSMH WITH NOCHECK ADD FOREIGN KEY(monhoc_idmonhoc)
REFERENCES MONHOC (idmonhoc)

GO
ALTER TABLE DSMH WITH NOCHECK ADD FOREIGN KEY(giangvien_idgiangvien)
REFERENCES GIANGVIEN (idgiangvien)

GO
ALTER TABLE DSMONHOCLAI WITH NOCHECK ADD FOREIGN KEY(dsmh_idddsmh)
REFERENCES DSMH (idddsmh)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE DSMONHOCLAI WITH NOCHECK ADD FOREIGN KEY(sinhvien_masinhvien)
REFERENCES SINHVIEN (MaSinhVien)

GO
ALTER TABLE PHONGTHI WITH NOCHECK ADD FOREIGN KEY(dsmh_idddsmh)
REFERENCES DSMH (idddsmh)

GO
ALTER TABLE PHONGTHI WITH NOCHECK ADD FOREIGN KEY(dethi_iddethi)
REFERENCES DETHI (iddethi)

GO
ALTER TABLE MONHOC WITH NOCHECK ADD FOREIGN KEY(bomon_idbomon)
REFERENCES BOMON (idbomon)

GO
ALTER TABLE DETHI WITH NOCHECK ADD FOREIGN KEY(monhoc_idmonhoc)
REFERENCES MONHOC (idmonhoc)

GO
ALTER TABLE DETHI WITH NOCHECK ADD FOREIGN KEY(giangvien_idgiangvien)
REFERENCES GIANGVIEN (idgiangvien)

GO
ALTER TABLE GIANGVIEN WITH NOCHECK ADD FOREIGN KEY(bomon_idbomon)
REFERENCES BOMON (idbomon)

GO
ALTER TABLE NGANHANGCAUHOI WITH NOCHECK ADD FOREIGN KEY(monhoc_idmonhoc)
REFERENCES MONHOC (idmonhoc)

GO
ALTER TABLE NGANHANGCAUHOI WITH NOCHECK ADD FOREIGN KEY(giangvien_idgiangvien)
REFERENCES GIANGVIEN (idgiangvien)



---------- INSERT INTO ----------

INSERT INTO KHOA VALUES (N'CÔNG NGHỆ THÔNG TIN',N'CNTT',N'')
INSERT INTO KHOA VALUES (N'TÀI CHÍNH NGÂN HÀNG',N'TCNH',N'')
INSERT INTO KHOA VALUES (N'ĐIỆN TỬ VIỄN THÔNG',N'DTVT',N'')
INSERT INTO KHOA VALUES (N'QUẢN TRỊ KINH DOANH',N'QTKD',N'')


INSERT INTO LOP VALUES (N'CÔNG NGHỆ THÔNG TIN 1',N'C10CT1',1)
INSERT INTO LOP VALUES (N'CÔNG NGHỆ THÔNG TIN 2',N'C10CT2',1)
INSERT INTO LOP VALUES (N'CÔNG NGHỆ THÔNG TIN 3',N'C10CT3',1)
INSERT INTO LOP VALUES (N'TÀI CHÍNH NGÂN HÀNG 1',N'C10NH1',2)
INSERT INTO LOP VALUES (N'TÀI CHÍNH NGÂN HÀNG 2',N'C10NH1',2)
INSERT INTO LOP VALUES (N'TÀI CHÍNH NGÂN HÀNG 3',N'C10NH1',2)
INSERT INTO LOP VALUES (N'ĐIỆN TỬ VIỄN THÔNG 1',N'C10DT1',3)
INSERT INTO LOP VALUES (N'ĐIỆN TỬ VIỄN THÔNG 2',N'C10DT2',3)
INSERT INTO LOP VALUES (N'QUẢN TRỊ KINH DOANH 1',N'C10QT1',4)


SET DATEFORMAT DMY
INSERT INTO SINHVIEN VALUES ('1100021',N'Nguyễn Văn A','22-11-1992',N'Địa chỉ','01289941997',N'hoangvn9x@gmail.com','',1)


INSERT INTO BOMON VALUES (N'TOIEC 350',N'Toiec',N'',1)
INSERT INTO BOMON VALUES (N'TOÁN',N'Math',N'',1)

INSERT INTO MONHOC VALUES (N'TOÁN A1',N'TOÁN ĐẠI CƯƠNG A1',N'',2)

SET DATEFORMAT DMY

INSERT INTO GIANGVIEN VALUES (N'admin',N'123456',N'administrator',N'address',N'Number phone',N'info@gmail.com','',1,5)






