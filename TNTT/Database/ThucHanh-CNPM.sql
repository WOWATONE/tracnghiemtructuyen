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
	tenkhoa nvarchar(200) NOT NULL,
	makhoa nvarchar(64) NOT NULL,
	ghichu_khoa nvarchar(500) NULL,
	primary key (idkhoa)
)

GO
CREATE TABLE LOP
(
	idlop int identity(1,1),
	tenlop nvarchar(200) NOT NULL,
	malop nvarchar(64) NOT NULL,
	khoa_idkhoa int,
	primary key (idlop)
)

GO
CREATE TABLE SINHVIEN
(
	masinhvien nvarchar(64) NOT NULL,
	tensinhvien nvarchar(200) NULL,
	ngaysinh_sinhvien nvarchar(45) NOT NULL,
	diachi_sinhvien nvarchar(500) NULL,
	dienthoai_sinhvien nvarchar(64) NULL,
	email_sinhvien nvarchar(64) NULL,
	avartar_sinhvien nvarchar(500) NULL,
	lop_idlop int NOT NULL,
	primary key (masinhvien)
)

GO
CREATE TABLE DANHSACHTHI
(
	sinhvien_masinhvien nvarchar(64) NOT NULL,
	phongthi_idphongthi int NOT NULL,
	diem int NOT NULL,
	thoigianvaophong datetime NOT NULL,
	thoigianketthuc datetime NOT NULL,
	primary key(sinhvien_masinhvien,phongthi_idphongthi)
)

GO
CREATE TABLE BOMON
(
	idbomon int identity(1,1),
	tenbomon nvarchar(200) not null,
	mabomon nvarchar(64) not null,
	ghichu_bomon nvarchar(500) null,
	khoa_idkhoa int not null,
	primary key(idbomon)
)

GO
CREATE TABLE DSMH
(
	idddsmh nvarchar(200) NOT NULL,
	lop_idlop int not null,
	monhoc_idmonhoc int not null,
	giangvien_idgiangvien int not null,
	ngayhoc datetime not null,
	primary key(idddsmh)
)

GO
CREATE TABLE DSMONHOCLAI
(
	iddsmonhoclai nvarchar(200) not null,
	sinhvien_masinhvien nvarchar(64) not null,
	dsmh_idddsmh nvarchar(200) NOT NULL,
	primary key(iddsmonhoclai)
)

GO
CREATE TABLE PHONGTHI
(
	idphongthi int identity(1,1),
	tenphongthi nvarchar(200) NOT NULL,
	maphongthi nvarchar(200) NOT NULL,
	matkhau nvarchar(200) NOT NULL,
	dsmh_idddsmh nvarchar(200) NOT NULL,
	dethi_iddethi nvarchar(200) not null,
	ngaythi datetime not null,
	thoigianthi datetime not null,
	tinhtrang int not null,
	gianviengacthi nvarchar(200),
	tongthoigianthi int not null,
	primary key (idphongthi)
)

GO
CREATE TABLE MONHOC
(
	idmonhoc int identity(1,1),
	mamonhoc nvarchar(64) NOT NULL,
	tenmonhoc nvarchar(200) NOT NULL,
	ghichu_monhoc nvarchar(500) NULL,
	bomon_idbomon int NOT NULL,
	primary key(idmonhoc)
)

GO
CREATE TABLE DETHI
(
	iddethi nvarchar(200),
	madethi nvarchar(200),
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
	magiangvien nvarchar(64) NOT NULL,
	matkhau nvarchar(200) not null,
	tengiangvien nvarchar(200) NOT NULL,
	diachi_giangvien nvarchar(500) NULL,
	dienthoai_giangvien nvarchar(64) NULL,
	email_giangvien nvarchar(64) NULL,
	avatar_giangvien nvarchar(500) NULL,
	bomon_idbomon int NOT NULL,
	chucvu int not null,
	primary key(idgiangvien)
)

GO
CREATE TABLE NGANHANGCAUHOI
(
	idnganhangcauhoi int identity(1,1),
	monhoc_idmonhoc int NOT NULL,
	tieude ntext null,
	--listcautraloi text NOT NULL,
	--listdapan nvarchar(200) NOT NULL,
	chuong varchar(3) NOT NULL,
	phan nvarchar(3) NULL,
	level int NOT NULL,
	ngaytao datetime null,
	tinhtrang int ,
	giangvien_idgiangvien int,
	troncauhoi bit not null,	
	primary key (idnganhangcauhoi)
)

GO
CREATE TABLE CAUTRALOI
(
	idcautraloi int identity(1,1),
	NHCH_idnganhangcauhoi int NOT NULL,
	cautraloi nvarchar(500),
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
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE SINHVIEN WITH NOCHECK ADD FOREIGN KEY(lop_idlop)
REFERENCES LOP (idlop)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE DANHSACHTHI WITH NOCHECK ADD FOREIGN KEY(phongthi_idphongthi)
REFERENCES PHONGTHI (idphongthi)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE BOMON WITH NOCHECK ADD FOREIGN KEY(khoa_idkhoa)
REFERENCES KHOA (idkhoa)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE DSMH WITH NOCHECK ADD FOREIGN KEY(lop_idlop)
REFERENCES LOP (idlop)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE DSMH WITH NOCHECK ADD FOREIGN KEY(monhoc_idmonhoc)
REFERENCES MONHOC (idmonhoc)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE DSMH WITH NOCHECK ADD FOREIGN KEY(giangvien_idgiangvien)
REFERENCES GIANGVIEN (idgiangvien)
--

GO
ALTER TABLE DSMONHOCLAI WITH NOCHECK ADD FOREIGN KEY(dsmh_idddsmh)
REFERENCES DSMH (idddsmh)
ON UPDATE CASCADE
ON DELETE CASCADE
-- 1

GO
ALTER TABLE DSMONHOCLAI WITH NOCHECK ADD FOREIGN KEY(sinhvien_masinhvien)
REFERENCES SINHVIEN (MaSinhVien)
-- 2 why ! sao chỗ này ko thêm update,dalete dc vậy ta :|

GO
ALTER TABLE PHONGTHI WITH NOCHECK ADD FOREIGN KEY(dsmh_idddsmh)
REFERENCES DSMH (idddsmh)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE PHONGTHI WITH NOCHECK ADD FOREIGN KEY(dethi_iddethi)
REFERENCES DETHI (iddethi)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE MONHOC WITH NOCHECK ADD FOREIGN KEY(bomon_idbomon)
REFERENCES BOMON (idbomon)
--^^

GO
ALTER TABLE DETHI WITH NOCHECK ADD FOREIGN KEY(monhoc_idmonhoc)
REFERENCES MONHOC (idmonhoc)
-- ^^ 
GO
ALTER TABLE DETHI WITH NOCHECK ADD FOREIGN KEY(giangvien_idgiangvien)
REFERENCES GIANGVIEN (idgiangvien)
--

GO
ALTER TABLE GIANGVIEN WITH NOCHECK ADD FOREIGN KEY(bomon_idbomon)
REFERENCES BOMON (idbomon)
ON UPDATE CASCADE
ON DELETE CASCADE

GO
ALTER TABLE NGANHANGCAUHOI WITH NOCHECK ADD FOREIGN KEY(monhoc_idmonhoc)
REFERENCES MONHOC (idmonhoc)

GO
ALTER TABLE NGANHANGCAUHOI WITH NOCHECK ADD FOREIGN KEY(giangvien_idgiangvien)
REFERENCES GIANGVIEN (idgiangvien)
ON UPDATE CASCADE
ON DELETE CASCADE



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
INSERT INTO SINHVIEN VALUES ('1100021',N'Nguyễn Văn A','22-11-1992',N'Địa chỉ','01289941997',N'hoangvn9x@gmail.com',N'Images\Super-star.PNG',1)


INSERT INTO BOMON VALUES (N'TOIEC 350',N'Toiec',N'',1)
INSERT INTO BOMON VALUES (N'TOÁN',N'Math',N'',1)

INSERT INTO MONHOC VALUES (N'TOÁN A1',N'TOÁN ĐẠI CƯƠNG A1',N'',2)

SET DATEFORMAT DMY
--INSERT INTO DSMH VALUES (N'TTT',1,1,1,'15-10-2012')
/*
	5 : admin
	4 : Trưởng khoa
	3 : phó khoa
	2 : giáo viên
	1 : ?
*/
INSERT INTO GIANGVIEN VALUES (N'admin',N'123456',N'administrator',N'address',N'Number phone',N'info@gmail.com',N'SUPERGV.PNG',1,5)

SELECT idddsmh,lop_idlop,monhoc_idmonhoc,giangvien_idgiangvien,ngayhoc,malop,mamonhoc,tengiangvien
FROM DSMH DS,LOP L,MONHOC MH,GIANGVIEN GV
WHERE DS.lop_idlop = L.idlop and DS.monhoc_idmonhoc = MH.idmonhoc and DS.giangvien_idgiangvien = GV.idgiangvien






