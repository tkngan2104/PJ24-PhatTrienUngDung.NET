create database QLBV
go
use QLBV
go
create table BenhNhan---1
(
	 [MSBN] nvarchar(12) not null
	,[TenBN] nvarchar(50) not null
	,[GioiTinh] nvarchar(3) not null
	,[NgSinh] date not null
	,[DiaChi] nvarchar(1000)
	,[NgheNghiep] nvarchar(80)
	,[SDT] nvarchar(15)
	,[CCCD] nvarchar(12)
	,[TTLienHe] nvarchar(15)
)
create table HoSoBenhAn-----29
(
	 [MaHoSoBA] nvarchar(30) not null
	,[MSBN] nvarchar(12) not null
	,[NgayTao] date
)

create table BHYT---2
(
	 [MaSoBHYT] nvarchar(15) not null
	,[NgayCap] date
	,[NgayHetHan] date
	,[MSBN] nvarchar(12) not null 
)
create table LoaiBenhAn----3
(
	 [MaLoaiBA] nvarchar(12) not null
	,[TenLoaiBA] nvarchar(120) not null
)

create table ChucVu---4
(
	 [MaCV] nvarchar(12) not null
	,[TenCV] nvarchar(150) not null
)
go
create table LoaiKham---5---------------Coi lại
(
	 [MaLoaiKham] nvarchar(12) not null
	,[TenLoaiKham] nvarchar(200)
	,[Gia] float
)

create table PhieuKhamBenh--6
(
	 [MSPhieuKhamBenh] nvarchar(30) not null
	,[NgayKham] datetime
	,[MaHoSoBA] nvarchar(30) not null
	,[TrieuChung] nvarchar(1000)
	,[BenhNen] nvarchar(500)
	,[MaLoaiKham] nvarchar(12) not null
)

create table Khoa-----------7
(
	 [MaKhoa] nvarchar(12) NOT NULL
	,[TenKhoa] nvarchar(90) not null
)

create table ChuyenNganh------8
(
	 [MaChuyenNganh] nvarchar(12) not null
	,[TenChuyenNganh] nvarchar(120)
	,[MaKhoa] nvarchar(12) NOT NULL
)
go
create table NhanVien---------9
(
	 [MaNV] nvarchar(12) not null
	,[TenNV] nvarchar(50)
	,[GioiTinh] nvarchar(3)
	,[SDT] nvarchar(15) 
	,[Email] nvarchar(30)
	,[NgayBatDauLam] date
	,[MaKhoa] nvarchar(12) not null
	,[MaCV] nvarchar(12) not null
)

create table DamNhanChuyenMon------10
(
	 [MaChuyenNganh] nvarchar(12) not null
	,[MaNV] nvarchar(12) not null
	,[KinhNghiem] nvarchar(20)
)

create table Thuoc--------------11
(
	 [MSThuoc] nvarchar(12) not null
	,[TenThuoc] nvarchar(100) not null
	,[DangThuoc] nvarchar(150) not null
	,[DonViTinh] nvarchar(50) not null
	,[DonGia] float not null
	,[Xuatxu] nvarchar(100) not null
)
go
create table PhongKham-------------Coi lại--12
(
	 [MSPhong] nvarchar(12) not null
	,[TenPhong] nvarchar(90)
	,[DiaDiem] nvarchar(120)
	,[MaKhoa] nvarchar(12) not null
	,[SoGiuong] int
	,[Loai] nvarchar(200) not null
)

create table GiuongBenh------------------------14
(
	 [MaGiuong] nvarchar(12) not null
	,[SoGiuongBenh] int not null
	,[MSPhong] nvarchar(12) not null
)

create table BenhLy--------------15
(
	 [MaBenh] nvarchar(12) not null
	,[TenBenh] nvarchar(200) not null
)

create table Kham--------------------16
(
	 [MaYeuCau] nvarchar(100) not null
	,[MSPhieuKhamBenh] nvarchar(30) not null
	,[MSPhong] nvarchar(12) not null
	,[MaNV] nvarchar(12) null
	,[MaNguoiYC] nvarchar(12) not null
)
create table ChuanDoan----------------17
(
	 [MaChuanDoan] nvarchar(30) not null
	,[MaYeuCau] nvarchar(100) not null
	,[MaBenh] nvarchar(12)
	,[MSPhieuKhamBenh] nvarchar(30) not null
	,[MaNV] nvarchar(12) not null
	,[KetLuan] nvarchar(300) 
	,[LoiKhuyen] nvarchar(500)
	,[MaLoaiBA] nvarchar(12)
)

create table PhanGiuong-----------------18
(
	 [MaGiuong] nvarchar(12) not null
	,[MaYeuCau] nvarchar(100) not null
	,[NgayNhanGiuong] date
	,[NgayTraGiuong] date
	,[MSPhieuKhamBenh] nvarchar(30) not null
	,[MaLoaiBA] nvarchar(12) not null
	,[MaLoaiChiTietDV] nvarchar(12) not null
)

create table BangGia----------------19
(
	 [MaLoaiChiTietDV] nvarchar(12) not null
	,[TenLoaiChiTietDV] nvarchar(100) not null
	,[Gia] float	
	,[MaKhoa] nvarchar(12) not null
	,[LoaiPT_XNCC] nvarchar(12) null
)

create table ToaThuoc----------20
(
	 [MaChuanDoan] nvarchar(30) not null
	,[MaToaThuoc] nvarchar(30) not null
	,[MSPhieuKhamBenh] nvarchar(30) not null
	,[MSThuoc] nvarchar(12) not null
	,[SoLuong] int
	,[GiaTien] float
	,[NgayCap] date
	,[HDSuDung] nvarchar(500) not null
	,[MaNV] nvarchar(12) not null
	,[Tien] float
)

create table LoaiPT_XNCC
(
	 [LoaiPT_XNCC] nvarchar(12) not null
	,[Ten] nvarchar(1000)
)

create table LamPhauThuat_XNCC--------------------------24
(
	 [MSPhieuKhamBenh] nvarchar(30) not null
	,[MaYeuCau] nvarchar(100) not null
	,[MaNV] nvarchar(12) not null
	,[MSPhong] nvarchar(12) not null
	,[MaLoaiChiTietDV] nvarchar(12) not null
	,[ThoiGianThucHien] datetime
	,[KetQua] nvarchar(200)
	,[MucDoRuiRo] nvarchar(200)
	,[Loai] nvarchar(200) not null
	,[MaLoaiBA] nvarchar(12) not null
)

create table TheoDoiSucKhoe-----------------------26
(
	 [MaTheoDoi] nvarchar(80) not null
	,[MaYeuCau] nvarchar(100) not null
	,[MSPhieuKhamBenh] nvarchar(30) not null
	,[MaNV] nvarchar(12) not null
	,[NgayTheoDoi] date
	,[TinhTrangSK] nvarchar(2000)
	,[GhiChu] nvarchar(2000)
)

create table HoaDon-------------------------------27
(
	 [MaHD] nvarchar(30) not null
	,[MSPhieuKhamBenh] nvarchar(30) not null,
     [NgayXuatHD] datetime NOT NULL,
	 [TienThuoc] float,
	 [TienKham] float,
	 [TienGiuong] float,
	 [TienPT_XNCC] float,
	 [TongTien] float,
	 [TienBHYTChiTra] float,
     [TongTienSauKhiDaGiam] float,
)
go
-----------------------------------------------
-------------------Khóa chính
alter table BangGia
add constraint PK_BangGia primary key ([MaLoaiChiTietDV])

alter table BenhLy
add constraint PK_BenhLy primary key ([MaBenh])

alter table BenhNhan
add constraint PK_BenhNhan primary key ([MSBN])

alter table BHYT
add constraint PK_BHYT primary key ([MaSoBHYT])

alter table ChuanDoan
add constraint PK_ChuanDoan primary key ([MaChuanDoan])

alter table ChucVu
add constraint PK_ChucVu primary key ([MaCV])

alter table ChuyenNganh
add constraint PK_ChuyenNganh primary key ([MaChuyenNganh])

alter table DamNhanChuyenMon
add constraint PK_DamNhanChuyenMon primary key ([MaChuyenNganh],[MaNV])

alter table GiuongBenh
add constraint PK_GiuongBenh primary key ([MaGiuong])

alter table HoaDon
add constraint PK_HoaDon primary key ([MaHD])

alter table HoSoBenhAn
add constraint PK_HoSoBenhAn primary key ([MaHoSoBA])

alter table Kham
add constraint PK_Kham primary key ([MaYeuCau])

alter table Khoa
add constraint PK_Khoa primary key ([MaKhoa])

alter table LamPhauThuat_XNCC
add constraint PK_LamPhauThuat_XNCC primary key ([MSPhieuKhamBenh],[MaYeuCau])

alter table LoaiBenhAn
add constraint PK_LoaiBenhAn primary key ([MaLoaiBA])

alter table LoaiKham
add constraint PK_LoaiKham primary key ([MaLoaiKham])

alter table NhanVien
add constraint PK_NhanVien primary key ([MaNV])

alter table PhanGiuong
add constraint PK_PhanGiuong primary key ([MaGiuong],[MSPhieuKhamBenh])

alter table PhieuKhamBenh
add constraint PK_PhieuKhamBenh primary key ([MSPhieuKhamBenh])

alter table PhongKham
add constraint PK_PhongKham primary key ([MSPhong])

alter table LoaiPT_XNCC
add constraint PK_LoaiPT_XNCC primary key ([LoaiPT_XNCC])

alter table TheoDoiSucKhoe
add constraint PK_TheoDoiSucKhoe primary key ([MaTheoDoi])

alter table Thuoc
add constraint PK_Thuoc primary key ([MSThuoc])

alter table ToaThuoc
add constraint PK_ToaThuoc primary key ([MaToaThuoc],[MSThuoc],MSPhieuKhamBenh)
------------------------------------------------------------------------
-----------Khóa ngoại
go
alter table BangGia
add constraint FK_Khoa_BangGia foreign key ([MaKhoa])
references Khoa ([MaKhoa])

alter table BHYT
add constraint FK_BenhNhan_BHYT foreign key ([MSBN])
references BenhNhan ([MSBN])

alter table ChuanDoan
add constraint FK_BenhLy_ChuanDoan foreign key ([MaBenh])
references BenhLy ([MaBenh])

alter table ChuanDoan
add constraint FK_Kham_ChuanDoan foreign key ([MaYeuCau])
references Kham ([MaYeuCau])

alter table ChuanDoan
add constraint FK_PhieuKhamBenh_ChuanDoan foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table ChuanDoan
add constraint FK_NhanVien_ChuanDoan foreign key ([MaNV])
references NhanVien ([MaNV])

alter table ChuanDoan
add constraint FK_LoaiBenhAn_ChuanDoan foreign key ([MaLoaiBA])
references LoaiBenhAn ([MaLoaiBA])

alter table ChuyenNganh
add constraint FK_Khoa_ChuyenNganh foreign key ([MaKhoa])
references Khoa ([MaKhoa])

alter table DamNhanChuyenMon
add constraint FK_ChuyenNganh_DamNhanChuyenMon foreign key ([MaChuyenNganh])
references ChuyenNganh ([MaChuyenNganh])

alter table DamNhanChuyenMon
add constraint FK_NhanVien_DamNhanChuyenMon foreign key ([MaNV])
references NhanVien ([MaNV])

alter table GiuongBenh
add constraint FK_PhongKham_GiuongBenh foreign key ([MSPhong])
references PhongKham ([MSPhong])
		
alter table ToaThuoc
add constraint FK_PhieuKhamBenh_ToaThuoc foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table HoaDon
add constraint FK_PhieuKhamBenh_HoaDon foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table HoSoBenhAn
add constraint FK_BenhNhan_HoSoBenhAn foreign key ([MSBN])
references BenhNhan ([MSBN])

alter table Kham
add constraint FK_PhieuKhamBenh_Kham foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table Kham
add constraint FK_PhongKham_Kham foreign key ([MSPhong])
references PhongKham ([MSPhong])

alter table Kham
add constraint FK_NhanVien_Kham foreign key ([MaNguoiYC])
references NhanVien ([MaNV])

alter table Kham
add constraint FK_NhanVien_Kham1 foreign key ([MaNV])
references NhanVien ([MaNV])

alter table LamPhauThuat_XNCC
add constraint FK_PhieuKhamBenh_LamPhauThuat_XNCC foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table LamPhauThuat_XNCC
add constraint FK_NhanVien_LamPhauThuat_XNCC foreign key ([MaNV])
references NhanVien ([MaNV])

alter table BangGia
add constraint FK_LoaiPT_XNCC_BangGia foreign key ([LoaiPT_XNCC])
references LoaiPT_XNCC ([LoaiPT_XNCC])

alter table LamPhauThuat_XNCC
add constraint FK_PhongKham_LamPhauThuat_XNCC foreign key ([MSPhong])
references PhongKham ([MSPhong])

alter table LamPhauThuat_XNCC
add constraint FK_BangGia_LamPhauThuat_XNCC foreign key ([MaLoaiChiTietDV])
references BangGia ([MaLoaiChiTietDV])

alter table LamPhauThuat_XNCC
add constraint FK_LoaiBenhAn_LamPhauThuat_XNCC foreign key ([MaLoaiBA])
references LoaiBenhAn ([MaLoaiBA])

alter table LamPhauThuat_XNCC
add constraint FK_Kham_LamPhauThuat_XNCC foreign key ([MaYeuCau])
references Kham ([MaYeuCau])

alter table NhanVien
add constraint FK_Khoa_NhanVien foreign key ([MaKhoa])
references Khoa ([MaKhoa])

alter table NhanVien
add constraint FK_ChucVu_NhanVien foreign key ([MaCV])
references ChucVu ([MaCV])

alter table PhanGiuong
add constraint FK_GiuongBenh_PhanGiuong foreign key ([MaGiuong])
references GiuongBenh ([MaGiuong])

alter table PhanGiuong
add constraint FK_BangGia_PhanGiuong foreign key (MaLoaiChiTietDV)
references BangGia (MaLoaiChiTietDV)

alter table PhanGiuong
add constraint FK_Kham_PhanGiuong foreign key ([MaYeuCau])
references Kham ([MaYeuCau])

alter table PhanGiuong
add constraint FK_PhieuKhamBenh_PhanGiuong foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table PhanGiuong
add constraint FK_LoaiBenhAn_PhanGiuong foreign key ([MaLoaiBA])
references LoaiBenhAn ([MaLoaiBA])

alter table PhieuKhamBenh
add constraint FK_HoSoBenhAn_PhieuKhamBenh foreign key ([MaHoSoBA])
references HoSoBenhAn ([MaHoSoBA])

alter table PhieuKhamBenh
add constraint FK_LoaiKham_PhieuKhamBenh foreign key ([MaLoaiKham])
references LoaiKham ([MaLoaiKham])

alter table PhongKham
add constraint FK_Khoa_PhongKham foreign key ([MaKhoa])
references Khoa ([MaKhoa])

alter table TheoDoiSucKhoe
add constraint FK_PhieuKhamBenh_TheoDoiSucKhoe foreign key ([MSPhieuKhamBenh])
references PhieuKhamBenh ([MSPhieuKhamBenh])

alter table TheoDoiSucKhoe
add constraint FK_NhanVien_TheoDoiSucKhoe foreign key ([MaNV])
references NhanVien ([MaNV])

alter table ToaThuoc
add constraint FK_Thuoc_ToaThuoc foreign key ([MSThuoc])
references Thuoc ([MSThuoc])

alter table ToaThuoc
add constraint FK_ChuanDoan_ToaThuoc foreign key ([MaChuanDoan])
references ChuanDoan ([MaChuanDoan])

alter table ToaThuoc
add constraint FK_NhanVien_ToaThuoc foreign key ([MaNV])
references NhanVien ([MaNV])

alter table TheoDoiSucKhoe
add constraint FK_Kham_TheoDoiSucKhoe foreign key ([MaYeuCau])
references Kham ([MaYeuCau])

go
insert into Khoa([MaKhoa],[TenKhoa])
values
	 ('K01',N'Khoa hồi sức cấp cứu')
	,('K02',N'Khoa nhi')
	,('K03',N'Khoa mắt')
	,('K04',N'Khoa tiêu hóa')
	,('K05',N'Khoa nội tiết')
	,('K06',N'Khoa Răng-Hàm-Mặt')
	,('K07',N'Khoa da liễu')
	,('K08',N'Khoa tim mạch')
	,('K09',N'Khoa Cơ-Xương-Khớp')
	,('K10',N'Khoa ung bướu')
	,('K11',N'Khoa hô hấp')
	,('K12',N'Khoa vật lý trị liệu-phục hồi chức năng')
	,('K13',N'Khoa dinh dưỡng')
	,('K14',N'Khoa nội tổng hợp')
	,('K15',N'Khoa chấn thương chỉnh hình')
	,('K16',N'Khoa phẫu thuật gây mê hồi sức')
	,('K17',N'Khoa dược')
	,('K18',N'Khoa phụ sản')
	,('K19',N'Khoa ngoại tổng hợp')
	,('K20',N'Khoa chẩn đoán hình ảnh')
	,('K21',N'Khoa Tai-Mũi-Họng')
	,('K22',N'Khoa lao và bệnh phổi')
	,('K23',N'Khoa tâm thần')
	,('K24',N'Khoa thận')
	,('K25',N'Khoa phẫu thuật')
	,('K26',N'Khoa ngoại thần kinh')
	,('K27',N'Khoa nội thần kinh')
	,('K28',N'Khoa cận lâm sàng')
	,('K29',N'Khoa truyền nhiễm')
	,('K30',N'Khoa hành chính')


insert into LoaiPT_XNCC([LoaiPT_XNCC],[Ten])
values
	 ('L01',N'Phẫu thuật tim mạch')--tim mạch
	,('L02', N'Phẫu thuật ung thư phổi')--ung thư phổi
	,('L03', N'Phẫu thuật loại bỏ sỏi thận')--sỏi thận
	,('L04', N'Phẫu thuật cắt ống nhĩ')--viêm tai giữa
	,('L05', N'Phẫu thuật ghép gan')--xơ gan
	,('L06', N'Phẫu thuật cắt ruột thừa')--viêm ruột thừa
	,('L07', N'Phẫu thuật mở rộng động mạch cảnh')--Hẹp động mạch cảnh
	,('L08', N'Phẫu thuật lấy cục máu đông não')--Đột quỵ
	,('L09', N'Phẫu thuật cắt bỏ phần phổi do lao')--Lao phổi
	,('L10', N'Phẫu thuật cắt bỏ mụn cóc')--Mụn cóc
	,('L11', N'Phẫu thuật loại bỏ thai ngoài tử cung')--Mang thai ngoài tử cung
	,('L12', N'Phẫu thuật loại bỏ tĩnh mạch')--Suy tĩnh mạn tính
	,('L13', N'Phẫu thuật loại bỏ sán lá gan và sửa chữa ống mật')--Sán lá gan
	,('L14', N'Phẫu thuật loại bỏ nang sán chó')--Nhiễm sán chó
	,('L15', N'Phẫu thuật Mohs')--Ung thư da
	,('L16', N'Phẫu thuật loại bỏ u não')--U não
	,('L17', N'Phẫu thuật can thiệp cho biến chứng xơ cứng bì')--xơ cứng bì
	,('L18', N'Phẫu thuật thay khớp gối')--Đau khớp
	,('L19', N'Phẫu thuật ghép mạch vành')--Đau thắt ngực
	,('L20', N'Phẫu thuật cấy ghép tim')--Cơ tim giãn nở
	,('L21', N'Craniotomy')--Chấn thương sọ não
	,('L22', N'Phẫu thuật cắt bỏ tử cung do băng huyết sau sinh')--Băng huyết sau sinh
	,('L23', N'Phẫu thuật loại bỏ gai xương')--Gai xương
	,('L24', N'Phẫu thuật loại bỏ tắc nghẽn do giun đũa')--Giun đũa
	,('L25', N'Phẫu thuật Đục thủy tinh thể')--Đục thủy tinh thể
	,('L26', N'Phẫu thuật cắt bỏ phần gan')--Gan to
	,('L27', N'Phẫu thuật thay van động mạch chủ')--Hẹp van động mặt chủ
	,('L28', N'Phẫu thuật tái tạo dây thần kinh mặt')--Liệt mặt
	,('L29', N'Phẫu thuật cắt trĩ')--Trĩ nội
	,('L30', N'Điều trị laser')
	----------------------------------XN_CC
	,('LXNCC01',N'Chụp X-Quang')
	,('LXNCC02',N'Chụp CT')
	,('LXNCC03',N'Nội soi')
	,('LXNCC04',N'Chụp PET')
	,('LXNCC05',N'Chụp MRI')
	,('LXNCC06',N'Siêu âm')
	,('LXNCC07',N'Xét nghiệm máu')
	,('LXNCC08',N'Xét nghiệm nước tiểu')
	,('LXNCC09',N'Xét nghiệm PCR và xét nghiệm phân tử')
	,('LXNCC10',N'Xét nghiệm chẩn đoán nhiễm trùng hoặc bệnh lây truyền qua đường tình dục')
	,('LXNCC11',N'Xét nghiệm viêm và đánh giá phản ứng cơ thể')
	,('LXNCC12',N'Xét nghiệm chức năng tiêu hóa')
	select * from LoaiPT_XNCC
insert into BangGia([MaLoaiChiTietDV],[TenLoaiChiTietDV],[Gia],[MaKhoa],[LoaiPT_XNCC])
values
	 (N'DVCT03.1',N'Xét nghiệm đường huyết',100000,'K28','LXNCC07')
	,(N'DVCT03.2',N'Xét nghiệm HbAlc',200000,'K28','LXNCC07')
	,(N'DVCT03.4',N'Xét nghiệm lipid máu',300000,'K28','LXNCC07')
	,(N'DVCT03.5',N'Xét nghiệm số lượng tiểu cầu',150000,'K28','LXNCC07')
	,(N'DVCT03.6',N'Xét nghiệm huyết học cơ bản',200000,'K28','LXNCC07')
	,(N'DVCT03.7',N'Xét nghiệm chức năng tiêu hóa',500000,'K28','LXNCC12')
	,(N'DVCT03.9',N'Xét nghiệm CRP (Protein C phản ứng)',200000,'K28','LXNCC11')
	,(N'DVCT03.10',N'Xét nghiệm GeneXpert',1000000,'K28','LXNCC09')
	,(N'DVCT03.11',N'Xét nghiệm HPV',500000,'K28','LXNCC09')
	,(N'DVCT03.12',N'Xét nghiệm máu HCG',500000,'K28','LXNCC07')
	,(N'DVCT03.14',N'Xét nghiệm kháng thuốc sốt rét',600000,'K28','LXNCC09')
	,(N'DVCT03.15',N'Xét nghiệm máu phát hiện kháng thể sán lá gan',700000,'K28','LXNCC07')
	,(N'DVCT03.16',N'Xét nghiệm máu phát hiện kháng thể sán chó',700000,'K28','LXNCC07')
	,(N'DVCT03.17',N'Xét nghiệm máu để kiểm tra mất cân bằng hóa học',600000,'K28','LXNCC07')
	,(N'DVCT03.18',N'Xét nghiệm hormon',800000,'K28','LXNCC07')
	,(N'DVCT03.19',N'Xét nghiệm chức năng gan',500000,'K28','LXNCC07')
	,(N'DVCT03.20',N'Xét nghiệm PCR Đậu mùa khỉ',1000000,'K28','LXNCC09')
	,(N'DVCT03.21',N'Xét nghiệm nước tiểu',1000000,'K28','LXNCC08')
	,(N'DVCT03.22',N'Xét nghiệm phân tử PCR để chẩn đoán H5N1',700000,'K28','LXNCC09')
	,(N'DVCT03.23',N'Xét nghiệm máu phát hiện virus dại',400000,'K28','LXNCC07')
	,(N'DVCT03.24',N'Xét nghiệm máu tìm kháng thể giun đũa',200000,'K28','LXNCC07')

	,(N'DVCT01.1',N'Chụp cộng hưởng từ tim',700000,'K20','LXNCC05')
	,(N'DVCT01.2',N'Chụp động mạch vành',5500000,'K20','LXNCC02')
	,(N'DVCT01.3',N'Chụp PET',7000000,'K20','LXNCC04')
	,(N'DVCT01.4',N'Chụp MRI não',3000000,'K20','LXNCC05')
	,(N'DVCT01.5',N'Chụp X-Quang KUB',500000,'K20','LXNCC01')
	,(N'DVCT01.7',N'Chụp CT bụng',500000,'K20','LXNCC02')
	,(N'DVCT01.8',N'Chụp X-Quang phổi',500000,'K20','LXNCC01')
	,(N'DVCT01.9',N'Chụp CT nếu cần để kiểm tra tổn thương nội tạng',3000000,'K20','LXNCC02')
	,(N'DVCT01.10',N'Chụp CT nếu cần để kiểm tra tổn thương nội tạng',3000000,'K20','LXNCC02')
	,(N'DVCT01.11',N'Chụp X-quang khớp',750000,'K20','LXNCC01')
	,(N'DVCT01.12',N'Chụp X-quang ngực',800000,'K20','LXNCC01')
	,(N'DVCT01.13',N'Chụp X-Quang sọ não',750000,'K20','LXNCC01')
	,(N'DVCT01.14',N'Chụp X-Quang cột sống',300000,'K20','LXNCC01')
	,(N'DVCT01.15',N'Chụp X-Quang mắt',300000,'K20','LXNCC01')
	,(N'DVCT01.16',N'Chụp CT gan',300000,'K20','LXNCC02')
	,(N'DVCT01.17',N'Nội soi trực tràng hậu môn',600000,'K20','LXNCC03')
	
	,(N'DVCT02.2',N'Phẫu thuật nội soi lấy sỏi',15000000,'K25','L03')
	,(N'DVCT02.3',N'Phẫu thuật cắt ruột thừa',10000000,'K19','L06')
	,(N'DVCT02.4',N'Phẫu thuật cắt bỏ tĩnh mạch',20000000,'K25','L12')
	,(N'DVCT02.5',N'Điều trị laser loại bỏ tổn thương',5000000,'K07','L30')
	,(N'DVCT02.6',N'Phẫu thuật loại bỏ sán khỏi gan',15000000,'K25','L14')
	,(N'DVCT02.7',N'Phẫu thuật thay thủy tinh thể nhân tạo',20000000,'K03','L25')
	,(N'DVCT02.8',N'Phẫu thuật thay van tim',15000000,'K08','L01')
	,(N'DVCT02.10',N'Phẫu thuật cắt trĩ nội',10000000,'K25','L29')
	,(N'DVCT02.11',N'Điều trị bằng Laser',2000000,'K07','L30')
	,(N'DVCT02.12',N'Phẫu thuật tim mạch',2000000,'K25','L01')
	,(N'DVCT02.13',N'Phẫu thuật cắt một lá phổi',2000000,'K25','L02')
	,(N'DVCT02.14',N'Phẫu thuật ghép gan',2000000,'K25','L05')
	,(N'DVCT02.15',N'Phẫu thuật mở rộng động mạch cảnh',1500000,'K25','L07')
	,(N'DVCT02.16',N'Phẫu thuật lấy cục máu đông não',2500000,'K26','L08')
	,(N'DVCT02.17',N'Phẫu thuật cắt bỏ phần phổi do lao',2000000,'K25','L09')
	,(N'DVCT02.18',N'Phẫu thuật loại bỏ thai ngoài tử cung',3000000,'K18','L22')
	,(N'DVCT02.19',N'Phẫu thuật nang sán chó',3500000,'K25','L14')
	,(N'DVCT02.20',N'Phẫu thuật loại bỏ tĩnh mạch',1500000,'K25','L12')
	,(N'DVCT02.21',N'Phẫu thuật Mohs',2000000,'K07','L15')
	,(N'DVCT02.22',N'Phẫu thuật loại bỏ u não',5000000,'K26','L16')
	,(N'DVCT02.24',N'Phẫu thuật thay khớp gối',1500000,'K15','L18')
	,(N'DVCT02.25',N'Phẫu thuật ghép mạch vành',1500000,'K25','L19')
	,(N'DVCT02.26',N'Phẫu thuật cấy ghép tim',5000000,'K25','L20')
	,(N'DVCT02.27',N'Phẫu thuật cắt bỏ tử cung do băng huyết sau sinh',4000000,'K18','L22')
	,(N'DVCT02.28',N'Phẫu thuật loại bỏ gai xương',4000000,'K09','L23')
	,(N'DVCT02.29',N'Phẫu thuật loại bỏ tắc nghẽn do giun đũa',2500000,'K25','L24')
	,(N'DVCT02.30',N'Phẫu thuật cắt bỏ phần gan',3000000,'K25','L26')
	,(N'DVCT02.31',N'Phẫu thuật thay van động mạch chủ',5000000,'K19','L27')
	,(N'DVCT02.32',N'Phẫu thuật tái tạo dây thần kinh mặt',2500000,'K26','L28')

	,(N'DVCT06.1',N'Phục hồi chức năng não',2000000,'K12',null)
	,(N'DVCT06.2',N'Phục hồi chức năng sau phẫu thuật động mạch',500000,'K12',null)
	,(N'DVCT06.3',N'Liệu pháp hành vi',500000,'K23',null)
	,(N'DVCT06.4',N'Liệu pháp vật lý trị liệu',400000,'K12',null)
	,(N'DVCT06.5',N'Vật lý trị liệu cho khớp',1000000,'K12',null)
	,(N'DVCT06.6',N'Phục hồi chức năng sau Đột quỵ',6000000,'K12',null)
		
	,(N'DVCT08.1',N'Tư vấn dinh dưỡng và lối sống',400000,'K13',null)
	,(N'DVCT08.2',N'Tư vấn giấc ngủ',300000,'K23',null)
	,(N'DVCT08.4',N'Tư vấn phục hồi chức năng',300000,'K12',null)
	,(N'DVCT08.5',N'Tư vấn điều trị viêm tai',150000,'K21',null)

	,(N'DVCT09.1',N'Cấp cứu 24/7',200000,'K01',null)
	
	,(N'DVCT11.1',N'Siêu âm gan',400000,'K28','LXNCC06')
	,(N'DVCT11.2',N'Siêu âm tim',1200000,'K28','LXNCC06')
	,(N'DVCT11.3',N'Siêu âm tuyến giáp',700000,'K28','LXNCC06')
	,(N'DVCT11.4',N'Siêu âm để xác định vị trí của thai',750000,'K28','LXNCC06')

	,(N'DVCT04.1',N'Chăm sóc trước sinh',400000,'K18',null)
	,(N'DVCT04.2',N'Chăm sóc sau sinh',400000,'K18',null)
	,(N'DVCT04.3',N'Quản lý quá trình sinh nở',400000,'K18',null)

	,(N'DVCT12.1.1',N'Nằm phòng vip khoa hồi sức cấp cứu',4000000,'K01',null)
	,(N'DVCT12.1.2',N'Nằm phòng vip khoa nhi ',1000000,'K02',null)
	,(N'DVCT12.1.3',N'Nằm phòng vip khoa mắt',800000,'K03',null)
	,(N'DVCT12.1.4',N'Nằm phòng vip khoa tiêu hóa',1000000,'K04',null)
	,(N'DVCT12.1.5',N'Nằm phòng vip khoa nội tiết',1800000,'K05',null)
	,(N'DVCT12.1.6',N'Nằm phòng vip khoa Răng-Hàm-Mặt',900000,'K06',null)
	,(N'DVCT12.1.7',N'Nằm phòng vip khoa da liễu',1000000,'K07',null)
	,(N'DVCT12.1.8',N'Nằm phòng vip khoa tim mạch',1950000,'K08',null)
	,(N'DVCT12.1.9',N'Nằm phòng vip khoa cơ-xương-khớp',1000000,'K09',null)
	,(N'DVCT12.1.10',N'Nằm phòng vip khoa ung bướu',1200000,'K10',null)
	,(N'DVCT12.1.11',N'Nằm phòng vip khoa hô hấp',200000,'K11',null)
	,(N'DVCT12.1.12',N'Nằm phòng vip khoa vật lý trị liệu-phục hồi chức nặng',1000000,'K12',null)
	,(N'DVCT12.1.13',N'Nằm phòng vip khoa dinh dưỡng',850000,'K13',null)
	,(N'DVCT12.1.14',N'Nằm phòng vip khoa nội tổng hợp',1000000,'K14',null)
	,(N'DVCT12.1.15',N'Nằm phòng vip khoa chấn thương chỉnh hình',600000,'K15',null)
	,(N'DVCT12.1.16',N'Nằm phòng vip khoa phẫu thuật gây mê hồi sức',1000000,'K16',null)
	,(N'DVCT12.1.18',N'Nằm phòng vip khoa phụ sản',1400000,'K18',null)
	,(N'DVCT12.1.19',N'Nằm phòng vip khoa ngoại tổng hợp',1700000,'K19',null)
	,(N'DVCT12.1.21',N'Nằm phòng vip khoa Tai-Mũi-Họng',1350000,'K21',null)
	,(N'DVCT12.1.22',N'Nằm phòng vip khoa lao và bệnh phổi',1000000,'K22',null)
	,(N'DVCT12.1.23',N'Nằm phòng vip khoa tâm thần',2200000,'K23',null)
	,(N'DVCT12.1.24',N'Nằm phòng vip khoa thận ',900000,'K24',null)
	,(N'DVCT12.1.25',N'Nằm phòng vip khoa phẫu thuật',2200000,'K25',null)
	,(N'DVCT12.1.26',N'Nằm phòng vip khoa nội thần kinh ',1800000,'K27',null)
	,(N'DVCT12.1.27',N'Nằm phòng vip khoa ngoại thần kinh ',1900000,'K26',null)
	,(N'DVCT12.1.29',N'Nằm phòng vip khoa truyền nhiễm ',200000,'K29',null)

	

	,(N'DVCT12.2.1',N'Nằm phòng thường-2 giường khoa cấp cứu',1500000,'K01',null)
	,(N'DVCT12.2.2',N'Nằm phòng thường-2 giường khoa nhi ',900000,'K02',null)
	,(N'DVCT12.2.3',N'Nằm phòng thường-2 giường khoa mắt',700000,'K03',null)
	,(N'DVCT12.2.4',N'Nằm phòng thường-2 giường khoa tiêu hóa',900000,'K04',null)
	,(N'DVCT12.2.5',N'Nằm phòng thường-2 giường khoa nội tiết',1700000,'K05',null)
	,(N'DVCT12.2.6',N'Nằm phòng thường-2 giường khoa Răng-Hàm-Mặt',800000,'K06',null)
	,(N'DVCT12.2.7',N'Nằm phòng thường-2 giường khoa da liễu',900000,'K07',null)
	,(N'DVCT12.2.8',N'Nằm phòng thường-2 giường khoa tim mạch',1850000,'K08',null)
	,(N'DVCT12.2.9',N'Nằm phòng thường-2 giường khoa cơ-xương-khớp',900000,'K09',null)
	,(N'DVCT12.2.10',N'Nằm phòng thường-2 giường khoa ung bướu',1100000,'K10',null)
	,(N'DVCT12.2.11',N'Nằm phòng thường-2 giường khoa hô hấp',100000,'K11',null)
	,(N'DVCT12.2.12',N'Nằm phòng thường-2 giường khoa vật lý trị liệu-phục hồi chức nặng',900000,'K12',null)
	,(N'DVCT12.2.13',N'Nằm phòng thường-2 giường khoa dinh dưỡng',750000,'K13',null)
	,(N'DVCT12.2.14',N'Nằm phòng thường-2 giường khoa nội tổng hợp',900000,'K14',null)
	,(N'DVCT12.2.15',N'Nằm phòng thường-2 giường khoa chấn thương chỉnh hình',500000,'K15',null)
	,(N'DVCT12.2.16',N'Nằm phòng thường-2 giường khoa phẫu thuật gây mê hồi sức',900000,'K16',null)
	,(N'DVCT12.2.18',N'Nằm phòng thường-2 giường khoa phụ sản',1200000,'K18',null)
	,(N'DVCT12.2.19',N'Nằm phòng thường-2 giường khoa ngoại tổng hợp',1500000,'K19',null)
	,(N'DVCT12.2.21',N'Nằm phòng thường-2 giường khoa Tai-Mũi-Họng',1250000,'K21',null)
	,(N'DVCT12.2.22',N'Nằm phòng thường-2 giường khoa lao và bệnh phổi',900000,'K22',null)
	,(N'DVCT12.2.23',N'Nằm phòng thường-2 giường khoa tâm thần',2000000,'K23',null)
	,(N'DVCT12.2.24',N'Nằm phòng thường-2 giường khoa thận ',800000,'K24',null)
	,(N'DVCT12.2.25',N'Nằm phòng thường-2 giường khoa phẫu thuật',2000000,'K25',null)
	,(N'DVCT12.2.26',N'Nằm phòng thường-2 giường khoa nội thần kinh ',1700000,'K27',null)
	,(N'DVCT12.2.27',N'Nằm phòng thường-2 giường khoa ngoại thần kinh ',1700000,'K26',null)
	,(N'DVCT12.2.29',N'Nằm phòng thường-2 giường khoa truyền nhiễm ',1700000,'K29',null)

	,(N'DVCT12.3.1',N'Nằm phòng thường-3 giường',1400000,'K01',null)
	,(N'DVCT12.3.2',N'Nằm phòng thường-3 giường khoa nhi ',800000,'K02',null)
	,(N'DVCT12.3.3',N'Nằm phòng thường-3 giường khoa mắt',600000,'K03',null)
	,(N'DVCT12.3.4',N'Nằm phòng thường-3 giường khoa tiêu hóa',800000,'K04',null)
	,(N'DVCT12.3.5',N'Nằm phòng thường-3 giường khoa nội tiết',1600000,'K05',null)
	,(N'DVCT12.3.6',N'Nằm phòng thường-3 giường khoa Răng-Hàm-Mặt',700000,'K06',null)
	,(N'DVCT12.3.7',N'Nằm phòng thường-3 giường khoa da liễu',800000,'K07',null)
	,(N'DVCT12.3.8',N'Nằm phòng thường-3 giường khoa tim mạch',1750000,'K08',null)
	,(N'DVCT12.3.9',N'Nằm phòng thường-3 giường khoa cơ-xương-khớp',800000,'K09',null)
	,(N'DVCT12.3.10',N'Nằm phòng thường-3 giường khoa ung bướu',1000000,'K10',null)
	,(N'DVCT12.3.11',N'Nằm phòng thường-3 giường khoa hô hấp',900000,'K11',null)
	,(N'DVCT12.3.12',N'Nằm phòng thường-3 giường khoa vật lý trị liệu-phục hồi chức nặng',800000,'K12',null)
	,(N'DVCT12.3.13',N'Nằm phòng thường-3 giường khoa dinh dưỡng',650000,'K13',null)
	,(N'DVCT12.3.14',N'Nằm phòng thường-3 giường khoa nội tổng hợp',800000,'K14',null)
	,(N'DVCT12.3.15',N'Nằm phòng thường-3 giường khoa chấn thương chỉnh hình',400000,'K15',null)
	,(N'DVCT12.3.16',N'Nằm phòng thường-3 giường khoa phẫu thuật gây mê hồi sức',800000,'K16',null)
	,(N'DVCT12.3.18',N'Nằm phòng thường-3 giường khoa phụ sản',1100000,'K18',null)
	,(N'DVCT12.3.19',N'Nằm phòng thường-3 giường khoa ngoại tổng hợp',1400000,'K19',null)
	,(N'DVCT12.3.21',N'Nằm phòng thường-3 giường khoa Tai-Mũi-Họng',1150000,'K21',null)
	,(N'DVCT12.3.22',N'Nằm phòng thường-3 giường khoa lao và bệnh phổi',800000,'K22',null)
	,(N'DVCT12.3.23',N'Nằm phòng thường-3 giường khoa tâm thần',1900000,'K23',null)
	,(N'DVCT12.3.24',N'Nằm phòng thường-3 giường khoa thận ',700000,'K24',null)
	,(N'DVCT12.3.25',N'Nằm phòng thường-3 giường khoa phẫu thuật',1800000,'K25',null)
	,(N'DVCT12.3.26',N'Nằm phòng thường-3 giường khoa ngoại thần kinh',1600000,'K26',null)
	,(N'DVCT12.3.27',N'Nằm phòng thường-3 giường khoa nội thần kinh ',1600000,'K27',null)
	,(N'DVCT12.3.29',N'Nằm phòng thường-3 giường khoa truyền nhiễm ',1600000,'K29',null)

	,(N'DVCT12.4.1',N'Nằm phòng thường-4 giường khoa cấp cứu',800000,'K01',null)
	,(N'DVCT12.4.2',N'Nằm phòng thường-4 giường khoa nhi ',400000,'K02',null)
	,(N'DVCT12.4.3',N'Nằm phòng thường-4 giường khoa mắt',400000,'K03',null)
	,(N'DVCT12.4.4',N'Nằm phòng thường-4 giường khoa tiêu hóa',500000,'K04',null)
	,(N'DVCT12.4.5',N'Nằm phòng thường-4 giường khoa nội tiết',800000,'K05',null)
	,(N'DVCT12.4.6',N'Nằm phòng thường-4 giường khoa Răng-Hàm-Mặt',500000,'K06',null)
	,(N'DVCT12.4.7',N'Nằm phòng thường-4 giường khoa da liễu',300000,'K07',null)
	,(N'DVCT12.4.8',N'Nằm phòng thường-4 giường khoa tim mạch',1000000,'K08',null)
	,(N'DVCT12.4.9',N'Nằm phòng thường-4 giường khoa cơ-xương-khớp',500000,'K09',null)
	,(N'DVCT12.4.10',N'Nằm phòng thường-4 giường khoa ung bướu',700000,'K10',null)
	,(N'DVCT12.4.11',N'Nằm phòng thường-4 giường khoa hô hấp',500000,'K11',null)
	,(N'DVCT12.4.12',N'Nằm phòng thường-4 giường khoa vật lý trị liệu-phục hồi chức nặng',400000,'K12',null)
	,(N'DVCT12.4.13',N'Nằm phòng thường-4 giường khoa dinh dưỡng',450000,'K13',null)
	,(N'DVCT12.4.14',N'Nằm phòng thường-4 giường khoa nội tổng hợp',500000,'K14',null)
	,(N'DVCT12.4.15',N'Nằm phòng thường-4 giường khoa chấn thương chỉnh hình',300000,'K15',null)
	,(N'DVCT12.4.16',N'Nằm phòng thường-4 giường khoa phẫu thuật gây mê hồi sức',600000,'K16',null)
	,(N'DVCT12.4.18',N'Nằm phòng thường-4 giường khoa phụ sản',900000,'K18',null)
	,(N'DVCT12.4.19',N'Nằm phòng thường-4 giường khoa ngoại tổng hợp',900000,'K19',null)
	,(N'DVCT12.4.21',N'Nằm phòng thường-4 giường khoa Tai-Mũi-Họng',90000,'K21',null)
	,(N'DVCT12.4.22',N'Nằm phòng thường-4 giường khoa lao và bệnh phổi',700000,'K22',null)
	,(N'DVCT12.4.23',N'Nằm phòng thường-4 giường khoa tâm thần',1200000,'K23',null)
	,(N'DVCT12.4.24',N'Nằm phòng thường-4 giường khoa thận ',500000,'K24',null)
	,(N'DVCT12.4.25',N'Nằm phòng thường-4 giường khoa phẫu thuật',1300000,'K25',null)
	,(N'DVCT12.4.26',N'Nằm phòng thường-4 giường khoa ngoại thần kinh ',700000,'K27',null)
	,(N'DVCT12.4.27',N'Nằm phòng thường-4 giường khoa nội thần kinh ',700000,'K26',null)
	,(N'DVCT12.4.29',N'Nằm phòng thường-4 giường khoa truyền nhiễm ',1100000,'K29',null)
go
insert into LoaiBenhAn([MaLoaiBA],[TenLoaiBA])
values
	 ('LBA01',N'Bệnh án nội khoa')
	,('LBA02',N'Bệnh án ngoại khoa')
	,('LBA03',N'Bệnh án cấp cứu')
	,('LBA04',N'Bệnh án nhi khoa')
	,('LBA05',N'Bệnh án truyền nhiễm')
	,('LBA06',N'Bệnh án sản khoa')
	,('LBA07',N'Bệnh án ung bướu')
	,('LBA08',N'Bệnh án răng-hàm-mặt')
	,('LBA09',N'Bệnh án da liễu')
	,('LBA10',N'Bệnh án tâm thần')
	,('LBA11',N'Bệnh án tai mũi họng')
	,('LBA12',N'Bệnh án tiêu hóa')
	,('LBA13',N'Bệnh án dị ứng')
	,('LBA14',N'Bệnh án cơ-xương-khớp')
	,('LBA15',N'Bệnh án hô hấp')
	,('LBA16',N'Bệnh án nội tiết')
	,('LBA17',N'Bệnh án mắt')
	,('LBA18',N'Bệnh án tim mạch')
	,('LBA19',N'Bệnh án phục hồi chức năng')
	,('LBA20',N'Bệnh án thần kinh')
	,('LBA21',N'Bệnh án thận-tiết niệu')
	,('LBA22',N'Bệnh án phẫu thuật')
	,('LBA23',N'Bệnh án hình ảnh và xét nghiệm')
	,('LBA24',N'Bệnh án nội trú')
	,('LBA25',N'Bệnh án ngoại trú')
go
insert into BenhLy(MaBenh,TenBenh)
values
	 ('B01',N'Cảm cúm')
	,('B02',N'Đái tháo đường')
	,('B03',N'Tim mạch')
	,('B04',N'Ung thư phổi')
	,('B05',N'Alzheimer')
	,('B06',N'Sốt xuất huyết')
	,('B07',N'Táo bón')
	,('B08',N'Béo phì')
	,('B09',N'Đau mắt')
	,('B10',N'Sỏi thận')
	,('B11',N'Viêm tai giữa')
	,('B12',N'Xơ gan')
	,('B13',N'Viêm ruột thừa')
	,('B14',N'Hẹp động mạch cảnh')
	,('B15',N'Hoảng sợ khi ngủ')
	,('B16',N'Gout')
	,('B17',N'Đột quỵ')
	,('B18',N'Lao phổi')
	,('B19',N'Mụn cóc')
	,('B20',N'Mang thai ngoài tử cung')
	,('B21',N'Suy tĩnh mạch mạn tính')
	,('B22',N'Sủi mào gà')
	,('B23',N'Sốt rét')
	,('B24',N'Sán lá gan')
	,('B25',N'Parkinson')
	,('B26',N'Nhiễm sán chó')
	,('B27',N'Ung thư da')
	,('B29',N'Mất ngủ')
	,('B30',N'Mất cân bằng nội tiết tố')
	,('B31',N'Mụn bọc')
	,('B32',N'Mắt loạn thị')
	,('B34',N'U não')
	,('B37',N'Viêm mũi dị ứng thời tiết')
	,('B39',N'Xơ cứng bì')
	,('B40',N'Đậu mùa khỉ')
	,('B41',N'Đau khớp')
	,('B42',N'Đau thắt ngực')
	,('B43',N'Cơ tim giãn nở')
	,('B44',N'Cường giáp')
	,('B45',N'Chấn thương sọ não')
	,('B46',N'Băng huyết sau sinh')
	,('B47',N'Khó thở')
	,('B48',N'Hội chứng thận hư')
	,('B49',N'Gai xương')
	,('B51',N'Cúm H5N1')
	,('B52',N'Dại')
	,('B53',N'Dị ứng mắt')
	,('B54',N'Giun đũa')
	,('B55',N'Đậu mùa')
	,('B56',N'Đục thủy tinh thể')
	,('B57',N'Gan to')
	,('B58',N'Hẹp van động mạch chủ')
	,('B59',N'Liệt mặt')
	,('B60',N'Trĩ nội')
go
insert into BenhNhan(MSBN,TenBN,GioiTinh,NgSinh,DiaChi,NgheNghiep,SDT,CCCD,TTLienHe)
values
	 ('BN01',N'Trần Văn Hải',N'Nam','1978/09/24',N'Số 250 Đường Gò Tháp, Khóm 1, Thị trấn Mỹ An, Huyện Tháp Mười, Đồng Tháp',N'Nhân viên văn phòng','1122334455',N'001122334455','0827162389')
	,('BN02',N'Nguyễn Trung Minh',N'Nam','1999/06/17',N'Số 134 Nguyễn Tri Phương, Phường 2, Thành phố Bảo Lộc, Lâm Đồng',N'Sinh viên','2233445566','112233445566','0362516253')
	,('BN03',N'Trương Thanh Ngọc',N'Nữ','2006/04/06',N'197/5 Bích Khê, Phường Nghĩa Chánh, Thành phố Quảng Ngãi, Quảng Ngãi',N'Học sinh','3344556677','223344556677','0276546556')
	,('BN04',N'Nguyễn Thị Kiều Oanh',N'Nữ','2002/12/28',N'Số 20 Phạm Ngũ Lão, Phường Phú Hội, Thành phố Huế, Thừa Thiên - Huế',N'Trung tá','4455667788','334455667788','0489200543')
	,('BN05',N'Dương Anh Tuấn',N'Nam','1999/01/25',N'Số 14, ngõ 189/ 82 Nguyễn Ngọc Vũ, Phường Trung Hoà, Quận Cầu Giấy, Hà Nội',N'Bác sĩ','5566778899','445566778899','0267345634')
	,('BN06',N'Đặng Nguyễn Thùy Trâm',N'Nữ','1996/03/15',N'Số 08 đường Ninh Bình, Phường 2, Thành Phố Bạc Liêu, Bạc Liêu',N'Công nhân','6677889900','556677889900','0153236555')
	,('BN07',N'Lê Nam',N'Nam','2000/11/30',N'Số 97 ấp Hòa Đông A, Xã Hòa Hiệp, Huyện Tân Biên, Tây Ninh',N'Luật sư','7788990011','667788990011','0765214567')
	,('BN08',N'Trương Thanh Nhàn',N'Nữ','2009/03/28',N'Số 126, đường Lương Văn Thăng, Phường Đông Thành, Thành phố Ninh Bình, Ninh Bình',N'Học sinh','8899001122','778899001122','0906575456')
	,('BN09',N'Nguyễn Hà Anh',N'Nữ','2017/09/03',N'2/33 đường 147, KP5, Phường Tăng Nhơn Phú B, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Học sinh','9900112233','889900112233','0165786576')
	,('BN10',N'Bùi Văn Thể',N'Nam','1999/09/24',N'234, 236 Hùng Vương, Phường 7, TP Tuy Hoà, Phú Yên',N'Thượng tá','0011223344','990011223344','0326754897')
	,('BN11',N'Bùi Văn Nam',N'Nam','2002/09/24',N'234, 236 Hùng Vương, Phường 7, TP Tuy Hoà, Phú Yên',N'Sinh viên','0267192817','036782910234','0489086588')
	,('BN12',N'Lệ Quyên',N'Nữ','1979/10/14',N'Số 41 đường A5, Khu dân cư An Trang, Xã An Đồng, Huyện An Dương, Hải Phòng',N'Nhân viên văn phòng','0671981621','652917261234','0587434243')
	,('BN13',N'Nguyễn Lệ Nam',N'Nữ','2020/03/01',N'Số 09, Đường số 10, KDC Tây Đại Học, Phường Mỹ Phước, Thành phố Long Xuyên, An Giang',N'','','','0567834567')
	,('BN14',N'Ngụy Đại Huân',N'Nam','2003/06/07',N'Nhà số 45, phố Hồ Xuân Hương, khu Thanh An, Phường Vũ Ninh, Thành phố Bắc Ninh, Bắc Ninh',N'Sinh viên','0345619035','952089129021','0457896706')
	,('BN15',N'Ngô Hải Uyên',N'Nữ','2004/05/24',N'120 Vũ Tông Phan , Khu Phố 5, Phường An Phú, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Lập trình viên','0432167892','051298162341','0983243343')
	,('BN16',N'Đinh Nguyễn An Bình',N'Nữ','1999/03/03',N'Số 221/20A, đường Lý Thường Kiệt, khóm 3, Phường 6, Thành phố Cà Mau, Cà Mau',N'Giáo viên','2341090234','064752854310','0657891234')
	,('BN17',N'Trần Hoàng Thùy Lan',N'Nữ','2004/06/01',N'Số 28 Xuân Diệu, Tổ Dân Phố Hưng Lợi, Phường Hưng Trí, Thị xã Kỳ Anh, Hà Tĩnh',N'Sinh viên','2130842390','752306701234','0891657654')
	,('BN18',N'Lê Trần Hoàng Vũ',N'Nam','2002/06/12',N' 223 Hoàng Văn Thụ (K3.28 Cao ốc Kingston Residence), Phường 08, Quận Phú Nhuận, TP Hồ Chí Minh',N'Sinh viên','3208164021','048629542310','0175565465')
	,('BN19',N'Lê Văn Siêng',N'Nam','2021/02/24',N'72 Bình Giã, Phường 13, Quận Tân Bình, TP Hồ Chí Minh',N'','','','0548976765')
	,('BN20',N'Nguyễn Văn Hoàng',N'Nam','1990/09/22',N'59 Lý Thái Tổ, Phường Xuân Hoà, Thành phố Long Khánh, Đồng Nai',N'Kiểm lâm','3678912034','067912065301','0176876587')
	,('BN21',N'Dương Huy Hoàng',N'Nam','2004/03/27',N'Số 31 Vũ Phạm Hàm, Phường Yên Hoà, Quận Cầu Giấy, Hà Nội',N'Sinh viên','0099887766','009988776655','0652528762')
	,('BN22',N'Phan Ngọc Hiền',N'Nữ','1987/05/21',N'219C Võ Thị Sáu, Phường Thắng Tam, Thành Phố Vũng Tàu, Bà Rịa, Vũng Tàu.',N'Giám đốc','9988776655','998877665544','0362516253')
	,('BN23',N'Nguyễn Thế Hiển',N'Nam','1995/01/13',N'Số 98/14 Nguyễn Trung Trực, Phường 3, Thành phố Đà Lạt, Lâm Đồng',N'Y tá','8877665544','887766554433','0256432143')
	,('BN24',N'Trần Thị Duyên',N'Nữ','2001/02/20',N'33/9A Đường số 08, Khu phố 01, Phường Linh Xuân, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Lập trình viên','7766554433','776655443322','0243768754')
	,('BN25',N'Nguyễn Thị Kim Thanh',N'Nữ','2000/07/02',N'2/1 Trần Thị Vững, Khu Phố Bình Đường 3, Phường An Bình, Thành phố Dĩ An, Bình Dương',N'Đầu bếp','6655443322','990011223344','0436578910')
	,('BN26',N'Nguyễn Ngọc Hằng',N'Nữ','1950/04/05',N'Số 161 Ngô Gia Tự, Phường Chánh Nghĩa, Thành phố Thủ Dầu Một, Bình Dương',N'','2045240654','012856340841','0756589712')
	,('BN27',N'Ngô Kim Uyên',N'Nữ','2000/07/02',N'Số 740/36, ấp 6B, Xã Tân Hòa, Huyện Châu Thành A, Hậu Giang',N'Kỹ sư xây dựng','0543284544','767632018324','089765890')
	,('BN28',N'Trần Quốc Cường',N'Nam','2022/07/28',N'Số 441 Đà Nẵng, Phường Đông Hải 1, Quận Hải An, Hải Phòng',N'','','','0657865432')
	,('BN29',N'Đỗ Đức',N'Nam','2006/06/02',N'53 Nguyễn Huệ, Phường Vĩnh Ninh, Thành phố Huế, Thừa Thiên, Huế.',N'Học sinh','0236849377','276085634012','0988780876')
	,('BN30',N'Trần Mai Anh',N'Nữ','2000/01/12',N'08 Nguyễn Huệ, Phường Vĩnh Ninh, Thành phố Huế, Thừa Thiên, Huế.',N'Đầu bếp','0239956713','247915803000','0456235645')
	,('BN31',N'Nguyễn Ngọc Minh Châu',N'Nữ','1990/05/09',N' Tổ 14, ấp Mỹ Tân, Xã Mỹ Xuân, Huyện Tân Thành, Bà Rịa - Vũng Tàu',N'Nhân viên ngân hàng','0921587623','436869942134','0975435478')
	,('BN32',N'Lê Hoàng Nam',N'Nam','1987/07/02',N'1001/2 /5 Đường Nguyễn Thị Định, Khu Phố 3, Phường Cát Lái, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Nội trợ','6593201548','064582890123','0176876543')
	,('BN33',N'Nguyễn Hương Giang',N'Nữ','2004/12/21',N'Số 1445 đường Phạm Văn Thuận, KP 2, Phường Thống Nhất, Thành phố Biên Hoà, Đồng Nai',N'Nhân viên Marketing','4354021897','343451789238','0465768765')
	,('BN34',N'Nguyễn Huy Hoàng',N'Nam','1990/08/13',N'Số 205, Đại lộ Bình Dương, Tổ 18, Khu phố 2, Phường Mỹ Phước, Thị Xã Bến Cát, Bình Dương',N'Nhà văn','0382315636','064835373523','0532567345')
	,('BN35',N'Nguyễn Hoàng Hiệp',N'Nam','2000/06/11',N'1028 Nguyễn Tất Thành, Phường Phú Bài, Thị xã Hương Thuỷ, Thừa Thiên - Huế',N'Kế toán','0264293456','215636241243','0346654561')
	,('BN36',N'Lê Đình Minh Đăng',N'Nam','1987/11/12',N'212.I10 Nguyễn Hữu Cảnh, Phường Thắng Nhất, Thành Phố Vũng Tàu, Bà Rịa, Vũng Tàu',N'Giáo viên','0865785867','897068086896','0876543256')
	,('BN37',N'Lê Quỳnh Như',N'Nữ','2002/04/24',N'Số 12 Lê Đình Lý, Phường Nhơn Bình, Thành phố Quy Nhơn, Bình Định',N'Nhà thơ','0362759234','328739763512','0785439087')
	,('BN38',N'Lê Tùng Ưng',N'Nam','2001/12/08',N'Tổ 1, Khu phố 4, Phường Phước Hưng, Thành phố Bà Rịa, Bà Rịa, Vũng Tàu',N'','0537856473','875261906521','065458987')
	,('BN39',N'Phan Đức An',N'Nam','2003/09/08',N'Nhà số 7D Tổ dân phố Xuân Mai, Thị trấn Xuân Mai, Huyện Chương Mỹ, Hà Nội',N'Sinh viên','0689246577','452789456717','0654789654')
	,('BN40',N'Trần Xuân Phương',N'Nữ','1998/08/16',N'Số 31 Vũ Phạm Hàm, Phường Yên Hoà, Quận Cầu Giấy, Hà Nội',N'Cảnh sát','0686281656','876529175214','0654356789')
	,('BN41',N'Trần My',N'Nữ','2000/09/14',N'Bình Số 41 đường A5, Khu dân cư An Trang, Xã An Đồng, Huyện An Dương, Hải Phòng',N'Diễn viên','0590472197','439900776655','0876321432')
	,('BN42',N'Trần Thị Thùy Linh',N'Nữ','2002/06/09',N'Số 125 Lô 16 Mở Rộng Trung Hành 5, Phường Đằng Lâm, Quận Hải An, Hải Phòng',N'Đầu bếp','0745689321','653475874365','0654128765')
	,('BN43',N'Phạm Hoàng Ngọc Trân',N'Nữ','2001/09/18',N'9 Phạm Ngũ Lão, KP. Thắng Lợi 2, Phường Dĩ An, Thành phố Dĩ An, Bình Dương',N'Nhân viên văn phòng','0812368197','856701652617','0955765435')
	,('BN44',N'Phạm Minh Trí',N'Nam','2002/06/17',N'289/14 Nguyễn Đức Thuận, Phường Hiệp Thành, Thành phố Thủ Dầu Một, Bình Dương',N'','0456814953','542957451782','0540093243')
	,('BN45',N'Ngô Thị Phương Anh',N'Nữ','1998/06/11',N'Số 1B Đường số 30, Khu phố 2, Phường An Khánh, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Kiểm toán','0543876534','450589705432','0657980087')
	,('BN46',N'Ngô Anh Khôi',N'Nam','1986/11/22',N'8/7 Đường 49B, Khu phố 4, Phường Thảo Điền, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Kiểm lâm','0452785436','767634200975','0465281761')
	,('BN47',N'Đinh Công Tùng',N'Nam','2023/07/02',N'12A Đường 109, Khu phố 5, Phường Phước Long B, Thành phố Thủ Đức, TP Hồ Chí Minh',N'','','','0653356781')
	,('BN48',N'Đinh Việt Hoàng',N'Nam','2007/01/02',N'12A Đường 109, Khu phố 5, Phường Phước Long B, Thành phố Thủ Đức, TP Hồ Chí Minh',N'Học sinh','','054365743789','0186567890')
	,('BN49',N'Nguyễn Văn Phú',N'Nam','1954/08/30',N'32 Cao Đức Lân, Phường An Phú, Thành phố Thủ Đức, TP Hồ Chí Minh',N'','0721386598','658973347676','0467362531')
	,('BN50',N'Lê Quỳnh Như',N'Nữ','2000/08/27',N'Số G21 tổ 19, khu phố 7A, Phường Long Bình, Thành phố Biên Hoà, Đồng Nai',N'Nhân viên bán hàng','0652812453','432143276564','0654787621')
go
insert into HoSoBenhAn([MaHoSoBA],[MSBN],[NgayTao])
values
	 ('HOSOKBBN01','BN01','1978/09/24')
	,('HOSOKBBN02','BN02','1999/06/17')
	,('HOSOKBBN03','BN03','2006/04/06')
	,('HOSOKBBN04','BN04','2002/12/28')
	,('HOSOKBBN05','BN05','1999/01/25')
	,('HOSOKBBN06','BN06','1996/03/15')
	,('HOSOKBBN07','BN07','2000/11/30')
	,('HOSOKBBN08','BN08','2009/03/28')
	,('HOSOKBBN09','BN09','2017/09/03')
	,('HOSOKBBN10','BN10','1999/09/24')
	,('HOSOKBBN11','BN11','2002/09/24')
	,('HOSOKBBN12','BN12','1979/10/14')
	,('HOSOKBBN13','BN13','2020/03/01')
	,('HOSOKBBN14','BN14','2003/06/07')
	,('HOSOKBBN15','BN15','2004/05/24')
	,('HOSOKBBN16','BN16','1999/03/03')
	,('HOSOKBBN17','BN17','2024/06/01')
	,('HOSOKBBN18','BN18','2002/06/12')
	,('HOSOKBBN19','BN19','2021/02/24')
	,('HOSOKBBN20','BN20','1990/09/22')
	,('HOSOKBBN21','BN21','2004/03/27')
	,('HOSOKBBN22','BN22','1987/05/21')
	,('HOSOKBBN23','BN23','1995/01/13')
	,('HOSOKBBN24','BN24','2001/02/20')
	,('HOSOKBBN25','BN25','2000/07/02')
	,('HOSOKBBN26','BN26','1950/04/05')
	,('HOSOKBBN27','BN27','2000/07/02')
	,('HOSOKBBN28','BN28','2022/07/28')
	,('HOSOKBBN29','BN29','2006/06/02')
	,('HOSOKBBN30','BN30','2000/01/12')
	,('HOSOKBBN31','BN31','2004/05/09')
	,('HOSOKBBN32','BN32','1987/07/02')
	,('HOSOKBBN33','BN33','2004/12/21')
	,('HOSOKBBN34','BN34','1990/08/13')
	,('HOSOKBBN35','BN35','2000/06/11')
	,('HOSOKBBN36','BN36','1987/11/12')
	,('HOSOKBBN37','BN37','2002/04/24')
	,('HOSOKBBN38','BN38','2001/12/08')
	,('HOSOKBBN39','BN39','2003/09/08')
	,('HOSOKBBN40','BN40','1998/08/16')
	,('HOSOKBBN41','BN41','2000/09/14')
	,('HOSOKBBN42','BN42','2002/06/09')
	,('HOSOKBBN43','BN43','2001/09/18')
	,('HOSOKBBN44','BN44','2002/06/17')
	,('HOSOKBBN45','BN45','1998/06/11')
	,('HOSOKBBN46','BN46','1986/11/22')
	,('HOSOKBBN47','BN47','2023/07/02')
	,('HOSOKBBN48','BN48','2007/01/02')
	,('HOSOKBBN49','BN49','1964/08/30')
	,('HOSOKBBN50','BN50','2000/08/27')
go
insert into Thuoc([MSThuoc],[TenThuoc],[DangThuoc],[DonViTinh],[DonGia],[Xuatxu])
values
	 ('TH01',N'Paracetamol',N'Viên nén',N'Viên',50000,N'Mỹ')
	,('TH02',N'Ibuprofen',N'Viên nén',N'Viên',200000,N'Việt Nam')
	,('TH03',N'Oseltamivir',N'Viên nang',N'Viên',15000,N'Thụy Sĩ')
	,('TH04',N'Metformin',N'Viên nén',N'Viên',8000,N'Việt Nam')
	,('TH05',N'Glipizide',N'Viên nén',N'Viên',8800,N'Việt Nam')
	,('TH06',N'Atorvastatin',N'Viên nén',N'Viên',3000,N'Ấn Độ')
	,('TH07',N'Bisoprolol',N'Viên nén',N'Viên',25000,N'Đức')
	,('TH08',N'Erlotinib',N'Viên nén',N'Viên',80000,N'Mỹ')
	,('TH09',N'Docetaxel',N'Dung dịch tiêm',N'Lọ',2500000,N'Pháp')
	,('TH10',N'Pemetrexed',N'Bột pha tiêm',N'Lọ',1500000,N'Mỹ')
	,('TH11',N'Donepezil',N'Viên nén',N'Viên',45000,N'Ấn Độ')
	,('TH12',N'Ramipril',N'Viên nén',N'Viên',3500,N'Canada')
	,('TH13',N'Rivastigmine',N'Miếng dán',N'Miếng',60000,N'Thụy Sĩ')
	,('TH14',N'ORS',N'Gói pha nước',N'Gói',3000,N'Ấn Độ')
	,('TH15',N'Albumin',N'Dung dịch truyền',N'Túi',500000,N'Mỹ')
	,('TH16',N'Lactulose',N'Siro',N'ml',120000,N'Pháp')
	,('TH17',N'Senna',N'Viên nén',N'Viên',5000,N'Ấn Độ')
	,('TH18',N'Bisacodyl',N'Viên nén',N'Viên',3000,N'Đức')
	,('TH19',N'Orlistat',N'Viên nén',N'Viên',7000,N'Mỹ')
	,('TH20',N'Phentermine ',N'Viên nén',N'Viên',3000,N'Mỹ')
	,('TH21',N'Bupropion',N'Viên nén',N'Viên',20000,N'Mỹ')
	,('TH22',N'Naphazoline',N'Nhỏ mắt',N'Chai',50000,N'Đức')
	,('TH23',N'Tobramycin',N'Nhỏ mắt',N'Chai',75000,N'Ý')
	,('TH24',N'Moxifloxacin',N'Nhỏ mắt',N'Chai',85000,N'Ấn Độ')
	,('TH25',N'Tamsulosin',N'Viên',N'Viên',30000,N'Mỹ')
	,('TH26',N'Potassium citrate',N'Viên sủi',N'Viên',40000,N'Canada')
	,('TH27',N'Allopurinol',N'Viên',N'Viên',20000,N'Ấn Độ')
	,('TH28',N'Amoxicillin',N'Viên',N'Viên',50000,N'Ấn Độ')
	,('TH29',N'Cefuroxime',N'Viên',N'Viên',80000,N'Mỹ')
	,('TH30',N'Spironolactone',N'Viên',N'Viên',40000,N'Ấn Độ')
	,('TH31',N'Propranolol',N'Viên',N'Viên',25000,N'Mỹ')
	,('TH32',N'Amoxicillin',N'Viên nén',N'Viên',50000,N'Anh')
	,('TH33',N'Metronidazole',N'Viên nén',N'Viên',45000,N'Pháp')
	,('TH34',N'Atorvastatin',N'Viên nén',N'Viên',20000,N'Mỹ')
	,('TH35',N'Amlodipine',N'Viên nén',N'Viên',20000,N'Ấn Độ')
	,('TH36',N'Clopidogrel',N'Viên nén',N'Viên',30000,N'Pháp')
	,('TH37',N'Sertraline',N'Viên nén',N'Viên',18000,N'Mỹ')
	,('TH38',N'Diazepam',N'Viên nén',N'Viên',10000,N'Anh')
	,('TH39',N'Quetiapine',N'Viên nén',N'Viên',25000,N'Canada')
	,('TH40',N'Colchicine',N'Viên nén',N'Viên',10000,N'Pháp')
	,('TH41',N'Febuxostat',N'Viên nén',N'Viên',20000,N'Nhật Bản')
	,('TH42',N'Probenecid',N'Viên nén',N'Viên',20000,N'Canada')
	,('TH43',N'Aspirin',N'Viên nén',N'Viên',25000,N'Ấn Độ')
	,('TH44',N'Warfarin',N'Viên nén',N'Viên',2000,N'Mỹ')
	,('TH45',N'Isoniazid',N'Viên nén',N'Viên',500,N'Ấn Độ')
	,('TH46',N'Rifampin',N'Viên nén',N'Viên',2000,N'Pháp')
	,('TH47',N'Pyrazinamide',N'Viên nén',N'Viên',2000,N'Mỹ')
	,('TH48',N'Compound W',N'Dung dịch',N'ml',200000,N'Mỹ')
	,('TH49',N'Compound W Freeze Off',N'Bình xịt',N'Bộ',50000,N'Mỹ')
	,('TH51',N'Methotrexate',N'Tiêm',N'Lọ',500000,N'Mỹ')
	,('TH52',N'Warfarin',N'Viên',N'Viên',5000,N'Mỹ')
	,('TH53',N'Furosemide',N'Viên',N'Viên',500,N'Ấn Độ')
	,('TH54',N'Diclofenac',N'Gel',N'Hộp',150000,N'Việt Nam')
	,('TH55',N'Podofilox',N'Dung dịch',N'Chai',150000,N'Mỹ')
	,('TH56',N'Imiquimod',N'Kem',N'Tuýt',1000000,N'Canada')
	,('TH57',N'Artesunate',N'Viên nén',N'Viên',50000,N'Việt Nam')
	,('TH58',N'Quinine',N'Dung dịch',N'Chai',1000000,N'Pháp')
	,('TH59',N'Doxycycline',N'Viên nén',N'Viên',300000,N'Mỹ')
	,('TH60',N'Triclabendazole',N'Viên nén',N'Viên',400000,N'Anh')
	,('TH61',N'Praziquantel',N'Viên nén',N'Viên',300000,N'Đức')
	,('TH62',N'Levodopa',N'Viên nén',N'Viên',500000,N'Mỹ')
	,('TH63',N'Selegiline',N'Viên nén',N'Viên',300000,N'Đức')
	,('TH64',N'Albendazole',N'Viên nén',N'Viên',300000,N'Ấn Độ')
	,('TH65',N'Mebendazole',N'Viên nén',N'Viên',250000,N'Mỹ')
	,('TH66',N'Melatonin',N'Viên nén',N'Viên',10000,N'Canada')
	,('TH67',N'Valerian Root',N'Viên nang',N'Viên',5000,N'Anh')
	,('TH68',N'Levothyroxine',N'Viên nén',N'Viên',5000,N'Mỹ')
	,('TH69',N'Estrogen',N'Gel',N'Tuýt',200000,N'Pháp')
	,('TH70',N'Metformin',N'Viên nén',N'Viên',12000,N'Ấn Độ')
	,('TH71',N'Isotretinoin',N'Viên nén',N'Viên',500000,N'Pháp')
	,('TH72',N'Tretinoin',N'Kem',N'Tuýt',300000,N'Pháp')
	,('TH73',N'Doxycycline',N'Viên nén',N'Viên',50000,N'Ấn Độ')
	,('TH74',N'Temozolomide',N'Viên nén',N'Viên',200000,N'Mỹ')
	,('TH75',N'Bevacizumab',N'Tiêm',N'Lọ',2000000,N'Mỹ')
	,('TH76',N'Dexamethasone',N'Viên nén',N'Viên',30000,N'Anh')
	,('TH77',N'Loratadine',N'Viên nén',N'Viên',50000,N'Ý')
	,('TH78',N'Fluticasone',N'Xịt mũi',N'Chai',100000,N'Anh')
	,('TH79',N'Pseudoephedrine',N'Viên nén',N'Viên',25000,N'Ấn Độ')
	,('TH80',N'Methotrexate',N'Viên nén',N'Viên',25000,N'Mỹ')
	,('TH81',N'Prednisone',N'Viên nén',N'Viên',50000,N'Anh')
	,('TH82',N'Tecovirimat',N'Viên nén',N'Viên',500000,N'Anh')
	,('TH83',N'Metoprolol',N'Viên nén',N'Viên',200000,N'Anh')
	,('TH84',N'Methimazole',N'Viên nén',N'Viên',55000,N'Việt Nam')
	,('TH85',N'Oxytocin',N'Tiêm',N'Lọ',15000,N'Pháp')
	,('TH86',N'Salbutamol',N'Hít',N'Bình xịt',201000,N'Anh')
	,('TH87',N'Mycophenolate mofetil',N'Viên nén',N'Viên',340000,N'Việt Nam')
	,('TH89',N'HRIG',N'Tiêm',N'ml',100000,N'Mỹ')
	,('TH90',N'Ketotifen',N'Nhỏ mắt',N'Chai',50000,N'Việt Nam')
	,('TH91',N'Olopatadine',N'Nhỏ mắt',N'Chai',60000,N'Anh')
	,('TH92',N'Antihistamines',N'Viên nén',N'Viên',15000,N'Mỹ')
	,('TH93',N'Acyclovir',N'Viên nén',N'Viên',10000,N'Việt Nam')
	,('TH94',N'Prednisolone acetate',N'Nhỏ mắt',N'Chai',200000,N'Mỹ')
	,('TH95',N'Ketorolac tromethamine',N'Nhỏ mắt',N'Chai',100000,N'Việt Nam')
	,('TH96',N'Lamivudine',N'Viên nén',N'Viên',20000,N'Việt Nam')
	,('TH97',N'Lisinopril',N'Viên',N'Viên',40000,N'Anh')
	,('TH98',N'Daflon',N'Viên nén',N'Viên',10000,N'Đức')
	,('TH99',N'Proctosedyl',N'Kem bôi',N'Tuýt',150000,N'Anh')
	,('TH100',N'Vaccine dại chuẩn',N'Dung dịch tiêm',N'Ống',150000,'Việt Nam')
	,('TH101',N'Vaccine dại không giết chết virus (vaccine dại tái tạo)',N'Dung dịch tiêm',N'Ống',260000,'Việt Nam')
	,('TH102',N'Vaccine dại kết hợp', N'Dung dịch tiêm',N'Ống',300000,'Việt Nam')
go
insert into ChuyenNganh([MaChuyenNganh],[TenChuyenNganh],[MaKhoa])
values
	 ('CN01.1',N'Cấp cứu khẩn cấp','K01')
	,('CN01.2',N'Hồi sức tính cực','K01')
	,('CN02.1',N'Nhi tim mạch','K02')
	,('CN02.2',N'Nhi hô hấp','K02')
	,('CN02.3',N'Nhi tiêu hóa','K02')
	,('CN02.4',N'Nhi tổng quát','K02')
	,('CN03.1',N'Nhãn khoa','K03')
	,('CN03.2',N'Tăng nhãn áp','K03')
	,('CN04.1',N'Tiêu hóa học','K04')
	,('CN04.2',N'Gan học','K04')
	,('CN05.1',N'Tiểu đường','K05')
	,('CN05.2',N'Rối loạn chức năng sinh dục','K05')
	,('CN05.3',N'Rối loạn tuyến giáp','K05')
	,('CN05.4',N'Nội tiết','K05')
	,('CN06.1',N'Nha khoa tổng quát','K06')
	,('CN06.2',N'Bệnh lý miệng','K06')
	,('CN07.1',N'Da liễu chung','K07')
	,('CN07.2',N'Bệnh truyền nhiễm da liễu','K07')
	,('CN07.3',N'Da liễu dị ứng','K07')
	,('CN08.1',N'Bệnh lý tim mạch tổng quát','K08')
	,('CN08.2',N'Can thiệp tim mạch','K08')
	,('CN08.3',N'Điện tâm đồ','K08')
	,('CN09.1',N'Bệnh xương khớp','K09')
	,('CN09.2',N'Phục hồi chức năng cơ-xương-khớp','K09')
	,('CN09.3',N'Chấn thương chỉnh hình','K09')
	,('CN10.1',N'Ung thư phổi','K10')
	,('CN10.2',N'Hóa trị liệu','K10')
	,('CN10.3',N'Xạ trị liệu','K10')
	,('CN11.1',N'Hen suyễn','K11')
	,('CN11.2',N'Bệnh lao và các bệnh nhiễm phổi khác','K11')
	,('CN12.1',N'Phục hồi chức năng cho chấn thương cột sống và não','K12')
	,('CN12.2',N'Quản lý đau mãn tính','K12')
	,('CN13.1',N'Dinh dưỡng lâm sàng','K13')
	,('CN13.2',N'Dinh dưỡng cho bệnh nhân suy dinh dưỡng và bệnh nhân cần chăm sóc đặc biệt','K13')
	,('CN14.1',N'Nội tổng hợp','K14')
	,('CN15.1',N'Chấn thương chỉnh tổng quát','K15')
	,('CN15.2',N'Phẫu thuật chấn thương','K15')
	,('CN16.1',N'Gây mê tổng quát','K16')
	,('CN16.2',N'Hồi sức cấp cứu','K16')
	,('CN18.1',N'Phụ khoa','K18')
	,('CN18.2',N'Sản khoa','K18')
	,('CN19.1',N'Phẫu thuật tim mạch','K19')
	,('CN19.2',N'Phẫu thuật tiêu hóa','K19')
	,('CN19.3',N'Phẫu thuật tổng quát','K19')
	,('CN19.4',N'Phẫu thuật ung bướu','K19')
	,('CN20.1',N'Radiology','K20')
	,('CN21.1',N'Rhinology','K21')
	,('CN21.2',N'Otology','K21')
	,('CN22.1',N'Lao','K22')
	,('CN22.2',N'Ung thư phổi','K22')
	,('CN22.3',N'Hen suyễn','K22')
	,('CN23.1',N'Tâm thần học tổng quát','K23')
	,('CN23.2',N'Tâm thần học thần kinh','K23')
	,('CN24.1',N'Nephrology tổng quát','K24')
	,('CN25.1',N'Phẫu thuật thần kinh','K25')
	,('CN25.2',N'Phẫu thuật cơ-xương-khớp','K25')
	,('CN25.3',N'Phẫu thuật tiết niệu','K25')
	,('CN26.1',N'Phẫu thuật não','K26')
	,('CN26.2',N'Phẫu thuật tủy sống','K26')
	,('CN27.1',N'Bệnh parkinson và các loại rối loạn vận động','K27')
	,('CN27.2',N'Tai biến mạch máu não','K27')
	,('CN27.3',N'Giấc ngủ','K27')
	,('CN28.1',N'Xét nghiệm','K28')
	,('CN28.2',N'Nội soi','K28')
	,('CN28.3',N'Siêu âm','K28')
	--,('CN28.2',N'Hen suyễn','K28')
	--,('CN28.3',N'Các bệnh lý da liên quan đến dị ứng','K28')
	,('CN29.1',N'Bệnh truyền nhiễm nhiệt đới','K29')
	,('CN29.2',N'Bệnh truyền nhiễm trong cộng đồng','K29')
	--,('CN29.3',N'Hepatitis','K29')
	,('CN21.4',N'Tai-Mũi-Họng','K21')

insert into LoaiKham([MaLoaiKham],[TenLoaiKham],[Gia])
values
	 ('LK01',N'Khám dịch vụ',1300000)
	,('LK02',N'Khám bình thường',100000)

insert into ChucVu(MaCV,TenCV)
values
	 ('CV01',N'Bác sĩ')
	,('CV02',N'Y Tá')
	,('CV03',N'Trưởng khoa')
	,('CV04',N'Dược sĩ')
	
------------------------------------------NV Không khám dịch vụ----------------------------------------------
go
insert into NhanVien([MaNV],[TenNV],[GioiTinh],[SDT],[Email],[NgayBatDauLam],[MaCV],[MaKhoa])
values
     ('BS01',N'Cao Thanh Tùng',N'Nam','','','2001/02/12','CV01','K01')
	,('BS02',N'Cao Thanh Tùng',N'Nam','8625290162','caothanhtung@gmail.com','1999/08/23','CV01','K01')
	,('BS03',N'Vũ Hoàng Diệp',N'Nữ','2516816187','vuhoangdiep@gmail.com','1990/01/12','CV01','K01')
	,('BS04',N'Nguyễn Tiến Lực',N'Nam','7281861912','nguyentienluc@gmail.com','2001/05/12','CV01','K02')
	,('BS05',N'Lâm Lê Diệu Hằng',N'Nữ','5601827917','lamledieuhang@gmail.com','2002/01/12','CV01','K02')
	,('BS06',N'Phan Thanh Hải',N'Nam','2363872626','phanthanhhai@gmail.com','1990/04/12','CV01','K02')
	,('BS07',N'Lê Văn Thành',N'Nam','4597271621','levanthanh@gmail.com','2023/01/12','CV01','K01')
	,('BS08',N'Nguyễn Thị Thanh Trang',N'Nữ','2364281721','thanhtrang@gmail.com','2024/01/01','CV01','K02')
	,('BS09',N'Lê Thị Minh Châu',N'Nữ','6528126523','lethiminhchau@gmail.com','1990/07/12','CV01','K01')
	,('BS10',N'Hồng Tuấn An',N'Nam','1365290123','hongtuanan@gmail.com','2013/08/12','CV01','K02')
	,('BS11',N'Võ Thị Quỳnh Như',N'Nữ','2675433532','quynhnhu@gmail.com','2023/11/12','CV01','K03')
	,('BS12',N'Võ Văn Định',N'Nam','7542654176','vovandinh@gmail.com','2012/03/14','CV01','K03')
	,('BS13',N'Nguyễn Ngọc Hoàng',N'Nam','7625426512','nguyenngochoang@gmail.com','2022/09/12','CV01','K03')
	,('BS14',N'Đinh Văn Tỵ',N'Nam','654328765','dinhvanty@gmail.com','1954/03/24','CV01','K03')
	,('BS15',N'Nguyễn Thị Hải Thanh',N'Nữ','0865386543','nguyenthaithanh@gmail.com','2000/01/01','CV01','K04')
	,('BS16',N'Trương Duy Thái',N'Nam','2265726152','truongduythai@gmail.com','2007/04/12','CV01','K04')
	,('BS17',N'Bùi Quốc Đạt',N'Nam','5465768723','buiquocdat@gmail.com','2020/08/12','CV01','K04')
	,('BS18',N'Bùi Quốc Triệu',N'Nam','2543862716','buiquoctrieu@gmail.com','2021/01/30','CV01','K04')
	,('BS19',N'Hồ Hiền Lương',N'Nữ','5435423432','hohienluong@gmail.com','1954/06/12','CV01','K05')
	,('BS20',N'Phạm Thanh Nam',N'Nam','3426576543','phamthanhnam@gmail.com','2014/01/01','CV01','K05')
	,('BS21',N'Nguyễn Việt Triều',N'Nam','6432357654','nguyenviettrieu@gmail.com','2009/12/03','CV01','K05')
	,('BS22',N'Trà Thanh Phương',N'Nam','3464768909','trathanhphuong@gmail.com','1979/04/29','CV01','K05')
	,('BS23',N'Lê Xuân Đức',N'Nam','4534876543','lexuanduc@gmail.com','2023/12/12','CV01','K06')
	,('BS24',N'Nguyễn Quang Hòa',N'Nam','0726216372','nguyenquanghoa@gmail.com','2012/01/01','CV01','K06')
	,('BS25',N'Lê Văn Điền',N'Nam','1653872615','levandien@gmail.com','2005/12/23','CV01','K06')
	,('BS26',N'Lê Đức Hải',N'Nam','9765432678','leduchai@gmail.com','1954/03/24','CV01','K07')
	,('BS27',N'Trượng Văn Trang',N'Nam','2546109876','truongvantrang@gmail.com','1954/03/24','CV01','K07')
	,('BS28',N'Võ Thiên Nhàn',N'Nữ','6543543212','vothiennhan@gmail.com','1954/04/25','CV01','K07')
	,('BS29',N'Nguyễn Thị Phương',N'Nữ','6523862612','','1954/12/24','CV01','K07')
	,('BS30',N'Lê Thị Hồng Linh',N'Nữ','2651975412','lethihonglinh@gmail.com','1954/12/24','CV01','K08')
	,('BS31',N'Phạm Văn Kiên',N'Nam','5415087654','phamvankien@gmail.com','1954/03/01','CV01','K08')
	,('BS32',N'Nguyễn Thị Mỹ Nương',N'Nữ','','nguyenthimyphuong@gmail.com','2000/04/25','CV01','K08')
	,('BS33',N'Ngô Văn Tý',N'Nam','4236793456','','2001/06/12','CV01','K08')
	,('BS34',N'Hồ Thị Minh Hồng',N'Nữ','','','2023/05/21','CV01','K08')
	,('BS35',N'Hà Văn Tuất',N'Nam','5426516254','','2022/04/25','CV01','K09')
	,('BS36',N'Võ Thành Lộc',N'Nam','8754357891','vothanhloc@gmail.com','2004/04/28','CV01','K09')
	,('BS37',N'Phạm Tuấn Thanh',N'Nam','8965436764','phamtuanthanh@gmail.com','1955/04/25','CV01','K09')
	,('BS38',N'Phạm Ngọc Thái',N'Nam','','','2000/12/03','CV01','K09')
	,('BS39',N'Lưu Thị Khanh',N'Nữ','','','2024/03/30','CV01','K10')
	,('BS40',N'Lâm Xuân Uyên',N'Nữ','5427816589','lamxuanuyen@gmail.com','2003/07/21','CV01','K10')
	,('BS41',N'Trần Đức Anh',N'Nam','','','1999/04/25','CV01','K10')
	,('BS42',N'Đặng Thị Bé Thu',N'Nữ','4356890654','dangthibethu@gmail.com','2008/08/14','CV01','K10')
	,('BS43',N'Phan Thanh Tươi',N'Nam','3452343423','phanthanhtuoi@gmail.com','2002/08/19','CV01','K11')
	,('BS44',N'Nguyễn Thị Thanh Thủy',N'Nữ','','','1954/04/25','CV01','K11')
	,('BS45',N'Nguyễn Thị Thu Mai',N'Nữ','','','2000/05/12','CV01','K11')
	,('BS46',N'Vũ Hồng Quang',N'Nam','6478943254','vuhongquang@gmail.com','2003/12/03','CV01','K11')
	,('BS47',N'Nguyễn Thị Thu Hồng',N'Nữ','7625716325','','2009/08/06','CV01','K12')
	,('BS48',N'Thạch Minh Huy',N'Nam','','thachminhhuy@gmail.com','2009/08/06','CV01','K12')
	,('BS49',N'Nguyễn Văn Thuận',N'Nam','1234234234','nguyenvanthuan@gmail.com','2002/05/12','CV01','K12')
	,('BS50',N'Võ Thị Mười Hai',N'Nữ','','','1954/04/25','CV01','K13')
	,('BS51',N'Huỳnh Thị Chiêu Oanh',N'Nữ','5426516252','chieuoanh@gmail.com','2001/05/12','CV01','K13')
	,('BS52',N'Nguyễn Đình Phương Thảo',N'Nữ','7524615189','nguyendinhphuong@gmail.com','2016/09/10','CV01','K14')
	,('BS53',N'Nguyễn Văn Thịnh',N'Nam','','nguyenvanthinh@gmail.com','2010/04/28','CV01','K14')
	,('BS54',N'Lương Văn Ba',N'Nam','7896560876','luongvanba@gmail.com','2008/09/17','CV01','K14')
	,('BS55',N'Bùi Tiến Kiên',N'Nam','','','2002/05/12','CV01','K14')
	,('BS56',N'Hoàng Minh Chương',N'Nam','','hoangminhchuong@gmail.com','1997/08/22','CV01','K14')
	,('BS57',N'Phương Thị Ngọc Đào',N'Nữ','','','2002/05/12','CV01','K14')
	,('BS58',N'Nguyễn Phạm Minh Tùng',N'Nam','5428761523','nguyenphamminhtung@gmail.com','2004/05/12','CV01','K14')
	,('BS59',N'Phạm Thành Kiên',N'Nam','','phamthanhkien@gmail.com','2022/08/11','CV01','K14')
	,('BS60',N'Nguyễn Xuân Phúc',N'Nam','6534905432','nguyenxuanphuc@gmail.com','1995/05/12','CV01','K14')
	,('BS61',N'Hứa Minh Hải',N'Nam','','','1990/08/13','CV01','K15')
	,('BS62',N'Nguyễn Thái Bảo',N'Nam','1234234234','nguyenthaibao@gmail.com','2002/05/12','CV01','K15')
	,('BS63',N'Nguyễn Thị Vân Anh',N'Nữ','1234234234','nguyenvanthuan@gmail.com','2006/07/13','CV01','K15')
	,('BS64',N'Hoàng Đức Huy',N'Nam','5426171625','hoangduchuy@gmail.com','1999/01/02','CV01','K16')
	,('BS65',N'Nguyễn Thị Hân',N'Nữ','2541626524','nguyenthihan@gmail.com','1999/01/02','CV01','K16')
	,('BS66',N'Phùng Thị Hằng',N'Nữ','0265172615','phungthihang@gmail.com','1999/01/02','CV01','K16')
	,('BS67',N'Hoàng Văn Hoàng',N'Nam','6524167162','hoangvanhoang@gmail.com','1999/01/02','CV04','K17')
	,('BS68',N'Lê Văn Thành',N'Nam','','','1998/01/02','CV04','K17')
	,('BS69',N'Nguyễn Minh Triết',N'Nam','2451625162','nguyenminhtriet@gmail.com','2000/01/02','CV04','K17')
	,('BS70',N'Tăng Quốc Thịnh',N'Nam','5261736980','tangquocthinh@gmail.com','1999/01/02','CV01','K18')
	,('BS71',N'Ngô Văn Đến',N'Nam','','','2015/01/02','CV01','K18')
	,('BS72',N'Trần Thị Hoài Thu',N'Nữ','5432567894','','1999/01/02','CV01','K18')
	,('BS73',N'Nguyễn Mỹ Dung',N'Nữ','','','1978/01/02','CV01','K19')
	,('BS74',N'Huỳnh Trung Lập',N'Nam','5076426152','huynhtrunglap@gmail.com','1999/01/02','CV01','K19')
	,('BS75',N'Nguyễn Thanh Liêm',N'Nam','','','1999/01/02','CV01','K19')
	,('BS76',N'Võ Thành Nhân',N'Nam','2516281726','vothanhnhan@gmail.com','2003/03/04','CV01','K19')
	,('BS77',N'Phạm Nhật An',N'Nam','','phamnhatan@gmail.com','1999/01/02','CV01','K19')
	,('BS78',N'Phan Quỳnh Lan',N'Nữ','6534590765','phamquynhlan@gmail.com','1998/11/19','CV01','K19')
	,('BS79',N'Huỳnh Trung Lập',N'Nam','2516271621','huynhtrunglap@gmail.com','1999/01/02','CV01','K19')
	,('BS80',N'Nguyễn Thị Tân Sinh',N'Nam','','','1998/01/02','CV01','K20')
	,('BS81',N'Tôn Thất Trí Dũng',N'Nam','','tonttridung@gmail.com','1999/01/02','CV01','K20')
	,('BS82',N'Quách Thanh Dung',N'Nam','','','2004/01/02','CV01','K20')
	,('BS83',N'Ngô Văn Đoàn',N'Nam','6537261876','ngovandoan@gmail.com','1954/04/03','CV01','K21')
	,('BS84',N'Nguyễn Tất Bình',N'Nam','6241568910','nguyentanquyetn@gmail.com','1954/04/03','CV01','K21')
	,('BS85',N'Nguyễn Văn Quyết',N'Nam','','nguyenvanquyet@gmail.com','1954/04/03','CV01','K21')
	,('BS86',N'Đoàn Thị Hồng Hạnh',N'Nữ','','doanthihonghanh@gmail.com','2000/04/03','CV01','K21')
	,('BS87',N'Nguyễn Thanh Hưng',N'Nam','6726156171','nguyenthanhhung@gmail.com','1954/04/03','CV01','K22')
	,('BS88',N'Nguyễn Thanh Hưng',N'Nam','6726156171','nguyenthanhhung@gmail.com','1954/04/03','CV01','K22')
	,('BS89',N'Thái Bằng',N'Nam','5675356876','thaibang@gmail.com','1954/04/03','CV01','K23')
	,('BS90',N'Trần Thị Linh Chi',N'Nam','','','1954/04/03','CV01','K23')
	,('BS91',N'Thái Lăng',N'Nam','5675356654','thailang@gmail.com','1954/04/03','CV01','K24')
	,('BS92',N'Trần Thị Lam',N'Nữ','','','1954/04/03','CV01','K24')
	,('BS93',N'Nguyễn Thị Hoàng',N'ữ','','nguyenthihoang@gmail.com','2003/04/03','CV01','K25')
	,('BS94',N'Trần Hoàng Thùy',N'Nữ','','','1954/04/03','CV01','K25')
	,('BS95',N'Huỳnh Thoại Lan',N'Nữ','','','1954/04/03','CV01','K26')
	,('BS96',N'Trần Liên An',N'Nữ','5241615271','tranlienan@gmail.com','2003/04/03','CV01','K26')
	,('BS97',N'Phạm Thùy Nhung',N'Nữ','1625192837','','1954/04/03','CV01','K26')
	,('BS98',N'Bùi Tiến Đạt',N'Nam','','buitiendat@gmail.com','2001/06/23','CV01','K27')
	,('BS99',N'Đoàn Trung Hiệp',N'Nam','5865487658','tranlienan@gmail.com','2007/11/03','CV01','K27')
	,('BS100',N'Trần Hữu Tuấn',N'Nam','','tranhuutan@gmail.com','1954/08/03','CV01','K27')
	,('BS101',N'Khổng Trọng Thắng',N'Nam','','khongtrongthang@gmail.com','1988/09/12','CV01','K28')
	,('BS102',N'Phạm Ngọc Hoa',N'Nam','2538279171','phamngochoa@gmail.com','1999/11/12','CV01','K28')
	,('BS103',N'Dương Thế Vinh',N'Nam','2357917261','duongthevinhg@hgmail.com','2000/09/12','CV01','K28')
	,('BS104',N'Lê Hữu Đồng',N'Nam','','khongtrongthang@hgmail.com','1988/09/12','CV01','K29')
	,('BS105',N'Nguyễn Thị Nữ',N'Nữ','2653670187','nguyenthinu@hgmail.com','2001/09/12','CV01','K29')
	,('BS106',N'Lê Viết Cường',N'Nam','','levietcuong@hgmail.com','2000/05/27','CV01','K29')
	,('BS107',N'Cao Thanh Sơn',N'Nam','','','2001/02/12','CV01','K14')
	,('BS108',N'Vũ Văn Soát',N'Nam','','','1954/04/03','CV01','K22')
	,('BS109',N'Vũ Đình Toàn',N'Nam','2363872626','vudinhtoan@gmail.com','1991/05/12','CV01','K02')
	,('BS110',N'Vũ Đình Nam',N'Nam','2363872622','','2000/05/12','CV01','K02')
	,('BS111',N'Lê Thị Hường',N'Nữ','','','2002/01/12','CV01','K01')
	,('BS112',N'Nguyễn Tiến Quyết',N'Nam','0652615261','nguyentienquyet@gmail.com','1990/04/12','CV01','K01')
	,('BS113',N'Nguyễn Ngọc Ánh',N'Nữ','','','1968/03/13','CV01','K03')
	,('BS114',N'Trương Thị Vân',N'Nữ','0365287162','truongthivan@gmail.com','2000/01/01','CV01','K03')
	,('BS115',N'Đặng Quang Hưng',N'Nam','4532871623','','1970/04/10','CV01','K04')
	,('BS116',N'Lê Thị Hà Châu',N'Nữ','4532871624','lethihachau@gmail.com','1974/06/28','CV01','K04')
	,('BS117',N'Hoàng Thanh Thương',N'Nữ','','','1973/02/11','CV01','K05')
	,('BS118',N'Nguyễn Thị Thu Hiền',N'Nữ','0365276152','nguyenthithuhien@gmail.com','1973/02/11','CV01','K05')
	,('BS119',N'Đinh Thị Thanh Tâm',N'Nữ','0654326543','dinhthithanhtam@gmail.com','1984/08/21','CV01','K06')
	,('BS120',N'Nguyễn Thị Thu Hà',N'Nữ','','','1985/10/26','CV01','K06')
	,('BS121',N'Đào Minh Phương',N'Nữ','7652541876','daominhphuong@gmail.com','1985/10/26','CV01','K07')
	,('BS122',N'Nguyễn Thái Hanh',N'Nam','','','2007/02/17','CV01','K13')
	,('BS123',N'Đỗ Thị Thanh Thùy',N'Nữ','8743564321','dothithanhthuy@gmail.com','1990/04/17','CV01','K15')
	,('BS124',N'Trần Thị Huệ',N'Nữ','','','1989/07/09','CV01','K15')
	,('BS125',N'Nguyễn Quốc Tuấn',N'Nam','0654653245','nguyenquoctuan@gmail.com','2001/03/01','CV01','K16')
	,('BS126',N'Huỳnh Duy Anh',N'Nam','0167254123','huynhduyanh@gmail.com','2001/03/01','CV01','K18')
	,('BS127',N'Huỳnh Duy Anh',N'Nam','0167254154','','2003/03/01','CV01','K21')
	,('BS128',N'Văn Bội Ngọc',N'Nữ','0654267876','vanboingoc@gmail.com','1991/06/19','CV01','K21')
	,('BS129',N'Vũ Văn Tài',N'Nam','0654354323','vuvantai@gmail.com','2008/05/10','CV01','K22')
	,('BS130',N'Hồ Quỳnh Nhung',N'Nữ','','','1990/06/12','CV01','K22')
	,('BS131',N'Bùi Văn Giang',N'Nam','','buivangiang@gmail.com','2001/09/03','CV01','K22')
	,('BS132',N'Ngô Thị Thanh Tú',N'Nữ','0543652761','ngothithanhtu@gmail.com','1996/12/02','CV01','K23')
	,('BS133',N'Huỳnh Hoàng Khang',N'Nam','','','1996/12/02','CV01','K23')
	,('BS134',N'Nguyễn Quỳnh Hoa',N'Nữ','9876251542','','1998/05/08','CV01','K24')
	,('BS135',N'Đặng Thị Linh',N'Nữ','','dangthilinh@gmail.com','2001/11/11','CV01','K25')
	,('BS136',N'Đoàn Đức Dũng',N'Nam','3876276510','','2003/04/05','CV01','K25')
	,('BS137',N'Nguyễn Thị Lam',N'Nữ','','','1998/05/08','CV01','K25')
	,('BS138',N'Trương Bá Duy',N'Nam','0654354321','truongbaduy','2000/07/06','CV01','K26')
	,('BS139',N'Trần Thị Nguyệt Thanh',N'Nữ','0654765432','nguyetthanh@gmail.com','2000/04/05','CV01','K27')
	,('BS140',N'Phạm Bá Nha',N'Nam','','','2000/07/06','CV01','K27')
	,('BS141',N'Vũ Thị Thu Hoài',N'Nữ','','','2000/07/06','CV01','K27')
	,('BS142',N'Bùi Minh Thanh',N'Nam','0652542467','buiminhthanh@gmail.com','1993/06/16','CV01','K29')
	,('BS143',N'Phạm Anh Vũ',N'Nam','','','2005/07/06','CV01','K29')
	,('BS144',N'Nguyễn Huy Đức',N'Nam','6547875432','nguyenhuyduc@gmail.com','2007/02/17','CV01','K13')
	,('BS145',N'Lâm Phước Nguyên',N'Nam','3453234567','lamphuocnguyen@gmail.com','2020/03/02','CV01','K01')
	,('BS146',N'Bùi Văn Thảo',N'Nam','3453234561','buivanthao@gmail.com','2021/03/02','CV01','K01')
	,('BS147',N'Hồ Việt Triều',N'Nam','3453234562','','2023/05/02','CV01','K01')
	,('BS148',N'Nguyễn Quốc Toản',N'Nam','3453234563','nguyenquoctoan@gmail.com','2018/03/15','CV01','K01')
	,('BS149',N'Bùi Duy Hưng',N'Nam','3453234564','buiduyhung@gmail.com','2019/03/15','CV01','K01')
	,('BS150',N'Trương Sơn Lâm',N'Nam','3453234565','','2018/03/15','CV01','K01')
	,('BS151',N'Tạ Văn Đẹp',N'Nam','3453234566','tavandep@gmail.com','2015/11/20','CV01','K01')
	,('BS152',N'Võ Đức Nguyện',N'Nam','3453234567','','2016/09/01','CV01','K01')
	,('BS153',N'Bùi Xuân Thắng',N'Nam','3453234568','buixuanthang@gmail.com','2016/08/20','CV01','K01')

	-------------K02
	,('BS154',N'Lê Quang Nhân',N'Nam','3453234569','lequangnhan@gmail.com','2015/11/20','CV01','K02')
	,('BS155',N'Phạm Thành Sỹ',N'Nam','3453234570','','2016/03/11','CV01','K02')
	,('BS156',N'Vũ Hồng Quang',N'Nam','3453234571','vuhongquang@gmail.com','2016/11/20','CV01','K02')
	,('BS157',N'Nguyễn Văn Thuận',N'Nam','3453234572','','2014/11/20','CV01','K02')
	,('BS158',N'Vũ Xuân Viên',N'Nam','3453234573','','2016/11/20','CV01','K02')
	,('BS159',N'Lê Vinh Quy',N'Nam','','levinhquy@gmail.com','2005/11/20','CV01','K02')
	,('BS160',N'Nguyễn Thanh Liêm',N'Nam','','','2010/07/13','CV01','K02')
	,('BS161',N'Ngô Thanh Bình',N'Nam','3453234574','','2016/11/20','CV01','K02')
	---------------K03
	,('BS162',N'Nguyễn Sỹ Quang',N'Nam','3453234575','','2003/05/19','CV01','K03')
	,('BS163',N'Nguyễn Văn Hiểu',N'Nam','3453234576','','2006/09/09','CV01','K03')
	,('BS164',N'Phan Huy Ngọc',N'Nam','','phanhuyngoc@gmail.com','2013/04/28','CV01','K03')
	,('BS165',N'Tô Anh Dũng',N'Nam','','toanhdung@gmail.com','2012/05/29','CV01','K03')
	,('BS166',N'Nguyễn Hải Trung',N'Nam','3453234577','nguyenhaitrung@gmail.com','2003/06/16','CV01','K03')
	,('BS167',N'Nguyễn Hồng Phong',N'Nam','','nguyenhongphong@gmail.com','2003/05/19','CV01','K03')
	,('BS168',N'Bùi Quang Bình',N'Nam','3453234578','buiquangbinh@gmail.com','2015/10/21','CV01','K03')
	,('BS169',N'Vũ Thanh Chương',N'Nam','3453234579','','2023/01/02','CV01','K03')
	----------------K04
	,('BS170',N'Huỳnh Việt Hòa',N'Nam','','','2011/03/08','CV01','K04')
	,('BS171',N'Đỗ Thanh Bình',N'Nam','','','2011/03/08','CV01','K04')
	,('BS172',N'Lê Hồng Nam',N'Nam','','lehongnam@gmail.com','2014/08/12','CV01','K04')
	,('BS173',N'Nguyễn Thanh Trường',N'Nam','2546517819','nguyenthanhtruong@gmail.com','2007/11/12','CV01','K04')
	,('BS174',N'Nguyễn Thế Hùng',N'Nam','','nguyenthehung@gmail.com','2012/04/07','CV01','K04')
	,('BS175',N'Nguyễn Văn Hận',N'Nam','8657261789','nguyenvanhan@gmail.com','2022/06/12','CV01','K04')
	,('BS176',N'Nguyễn Hồng Nhật',N'Nam','','nguyenhongnhat@gmail.com','2002/03/08','CV01','K04')
	,('BS177',N'Đỗ Viết Giang',N'Nam','','dovietgiang@gmail.com','2022/09/01','CV01','K04')
	-------------K05
	,('BS178',N'Thái Hồng Công',N'Nam','','','2011/03/08','CV01','K04')
	,('BS179',N'Cao Minh Huyền',N'Nam','0652765176','caominhhuyen@gmail.com','2012/06/19','CV01','K04')
	,('BS180',N'Trương Minh Đương',N'Nam','','truongminhduong@gmail.com','2012/06/19','CV01','K04')
	,('BS181',N'Lâm Minh Hồng',N'Nam','0652765174','lamminhhong@gmail.com','2022/11/29','CV01','K04')
	,('BS182',N'Nguyễn Hữu Mạnh',N'Nam','','','2024/01/01','CV01','K04')
	,('BS183',N'Bùi Quang Thanh',N'Nam','0654259872','buiquangthanh@gmail.com','2021/01/17','CV01','K04')
	,('BS184',N'Đặng Trọng Cường',N'Nam','0652765173','','2013/02/03','CV01','K04')
	,('BS185',N'Huỳnh Tấn Hạnh',N'Nam','','huynhtanhanh@gmail.com','2012/06/19','CV01','K04')
	--------------K05
	,('BS186',N'Nguyễn Minh Tuấn',N'Nam','0546762512','','2022/03/07','CV01','K05')
	,('BS187',N'Phan Thanh Tám',N'Nam','0546762521','phanthanhtam@gmail.com','2021/06/11','CV01','K05')
	,('BS188',N'Nguyễn Minh Tuấn',N'Nam','','','2022/08/07','CV01','K05')
	,('BS189',N'Nguyễn Hữu Hợp',N'Nam','0652615262','nguyenhuuhop@gmail.com','2023/08/13','CV01','K05')
	,('BS190',N'Nguyễn Đức Dũng',N'Nam','0546765431','nguyenducdung','2006/08/07','CV01','K05')
	,('BS191',N'Đinh Văn Nơi',N'Nam','','dinhvannoi@gmail.com','2022/03/07','CV01','K05')
	,('BS192',N'Phan Công Bình',N'Nam','','','2021/04/15','CV01','K05')
	,('BS193',N'Nguyễn Đức Hải',N'Nam','','nguyenduchai@gmail.com','2018/03/07','CV01','K05')
	---------------K06
	
	,('BS194',N'Bùi Quốc Khánh',N'Nam','0238761523','buiquockhanh@gmail.com','2022/09/11','CV01','K06')
	,('BS195',N'Nguyễn Ngọc Vân',N'Nữ','','nguyenngocvan@gmail.com','2020/10/11','CV01','K06')
	,('BS196',N'Nguyễn Văn Trãi',N'Nam','0238761524','nguyenvantrai.com','2024/01/18','CV01','K06')
	,('BS197',N'Trần Văn Phúc',N'Nam','0763526715','','2013/11/18','CV01','K06')
	,('BS198',N'Bùi Đức Hải',N'Nam','','','2022/10/11','CV01','K06')
	,('BS199',N'Trần Đức Hà',N'Nam','0635672165','tranducha@gmail.com','2022/09/11','CV01','K06')
	,('BS200',N'Bùi Quốc Khánh',N'Nam','','','2023/12/11','CV01','K06')
	,('BS201',N'Nguyễn Thanh Tuấn',N'Nam','0909021654','nguyenthanhtuan@gmail.com','2020/12/23','CV01','K06')
	,('BS202',N'Nguyễn Văn Nhựt',N'Nam','0320976545','nguyenvannhut@gmail.com','2020/09/11','CV01','K06')
	--------------K07
	,('BS203',N'Trần Xuân Ánh',N'Nam','0679098789','tranxuananh@gmail.com','2021/10/23','CV01','K07')
	,('BS204',N'Phạm Kim Đĩnh',N'Nam','0679098790','','2021/10/30','CV01','K07')
	,('BS205',N'Nguyễn Trọng Dũng',N'Nam','0679098791','nguyentrongdung@gmail.com','2022/01/23','CV01','K07')
	,('BS206',N'Thân Văn Hải',N'Nam','','thanvanhai@gmail.com','2019/06/18','CV01','K07')
	,('BS207',N'Lê Việt Thắng',N'Nam','','','2019/03/07','CV01','K07')
	,('BS208',N'Trần Xuân Anh',N'Nam','','','2021/10/23','CV01','K07')
	,('BS209', N'Nguyễn Thị Hà', N'Nữ','0912345678','','1995/04/15','CV01','K07')
	,('BS210', N'Lê Quang', N'Nam', '0987654321','', '1990/08/21', 'CV01', 'K07')
	,('BS211', N'Nguyễn Văn An', 'Nam', '', '', '2022/05/20', 'CV01', 'K07'),
	------------------K08
	('BS212',N'Hoàng Đức Anh',N'Nam','9302702345','hoangducanh@gmail.com.com','2024/01/10','CV01','K08'),
    ('BS213',N'Phạm Thị Mai',N'Nữ','9302903456','phamthimai@gmail.com','2024/02/01','CV01','K08'),
    ('BS214',N'Trần Ngọc Quang',N'Nam','9303104567','tranngocquang@gmail.com','2024/02/21','CV01','K08'),
    ('BS215',N'Nguyễn Hoài Thu',N'Nữ','9303305678','nguyenhoaithu@gmail.com','2024/03/14','CV01','K08'),
    ('BS216',N'Dương Quốc Toản',N'Nam','9303506789','duongquoctoan@gmail.com','2024/04/04','CV01','K08'),
	('BS217',N'Trần Đức Nam',N'Nam','9313707890','tranducnam@gmail.com','2024/05/10','CV01','K08'),
    ('BS218',N'Lê Thị Hồng',N'Nữ','9313908901','lethihong@gmail.com','2024/05/30','CV01','K08'),
    ('BS219',N'Nguyễn Anh Khoa',N'Nam','9314119012','nguyenanhkhoa@gmail.com','2024/06/19','CV01','K08'),
    ('BS220',N'Phạm Thị Lan',N'Nữ','9314330123','phamthilan@gmail.com','2024/07/09','CV01','K08'),
	------------------K09
	('BS221', N'Trần Văn Nam', N'Nam', '9254789632', 'tranvannam@gmail.com', '2018/06/10', 'CV01', 'K09'),
	('BS222', N'Hoàng Thị Lan', N'Nữ', '9256798234', 'hoangthilan@gmail.com', '2018/07/15', 'CV01', 'K09'),
	('BS223', N'Phan Văn Hùng', N'Nam', '9258807645', 'phanvanhung@gmail.com', '2018/08/20', 'CV01', 'K09'),
	('BS224', N'Lưu Thị Mai', N'Nữ', '9260918756', 'luuthimai@gmail.com', '2019/09/25', 'CV01', 'K09'),
	('BS225', N'Ngô Anh Tuấn', N'Nam', '9263029867', 'ngoanhtuan@gmail.com', '2019/10/30', 'CV01', 'K09'),
	('BS226', N'Đỗ Thị Hà', N'Nữ', '9265135978', 'dothiha@gmail.com', '2020/11/05', 'CV01', 'K09'),
	('BS227', N'Vũ Đình Chiểu', N'Nam', '9267246089', 'vudinhchieu@gmail.com', '2020/12/10', 'CV01', 'K09'),
	('BS228', N'Nguyễn Phương Thảo', N'Nữ', '9269357190', 'nguyenphuongthao@gmail.com', '2021/01/15', 'CV01', 'K09'),
	('BS229', N'Đặng Quốc Anh', N'Nam', '9271468201', 'dangquocanh@gmail.com', '2021/02/20', 'CV01', 'K09'),
	('BS230', N'Bùi Khánh Linh', N'Nữ', '9273579312', 'buikhanhlinh@gmail.com', '2021/03/25', 'CV01', 'K09'),
	----------------K10
	('BS231', N'Phạm Minh Tuấn', N'Nam', '9274689321', 'phamminhtuan@gmail.com', '2019/01/10', 'CV01', 'K10'),
	('BS232', N'Lê Thị Hồng', N'Nữ', '9275790432', 'lethihong@gmail.com', '2019/02/20', 'CV01', 'K10'),
	('BS233', N'Nguyễn Văn Bình', N'Nam', '9276891543', 'nguyenvanbinh@gmail.com', '2019/03/30', 'CV01', 'K10'),
	('BS234', N'Tran Thị Cẩm', N'Nữ', '9277992654', 'tranthicam@gmail.com', '2019/04/15', 'CV01', 'K10'),
	('BS235', N'Bùi Đức Thọ', N'Nam', '9278093765', 'buiductho@gmail.com', '2019/05/25', 'CV01', 'K10'),
	('BS236', N'Vũ Thị Mai', N'Nữ', '9279194876', 'vuthimai@gmail.com', '2019/06/05', 'CV01', 'K10'),
	('BS237', N'Đào Văn Khoa', N'Nam', '9280295987', 'daovankhoa@gmail.com', '2019/07/15', 'CV01', 'K10'),
	('BS238', N'Hoàng Thị Lan', N'Nữ', '9281396098', 'hoangthilan@gmail.com', '2019/08/25', 'CV01', 'K10'),
	('BS239', N'Trần Đức Anh', N'Nam', '9282497109', 'tranducanh@gmail.com', '2019/09/10', 'CV01', 'K10'),
	('BS240', N'Ngô Thị Phương', N'Nữ', '9283598210', 'ngothiphuong@gmail.com', '2019/10/30', 'CV01', 'K10'),
	----------------K11
	('BS241', N'Trần Minh Quân', N'Nam', '9382745612', 'tranminhquan@gmail.com', '2022/01/12', 'CV01', 'K11'),
	('BS242', N'Lưu Thị Hà', N'Nữ', '9382745613', 'luuthiha@gmail.com', '2022/02/15', 'CV01', 'K11'),
	('BS243', N'Phan Văn Kiên', N'Nam', '9382745614', 'phanvankien@gmail.com', '2022/03/20', 'CV01', 'K11'),
	('BS244', N'Nguyễn Thị Lan', N'Nữ', '9382745615', 'nguyenthilan@gmail.com', '2022/04/25', 'CV01', 'K11'),
	('BS245', N'Dương Văn Hoàng', N'Nam', '9382745616', 'duongvanhoang@gmail.com', '2022/05/30', 'CV01', 'K11'),
	('BS246', N'Hoàng Thị Đoan', N'Nữ', '9382745617', 'hoangthidoan@gmail.com', '2022/06/05', 'CV01', 'K11'),
	('BS247', N'Lê Quốc Trung', N'Nam', '9382745618', 'lequoctrung@gmail.com', '2022/07/10', 'CV01', 'K11'),
	('BS248', N'Trần Thị Nga', N'Nữ', '9382745619', 'tranthinga@gmail.com', '2022/08/15', 'CV01', 'K11'),
	('BS249', N'Phạm Văn Bảo', N'Nam', '9382745620', 'phamvanbao@gmail.com', '2022/09/20', 'CV01', 'K11'),
	('BS250', N'Ngô Thị Thu', N'Nữ', '9382745621', 'ngothithu@gmail.com', '2022/10/25', 'CV01', 'K11'),
	----------------K12
	('BS251', N'Nguyễn Hoàng Nam', N'Nam', '9392745611', 'nguyenhoangnam@gmail.com', '2023/01/05', 'CV01', 'K12'),
	('BS252', N'Lê Thị Bích', N'Nữ', '9392745612', 'lethibich@gmail.com', '2023/02/10', 'CV01', 'K12'),
	('BS253', N'Tran Van Phu', N'Nam', '9392745613', 'tranvanphu@gmail.com', '2023/03/15', 'CV01', 'K12'),
	('BS254', N'Hoàng Minh Tú', N'Nữ', '9392745614', 'hoangminhtu@gmail.com', '2023/04/20', 'CV01', 'K12'),
	('BS255', N'Dương Quốc Dũng', N'Nam', '9392745615', 'duongquocdung@gmail.com', '2023/05/25', 'CV01', 'K12'),
	('BS256', N'Phạm Thị Lan', N'Nữ', '9392745616', 'phamthilan@gmail.com', '2023/06/30', 'CV01', 'K12'),
	('BS257', N'Ngô Văn Khoa', N'Nam', '9392745617', 'ngovankhoa@gmail.com', '2023/07/05', 'CV01', 'K12'),
	('BS258', N'Vũ Thị Hồng', N'Nữ', '9392745618', 'vuthihong@gmail.com', '2023/08/10', 'CV01', 'K12'),
	('BS259', N'Trần Đức Thắng', N'Nam', '9392745619', 'tranducthang@gmail.com', '2023/09/15', 'CV01', 'K12'),
	('BS260', N'Nguyễn Thị Mai', N'Nữ', '9392745620', 'nguyenthimai@gmail.com', '2023/10/20', 'CV01', 'K12'),
	('BS261', N'Lê Thanh Tùng', N'Nam', '9392745621', 'lethanhtung@gmail.com', '2023/11/25', 'CV01', 'K12'),
	----------------K13
	('BS262', N'Võ Thị Hà', N'Nữ', '9402745622', 'vothiha@gmail.com', '2023/01/05', 'CV01', 'K13'),
	('BS263', N'Phan Anh Tuấn', N'Nam', '9402745623', 'phananhtuan@gmail.com', '2023/02/15', 'CV01', 'K13'),
	('BS264', N'Trần Minh Châu', N'Nữ', '9402745624', 'tranminhchau@gmail.com', '2023/03/25', 'CV01', 'K13'),
	('BS265', N'Nguyễn Văn Quyết', N'Nam', '9402745625', 'nguyenvanquyet@gmail.com', '2023/04/10', 'CV01', 'K13'),
	('BS266', N'Lê Thị Thanh', N'Nữ', '9402745626', 'lethithanh@gmail.com', '2023/05/20', 'CV01', 'K13'),
	('BS267', N'Đỗ Hoàng Phúc', N'Nam', '9402745627', 'dohoangphuc@gmail.com', '2023/06/15', 'CV01', 'K13'),
	('BS268', N'Phạm Thị Ngọc', N'Nữ', '9402745628', 'phamthingoc@gmail.com', '2023/07/05', 'CV01', 'K13'),
	('BS269', N'Ngô Đức Thắng', N'Nam', '9402745629', 'ngoducthang@gmail.com', '2023/08/25', 'CV01', 'K13'),
	('BS270', N'Bùi Thanh Tâm', N'Nữ', '9402745630', 'buithanhtam@gmail.com', '2023/09/15', 'CV01', 'K13'),
	('BS271', N'Lưu Minh Đức', N'Nam', '9402745631', 'luuminhduc@gmail.com', '2023/10/30', 'CV01', 'K13'),
	-------------------K14
	('BS272', N'Trần Văn Nam', N'Nam', '9502745632', 'tranvannam@gmail.com', '2023/01/10', 'CV01', 'K14'),
	('BS273', N'Nguyễn Thị Lan', N'Nữ', '9502745633', 'nguyenthilan@gmail.com', '2023/02/20', 'CV01', 'K14'),
	('BS274', N'Lê Quốc Toàn', N'Nam', '9502745634', 'lequoctoan@gmail.com', '2023/03/15', 'CV01', 'K14'),
	('BS275', N'Phạm Hồng Anh', N'Nữ', '9502745635', 'phamhonganh@gmail.com', '2023/04/25', 'CV01', 'K14'),
	('BS276', N'Võ Minh Quân', N'Nam', '9502745636', 'vominhquan@gmail.com', '2023/05/30', 'CV01', 'K14'),
	('BS277', N'Đào Thị Thu', N'Nữ', '9502745637', 'daothithu@gmail.com', '2023/06/10', 'CV01', 'K14'),
	('BS278', N'Trần Thị Mơ', N'Nữ', '9502745638', 'tranthimo@gmail.com', '2023/07/20', 'CV01', 'K14'),
	('BS279', N'Nguyễn Hữu Tài', N'Nam', '9502745639', 'nguyenhuutai@gmail.com', '2023/08/15', 'CV01', 'K14'),
	('BS280', N'Lê Thanh Tùng', N'Nam', '9502745640', 'lethanhtung@gmail.com', '2023/09/05', 'CV01', 'K14'),
	('BS281', N'Phạm Bảo Trân', N'Nữ', '9502745641', 'phambaotran@gmail.com', '2023/10/25', 'CV01', 'K14'),
	-------------------K15
	('BS282', N'Ngô Anh Khoa', N'Nam', '9602845632', 'ngoanhkhoa@gmail.com', '2023/01/05', 'CV01', 'K15'),
	('BS283', N'Trần Hà My', N'Nữ', '9602845633', 'tranhamy@gmail.com', '2023/02/10', 'CV01', 'K15'),
	('BS284', N'Vũ Bảo Trâm', N'Nữ', '9602845634', 'vubaotram@gmail.com', '2023/03/15', 'CV01', 'K15'),
	('BS285', N'Lê Quang Minh', N'Nam', '9602845635', 'lequangminh@gmail.com', '2023/04/20', 'CV01', 'K15'),
	('BS286', N'Phan Thị Hương', N'Nữ', '9602845636', 'phanthihuong@gmail.com', '2023/05/25', 'CV01', 'K15'),
	('BS287', N'Nguyễn Minh Đức', N'Nam', '9602845637', 'nguyenminhduc@gmail.com', '2023/06/30', 'CV01', 'K15'),
	('BS288', N'Hồ Thị Lan', N'Nữ', '9602845638', 'hothilan@gmail.com', '2023/07/05', 'CV01', 'K15'),
	('BS289', N'Phạm Tuấn Anh', N'Nam', '9602845639', 'phamtuananh@gmail.com', '2023/08/10', 'CV01', 'K15'),
	('BS290', N'Trần Thị Thảo', N'Nữ', '9602845640', 'tranthithao@gmail.com', '2023/09/15', 'CV01', 'K15'),
	('BS291', N'Lê Đức Anh', N'Nam', '9602845641', 'leducanh@gmail.com', '2023/10/20', 'CV01', 'K15'),
	-----------------K16
	('BS292', N'Lương Thị Lan', N'Nữ', '9752845632', 'luongthilan@gmail.com', '2023/01/01', 'CV01', 'K16'),
	('BS293', N'Đặng Minh Hoàng', N'Nam', '9752845633', 'dangminhhoang@gmail.com', '2023/02/05', 'CV01', 'K16'),
	('BS294', N'Nguyễn Thu Uyên', N'Nữ', '9752845634', 'nguyenthuyen@gmail.com', '2023/03/10', 'CV01', 'K16'),
	('BS295', N'Phạm Đức Nam', N'Nam', '9752845635', 'phamducnam@gmail.com', '2023/04/15', 'CV01', 'K16'),
	('BS296', N'Võ Thị Hà', N'Nữ', '9752845636', 'vothiha@gmail.com', '2023/05/20', 'CV01', 'K16'),
	('BS297', N'Hoàng Anh Tuấn', N'Nam', '9752845637', 'hoanganhtuan@gmail.com', '2023/06/25', 'CV01', 'K16'),
	('BS298', N'Tran Thu Trang', N'Nữ', '9752845638', 'tranthutrang@gmail.com', '2023/07/30', 'CV01', 'K16'),
	('BS299', N'Ngô Quốc Đạt', N'Nam', '9752845639', 'ngoquocdat@gmail.com', '2023/08/05', 'CV01', 'K16'),
	('BS300', N'Doan Thị Thanh', N'Nữ', '9752845640', 'doanthithanh@gmail.com', '2023/09/10', 'CV01', 'K16'),
	('BS301', N'Đỗ Văn Hùng', N'Nam', '9752845641', 'dovanhung@gmail.com', '2023/10/15', 'CV01', 'K16'),
	-----------------K17
	('BS302', N'Vũ Minh Tuấn', N'Nam', '9834752631', 'vuminhtuan@gmail.com', '2023/01/01', 'CV04', 'K17'),
	('BS303', N'Tran Khoa My', N'Nữ', '9834752632', 'trankhoamy@gmail.com', '2023/02/10', 'CV04', 'K17'),
	('BS304', N'Bùi Tấn Phát', N'Nam', '9834752633', 'buitanphat@gmail.com', '2023/03/20', 'CV04', 'K17'),
	('BS305', N'Phan Thu Loan', N'Nữ', '9834752634', 'phanthuloan@gmail.com', '2023/04/30', 'CV04', 'K17'),
	('BS306', N'Lê Đức Thịnh', N'Nam', '9834752635', 'leducthinh@gmail.com', '2017/05/15', 'CV04', 'K17'),
	('BS307', N'Ngô Thị Thu', N'Nữ', '9834752636', 'ngothithu@gmail.com', '2012/06/25', 'CV04', 'K17'),
	('BS308', N'Doãn Văn Bảo', N'Nam', '9834752637', 'doanvanbao@gmail.com', '2004/07/05', 'CV04', 'K17'),
	('BS309', N'Nguyễn Thị Mai', N'Nữ', '9834752638', 'nguyenthimai17@gmail.com', '2013/08/15', 'CV04', 'K17'),
	('BS310', N'Hà Quốc Anh', N'Nam', '9834752639', 'haquocanh@gmail.com', '2000/09/25', 'CV04', 'K17'),
	('BS311', N'Vương Thị Thảo', N'Nữ', '9834752640', 'vuongthithao@gmail.com', '1999/10/10', 'CV04', 'K17'),
	('BS312', N'Trần Minh Tuệ', N'Nam', '9834752641', 'tranminhtue@gmail.com', '1997/11/20', 'CV04', 'K17'),
	-----------------K18
	('BS313', N'Đỗ Thanh Tùng', N'Nam', '9835752642', 'dothanhtung@gmail.com', '1996/01/05', 'CV01', 'K18'),
	('BS314', N'Lương Hải Yến', N'Nữ', '9835752643', 'luonghaiyen@gmail.com', '2004/02/14', 'CV01', 'K18'),
	('BS315', N'Phạm Tuấn Kiệt', N'Nam', '9835752644', 'phamtuankiet@gmail.com', '2004/03/23', 'CV01', 'K18'),
	('BS316', N'Trần Ngọc Lan', N'Nữ', '9835752645', 'tranngoclan@gmail.com', '2000/04/01', 'CV01', 'K18'),
	('BS317', N'Vũ Phương Anh', N'Nữ', '9835752646', 'vuphuonganh@gmail.com', '2018/05/12', 'CV01', 'K18'),
	('BS318', N'Nguyễn Duy Khoa', N'Nam', '9835752647', 'nguyenduykhoa@gmail.com', '2019/06/21', 'CV01', 'K18'),
	('BS319', N'Lê Thảo My', N'Nữ', '9835752648', 'lethaomy@gmail.com', '2011/07/30', 'CV01', 'K18'),
	('BS320', N'Phan Anh Tuấn', N'Nam', '9835752649', 'phananhtuan@gmail.com', '2010/08/08', 'CV01', 'K18'),
	('BS321', N'Bùi Thị Thanh', N'Nữ', '9835752650', 'buithithanh@gmail.com', '2001/09/17', 'CV01', 'K18'),
	('BS322', N'Hoàng Minh Đức', N'Nam', '9835752651', 'hoangminhduc@gmail.com', '2002/10/26', 'CV01', 'K18'),
	--------------------K19
	('BS323', N'Nguyễn Hải Long', N'Nam', '9935752652', 'nguyenhailong@gmail.com', '2003/01/10', 'CV01', 'K19'),
	('BS324', N'Trần Thu Hà', N'Nữ', '9935752653', 'tranthuha@gmail.com', '2000/02/15', 'CV01', 'K19'),
	('BS325', N'Võ Đình Phong', N'Nam', '9935752654', 'vodinhphong@gmail.com', '2004/03/22', 'CV01', 'K19'),
	('BS326', N'Bùi Khánh Linh', N'Nữ', '9935752655', 'buikhanhlinh@gmail.com', '2006/04/28', 'CV01', 'K19'),
	('BS327', N'Đặng Văn Hoàng', N'Nam', '9935752656', 'dangvanhoang@gmail.com', '2015/05/19', 'CV01', 'K19'),
	('BS328', N'Lê Thị Ánh', N'Nữ', '9935752657', 'lethianh@gmail.com', '2014/06/26', 'CV01', 'K19'),
	('BS329', N'Phạm Văn Nam', N'Nam', '9935752658', 'phamvannam@gmail.com', '1996/07/14', 'CV01', 'K19'),
	---------------------K20
	('BS330', N'Lê Thị Bảo', N'Nữ', '9942652371', 'lethibao@gmail.com', '2024/01/05', 'CV01', 'K20'),
	('BS331', N'Ngô Quốc Anh', N'Nam', '9942652372', 'ngoquocanh@gmail.com', '2000/02/08', 'CV01', 'K20'),
	('BS332', N'Vũ Hoài Nam', N'Nam', '9942652373', 'vuhoainam@gmail.com', '2021/03/11', 'CV01', 'K20'),
	('BS333', N'Phan Thị Hoa', N'Nữ', '9942652374', 'phanthihoa@gmail.com', '2021/04/15', 'CV01', 'K20'),
	('BS334', N'Trịnh Văn Bảo', N'Nam', '9942652375', 'trinhvanbao@gmail.com', '2021/05/20', 'CV01', 'K20'),
	('BS335', N'Đặng Thị Lan', N'Nữ', '9942652376', 'dangthilan@gmail.com', '2012/06/25', 'CV01', 'K20'),
	('BS336', N'Bùi Văn Đạt', N'Nam', '9942652377', 'buivandat@gmail.com', '2008/07/30', 'CV01', 'K20'),
	('BS337', N'Nguyễn Hà Phương', N'Nữ', '9942652378', 'nguyenhaphuong@gmail.com', '2009/08/02', 'CV01', 'K20'),
	('BS338', N'Trần Khánh Duy', N'Nam', '9942652379', 'trankhanhduy@gmail.com', '2006/09/07', 'CV01', 'K20'),
	('BS339', N'Võ Thị Thu', N'Nữ', '9942652380', 'vothithu@gmail.com', '2010/10/12', 'CV01', 'K20'),
	('BS340', N'Phạm Văn Khoa', N'Nam', '9942652381', 'phamvankhoa@gmail.com', '2019/11/17', 'CV01', 'K20'),
	------------------K21
	('BS341', N'Trần Minh Thu', N'Nữ', '9953724681', 'tranminhthu@gmail.com', '2024/01/03', 'CV01', 'K21'),
	('BS342', N'Lê Quang Huy', N'Nam', '9953724682', 'lequanghuy@gmail.com', '2009/02/05', 'CV01', 'K21'),
	('BS343', N'Hoàng Thị Mai', N'Nữ', '9953724683', 'hoangthimai@gmail.com', '1967/03/08', 'CV01', 'K21'),
	('BS344', N'Phạm Văn Hùng', N'Nam', '9953724684', 'phamvanhung@gmail.com', '1967/04/10', 'CV01', 'K21'),
	('BS345', N'Võ Thị Hạnh', N'Nữ', '9953724685', 'vothihanh@gmail.com', '1968/05/12', 'CV01', 'K21'),
	('BS346', N'Nguyễn Văn Thắng', N'Nam', '9953724686', 'nguyenvanthang@gmail.com', '2007/06/14', 'CV01', 'K21'),
	('BS347', N'Dương Thị Bích', N'Nữ', '9953724687', 'duongthibich@gmail.com', '2017/07/16', 'CV01', 'K21'),
	('BS348', N'Bùi Văn Khoa', N'Nam', '9953724688', 'buivankhoa@gmail.com', '2021/08/18', 'CV01', 'K21'),
	---------------------K22
	('BS349', N'Nguyễn Thị Lan', N'Nữ', '9953724689', 'nguyenthilan@gmail.com', '2008/01/02', 'CV01', 'K22'),
	('BS350', N'Trần Văn Toàn', N'Nam', '9953724690', 'tranvantoan@gmail.com', '2005/02/04', 'CV01', 'K22'),
	('BS351', N'Phạm Thị Ngọc', N'Nữ', '9953724691', 'phamthingoc@gmail.com', '2004/03/06', 'CV01', 'K22'),
	('BS352', N'Vũ Hoàng Nam', N'Nam', '9953724692', 'vuhoangnam@gmail.com', '1996/04/08', 'CV01', 'K22'),
	('BS353', N'Lê Thị Hồng', N'Nữ', '9953724693', 'lethihong@gmail.com', '1990/05/10', 'CV01', 'K22'),
	('BS354', N'Đỗ Duy Khánh', N'Nam', '9953724694', 'doduykhanh@gmail.com', '2020/06/12', 'CV01', 'K22'),
	('BS355', N'Bùi Hải Yến', N'Nữ', '9953724695', 'buihaiyen@gmail.com', '2019/07/14', 'CV01', 'K22'),
	('BS356', N'Nguyễn Quốc Anh', N'Nam', '9953724696', 'nguyenquocanh@gmail.com', '2021/08/16', 'CV01', 'K22'),
	------------------K23
	('BS357', N'Hoàng Minh Tú', N'Nam', '9925847630', 'hoangminhtu@gmail.com', '2024/01/03', 'CV01', 'K23'),
	('BS358', N'Trần Thu Hà', N'Nữ', '9925847631', 'tranthuha@gmail.com', '2024/02/05', 'CV01', 'K23'),
	('BS359', N'Lê Quang Đạt', N'Nam', '9925847632', 'lequangdat@gmail.com', '2024/03/07', 'CV01', 'K23'),
	('BS360', N'Nguyễn Thị Thuỳ', N'Nữ', '9925847633', 'nguyenthithuy@gmail.com', '2022/04/09', 'CV01', 'K23'),
	('BS361', N'Phan Anh Tú', N'Nam', '9925847634', 'phananhtu@gmail.com', '2023/05/11', 'CV01', 'K23'),
	('BS362', N'Vũ Thị Lan', N'Nữ', '9925847635', 'vuthilan@gmail.com', '1999/06/13', 'CV01', 'K23'),
	('BS363', N'Trần Văn Thanh', N'Nam', '9925847636', 'tranvanthanh@gmail.com', '2000/07/15', 'CV01', 'K23'),
	('BS364', N'Ngô Hồng Nhung', N'Nữ', '9925847637', 'ngohongnhung@gmail.com', '1998/08/17', 'CV01', 'K23'),
	('BS365', N'Lý Đức Anh', N'Nam', '9925847638', 'lyducanh@gmail.com', '1997/09/19', 'CV01', 'K23'),
	('BS366', N'Đào Thị Mai', N'Nữ', '9925847639', 'daothimai@gmail.com', '2000/10/21', 'CV01', 'K23'),
	--------------------K24	
	('BS367', N'Đinh Văn Toàn', N'Nam', '9935748100', 'dinhvantoan@gmail.com', '2024/01/02', 'CV01', 'K24'),
	('BS368', N'Bùi Thị Hạnh', N'Nữ', '9935748101', 'buithihanh@gmail.com', '2024/02/04', 'CV01', 'K24'),
	('BS369', N'Nguyễn Đức Tài', N'Nam', '9935748102', 'nguyenductai@gmail.com', '2000/03/06', 'CV01', 'K24'),
	('BS370', N'Lương Thị Mai', N'Nữ', '9935748103', 'luongthimai@gmail.com', '1990/04/08', 'CV01', 'K24'),
	('BS371', N'Hoàng Trung Kiên', N'Nam', '9935748104', 'hoangtrungkien@gmail.com', '1996/05/10', 'CV01', 'K24'),
	('BS372', N'Phạm Thu Hương', N'Nữ', '9935748105', 'phamthuhuong@gmail.com', '1976/06/12', 'CV01', 'K24'),
	('BS373', N'Trần Minh Châu', N'Nam', '9935748106', 'tranminhchau@gmail.com', '1977/07/14', 'CV01', 'K24'),
	('BS374', N'Võ Thị Bích', N'Nữ', '9935748107', 'vothibich@gmail.com', '1999/08/16', 'CV01', 'K24'),
	('BS375', N'Nguyễn Tấn Phát', N'Nam', '9935748108', 'nguyentanphat@gmail.com', '1997/09/18', 'CV01', 'K24'),
	('BS376', N'Dương Thị Lan', N'Nữ', '9935748109', 'duongthilan@gmail.com', '2000/10/20', 'CV01', 'K24'),
	('BS377', N'Lê Quốc Trung', N'Nam', '9935748110', 'lequoctrung@gmail.com', '2000/11/22', 'CV01', 'K24'),
	-------------------------K25
	('BS378', N'Nguyễn Hà Phương', N'Nữ', '9955748100', 'nguyenhaphuong@gmail.com', '2024/01/05', 'CV01', 'K25'),
	('BS379', N'Phan Thanh Tùng', N'Nam', '9955748101', 'phanthanhtung@gmail.com', '2024/02/07', 'CV01', 'K25'),
	('BS380', N'Vũ Thị Hồng', N'Nữ', '9955748102', 'vuthihong@gmail.com', '1997/03/09', 'CV01', 'K25'),
	('BS381', N'Trương Đình Nghệ', N'Nam', '9955748103', 'truongdinhnghe@gmail.com', '1998/04/11', 'CV01', 'K25'),
	('BS382', N'Doãn Minh Thư', N'Nữ', '9955748104', 'doanminhthu@gmail.com', '2000/05/13', 'CV01', 'K25'),
	('BS383', N'Bùi Nhật Minh', N'Nam', '9955748105', 'buinhatminh@gmail.com', '2020/06/15', 'CV01', 'K25'),
	('BS384', N'Lê Phương Thảo', N'Nữ', '9955748106', 'lephuongthao@gmail.com', '2021/07/17', 'CV01', 'K25'),
	('BS385', N'Trần Văn Bảo', N'Nam', '9955748107', 'tranvanbao@gmail.com', '2019/08/19', 'CV01', 'K25'),
	('BS386', N'Đào Thị Mai', N'Nữ', '9955748108', 'daothimai@gmail.com', '2012/09/21', 'CV01', 'K25'),
	---------------------------K26
	('BS387', N'Nguyễn Thị Lan', N'Nữ', '9955748109', 'nguyenthilan@gmail.com', '2024/01/05', 'CV01', 'K26'),
	('BS388', N'Lê Quang Minh', N'Nam', '9955748110', 'lequangminh@gmail.com', '2024/02/06', 'CV01', 'K26'),
	('BS389', N'Tran Thị Thúy', N'Nữ', '9955748111', 'tranthithuy@gmail.com', '2024/03/07', 'CV01', 'K26'),
	('BS390', N'Phạm Văn Đạt', N'Nam', '9955748112', 'phamvandat@gmail.com', '2024/04/08', 'CV01', 'K26'),
	('BS391', N'Hồ Ngọc Hà', N'Nữ', '9955748113', 'hongocha@gmail.com', '2000/05/09', 'CV01', 'K26'),
	('BS392', N'Ngô Thanh Vân', N'Nữ', '9955748114', 'ngothanhvan@gmail.com', '2012/06/10', 'CV01', 'K26'),
	('BS393', N'Bùi Văn Nam', N'Nam', '9955748115', 'buivannam@gmail.com', '2012/07/11', 'CV01', 'K26'),
	('BS394', N'Trần Thị Bảo', N'Nữ', '9955748116', 'tranthibao@gmail.com', '2013/08/12', 'CV01', 'K26'),
	('BS395', N'Võ Quốc Bình', N'Nam', '9955748117', 'voquocbinh@gmail.com', '2013/09/13', 'CV01', 'K26'),
	('BS396', N'Dương Minh Châu', N'Nữ', '9955748118', 'duongminhchau@gmail.com', '2013/10/14', 'CV01', 'K26'),
	------------------------K27
	('BS397', N'Phan Thị Minh', N'Nữ', '9965748201', 'phanthiminh@gmail.com', '2024/01/15', 'CV01', 'K27'),
	('BS398', N'Đặng Quốc Toản', N'Nam', '9965748202', 'dangquoctoan@gmail.com', '2024/02/16', 'CV01', 'K27'),
	('BS399', N'Hoàng Minh Tú', N'Nữ', '9965748203', 'hoangminhtu@gmail.com', '2024/03/17', 'CV01', 'K27'),
	('BS400', N'Lý Văn Sâm', N'Nam', '9965748204', 'lyvansam@gmail.com', '2000/04/18', 'CV01', 'K27'),
	('BS401', N'Trịnh Hồng Sơn', N'Nam', '9965748205', 'trinhhongson@gmail.com', '2002/05/19', 'CV01', 'K27'),
	('BS402', N'Nguyễn Thị Lan Anh', N'Nữ', '9965748206', 'nguyenthilanh@gmail.com', '2002/06/20', 'CV01', 'K27'),
	('BS403', N'Vũ Minh Trí', N'Nam', '9965748207', 'vuminhtri@gmail.com', '2002/07/21', 'CV01', 'K27'),
	('BS404', N'Lê Thị Thảo', N'Nữ', '9965748208', 'lethithao@gmail.com', '2009/08/22', 'CV01', 'K27'),
	----------------------------K28
	('BS405', N'Ngô Thanh Minh', N'Nam', '9975748301', 'ngothanhminh@gmail.com', '2000/01/01', 'CV01', 'K28'),
	('BS406', N'Đinh Hà Giang', N'Nữ', '9975748302', 'dinhhagiang@gmail.com', '2004/02/02', 'CV01', 'K28'),
	('BS407', N'Lương Đức Hoàng', N'Nam', '9975748303', 'luongduchoang@gmail.com', '2005/03/03', 'CV01', 'K28'),
	('BS408', N'Bùi Minh Châu', N'Nữ', '9975748304', 'buiminhchau@gmail.com', '2006/04/04', 'CV01', 'K28'),
	('BS409', N'Trần Thị Nhung', N'Nữ', '9975748305', 'tranthinhung@gmail.com', '2006/05/05', 'CV01', 'K28'),
	('BS410', N'Võ Ngọc Điệp', N'Nam', '9975748306', 'vongocdiep@gmail.com', '1999/06/06', 'CV01', 'K28'),
	('BS411', N'Phạm Minh Tuấn', N'Nam', '9975748307', 'phamminhtuan@gmail.com', '1998/07/07', 'CV01', 'K28'),
	('BS412', N'Lê Thảo Ly', N'Nữ', '9975748308', 'lethaoly@gmail.com', '1990/08/08', 'CV01', 'K28'),
	('BS413', N'Nguyễn Văn Hải', N'Nam', '9975748309', 'nguyenvanhai@gmail.com', '1991/09/09', 'CV01', 'K28'),
	('BS414', N'Dương Hồng Sơn', N'Nam', '9975748310', 'duonghongson@gmail.com', '1992/10/10', 'CV01', 'K28'),
	('BS415', N'Thái Thị Mai', N'Nữ', '9975748311', 'thaithimai@gmail.com', '1993/11/11', 'CV01', 'K28'),

	('BS416', N'Phan Quốc Bảo', N'Nam', '9985748312', 'phanquocbao@gmail.com', '2024/01/12', 'CV01', 'K28'),
	('BS417', N'Nguyễn Thu Hương', N'Nữ', '9985748313', 'nguyenthuhuong@gmail.com', '2024/02/13', 'CV01', 'K28'),
	('BS418', N'Lê Khắc Tài', N'Nam', '9985748314', 'lekhactai@gmail.com', '2024/03/14', 'CV01', 'K28'),
	('BS419', N'Trần Khánh Vy', N'Nữ', '9985748315', 'trankhanhvy@gmail.com', '2024/04/15', 'CV01', 'K28'),
	('BS420', N'Đoàn Thị Mỹ Linh', N'Nữ', '9985748316', 'doanthimylinh@gmail.com', '2000/05/16', 'CV01', 'K28'),
	('BS421', N'Nguyễn Phú Quốc', N'Nam', '9985748317', 'nguyenphuquoc@gmail.com', '2000/06/17', 'CV01', 'K28'),
	('BS422', N'Mai Thị Hòa', N'Nữ', '9985748318', 'maithihoa@gmail.com', '2005/07/18', 'CV01', 'K28'),
	('BS423', N'Hồ Ngọc Cường', N'Nam', '9985748319', 'hongoccuong@gmail.com', '2008/08/19', 'CV01', 'K28'),
	('BS424', N'Đặng Hải Yến', N'Nữ', '9985748320', 'danghaiyen@gmail.com', '2009/09/20', 'CV01', 'K28'),
	---------------------------K29
	('BS425', N'Vũ Minh Tuấn', N'Nam', '9985324761', 'vuminhtuan@gmail.com', '2024/01/21', 'CV01', 'K29'),
	('BS426', N'Trần Hà Phương', N'Nữ', '9985324762', 'tranhaphuong@gmail.com', '2024/02/22', 'CV01', 'K29'),
	('BS427', N'Lê Thị Lan', N'Nữ', '9985324763', 'lethilan@gmail.com', '2024/03/23', 'CV01', 'K29'),
	('BS428', N'Phạm Văn Đức', N'Nam', '9985324764', 'phamvanduc@gmail.com', '2024/04/24', 'CV01', 'K29'),
	('BS429', N'Ngô Quốc Duy', N'Nam', '9985324765', 'ngoquocduy@gmail.com', '2009/05/25', 'CV01', 'K29'),
	('BS430', N'Nguyễn Thị Mai', N'Nữ', '9985324766', 'nguyenthimai@gmail.com', '2011/06/26', 'CV01', 'K29'),
	('BS431', N'Hoàng Minh Huy', N'Nam', '9985324767', 'hoangminhhuy@gmail.com', '2012/07/27', 'CV01', 'K29'),
	('BS432', N'Lý Hải Anh', N'Nữ', '9985324768', 'lyhaianh@gmail.com', '2011/08/28', 'CV01', 'K29'),
	('BS433', N'Phan Anh Tú', N'Nam', '9985324769', 'phananhtu@gmail.com', '2012/09/29', 'CV01', 'K29')


-----------------------------------------NhanVien BS khám dịch vụ
INSERT INTO NhanVien([MaNV], [TenNV], [GioiTinh], [SDT], [Email], [NgayBatDauLam], [MaCV], [MaKhoa]) 
VALUES
-----------------------------------------K01-----------------------------------------
('BS434', N'Đoàn Khải', N'Nam', '9975342760', 'doankhai@gmail.com', '2024/01/01', 'CV01', 'K01'),
('BS435', N'Phạm Thu Hà', N'Nữ', '9975342761', 'phamthuha@gmail.com', '2024/01/02', 'CV01', 'K01'),
('BS436', N'Trần Huy Hoàng', N'Nam', '9975342762', 'tranhuyhoang@gmail.com', '2024/01/03', 'CV01', 'K01'),
('BS437', N'Nguyễn Thảo Linh', N'Nữ', '9975342763', 'nguyenthaolinh@gmail.com', '2024/01/04', 'CV01', 'K01'),
('BS438', N'Lê Quốc Toản', N'Nam', '9975342764', 'lequoctoan@gmail.com', '2024/01/05', 'CV01', 'K01'),
('BS439', N'Bùi Minh Quân', N'Nam', '9975342765', 'buiminhquan@gmail.com', '2024/01/06', 'CV01', 'K01'),
('BS440', N'Trần Minh Tú', N'Nữ', '9975342766', 'tranminhtu@gmail.com', '2024/01/07', 'CV01', 'K01'),
('BS441', N'Hoàng Văn Nam', N'Nam', '9975342767', 'hoangvannam@gmail.com', '2024/01/08', 'CV01', 'K01'),
('BS442', N'Lý Thị Mai', N'Nữ', '9975342768', 'lythimai@gmail.com', '2024/01/09', 'CV01', 'K01'),
('BS443', N'Ngô Anh Tuấn', N'Nam', '9975342769', 'ngoanhtuan@gmail.com', '2024/01/10', 'CV01', 'K01'),
('BS444', N'Vũ Hoàng Lan', N'Nữ', '9975342770', 'vuhoanglan@gmail.com', '2024/01/11', 'CV01', 'K01'),
('BS445', N'Phan Thanh Sơn', N'Nam', '9975342771', 'phanthanhsơn@gmail.com', '2024/01/12', 'CV01', 'K01'),
('BS446', N'Đỗ Minh Châu', N'Nữ', '9975342772', 'dominhchau@gmail.com', '2024/01/13', 'CV01', 'K01'),
('BS447', N'Lê Văn Kiên', N'Nam', '9975342773', 'levankien@gmail.com', '2024/01/14', 'CV01', 'K01'),
('BS448', N'Trương Hồng Thanh', N'Nữ', '9975342774', 'truonghongthanh@gmail.com', '2024/01/15', 'CV01', 'K01'),
---------------------------------------K02------------------------------------
('BS454', N'Trần Minh Khoa', N'Nam', '9985342770', 'tranminhkhoa@gmail.com', '2024/04/01', 'CV01', 'K02'),
('BS455', N'Nguyễn Thị Hồng Nhung', N'Nữ', '9985342771', 'nguyenthihongnhung@gmail.com', '2024/04/02', 'CV01', 'K02'),
('BS456', N'Lê Quang Duy', N'Nam', '9985342772', 'lequangduy@gmail.com', '2024/04/03', 'CV01', 'K02'),
('BS457', N'Phạm Bảo Trâm', N'Nữ', '9985342773', 'phambaotram@gmail.com', '2024/04/04', 'CV01', 'K02'),
('BS458', N'Đỗ Minh Quân', N'Nam', '9985342774', 'dominhquan@gmail.com', '2024/04/05', 'CV01', 'K02'),
('BS459', N'Hoàng Thị Mai', N'Nữ', '9985342775', 'hoangthimai@gmail.com', '2024/04/06', 'CV01', 'K02'),
('BS460', N'Nguyễn Anh Khoa', N'Nam', '9985342776', 'nguyenanhkhoa@gmail.com', '2024/04/07', 'CV01', 'K02'),
('BS461', N'Võ Thị Diễm', N'Nữ', '9985342777', 'vothidiem@gmail.com', '2024/04/08', 'CV01', 'K02'),
('BS462', N'Bùi Đức Thành', N'Nam', '9985342778', 'buiducthanh@gmail.com', '2024/04/09', 'CV01', 'K02'),
('BS463', N'Trần Thị Lan Anh', N'Nữ', '9985342779', 'tranthilanh@gmail.com', '2024/04/10', 'CV01', 'K02'),
('BS464', N'Nguyễn Đức Minh', N'Nam', '9985342780', 'nguyenducminh@gmail.com', '2024/04/11', 'CV01', 'K02'),
('BS465', N'Lý Hà My', N'Nữ', '9985342781', 'lyhamy@gmail.com', '2024/04/12', 'CV01', 'K02'),
('BS466', N'Trần Hoàng Nam', N'Nam', '9985342782', 'tranhoangnam@gmail.com', '2024/04/13', 'CV01', 'K02'),
('BS467', N'Phạm Thị Thùy Linh', N'Nữ', '9985342783', 'phamthithuylinh@gmail.com', '2024/04/14', 'CV01', 'K02'),
('BS468', N'Lê Trọng Đạt', N'Nam', '9985342784', 'letrongdat@gmail.com', '2024/04/15', 'CV01', 'K02'),
---------------------------------K03-----------------------------------------------------
('BS474', N'Lê Minh Châu', N'Nam', '9935342001', 'leminhchau@gmail.com', '2024/04/01', 'CV01', 'K03'),
('BS475', N'Trần Kim Thoa', N'Nữ', '9935342002', 'trankimthoa@gmail.com', '2024/04/02', 'CV01', 'K03'),
('BS476', N'Nguyễn Quốc Toàn', N'Nam', '9935342003', 'nguyenquoctoan@gmail.com', '2024/04/03', 'CV01', 'K03'),
('BS477', N'Phạm Bích Ngọc', N'Nữ', '9935342004', 'phambichngoc@gmail.com', '2024/04/04', 'CV01', 'K03'),
('BS478', N'Võ Thị Lan', N'Nữ', '9935342005', 'vothilan@gmail.com', '2024/04/05', 'CV01', 'K03'),
('BS479', N'Đinh Tài Năng', N'Nam', '9935342006', 'dinhtainang@gmail.com', '2024/04/06', 'CV01', 'K03'),
('BS480', N'Bùi Văn Khoa', N'Nam', '9935342007', 'buivankhoa@gmail.com', '2024/04/07', 'CV01', 'K03'),
('BS481', N'Hoàng Thị Hồng', N'Nữ', '9935342008', 'hoangthihong@gmail.com', '2024/04/08', 'CV01', 'K03'),
('BS482', N'Nguyễn Thanh Hải', N'Nam', '9935342009', 'nguyenthanhhai@gmail.com', '2024/04/09', 'CV01', 'K03'),
('BS483', N'Trần Thị Mai', N'Nữ', '9935342010', 'tranthimai@gmail.com', '2024/04/10', 'CV01', 'K03'),
('BS484', N'Lê Văn Tam', N'Nam', '9935342011', 'levantam@gmail.com', '2024/04/11', 'CV01', 'K03'),
('BS485', N'Phạm Thị Bình', N'Nữ', '9935342012', 'phamthibinh@gmail.com', '2024/04/12', 'CV01', 'K03'),
('BS486', N'Nguyễn Đức Anh', N'Nam', '9935342013', 'nguyenducanh@gmail.com', '2024/04/13', 'CV01', 'K03'),
('BS487', N'Đỗ Thị Hương', N'Nữ', '9935342014', 'dothihuong@gmail.com', '2024/04/14', 'CV01', 'K03'),
('BS488', N'Bùi Hoàng Anh', N'Nam', '9935342015', 'buihoanganh@gmail.com', '2024/04/15', 'CV01', 'K03'),
-------------------------------------------K04-----------------------------------------------------------------
('BS494', N'Dương Minh Trí', N'Nam', '9945342001', 'duongminhtri@gmail.com', '2024/04/01', 'CV01', 'K04'),
('BS495', N'Phan Thị Thuỷ', N'Nữ', '9945342002', 'phanthithuy@gmail.com', '2024/04/02', 'CV01', 'K04'),
('BS496', N'Lê Quốc Cường', N'Nam', '9945342003', 'lequoccuong@gmail.com', '2024/04/03', 'CV01', 'K04'),
('BS497', N'Tran Ngọc Diệp', N'Nữ', '9945342004', 'trangocdiep@gmail.com', '2024/04/04', 'CV01', 'K04'),
('BS498', N'Võ Thị Sen', N'Nữ', '9945342005', 'vothisen@gmail.com', '2024/04/05', 'CV01', 'K04'),
('BS499', N'Nguyễn Văn Thanh', N'Nam', '9945342006', 'nguyenvanthanh@gmail.com', '2024/04/06', 'CV01', 'K04'),
('BS500', N'Hoàng Minh Tú', N'Nữ', '9945342007', 'hoangminhtu@gmail.com', '2024/04/07', 'CV01', 'K04'),
('BS501', N'Phạm Thế Vinh', N'Nam', '9945342008', 'phamthevinh@gmail.com', '2024/04/08', 'CV01', 'K04'),
('BS502', N'Đặng Thị Bảo', N'Nữ', '9945342009', 'dangthibao@gmail.com', '2024/04/09', 'CV01', 'K04'),
('BS503', N'Trần Minh Quân', N'Nam', '9945342010', 'tranminhquan@gmail.com', '2024/04/10', 'CV01', 'K04'),
('BS504', N'Lý Thị Hoa', N'Nữ', '9945342011', 'lythihoa@gmail.com', '2024/04/11', 'CV01', 'K04'),
('BS505', N'Vũ Văn Kiên', N'Nam', '9945342012', 'vuvankien@gmail.com', '2024/04/12', 'CV01', 'K04'),
('BS506', N'Nguyễn Thị Lan', N'Nữ', '9945342013', 'nguyenthilan@gmail.com', '2024/04/13', 'CV01', 'K04'),
('BS507', N'Trần Hữu Lộc', N'Nam', '9945342014', 'tranhuuloc@gmail.com', '2024/04/14', 'CV01', 'K04'),
('BS508', N'Phan Thị Mai', N'Nữ', '9945342015', 'phanthimai@gmail.com', '2024/04/15', 'CV01', 'K04'),
------------------------------------K05-----------------------------------------------------------
('BS514', N'Bùi Minh Quân', N'Nam', '9955141001', 'buiminhquan@gmail.com', '2018/04/01', 'CV01', 'K05'),
('BS515', N'Trần Thị Hồng', N'Nữ', '9955141002', 'tranthihong@gmail.com', '2017/04/02', 'CV01', 'K05'),
('BS516', N'Nguyễn Đức Anh', N'Nam', '9955141003', 'nguyenducanh@gmail.com', '2000/04/03', 'CV01', 'K05'),
('BS517', N'Phạm Thị Lan', N'Nữ', '9955141004', 'phamthilan@gmail.com', '1999/04/04', 'CV01', 'K05'),
('BS518', N'Lê Quốc Toàn', N'Nam', '9955141005', 'lequoctoan@gmail.com', '1998/04/05', 'CV01', 'K05'),
('BS519', N'Đỗ Thị Mai', N'Nữ', '9955141006', 'dothimai@gmail.com', '1991/04/06', 'CV01', 'K05'),
('BS520', N'Vũ Hoàng Nam', N'Nam', '9955141007', 'vuhuongnam@gmail.com', '1991/04/07', 'CV01', 'K05'),
('BS521', N'Nguyễn Thị Bảo Trâm', N'Nữ', '9955141008', 'nguyenthitram@gmail.com', '2003/04/08', 'CV01', 'K05'),
('BS522', N'Huỳnh Tấn Phát', N'Nam', '9955141009', 'huynhtanphat@gmail.com', '2002/04/09', 'CV01', 'K05'),
('BS523', N'Phan Thị Nga', N'Nữ', '9955141010', 'phanthinga@gmail.com', '1998/04/10', 'CV01', 'K05'),
('BS524', N'Trương Minh Thư', N'Nữ', '9955141011', 'truongminhthu@gmail.com', '1995/05/11', 'CV01', 'K05'),
('BS525', N'Lưu Quốc Hưng', N'Nam', '9955141012', 'luuquochung@gmail.com', '2000/04/12', 'CV01', 'K05'),
('BS526', N'Đặng Hữu Nghĩa', N'Nam', '9955141013', 'danghuunghia@gmail.com', '2004/04/13', 'CV01', 'K05'),
('BS527', N'Nguyễn Thị Thuỳ Linh', N'Nữ', '9955141014', 'nguyenthuylinh@gmail.com', '2022/04/14', 'CV01', 'K05'),
('BS528', N'Trần Khánh Dương', N'Nam', '9955141015', 'trankhanhduong@gmail.com', '2021/04/15', 'CV01', 'K05'),
----------------------------------------------K06-----------------------------------------------
('BS534', N'Ngô Quang Hải', 'Nam', '9955341001', 'ngoquanghai@gmail.com', '2000/04/01', 'CV01', 'K06'),
('BS535', N'Phạm Minh Tâm', N'Nữ', '9955341002', 'phamminhtam@gmail.com', '2002/04/02', 'CV01', 'K06'),
('BS536', N'Vũ Thị Hoa', N'Nữ', '9955341003', 'vuthihoa@gmail.com', '2002/04/03', 'CV01', 'K06'),
('BS537', N'Trần Đức Lợi', 'Nam', '9955341004', 'tranducloi@gmail.com', '2019/04/04', 'CV01', 'K06'),
('BS538', N'Lê Thị Phương', N'Nữ', '9955341005', 'lethiphuong@gmail.com', '2017/04/05', 'CV01', 'K06'),
('BS539', N'Hoàng Minh Sơn', 'Nam', '9955341006', 'hoangminhson@gmail.com', '2013/04/06', 'CV01', 'K06'),
('BS540', N'Đặng Thị Bích', N'Nữ', '9955341007', 'dangthibich@gmail.com', '2014/04/07', 'CV01', 'K06'),
('BS541', N'Nguyễn Văn Khải', 'Nam', '9955341008', 'nguyenvankhai@gmail.com', '2004/04/08', 'CV01', 'K06'),
('BS542', N'Trần Thị Mai', N'Nữ', '9955341009', 'tranthimai@gmail.com', '1991/04/09', 'CV01', 'K06'),
('BS543', N'Phan Hữu Lộc', 'Nam', '9955341010', 'phanhuuloc@gmail.com', '1991/04/10', 'CV01', 'K06'),
('BS544', N'Lý Thị Lan', N'Nữ', '9955341011', 'lythilan@gmail.com', '1991/04/11', 'CV01', 'K06'),
('BS545', N'Võ Văn Kiệt', 'Nam', '9955341012', 'vovankiet@gmail.com', '1992/04/12', 'CV01', 'K06'),
('BS546', N'Đỗ Thị Hằng', N'Nữ', '9955341013', 'dothihang@gmail.com', '1992/04/13', 'CV01', 'K06'),
('BS547', N'Nguyễn Minh Thuận', 'Nam', '9955341014', 'nguyenminhthuan@gmail.com', '2024/04/14', 'CV01', 'K06'),
('BS548', N'Bùi Thị Nhung', N'Nữ', '9955341015', 'buithinhung@gmail.com', '1993/04/15', 'CV01', 'K06'),
---------------------------------------------K07------------------------------------------------------------
('BS554', N'Trần Văn Nam', 'Nam', '9955541001', 'tranvannam@gmail.com', '2024/04/01', 'CV01', 'K07'),
('BS555', N'Nguyễn Thị Hồng', N'Nữ', '9955541002', 'nguyenthihong@gmail.com', '2024/04/02', 'CV01', 'K07'),
('BS556', N'Lê Quang Minh', 'Nam', '9955541003', 'lequangminh@gmail.com', '2024/04/03', 'CV01', 'K07'),
('BS557', N'Vũ Hoàng Lan', N'Nữ', '9955541004', 'vuhoanglan@gmail.com', '2024/04/04', 'CV01', 'K07'),
('BS558', N'Phạm Đức Toàn', 'Nam', '9955541005', 'phamductoan@gmail.com', '2024/04/05', 'CV01', 'K07'),
('BS559', N'Đào Thị Mai', N'Nữ', '9955541006', 'daothimai@gmail.com', '2024/04/06', 'CV01', 'K07'),
('BS560', N'Trần Thị Bảo', N'Nữ', '9955541007', 'tranthibao@gmail.com', '2024/04/07', 'CV01', 'K07'),
('BS561', N'Nguyễn Hải Long', 'Nam', '9955541008', 'nguyenhailong@gmail.com', '2024/04/08', 'CV01', 'K07'),
('BS562', N'Phan Thị Linh', N'Nữ', '9955541009', 'phanthilinh@gmail.com', '2024/04/09', 'CV01', 'K07'),
('BS563', N'Hoàng Minh Tuấn', 'Nam', '9955541010', 'hoangminhtuan@gmail.com', '2024/04/10', 'CV01', 'K07'),
('BS564', N'Vũ Khánh Hòa', N'Nữ', '9955541011', 'vukhanhhoa@gmail.com', '2024/04/11', 'CV01', 'K07'),
('BS565', N'Ngô Anh Tuấn', 'Nam', '9955541012', 'ngoanhtuan@gmail.com', '2024/04/12', 'CV01', 'K07'),
('BS566', N'Lê Thị Đoan', N'Nữ', '9955541013', 'lethidoan@gmail.com', '1995/04/13', 'CV01', 'K07'),
('BS567', N'Trần Văn Kiệt', 'Nam', '9955541014', 'tranvankiet@gmail.com', '1995/04/14', 'CV01', 'K07'),
('BS568', N'Phạm Thị Trang', N'Nữ', '9955541015', 'phamthitrang@gmail.com', '1996/04/15', 'CV01', 'K07'),
----------------------------------------K08---------------------------------------------------------------
('BS574', N'Dương Minh Tâm', 'Nam', '9955542001', 'duongminhtam@gmail.com', '2000/04/01', 'CV01', 'K08'),
('BS575', N'Trần Khánh Linh', N'Nữ', '9955542002', 'trankhanhlinh@gmail.com', '2018/04/02', 'CV01', 'K08'),
('BS576', N'Nguyễn Quốc Toản', 'Nam', '9955542003', 'nguyenquoctoan@gmail.com', '2014/04/03', 'CV01', 'K08'),
('BS577', N'Phạm Thị Hương', N'Nữ', '9955542004', 'phamthihuong@gmail.com', '2013/04/04', 'CV01', 'K08'),
('BS578', N'Hoàng Minh Chiến', 'Nam', '9955542005', 'hoangminhchien@gmail.com', '2012/04/05', 'CV01', 'K08'),
('BS579', N'Vũ Thị Phương', N'Nữ', '9955542006', 'vuthiphuong@gmail.com', '2012/04/06', 'CV01', 'K08'),
('BS580', N'Trần Ngọc Thảo', N'Nữ', '9955542007', 'tranngocthao@gmail.com', '2011/04/07', 'CV01', 'K08'),
('BS581', N'Lê Thanh Bình', 'Nam', '9955542008', 'lethanhbinh@gmail.com', '2003/06/08', 'CV01', 'K08'),
('BS582', N'Phan Hồng Sơn', 'Nam', '9955542009', 'phanhongson@gmail.com', '2001/06/09', 'CV01', 'K08'),
('BS583', N'Đỗ Minh Thùy', N'Nữ', '9955542010', 'dominhthuy@gmail.com', '2000/08/10', 'CV01', 'K08'),
('BS584', N'Nguyễn Hoàng Lan', N'Nữ', '9955542011', 'nguyenhoanglan@gmail.com', '2002/09/11', 'CV01', 'K08'),
('BS585', N'Trần Đình Nghĩa', 'Nam', '9955542012', 'trandinhnghia@gmail.com', '2000/04/16', 'CV01', 'K08'),
('BS586', N'Lý Thị Mai', N'Nữ', '9955542013', 'lythimai@gmail.com', '2016/07/23', 'CV01', 'K08'),
('BS587', N'Hoàng Văn Khoa', 'Nam', '9955542014', 'hoangvankhoa@gmail.com', '2024/04/14', 'CV01', 'K08'),
('BS588', N'Vũ Thị Nhung', N'Nữ', '9955542015', 'vuthinhung@gmail.com', '2024/04/15', 'CV01', 'K08'),
----------------------------------------------K09-------------------------------------------------------------
('BS594', N'Nguyễn Thế An', 'Nam', '9955542021', 'nguyenthean@gmail.com', '2018/04/01', 'CV01', 'K09'),
('BS595', N'Trần Minh Tú', N'Nữ', '9955542022', 'tranminhtu@gmail.com', '2016/09/02', 'CV01', 'K09'),
('BS596', N'Lê Khắc Huy', 'Nam', '9955542023', 'lekhachuy@gmail.com', '2017/05/03', 'CV01', 'K09'),
('BS597', N'Phan Thanh Tâm', N'Nữ', '9955542024', 'phanthanhtam@gmail.com', '2018/03/21', 'CV01', 'K09'),
('BS598', N'Đỗ Minh Hằng', N'Nữ', '9955542025', 'dominhhang@gmail.com', '2010/12/05', 'CV01', 'K09'),
('BS599', N'Vũ Văn Kiên', 'Nam', '9955542026', 'vuvankien@gmail.com', '2010/03/06', 'CV01', 'K09'),
('BS600', N'Nguyễn Thị Mai', N'Nữ', '9955542027', 'nguyenthimai@gmail.com', '2011/05/07', 'CV01', 'K09'),
('BS601', N'Hoàng Thanh Sơn', 'Nam', '9955542028', 'hoangthanhhson@gmail.com', '2012/04/08', 'CV01', 'K09'),
('BS602', N'Phạm Thị Bảo', N'Nữ', '9955542029', 'phamthibao@gmail.com', '2008/07/12', 'CV01', 'K09'),
('BS603', N'Ngô Minh Châu', N'Nữ', '9955542030', 'ngominhchau@gmail.com', '2007/01/01', 'CV01', 'K09'),
('BS604', N'Trần Đình Lộc', 'Nam', '9955542031', 'trandinhloc@gmail.com', '2024/04/11', 'CV01', 'K09'),
('BS605', N'Lý Hải Dương', 'Nam', '9955542032', 'lyhaiduong@gmail.com', '2021/05/17', 'CV01', 'K09'),
('BS606', N'Dương Thị Lan', N'Nữ', '9955542033', 'duongthilan@gmail.com', '2022/06/29', 'CV01', 'K09'),
('BS607', N'Phan Thanh Đào', N'Nữ', '9955542034', 'phanthanhdao@gmail.com', '2020/01/14', 'CV01', 'K09'),
('BS608', N'Vũ Minh Tuấn', 'Nam', '9955542035', 'vuminhtuan@gmail.com', '2016/08/20', 'CV01', 'K09'),
-------------------------------------------K10-----------------------------------------------------------------
('BS701', N'Nguyễn Thị Hoa', N'Nữ', '9923342101', 'nguyenthihoa@gmail.com', '1990/05/20', 'CV01', 'K10'),
('BS702', N'Trần Quốc Toản', 'Nam', '9923342102', 'tranquoctoan@gmail.com', '1991/06/15', 'CV01', 'K10'),
('BS703', N'Lê Văn Ninh', 'Nam', '9923342103', 'levanninh@gmail.com', '1992/07/18', 'CV01', 'K10'),
('BS704', N'Phạm Minh Đức', 'Nam', '9923342104', 'phamminhduc@gmail.com', '1993/08/22', 'CV01', 'K10'),
('BS705', N'Thái Thị Linh', N'Nữ', '9923342105', 'thaithilinh@gmail.com', '1994/09/30', 'CV01', 'K10'),
('BS706', N'Hoàng Minh Tâm', 'Nam', '9923342106', 'hoangminhtam@gmail.com', '1995/10/12', 'CV01', 'K10'),
('BS707', N'Đỗ Hà Phương', N'Nữ', '9923342107', 'dohaphuong@gmail.com', '1996/11/11', 'CV01', 'K10'),
('BS708', N'Vũ Hồng Sơn', 'Nam', '9923342108', 'vuhongson@gmail.com', '1997/12/20', 'CV01', 'K10'),
('BS709', N'Nguyễn Khánh Ly', N'Nữ', '9923342109', 'nguyenkhanhly@gmail.com', '1998/01/25', 'CV01', 'K10'),
('BS710', N'Mai Chí Thành', 'Nam', '9923342110', 'maichithanh@gmail.com', '1999/02/22', 'CV01', 'K10'),
('BS711', N'Trịnh Thị Mỹ', N'Nữ', '9923342111', 'trinhthimy@gmail.com', '2000/03/15', 'CV01', 'K10'),
('BS712', N'Bùi Minh Quân', 'Nam', '9923342112', 'buiminhquan@gmail.com', '2001/04/10', 'CV01', 'K10'),
('BS713', N'Lưu Hoàng Nam', 'Nam', '9923342113', 'luuhoangnam@gmail.com', '2002/05/05', 'CV01', 'K10'),
('BS714', N'Ngô Quý Phi', N'Nữ', '9923342114', 'ngoquyphi@gmail.com', '2003/06/18', 'CV01', 'K10'),
('BS715', N'Dương Văn Hoàng', 'Nam', '9923342115', 'duongvanhoang@gmail.com', '2004/07/23', 'CV01', 'K10'),
------------------------------------------------K11-------------------------------------------------------
('BS721', N'Võ Thị Minh', N'Nữ', '9933342101', 'vothiminh@gmail.com', '1990/01/05', 'CV01', 'K11'),
('BS722', N'Nguyễn Văn Hùng', 'Nam', '9933342102', 'nguyenvanhung@gmail.com', '1992/02/14', 'CV01', 'K11'),
('BS723', N'Trần Hoài Nam', 'Nam', '9933342103', 'tranhoainam@gmail.com', '1994/03/22', 'CV01', 'K11'),
('BS724', N'Phạm Hồng Anh', N'Nữ', '9933342104', 'phamhonganh@gmail.com', '1996/04/17', 'CV01', 'K11'),
('BS725', N'Hoàng Minh Châu', N'Nữ', '9933342105', 'hoangminhchau@gmail.com', '1998/05/29', 'CV01', 'K11'),
('BS726', N'Lưu Đức Toàn', 'Nam', '9933342106', 'luuductoan@gmail.com', '2000/06/13', 'CV01', 'K11'),
('BS727', N'Dương Quốc Đạt', 'Nam', '9933342107', 'duongquocdat@gmail.com', '2002/07/19', 'CV01', 'K11'),
('BS728', N'Lê Thị Bảo', N'Nữ', '9933342108', 'lethibao@gmail.com', '2004/08/25', 'CV01', 'K11'),
('BS729', N'Nguyễn Thành Long', 'Nam', '9933342109', 'nguyenthanhlong@gmail.com', '2006/09/30', 'CV01', 'K11'),
('BS730', N'Trịnh Cẩm Ly', N'Nữ', '9933342110', 'trinhcamly@gmail.com', '2008/10/12', 'CV01', 'K11'),
('BS731', N'Phan Hữu Lộc', 'Nam', '9933342111', 'phanhuuloc@gmail.com', '2010/11/15', 'CV01', 'K11'),
('BS732', N'Vũ Minh Tuấn', 'Nam', '9933342112', 'vuminhtuan@gmail.com', '2012/12/18', 'CV01', 'K11'),
('BS733', N'Dương Thị Thanh', N'Nữ', '9933342113', 'duongthithanh@gmail.com', '2015/01/21', 'CV01', 'K11'),
('BS734', N'Lê Quang Minh', 'Nam', '9933342114', 'lequangminh@gmail.com', '2017/02/24', 'CV01', 'K11'),
('BS735', N'Ngô Thị Lan', N'Nữ', '9933342115', 'ngothilan@gmail.com', '2019/03/28', 'CV01', 'K11'),
-------------------------------------------------K12--------------------------------------------------
('BS741', N'Nguyễn Khánh Duy', 'Nam', '9933342121', 'nguyenkhanhduy@gmail.com', '1990/01/07', 'CV01', 'K12'),
('BS742', N'Phạm Anh Tuấn', 'Nam', '9933342122', 'phamanhtuan@gmail.com', '1992/03/15', 'CV01', 'K12'),
('BS743', N'Trần Phương Lan', N'Nữ', '9933342123', 'tranphuonglan@gmail.com', '1994/05/23', 'CV01', 'K12'),
('BS744', N'Lê Thị Nga', N'Nữ', '9933342124', 'lethinga@gmail.com', '1996/07/30', 'CV01', 'K12'),
('BS745', N'Hoàng Văn Bảo', 'Nam', '9933342125', 'hoangvanbao@gmail.com', '1998/09/14', 'CV01', 'K12'),
('BS746', N'Dương Thị Hoa', N'Nữ', '9933342126', 'duongthihoa@gmail.com', '2000/11/20', 'CV01', 'K12'),
('BS747', N'Ngô Quốc An', 'Nam', '9933342127', 'ngoquocan@gmail.com', '2003/01/27', 'CV01', 'K12'),
('BS748', N'Vũ Thu Phương', N'Nữ', '9933342128', 'vuthuphuong@gmail.com', '2005/04/06', 'CV01', 'K12'),
('BS749', N'Trịnh Văn Thành', 'Nam', '9933342129', 'trinhvanthanh@gmail.com', '2007/06/12', 'CV01', 'K12'),
('BS750', N'Mai Thị Linh', N'Nữ', '9933342130', 'maithilinh@gmail.com', '2009/08/19', 'CV01', 'K12'),
('BS751', N'Nguyễn Minh Tâm', 'Nam', '9933342131', 'nguyenminhtam@gmail.com', '2011/10/26', 'CV01', 'K12'),
('BS752', N'Lưu Bảo Trâm', N'Nữ', '9933342132', 'luubaotram@gmail.com', '2014/01/02', 'CV01', 'K12'),
('BS753', N'Trần Đức Huy', 'Nam', '9933342133', 'tranduchuy@gmail.com', '2016/03/10', 'CV01', 'K12'),
('BS754', N'Phạm Thị Bích', N'Nữ', '9933342134', 'phamthibich@gmail.com', '2018/05/17', 'CV01', 'K12'),
('BS755', N'Võ Hồng Sơn', 'Nam', '9933342135', 'vohongson@gmail.com', '2020/07/25', 'CV01', 'K12'),
-------------------------------------------------------K13---------------------------------------------

('BS761', N'Phạm Quang Huy', 'Nam', '9933342141', 'phamquanghuy@gmail.com', '1990/02/03', 'CV01', 'K13'),
('BS762', N'Lê Hồng Nhung', N'Nữ', '9933342142', 'lehongnhung@gmail.com', '1992/04/07', 'CV01', 'K13'),
('BS763', N'Nguyễn Văn Khôi', 'Nam', '9933342143', 'nguyenvankhoi@gmail.com', '1994/06/09', 'CV01', 'K13'),
('BS764', N'Trần Minh Thu', N'Nữ', '9933342144', 'tranminhthu@gmail.com', '1996/08/15', 'CV01', 'K13'),
('BS765', N'Hoàng Thị Đào', N'Nữ', '9933342145', 'hoangthidao@gmail.com', '1998/10/21', 'CV01', 'K13'),
('BS766', N'Vũ Đức Mạnh', 'Nam', '9933342146', 'vuducmanh@gmail.com', '2000/12/26', 'CV01', 'K13'),
('BS767', N'Mai Chí Thanh', 'Nam', '9933342147', 'maichithanh@gmail.com', '2003/02/28', 'CV01', 'K13'),
('BS768', N'Trịnh Kim Oanh', N'Nữ', '9933342148', 'trinhkimoanh@gmail.com', '2005/05/04', 'CV01', 'K13'),
('BS769', N'Lưu Hải Bình', 'Nam', '9933342149', 'luuhaibinh@gmail.com', '2007/07/08', 'CV01', 'K13'),
('BS770', N'Đỗ Thị Lan', N'Nữ', '9933342150', 'dothilan@gmail.com', '2009/09/14', 'CV01', 'K13'),
('BS771', N'Ngô Thanh Tâm', 'Nam', '9933342151', 'ngothanhtam@gmail.com', '2011/11/19', 'CV01', 'K13'),
('BS772', N'Vũ Minh Tuệ', N'Nữ', '9933342152', 'vuminhtue@gmail.com', '2014/01/23', 'CV01', 'K13'),
('BS773', N'Trần Hồng Sơn', 'Nam', '9933342153', 'tranhongson@gmail.com', '2016/03/29', 'CV01', 'K13'),
('BS774', N'Phạm Thị Hồng', N'Nữ', '9933342154', 'phamthihong@gmail.com', '2018/06/03', 'CV01', 'K13'),
('BS775', N'Lê Quang Linh', 'Nam', '9933342155', 'lequanglinh@gmail.com', '2020/08/09', 'CV01', 'K13'),
-------------------------------------------------------K14-----------------------------------------------
('BS781', N'Bùi Văn Hoàng', 'Nam', '9944442101', 'buivanhoang@gmail.com', '1990/01/10', 'CV01', 'K14'),
('BS782', N'Nguyễn Thị Minh', N'Nữ', '9944442102', 'nguyenthiminh@gmail.com', '1991/03/12', 'CV01', 'K14'),
('BS783', N'Trần Quốc Toản', 'Nam', '9944442103', 'tranquoctoan@gmail.com', '1992/05/14', 'CV01', 'K14'),
('BS784', N'Lê Thị Cẩm', N'Nữ', '9944442104', 'lethicam@gmail.com', '1993/07/16', 'CV01', 'K14'),
('BS785', N'Hoàng Thị Thu Hà', N'Nữ', '9944442105', 'hoangthithuha@gmail.com', '1994/09/18', 'CV01', 'K14'),
('BS786', N'Vũ Minh Đức', 'Nam', '9944442106', 'vuminhduc@gmail.com', '1995/11/20', 'CV01', 'K14'),
('BS787', N'Trịnh Đức Mạnh', 'Nam', '9944442107', 'trinhducmanh@gmail.com', '1996/02/22', 'CV01', 'K14'),
('BS788', N'Ngô Thị Lan', N'Nữ', '9944442108', 'ngothilan@gmail.com', '1997/04/24', 'CV01', 'K14'),
('BS789', N'Mai Chí Trung', 'Nam', '9944442109', 'maichitrung@gmail.com', '1998/06/26', 'CV01', 'K14'),
('BS790', N'Đặng Phương Nam', 'Nam', '9944442110', 'dangphuongnam@gmail.com', '1999/08/28', 'CV01', 'K14'),
('BS791', N'Trần Hồng Nhung', N'Nữ', '9944442111', 'tranhongnhung@gmail.com', '2000/10/30', 'CV01', 'K14'),
('BS792', N'Lưu Minh Châu', N'Nữ', '9944442112', 'luuminhchau@gmail.com', '2001/12/02', 'CV01', 'K14'),
('BS793', N'Phạm Thành Đạt', 'Nam', '9944442113', 'phamthanhdatt@gmail.com', '2003/02/04', 'CV01', 'K14'),
('BS794', N'Nguyễn Thị Tuyết', N'Nữ', '9944442114', 'nguyenthituyet@gmail.com', '2004/04/06', 'CV01', 'K14'),
('BS795', N'Võ Đức Thành', 'Nam', '9944442115', 'voducthanh@gmail.com', '2005/06/08', 'CV01', 'K14'),

-------------------------------------------------K15---------------------------------------------------
('BS801', N'Nguyễn Thế An', 'Nam', '9944443121', 'nguyenthean@gmail.com', '1990/01/15', 'CV01', 'K15'),
('BS802', N'Lê Văn Bảo', 'Nam', '9944443122', 'levanbao@gmail.com', '1991/03/17', 'CV01', 'K15'),
('BS803', N'Trần Minh Châu', N'Nữ', '9944443123', 'tranminhchau@gmail.com', '1992/05/19', 'CV01', 'K15'),
('BS804', N'Doãn Thu Hà', N'Nữ', '9944443124', 'doanthuha@gmail.com', '1993/07/21', 'CV01', 'K15'),
('BS805', N'Phạm Hồng Loan', N'Nữ', '9944443125', 'phamhongloan@gmail.com', '1994/09/23', 'CV01', 'K15'),
('BS806', N'Ngô Đức Quý', 'Nam', '9944443126', 'ngoducquy@gmail.com', '1995/11/25', 'CV01', 'K15'),
('BS807', N'Mai Anh Tuấn', 'Nam', '9944443127', 'maianhtuan@gmail.com', '1996/02/27', 'CV01', 'K15'),
('BS808', N'Vũ Thị Phương', N'Nữ', '9944443128', 'vuthiphuong@gmail.com', '1997/04/29', 'CV01', 'K15'),
('BS809', N'Trần Khải Minh', 'Nam', '9944443129', 'trankhaiminh@gmail.com', '1998/06/01', 'CV01', 'K15'),
('BS810', N'Hoàng Minh Đức', 'Nam', '9944443130', 'hoangminhduc@gmail.com', '1999/08/03', 'CV01', 'K15'),
('BS811', N'Lý Thị Lan', N'Nữ', '9944443131', 'lythilan@gmail.com', '2000/10/05', 'CV01', 'K15'),
('BS812', N'Đỗ Minh Châu', N'Nữ', '9944443132', 'dominhchau@gmail.com', '2001/12/07', 'CV01', 'K15'),
('BS813', N'Bùi Quốc Thanh', 'Nam', '9944443133', 'buiquocthanh@gmail.com', '2003/02/09', 'CV01', 'K15'),
('BS814', N'Nguyễn Thị Hiền', N'Nữ', '9944443134', 'nguyenthihien@gmail.com', '2004/04/11', 'CV01', 'K15'),
('BS815', N'Võ Văn Khoa', 'Nam', '9944443135', 'vovankhoa@gmail.com', '2005/06/13', 'CV01', 'K15'),
---------------------------------------------K16----------------------------------------------------
('BS841', N'Phan Thị Bảo Trân', N'Nữ', '9955553101', 'phanthibao@gmail.com', '1990/06/10', 'CV01', 'K16'),
('BS842', N'Hoàng Anh Tuấn', 'Nam', '9955553102', 'hoanganhtuan@gmail.com', '1991/08/12', 'CV01', 'K16'),
('BS843', N'Đào Thị Lan Anh', N'Nữ', '9955553103', 'daothilananh@gmail.com', '1992/10/14', 'CV01', 'K16'),
('BS844', N'Lưu Quang Hải', 'Nam', '9955553104', 'luuquanghai@gmail.com', '1993/12/16', 'CV01', 'K16'),
('BS845', N'Nguyễn Minh Hằng', N'Nữ', '9955553105', 'nguyenminhhang@gmail.com', '1995/02/18', 'CV01', 'K16'),
('BS846', N'Bùi Xuân Phú', 'Nam', '9955553106', 'buixuanphu@gmail.com', '1996/04/20', 'CV01', 'K16'),
('BS847', N'Trần Hoài Nam', 'Nam', '9955553107', 'tranhoainam@gmail.com', '1997/06/22', 'CV01', 'K16'),
('BS848', N'Võ Thị Mai', N'Nữ', '9955553108', 'vothimai@gmail.com', '1998/08/24', 'CV01', 'K16'),
('BS849', N'Phạm Văn Kiên', 'Nam', '9955553109', 'phamvankien@gmail.com', '1999/10/26', 'CV01', 'K16'),
('BS850', N'Lê Ngọc Trâm', N'Nữ', '9955553110', 'lengoctram@gmail.com', '2000/12/28', 'CV01', 'K16'),
('BS851', N'Dương Văn Cảnh', 'Nam', '9955553111', 'duongvancanh@gmail.com', '2002/02/24', 'CV01', 'K16'),
('BS852', N'Trịnh Kim Chi', N'Nữ', '9955553112', 'trinhkimchi@gmail.com', '2003/05/01', 'CV01', 'K16'),
('BS853', N'Phan Thế Vinh', 'Nam', '9955553113', 'phanthevinh@gmail.com', '2004/07/03', 'CV01', 'K16'),
('BS854', N'Ngô Thị Bích', N'Nữ', '9955553114', 'ngothibich@gmail.com', '2005/09/05', 'CV01', 'K16'),
('BS855', N'Hoàng Minh Tâm', 'Nam', '9955553115', 'hoangminhtam@gmail.com', '2006/11/07', 'CV01', 'K16'),
-------------------------------------------------K17-------------------------------------------------------
('BS861', N'Nguyễn Anh Tuấn', 'Nam', '9955553121', 'nguyenanhtuan@gmail.com', '1990/02/05', 'CV04', 'K17'),
('BS862', N'Lê Phương Thảo', N'Nữ', '9955553122', 'lephuongthao@gmail.com', '1992/04/10', 'CV04', 'K17'),
('BS863', N'Tran Duy Khang', 'Nam', '9955553123', 'tranduykhang@gmail.com', '1994/06/15', 'CV04', 'K17'),
('BS864', N'Phạm Thị Hồng Nhung', N'Nữ', '9955553124', 'phamthinhongnhung@gmail.com', '1996/08/20', 'CV04', 'K17'),
('BS865', N'Vũ Mạnh Dũng', 'Nam', '9955553125', 'vumanhdung@gmail.com', '1998/10/25', 'CV04', 'K17'),
('BS866', N'Doãn Minh Hoàng', 'Nam', '9955553126', 'doanminhhoang@gmail.com', '2000/12/30', 'CV04', 'K17'),
('BS867', N'Trần Thị Mai', N'Nữ', '9955553127', 'tranthimai@gmail.com', '2003/03/05', 'CV04', 'K17'),
('BS868', N'Nguyễn Thế Vinh', 'Nam', '9955553128', 'nguyenthevinh@gmail.com', '2005/05/10', 'CV04', 'K17'),
('BS869', N'Hoàng Thị Lan', N'Nữ', '9955553129', 'hoangthilan@gmail.com', '2007/07/15', 'CV04', 'K17'),
('BS870', N'Bùi Văn Khoa', 'Nam', '9955553130', 'buivankhoa@gmail.com', '2009/09/20', 'CV04', 'K17'),
-----------------------------------------------K18-------------------------------------------------------------
('BS921', N'Lê Thanh Tùng', 'Nam', '9921115671', 'lethanhtung@gmail.com', '1990/01/01', 'CV01', 'K18'),
('BS922', N'Trần Hoài Nam', 'Nam', '9921115672', 'tranhoainam@gmail.com', '1991/02/15', 'CV01', 'K18'),
('BS923', N'Phạm Minh Châu', N'Nữ', '9921115673', 'phamminhchau@gmail.com', '1992/03/17', 'CV01', 'K18'),
('BS924', N'Nguyễn Thị Hà', N'Nữ', '9921115674', 'nguyenthiha@gmail.com', '1993/04/22', 'CV01', 'K18'),
('BS925', N'Vũ Minh Tuấn', 'Nam', '9921115675', 'vuminhtuan@gmail.com', '1994/05/28', 'CV01', 'K18'),
('BS926', N'Bùi Thị Mai', N'Nữ', '9921115676', 'buithimai@gmail.com', '1995/06/30', 'CV01', 'K18'),
('BS927', N'Đỗ Văn Kiên', 'Nam', '9921115677', 'dovankien@gmail.com', '1996/07/05', 'CV01', 'K18'),
('BS928', N'Hoàng Minh Tâm', 'Nam', '9921115678', 'hoangminhtam@gmail.com', '1997/08/11', 'CV01', 'K18'),
('BS929', N'Trần Thị Bích', N'Nữ', '9921115679', 'tranthibich@gmail.com', '1998/09/13', 'CV01', 'K18'),
('BS930', N'Phan Quốc Trung', 'Nam', '9921115680', 'phanquoctrung@gmail.com', '1999/10/20', 'CV01', 'K18'),
('BS931', N'Ngô Thị Lan', N'Nữ', '9921115681', 'ngothilan@gmail.com', '2000/11/22', 'CV01', 'K18'),
('BS932', N'Lưu Văn Hoàng', 'Nam', '9921115682', 'luuvanhoang@gmail.com', '2001/12/25', 'CV01', 'K18'),
('BS933', N'Nguyễn Văn Thanh', 'Nam', '9921115683', 'nguyenvanthanh@gmail.com', '2002/01/29', 'CV01', 'K18'),
('BS934', N'Phạm Hữu Lộc', 'Nam', '9921115684', 'phamhuuloc@gmail.com', '2003/02/12', 'CV01', 'K18'),
('BS935', N'Trần Minh Thu', N'Nữ', '9921115685', 'tranminhthu@gmail.com', '2004/03/29', 'CV01', 'K18'),
---------------------------------------K19-------------------------------------------------------------------------
('BS941', N'Đặng Thị Minh', N'Nữ', '9932115611', 'dangthiminh@gmail.com', '1990/01/15', 'CV01', 'K19'),
('BS942', N'Phạm Bảo Long', 'Nam', '9932115612', 'phambaolong@gmail.com', '1991/03/18', 'CV01', 'K19'),
('BS943', N'Lê Khánh Duy', 'Nam', '9932115613', 'lekhanhduy@gmail.com', '1992/05/21', 'CV01', 'K19'),
('BS944', N'Trần Hồng Quân', 'Nam', '9932115614', 'tranhongquan@gmail.com', '1993/07/24', 'CV01', 'K19'),
('BS945', N'Nguyễn Thị Hoa', N'Nữ', '9932115615', 'nguyenthihoa@gmail.com', '1994/09/27', 'CV01', 'K19'),
('BS946', N'Võ Minh Tâm', 'Nam', '9932115616', 'vominhtam@gmail.com', '1995/11/30', 'CV01', 'K19'),
('BS947', N'Bùi Ngọc Mai', N'Nữ', '9932115617', 'buingocmai@gmail.com', '1997/02/02', 'CV01', 'K19'),
('BS948', N'Hoàng Minh Hằng', N'Nữ', '9932115618', 'hoangminhhang@gmail.com', '1998/04/05', 'CV01', 'K19'),
('BS949', N'Lê Thị Thu', N'Nữ', '9932115619', 'lethithu@gmail.com', '1999/06/08', 'CV01', 'K19'),
('BS950', N'Trần Tuấn Anh', 'Nam', '9932115620', 'trantuananh@gmail.com', '2000/08/11', 'CV01', 'K19'),
('BS951', N'Phan Hữu Trí', 'Nam', '9932115621', 'phanhuutri@gmail.com', '2001/10/14', 'CV01', 'K19'),
('BS952', N'Ngô Anh Thư', N'Nữ', '9932115622', 'ngoanhthu@gmail.com', '2002/12/17', 'CV01', 'K19'),
('BS953', N'Vũ Đức Long', 'Nam', '9932115623', 'vuduclong@gmail.com', '2003/02/20', 'CV01', 'K19'),
('BS954', N'Bùi Thị Lan', N'Nữ', '9932115624', 'buithilan@gmail.com', '2004/04/23', 'CV01', 'K19'),
('BS955', N'Lưu Văn Thanh', 'Nam', '9932115625', 'luuvanthanh@gmail.com', '2005/06/26', 'CV01', 'K19'),
-------------------------------------------------------K20---------------------------------------------
('BS961', N'Nguyễn Minh Châu', 'Nam', '9933315611', 'nguyenminhchau@gmail.com', '1990/01/05', 'CV01', 'K20'),
('BS962', N'Trần Hải Dương', 'Nam', '9933315612', 'tranhaiduong@gmail.com', '1991/03/16', 'CV01', 'K20'),
('BS963', N'Phạm Tuyết Mai', N'Nữ', '9933315613', 'phamtuyetmai@gmail.com', '1992/06/25', 'CV01', 'K20'),
('BS964', N'Lê Đức Thắng', 'Nam', '9933315614', 'leducthang@gmail.com', '1993/09/03', 'CV01', 'K20'),
('BS965', N'Vũ Thị Hòa', N'Nữ', '9933315615', 'vuthihoa@gmail.com', '1994/11/12', 'CV01', 'K20'),
('BS966', N'Đặng Văn Khoa', 'Nam', '9933315616', 'dangvankhoa@gmail.com', '1996/01/22', 'CV01', 'K20'),
('BS967', N'Nguyễn Thị Lan', N'Nữ', '9933315617', 'nguyenthilan@gmail.com', '1997/04/01', 'CV01', 'K20'),
('BS968', N'Bùi Minh Quân', 'Nam', '9933315618', 'buiminhquan@gmail.com', '1998/06/10', 'CV01', 'K20'),
('BS969', N'Trần Thị Đào', N'Nữ', '9933315619', 'tranthidao@gmail.com', '1999/08/19', 'CV01', 'K20'),
('BS970', N'Lê Phương Anh', N'Nữ', '9933315620', 'lephuonganh@gmail.com', '2000/10/28', 'CV01', 'K20'),
('BS971', N'Phạm Văn Nam', 'Nam', '9933315621', 'phamvannam@gmail.com', '2002/01/06', 'CV01', 'K20'),
('BS972', N'Nguyễn Đức Hải', 'Nam', '9933315622', 'nguyenduchai@gmail.com', '2003/03/17', 'CV01', 'K20'),
('BS973', N'Vũ Hồng Sen', N'Nữ', '9933315623', 'vuhongsen@gmail.com', '2004/05/26', 'CV01', 'K20'),
('BS974', N'Bùi Thu Hằng', N'Nữ', '9933315624', 'buithuhang@gmail.com', '2005/08/04', 'CV01', 'K20'),
('BS975', N'Trần Minh Tuấn', 'Nam', '9933315625', 'tranminhtuan@gmail.com', '2006/10/13', 'CV01', 'K20'),
-----------------------------------------K21--------------------------------------------
('BS981', N'Đặng Kim Thành', 'Nam', '9934315611', 'dangkimthanh@gmail.com', '1990/01/05', 'CV01', 'K21'),
('BS982', N'Trần Thị Lan', N'Nữ', '9934315612', 'tranthilan@gmail.com', '1991/03/16', 'CV01', 'K21'),
('BS983', N'Phạm Minh Tuấn', 'Nam', '9934315613', 'phamminhtuan@gmail.com', '1992/06/25', 'CV01', 'K21'),
('BS984', N'Lê Hoàng Anh', 'Nam', '9934315614', 'lehoanganh@gmail.com', '1993/09/03', 'CV01', 'K21'),
('BS985', N'Nguyễn Thu Hà', N'Nữ', '9934315615', 'nguyenthuha@gmail.com', '1994/11/12', 'CV01', 'K21'),
('BS986', N'Vũ Đình Sơn', 'Nam', '9934315616', 'vudinhson@gmail.com', '1996/01/22', 'CV01', 'K21'),
('BS987', N'Nguyễn Khánh Linh', N'Nữ', '9934315617', 'nguyenkhanhlinh@gmail.com', '1997/04/01', 'CV01', 'K21'),
('BS988', N'Bùi Minh Châu', N'Nữ', '9934315618', 'buiminhchau@gmail.com', '1998/06/10', 'CV01', 'K21'),
('BS989', N'Trần Thị Nga', N'Nữ', '9934315619', 'tranthinga@gmail.com', '1999/08/19', 'CV01', 'K21'),
('BS990', N'Lê Văn Tâm', 'Nam', '9934315620', 'levantam@gmail.com', '2000/10/28', 'CV01', 'K21'),
('BS991', N'Phạm Hữu Lộc', 'Nam', '9934315621', 'phamhuuloc@gmail.com', '2002/01/06', 'CV01', 'K21'),
('BS992', N'Nguyễn Thị Hoa', N'Nữ', '9934315622', 'nguyenthihoa@gmail.com', '2003/03/17', 'CV01', 'K21'),
('BS993', N'Vũ Hải Long', 'Nam', '9934315623', 'vuhailong@gmail.com', '2004/05/26', 'CV01', 'K21'),
('BS994', N'Bùi Thị Mai', N'Nữ', '9934315624', 'buithimai@gmail.com', '2005/08/04', 'CV01', 'K21'),
('BS995', N'Trần Minh Đức', 'Nam', '9934315625', 'tranminhduc@gmail.com', '2006/10/13', 'CV01', 'K21'),
---------------------------------------------K22---------------------------------------------------
('BS1001', N'Nguyễn Đức Minh', 'Nam', '9934315631', 'nguyenducminh@gmail.com', '1990/03/01', 'CV01', 'K22'),
('BS1002', N'Trần Thị Hương', N'Nữ', '9934315632', 'tranthihuong@gmail.com', '1991/04/05', 'CV01', 'K22'),
('BS1003', N'Phạm Văn Bảo', 'Nam', '9934315633', 'phamvanbao@gmail.com', '1992/05/10', 'CV01', 'K22'),
('BS1004', N'Lê Khánh Vy', N'Nữ', '9934315634', 'lekhanhvy@gmail.com', '1993/06/15', 'CV01', 'K22'),
('BS1005', N'Hoàng Minh Tuấn', 'Nam', '9934315635', 'hoangminhtuan@gmail.com', '1994/07/20', 'CV01', 'K22'),
('BS1006', N'Ngô Thị Lan', N'Nữ', '9934315636', 'ngothilan@gmail.com', '1995/08/25', 'CV01', 'K22'),
('BS1007', N'Trần Nhật Phong', 'Nam', '9934315637', 'trannhatphong@gmail.com', '1996/09/30', 'CV01', 'K22'),
('BS1008', N'Phạm Thị Thu Thảo', N'Nữ', '9934315638', 'phamthithuthao@gmail.com', '1997/11/05', 'CV01', 'K22'),
('BS1009', N'Lê Văn Tài', 'Nam', '9934315639', 'levantai@gmail.com', '1998/12/10', 'CV01', 'K22'),
('BS1010', N'Nguyễn Thị Hoa', N'Nữ', '9934315640', 'nguyenthihoa@gmail.com', '2000/01/15', 'CV01', 'K22'),
('BS1011', N'Vũ Minh Đức', 'Nam', '9934315641', 'vuminhduc@gmail.com', '2001/02/20', 'CV01', 'K22'),
('BS1012', N'Trần Thị Mai', N'Nữ', '9934315642', 'tranthimai@gmail.com', '2002/03/27', 'CV01', 'K22'),
('BS1013', N'Nguyễn Văn Thắng', 'Nam', '9934315643', 'nguyenvanthang@gmail.com', '2003/04/30', 'CV01', 'K22'),
('BS1014', N'Lê Thị Hồng', N'Nữ', '9934315644', 'lethihong@gmail.com', '2004/06/05', 'CV01', 'K22'),
('BS1015', N'Phạm Văn Khoa', 'Nam', '9934315645', 'phamvankhoa@gmail.com', '2005/07/11', 'CV01', 'K22'),
-----------------------------------------------------------K23----------------------------------------------
('BS1021', N'Đỗ Thị Lan', N'Nữ', '9923315651', 'dothilan@gmail.com', '1992/01/15', 'CV01', 'K23'),
('BS1022', N'Nguyễn Văn Hùng', 'Nam', '9923315652', 'nguyenvanhung@gmail.com', '1994/05/20', 'CV01', 'K23'),
('BS1023', N'Trần Minh Thu', N'Nữ', '9923315653', 'tranminhthu@gmail.com', '1996/08/25', 'CV01', 'K23'),
('BS1024', N'Phạm Hữu Tài', 'Nam', '9923315654', 'phamhuutai@gmail.com', '1998/02/28', 'CV01', 'K23'),
('BS1025', N'Nguyễn Thị Mai', N'Nữ', '9923315655', 'nguyenthimai@gmail.com', '2000/07/05', 'CV01', 'K23'),
('BS1026', N'Lê Văn Nam', 'Nam', '9923315656', 'levannam@gmail.com', '2002/11/15', 'CV01', 'K23'),
('BS1027', N'Trần Hà Linh', N'Nữ', '9923315657', 'tranhalinh@gmail.com', '2004/12/21', 'CV01', 'K23'),
('BS1028', N'Phạm Quốc Toản', 'Nam', '9923315658', 'phamquoctoan@gmail.com', '2007/03/30', 'CV01', 'K23'),
('BS1029', N'Lưu Thị Bảo', N'Nữ', '9923315659', 'luuthibao@gmail.com', '2010/09/25', 'CV01', 'K23'),
('BS1030', N'Nguyễn Hữu Khánh', 'Nam', '9923315660', 'nguyenhuukhanh@gmail.com', '2013/01/10', 'CV01', 'K23'),
---------------------------------------------K24------------------------------------------------------
('BS1031', N'Nguyễn Thế Anh', 'Nam', '9933315671', 'nguyen.theanh@gmail.com', '1991/03/20', 'CV01', 'K24'),
('BS1032', N'Lê Hồng Phúc', 'Nam', '9933315672', 'le.hongphuc@gmail.com', '1993/06/15', 'CV01', 'K24'),
('BS1033', N'Phan Thị Nhung', N'Nữ', '9933315673', 'phan.thinhung@gmail.com', '1995/09/08', 'CV01', 'K24'),
('BS1034', N'Trần Duy Quang', 'Nam', '9933315674', 'tran.duyquang@gmail.com', '1997/12/24', 'CV01', 'K24'),
('BS1035', N'Nguyễn Khánh Linh', N'Nữ', '9933315675', 'nguyen.khanhlinh@gmail.com', '2000/04/03', 'CV01', 'K24'),
('BS1036', N'Vũ Minh Tuấn', 'Nam', '9933315676', 'vu.minhtuan@gmail.com', '2002/07/19', 'CV01', 'K24'),
('BS1037', N'Đỗ Phương Thảo', N'Nữ', '9933315677', 'do.phuongthao@gmail.com', '2004/10/29', 'CV01', 'K24'),
('BS1038', N'Bùi Hữu Đạt', 'Nam', '9933315678', 'bui.huudat@gmail.com', '2006/01/15', 'CV01', 'K24'),
('BS1039', N'Phạm Thị Hoa', N'Nữ', '9933315679', 'pham.thihoa@gmail.com', '2008/05/22', 'CV01', 'K24'),
('BS1040', N'Hoàng Minh Hải', 'Nam', '9933315680', 'hoang.minhhai@gmail.com', '2010/08/10', 'CV01', 'K24'),
('BS1041', N'Lê Thị Mỹ', N'Nữ', '9933315681', 'le.thimy@gmail.com', '2012/11/27', 'CV01', 'K24'),
('BS1042', N'Tran Van Khoa', 'Nam', '9933315682', 'tran.vankhoa@gmail.com', '2015/02/13', 'CV01', 'K24'),
('BS1043', N'Nguyễn Thị Hương', N'Nữ', '9933315683', 'nguyen.thihuong@gmail.com', '2017/04/30', 'CV01', 'K24'),
('BS1044', N'Phạm Ngọc Thạch', 'Nam', '9933315684', 'pham.ngocthach@gmail.com', '2019/08/16', 'CV01', 'K24'),
('BS1045', N'Trần Hạnh Nhi', N'Nữ', '9933315685', 'tran.hanhnhi@gmail.com', '2021/11/03', 'CV01', 'K24'),
------------------------------------K25-----------------------------------------
('BS1061', N'Trần Thế An', 'Nam', '9983315681', 'tran.thean@gmail.com', '1990/03/12', 'CV01', 'K25'),
('BS1062', N'Phạm Thu Trang', N'Nữ', '9983315682', 'pham.thutrang@gmail.com', '1992/05/24', 'CV01', 'K25'),
('BS1063', N'Lê Quốc Toàn', 'Nam', '9983315683', 'le.quoctoan@gmail.com', '1994/07/16', 'CV01', 'K25'),
('BS1064', N'Nguyễn Minh Hằng', N'Nữ', '9983315684', 'nguyen.minhhang@gmail.com', '1996/09/08', 'CV01', 'K25'),
('BS1065', N'Đỗ Tiến Đạt', 'Nam', '9983315685', 'do.tiendat@gmail.com', '1998/11/30', 'CV01', 'K25'),
('BS1066', N'Trần Thị Lan', N'Nữ', '9983315686', 'tran.thilan@gmail.com', '2000/02/21', 'CV01', 'K25'),
('BS1067', N'Hoàng Văn Thái', 'Nam', '9983315687', 'hoang.vanthai@gmail.com', '2002/04/14', 'CV01', 'K25'),
('BS1068', N'Ngô Thị Bảo', N'Nữ', '9983315688', 'ngo.thibao@gmail.com', '2004/06/06', 'CV01', 'K25'),
('BS1069', N'Vũ Văn Hòa', 'Nam', '9983315689', 'vu.vanhoa@gmail.com', '2006/07/29', 'CV01', 'K25'),
('BS1070', N'Lê Thị Thơ', N'Nữ', '9983315690', 'le.thitho@gmail.com', '2008/09/20', 'CV01', 'K25'),
('BS1071', N'Trần Đình Khiêm', 'Nam', '9983315691', 'tran.dinhkhiem@gmail.com', '2010/11/12', 'CV01', 'K25'),
('BS1072', N'Phạm Thị Quyên', N'Nữ', '9983315692', 'pham.thiquyen@gmail.com', '2013/01/04', 'CV01', 'K25'),
('BS1073', N'Dương Văn Bảo', 'Nam', '9983315693', 'duong.vanbao@gmail.com', '2015/02/25', 'CV01', 'K25'),
('BS1074', N'Trần Thị Mai', N'Nữ', '9983315694', 'tran.thimai@gmail.com', '2017/04/17', 'CV01', 'K25'),
('BS1075', N'Phan Anh Tuấn', 'Nam', '9983315695', 'phan.anhtuan@gmail.com', '2019/06/09', 'CV01', 'K25'),
------------------------------------------------K26---------------------------------------
('BS1081', N'Bùi Minh Quân', 'Nam', '9984425611', 'buiminhquan@gmail.com', '1990/01/15', 'CV01', 'K26'),
('BS1082', N'Ngô Ánh Linh', N'Nữ', '9984425612', 'ngoanhlinh@gmail.com', '1992/03/17', 'CV01', 'K26'),
('BS1083', N'Trần Hoài Nam', 'Nam', '9984425613', 'tranhoainam@gmail.com', '1994/05/19', 'CV01', 'K26'),
('BS1084', N'Lê Kim Chi', N'Nữ', '9984425614', 'lekimchi@gmail.com', '1996/07/21', 'CV01', 'K26'),
('BS1085', N'Phạm Quốc Toản', 'Nam', '9984425615', 'phamquoctoan@gmail.com', '1998/09/23', 'CV01', 'K26'),
('BS1086', N'Thái Thùy Linh', N'Nữ', '9984425616', 'thaithuylinh@gmail.com', '2000/11/25', 'CV01', 'K26'),
('BS1087', N'Đỗ Duy Mạnh', 'Nam', '9984425617', 'doduymang@gmail.com', '2003/01/27', 'CV01', 'K26'),
('BS1088', N'Nguyễn Thanh Hà', N'Nữ', '9984425618', 'nguyenthanhha@gmail.com', '2005/03/29', 'CV01', 'K26'),
('BS1089', N'Vũ Ngọc Đăng', 'Nam', '9984425619', 'vungocdang@gmail.com', '2007/05/31', 'CV01', 'K26'),
('BS1090', N'Thái Minh Châu', N'Nữ', '9984425620', 'thaiminhchau@gmail.com', '2009/08/02', 'CV01', 'K26'),
('BS1091', N'Đặng Thanh Tùng', 'Nam', '9984425621', 'dangthanhtung@gmail.com', '2011/10/04', 'CV01', 'K26'),
('BS1092', N'Huỳnh Bảo Trâm', N'Nữ', '9984425622', 'huynhbaotram@gmail.com', '2013/12/06', 'CV01', 'K26'),
('BS1093', N'Tô Minh Đức', 'Nam', '9984425623', 'tominhduc@gmail.com', '2016/02/08', 'CV01', 'K26'),
('BS1094', N'Phan Thị Mai', N'Nữ', '9984425624', 'phanthimai@gmail.com', '2018/04/10', 'CV01', 'K26'),
('BS1095', N'Nguyễn Tuấn Kiệt', 'Nam', '9984425625', 'nguyentuankiet@gmail.com', '2020/06/12', 'CV01', 'K26'),
----------------------------------------K27------------------------------------------------------------------------
('BS1101', N'Võ Văn Thanh', 'Nam', '9984425701', 'vovanthanh@gmail.com', '1990/01/07', 'CV01', 'K27'),
('BS1102', N'Lý Hoàng Anh', N'Nữ', '9984425702', 'lyhoanganh@gmail.com', '1992/02/18', 'CV01', 'K27'),
('BS1103', N'Trương Văn Bảo', 'Nam', '9984425703', 'truongvanbao@gmail.com', '1994/03/28', 'CV01', 'K27'),
('BS1104', N'Nguyễn Mai Phương', N'Nữ', '9984425704', 'nguyenmaiphuong@gmail.com', '1996/05/09', 'CV01', 'K27'),
('BS1105', N'Đặng Minh Trí', 'Nam', '9984425705', 'dangminhtri@gmail.com', '1998/07/21', 'CV01', 'K27'),
('BS1106', N'Hoàng Thị Thu', N'Nữ', '9984425706', 'hoangthithu@gmail.com', '2000/09/02', 'CV01', 'K27'),
('BS1107', N'Lê Quốc Tùng', 'Nam', '9984425707', 'lequoctung@gmail.com', '2002/10/13', 'CV01', 'K27'),
('BS1108', N'Phạm Khánh Linh', N'Nữ', '9984425708', 'phamkhanhlinh@gmail.com', '2004/12/24', 'CV01', 'K27'),
('BS1109', N'Vũ Tiến Đạt', 'Nam', '9984425709', 'vutiendat@gmail.com', '2007/02/04', 'CV01', 'K27'),
('BS1110', N'Thái Bảo Trâm', N'Nữ', '9984425710', 'thaibaotram@gmail.com', '2009/03/16', 'CV01', 'K27'),
('BS1111', N'Ngô Đình Nam', 'Nam', '9984425711', 'ngodinhnam@gmail.com', '2011/05/28', 'CV01', 'K27'),
('BS1112', N'Trần Huyền My', N'Nữ', '9984425712', 'tranmy@gmail.com', '2013/07/10', 'CV01', 'K27'),
('BS1113', N'Dương Văn Hòa', 'Nam', '9984425713', 'duongvanhoa@gmail.com', '2015/08/21', 'CV01', 'K27'),
('BS1114', N'Lê Thị Lan', N'Nữ', '9984425714', 'lethilan@gmail.com', '2017/10/03', 'CV01', 'K27'),
('BS1115', N'Phan Thế Vinh', 'Nam', '9984425715', 'phanthevinh@gmail.com', '2019/11/14', 'CV01', 'K27'),
---------------------------------------------------K28------------------------------------------------------
('BS1201', N'Nguyễn Anh Dũng', 'Nam', '9984425801', 'nguyenanhdung@gmail.com', '1990/01/11', 'CV01', 'K28'),
('BS1202', N'Lê Thị Thanh', N'Nữ', '9984425802', 'lethithanh@gmail.com', '1992/02/22', 'CV01', 'K28'),
('BS1203', N'Đỗ Văn Hải', 'Nam', '9984425803', 'dovanhai@gmail.com', '1994/04/03', 'CV01', 'K28'),
('BS1204', N'Trần Thị Mai', N'Nữ', '9984425804', 'tranthimai@gmail.com', '1996/05/15', 'CV01', 'K28'),
('BS1205', N'Hoàng Văn Tuấn', 'Nam', '9984425805', 'hoangvantuan@gmail.com', '1998/06/26', 'CV01', 'K28'),
('BS1206', N'Vũ Thị Thùy Dung', N'Nữ', '9984425806', 'vuthithuydung@gmail.com', '2000/08/07', 'CV01', 'K28'),
('BS1207', N'Lê Văn Hải', 'Nam', '9984425807', 'levanhai@gmail.com', '2002/09/18', 'CV01', 'K28'),
('BS1208', N'Nguyễn Thị Lan Anh', N'Nữ', '9984425808', 'nguyenthilananh@gmail.com', '2004/10/30', 'CV01', 'K28'),
('BS1209', N'Phạm Văn Hùng', 'Nam', '9984425809', 'phamvanhung@gmail.com', '2006/12/11', 'CV01', 'K28'),
('BS1210', N'Đặng Thị Thanh Hằng', N'Nữ', '9984425810', 'dangthithanhhang@gmail.com', '2009/01/22', 'CV01', 'K28'),
('BS1211', N'Ngô Văn Hoàng', 'Nam', '9984425811', 'ngovanhoang@gmail.com', '2011/03/05', 'CV01', 'K28'),
('BS1212', N'Trần Thị Thúy Hằng', N'Nữ', '9984425812', 'tranthithuyhang@gmail.com', '2013/04/16', 'CV01', 'K28'),
('BS1213', N'Vũ Văn Tú', 'Nam', '9984425813', 'vuvantu@gmail.com', '2015/05/29', 'CV01', 'K28'),
('BS1214', N'Đinh Thị Thúy Nga', N'Nữ', '9984425814', 'dinhthithuynga@gmail.com', '2017/07/10', 'CV01', 'K28'),
('BS1215', N'Hoàng Minh Tuấn', 'Nam', '9984425815', 'hoangminhtuan@gmail.com', '2019/08/21', 'CV01', 'K28'),
----------------------------------------------------K29------------------------------------------------------------
('BS1301', N'Nguyễn Văn An', 'Nam', '9984575801', 'nguyenvanan@gmail.com', '1990/03/10', 'CV01', 'K29'),
('BS1302', N'Trần Thị Bảo', N'Nữ', '9984575802', 'tranthibao@gmail.com', '1992/04/20', 'CV01', 'K29'),
('BS1303', N'Lê Văn Cường', 'Nam', '9984575803', 'levancuong@gmail.com', '1994/05/30', 'CV01', 'K29'),
('BS1304', N'Hoàng Thị Đào', N'Nữ', '9984575804', 'hoangthidao@gmail.com', '1996/06/09', 'CV01', 'K29'),
('BS1305', N'Đỗ Thị Thu', N'Nữ', '9984575805', 'dothithu@gmail.com', '1998/07/19', 'CV01', 'K29'),
('BS1306', N'Phạm Văn Kiên', 'Nam', '9984575806', 'phamvankien@gmail.com', '2000/08/29', 'CV01', 'K29'),
('BS1307', N'Vũ Thị Lan', N'Nữ', '9984575807', 'vuthilan@gmail.com', '2002/10/08', 'CV01', 'K29'),
('BS1308', N'Ngô Quốc Huy', 'Nam', '9984575808', 'ngoquochuy@gmail.com', '2004/11/18', 'CV01', 'K29'),
('BS1309', N'Đặng Thị Ngọc', N'Nữ', '9984575809', 'dangthingoc@gmail.com', '2007/01/28', 'CV01', 'K29'),
('BS1310', N'Trần Văn Thanh', 'Nam', '9984575810', 'tranvanthanh@gmail.com', '2009/03/09', 'CV01', 'K29'),
('BS1311', N'Lê Thị Hồng', N'Nữ', '9984575811', 'lethihong@gmail.com', '2011/04/19', 'CV01', 'K29'),
('BS1312', N'Nguyễn Văn Phú', 'Nam', '9984575812', 'nguyenvanphu@gmail.com', '2013/05/30', 'CV01', 'K29'),
('BS1313', N'Vũ Thị Mai', N'Nữ', '9984575813', 'vuthimai@gmail.com', '2015/07/10', 'CV01', 'K29'),
('BS1314', N'Hoàng Văn Đạt', 'Nam', '9984575814', 'hoangvandat@gmail.com', '2017/08/20', 'CV01', 'K29'),
('BS1315', N'Đỗ Văn Hoàng', 'Nam', '9984575815', 'dovanhoang@gmail.com', '2019/09/30', 'CV01', 'K29')

-----------------------------------Y tá không khám dịch vụ
insert into NhanVien([MaNV],[TenNV],[GioiTinh],[SDT],[Email],[NgayBatDauLam],[MaCV],[MaKhoa])
values 
	 ('YT01',N'Nguyễn Đăng Tuấn',N'Nam','7261590171','nguyendangtuan@gmail.com','1954/03/12','CV02','K01')
	,('YT02',N'Nguyễn Ngọc Khánh',N'Nam','','nguyenngockhanh@gmail.com','1954/03/12','CV02','K01')
	,('YT04',N'Bùi Thu Hương',N'Nữ','2652817261','buithuhuong@gmail.com','2023/05/02','CV02','K01')
	,('YT05',N'Nguyễn Thị Phi Yến',N'Nữ','6253827191','nguyenngockhanh@gmail.com','1954/03/12','CV02','K02')
	,('YT06',N'Nguyễn Thị Tâm',N'Nữ','','','1955/03/12','CV02','K02')
	,('YT07',N'Hà Thị Thu Hiền',N'Nữ','','hathithuhien@gmail.com','2002/03/12','CV02','K02')
	,('YT08',N'Phạm Thị Thu Hương',N'Nữ','2367182716','phamthithuhuong@gmail.com','2022/05/12','CV02','K02')
	,('YT09',N'Phạm Thị Việt Hương',N'Nữ','2651632345','phamthiviethuong@gmail.com','1954/03/12','CV02','K02')
	,('YT10',N'Nguyễn Thu Hoài',N'Nữ','','nguyenthuhoai@gmail.com','1954/03/12','CV02','K02')
	,('YT11',N'Phùng Quang Thủy',N'Nam','9876527381','','2000/03/12','CV02','K03')
	,('YT12',N'Nguyễn Khắc Đạt',N'Nam','5362716215','nguyenkhacdat@gmail.com','1954/03/12','CV02','K03')
	,('YT13',N'Phạm Tuyết Trinh',N'Nữ','','','1955/06/17','CV02','K03')
	,('YT14',N'Nguyễn Văn Phong',N'Nam','2536171891','nguyenvanphong@gmail.com','2017/06/11','CV02','K04')
	,('YT15',N'Nguyễn Xuân Thanh',N'Nam','','nguyenxuanthanh@gmail.com','2022/09/13','CV02','K04')
	,('YT16',N'Lê Đức Hiệp',N'Nam','2153617621','leduchiep@gmail.com','2017/07/12','CV02','K04')
	,('YT18',N'Tô Minh Hương',N'Nữ','4536297542','tominhhuong@gmail.com','1999/06/11','CV02','K05')
	,('YT19',N'Lê Thị Phương Lan',N'Nữ','','','1999/06/11','CV02','K05')
	,('YT20',N'Nguyễn Ngọc Chiến',N'Nam','','nguyenngocchien@gmail.com','2000/06/11','CV02','K05')
	,('YT21',N'Nguyễn Thị Xuyến',N'Nữ','6252615226','nguyenthixuyen@gmail.com','1999/06/11','CV02','K06')
	,('YT22',N'Nguyễn Bá Hưng',N'Nam','6251690176','','1995/11/12','CV02','K06')
	,('YT23',N'Nguyễn Thị Cẩm Vân',N'Nữ','','','2022/01/11','CV02','K06')
	,('YT24',N'Nguyễn Thị Tâm Lý',N'Nữ','7827162781','nguyenthitamly@gmail.com','1995/02/03','CV02','K07')
	,('YT25',N'Nguyễn Đăng Đại',N'Nam','','nguyendangdai@gmail.com','1995/12/06','CV02','K07')
	,('YT26',N'Phạm Hồng Thái',N'Nữ','7261009021','phamhongthai@gmail.com','1995/02/03','CV02','K08')
	,('YT27',N'Phạm Đức Thọ',N'Nam','6251726172','','1996/01/03','CV02','K08')
	,('YT28',N'Trần Văn Trọng',N'Nam','','tranvantrong@gmail.com','2000/12/11','CV02','K08')
	,('YT29',N'Nguyễn Công Hoàng',N'Nam','8716271621','nguyenconghoan@gmail.com','2018/05/02','CV02','K09')
	,('YT30',N'Nguyễn Thái Bảo',N'Nam','','nguyenthaibao@gmail.com','1990/12/02','CV02','K09')
	,('YT31',N'Đỗ Tất Cường',N'Nam','6251627181','','2024/05/02','CV02','K09')
	,('YT32',N'Phan Quang Đoàn',N'Nam','9090965432','phanqdoan@gmail.com','1990/08/12','CV02','K10')
	,('YT33',N'Nguyễn Thị Kim Dung',N'Nam','','nguyenthikimdung@gmail.com','2019/05/02','CV02','K10')
	,('YT34',N'Nguyễn Công Hoàng',N'Nam','','','2018/05/02','CV02','K10')
	,('YT35',N'Hoàng Thị Thu Hương',N'Nữ','6272617261','hoangthithuhuong@gmail.com','2000/08/12','CV02','K11')
	,('YT36',N'Nguyễn Thị Minh Tuyết',N'Nữ','','nguyenthiminhtuyet@gmail.com','2001/08/12','CV02','K11')
	,('YT37',N'Nguyễn Thị Mận',N'Nữ','','','2022/09/11','CV02','K11')
	,('YT38',N'Cao Thị Giang',N'Nữ','6272617876','caothigiang@gmail.com','1990/08/12','CV02','K12')
	,('YT39',N'Đàm Thị Quỳnh',N'Nữ','7625162512','','1991/10/12','CV02','K12')
	,('YT40',N'Ninh Thị Ứng',N'Nữ','','ninhthiung@gmail.com','2022/08/12','CV02','K12')
	,('YT41',N'Nguyễn Thị Thùy Linh',N'Nữ','9872652412','nguyenthithuylinh@gmail.com','2000/09/23','CV02','K13')
	,('YT42',N'Trần Quốc Vĩnh',N'Nam','','','1995/01/03','CV02','K13')
	,('YT43',N'Bùi Thị Hồng Khang',N'Nữ','9872008726','buithihongkhang@gmail.com','2001/09/23','CV02','K13')
	,('YT44',N'Tạ Quốc Bản',N'Nam','9000765123','taquocban@gmail.com','1991/11/29','CV02','K14')
	,('YT45',N'Đoàn Ngọc Quỳnh Trâm',N'Nữ','','quynhtram@gmail.com','2023/03/01','CV02','K14')
	,('YT46',N'Nguyễn Xuân Tịnh',N'Nam','','','2017/05/12','CV02','K14')
	,('YT47',N'Nguyễn Thị Thúy Hằng',N'Nữ','9000760003','nguyenthithuyhang@gmail.com','1992/07/30','CV02','K15')
	,('YT48',N'Trương Công Duẩn',N'Nam','','truongcongduan@gmail.com','2002/09/30','CV02','K15')
	,('YT49',N'Trần Quỳnh Trang',N'Nữ','9372617281','','2021/04/22','CV02','K15')
	,('YT50',N'Trịnh Quang Diện',N'Nam','0962516271','trinhquangdien@gmail.com','1991/01/11','CV02','K16')
	,('YT51',N'Nguyễn Gia Bình',N'Nam','','','1992/01/11','CV02','K16')
	,('YT52',N'Ngô Văn Dần',N'Nam','','ngovandan@gmail.com','2023/12/24','CV02','K16')
	,('YT53',N'Triệu Thị Hồng Thái',N'Nữ','8736251621','trieuthihongthai@gmail.com','2012/02/11','CV02','K17')
	,('YT54',N'Phạm Đỗ Ngọc Diệp',N'Nữ','8736251600','','1998/02/11','CV02','K17')
	,('YT55',N'Nguyễn Văn Khánh',N'Nam','','','2024/01/11','CV02','K17')
	,('YT56',N'Nguyễn Đức Thọ',N'Nam','0936271628','nguyenductho@gmail.com','1990/08/29','CV02','K18')
	,('YT57',N'Lê Dương Tiến',N'Nam','','','1994/02/28','CV02','K18')
	,('YT58',N'Đỗ Thị Hảo',N'Nam','','dothihao@gmail.com','2014/09/12','CV02','K18')
	,('YT59',N'Vu Duy Chinh',N'Nam','1762635289','vuduychinh@gmail.com','1996/09/18','CV02','K19')
	,('YT60',N'Cao Thị Anh Đào',N'Nữ','6527872612','caothianhdao@gmail.com','1999/12/24','CV02','K19')
	,('YT61',N'Huỳnh Bảo Toàn',N'Nam','','','2002/01/16','CV02','K19')
	,('YT62',N'Lương Võ	Quang',N'Nam','6876543900','luongvoquang@gmail.com','2023/02/21','CV02','K20')
	,('YT63',N'Nguyễn Duy Bộ',N'Nam','','nguyenduybo@gmail.com','2013/05/04','CV02','K20')
	,('YT64',N'Nguyễn Viết Thụ',N'Nam','','','2003/02/21','CV02','K20')
	,('YT65',N'Tạ Quang Hùng',N'Nam','6999002651','taquanghung@gmail.com','1991/03/20','CV02','K21')
	,('YT66',N'Trần Thị Ngát',N'Nữ','699902761','tranthingat@gmail.com','2019/06/03','CV02','K21')
	,('YT67',N'Nguyễn Đức Thông',N'Nam','','','2006/08/11','CV02','K21')
	,('YT68',N'Dương Xuân Lộc',N'Nam','7776548904','duongxuanloc@gmail.com','1990/12/12','CV02','K22')
	,('YT69',N'Nguyễn Văn Thái',N'Nam','7776548765','','1999/06/10','CV02','K22')
	,('YT70',N'Nguyễn Thị Thanh Thu',N'Nự','','','2000/09/27','CV02','K22')
	,('YT71',N'Nguyễn Thị Minh Thuyên',N'Nữ','7983726125','nguyenthiminhthuyen@gmail.com','2007/09/11','CV02','K23')
	,('YT72',N'Nguyễn Thái Hưng',N'Nam','','nguyenthaihung@gmail.com','2009/08/19','CV02','K23')
	,('YT73',N'Trần Khắc Điền',N'Nam','','trankhacdien@gmail.com','2003/03/23','CV02','K23')
	,('YT74',N'Nguyễn Văn Thắng',N'Nam','6545900654','nguyenvanthang@gmail.com','2010/07/02','CV02','K24')
	,('YT75',N'Hoàng Lan Nhung',N'Nữ','','','1999/02/01','CV02','K24')
	,('YT76',N'Quách Thị Thanh Nhàn',N'Nữ','6545900543','thanhnhan@gmail.com','2010/07/02','CV02','K24')
	,('YT77',N'Phan Ngọc Toán',N'Nam','3456547890','phanngoctoan@gmail.com','2021/09/22','CV02','K25')
	,('YT78',N'Nguyễn Thanh Nam',N'Nam','','','1989/09/22','CV02','K25')
	,('YT79',N'Lê Thị Hồng Vũ',N'Nữ','','lethihongvu@gmail.com','2001/06/07','CV02','K25')
	,('YT80',N'Huỳnh Kim Long',N'Nam','3456546521','huynhkimlong@gmail.com','2021/09/22','CV02','K26')
	,('YT81',N'Lý Thị Thanh Nhã',N'Nữ','0875456754','','1954/09/22','CV02','K26')
	,('YT82',N'Nguyễn Minh Tuấn',N'Nam','','nguyenminhtuan@gmail.com','1977/10/10','CV02','K26')
	,('YT83',N'Dương Đức Bình',N'Nam','6745982612','duongducbinh@gmail.com','1996/01/22','CV02','K27')
	,('YT84',N'Nguyễn Quang Đức',N'Nam','6745982762','nguyenquangduc@gmail.com','2005/08/03','CV02','K27')
	,('YT85',N'Nguyễn Hùng Cương',N'Nam','','','2020/10/03','CV02','K27')
	,('YT86',N'Nguyễn Lê Đức Hoàng',N'Nam','7837890123','nguyenleduchoang@gmail.com','2004/09/09','CV02','K28')
	,('YT87',N'Bùi Ngọc Phương Hòa',N'Nam','','buingocphuonghoa@gmail.com','2019/12/23','CV02','K28')
	,('YT88',N'Nguyễn Ngọc Bách',N'Nam','','','2000/12/28','CV02','K28')
	,('YT89',N'Võ Khôi Nguyên',N'Nam','2354789012','vokhoinguyen@gmail.com','1990/03/04','CV02','K29')
	,('YT90',N'Bùi Thị Thanh Hà',N'Nữ','9000376221','','1994/04/17','CV02','K29')
	,('YT91',N'Nguyễn Bình',N'Nam','','','2019/03/19','CV02','K29'),
	('YT146',N'Đỗ Duy Nhân',N'Nam','54672407','donhan@gmail.com','2019/04/30','CV02','K29'),
	('YT147',N'Nguyễn Phúc Thiện Nhân',N'Nam','123567098','nhannguyen@gmail.com','2020/01/29','CV02','K29'),

	('YT144',N'Trương Đức Hải',N'Nam','24576854','haitruong@gmail.com','2024/01/17','CV02','K28'),
	('YT145',N'Ngọc Ngọc Thùy Dương',N'Nữ','325436474','ngocduong@gmail.com','2023/06/12','CV02','K28'),

	('YT142',N'Nguyễn Hà Oanh',N'Nữ','645365865','nguyenoanh@gmail.com','2007/04/15','CV02','K27'),
	('YT143',N'Dương Thanh Tú',N'Nữ','123678945','duongtu@gmail.com','2008/03/10','CV02','K27'),

	('YT140',N'Nguyễn Ngọc Y Tiên',N'Nữ','0938345654','tiennguyen@gmail.com','2011/08/13','CV02','K26'),
	('YT141',N'Nguyễn Hoàng Trân',N'Nữ','0973566376','trannguyen@gmail.com','2010/05/11','CV02','K26'),

	('YT138',N'Lê Văn Án',N'Nam','86453145','lean@gmail.com','2018/08/13','CV02','K25'),
	('YT139',N'Nguyễn Hoàng',N'Nữ','230647534','nguyenhoang@gmail.com','2016/05/11','CV02','K25'),

	('YT136',N'Lê Thọ',N'Nam','17564531','letho@gmail.com','2024/12/13','CV02','K24'),
	('YT137',N'Nguyễn Thị Hồng Mỹ',N'Nữ','38245574','mynguyen@gmail.com','2024/10/11','CV02','K24'),

	('YT134',N'Nguyễn Duy Sơn',N'Nam','9576434','sonnguyen@gmail.com','2021/07/29','CV02','K23'),
	('YT135',N'Nguyễn Hà Mây',N'Nữ','6734231','maynguyen@gmail.com','2022/09/24','CV02','K23'),

	('YT132',N'Nguyễn Trần Phúc Hậu',N'Nam','2457257','haunguyen@gmail.com','2021/07/29','CV02','K22'),
	('YT133',N'Bùi Thị Phương',N'Nam','8645634','phuongbui@gmail.com','2022/09/24','CV02','K22'),

	('YT131',N'Hữu Duy Khang',N'Nam','2457257','duykhang@gmail.com','2017/07/18','CV02','K21'),
	('YT130',N'Võ Thanh Uyển',N'Nam','8645634','vouyen@gmail.com','2023/04/20','CV02','K21'),

	('YT128',N'Nguyễn Trần Trung Quân',N'Nam','2457257','quannguyen@gmail.com','2000/07/18','CV02','K20'),
	('YT129',N'Đặng Thị Kiều Uyên',N'Nữ','1287965','uyendang@gmail.com','2018/12/23','CV02','K20'),

	('YT126',N'Dương Tuấn Kiệt',N'Nam','2345678901','kietduong@gmail.com','1996/07/18','CV02','K19'),
	('YT127',N'Nguyễn Văn Minh',N'Nam','7890123456','minhnguyen@gmail.com','1995/12/23','CV02','K19'),

	('YT124',N'Nguyễn Thành Nam',N'Nam','4567890123','namnguyen@gmail.com','1998/03/20','CV02','K18'),
	('YT125',N'Trương Y Mẫn',N'Nữ','5678901234','mantruong@gmail.com','2001/03/29','CV02','K18'),

	('YT122',N'Nguyễn Trung Trực',N'Nam','1234567','nguyentruc@gmail.com','2000/09/18','CV02','K17'),
	('YT123',N'Nguyễn Trần Thanh Tuấn',N'Nam','2345678','nguyentuan@gmail.com','2000/11/23','CV02','K17'),

	('YT120',N'Mai Anh Hương',N'Nữ','34536456','maihuong@gmail.com','1995/06/16','CV02','K16'),
	('YT121',N'Võ Trần Thanh Hằng',N'Nữ','654745623','hangvo@gmail.com','1992/03/21','CV02','K16'),

	('YT118',N'Bùi Trí Trung',N'Nam','','trungbui@gmail.com','1984/06/16','CV02','K15'),
	('YT119',N'Võ Trần Thanh Hằng',N'Nữ','','hangvo@gmail.com','2004/07/24','CV02','K15'),

	('YT116',N'Hữu Thanh Bình',N'Nam','','huubinh@gmail.com','1980/10/08','CV02','K14'),
	('YT117',N'Tư Hồng Yên',N'Nữ','','tuyen@gmail.com','2000/01/27','CV02','K14'),

	('YT114',N'Bùi Thanh Khánh',N'Nam','','thanhkhanh@gmail.com','1997/11/09','CV02','K13'),
	('YT115',N'Trần Ngọc Yến',N'Nữ','','yentran@gmail.com','1987/01/16','CV02','K13'),

	('YT112',N'Hà Mộc Lan',N'Nữ','','mocla@gmail.com','1990/11/09','CV02','K12'),
	('YT113',N'Châu Hải Nam',N'Nam','','namchau@gmail.com','1999/07/30','CV02','K12'),

	('YT110',N'Đỗ Duy Khải',N'Nam','1223344556','khaido@gmail.com','2001/12/11','CV02','K11'),
	('YT111',N'Trần Duy Linh',N'Nữ','0973623625','linhtran@gmail.com','2000/11/25','CV02','K11'),

	('YT108',N'Hà Duy Tuấn',N'Nam','098765412','tuanha@gmail.com','2004/12/11','CV02','K10'),
	('YT109',N'Trần Thị Ngọc Liễu',N'Nữ','092362543','lieutran@gmail.com','2000/03/28','CV02','K10'),

	('YT106',N'Trần Nguyễn Anh Tú',N'Nữ','000987134','tutran@gmail.com','2000/12/17','CV02','K09'),
	('YT107',N'Nguyễn Thị Như Ý',N'Nữ','092362543','ynguyen@gmail.com','2001/07/18','CV02','K09'),

	('YT104',N'Bùi Thanh Trúc',N'Nữ','217348907','trucbui@gmail.com','1890/12/23','CV02','K08'),
	('YT105',N'Nguyễn Thị Trúc Đào',N'Nữ','079273423','daonguyen@gmail.com','1996/01/01','CV02','K08'),

	('YT101',N'Đào Thanh Hải',N'Nam','124356547','haidao@gmail.com','1789/09/24','CV02','K07'),
	('YT102',N'Nguyễn Thị Tâm Anh',N'Nữ','45675687','tamanh@gmail.com','2000/03/29','CV02','K07'),
	('YT103',N'Hà Tú Ân',N'Nam','314356875','anha@gmail.com','2002/09/09','CV02','K07'),

	('YT99',N'Nguyễn Tấn Tài',N'Nam','','tantai@gmail.com','1889/09/03','CV02','K06'),
	('YT100',N'Trương Thanh Ngà',N'Nam','','ngatruong@gmail.com','2004/03/29','CV02','K06'),

	('YT97',N'Nguyễn Quang Dinh',N'Nam','','quangdinh@gmail.com','1990/02/04','CV02','K05'),
	('YT98',N'Huỳnh Vương Quốc Bảo',N'Nam','','baohuynh@gmail.com','2001/09/23','CV02','K05'),

	('YT95',N'Trần Bá Triệu',N'Nam','','batrieu@gmail.com','1987/08/08','CV02','K04'),
	('YT96',N'Nguyễn Thị An',N'Nữ','','anan@gmail.com','1998/07/13','CV02','K04'),

	('YT93',N'Nguyễn Thúc Thùy Tiên',N'Nữ','1122334455','tiennguyen@gmail.com','1998/05/08','CV02','K03'),
	('YT94',N'Trương Bá Thái',N'Nam','6677889900','truongthai','1989/12/01','CV02','K03'),

	('YT92',N'Trần Thị Ngọc Linh',N'Nữ','1234567890','linhtran@gmail.com','2004/01/24','CV02','K01')

insert into NhanVien([MaNV],[TenNV],[GioiTinh],[SDT],[Email],[NgayBatDauLam],[MaCV],[MaKhoa])
values 
---------------------------------K01
('YT148', N'Trần Hữu Lộc', 'Nam', '7261590172', 'tranhuuloc@gmail.com', '1992/05/14', 'CV02', 'K01'),
('YT149', N'Lê Phương Thảo', N'Nữ', '7261590173', 'lephuongthao@gmail.com', '1994/06/24', 'CV02', 'K01'),
('YT150', N'Phạm Minh Tuấn', 'Nam', '7261590174', 'phamminhtuan@gmail.com', '1996/07/08', 'CV02', 'K01'),
('YT151', N'Đỗ Thị Hà', N'Nữ', '7261590175', 'dothiha@gmail.com', '1998/08/18', 'CV02', 'K01'),
('YT152', N'Vũ Văn Nam', 'Nam', '7261590176', 'vuvannam@gmail.com', '2000/09/28', 'CV02', 'K01'),
-------------------------------K02
('YT153', N'Nguyễn Thị Lan', N'Nữ', '7261590177', 'nguyenthilan@gmail.com', '1991/03/15', 'CV02', 'K02'),
('YT154', N'Hoàng Minh Đức', 'Nam', '7261590178', 'hoangminhduc@gmail.com', '1993/04/25', 'CV02', 'K02'),
('YT155', N'Trần Bảo Khánh', 'Nam', '7261590179', 'tranbaokhanh@gmail.com', '1995/05/30', 'CV02', 'K02'),
('YT156', N'Lưu Bích Hồng', N'Nữ', '7261590180', 'luubichhong@gmail.com', '1997/07/10', 'CV02', 'K02'),
('YT157', N'Đào Tuấn Khoa', 'Nam', '7261590181', 'daotuankhoa@gmail.com', '1999/08/20', 'CV02', 'K02'),
-----------------------------------K03
('YT158', N'Phan Văn Huy', 'Nam', '7261590182', 'phanvanhuy@gmail.com', '1992/01/15', 'CV02', 'K03'),
('YT159', N'Dương Thị Mai', N'Nữ', '7261590183', 'duongthimai@gmail.com', '1994/02/28', 'CV02', 'K03'),
('YT160', N'Ngô Quốc Toản', 'Nam', '7261590184', 'ngoquoctoan@gmail.com', '1996/03/12', 'CV02', 'K03'),
('YT161', N'Trịnh Cẩm Ly', N'Nữ', '7261590185', 'trinhcamly@gmail.com', '1998/04/20', 'CV02', 'K03'),
('YT162', N'Võ Minh Triết', 'Nam', '7261590186', 'vominhtriet@gmail.com', '2000/05/30', 'CV02', 'K03'),
----------------------------------K04
('YT163', N'Lê Quang Hùng', 'Nam', '7261590187', 'lequanghung@gmail.com', '1992/07/01', 'CV02', 'K04'),
('YT164', N'Nguyễn Thị Bảo', N'Nữ', '7261590188', 'nguyenthobao@gmail.com', '1994/08/13', 'CV02', 'K04'),
('YT165', N'Bùi Thanh Sơn', 'Nam', '7261590189', 'buithanhson@gmail.com', '1996/09/25', 'CV02', 'K04'),
('YT166', N'Trần Hồng Nhung', N'Nữ', '7261590190', 'tranhongnhung@gmail.com', '1998/10/07', 'CV02', 'K04'),
('YT167', N'Phạm Đức Anh', 'Nam', '7261590191', 'phamducanh@gmail.com', '2000/11/19', 'CV02', 'K04'),
-------------------------------------K05
('YT168', N'Đào Minh Quân', 'Nam', '7261590192', 'daominhquan@gmail.com', '1991/12/14', 'CV02', 'K05'),
('YT169', N'Vũ Mai Lan', N'Nữ', '7261590193', 'vumailan@gmail.com', '1993/01/27', 'CV02', 'K05'),
('YT170', N'Ngô Thanh Vân', N'Nữ', '7261590194', 'ngothanhvan@gmail.com', '1995/03/10', 'CV02', 'K05'),
('YT171', N'Phan Hải Đăng', 'Nam', '7261590195', 'phanhaidang@gmail.com', '1997/04/22', 'CV02', 'K05'),
('YT172', N'Lương Đức Minh', 'Nam', '7261590196', 'luongducminh@gmail.com', '1999/06/04', 'CV02', 'K05'),
----------------------------------K06
('YT173', N'Phạm Thanh Tùng', 'Nam', '7261590221', 'phamthanhtung@gmail.com', '1991/06/15', 'CV02', 'K06'),
('YT174', N'Lê Thị Lan', N'Nữ', '7261590222', 'lethilan@gmail.com', '1994/07/25', 'CV02', 'K06'),
('YT175', N'Nguyễn Minh Châu', 'Nam', '7261590223', 'nguyenminhchau@gmail.com', '1997/08/05', 'CV02', 'K06'),
('YT176', N'Đỗ Văn Hoàng', 'Nam', '7261590224', 'dovanhoang@gmail.com', '2000/09/16', 'CV02', 'K06'),
('YT177', N'Trần Thị Nga', N'Nữ', '7261590225', 'tranthingga@gmail.com', '2003/10/27', 'CV02', 'K06'),
------------------------------------K07
('YT178', N'Hoàng Minh Đức', 'Nam', '7261590226', 'hoangminhduc@gmail.com', '1992/03/12', 'CV02', 'K07'),
('YT179', N'Bùi Thị Mai', N'Nữ', '7261590227', 'buithimai@gmail.com', '1995/04/22', 'CV02', 'K07'),
('YT180', N'Ngô Quốc Huy', 'Nam', '7261590228', 'ngoquochuy@gmail.com', '1998/05/02', 'CV02', 'K07'),
('YT181', N'Võ Hồng Phúc', 'Nam', '7261590229', 'vohongphuc@gmail.com', '2001/06/13', 'CV02', 'K07'),
('YT182', N'Trần Thị Hạnh', N'Nữ', '7261590230', 'tranthihanh@gmail.com', '2004/07/24', 'CV02', 'K07'),
-------------------------------------K08
('YT183', N'Lưu Thị Lan', N'Nữ', '7261590231', 'luuthilan@gmail.com', '1991/02/05', 'CV02', 'K08'),
('YT184', N'Phan Văn Kiệt', 'Nam', '7261590232', 'phanvankiet@gmail.com', '1993/03/15', 'CV02', 'K08'),
('YT185', N'Dương Văn Minh', 'Nam', '7261590233', 'duongvanminh@gmail.com', '1995/04/25', 'CV02', 'K08'),
('YT186', N'Trịnh Hồng Sơn', 'Nam', '7261590234', 'trinhhongson@gmail.com', '1997/05/06', 'CV02', 'K08'),
('YT187', N'Thái Thị Bảo', N'Nữ', '7261590235', 'thaithibao@gmail.com', '1999/06/17', 'CV02', 'K08'),
--------------------------------------K09
('YT188', N'Nguyễn Thị Mai', N'Nữ', '7261590236', 'nguyenthimai@gmail.com', '1990/07/07', 'CV02', 'K09'),
('YT189', N'Tran Van Quan', 'Nam', '7261590237', 'tranvanquan@gmail.com', '1992/08/17', 'CV02', 'K09'),
('YT190', N'Hoàng Bảo Trâm', N'Nữ', '7261590238', 'hoangbaotram@gmail.com', '1994/09/27', 'CV02', 'K09'),
('YT191', N'Lê Đức Thịnh', 'Nam', '7261590239', 'leducthinh@gmail.com', '1996/10/08', 'CV02', 'K09'),
('YT192', N'Vũ Minh Châu', N'Nữ', '7261590240', 'vuminhchau@gmail.com', '1998/11/18', 'CV02', 'K09'),
-----------------------------------------K10
('YT193', N'Đặng Thị Lan', N'Nữ', '7261590241', 'dangthilan@gmail.com', '1990/12/12', 'CV02', 'K10'),
('YT194', N'Phan Văn Hoàng', 'Nam', '7261590242', 'phanvanhoang@gmail.com', '1993/01/22', 'CV02', 'K10'),
('YT195', N'Bùi Minh Đức', 'Nam', '7261590243', 'buiminhduc@gmail.com', '1995/02/28', 'CV02', 'K10'),
('YT196', N'Hoàng Minh Tâm', N'Nữ', '7261590244', 'hoangminhtam@gmail.com', '1997/03/15', 'CV02', 'K10'),
('YT197', N'Trần Thị Thu', N'Nữ', '7261590245', 'tranthithu@gmail.com', '1999/04/05', 'CV02', 'K10'),
---------------------------------------------K11
('YT198', N'Nguyễn Văn Hùng', 'Nam', '7261590246', 'nguyenvanhung@gmail.com', '1991/05/10', 'CV02', 'K11'),
('YT199', N'Lưu Thị Mai', N'Nữ', '7261590247', 'luuthimai@gmail.com', '1992/06/20', 'CV02', 'K11'),
('YT200', N'Dương Quốc Toản', 'Nam', '7261590248', 'duongquoctoan@gmail.com', '1994/07/30', 'CV02', 'K11'),
('YT201', N'Phạm Bảo Trâm', N'Nữ', '7261590249', 'phambaotram@gmail.com', '1996/08/19', 'CV02', 'K11'),
('YT202', N'Vũ Thị Lan', N'Nữ', '7261590250', 'vuthilan@gmail.com', '1998/09/09', 'CV02', 'K11'),
-----------------------------------------------K12
('YT203', N'Trần Hữu Khang', 'Nam', '7261590251', 'tranhuukhang@gmail.com', '1990/10/05', 'CV02', 'K12'),
('YT204', N'Hoàng Mai Linh', N'Nữ', '7261590252', 'hoangmailinh@gmail.com', '1992/11/15', 'CV02', 'K12'),
('YT205', N'Lê Quang Huy', 'Nam', '7261590253', 'lequanghuy@gmail.com', '1994/12/25', 'CV02', 'K12'),
('YT206', N'Đỗ Thị Nga', N'Nữ', '7261590254', 'dothinga@gmail.com', '1996/01/04', 'CV02', 'K12'),
('YT207', N'Vũ Minh Tuệ', 'Nam', '7261590255', 'vuminhtue@gmail.com', '1998/02/14', 'CV02', 'K12'),
---------------------------------------------------K13
('YT208', N'Phạm Thanh Tùng', 'Nam', '7261590256', 'phamthanhtung@gmail.com', '1990/03/25', 'CV02', 'K13'),
('YT209', N'Nguyễn Thị Lan', N'Nữ', '7261590257', 'nguyenthilan@gmail.com', '1992/04/05', 'CV02', 'K13'),
('YT210', N'Hoàng Đình Nam', 'Nam', '7261590258', 'hoangdinhnam@gmail.com', '1994/05/16', 'CV02', 'K13'),
('YT211', N'Trần Minh Thu', N'Nữ', '7261590259', 'tranminhthu@gmail.com', '1996/06/26', 'CV02', 'K13'),
('YT212', N'Đặng Văn Hòa', 'Nam', '7261590260', 'dangvanhoa@gmail.com', '1998/07/07', 'CV02', 'K13'),
----------------------------------------------------K14
('YT213', N'Lê Quang Hải', 'Nam', '7261590261', 'lequanghai@gmail.com', '1990/08/15', 'CV02', 'K14'),
('YT214', N'Đào Phương Anh', N'Nữ', '7261590262', 'daophuonganh@gmail.com', '1992/09/03', 'CV02', 'K14'),
('YT215', N'Bùi Văn Kiên', 'Nam', '7261590263', 'buivankien@gmail.com', '1994/10/21', 'CV02', 'K14'),
('YT216', N'Nguyễn Hồng Hạnh', N'Nữ', '7261590264', 'nguyenhonghanh@gmail.com', '1996/11/09', 'CV02', 'K14'),
('YT217', N'Trần Thị Mai', N'Nữ', '7261590265', 'tranthimai@gmail.com', '1998/12/28', 'CV02', 'K14'),
------------------------------------------------------K15
('YT218', N'Phan Thế Anh', 'Nam', '7261590266', 'phantheanh@gmail.com', '1991/01/12', 'CV02', 'K15'),
('YT219', N'Dương Thị Lan', N'Nữ', '7261590267', 'duongthilan@gmail.com', '1993/02/23', 'CV02', 'K15'),
('YT220', N'Hoàng Minh Tú', 'Nam', '7261590268', 'hoangminhtu@gmail.com', '1995/03/15', 'CV02', 'K15'),
('YT221', N'Ngô Quỳnh Trang', N'Nữ', '7261590269', 'ngoquynhtrang@gmail.com', '1997/04/17', 'CV02', 'K15'),
('YT222', N'Vũ Thế Vinh', 'Nam', '7261590270', 'vuthevinh@gmail.com', '1999/05/29', 'CV02', 'K15'),
--------------------------------------------------------K16
('YT223', N'Nguyễn Minh Chiến', 'Nam', '7261590271', 'nguyenminhchien@gmail.com', '1990/06/01', 'CV02', 'K16'),
('YT224', N'Trần Khánh Ly', N'Nữ', '7261590272', 'trankhanhly@gmail.com', '1992/07/14', 'CV02', 'K16'),
('YT225', N'Lưu Hoàng Nam', 'Nam', '7261590273', 'luuhoangnam@gmail.com', '1994/08/26', 'CV02', 'K16'),
('YT226', N'Phạm Hồng Anh', N'Nữ', '7261590274', 'phamhonganh@gmail.com', '1996/09/09', 'CV02', 'K16'),
('YT227', N'Bùi Đức Huy', 'Nam', '7261590275', 'buiduchuy@gmail.com', '1998/10/21', 'CV02', 'K16'),
---------------------------------------------------------K17
('YT228', N'Vũ Đức Minh', 'Nam', '7261590276', 'vuducminh@gmail.com', '1991/01/05', 'CV02', 'K17'),
('YT229', N'Hồ Ngọc Mai', N'Nữ', '7261590277', 'hongocmai@gmail.com', '1993/02/17', 'CV02', 'K17'),
('YT230', N'Phan Thị Trà', N'Nữ', '7261590278', 'phanthitra@gmail.com', '1995/03/30', 'CV02', 'K17'),
('YT231', N'Nguyễn Tuấn Khoa', 'Nam', '7261590279', 'nguyentuankhoa@gmail.com', '1997/05/12', 'CV02', 'K17'),
('YT232', N'Lê Thị Bảo', N'Nữ', '7261590280', 'lethibao@gmail.com', '1999/06/24', 'CV02', 'K17'),
------------------------------------------------------------K18
('YT233', N'Nguyễn Văn Hùng', 'Nam', '7261590281', 'nguyenvanhung@gmail.com', '1990/07/15', 'CV02', 'K18'),
('YT234', N'Trần Thị Lan', N'Nữ', '7261590282', 'tranthilan@gmail.com', '1992/08/26', 'CV02', 'K18'),
('YT235', N'Lưu Đức Hoa', 'Nam', '7261590283', 'luuduchoa@gmail.com', '1994/09/07', 'CV02', 'K18'),
('YT236', N'Phạm Thanh Tâm', N'Nữ', '7261590284', 'phamthanhtam@gmail.com', '1996/10/18', 'CV02', 'K18'),
('YT237', N'Vũ Minh Tuấn', 'Nam', '7261590285', 'vuminhtuan@gmail.com', '1998/11/29', 'CV02', 'K18'),
--------------------------------------------------------------K19
('YT238', N'Hoàng Minh Đức', 'Nam', '7261590286', 'hoangminhduc@gmail.com', '1990/12/01', 'CV02', 'K19'),
('YT239', N'Doãn Thu Hà', N'Nữ', '7261590287', 'doanthuha@gmail.com', '1995/01/15', 'CV02', 'K19'),
('YT240', N'Ngô Thanh Vân', N'Nữ', '7261590288', 'ngothanhvan@gmail.com', '2000/02/25', 'CV02', 'K19'),
('YT241', N'Lê Quốc Toàn', 'Nam', '7261590289', 'lequoctoan@gmail.com', '2003/03/30', 'CV02', 'K19'),
('YT242', N'Nguyễn Thị Mai', N'Nữ', '7261590290', 'nguyenthimai@gmail.com', '2021/04/10', 'CV02', 'K19'),
--------------------------------------------------------------K20
('YT243', N'Trần Khải Hoàn', 'Nam', '7261590291', 'trankhaihoan@gmail.com', '1990/05/20', 'CV02', 'K20'),
('YT244', N'Phạm Huyền Trang', N'Nữ', '7261590292', 'phamhuyentrang@gmail.com', '1994/06/15', 'CV02', 'K20'),
('YT245', N'Bùi Đức Long', 'Nam', '7261590293', 'buiduclong@gmail.com', '1998/07/05', 'CV02', 'K20'),
('YT246', N'Nguyễn Thanh Thảo', N'Nữ', '7261590294', 'nguyenthanhthao@gmail.com', '2002/08/22', 'CV02', 'K20'),
('YT247', N'Lê Văn Kiệt', 'Nam', '7261590295', 'levankiet@gmail.com', '2023/09/10', 'CV02', 'K20'),
----------------------------------------------------------------K21
('YT248', N'Doãn Minh Quân', 'Nam', '7261590296', 'doanminhquan@gmail.com', '1990/03/12', 'CV02', 'K21'),
('YT249', N'Ngô Ái Linh', N'Nữ', '7261590297', 'ngoailinh@gmail.com', '1995/04/08', 'CV02', 'K21'),
('YT250', N'Vũ Hoàng Nam', 'Nam', '7261590298', 'vuhoangnam@gmail.com', '2000/11/25', 'CV02', 'K21'),
('YT251', N'Trần Phương Anh', N'Nữ', '7261590299', 'tranphuonganh@gmail.com', '2005/01/15', 'CV02', 'K21'),
('YT252', N'Phan Thị Bảo', N'Nữ', '7261590300', 'phanthibao@gmail.com', '2024/12/31', 'CV02', 'K21'),
------------------------------------------------------------------K22
('YT253', N'Nguyễn Thị Mai', N'Nữ', '7281590301', 'nguyenthimai@gmail.com', '1992/07/22', 'CV02', 'K22'),
('YT254', N'Lê Quốc Toản', 'Nam', '7281590302', 'lequoctoan@gmail.com', '1994/05/16', 'CV02', 'K22'),
('YT255', N'Hồ Văn Hùng', 'Nam', '7281590303', 'hovanhung@gmail.com', '2003/08/03', 'CV02', 'K22'),
('YT256', N'Bùi Thu Hà', N'Nữ', '7281590304', 'buithuha@gmail.com', '2010/01/28', 'CV02', 'K22'),
('YT257', N'Phạm Đức Minh', 'Nam', '7281590305', 'phamducminh@gmail.com', '2023/09/15', 'CV02', 'K22'),
-----------------------------------------------------------------K23
('YT258', N'Trần Thị Lan', N'Nữ', '7281590306', 'tranthilan@gmail.com', '1990/11/25', 'CV02', 'K23'),
('YT259', N'Phan Anh Tuấn', 'Nam', '7281590307', 'phananhtuan@gmail.com', '1996/02/17', 'CV02', 'K23'),
('YT260', N'Doãn Minh Đức', 'Nam', '7281590308', 'doanminhduc@gmail.com', '2000/06/08', 'CV02', 'K23'),
('YT261', N'Võ Bảo Trâm', N'Nữ', '7281590309', 'vobaotram@gmail.com', '2009/09/24', 'CV02', 'K23'),
('YT262', N'Lê Thảo Vy', N'Nữ', '7281590310', 'lethaovy@gmail.com', '2021/12/30', 'CV02', 'K23'),
---------------------------------------------------------------------K24
('YT263', N'Nguyễn Thanh Hà', N'Nữ', '7281590311', 'nguyenthanhha@gmail.com', '1990/03/15', 'CV02', 'K24'),
('YT264', N'Bùi Quốc Trung', 'Nam', '7281590312', 'buiquoctrung@gmail.com', '1994/07/19', 'CV02', 'K24'),
('YT265', N'Phạm Thị Mai', N'Nữ', '7281590313', 'phamthimai@gmail.com', '1998/08/25', 'CV02', 'K24'),
('YT266', N'Lương Đức Thắng', 'Nam', '7281590314', 'luongducthang@gmail.com', '2003/11/02', 'CV02', 'K24'),
('YT267', N'Vũ Minh Châu', N'Nữ', '7281590315', 'vuminhchau@gmail.com', '2022/06/30', 'CV02', 'K24'),
------------------------------------------------------------------------K25
('YT268', N'Trần Đình Nam', 'Nam', '7281590316', 'trandinhnam@gmail.com', '1992/04/20', 'CV02', 'K25'),
('YT269', N'Lê Phương Thảo', N'Nữ', '7281590317', 'lephuongthao@gmail.com', '1996/12/15', 'CV02', 'K25'),
('YT270', N'Đoàn Thị Hạnh', N'Nữ', '7281590318', 'doanthihanhh@gmail.com', '2001/09/07', 'CV02', 'K25'),
('YT271', N'Ngô Bảo Khánh', 'Nam', '7281590319', 'ngobaokhanh@gmail.com', '2005/05/22', 'CV02', 'K25'),
('YT272', N'Hoàng Minh Tuấn', 'Nam', '7281590320', 'hoangminhtuan@gmail.com', '2019/03/11', 'CV02', 'K25'),
------------------------------------------------------------------------K26
('YT273', N'Vũ Thị Lan', N'Nữ', '7281590321', 'vuthilan@gmail.com', '1990/01/05', 'CV02', 'K26'),
('YT274', N'Bùi Minh Đức', 'Nam', '7281590322', 'buiminhduc@gmail.com', '1994/08/24', 'CV02', 'K26'),
('YT275', N'Tran Minh Hoa', N'Nữ', '7281590323', 'tranminhhoa@gmail.com', '1998/11/19', 'CV02', 'K26'),
('YT276', N'Nguyễn Văn Bảo', 'Nam', '7281590324', 'nguyenvanbao@gmail.com', '2003/06/30', 'CV02', 'K26'),
('YT277', N'Phạm Huyền Trang', N'Nữ', '7281590325', 'phamhuyentrang@gmail.com', '2022/09/14', 'CV02', 'K26'),
-----------------------------------------------------K27
('YT278', N'Ngô Thị Thu', N'Nữ', '7281590326', 'ngothithu@gmail.com', '1992/03/10', 'CV02', 'K27'),
('YT279', N'Lê Quang Hùng', 'Nam', '7281590327', 'lequanghung@gmail.com', '1996/07/21', 'CV02', 'K27'),
('YT280', N'Dương Thị Mai', N'Nữ', '7281590328', 'duongthimai@gmail.com', '2000/05/16', 'CV02', 'K27'),
('YT281', N'Trần Văn Khoa', 'Nam', '7281590329', 'tranvankhoa@gmail.com', '2005/12/03', 'CV02', 'K27'),
('YT282', N'Hoàng Minh Tú', N'Nữ', '7281590330', 'hoangminhtu@gmail.com', '2023/01/25', 'CV02', 'K27'),
------------------------------------------------------K28
('YT283', N'Phạm Văn Nam', 'Nam', '7281590331', 'phamvana@gmail.com', '1991/04/12', 'CV02', 'K28'),
('YT284', N'Trần Thị Lam', N'Nữ', '7281590332', 'tranthib@gmail.com', '1994/06/23', 'CV02', 'K28'),
('YT285', N'Nguyễn Văn Hùng', 'Nam', '7281590333', 'nguyenvanc@gmail.com', '1999/08/15', 'CV02', 'K28'),
('YT286', N'Doãn Thị DNữ', N'Nữ', '7281590334', 'doanthid@gmail.com', '2003/10/28', 'CV02', 'K28'),
('YT287', N'Lê Văn Tùng', 'Nam', '7281590335', 'levane@gmail.com', '2021/12/09', 'CV02', 'K28'),
-----------------------------------------------------------K29
('YT288', N'Đặng Hồng', N'Nữ', '7281590336', 'danghongf@gmail.com', '1990/01/20', 'CV02', 'K29'),
('YT289', N'Võ Văn Tú', 'Nam', '7281590337', 'vovang@gmail.com', '1993/03/22', 'CV02', 'K29'),
('YT290', N'Bùi Thị Hằng', N'Nữ', '7281590338', 'buithih@gmail.com', '1996/07/30', 'CV02', 'K29'),
('YT291', N'Hoàng Minh Hạo', 'Nam', '7281590339', 'hoangminhi@gmail.com', '2000/09/16', 'CV02', 'K29'),
('YT292', N'Ngô Quốc Hào', 'Nam', '7281590340', 'ngoquocj@gmail.com', '2022/11/11', 'CV02', 'K29')

insert into NhanVien([MaNV],[TenNV],[GioiTinh],[SDT],[Email],[NgayBatDauLam],[MaCV],[MaKhoa])
values
	 ('TK01',N'Hoàng Thọ',N'Nam','0972615276','hoangtho@gmail.com','1999/12/01','CV03','K01')
	,('TK02',N'Nguyễn Anh Tú',N'Nam','0962514123','nguyenanhtu@gmail.com','1954/08/03','CV03','K02')
	,('TK03',N'Phạm Mạnh Chung',N'Nam','0251627182','phammanhchung@gmail.com','1992/01/01','CV03','K03')
	,('TK04',N'Hà Minh Hiền',N'Nam','0271625198','haminhhien@gmail.com','1999/12/01','CV03','K04')
	,('TK05',N'Bùi Văn Trương',N'Nam','0827538712','buivantruong@gmail.com','1999/12/01','CV03','K05')
	,('TK06',N'Trần Thị Tuyết Trinh',N'Nữ','0243567890','tttuyettrinh@gmail.com','1998/03/04','CV03','K06')
	,('TK07',N'Thân Thị Trang Uyên',N'Nữ','0972615736','tranguyen@gmail.com','2005/09/12','CV03','K07')
	,('TK08',N'Nguyễn Hồng Thanh',N'Nam','0987544097','nguyenhongthanh@gmail.com','1999/12/01','CV03','K08')
	,('TK09',N'Đàm Thị Minh Phương',N'Nữ','0152768765','damtminhphuong@gmail.com','1999/12/01','CV03','K09')
	,('TK10',N'Lê Hồng Chiến',N'Nam','6578162518','lehongchien@gmail.com','2006/01/01','CV03','K10')
	,('TK11',N'Nguyễn Quỳnh Giang',N'Nữ','0867658753','quynhgiang@gmail.com','1999/06/12','CV03','K11')
	,('TK12',N'Vũ Thị Hậu',N'Nam','0129736998','vuthihau@gmail.com','2012/09/01','CV03','K12')
	,('TK13',N'Võ Thị Thùy Trang',N'Nữ','0762538762','thuytrang@gmail.com','1999/12/01','CV03','K13')
	,('TK14',N'Lê Thị Thanh Hương',N'Nữ','0987645634','lethithanhhuong@gmail.com','1989/03/24','CV03','K14')
	,('TK15',N'Mai Viễn Phương',N'Nam','6578875432','maivienphuong@gmail.com','2017/07/11','CV03','K15')
	,('TK16',N'Nguyễn Thị Ngọc',N'Nữ','0865435687','nguyenthingoc@gmail.com','2003/06/18','CV03','K16')
	,('TK17',N'Đặng Vũ Anh',N'Nam','0866543456','dangvuanh@gmail.com','2006/06/18','CV03','K17')
	,('TK18',N'Võ Công Hiền',N'Nam','0654789043','voconghien@gmail.com','2003/06/18','CV03','K18')
	,('TK19',N'Nguyễn Văn Huy',N'Nam','0654789876','nguyenvanhuy@gmail.com','1996/07/20','CV03','K19')
	,('TK20',N'Nguyễn Thu Hương',N'Nữ','0865765421','nguyenthuhuong@gmail.com','2019/09/19','CV03','K20')
	,('TK21',N'Ma Văn Thấm',N'Nam','0888098765','mavantham@gmail.com','2005/03/16','CV03','K21')
	,('TK22',N'Nguyễn Hoàng Oanh',N'Nữ','0876257890','nguyenhoangoanh@gmail.com','1999/12/11','CV03','K22')
	,('TK23',N'Nguyễn Quốc Việt',N'Nam','0435678976','nguyenquocviet@gmail.com','2002/06/18','CV03','K23')
	,('TK24',N'Nguyễn trung Kien',N'Nam','0234065437','nguyentrungkien@gmail.com','2009/01/12','CV03','K24')
	,('TK25',N'Nguyễn Minh Sơn',N'Nam','8765654321','nguyenminhson@gmail.com','1976/11/11','CV03','K25')
	,('TK26',N'Huỳnh An Thiên',N'Nữ','0145764389','huynhanthien@gmail.com','2010/07/29','CV03','K26')
	,('TK27',N'Phạm Văn Hùng',N'Nam','0546786543','phamvanhung@gmail.com','2011/01/10','CV03','K27')
	,('TK28',N'Trịnh Ngọc An',N'Nam','0456732865','trinhngocan@gmail.com','2003/06/18','CV03','K28')
	,('TK29',N'Phan Ngọc Hải',N'Nam','0865435685','phanngochai@gmail.com','2003/06/18','CV03','K29')

insert into PhongKham([MSPhong],[TenPhong],[DiaDiem],[MaKhoa],[SoGiuong],Loai)
values
	   ('P01',N'Phòng khám sơ bộ của cấp cứu khẩn cấp 01',N'Lầu 1','K01',0,N'Phòng khám')
	  ,('P02',N'Phòng khám sơ bộ của cấp cứu khẩn cấp 01',N'Lầu 1','K01',0,N'Phòng khám')
	  ,('P05',N'Phòng khám nhi tim mạch 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P06',N'Phòng khám nhi tim mạch 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P07',N'Phòng khám nhi hô hấp 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P08',N'Phòng khám nhi hô hấp 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P09',N'Phòng khám nhi tiêu hóa 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P10',N'Phòng khám nhi tiêu hóa 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P11',N'Phòng khám nhi tổng quát 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P12',N'Phòng khám nhi tổng quát 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P13',N'Phòng khám nhãn khoa 01',N'Lầu 2','K03',0,N'Phòng khám')
	  ,('P14',N'Phòng khám nhãn khoa 02',N'Lầu 2','K03',0,N'Phòng khám')
	  ,('P15',N'Phòng khám tăng nhãn áp 01',N'Lầu 2','K03',0,N'Phòng khám')
	  ,('P16',N'Phòng khám tiêu hóa học 01',N'Lầu 2','K04',0,N'Phòng khám')
	  ,('P17',N'Phòng khám tiêu hóa học 02',N'Lầu 2','K04',0,N'Phòng khám')
	  ,('P18',N'Phòng khám gan học 01',N'Lầu 2','K04',0,N'Phòng khám')
	  ,('P19',N'Phòng khám gan học 02',N'Lầu 2','K04',0,N'Phòng khám')

	  ,('P22',N'Phòng khám tiểu đường 01',N'Lầu 2','K05',0,N'Phòng khám')
	  ,('P23',N'Phòng khám tiểu đường 02',N'Lầu 2','K05',0,N'Phòng khám')
	  ,('P24',N'Phòng khám rối loạn chức năng sinh dục 01',N'Lầu 2','K05',0,N'Phòng khám')
	  ,('P25',N'Phòng khám rối loạn chức năng sinh dục 02',N'Lầu 3','K05',0,N'Phòng khám')
	  ,('P26',N'Phòng khám rối loạn tuyến giáp 01',N'Lầu 3','K05',0,N'Phòng khám')
	  ,('P27',N'Phòng khám rối loạn tuyến giáp 02',N'Lầu 3','K05',0,N'Phòng khám')
	  ,('P28',N'Phòng khám nha khoa tổng quát 01',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P29',N'Phòng khám nha khoa tổng quát 02',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P30',N'Phòng khám bệnh lý miệng 01',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P31',N'Phòng khám bệnh lý miệng 02',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P32',N'Phòng khám da liễu chung 01',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P33',N'Phòng khám da liễu chung 02',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P34',N'Phòng khám bệnh truyền nhiễm da liễu 01',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P35',N'Phòng khám bệnh truyền nhiễm da liễu 02',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P36',N'Phòng khám da liễu dị ứng 01',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P37',N'Phòng khám da liễu dị ứng 02',N'Lầu 4','K07',0,N'Phòng khám')
	  ,('P38',N'Phòng khám bệnh lý tim mạch tổng quát 01',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P39',N'Phòng khám bệnh lý tim mạch tổng quát 02',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P40',N'Phòng can thiệp tim mạch 01',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P41',N'Phòng can thiệp tim mạch 02',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P42',N'Phòng điện tâm đồ 01',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P43',N'Phòng điện tâm đồ 02',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P44',N'Phòng khám bệnh xương khớp 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P45',N'Phòng khám bệnh xương khớp 02',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P46',N'Phòng phục hồi chức năng cơ-xương-khớp 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P47',N'Phòng phục hồi chức năng cơ-xương-khớp 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P48',N'Phòng chấn thương chỉnh hình 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P49',N'Phòng chấn thương chỉnh hình 02',N'Lầu 5','K09',0,N'Phòng khám')
	  ,('P50',N'Phòng khám ung thư phổi 01',N'Lầu 5','K10',0,N'Phòng khám')
	  ,('P51',N'Phòng khám ung thư phổi 02',N'Lầu 5','K10',0,N'Phòng khám')
	  ,('P56',N'Phòng khám hen suyễn 01',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P57',N'Phòng khám hen suyễn 02',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P58',N'Phòng khám bệnh lao và các bệnh nhiễm phổi khác 01',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P59',N'Phòng khám bệnh lao và các bệnh nhiễm phổi khác 02',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P62',N'Phòng quản lý đau mãn tính 01',N'Lầu 6','K12',0,N'Phòng khám')
	  ,('P63',N'Phòng quản lý đau mãn tính 02',N'Lầu 6','K12',0,N'Phòng khám')
	  ,('P64',N'Phòng khám dinh dưỡng lâm sàng 01',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P65',N'Phòng khám dinh dưỡng lâm sàng 02',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P66',N'Phòng khám cho bệnh nhân suy dinh dưỡng và cần chăm sóc đặc biệt 01',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P67',N'Phòng khám cho bệnh nhân suy dinh dưỡng và cần chăm sóc đặc biệt 02',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P68',N'Phòng khám nội tổng hợp 01',N'Lầu 6','K14',0,N'Phòng khám')
	  ,('P69',N'Phòng khám nội tổng hợp 02',N'Lầu 6','K14',0,N'Phòng khám')
	  ,('P70',N'Phòng chấn thương chỉnh hình tổng quát 01',N'Lầu 6','K15',0,N'Phòng khám')
	  ,('P71',N'Phòng chấn thương chỉnh hình tổng quát 02',N'Lầu 6','K15',0,N'Phòng khám')
	  ,('P72',N'Phòng khám trước và sau phẫu thuật chấn thương 01',N'Lầu 6','K15',0,N'Phòng khám')
	  ,('P73',N'Phòng khám trước và sau phẫu thuật chấn thương 02',N'Lầu 7','K15',0,N'Phòng khám')
	  ,('P74',N'Phòng chuẩn bị gây mê 01',N'Lầu 7','K16',0,N'Phòng khám')
	  ,('P75',N'Phòng chuẩn bị gây mê 02',N'Lầu 7','K16',0,N'Phòng khám')
	  ,('P78',N'Phòng khám phụ khoa 01',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P79',N'Phòng khám phụ khoa 02',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P80',N'Phòng khám sản khoa 01',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P81',N'Phòng khám sản khoa 02',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P82',N'Phòng khám trước và sau phẫu thuật tim mạch 01',N'Lầu 7','K19',0,N'Phòng khám')
	  ,('P83',N'Phòng khám trước và sau phẫu thuật tim mạch 02',N'Lầu 7','K19',0,N'Phòng khám')
	  ,('P84',N'Phòng khám trước và sau phẫu thuật tiêu hóa 01',N'Lầu 7','K19',0,N'Phòng khám')
	  ,('P85',N'Phòng khám trước và sau phẫu thuật tiêu hóa 02',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P86',N'Phòng khám trước và sau phẫu thuật tổng quát 01',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P87',N'Phòng khám trước và sau phẫu thuật tổng quát 02',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P88',N'Phòng khám trước và sau phẫu thuật ung bướu 01',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P89',N'Phòng khám trước và sau phẫu thuạt ung bướu 02',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P90',N'Phòng khám Radiology 01',N'Lầu 8','K20',0,N'Phòng khám')
	  ,('P91',N'Phòng khám Radiology 02',N'Lầu 8','K20',0,N'Phòng khám')
	  ,('P92',N'Phòng khám Rhinology 01',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P93',N'Phòng khám Rhinology 02',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P94',N'Phòng khám Otology 01',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P95',N'Phòng khám Otology 02',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P96',N'Phòng khám Tai-Mũi-Họng 01',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P97',N'Phòng khám Tai-Mũi-Họng 02',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P98',N'Phòng khám lao 01',N'Lầu 8','K22',0,N'Phòng khám')
	  ,('P99',N'Phòng khám lao 02',N'Lầu 8','K22',0,N'Phòng khám')
	  ,('P100',N'Phòng khám bệnh lao 01',N'Lầu 8','K22',0,N'Phòng khám')
	  ,('P101',N'Phòng khám bệnh lao 02',N'Lầu 9','K22',0,N'Phòng khám')
	  ,('P102',N'Phòng khám bệnh hen suyễn 01',N'Lầu 9','K22',0,N'Phòng khám')
	  ,('P103',N'Phòng khám bệnh hen suyễn 02',N'Lầu 9','K22',0,N'Phòng khám')
	  ,('P104',N'Phòng khám tâm thần học tổng quát 01',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P105',N'Phòng khám tâm thần học tổng quát 02',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P106',N'Phòng khám tâm thần học thần kinh 01',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P107',N'Phòng khám tâm thần học thần kinh 02',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P108',N'Phòng khám Nephrology tổng quát 01',N'Lầu 9','K24',0,N'Phòng khám')
	  ,('P109',N'Phòng khám Nephrology tổng quát 02',N'Lầu 9','K24',0,N'Phòng khám')
	  ,('P110',N'Phòng khám trước và sau phẫu thuật thần kinh 01',N'Lầu 9','K25',0,N'Phòng khám')
	  ,('P111',N'Phòng khám trước và sau phẫu thuật thần kinh 02',N'Lầu 9','K25',0,N'Phòng khám')
	  ,('P112',N'Phòng khám trước và sau phẫu thuật cơ-xương-khớp 01',N'Lầu 9','K25',0,N'Phòng khám')
	  ,('P113',N'Phòng khám trước và sau phẫu thuật cơ-xương-khớp 02',N'Lầu 10','K25',0,N'Phòng khám')
	  ,('P114',N'Phòng khám trước và sau phẫu thuật tiết niệu 01',N'Lầu 10','K25',0,N'Phòng khám')
	  ,('P115',N'Phòng khám trước và sau phẫu thuật tiết niệu 02',N'Lầu 10','K25',0,N'Phòng khám')
	  ,('P116',N'Phòng khám trước và sau phẫu thuật não 01',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P117',N'Phòng khám trước và sau phẫu thuật não 02',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P118',N'Phòng khám trước và sau phẫu thuật tủy sống 01',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P119',N'Phòng khám trước và sau phẫu thuật tủy sống 02',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P120',N'Phòng khám bệnh parkinson và các loại rối loạn vận động 01',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P121',N'Phòng khám bệnh parkinson và các loại rối loạn vận động 02',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P122',N'Phòng khám tai biến mạch máu não 01',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P123',N'Phòng khám tai biến mạch máu não 02',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P124',N'Phòng khám giấc ngủ 01',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P125',N'Phòng khám giấc ngủ 02',N'Lầu 11','K27',0,N'Phòng khám')
	  ,('P128',N'Phòng khám bệnh truyền nhiễm nhiệt đới 01',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P129',N'Phòng khám bệnh truyền nhiễm nhiệt đới 02',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P130',N'Phòng khám bệnh truyền nhiễm trong cộng đồng 01',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P131',N'Phòng khám bệnh truyền nhiễm trong cộng đồng 02',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P132',N'Phòng khám tăng nhãn áp 02',N'Lầu 11','K03',0,N'Phòng khám')
	  ,('P133',N'Phòng khám nội tiết 01',N'Lầu 11','K05',0,N'Phòng khám')
	  ,('P134',N'Phòng khám nội tiết 02',N'Lầu 11','K05',0,N'Phòng khám')


------------------------------Phòng khám khi đăng ký khám dịch vụ----------------------------------------
insert into PhongKham([MSPhong],[TenPhong],[DiaDiem],[MaKhoa],[SoGiuong],Loai)
values
	   ('P135',N'Phòng khám sơ bộ của cấp cứu khẩn cấp 01',N'Lầu 1','K01',0,N'Phòng khám')
	  ,('P136',N'Phòng khám sơ bộ của cấp cứu khẩn cấp 01',N'Lầu 1','K01',0,N'Phòng khám')
	  ,('P139',N'Phòng khám nhi tim mạch 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P140',N'Phòng khám nhi tim mạch 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P141',N'Phòng khám nhi hô hấp 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P142',N'Phòng khám nhi hô hấp 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P143',N'Phòng khám nhi tiêu hóa 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P144',N'Phòng khám nhi tiêu hóa 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P145',N'Phòng khám nhi tổng quát 01',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P146',N'Phòng khám nhi tổng quát 02',N'Lầu 1','K02',0,N'Phòng khám')
	  ,('P147',N'Phòng khám nhãn khoa 01',N'Lầu 2','K03',0,N'Phòng khám')
	  ,('P148',N'Phòng khám nhãn khoa 02',N'Lầu 2','K03',0,N'Phòng khám')
	  ,('P149',N'Phòng khám tăng nhãn áp 01',N'Lầu 2','K03',0,N'Phòng khám')
	  
	  ,('P150',N'Phòng khám tiêu hóa học 01',N'Lầu 2','K04',0,N'Phòng khám')
	  ,('P151',N'Phòng khám tiêu hóa học 02',N'Lầu 2','K04',0,N'Phòng khám')
	  ,('P152',N'Phòng khám gan học 01',N'Lầu 2','K04',0,N'Phòng khám')
	  ,('P153',N'Phòng khám gan học 02',N'Lầu 2','K04',0,N'Phòng khám')

	  ,('P154',N'Phòng khám tiểu đường 01',N'Lầu 2','K05',0,N'Phòng khám')
	  ,('P155',N'Phòng khám tiểu đường 02',N'Lầu 2','K05',0,N'Phòng khám')
	  ,('P156',N'Phòng khám rối loạn chức năng sinh dục 01',N'Lầu 2','K05',0,N'Phòng khám')
	  ,('P157',N'Phòng khám rối loạn chức năng sinh dục 02',N'Lầu 3','K05',0,N'Phòng khám')
	  ,('P158',N'Phòng khám rối loạn tuyến giáp 01',N'Lầu 3','K05',0,N'Phòng khám')
	  ,('P159',N'Phòng khám rối loạn tuyến giáp 02',N'Lầu 3','K05',0,N'Phòng khám')
	  ,('P160',N'Phòng khám nha khoa tổng quát 01',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P161',N'Phòng khám nha khoa tổng quát 02',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P162',N'Phòng khám bệnh lý miệng 01',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P163',N'Phòng khám bệnh lý miệng 02',N'Lầu 3','K06',0,N'Phòng khám')
	  ,('P164',N'Phòng khám da liễu chung 01',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P165',N'Phòng khám da liễu chung 02',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P166',N'Phòng khám bệnh truyền nhiễm da liễu 01',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P167',N'Phòng khám bệnh truyền nhiễm da liễu 02',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P168',N'Phòng khám da liễu dị ứng 01',N'Lầu 3','K07',0,N'Phòng khám')
	  ,('P169',N'Phòng khám da liễu dị ứng 02',N'Lầu 4','K07',0,N'Phòng khám')
	  ,('P170',N'Phòng khám bệnh lý tim mạch tổng quát 01',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P171',N'Phòng khám bệnh lý tim mạch tổng quát 02',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P172',N'Phòng can thiệp tim mạch 01',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P173',N'Phòng can thiệp tim mạch 02',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P174',N'Phòng điện tâm đồ 01',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P175',N'Phòng điện tâm đồ 02',N'Lầu 4','K08',0,N'Phòng khám')
	  ,('P176',N'Phòng khám bệnh xương khớp 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P177',N'Phòng khám bệnh xương khớp 02',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P178',N'Phòng phục hồi chức năng cơ-xương-khớp 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P179',N'Phòng phục hồi chức năng cơ-xương-khớp 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P180',N'Phòng chấn thương chỉnh hình 01',N'Lầu 4','K09',0,N'Phòng khám')
	  ,('P181',N'Phòng chấn thương chỉnh hình 02',N'Lầu 5','K09',0,N'Phòng khám')
	  ,('P182',N'Phòng khám ung thư phổi 01',N'Lầu 5','K10',0,N'Phòng khám')
	  ,('P183',N'Phòng khám ung thư phổi 02',N'Lầu 5','K10',0,N'Phòng khám')
	  ,('P184',N'Phòng khám hen suyễn 01',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P185',N'Phòng khám hen suyễn 02',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P186',N'Phòng khám bệnh lao và các bệnh nhiễm phổi khác 01',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P187',N'Phòng khám bệnh lao và các bệnh nhiễm phổi khác 02',N'Lầu 5','K11',0,N'Phòng khám')
	  ,('P188',N'Phòng phục hồi chức năng cho chấn thương cột sống và não 01',N'Lầu 5','K12',0,N'Phòng khám')
	  ,('P189',N'Phòng phục hồi chức năng cho chấn thương cột sống và não 02',N'Lầu 6','K12',0,N'Phòng khám')
	  ,('P190',N'Phòng quản lý đau mãn tính 01',N'Lầu 6','K12',0,N'Phòng khám')
	  ,('P191',N'Phòng quản lý đau mãn tính 02',N'Lầu 6','K12',0,N'Phòng khám')
	  ,('P192',N'Phòng khám dinh dưỡng lâm sàng 01',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P193',N'Phòng khám dinh dưỡng lâm sàng 02',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P194',N'Phòng khám cho bệnh nhân suy dinh dưỡng và cần chăm sóc đặc biệt 01',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P195',N'Phòng khám cho bệnh nhân suy dinh dưỡng và cần chăm sóc đặc biệt 02',N'Lầu 6','K13',0,N'Phòng khám')
	  ,('P196',N'Phòng khám nội tổng hợp 01',N'Lầu 6','K14',0,N'Phòng khám')
	  ,('P197',N'Phòng khám nội tổng hợp 02',N'Lầu 6','K14',0,N'Phòng khám')
	  ,('P198',N'Phòng khám chấn thương chỉnh hình tổng quát 01',N'Lầu 6','K15',0,N'Phòng khám')
	  ,('P199',N'Phòng khám chấn thương chỉnh hình tổng quát 02',N'Lầu 6','K15',0,N'Phòng khám')
	  ,('P200',N'Phòng khám trước và sau phẫu thuật chấn thương 01',N'Lầu 6','K15',0,N'Phòng khám')
	  ,('P201',N'Phòng khám trước và sau phẫu thuật chấn thương 02',N'Lầu 7','K15',0,N'Phòng khám')
	  ,('P202',N'Phòng chuẩn bị gây mê 01',N'Lầu 7','K16',0,N'Phòng khám')
	  ,('P203',N'Phòng chuẩn bị gây mê 02',N'Lầu 7','K16',0,N'Phòng khám')
	  ,('P206',N'Phòng khám phụ khoa 01',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P207',N'Phòng khám phụ khoa 02',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P208',N'Phòng khám sản khoa 01',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P209',N'Phòng khám sản khoa 02',N'Lầu 7','K18',0,N'Phòng khám')
	  ,('P210',N'Phòng khám trước và sau phẫu thuật tim mạch 01',N'Lầu 7','K19',0,N'Phòng khám')
	  ,('P211',N'Phòng khám trước và sau phẫu thuật tim mạch 02',N'Lầu 7','K19',0,N'Phòng khám')
	  ,('P212',N'Phòng khám trước và sau phẫu thuật tiêu hóa 01',N'Lầu 7','K19',0,N'Phòng khám')
	  ,('P213',N'Phòng khám trước và sau phẫu thuật tiêu hóa 02',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P214',N'Phòng khám trước và sau phẫu thuật tổng quát 01',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P215',N'Phòng khám trước và sau phẫu thuật tổng quát 02',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P216',N'Phòng khám trước và sau phẫu thuật ung bướu 01',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P217',N'Phòng khám trước và sau phẫu thuạt ung bướu 02',N'Lầu 8','K19',0,N'Phòng khám')
	  ,('P218',N'Phòng khám Radiology 01',N'Lầu 8','K20',0,N'Phòng khám')
	  ,('P219',N'Phòng khám Radiology 02',N'Lầu 8','K20',0,N'Phòng khám')
	  ,('P220',N'Phòng khám Rhinology 01',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P221',N'Phòng khám Rhinology 02',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P222',N'Phòng khám Otology 01',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P223',N'Phòng khám Otology 02',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P224',N'Phòng khám Tai-Mũi-Họng 01',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P225',N'Phòng khám Tai-Mũi-Họng 02',N'Lầu 8','K21',0,N'Phòng khám')
	  ,('P226',N'Phòng khám lao 01',N'Lầu 8','K22',0,N'Phòng khám')
	  ,('P227',N'Phòng khám lao 02',N'Lầu 8','K22',0,N'Phòng khám')
	  ,('P228',N'Phòng khám bệnh ung thư phổi 01',N'Lầu 8','K22',0,N'Phòng khám')
	  ,('P229',N'Phòng khám bệnh ung thư phổi 02',N'Lầu 9','K22',0,N'Phòng khám')
	  ,('P230',N'Phòng khám bệnh hen suyễn 01',N'Lầu 9','K22',0,N'Phòng khám')
	  ,('P231',N'Phòng khám bệnh hen suyễn 02',N'Lầu 9','K22',0,N'Phòng khám')
	  ,('P232',N'Phòng khám tâm thần học tổng quát 01',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P233',N'Phòng khám tâm thần học tổng quát 02',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P234',N'Phòng khám tâm thần học thần kinh 01',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P235',N'Phòng khám tâm thần học thần kinh 02',N'Lầu 9','K23',0,N'Phòng khám')
	  ,('P236',N'Phòng khám Nephrology tổng quát 01',N'Lầu 9','K24',0,N'Phòng khám')
	  ,('P237',N'Phòng khám Nephrology tổng quát 02',N'Lầu 9','K24',0,N'Phòng khám')
	  ,('P238',N'Phòng khám trước và sau phẫu thuật thần kinh 01',N'Lầu 9','K25',0,N'Phòng khám')
	  ,('P239',N'Phòng khám trước và sau phẫu thuật thần kinh 02',N'Lầu 9','K25',0,N'Phòng khám')
	  ,('P240',N'Phòng khám trước và sau phẫu thuật cơ-xương-khớp 01',N'Lầu 9','K25',0,N'Phòng khám')
	  ,('P241',N'Phòng khám trước và sau phẫu thuật cơ-xương-khớp 02',N'Lầu 10','K25',0,N'Phòng khám')
	  ,('P242',N'Phòng khám trước và sau phẫu thuật tiết niệu 01',N'Lầu 10','K25',0,N'Phòng khám')
	  ,('P243',N'Phòng khám trước và sau phẫu thuật tiết niệu 02',N'Lầu 10','K25',0,N'Phòng khám')
	  ,('P244',N'Phòng khám trước và sau phẫu thuật não 01',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P245',N'Phòng khám trước và sau phẫu thuật não 02',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P246',N'Phòng khám trước và sau phẫu thuật tủy sống 01',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P247',N'Phòng khám trước và sau phẫu thuật tủy sống 02',N'Lầu 10','K26',0,N'Phòng khám')
	  ,('P248',N'Phòng khám bệnh parkinson và các loại rối loạn vận động 01',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P249',N'Phòng khám bệnh parkinson và các loại rối loạn vận động 02',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P250',N'Phòng khám tai biến mạch máu não 01',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P251',N'Phòng khám tai biến mạch máu não 02',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P252',N'Phòng khám giấc ngủ 01',N'Lầu 10','K27',0,N'Phòng khám')
	  ,('P253',N'Phòng khám giấc ngủ 02',N'Lầu 11','K27',0,N'Phòng khám')
	  ,('P254',N'Phòng khám bệnh truyền nhiễm nhiệt đới 01',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P255',N'Phòng khám bệnh truyền nhiễm nhiệt đới 02',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P256',N'Phòng khám bệnh truyền nhiễm nhiệt đới 02',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P257',N'Phòng khám bệnh truyền nhiễm nhiệt đới 02',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P258',N'Phòng khám bệnh truyền nhiễm trong cộng đồng 01',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P259',N'Phòng khám bệnh truyền nhiễm trong cộng đồng 02',N'Lầu 11','K29',0,N'Phòng khám')
	  ,('P260',N'Phòng khám tăng nhãn áp 02',N'Lầu 11','K03',0,N'Phòng khám')
	  ,('P261',N'Phòng khám nội tiết 01',N'Lầu 11','K05',0,N'Phòng khám')
	  ,('P262',N'Phòng khám nội tiết 02',N'Lầu 11','K05',0,N'Phòng khám')

insert into PhongKham([MSPhong],[TenPhong],[DiaDiem],[MaKhoa],[SoGiuong],Loai)
values
	 ('PXNCC263',N'Phòng chụp cộng hưởng từ 01',N'Lầu 1','K20',0,N'Phòng chức năng')
	,('PXNCC264',N'Phòng chụp cộng hưởng từ 02',N'Lầu 1','K20',0,N'Phòng chức năng')

	,('PXNCC265',N'Phòng chụp cộng hưởng từ 03',N'Lầu 1','K20',0,N'Phòng chức năng')
	,('PXNCC266',N'Phòng chụp cộng hưởng từ 04',N'Lầu 1','K20',0,N'Phòng chức năng')
	 
	,('PXNCC267',N'Phòng chụp CT 01',N'Lầu 1','K20',0,N'Phòng chức năng')
	,('PXNCC268',N'Phòng chụp CT 02',N'Lầu 1','K20',0,N'Phòng chức năng')

	,('PXNCC269',N'Phòng chụp CT 03',N'Lầu 1','K20',0,N'Phòng chức năng')
	,('PXNCC270',N'Phòng chụp CT 04',N'Lầu 1','K20',0,N'Phòng chức năng')

	,('PXNCC271',N'Phòng chụp X-Quang 01',N'Lầu 2','K20',0,N'Phòng chức năng')
	,('PXNCC272',N'Phòng chụp X-Quang 02',N'Lầu 2','K20',0,N'Phòng chức năng')

	,('PXNCC273',N'Phòng chụp X-Quang 03',N'Lầu 2','K20',0,N'Phòng chức năng')
	,('PXNCC274',N'Phòng chụp X-Quang 04',N'Lầu 2','K20',0,N'Phòng chức năng')
	
	,('PXNCC275',N'Phòng nội soi 01',N'Lầu 2','K28',0,N'Phòng chức năng')
	,('PXNCC276',N'Phòng nội soi 02',N'Lầu 2','K28',0,N'Phòng chức năng')

	,('PXNCC277',N'Phòng nội soi 03',N'Lầu 2','K28',0,N'Phòng chức năng')
	,('PXNCC278',N'Phòng nội soi 04',N'Lầu 2','K28',0,N'Phòng chức năng')

	,('PXNCC279',N'Phòng chụp PET 01',N'Lầu 3','K20',0,N'Phòng chức năng')
	,('PXNCC280',N'Phòng chụp PET 02',N'Lầu 3','K20',0,N'Phòng chức năng')

	,('PXNCC281',N'Phòng chụp PET 03',N'Lầu 3','K20',0,N'Phòng chức năng')
	,('PXNCC282',N'Phòng chụp PET 04',N'Lầu 3','K20',0,N'Phòng chức năng')

	,('PXNCC283',N'Phòng chụp MRI 01',N'Lầu 3','K20',0,N'Phòng chức năng')
	,('PXNCC284',N'Phòng chụp MRI 02',N'Lầu 3','K20',0,N'Phòng chức năng')

	,('PXNCC285',N'Phòng chụp MRI 03',N'Lầu 3','K20',0,N'Phòng chức năng')
	,('PXNCC286',N'Phòng chụp MRI 04',N'Lầu 3','K20',0,N'Phòng chức năng')

	,('P288',N'Phòng phẫu thuật khoa phụ sản 01',N'Lầu 4','K18',0,N'Phòng chức năng')
	,('P289',N'Phòng phẫu thuật khoa phụ sản 02',N'Lầu 4','K18',0,N'Phòng chức năng')
	,('P290',N'Phòng phẫu thuật khoa phụ sản 03',N'Lầu 4','K18',0,N'Phòng chức năng')

	,('P291',N'Phòng phẫu thuật khoa Răng-Hàm-Mặt 01',N'Lầu 5','K06',0,N'Phòng chức năng')
	,('P292',N'Phòng phẫu thuật khoa Răng-Hàm-Mặt 02',N'Lầu 5','K06',0,N'Phòng chức năng')
	,('P293',N'Phòng phẫu thuật khoa Răng-Hàm-Mặt 03',N'Lầu 5','K06',0,N'Phòng chức năng')
	,('P294',N'Phòng phẫu thuật khoa Răng-Hàm-Mặt 03',N'Lầu 5','K06',0,N'Phòng chức năng')

	,('P295',N'Phòng phẫu thuật khoa tim mạch 01',N'Lầu 5','K08',0,N'Phòng chức năng')
	,('P296',N'Phòng phẫu thuật khoa tim mạch 02',N'Lầu 5','K08',0,N'Phòng chức năng')
	,('P297',N'Phòng phẫu thuật khoa tim mạch 03',N'Lầu 5','K08',0,N'Phòng chức năng')
	,('P298',N'Phòng phẫu thuật khoa tim mạch 04',N'Lầu 5','K08',0,N'Phòng chức năng')

	,('P299',N'Phòng phẫu thuật khoa ngoại tổng hợp 01',N'Lầu 6','K19',0,N'Phòng chức năng')
	,('P300',N'Phòng phẫu thuật khoa ngoại tổng hợp 02',N'Lầu 6','K19',0,N'Phòng chức năng')
	,('P301',N'Phòng phẫu thuật khoa ngoại tổng hợp 03',N'Lầu 6','K19',0,N'Phòng chức năng')
	,('P302',N'Phòng phẫu thuật khoa ngoại tổng hợp 04',N'Lầu 6','K19',0,N'Phòng chức năng')

	,('P303',N'Phòng phẫu thuật khoa phẫu thuật 01',N'Lầu 6','K25',0,N'Phòng chức năng')
	,('P304',N'Phòng phẫu thuật khoa phẫu thuật 01 02',N'Lầu 6','K25',0,N'Phòng chức năng')
	,('P305',N'Phòng phẫu thuật khoa phẫu thuật 01 03',N'Lầu 6','K25',0,N'Phòng chức năng')
	,('P306',N'Phòng phẫu thuật khoa phẫu thuật 01 04',N'Lầu 6','K25',0,N'Phòng chức năng')

	,('P307',N'Phòng phẫu thuật khoa chấn thương chỉnh hình 01',N'Lầu 6','K15',0,N'Phòng chức năng')
	,('P308',N'Phòng phẫu thuật khoa chấn thương chỉnh hình 02',N'Lầu 6','K15',0,N'Phòng chức năng')
	,('P309',N'Phòng phẫu thuật khoa chấn thương chỉnh hình 03',N'Lầu 6','K15',0,N'Phòng chức năng')
	,('P310',N'Phòng phẫu thuật khoa chấn thương chỉnh hình 04',N'Lầu 6','K15',0,N'Phòng chức năng')

	,('P311',N'Phòng phẫu thuật khoa mắt 1',N'Lầu 7','K03',0,N'Phòng chức năng')
	,('P312',N'Phòng phẫu thuật khoa mắt 2',N'Lầu 7','K03',0,N'Phòng chức năng')
	,('P313',N'Phòng phẫu thuật khoa mắt 3',N'Lầu 7','K03',0,N'Phòng chức năng')

	,('P314',N'Phòng thủ thuật khoa da liễu 1',N'Lầu 7','K07',0,N'Phòng chức năng')
	,('P315',N'Phòng thủ thuật khoa da liễu 2',N'Lầu 7','K07',0,N'Phòng chức năng')

	,('P316',N'Phòng thủ thuật khoa tiêu hóa 1',N'Lầu 7','K04',0,N'Phòng chức năng')
	,('P317',N'Phòng thủ thuật khoa tiêu hóa 2',N'Lầu 7','K04',0,N'Phòng chức năng')

	,('P318',N'Phòng phẫu thuật khoa ngoại thần kinh 1',N'Lầu 8','K26',0,N'Phòng chức năng')
	,('P319',N'Phòng phẫu thuật khoa ngoại thần kinh 2',N'Lầu 8','K26',0,N'Phòng chức năng')
	,('P320',N'Phòng phẫu thuật khoa ngoại thần kinh 3',N'Lầu 8','K26',0,N'Phòng chức năng')
	,('P321',N'Phòng phẫu thuật khoa ngoại thần kinh 4',N'Lầu 8','K26',0,N'Phòng chức năng')

	,('PXNCC322',N'Phòng xét nghiệm PCR 01',N'Lầu 8','K28',0,N'Phòng chức năng')
	,('PXNCC323',N'Phòng xét nghiệm PCR 02',N'Lầu 8','K28',0,N'Phòng chức năng')
	,('PXNCC324',N'Phòng xét nghiệm PCR 03',N'Lầu 8','K28',0,N'Phòng chức năng')

	,('PXNCC325',N'Phòng xét nghiệm lâm sàng 01',N'Lầu 8','K28',0,N'Phòng chức năng')
	,('PXNCC326',N'Phòng xét nghiệm lâm sàng 02',N'Lầu 8','K28',0,N'Phòng chức năng')
	,('PXNCC327',N'Phòng xét nghiệm lâm sàng 03',N'Lầu 8','K28',0,N'Phòng chức năng')

	,('PXNCC328',N'Phòng xét nghiệm sinh học phân tử 01',N'Lầu 9','K28',0,N'Phòng chức năng')
	,('PXNCC329',N'Phòng xét nghiệm sinh học phân tử 02',N'Lầu 9','K28',0,N'Phòng chức năng')
	,('PXNCC330',N'Phòng xét nghiệm sinh học phân tử 03',N'Lầu 9','K28',0,N'Phòng chức năng')

	,('PXNCC331',N'Phòng xét nghiệm sinh học phân tử 01',N'Lầu 9','K28',0,N'Phòng chức năng')
	,('PXNCC332',N'Phòng xét nghiệm sinh học phân tử 02',N'Lầu 9','K28',0,N'Phòng chức năng')
	,('PXNCC333',N'Phòng xét nghiệm sinh học phân tử 03',N'Lầu 9','K28',0,N'Phòng chức năng')

	,('PXNCC334',N'Phòng xét nghiệm miễn dịch 01',N'Lầu 10','K28',0,N'Phòng chức năng')
	,('PXNCC335',N'Phòng xét nghiệm miễn dịch 02',N'Lầu 10','K28',0,N'Phòng chức năng')
	,('PXNCC336',N'Phòng xét nghiệm miễn dịch 03',N'Lầu 10','K28',0,N'Phòng chức năng')

	,('PXNCC337',N'Phòng xét nghiệm vi sinh vật 01',N'Lầu 10','K28',0,N'Phòng chức năng')
	,('PXNCC338',N'Phòng xét nghiệm vi sinh vật 02',N'Lầu 10','K28',0,N'Phòng chức năng')

	,('PXNCC339',N'Phòng xét nghiệm chuyên biệt 01',N'Lầu 10','K28',0,N'Phòng chức năng')
	,('PXNCC340',N'Phòng xét nghiệm chuyên biệt 02',N'Lầu 10','K28',0,N'Phòng chức năng')

	,('P341',N'Phòng đẻ 01',N'Lầu 11','K18',0,N'Phòng chức năng')
	,('P342',N'Phòng đẻ 02',N'Lầu 11','K18',0,N'Phòng chức năng')
	
	,('P343',N'Phòng phục hồi chức năng chuyên biệt 01',N'Lầu 11','K12',0,N'Phòng chức năng')
	,('P344',N'Phòng phục hồi chức năng chuyên biệt 02',N'Lầu 11','K12',0,N'Phòng chức năng')
	,('P345',N'Phòng phục hồi chức năng chuyên biệt 03',N'Lầu 11','K12',0,N'Phòng chức năng')
	,('P346',N'Phòng phục hồi chức năng chuyên biệt 04',N'Lầu 11','K12',0,N'Phòng chức năng')

	,('P347',N'Phòng vật lý trị liệu 01',N'Lầu 11','K12',0,N'Phòng chức năng')
	,('P348',N'Phòng vật lý trị liệu 01',N'Lầu 11','K12',0,N'Phòng chức năng')
	,('P349',N'Phòng vật lý trị liệu 02',N'Lầu 11','K12',0,N'Phòng chức năng')
	,('P350',N'Phòng vật lý trị liệu 02',N'Lầu 11','K12',0,N'Phòng chức năng')

	,('P351',N'Phòng phục hồi chức năng sau phẫu thuật 01',N'Lầu 12','K12',0,N'Phòng chức năng')
	,('P352',N'Phòng phục hồi chức năng sau phẫu thuật 02',N'Lầu 12','K12',0,N'Phòng chức năng')

	,('P353',N'Phòng tư vấn dinh dưỡng và lối sống 01',N'Lầu 12','K13',0,N'Phòng khám')
	,('P354',N'Phòng tư vấn dinh dưỡng và lối sống 02',N'Lầu 12','K13',0,N'Phòng khám')
	,('P355',N'Phòng tư giấc ngủ 01',N'Lầu 12','K27',0,N'Phòng khám')
	,('P356',N'Phòng tư giấc ngủ 02',N'Lầu 12','K27',0,N'Phòng khám')
	,('P357',N'Phòng tư vấn phục hồi chức năng 01',N'Lầu 13','K12',0,N'Phòng khám')
	,('P358',N'Phòng tư vấn phục hồi chức năng 02',N'Lầu 13','K12',0,N'Phòng khám')
	,('P359',N'Phòng tư vấn điều trị viêm tai 01',N'Lầu 13','K21',0,N'Phòng khám')
	,('P360',N'Phòng tư vấn điều trị viêm tai 02',N'Lầu 13','K21',0,N'Phòng khám')

	,('P361',N'Phòng cấp cứu 24/7 01',N'Lầu 13','K01',0,N'Phòng chức năng')
	,('P362',N'Phòng cấp cứu 24/7 02',N'Lầu 13','K01',0,N'Phòng chức năng')

	,('P363',N'Phòng siêu âm 01',N'Lầu 14','K20',0,N'Phòng chức năng')
	,('P364',N'Phòng siêu âm 01',N'Lầu 14','K20',0,N'Phòng chức năng')
	,('P365',N'Phòng siêu âm 01',N'Lầu 14','K20',0,N'Phòng chức năng')
	,('P366',N'Phòng siêu âm 01',N'Lầu 14','K20',0,N'Phòng chức năng')

	,('P367',N'Phòng liệu pháp hành vi 01',N'Lầu 14','K23',0,N'Phòng chức năng')
	,('P368',N'Phòng liệu pháp hành vi 02',N'Lầu 14','K23',0,N'Phòng chức năng')

	,('P369',N'Phòng phẫu thuật khoa Cơ-Xương-Khớp 01',N'Lầu 4','K09',0,N'Phòng chức năng')
	,('P370',N'Phòng phẫu thuật khoa Cơ-Xương-Khớp 02',N'Lầu 4','k09',0,N'Phòng chức năng')
	,('P371',N'Phòng phẫu thuật khoa Cơ-Xương-Khớp 03',N'Lầu 4','K09',0,N'Phòng chức năng')

	,('P372',N'Phòng phẫu thuật khoa phẫu thuật 01',N'Lầu 6','K25',0,N'Phòng chức năng')
	,('P373',N'Phòng phẫu thuật khoa phẫu thuật 02',N'Lầu 6','K25',0,N'Phòng chức năng')
	,('P374',N'Phòng phẫu thuật khoa phẫu thuật 03',N'Lầu 6','K25',0,N'Phòng chức năng')
	,('P375',N'Phòng phẫu thuật khoa phẫu thuật 04',N'Lầu 6','K25',0,N'Phòng chức năng')

insert into PhongKham(MSPhong,TenPhong,SoGiuong,MaKhoa,Loai)
VALUES
	 ('PB01.1',N'Phòng hồi sức tích cực-1 giường',1,'K01',N'Phòng bệnh')
	,('PB01.2',N'Phòng hồi sức tích cực-1 giường',1,'K01',N'Phòng bệnh')
	,('PB01.3',N'Phòng hồi sức tích cực-1 giường',1,'K01',N'Phòng bệnh')
	,('PB01.4',N'Phòng hồi sức tích cực-1 giường',1,'K01',N'Phòng bệnh')
	,('PB01.5',N'Phòng hồi sức tích cực-2 giường',2,'K01',N'Phòng bệnh')
	,('PB01.6',N'Phòng hồi sức tích cực-3 giường',3,'K01',N'Phòng bệnh')
	,('PB01.7',N'Phòng hồi sức tích cực-4 giường',4,'K01',N'Phòng bệnh')
	,('PB01.8',N'Phòng hồi sức tích cực-2 giường',2,'K01',N'Phòng bệnh')
	,('PB01.9',N'Phòng hồi sức tích cực-3 giường',3,'K01',N'Phòng bệnh')
	,('PB01.10',N'Phòng hồi sức tích cực-4 giường',4,'K01',N'Phòng bệnh')

	-----------------------------Khoa nhi---------------------------------------
	,('PB02.1',N'Phòng chăm sóc sức khỏe trẻ em-1 giường',1,'K02',N'Phòng bệnh')
	,('PB02.2',N'Phòng chăm sóc sức khỏe trẻ em-1 giường',1,'K02',N'Phòng bệnh')
	,('PB02.3',N'Phòng chăm sóc sức khỏe trẻ em-1 giường',1,'K02',N'Phòng bệnh')
	,('PB02.4',N'Phòng chăm sóc sức khỏe trẻ em-1 giường',1,'K02',N'Phòng bệnh')
	,('PB02.5',N'Phòng chăm sóc sức khỏe trẻ em-1 giường',1,'K02',N'Phòng bệnh')
	,('PB02.6',N'Phòng chăm sóc sức khỏe trẻ em-1 giường',1,'K02',N'Phòng bệnh')


	,('PB02.7',N'Phòng chăm sóc sức khỏe trẻ em-2 giường',2,'K02',N'Phòng bệnh')
	,('PB02.8',N'Phòng chăm sóc sức khỏe trẻ em-3 giường',3,'K02',N'Phòng bệnh')
	,('PB02.9',N'Phòng chăm sóc sức khỏe trẻ em-4 giường',4,'K02',N'Phòng bệnh')
	,('PB02.10',N'Phòng chăm sóc sức khỏe trẻ em-2 giường',2,'K02',N'Phòng bệnh')

	-------------------------------Khoa mắt-----------------------------------
	,('PB03.1',N'Phòng chăm sóc sức khỏe mắt-1 giường',1,'K03',N'Phòng bệnh')
	,('PB03.2',N'Phòng chăm sóc sức khỏe mắt-1 giường',1,'K03',N'Phòng bệnh')
	,('PB03.3',N'Phòng chăm sóc sức khỏe mắt-1 giường',1,'K03',N'Phòng bệnh')
	,('PB03.4',N'Phòng chăm sóc sức khỏe mắt-2 giường',2,'K03',N'Phòng bệnh')
	,('PB03.5',N'Phòng chăm sóc sức khỏe mắt-3 giường',3,'K03',N'Phòng bệnh')
	,('PB03.6',N'Phòng chăm sóc sức khỏe mắt-4 giường',4,'K03',N'Phòng bệnh')
	,('PB03.7',N'Phòng chăm sóc sức khỏe mắt-2 giường',2,'K03',N'Phòng bệnh')



	----------------------------Khoa tiêu hóa-----------------------------------------

	,('PB04.1',N'Phòng bệnh khoa tiêu hóa-1 giường',1,'K04',N'Phòng bệnh')
	,('PB04.2',N'Phòng bệnh khoa tiêu hóa-1 giường',1,'K04',N'Phòng bệnh')
	,('PB04.3',N'Phòng bệnh khoa tiêu hóa-1 giường',1,'K04',N'Phòng bệnh')

	,('PB04.7',N'Phòng bệnh khoa tiêu hóa-2 giường',2,'K04',N'Phòng bệnh')
	,('PB04.8',N'Phòng bệnh khoa tiêu hóa-3 giường',3,'K04',N'Phòng bệnh')
	,('PB04.9',N'Phòng bệnh khoa tiêu hóa-4 giường',4,'K04',N'Phòng bệnh')
	,('PB04.10',N'Phòng bệnh khoa tiêu hóa-2 giường',2,'K04',N'Phòng bệnh')

	--------------------------Khoa nội tiết-------------------------------------------

	,('PB05.1',N'Phòng bệnh khoa nội tiết-1 giường',1,'K05',N'Phòng bệnh')
	,('PB05.2',N'Phòng bệnh khoa nội tiết-1 giường',1,'K05',N'Phòng bệnh')
	,('PB05.3',N'Phòng bệnh khoa nội tiết-1 giường',1,'K05',N'Phòng bệnh')

	,('PB05.7',N'Phòng bệnh khoa nội tiết-2 giường',2,'K05',N'Phòng bệnh')
	,('PB05.8',N'Phòng bệnh khoa nội tiết-3 giường',3,'K05',N'Phòng bệnh')
	,('PB05.9',N'Phòng bệnh khoa nội tiết-4 giường',4,'K05',N'Phòng bệnh')
	,('PB05.10',N'Phòng bệnh khoa nội tiết-2 giường',2,'K05',N'Phòng bệnh')

	-----------------------------Khoa răng-hàm-mặt--------------------------------------

	,('PB06.1',N'Phòng bệnh khoa răng-hàm-mặt-1 giường',1,'K06',N'Phòng bệnh')
	,('PB06.2',N'Phòng bệnh khoa răng-hàm-mặt-1 giường',1,'K06',N'Phòng bệnh')
	,('PB06.3',N'Phòng bệnh khoa răng-hàm-mặt-1 giường',1,'K06',N'Phòng bệnh')


	,('PB06.7',N'Phòng bệnh khoa răng-hàm-mặt-2 giường',2,'K06',N'Phòng bệnh')
	,('PB06.8',N'Phòng bệnh khoa răng-hàm-mặt-3 giường',3,'K06',N'Phòng bệnh')
	,('PB06.9',N'Phòng bệnh khoa răng-hàm-mặt-4 giường',4,'K06',N'Phòng bệnh')
	,('PB06.10',N'Phòng bệnh khoa răng-hàm-mặt-2 giường',2,'K06',N'Phòng bệnh')

	---------------------------------------Khoa da liễu-------------------------------------------

	,('PB07.1',N'Phòng bệnh khoa da liễu-1 giường',1,'K07',N'Phòng bệnh')
	,('PB07.2',N'Phòng bệnh khoa da liễu-1 giường',1,'K07',N'Phòng bệnh')
	,('PB07.3',N'Phòng bệnh khoa da liễu-1 giường',1,'K07',N'Phòng bệnh')
	,('PB07.4',N'Phòng bệnh khoa da liễu-1 giường',1,'K07',N'Phòng bệnh')
	,('PB07.5',N'Phòng bệnh khoa da liễu-1 giường',1,'K07',N'Phòng bệnh')
	,('PB07.6',N'Phòng bệnh khoa da liễu-1 giường',1,'K07',N'Phòng bệnh')


	,('PB07.7',N'Phòng bệnh khoa da liễu-2 giường',2,'K07',N'Phòng bệnh')
	,('PB07.8',N'Phòng bệnh khoa da liễu-3 giường',3,'K07',N'Phòng bệnh')
	,('PB07.9',N'Phòng bệnh khoa da liễu-4 giường',4,'K07',N'Phòng bệnh')
	,('PB07.10',N'Phòng bệnh khoa da liễu-2 giường',2,'K07',N'Phòng bệnh')

	----------------Khoa tim mạch--------------------------------------------------

	,('PB08.1',N'Phòng bệnh khoa tim mạch-1 giường',1,'K08',N'Phòng bệnh')
	,('PB08.2',N'Phòng bệnh khoa tim mạch-1 giường',1,'K08',N'Phòng bệnh')
	,('PB08.3',N'Phòng bệnh khoa tim mạch-1 giường',1,'K08',N'Phòng bệnh')
	,('PB08.4',N'Phòng bệnh khoa tim mạch-1 giường',1,'K08',N'Phòng bệnh')
	,('PB08.5',N'Phòng bệnh khoa tim mạch-1 giường',1,'K08',N'Phòng bệnh')
	,('PB08.6',N'Phòng bệnh khoa tim mạch-1 giường',1,'K08',N'Phòng bệnh')


	,('PB08.7',N'Phòng bệnh khoa tim mạch-2 giường',2,'K08',N'Phòng bệnh')
	,('PB08.8',N'Phòng bệnh khoa tim mạch-3 giường',3,'K08',N'Phòng bệnh')
	,('PB08.9',N'Phòng bệnh khoa tim mạch-4 giường',4,'K08',N'Phòng bệnh')
	,('PB08.10',N'Phòng bệnh khoa tim mạch-2 giường',2,'K08',N'Phòng bệnh')

	-------------Khoa cơ-xương-khớp-----------------------------------
	,('PB09.1',N'Phòng bệnh khoa cơ-xương-khớp-1 giường',1,'K09',N'Phòng bệnh')
	,('PB09.2',N'Phòng bệnh khoa cơ-xương-khớp-1 giường',1,'K09',N'Phòng bệnh')
	,('PB09.3',N'Phòng bệnh khoa cơ-xương-khớp-1 giường',1,'K09',N'Phòng bệnh')
	,('PB09.4',N'Phòng bệnh khoa cơ-xương-khớp-1 giường',1,'K09',N'Phòng bệnh')
	,('PB09.5',N'Phòng bệnh khoa cơ-xương-khớp-1 giường',1,'K09',N'Phòng bệnh')
	,('PB09.6',N'Phòng bệnh khoa cơ-xương-khớp-1 giường',1,'K09',N'Phòng bệnh')

	,('PB09.7',N'Phòng bệnh khoa cơ-xương-khớp-2 giường',2,'K09',N'Phòng bệnh')
	,('PB09.8',N'Phòng bệnh khoa cơ-xương-khớp-3 giường',3,'K09',N'Phòng bệnh')
	,('PB09.9',N'Phòng bệnh khoa cơ-xương-khớp-4 giường',4,'K09',N'Phòng bệnh')
	,('PB09.10',N'Phòng bệnh khoa cơ-xương-khớp-2 giường',2,'K09',N'Phòng bệnh')
	,('PB09.11',N'Phòng bệnh khoa cơ-xương-khớp-3 giường',3,'K09',N'Phòng bệnh')
	,('PB09.12',N'Phòng bệnh khoa cơ-xương-khớp-4 giường',4,'K09',N'Phòng bệnh')

	-------------------------Khoa ung bướu----------------------------


	,('PB10.1',N'Phòng bệnh khoa ung bướu 1 giường',1,'K10',N'Phòng bệnh')
	,('PB10.2',N'Phòng bệnh khoa ung bướu 1 giường',1,'K10',N'Phòng bệnh')
	,('PB10.3',N'Phòng bệnh khoa ung bướu 1 giường',1,'K10',N'Phòng bệnh')
	,('PB10.4',N'Phòng bệnh khoa ung bướu 1 giường',1,'K10',N'Phòng bệnh')
	,('PB10.5',N'Phòng bệnh khoa ung bướu 1 giường',1,'K10',N'Phòng bệnh')
	,('PB10.6',N'Phòng bệnh khoa ung bướu 1 giường',1,'K10',N'Phòng bệnh')

	,('PB10.7',N'Phòng bệnh khoa ung bướu 2 giường',2,'K10',N'Phòng bệnh')
	,('PB10.8',N'Phòng bệnh khoa ung bướu 3 giường',3,'K10',N'Phòng bệnh')
	,('PB10.9',N'Phòng bệnh khoa ung bướu 4 giường',4,'K10',N'Phòng bệnh')
	,('PB10.10',N'Phòng bệnh khoa ung bướu 2 giường',2,'K10',N'Phòng bệnh')
	,('PB10.11',N'Phòng bệnh khoa ung bướu 3 giường',3,'K10',N'Phòng bệnh')
	,('PB10.12',N'Phòng bệnh khoa ung bướu 4 giường',4,'K10',N'Phòng bệnh')

	---------------------------Khoa hô hấp-------------------------------

	,('PB11.1',N'Phòng bệnh khoa hô hấp 1 giường',1,'K11',N'Phòng bệnh')
	,('PB11.2',N'Phòng bệnh khoa hô hấp 1 giường',1,'K11',N'Phòng bệnh')
	,('PB11.3',N'Phòng bệnh khoa hô hấp 1 giường',1,'K11',N'Phòng bệnh')
	,('PB11.4',N'Phòng bệnh khoa hô hấp 1 giường',1,'K11',N'Phòng bệnh')
	,('PB11.5',N'Phòng bệnh khoa hô hấp 1 giường',1,'K11',N'Phòng bệnh')
	,('PB11.6',N'Phòng bệnh khoa hô hấp 1 giường',1,'K11',N'Phòng bệnh')

	,('PB11.7',N'Phòng bệnh khoa hô hấp 2 giường',2,'K11',N'Phòng bệnh')
	,('PB11.8',N'Phòng bệnh khoa hô hấp 3 giường',3,'K11',N'Phòng bệnh')
	,('PB11.9',N'Phòng bệnh khoa hô hấp 4 giường',4,'K11',N'Phòng bệnh')
	,('PB11.10',N'Phòng bệnh khoa hô hấp 2 giường',2,'K11',N'Phòng bệnh')
	,('PB11.11',N'Phòng bệnh khoa hô hấp 3 giường',3,'K11',N'Phòng bệnh')
	,('PB11.12',N'Phòng bệnh khoa hô hấp 4 giường',4,'K11',N'Phòng bệnh')

	------------------------Phòng bệnh vật lý-trị liêu--------------------------------

	,('PB12.1',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 1 giường',1,'K12',N'Phòng bệnh')
	,('PB12.2',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 1 giường',1,'K12',N'Phòng bệnh')
	,('PB12.3',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 1 giường',1,'K12',N'Phòng bệnh')
	,('PB12.4',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 1 giường',1,'K12',N'Phòng bệnh')
	,('PB12.5',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 1 giường',1,'K12',N'Phòng bệnh')
	,('PB12.6',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 1 giường',1,'K12',N'Phòng bệnh')

	,('PB12.7',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 2 giường',2,'K12',N'Phòng bệnh')
	,('PB12.8',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 3 giường',3,'K12',N'Phòng bệnh')
	,('PB12.9',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 4 giường',4,'K12',N'Phòng bệnh')
	,('PB12.10',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 2 giường',2,'K12',N'Phòng bệnh')
	,('PB12.11',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 3 giường',3,'K12',N'Phòng bệnh')
	,('PB12.12',N'Phòng bệnh khoa vật lý trị liệu-phục hồi chức năng 4 giường',4,'K12',N'Phòng bệnh')

	---------------=------Khoa dinh dưỡng------------------------------------------------------------

	,('PB13.1',N'Phòng bệnh khoa dinh dưỡng 1 giường',1,'K13',N'Phòng bệnh')
	,('PB13.2',N'Phòng bệnh khoa dinh dưỡng 1 giường',1,'K13',N'Phòng bệnh')
	,('PB13.3',N'Phòng bệnh khoa dinh dưỡng 1 giường',1,'K13',N'Phòng bệnh')
	,('PB13.4',N'Phòng bệnh khoa dinh dưỡng 1 giường',1,'K13',N'Phòng bệnh')
	,('PB13.5',N'Phòng bệnh khoa dinh dưỡng 1 giường',1,'K13',N'Phòng bệnh')
	,('PB13.6',N'Phòng bệnh khoa dinh dưỡng 1 giường',1,'K13',N'Phòng bệnh')

	,('PB13.7',N'Phòng bệnh khoa dinh dưỡng 2 giường',2,'K13',N'Phòng bệnh')
	,('PB13.8',N'Phòng bệnh khoa dinh dưỡng 3 giường',3,'K13',N'Phòng bệnh')
	,('PB13.9',N'Phòng bệnh khoa dinh dưỡng 4 giường',4,'K13',N'Phòng bệnh')
	,('PB13.10',N'Phòng bệnh khoa dinh dưỡng 2 giường',2,'K13',N'Phòng bệnh')
	,('PB13.11',N'Phòng bệnh khoa dinh dưỡng 3 giường',3,'K13',N'Phòng bệnh')
	,('PB13.12',N'Phòng bệnh khoa dinh dưỡng 4 giường',4,'K13',N'Phòng bệnh')

	-----------------------Khoa nội tổng hợp------------------------------------

	,('PB14.1',N'Phòng bệnh khoa nội tổng hợp 1 giường',1,'K14',N'Phòng bệnh')
	,('PB14.2',N'Phòng bệnh khoa nội tổng hợp 1 giường',1,'K14',N'Phòng bệnh')
	,('PB14.3',N'Phòng bệnh khoa nội tổng hợp 1 giường',1,'K14',N'Phòng bệnh')
	,('PB14.4',N'Phòng bệnh khoa nội tổng hợp 1 giường',1,'K14',N'Phòng bệnh')
	,('PB14.5',N'Phòng bệnh khoa nội tổng hợp 1 giường',1,'K14',N'Phòng bệnh')
	,('PB14.6',N'Phòng bệnh khoa nội tổng hợp 1 giường',1,'K14',N'Phòng bệnh')

	,('PB14.7',N'Phòng bệnh khoa nội tổng hợp 2 giường',2,'K14',N'Phòng bệnh')
	,('PB14.8',N'Phòng bệnh khoa nội tổng hợp 3 giường',3,'K14',N'Phòng bệnh')
	,('PB14.9',N'Phòng bệnh khoa nội tổng hợp 4 giường',4,'K14',N'Phòng bệnh')
	,('PB14.10',N'Phòng bệnh khoa nội tổng hợp 2 giường',2,'K14',N'Phòng bệnh')
	,('PB14.11',N'Phòng bệnh khoa nội tổng hợp 3 giường',3,'K14',N'Phòng bệnh')
	,('PB14.12',N'Phòng bệnh khoa nội tổng hợp 4 giường',4,'K14',N'Phòng bệnh')
	-------------------------Khoa chấn thương chỉnh chình-------------------------------------------

	,('PB15.1',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 1 giường',1,'K15',N'Phòng bệnh')
	,('PB15.2',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 1 giường',1,'K15',N'Phòng bệnh')
	,('PB15.3',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 1 giường',1,'K15',N'Phòng bệnh')
	,('PB15.4',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 1 giường',1,'K15',N'Phòng bệnh')
	,('PB15.5',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 1 giường',1,'K15',N'Phòng bệnh')
	,('PB15.6',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 1 giường',1,'K15',N'Phòng bệnh')

	,('PB15.7',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 2 giường',2,'K15',N'Phòng bệnh')
	,('PB15.8',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 3 giường',3,'K15',N'Phòng bệnh')
	,('PB15.9',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 4 giường',4,'K15',N'Phòng bệnh')
	,('PB15.10',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 2 giường',2,'K15',N'Phòng bệnh')
	,('PB15.11',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 3 giường',3,'K15',N'Phòng bệnh')
	,('PB15.12',N'Phòng bệnh khoa chấn thương chỉnh chỉnh hình 4 giường',4,'K15',N'Phòng bệnh')

	--------------------------------Khoa phẫu thuật gây mê hồi sức

	,('PB16.1',N'Phòng bệnh hồi sức gây mê 1 giường',1,'K16',N'Phòng bệnh')
	,('PB16.2',N'Phòng bệnh hồi sức gây mê 1 giường',1,'K16',N'Phòng bệnh')
	,('PB16.3',N'Phòng bệnh hồi sức gây mê 1 giường',1,'K16',N'Phòng bệnh')
	,('PB16.4',N'Phòng bệnh hồi sức gây mê 1 giường',1,'K16',N'Phòng bệnh')
	,('PB16.5',N'Phòng bệnh hồi sức gây mê 1 giường',1,'K16',N'Phòng bệnh')
	,('PB16.6',N'Phòng bệnh hồi sức gây mê 1 giường',1,'K16',N'Phòng bệnh')

	,('PB16.7',N'Phòng bệnh hồi sức gây mê 2 giường',2,'K16',N'Phòng bệnh')
	,('PB16.8',N'Phòng bệnh hồi sức gây mê 3 giường',3,'K16',N'Phòng bệnh')
	,('PB16.9',N'Phòng bệnh hồi sức gây mê 4 giường',4,'K16',N'Phòng bệnh')
	,('PB16.10',N'Phòng bệnh hồi sức gây mê 2 giường',2,'K16',N'Phòng bệnh')
	,('PB16.11',N'Phòng bệnh hồi sức gây mê 3 giường',3,'K16',N'Phòng bệnh')
	,('PB16.12',N'Phòng bệnh hồi sức gây mê 4 giường',4,'K16',N'Phòng bệnh')
	---------------------Khoa phụ sản-------------------------------------
	,('PB18.1',N'Phòng bệnh khoa phụ sản 1 giường',1,'K18',N'Phòng bệnh')
	,('PB18.2',N'Phòng bệnh khoa phụ sản 1 giường',1,'K18',N'Phòng bệnh')
	,('PB18.3',N'Phòng bệnh khoa phụ sản 1 giường',1,'K18',N'Phòng bệnh')
	,('PB18.4',N'Phòng bệnh khoa phụ sản 1 giường',1,'K18',N'Phòng bệnh')
	,('PB18.5',N'Phòng bệnh khoa phụ sản 1 giường',1,'K18',N'Phòng bệnh')
	,('PB18.6',N'Phòng bệnh khoa phụ sản 1 giường',1,'K18',N'Phòng bệnh')

	,('PB18.7',N'Phòng bệnh khoa phụ sản 2 giường',2,'K18',N'Phòng bệnh')
	,('PB18.8',N'Phòng bệnh khoa phụ sản 3 giường',3,'K18',N'Phòng bệnh')
	,('PB18.9',N'Phòng bệnh khoa phụ sản 4 giường',4,'K18',N'Phòng bệnh')
	,('PB18.10',N'Phòng bệnh khoa phụ sản 2 giường',2,'K18',N'Phòng bệnh')
	,('PB18.11',N'Phòng bệnh khoa phụ sản 3 giường',3,'K18',N'Phòng bệnh')
	,('PB18.12',N'Phòng bệnh khoa phụ sản 4 giường',4,'K18',N'Phòng bệnh')

	---------------------------Khoa ngoại tổng hợp-------------------------------------


	,('PB19.1',N'Phòng bệnh khoa ngoại tổng hợp 1 giường',1,'K19',N'Phòng bệnh')
	,('PB19.2',N'Phòng bệnh khoa ngoại tổng hợp 1 giường',1,'K19',N'Phòng bệnh')
	,('PB19.3',N'Phòng bệnh khoa ngoại tổng hợp 1 giường',1,'K19',N'Phòng bệnh')
	,('PB19.4',N'Phòng bệnh khoa ngoại tổng hợp 1 giường',1,'K19',N'Phòng bệnh')
	,('PB19.5',N'Phòng bệnh khoa ngoại tổng hợp 1 giường',1,'K19',N'Phòng bệnh')
	,('PB19.6',N'Phòng bệnh khoa ngoại tổng hợp 1 giường',1,'K19',N'Phòng bệnh')

	,('PB19.7',N'Phòng bệnh khoa ngoại tổng hợp 2 giường',2,'K19',N'Phòng bệnh')
	,('PB19.8',N'Phòng bệnh khoa ngoại tổng hợp 3 giường',3,'K19',N'Phòng bệnh')
	,('PB19.9',N'Phòng bệnh khoa ngoại tổng hợp 4 giường',4,'K19',N'Phòng bệnh')
	,('PB19.10',N'Phòng bệnh khoa ngoại tổng hợp 2 giường',2,'K19',N'Phòng bệnh')
	,('PB19.11',N'Phòng bệnh khoa ngoại tổng hợp 3 giường',3,'K19',N'Phòng bệnh')
	,('PB19.12',N'Phòng bệnh khoa ngoại tổng hợp 4 giường',4,'K19',N'Phòng bệnh')

	------------------------------Khoa tai-mũi-hong------------------------------------

	,('PB21.1',N'Phòng bệnh khoa tai-mũi-họng 1 giường',1,'K21',N'Phòng bệnh')
	,('PB21.2',N'Phòng bệnh khoa tai-mũi-họng 1 giường',1,'K21',N'Phòng bệnh')
	,('PB21.3',N'Phòng bệnh khoa tai-mũi-họng 1 giường',1,'K21',N'Phòng bệnh')
	,('PB21.4',N'Phòng bệnh khoa tai-mũi-họng 1 giường',1,'K21',N'Phòng bệnh')
	,('PB21.5',N'Phòng bệnh khoa tai-mũi-họng 1 giường',1,'K21',N'Phòng bệnh')
	,('PB21.6',N'Phòng bệnh khoa tai-mũi-họng 1 giường',1,'K21',N'Phòng bệnh')

	,('PB21.7',N'Phòng bệnh khoa tai-mũi-họng 2 giường',2,'K21',N'Phòng bệnh')
	,('PB21.8',N'Phòng bệnh khoa tai-mũi-họng 3 giường',3,'K21',N'Phòng bệnh')
	,('PB21.9',N'Phòng bệnh khoa tai-mũi-họng 4 giường',4,'K21',N'Phòng bệnh')
	,('PB21.10',N'Phòng bệnh khoa tai-mũi-họng 2 giường',2,'K21',N'Phòng bệnh')
	,('PB21.11',N'Phòng bệnh khoa tai-mũi-họng 3 giường',3,'K21',N'Phòng bệnh')
	,('PB21.12',N'Phòng bệnh khoa tai-mũi-họng 4 giường',4,'K21',N'Phòng bệnh')

	------------------------------Khoa lao và bệnh phổi---------------------------------

	,('PB22.1',N'Phòng bệnh khoa lao và bệnh phổi 1 giường',1,'K22',N'Phòng bệnh')
	,('PB22.2',N'Phòng bệnh khoa lao và bệnh phổi 1 giường',1,'K22',N'Phòng bệnh')
	,('PB22.3',N'Phòng bệnh khoa lao và bệnh phổi 1 giường',1,'K22',N'Phòng bệnh')
	,('PB22.4',N'Phòng bệnh khoa lao và bệnh phổi 1 giường',1,'K22',N'Phòng bệnh')
	,('PB22.5',N'Phòng bệnh khoa lao và bệnh phổi 1 giường',1,'K22',N'Phòng bệnh')
	,('PB22.6',N'Phòng bệnh khoa lao và bệnh phổi 1 giường',1,'K22',N'Phòng bệnh')

	,('PB22.7',N'Phòng bệnh khoa lao và bệnh phổi 2 giường',2,'K22',N'Phòng bệnh')
	,('PB22.8',N'Phòng bệnh khoa lao và bệnh phổi 3 giường',3,'K22',N'Phòng bệnh')
	,('PB22.9',N'Phòng bệnh khoa lao và bệnh phổi 4 giường',4,'K22',N'Phòng bệnh')
	,('PB22.10',N'Phòng bệnh khoa lao và bệnh phổi 2 giường',2,'K22',N'Phòng bệnh')
	,('PB22.11',N'Phòng bệnh khoa lao và bệnh phổi 3 giường',3,'K22',N'Phòng bệnh')
	,('PB22.12',N'Phòng bệnh khoa lao và bệnh phổi 4 giường',4,'K22',N'Phòng bệnh')

	-----------------------Khoa tâm thần------------------------------------------

	,('PB23.1',N'Phòng bệnh khoa tâm thần 1 giường',1,'K23',N'Phòng bệnh')
	,('PB23.2',N'Phòng bệnh khoa tâm thần 1 giường',1,'K23',N'Phòng bệnh')
	,('PB23.3',N'Phòng bệnh khoa tâm thần 1 giường',1,'K23',N'Phòng bệnh')
	,('PB23.4',N'Phòng bệnh khoa tâm thần 1 giường',1,'K23',N'Phòng bệnh')
	,('PB23.5',N'Phòng bệnh khoa tâm thần 1 giường',1,'K23',N'Phòng bệnh')
	,('PB23.6',N'Phòng bệnh khoa tâm thần 1 giường',1,'K23',N'Phòng bệnh')

	,('PB23.7',N'Phòng bệnh khoa tâm thần 2 giường',2,'K23',N'Phòng bệnh')
	,('PB23.8',N'Phòng bệnh khoa tâm thần 3 giường',3,'K23',N'Phòng bệnh')
	,('PB23.9',N'Phòng bệnh khoa tâm thần 4 giường',4,'K23',N'Phòng bệnh')
	,('PB23.10',N'Phòng bệnh khoa tâm thần 2 giường',2,'K23',N'Phòng bệnh')
	,('PB23.11',N'Phòng bệnh khoa tâm thần 3 giường',3,'K23',N'Phòng bệnh')
	,('PB23.12',N'Phòng bệnh khoa tâm thần 4 giường',4,'K23',N'Phòng bệnh')

	-----------------------------Khoa thận-----------------------------------------
	,('PB24.1',N'Phòng bệnh khoa thận 1 giường',1,'K24',N'Phòng bệnh')
	,('PB24.2',N'Phòng bệnh khoa thận 1 giường',1,'K24',N'Phòng bệnh')
	,('PB24.3',N'Phòng bệnh khoa thận 1 giường',1,'K24',N'Phòng bệnh')
	,('PB24.4',N'Phòng bệnh khoa thận 1 giường',1,'K24',N'Phòng bệnh')
	,('PB24.5',N'Phòng bệnh khoa thận 1 giường',1,'K24',N'Phòng bệnh')
	,('PB24.6',N'Phòng bệnh khoa thận 1 giường',1,'K24',N'Phòng bệnh')

	,('PB24.7',N'Phòng bệnh khoa thận 2 giường',2,'K24',N'Phòng bệnh')
	,('PB24.8',N'Phòng bệnh khoa thận 3 giường',3,'K24',N'Phòng bệnh')
	,('PB24.9',N'Phòng bệnh khoa thận 4 giường',4,'K24',N'Phòng bệnh')
	,('PB24.10',N'Phòng bệnh khoa thận 2 giường',2,'K24',N'Phòng bệnh')
	,('PB24.11',N'Phòng bệnh khoa thận 3 giường',3,'K24',N'Phòng bệnh')
	,('PB24.12',N'Phòng bệnh khoa thận 4 giường',4,'K24',N'Phòng bệnh')
	
	-----------------------------------Khoa phẫu thuật--------------------------------------

	,('PB25.1',N'Phòng bệnh khoa phẫu thuật 1 giường',1,'K25',N'Phòng bệnh')
	,('PB25.2',N'Phòng bệnh khoa phẫu thuật 1 giường',1,'K25',N'Phòng bệnh')
	,('PB25.3',N'Phòng bệnh khoa phẫu thuật 1 giường',1,'K25',N'Phòng bệnh')
	,('PB25.4',N'Phòng bệnh khoa phẫu thuật 1 giường',1,'K25',N'Phòng bệnh')
	,('PB25.5',N'Phòng bệnh khoa phẫu thuật 1 giường',1,'K25',N'Phòng bệnh')
	,('PB25.6',N'Phòng bệnh khoa phẫu thuật 1 giường',1,'K25',N'Phòng bệnh')

	,('PB25.7',N'Phòng bệnh khoa phẫu thuật 2 giường',2,'K25',N'Phòng bệnh')
	,('PB25.8',N'Phòng bệnh khoa phẫu thuật 3 giường',3,'K25',N'Phòng bệnh')
	,('PB25.9',N'Phòng bệnh khoa phẫu thuật 4 giường',4,'K25',N'Phòng bệnh')
	,('PB25.10',N'Phòng bệnh khoa phẫu thuật 2 giường',2,'K25',N'Phòng bệnh')
	,('PB25.11',N'Phòng bệnh khoa phẫu thuật 3 giường',3,'K25',N'Phòng bệnh')
	,('PB25.12',N'Phòng bệnh khoa phẫu thuật 4 giường',4,'K25',N'Phòng bệnh')
	----------------------Khoa ngoại thần kinh-----------------------------------------

	,('PB26.1',N'Phòng bệnh khoa ngoại thần kinh 1 giường',1,'K26',N'Phòng bệnh')
	,('PB26.2',N'Phòng bệnh khoa ngoại thần kinh 1 giường',1,'K26',N'Phòng bệnh')
	,('PB26.3',N'Phòng bệnh khoa ngoại thần kinh 1 giường',1,'K26',N'Phòng bệnh')
	,('PB26.4',N'Phòng bệnh khoa ngoại thần kinh 1 giường',1,'K26',N'Phòng bệnh')
	,('PB26.5',N'Phòng bệnh khoa ngoại thần kinh 1 giường',1,'K26',N'Phòng bệnh')
	,('PB26.6',N'Phòng bệnh khoa ngoại thần kinh 1 giường',1,'K26',N'Phòng bệnh')

	,('PB26.7',N'Phòng bệnh khoa ngoại thần kinh 2 giường',2,'K26',N'Phòng bệnh')
	,('PB26.8',N'Phòng bệnh khoa ngoại thần kinh 3 giường',3,'K26',N'Phòng bệnh')
	,('PB26.9',N'Phòng bệnh khoa ngoại thần kinh 4 giường',4,'K26',N'Phòng bệnh')
	,('PB26.10',N'Phòng bệnh khoa ngoại thần kinh 2 giường',2,'K26',N'Phòng bệnh')
	,('PB26.11',N'Phòng bệnh khoa ngoại thần kinh 3 giường',3,'K26',N'Phòng bệnh')
	,('PB26.12',N'Phòng bệnh khoa ngoại thần kinh 4 giường',4,'K26',N'Phòng bệnh')

	--------------------Khoa nội thần kinh-------------------------------------------

	,('PB27.1',N'Phòng bệnh khoa nội thần kinh 1 giường',1,'K27',N'Phòng bệnh')
	,('PB27.2',N'Phòng bệnh khoa nội thần kinh 1 giường',1,'K27',N'Phòng bệnh')
	,('PB27.3',N'Phòng bệnh khoa nội thần kinh 1 giường',1,'K27',N'Phòng bệnh')
	,('PB27.4',N'Phòng bệnh khoa nội thần kinh 1 giường',1,'K27',N'Phòng bệnh')
	,('PB27.5',N'Phòng bệnh khoa nội thần kinh 1 giường',1,'K27',N'Phòng bệnh')
	,('PB27.6',N'Phòng bệnh khoa nội thần kinh 1 giường',1,'K27',N'Phòng bệnh')

	,('PB27.7',N'Phòng bệnh khoa nội thần kinh 2 giường',2,'K27',N'Phòng bệnh')
	,('PB27.8',N'Phòng bệnh khoa nội thần kinh 3 giường',3,'K27',N'Phòng bệnh')
	,('PB27.9',N'Phòng bệnh khoa nội thần kinh 4 giường',4,'K27',N'Phòng bệnh')
	,('PB27.10',N'Phòng bệnh khoa nội thần kinh 2 giường',2,'K27',N'Phòng bệnh')
	,('PB27.11',N'Phòng bệnh khoa nội thần kinh 3 giường',3,'K27',N'Phòng bệnh')
	,('PB27.12',N'Phòng bệnh khoa nội thần kinh 4 giường',4,'K27',N'Phòng bệnh')

	--------------------------Khoa dị ứng------------------------------------------------------
	-----------------------------------Khoa truyền nhiễm--------------------------------------

	,('PB29.1',N'Phòng bệnh khoa truyền nhiễm 1 giường',1,'K29',N'Phòng bệnh')
	,('PB29.2',N'Phòng bệnh khoa truyền nhiễm 1 giường',1,'K29',N'Phòng bệnh')
	,('PB29.3',N'Phòng bệnh khoa truyền nhiễm 1 giường',1,'K29',N'Phòng bệnh')
	,('PB29.4',N'Phòng bệnh khoa truyền nhiễm 1 giường',1,'K29',N'Phòng bệnh')
	,('PB29.5',N'Phòng bệnh khoa truyền nhiễm 1 giường',1,'K29',N'Phòng bệnh')
	,('PB29.6',N'Phòng bệnh khoa truyền nhiễm 1 giường',1,'K29',N'Phòng bệnh')

	,('PB29.7',N'Phòng bệnh khoa truyền nhiễm 2 giường',2,'K29',N'Phòng bệnh')
	,('PB29.8',N'Phòng bệnh khoa truyền nhiễm 3 giường',3,'K29',N'Phòng bệnh')
	,('PB29.9',N'Phòng bệnh khoa truyền nhiễm 4 giường',4,'K29',N'Phòng bệnh')
	,('PB29.10',N'Phòng bệnh khoa truyền nhiễm 2 giường',2,'K29',N'Phòng bệnh')
	,('PB29.11',N'Phòng bệnh khoa truyền nhiễm 3 giường',3,'K29',N'Phòng bệnh')
	,('PB29.12',N'Phòng bệnh khoa truyền nhiễm 4 giường',4,'K29',N'Phòng bệnh')


insert into GiuongBenh([MaGiuong],[SoGiuongBenh],[MSPhong])
values
	 ('G01.1',1,'PB01.1')
	,('G01.2',1,'PB01.2')
	,('G01.3',1,'PB01.3')
	,('G01.4',1,'PB01.4')
	,('G01.5.1',1,'PB01.5')
	,('G01.5.2',2,'PB01.5')
	,('G01.6.1',1,'PB01.6')
	,('G01.6.2',2,'PB01.6')
	,('G01.6.3',3,'PB01.6')
	,('G01.7.1',1,'PB01.7')
	,('G01.7.2',2,'PB01.7')
	,('G01.7.3',3,'PB01.7')
	,('G01.7.4',4,'PB01.7')
	,('G01.8.1',1,'PB01.8')
	,('G01.8.2',2,'PB01.8')
	,('G01.9.1',1,'PB01.9')
	,('G01.9.2',2,'PB01.9')
	,('G01.9.3',3,'PB01.9')
	,('G01.10.1',1,'PB01.10')
	,('G01.10.2',2,'PB01.10')
	,('G01.10.3',3,'PB01.10')
	,('G01.10.4',4,'PB01.10')

	----------------------K02--------------------------------
	,('G02.1',1,'PB02.1')
	,('G02.2',1,'PB02.2')
	,('G02.3',1,'PB02.3')
	,('G02.4',1,'PB02.4')
	,('G02.5',1,'PB02.5')
	,('G02.6',1,'PB02.6')
	,('G02.7.1',1,'PB02.7')
	,('G02.7.2',2,'PB02.7')
	,('G02.8.1',1,'PB02.8')
	,('G02.8.2',2,'PB02.8')
	,('G02.8.3',3,'PB02.8')
	,('G02.9.1',1,'PB02.9')
	,('G02.9.2',2,'PB02.9')
	,('G02.9.3',3,'PB02.9')
	,('G02.9.4',4,'PB02.9')
	,('G02.10.1',1,'PB02.10')
	,('G02.10.2',2,'PB02.10')
	--------------------------K03--------------------------------
	,('G03.1',1,'PB03.1')
	,('G03.2',1,'PB03.2')
	,('G03.3',1,'PB03.3')
	,('G03.4.1',1,'PB03.4')
	,('G03.4.2',2,'PB03.4')
	,('G03.5.1',1,'PB03.5')
	,('G03.5.2',2,'PB03.5')
	,('G03.5.3',3,'PB03.5')
	,('G03.6.1',1,'PB03.6')
	,('G03.6.2',2,'PB03.6')
	,('G03.6.3',3,'PB03.6')
	,('G03.6.4',4,'PB03.6')
	,('G03.7.1',1,'PB03.7')
	,('G03.7.2',2,'PB03.7')
	------------------------------K04--------------------------------
	,('G04.1',1,'PB04.1')
	,('G04.2',1,'PB04.2')
	,('G04.3',1,'PB04.3')
	,('G04.7.1',1,'PB04.7')
	,('G04.7.2',2,'PB04.7')
	,('G04.8.1',1,'PB04.8')
	,('G04.8.2',2,'PB04.8')
	,('G04.8.3',3,'PB04.8')
	,('G04.9.1',1,'PB04.9')
	,('G04.9.2',2,'PB04.9')
	,('G04.9.3',3,'PB04.9')
	,('G04.9.4',4,'PB04.9')
	,('G04.10.1',1,'PB04.10')
	,('G04.10.2',2,'PB04.10')
	-------------------------------K05---------------------------------------
	,('G05.1',1,'PB05.1')
	,('G05.2',1,'PB05.2')
	,('G05.3',1,'PB05.3')
	,('G05.7.1',1,'PB05.7')
	,('G05.7.2',2,'PB05.7')
	,('G05.8.1',1,'PB05.8')
	,('G05.8.2',2,'PB05.8')
	,('G05.8.3',3,'PB05.8')
	,('G05.9.1',1,'PB05.9')
	,('G05.9.2',2,'PB05.9')
	,('G05.9.3',3,'PB05.9')
	,('G05.9.4',4,'PB05.9')
	,('G05.10.1',1,'PB05.10')
	,('G05.10.2',2,'PB05.10')
	-------------------------------K06-----------------------------

	,('G06.1',1,'PB06.1')
	,('G06.2',1,'PB06.2')
	,('G06.3',1,'PB06.3')
	,('G06.7.1',1,'PB06.7')
	,('G06.7.2',2,'PB06.7')
	,('G06.8.1',1,'PB06.8')
	,('G06.8.2',2,'PB06.8')
	,('G06.8.3',3,'PB06.8')
	,('G06.9.1',1,'PB06.9')
	,('G06.9.2',2,'PB06.9')
	,('G06.9.3',3,'PB06.9')
	,('G06.9.4',4,'PB06.9')
	,('G06.10.1',1,'PB06.10')
	,('G06.10.2',2,'PB06.10')
----------------------------- ---K07---------------------------------------
	,('G07.1',1,'PB07.1')
	,('G07.2',1,'PB07.2')
	,('G07.3',1,'PB07.3')
	,('G07.4',1,'PB07.4')
	,('G07.5',1,'PB07.5')
	,('G07.6',1,'PB07.6')
	,('G07.7.1',1,'PB07.7')
	,('G07.7.2',2,'PB07.7')
	,('G07.8.1',1,'PB07.8')
	,('G07.8.2',2,'PB07.8')
	,('G07.8.3',3,'PB07.8')
	,('G07.9.1',1,'PB07.9')
	,('G07.9.2',2,'PB07.9')
	,('G07.9.3',3,'PB07.9')
	,('G07.9.4',4,'PB07.9')
-------------------------------K08----------------------------------------
	,('G08.1',1,'PB08.1')
	,('G08.2',1,'PB08.2')
	,('G08.3',1,'PB08.3')
	,('G08.4',1,'PB08.4')
	,('G08.5',1,'PB08.5')
	,('G08.6',1,'PB08.6')
	,('G08.7.1',1,'PB08.7')
	,('G08.7.2',2,'PB08.7')
	,('G08.8.1',1,'PB08.8')
	,('G08.8.2',2,'PB08.8')
	,('G08.8.3',3,'PB08.8')
	,('G08.9.1',1,'PB08.9')
	,('G08.9.2',2,'PB08.9')
	,('G08.9.3',3,'PB08.9')
	,('G08.9.4',4,'PB08.9')
	,('G08.10.1',1,'PB08.10')
	,('G08.10.2',2,'PB08.10')

	----------------------------------------K09-----------------------------
	,('G09.1',1,'PB09.1')
	,('G09.2',1,'PB09.2')
	,('G09.3',1,'PB09.3')
	,('G09.4',1,'PB09.4')
	,('G09.5',1,'PB09.5')
	,('G09.6',1,'PB09.6')
	,('G09.7.1',1,'PB09.7')
	,('G09.7.2',2,'PB09.7')
	,('G09.8.1',1,'PB09.8')
	,('G09.8.2',2,'PB09.8')
	,('G09.8.3',3,'PB09.8')
	,('G09.9.1',1,'PB09.9')
	,('G09.9.2',2,'PB09.9')
	,('G09.9.3',3,'PB09.9')
	,('G09.9.4',4,'PB09.9')
	,('G09.10.1',1,'PB09.10')
	,('G09.10.2',2,'PB09.10')
	,('G09.11.1',1,'PB09.11')
	,('G09.11.2',2,'PB09.11')
	,('G09.11.3',3,'PB09.11')
	,('G09.12.1',1,'PB09.12')
	,('G09.12.2',2,'PB09.12')
	,('G09.12.3',3,'PB09.12')
	,('G09.12.4',4,'PB09.12')

	-------------------------------------K10----------------------------------------

	,('G10.1',1,'PB10.1')
	,('G10.2',1,'PB10.2')
	,('G10.3',1,'PB10.3')
	,('G10.4',1,'PB10.4')
	,('G10.5',1,'PB10.5')
	,('G10.6',1,'PB10.6')
	,('G10.7.1',1,'PB10.7')
	,('G10.7.2',2,'PB10.7')
	,('G10.8.1',1,'PB10.8')
	,('G10.8.2',2,'PB10.8')
	,('G10.8.3',3,'PB10.8')
	,('G10.9.1',1,'PB10.9')
	,('G10.9.2',2,'PB10.9')
	,('G10.9.3',3,'PB10.9')
	,('G10.9.4',4,'PB10.9')
	,('G10.10.1',1,'PB10.10')
	,('G10.10.2',2,'PB10.10')
	,('G10.11.1',1,'PB10.11')
	,('G10.11.2',2,'PB10.11')
	,('G10.11.3',3,'PB10.11')
	,('G10.12.1',1,'PB10.12')
	,('G10.12.2',2,'PB10.12')
	,('G10.12.3',3,'PB10.12')
	,('G10.12.4',4,'PB10.12')
	------------------------------------K11--------------------------------------------

	,('G11.1',1,'PB11.1')
	,('G11.2',1,'PB11.2')
	,('G11.3',1,'PB11.3')
	,('G11.4',1,'PB11.4')
	,('G11.5',1,'PB11.5')
	,('G11.6',1,'PB11.6')
	,('G11.7.1',1,'PB11.7')
	,('G11.7.2',2,'PB11.7')
	,('G11.8.1',1,'PB11.8')
	,('G11.8.2',2,'PB11.8')
	,('G11.8.3',3,'PB11.8')
	,('G11.9.1',1,'PB11.9')
	,('G11.9.2',2,'PB11.9')
	,('G11.9.3',3,'PB11.9')
	,('G11.9.4',4,'PB11.9')
	,('G11.10.1',1,'PB11.10')
	,('G11.10.2',2,'PB11.10')
	,('G11.11.1',1,'PB11.11')
	,('G11.11.2',2,'PB11.11')
	,('G11.11.3',3,'PB11.11')
	,('G11.12.1',1,'PB11.12')
	,('G11.12.2',2,'PB11.12')
	,('G11.12.3',3,'PB11.12')
	,('G11.12.4',4,'PB11.12')

	-----------------------------------K12-------------------------------------------------------

	,('G12.1',1,'PB12.1')
	,('G12.2',1,'PB12.2')
	,('G12.3',1,'PB12.3')
	,('G12.4',1,'PB12.4')
	,('G12.5',1,'PB12.5')
	,('G12.6',1,'PB12.6')
	,('G12.7.1',1,'PB12.7')
	,('G12.7.2',2,'PB12.7')
	,('G12.8.1',1,'PB12.8')
	,('G12.8.2',2,'PB12.8')
	,('G12.8.3',3,'PB12.8')
	,('G12.9.1',1,'PB12.9')
	,('G12.9.2',2,'PB12.9')
	,('G12.9.3',3,'PB12.9')
	,('G12.9.4',4,'PB12.9')
	,('G12.10.1',1,'PB12.10')
	,('G12.10.2',2,'PB12.10')
	,('G12.11.1',1,'PB12.11')
	,('G12.11.2',2,'PB12.11')
	,('G12.11.3',3,'PB12.11')
	,('G12.12.1',1,'PB12.12')
	,('G12.12.2',2,'PB12.12')
	,('G12.12.3',3,'PB12.12')
	,('G12.12.4',4,'PB12.12')

	---------------------------------------K13-------------------------------------------
	,('G13.1',1,'PB13.1')
	,('G13.2',1,'PB13.2')
	,('G13.3',1,'PB13.3')
	,('G13.4',1,'PB13.4')
	,('G13.5',1,'PB13.5')
	,('G13.6',1,'PB13.6')
	,('G13.7.1',1,'PB13.7')
	,('G13.7.2',2,'PB13.7')
	,('G13.8.1',1,'PB13.8')
	,('G13.8.2',2,'PB13.8')
	,('G13.8.3',3,'PB13.8')
	,('G13.9.1',1,'PB13.9')
	,('G13.9.2',2,'PB13.9')
	,('G13.9.3',3,'PB13.9')
	,('G13.9.4',4,'PB13.9')
	,('G13.10.1',1,'PB13.10')
	,('G13.10.2',2,'PB13.10')
	,('G13.11.1',1,'PB13.11')
	,('G13.11.2',2,'PB13.11')
	,('G13.11.3',3,'PB13.11')
	,('G13.12.1',1,'PB13.12')
	,('G13.12.2',2,'PB13.12')
	,('G13.12.3',3,'PB13.12')
	,('G13.12.4',4,'PB13.12')
	-------------------------------------------------K14-------------------------------------------

	,('G14.1',1,'PB14.1')
	,('G14.2',1,'PB14.2')
	,('G14.3',1,'PB14.3')
	,('G14.4',1,'PB14.4')
	,('G14.5',1,'PB14.5')
	,('G14.6',1,'PB14.6')
	,('G14.7.1',1,'PB14.7')
	,('G14.7.2',2,'PB14.7')
	,('G14.8.1',1,'PB14.8')
	,('G14.8.2',2,'PB14.8')
	,('G14.8.3',3,'PB14.8')
	,('G14.9.1',1,'PB14.9')
	,('G14.9.2',2,'PB14.9')
	,('G14.9.3',3,'PB14.9')
	,('G14.9.4',4,'PB14.9')
	,('G14.10.1',1,'PB14.10')
	,('G14.10.2',2,'PB14.10')
	,('G14.11.1',1,'PB14.11')
	,('G14.11.2',2,'PB14.11')
	,('G14.11.3',3,'PB14.11')
	,('G14.12.1',1,'PB14.12')
	,('G14.12.2',2,'PB14.12')
	,('G14.12.3',3,'PB14.12')
	,('G14.12.4',4,'PB14.12')
	-------------------------------------------------K15-------------------------------------------------

	,('G15.1',1,'PB15.1')
	,('G15.2',1,'PB15.2')
	,('G15.3',1,'PB15.3')
	,('G15.4',1,'PB15.4')
	,('G15.5',1,'PB15.5')
	,('G15.6',1,'PB15.6')
	,('G15.7.1',1,'PB15.7')
	,('G15.7.2',2,'PB15.7')
	,('G15.8.1',1,'PB15.8')
	,('G15.8.2',2,'PB15.8')
	,('G15.8.3',3,'PB15.8')
	,('G15.9.1',1,'PB15.9')
	,('G15.9.2',2,'PB15.9')
	,('G15.9.3',3,'PB15.9')
	,('G15.9.4',4,'PB15.9')
	,('G15.10.1',1,'PB15.10')
	,('G15.10.2',2,'PB15.10')
	,('G15.11.1',1,'PB15.11')
	,('G15.11.2',2,'PB15.11')
	,('G15.11.3',3,'PB15.11')
	,('G15.12.1',1,'PB15.12')
	,('G15.12.2',2,'PB15.12')
	,('G15.12.3',3,'PB15.12')
	,('G15.12.4',4,'PB15.12')
	----------------------------------------------K16----------------------------------------------

	,('G16.1',1,'PB16.1')
	,('G16.2',1,'PB16.2')
	,('G16.3',1,'PB16.3')
	,('G16.4',1,'PB16.4')
	,('G16.5',1,'PB16.5')
	,('G16.6',1,'PB16.6')
	,('G16.7.1',1,'PB16.7')
	,('G16.7.2',2,'PB16.7')
	,('G16.8.1',1,'PB16.8')
	,('G16.8.2',2,'PB16.8')
	,('G16.8.3',3,'PB16.8')
	,('G16.9.1',1,'PB16.9')
	,('G16.9.2',2,'PB16.9')
	,('G16.9.3',3,'PB16.9')
	,('G16.9.4',4,'PB16.9')
	,('G16.10.1',1,'PB16.10')
	,('G16.10.2',2,'PB16.10')
	,('G16.11.1',1,'PB16.11')
	,('G16.11.2',2,'PB16.11')
	,('G16.11.3',3,'PB16.11')
	,('G16.12.1',1,'PB16.12')
	,('G16.12.2',2,'PB16.12')
	,('G16.12.3',3,'PB16.12')
	,('G16.12.4',4,'PB16.12')

	---------------------------------------------------K18--------------------------------------------------------
	,('G18.1',1,'PB18.1')
	,('G18.2',1,'PB18.2')
	,('G18.3',1,'PB18.3')
	,('G18.4',1,'PB18.4')
	,('G18.5',1,'PB18.5')
	,('G18.6',1,'PB18.6')
	,('G18.7.1',1,'PB18.7')
	,('G18.7.2',2,'PB18.7')
	,('G18.8.1',1,'PB18.8')
	,('G18.8.2',2,'PB18.8')
	,('G18.8.3',3,'PB18.8')
	,('G18.9.1',1,'PB18.9')
	,('G18.9.2',2,'PB18.9')
	,('G18.9.3',3,'PB18.9')
	,('G18.9.4',4,'PB18.9')
	,('G18.10.1',1,'PB18.10')
	,('G18.10.2',2,'PB18.10')
	,('G18.11.1',1,'PB18.11')
	,('G18.11.2',2,'PB18.11')
	,('G18.11.3',3,'PB18.11')
	,('G18.12.1',1,'PB18.12')
	,('G18.12.2',2,'PB18.12')
	,('G18.12.3',3,'PB18.12')
	,('G18.12.4',4,'PB18.12')
	-----------------------------------------------------K19---------------------------------------------------

	,('G19.1',1,'PB19.1')
	,('G19.2',1,'PB19.2')
	,('G19.3',1,'PB19.3')
	,('G19.4',1,'PB19.4')
	,('G19.5',1,'PB19.5')
	,('G19.6',1,'PB19.6')
	,('G19.7.1',1,'PB19.7')
	,('G19.7.2',2,'PB19.7')
	,('G19.8.1',1,'PB19.8')
	,('G19.8.2',2,'PB19.8')
	,('G19.8.3',3,'PB19.8')
	,('G19.9.1',1,'PB19.9')
	,('G19.9.2',2,'PB19.9')
	,('G19.9.3',3,'PB19.9')
	,('G19.9.4',4,'PB19.9')
	,('G19.10.1',1,'PB19.10')
	,('G19.10.2',2,'PB19.10')
	,('G19.11.1',1,'PB19.11')
	,('G19.11.2',2,'PB19.11')
	,('G19.11.3',3,'PB19.11')
	,('G19.12.1',1,'PB19.12')
	,('G19.12.2',2,'PB19.12')
	,('G19.12.3',3,'PB19.12')
	,('G19.12.4',4,'PB19.12')
	---------------------------------------------------K21--------------------------------------

	,('G21.1',1,'PB21.1')
	,('G21.2',1,'PB21.2')
	,('G21.3',1,'PB21.3')
	,('G21.4',1,'PB21.4')
	,('G21.5',1,'PB21.5')
	,('G21.6',1,'PB21.6')
	,('G21.7.1',1,'PB21.7')
	,('G21.7.2',2,'PB21.7')
	,('G21.8.1',1,'PB21.8')
	,('G21.8.2',2,'PB21.8')
	,('G21.8.3',3,'PB21.8')
	,('G21.9.1',1,'PB21.9')
	,('G21.9.2',2,'PB21.9')
	,('G21.9.3',3,'PB21.9')
	,('G21.9.4',4,'PB21.9')
	,('G21.10.1',1,'PB21.10')
	,('G21.10.2',2,'PB21.10')
	,('G21.11.1',1,'PB21.11')
	,('G21.11.2',2,'PB21.11')
	,('G21.11.3',3,'PB21.11')
	,('G21.12.1',1,'PB21.12')
	,('G21.12.2',2,'PB21.12')
	,('G21.12.3',3,'PB21.12')
	,('G21.12.4',4,'PB21.12')

	---------------------------------------K22---------------------------------------

	,('G22.1',1,'PB22.1')
	,('G22.2',1,'PB22.2')
	,('G22.3',1,'PB22.3')
	,('G22.4',1,'PB22.4')
	,('G22.5',1,'PB22.5')
	,('G22.6',1,'PB22.6')
	,('G22.7.1',1,'PB22.7')
	,('G22.7.2',2,'PB22.7')
	,('G22.8.1',1,'PB22.8')
	,('G22.8.2',2,'PB22.8')
	,('G22.8.3',3,'PB22.8')
	,('G22.9.1',1,'PB22.9')
	,('G22.9.2',2,'PB22.9')
	,('G22.9.3',3,'PB22.9')
	,('G22.9.4',4,'PB22.9')
	,('G22.10.1',1,'PB22.10')
	,('G22.10.2',2,'PB22.10')
	,('G22.11.1',1,'PB22.11')
	,('G22.11.2',2,'PB22.11')
	,('G22.11.3',3,'PB22.11')
	,('G22.12.1',1,'PB22.12')
	,('G22.12.2',2,'PB22.12')
	,('G22.12.3',3,'PB22.12')
	,('G22.12.4',4,'PB22.12')

	-----------------------------------K23--------------------------------------------------------

	,('G23.1',1,'PB23.1')
	,('G23.2',1,'PB23.2')
	,('G23.3',1,'PB23.3')
	,('G23.4',1,'PB23.4')
	,('G23.5',1,'PB23.5')
	,('G23.6',1,'PB23.6')
	,('G23.7.1',1,'PB23.7')
	,('G23.7.2',2,'PB23.7')
	,('G23.8.1',1,'PB23.8')
	,('G23.8.2',2,'PB23.8')
	,('G23.8.3',3,'PB23.8')
	,('G23.9.1',1,'PB23.9')
	,('G23.9.2',2,'PB23.9')
	,('G23.9.3',3,'PB23.9')
	,('G23.9.4',4,'PB23.9')
	,('G23.10.1',1,'PB23.10')
	,('G23.10.2',2,'PB23.10')
	,('G23.11.1',1,'PB23.11')
	,('G23.11.2',2,'PB23.11')
	,('G23.11.3',3,'PB23.11')
	,('G23.12.1',1,'PB23.12')
	,('G23.12.2',2,'PB23.12')
	,('G23.12.3',3,'PB23.12')
	,('G23.12.4',4,'PB23.12')
	-------------------------------------------K24-----------------------------------------------
	,('G24.1',1,'PB24.1')
	,('G24.2',1,'PB24.2')
	,('G24.3',1,'PB24.3')
	,('G24.4',1,'PB24.4')
	,('G24.5',1,'PB24.5')
	,('G24.6',1,'PB24.6')
	,('G24.7.1',1,'PB24.7')
	,('G24.7.2',2,'PB24.7')
	,('G24.8.1',1,'PB24.8')
	,('G24.8.2',2,'PB24.8')
	,('G24.8.3',3,'PB24.8')
	,('G24.9.1',1,'PB24.9')
	,('G24.9.2',2,'PB24.9')
	,('G24.9.3',3,'PB24.9')
	,('G24.9.4',4,'PB24.9')
	,('G24.10.1',1,'PB24.10')
	,('G24.10.2',2,'PB24.10')
	,('G24.11.1',1,'PB24.11')
	,('G24.11.2',2,'PB24.11')
	,('G24.11.3',3,'PB24.11')
	,('G24.12.1',1,'PB24.12')
	,('G24.12.2',2,'PB24.12')
	,('G24.12.3',3,'PB24.12')
	,('G24.12.4',4,'PB24.12')
	-----------------------------------------K25------------------------------------------
	,('G25.1',1,'PB25.1')
	,('G25.2',1,'PB25.2')
	,('G25.3',1,'PB25.3')
	,('G25.4',1,'PB25.4')
	,('G25.5',1,'PB25.5')
	,('G25.6',1,'PB25.6')
	,('G25.7.1',1,'PB25.7')
	,('G25.7.2',2,'PB25.7')
	,('G25.8.1',1,'PB25.8')
	,('G25.8.2',2,'PB25.8')
	,('G25.8.3',3,'PB25.8')
	,('G25.9.1',1,'PB25.9')
	,('G25.9.2',2,'PB25.9')
	,('G25.9.3',3,'PB25.9')
	,('G25.9.4',4,'PB25.9')
	,('G25.10.1',1,'PB25.10')
	,('G25.10.2',2,'PB25.10')
	,('G25.11.1',1,'PB25.11')
	,('G25.11.2',2,'PB25.11')
	,('G25.11.3',3,'PB25.11')
	,('G25.12.1',1,'PB25.12')
	,('G25.12.2',2,'PB25.12')
	,('G25.12.3',3,'PB25.12')
	,('G25.12.4',4,'PB25.12')



	------------------------------------------K26------------------------------------------

	,('G26.1',1,'PB26.1')
	,('G26.2',1,'PB26.2')
	,('G26.3',1,'PB26.3')
	,('G26.4',1,'PB26.4')
	,('G26.5',1,'PB26.5')
	,('G26.6',1,'PB26.6')
	,('G26.7.1',1,'PB26.7')
	,('G26.7.2',2,'PB26.7')
	,('G26.8.1',1,'PB26.8')
	,('G26.8.2',2,'PB26.8')
	,('G26.8.3',3,'PB26.8')
	,('G26.9.1',1,'PB26.9')
	,('G26.9.2',2,'PB26.9')
	,('G26.9.3',3,'PB26.9')
	,('G26.9.4',4,'PB26.9')
	,('G26.10.1',1,'PB26.10')
	,('G26.10.2',2,'PB26.10')
	,('G26.11.1',1,'PB26.11')
	,('G26.11.2',2,'PB26.11')
	,('G26.11.3',3,'PB26.11')
	,('G26.12.1',1,'PB26.12')
	,('G26.12.2',2,'PB26.12')
	,('G26.12.3',3,'PB26.12')
	,('G26.12.4',4,'PB26.12')

	-------------------------------------------K27-------------------------------------------

	,('G27.1',1,'PB27.1')
	,('G27.2',1,'PB27.2')
	,('G27.3',1,'PB27.3')
	,('G27.4',1,'PB27.4')
	,('G27.5',1,'PB27.5')
	,('G27.6',1,'PB27.6')
	,('G27.7.1',1,'PB27.7')
	,('G27.7.2',2,'PB27.7')
	,('G27.8.1',1,'PB27.8')
	,('G27.8.2',2,'PB27.8')
	,('G27.8.3',3,'PB27.8')
	,('G27.9.1',1,'PB27.9')
	,('G27.9.2',2,'PB27.9')
	,('G27.9.3',3,'PB27.9')
	,('G27.9.4',4,'PB27.9')
	,('G27.10.1',1,'PB27.10')
	,('G27.10.2',2,'PB27.10')
	,('G27.11.1',1,'PB27.11')
	,('G27.11.2',2,'PB27.11')
	,('G27.11.3',3,'PB27.11')
	,('G27.12.1',1,'PB27.12')
	,('G27.12.2',2,'PB27.12')
	,('G27.12.3',3,'PB27.12')
	,('G27.12.4',4,'PB27.12')

	--------------------------------------------K28-----------------------------------------------
	------------------------------------------K29-------------------------------------------
	
	,('G29.1',1,'PB29.1')
	,('G29.2',1,'PB29.2')
	,('G29.3',1,'PB29.3')
	,('G29.4',1,'PB29.4')
	,('G29.5',1,'PB29.5')
	,('G29.6',1,'PB29.6')
	,('G29.7.1',1,'PB29.7')
	,('G29.7.2',2,'PB29.7')
	,('G29.8.1',1,'PB29.8')
	,('G29.8.2',2,'PB29.8')
	,('G29.8.3',3,'PB29.8')
	,('G29.9.1',1,'PB29.9')
	,('G29.9.2',2,'PB29.9')
	,('G29.9.3',3,'PB29.9')
	,('G29.9.4',4,'PB29.9')
	,('G29.10.1',1,'PB29.10')
	,('G29.10.2',2,'PB29.10')
	,('G29.11.1',1,'PB29.11')
	,('G29.11.2',2,'PB29.11')
	,('G29.11.3',3,'PB29.11')
	,('G29.12.1',1,'PB29.12')
	,('G29.12.2',2,'PB29.12')
	,('G29.12.3',3,'PB29.12')
	,('G29.12.4',4,'PB29.12')

insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],[KinhNghiem])
values
	 ('CN01.1','BS01',null)
	,('CN01.1','BS111',null)
	,('CN01.2','BS02',null)
	,('CN01.2','BS112',null)
	,('CN01.1','BS03',null)
	,('CN01.2','BS03',null)
	,('CN01.2','BS07',null)
	,('CN01.1','TK01',null)
	,('CN01.2','YT01',null)
	,('CN01.1','YT01',null)
	,('CN01.1','YT02',null)
	,('CN01.2','YT04',null)
	
	,('CN01.1','BS145',null)
	,('CN01.1','BS146',null)
	,('CN01.1','BS147',null)
	,('CN01.1','BS148',null)
	,('CN01.2','BS149',null)
	,('CN01.2','BS150',null)
	,('CN01.2','BS151',null)
	,('CN01.2','BS152',null)
	,('CN01.2','BS153',null)
	
	,('CN01.1','BS434',null)
	,('CN01.1','BS435',null)
	,('CN01.1','BS436',null)
	,('CN01.1','BS437',null)
	,('CN01.1','BS438',null)
	,('CN01.1','BS439',null)
	,('CN01.1','BS440',null)
	,('CN01.2','BS441',null)
	,('CN01.2','BS442',null)
	,('CN01.2','BS443',null)
	,('CN01.2','BS444',null)
	,('CN01.2','BS445',null)
	,('CN01.2','BS446',null)
	,('CN01.2','BS447',null)
	,('CN01.1','BS448',null)

	,('CN01.1','YT148',null)
	,('CN01.1','YT149',null)
	,('CN01.1','YT150',null)
	,('CN01.2','YT151',null)
	,('CN01.2','YT152',null)
	------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN02.1','BS04',null)
	,('CN02.2','BS05',null)
	,('CN02.3','BS04',null)
	,('CN02.2','BS04',null)
	,('CN02.3','BS06',null)
	,('CN02.1','BS08',null)
	,('CN02.3','BS10',null)
	,('CN02.1','TK02',null)
	,('CN02.2','TK02',null)
	,('CN02.3','YT05',null)
	,('CN02.2','YT06',null)
	,('CN02.1','YT07',null)
	,('CN02.2','YT08',null)
	,('CN02.3','YT09',null)
	,('CN02.1','YT10',null)
	,('CN02.4','TK02',null)
	,('CN02.4','BS10',null)
	,('CN02.4','BS109',null)
	,('CN02.4','BS110',null)
	,('CN02.4','YT10',null)
	,('CN02.4','YT06',null)

	,('CN02.1','BS154',null)
	,('CN02.1','BS155',null)
	,('CN02.2','BS156',null)
	,('CN02.2','BS157',null)
	,('CN02.3','BS158',null)
	,('CN02.3','BS159',null)
	,('CN02.4','BS160',null)
	,('CN02.4','BS161',null)

	,('CN02.1','BS454',null)
	,('CN02.1','BS455',null)
	,('CN02.4','BS456',null)
	,('CN02.2','BS457',null)
	,('CN02.2','BS458',null)
	,('CN02.4','BS459',null)
	,('CN02.4','BS460',null)
	,('CN02.4','BS461',null)
	,('CN02.3','BS462',null)
	,('CN02.3','BS463',null)
	,('CN02.4','BS464',null)
	,('CN02.3','BS465',null)
	,('CN02.1','BS466',null)
	,('CN02.2','BS467',null)
	,('CN02.3','BS468',null)

	,('CN02.1','YT153',null)
	,('CN02.1','YT154',null)
	,('CN02.2','YT155',null)
	,('CN02.3','YT156',null)
	,('CN02.3','YT157',null)
	--------------------------------
	,('CN03.1','BS11',null)
	,('CN03.1','BS13',null)
	,('CN03.1','BS113',null)
	,('CN03.1','YT11',null)
	,('CN03.1','YT12',null)
	,('CN03.2','BS12',null)
	,('CN03.2','BS14',null)
	,('CN03.2','BS114',null)
	,('CN03.2','YT13',null)

	,('CN03.1','BS162',null)
	,('CN03.1','BS163',null)
	,('CN03.1','BS164',null)
	,('CN03.1','BS165',null)
	,('CN03.2','BS166',null)
	,('CN03.2','BS167',null)
	,('CN03.2','BS168',null)
	,('CN03.2','BS169',null)

	,('CN03.1','BS474',null)
	,('CN03.1','BS475',null)
	,('CN03.1','BS476',null)
	,('CN03.1','BS477',null)
	,('CN03.1','BS478',null)
	,('CN03.1','BS479',null)
	,('CN03.1','BS480',null)
	,('CN03.2','BS481',null)
	,('CN03.2','BS482',null)
	,('CN03.2','BS483',null)
	,('CN03.2','BS484',null)
	,('CN03.2','BS485',null)
	,('CN03.2','BS486',null)
	,('CN03.2','BS487',null)
	,('CN03.2','BS488',null)

	,('CN03.1','YT158',null)
	,('CN03.1','YT159',null)
	,('CN03.1','YT160',null)
	,('CN03.2','YT161',null)
	,('CN03.2','YT162',null)
	---------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN04.1','BS494',null)
	,('CN04.1','BS495',null)
	,('CN04.1','BS496',null)
	,('CN04.1','BS497',null)
	,('CN04.1','BS498',null)
	,('CN04.1','BS499',null)
	,('CN04.1','BS500',null)
	,('CN04.1','BS501',null)
	,('CN04.1','BS502',null)
	,('CN04.1','BS503',null)
	,('CN04.1','YT163',null)
	,('CN04.1','YT164',null)
	,('CN04.1','YT14',null)
	,('CN04.1','YT15',null)
	,('CN04.1','YT16',null)
	,('CN04.1','BS115',null)
	,('CN04.1','BS116',null)
	,('CN04.1','BS15',null)
	,('CN04.1','BS16',null)
	,('CN04.1','BS17',null)
	,('CN04.1','BS170',null)
	,('CN04.1','BS171',null)
	,('CN04.1','BS172',null)
	,('CN04.1','BS173',null)
	,('CN04.1','BS174',null)
	,('CN04.1','BS182',null)
	,('CN04.1','BS183',null)
	,('CN04.1','BS184',null)

	,('CN04.2','BS503',null)
	,('CN04.2','BS504',null)
	,('CN04.2','BS505',null)
	,('CN04.2','BS506',null)
	,('CN04.2','BS507',null)
	,('CN04.2','BS508',null)
	,('CN04.2','TK04',null)
	,('CN04.2','YT165',null)
	,('CN04.2','YT166',null)
	,('CN04.2','YT167',null)
	,('CN04.2','YT95',null)
	,('CN04.2','YT96',null)
	,('CN04.2','BS175',null)
	,('CN04.2','BS176',null)
	,('CN04.2','BS177',null)
	,('CN04.2','BS178',null)
	,('CN04.2','BS18',null)
	,('CN04.2','BS180',null)
	,('CN04.2','BS185',null)
	-----------------------------------
	,('CN05.1','BS19',null)
	,('CN05.1','BS117',null)
	,('CN05.1','BS22',null)
	,('CN05.1','YT19',null)
	,('CN05.1','YT20',null)
	,('CN05.2','BS20',null)
	,('CN05.2','TK05',null)
	,('CN05.2','YT18',null)
	,('CN05.2','YT19',null)
	,('CN05.3','BS20',null)
	,('CN05.3','BS21',null)
	,('CN05.3','YT18',null)
	,('CN05.4','BS20',null)
	,('CN05.4','BS21',null)
	,('CN05.4','YT18',null)
	,('CN05.4','BS118',null)

	,('CN05.1','BS186',null)
	,('CN05.1','BS187',null)
	,('CN05.2','BS188',null)
	,('CN05.2','BS189',null)
	,('CN05.3','BS190',null)
	,('CN05.3','BS191',null)
	,('CN05.3','BS192',null)
	,('CN05.3','BS193',null)

	,('CN05.1','BS514',null)
	,('CN05.1','BS515',null)
	,('CN05.1','BS516',null)
	,('CN05.2','BS517',null)
	,('CN05.2','BS518',null)
	,('CN05.2','BS519',null)
	,('CN05.3','BS520',null)
	,('CN05.3','BS521',null)
	,('CN05.3','BS522',null)
	,('CN05.4','BS523',null)
	,('CN05.4','BS524',null)
	,('CN05.4','BS525',null)
	,('CN05.1','BS526',null)
	,('CN05.2','BS527',null)
	,('CN05.3','BS528',null)

	,('CN05.1','YT168',null)
	,('CN05.1','YT169',null)
	,('CN05.2','YT170',null)
	,('CN05.3','YT171',null)
	,('CN05.4','YT172',null)
	------------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN06.1','BS25',null)
	,('CN06.1','BS119',null)
	,('CN06.1','TK06',null)
	,('CN06.1','YT21',null)
	,('CN06.1','YT22',null)
	,('CN06.2','BS24',null)
	,('CN06.2','BS120',null)
	,('CN06.2','TK06',null)
	,('CN06.2','YT23',null)
	
	,('CN06.1','BS194',null)
	,('CN06.1','BS195',null)
	,('CN06.1','BS196',null)
	,('CN06.1','BS197',null)
	,('CN06.2','BS198',null)
	,('CN06.2','BS199',null)
	,('CN06.2','BS200',null)
	,('CN06.2','BS201',null)
	,('CN06.2','BS202',null)
	
	,('CN06.1','BS534',null)
	,('CN06.1','BS535',null)
	,('CN06.1','BS536',null)
	,('CN06.1','BS537',null)
	,('CN06.1','BS538',null)
	,('CN06.1','BS539',null)
	,('CN06.1','BS540',null)
	,('CN06.1','BS541',null)
	,('CN06.1','YT173',null)
	,('CN06.1','YT174',null)
	,('CN06.1','YT175',null)

	,('CN06.2','BS542',null)
	,('CN06.2','BS543',null)
	,('CN06.2','BS544',null)
	,('CN06.2','BS545',null)
	,('CN06.2','BS546',null)
	,('CN06.2','BS547',null)
	,('CN06.2','BS548',null)
	,('CN06.2','YT176',null)
	,('CN06.2','YT177',null)
	------------------------------------
	,('CN07.1','BS26',null)
	,('CN07.1','YT24',null)
	,('CN07.1','BS29',null)
	,('CN07.1','YT25',null)
	,('CN07.2','TK07',null)
	,('CN07.2','BS121',null)
	,('CN07.2','BS28',null)
	,('CN07.2','YT25',null)
	,('CN07.2','YT24',null)
	,('CN07.3','BS27',null)
	,('CN07.3','YT25',null)

	,('CN07.1','BS203',null)
	,('CN07.1','BS204',null)
	,('CN07.1','BS205',null)
	,('CN07.2','BS206',null)
	,('CN07.2','BS207',null)
	,('CN07.2','BS208',null)
	,('CN07.3','BS209',null)
	,('CN07.1','BS210',null)
	,('CN07.1','BS211',null)

	,('CN07.1','BS554',null)
	,('CN07.1','BS555',null)
	,('CN07.1','BS556',null)
	,('CN07.1','BS557',null)
	,('CN07.2','BS558',null)
	,('CN07.2','BS559',null)
	,('CN07.2','BS560',null)
	,('CN07.2','BS561',null)
	,('CN07.3','BS562',null)
	,('CN07.3','BS563',null)
	,('CN07.3','BS564',null)
	,('CN07.3','BS565',null)
	,('CN07.1','BS566',null)
	,('CN07.2','BS567',null)
	,('CN07.3','BS568',null)

	,('CN07.1','YT178',null)
	,('CN07.2','YT179',null)
	,('CN07.3','YT180',null)
	,('CN07.1','YT181',null)
	,('CN07.3','YT182',null)
	-----------------------------------
	,('CN08.1','BS30',null)
	,('CN08.1','BS34',null)
	,('CN08.1','BS31',null)
	,('CN08.1','YT26',null)
	,('CN08.1','YT27',null)
	,('CN08.2','BS32',null)
	,('CN08.2','BS33',null)
	,('CN08.2','YT28',null)
	,('CN08.3','TK08',null)
	,('CN08.3','YT26',null)
	,('CN08.3','BS34',null)

	,('CN08.1','BS212',null)
	,('CN08.1','BS213',null)
	,('CN08.1','BS214',null)
	,('CN08.2','BS215',null)
	,('CN08.2','BS216',null)
	,('CN08.2','BS217',null)
	,('CN08.3','BS218',null)
	,('CN08.3','BS219',null)
	,('CN08.3','BS220',null)
	
	,('CN08.1','BS574',null)
	,('CN08.1','BS575',null)
	,('CN08.1','BS576',null)
	,('CN08.1','BS577',null)
	,('CN08.1','BS578',null)
	,('CN08.2','BS579',null)
	,('CN08.2','BS580',null)
	,('CN08.2','BS581',null)
	,('CN08.2','BS582',null)
	,('CN08.2','BS583',null)
	,('CN08.3','BS584',null)
	,('CN08.3','BS585',null)
	,('CN08.3','BS586',null)
	,('CN08.3','BS587',null)
	,('CN08.3','BS588',null)

	,('CN08.1','YT183',null)
	,('CN08.2','YT184',null)
	,('CN08.2','YT185',null)
	,('CN08.3','YT186',null)
	,('CN08.3','YT187',null)
	-------------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN09.1','BS35',null)
	,('CN09.1','BS38',null)
	,('CN09.1','YT29',null)
	,('CN09.2','BS36',null)
	,('CN09.2','BS37',null)
	,('CN09.2','YT30',null)
	,('CN09.3','TK09',null)
	,('CN09.3','YT31',null)
	,('CN09.3','BS38',null)

	,('CN09.1','BS221',null)
	,('CN09.1','BS222',null)
	,('CN09.1','BS227',null)
	,('CN09.2','BS223',null)
	,('CN09.2','BS224',null)
	,('CN09.2','BS228',null)
	,('CN09.3','BS225',null)
	,('CN09.3','BS226',null)
	,('CN09.3','BS229',null)

	,('CN09.1','BS594',null)
	,('CN09.1','BS595',null)
	,('CN09.1','BS596',null)
	,('CN09.1','BS597',null)
	,('CN09.1','BS598',null)
	,('CN09.2','BS599',null)
	,('CN09.2','BS600',null)
	,('CN09.2','BS601',null)
	,('CN09.2','BS602',null)
	,('CN09.2','BS603',null)
	,('CN09.3','BS604',null)
	,('CN09.3','BS605',null)
	,('CN09.3','BS606',null)
	,('CN09.3','BS607',null)
	,('CN09.3','BS608',null)

	,('CN09.1','YT188',null)
	,('CN09.1','YT189',null)
	,('CN09.2','YT190',null)
	,('CN09.2','YT191',null)
	,('CN09.3','YT192',null)

	--------------------------------------
	,('CN10.1','BS39',null)
	,('CN10.1','YT32',null)
	,('CN10.1','BS40',null)
	,('CN10.2','BS42',null)
	,('CN10.2','YT34',null)
	,('CN10.2','TK10',null)
	,('CN10.3','BS41',null)
	,('CN10.3','BS39',null)
	,('CN10.3','YT33',null)

	,('CN10.1','BS231',null)
	,('CN10.1','BS232',null)
	,('CN10.1','BS233',null)
	,('CN10.2','BS234',null)
	,('CN10.2','BS235',null)
	,('CN10.2','BS236',null)
	,('CN10.3','BS237',null)
	,('CN10.3','BS238',null)
	,('CN10.3','BS239',null)
	,('CN10.3','BS240',null)

	,('CN10.1','BS701',null)
	,('CN10.1','BS702',null)
	,('CN10.1','BS703',null)
	,('CN10.1','BS704',null)
	,('CN10.1','BS705',null)
	,('CN10.2','BS706',null)
	,('CN10.2','BS707',null)
	,('CN10.2','BS708',null)
	,('CN10.2','BS709',null)
	,('CN10.2','BS710',null)
	,('CN10.3','BS711',null)
	,('CN10.3','BS712',null)
	,('CN10.3','BS713',null)
	,('CN10.3','BS714',null)
	,('CN10.3','BS715',null)
	
	,('CN10.1','YT193',null)
	,('CN10.1','YT194',null)
	,('CN10.1','YT195',null)
	,('CN10.2','YT196',null)
	,('CN10.2','YT197',null)
	,('CN10.3','YT196',null)
	,('CN10.3','YT195',null)

	-------------------------------------
	,('CN11.1','BS43',null)
	,('CN11.1','BS45',null)
	,('CN11.1','BS46',null)
	,('CN11.1','TK11',null)
	,('CN11.1','YT35',null)
	,('CN11.1','YT36',null)
	,('CN11.2','BS43',null)
	,('CN11.2','BS45',null)
	,('CN11.2','BS46',null)
	,('CN11.2','TK11',null)
	,('CN11.2','YT35',null)
	,('CN11.2','YT36',null)
	,('CN11.2','YT37',null)

	,('CN11.1','BS241',null)
	,('CN11.1','BS242',null)
	,('CN11.1','BS243',null)
	,('CN11.1','BS244',null)
	,('CN11.1','BS245',null)
	,('CN11.2','BS246',null)
	,('CN11.2','BS247',null)
	,('CN11.2','BS248',null)
	,('CN11.2','BS249',null)
	,('CN11.2','BS250',null)

	,('CN11.1','BS721',null)
	,('CN11.1','BS722',null)
	,('CN11.1','BS723',null)
	,('CN11.1','BS724',null)
	,('CN11.1','BS725',null)
	,('CN11.1','BS726',null)
	,('CN11.1','BS727',null)
	,('CN11.1','BS728',null)
	,('CN11.2','BS729',null)
	,('CN11.2','BS730',null)
	,('CN11.2','BS731',null)
	,('CN11.2','BS732',null)
	,('CN11.2','BS733',null)
	,('CN11.2','BS734',null)
	,('CN11.2','BS735',null)

	,('CN11.1','YT198',null)
	,('CN11.1','YT199',null)
	,('CN11.2','YT200',null)
	,('CN11.2','YT201',null)
	,('CN11.2','YT202',null)
	-------------------------------------
	,('CN12.1','BS47',null)
	,('CN12.1','BS48',null)
	,('CN12.1','YT40',null)
	,('CN12.1','YT38',null)
	,('CN12.2','BS49',null)
	,('CN12.2','TK12',null)
	,('CN12.2','YT39',null)
	,('CN12.2','YT38',null)

	,('CN12.1','BS251',null)
	,('CN12.1','BS252',null)
	,('CN12.1','BS253',null)
	,('CN12.1','BS254',null)
	,('CN12.1','BS255',null)
	,('CN12.2','BS256',null)
	,('CN12.2','BS257',null)
	,('CN12.2','BS258',null)
	,('CN12.2','BS259',null)
	,('CN12.2','BS260',null)
	,('CN12.2','BS261',null)

	,('CN12.1','BS741',null)
	,('CN12.1','BS742',null)
	,('CN12.1','BS743',null)
	,('CN12.1','BS744',null)
	,('CN12.1','BS745',null)
	,('CN12.1','BS746',null)
	,('CN12.1','BS747',null)
	,('CN12.2','BS748',null)
	,('CN12.2','BS749',null)
	,('CN12.2','BS750',null)
	,('CN12.2','BS751',null)
	,('CN12.2','BS752',null)
	,('CN12.2','BS753',null)
	,('CN12.2','BS754',null)
	,('CN12.2','BS755',null)

	,('CN12.1','YT203',null)
	,('CN12.1','YT204',null)
	,('CN12.2','YT205',null)
	,('CN12.2','YT206',null)
	,('CN12.2','YT207',null)
	--------------------------------------
go
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN13.1','BS50',null)
	,('CN13.1','BS122',null)
	,('CN13.1','YT41',null)
	,('CN13.1','YT42',null)
	,('CN13.2','BS51',null)
	,('CN13.2','BS144',null)
	,('CN13.2','TK13',null)
	,('CN13.2','YT43',null)
	,('CN13.2','YT41',null)

	,('CN13.1','BS262',null)
	,('CN13.1','BS263',null)
	,('CN13.1','BS264',null)
	,('CN13.1','BS265',null)
	,('CN13.1','BS271',null)
	,('CN13.2','BS266',null)
	,('CN13.2','BS267',null)
	,('CN13.2','BS268',null)
	,('CN13.2','BS269',null)
	,('CN13.2','BS270',null)

	,('CN13.1','BS761',null)
	,('CN13.1','BS762',null)
	,('CN13.1','BS763',null)
	,('CN13.1','BS764',null)
	,('CN13.1','BS765',null)
	,('CN13.1','BS766',null)
	,('CN13.1','BS767',null)
	,('CN13.1','BS768',null)
	,('CN13.2','BS769',null)
	,('CN13.2','BS770',null)
	,('CN13.2','BS771',null)
	,('CN13.2','BS772',null)
	,('CN13.2','BS773',null)
	,('CN13.2','BS774',null)
	,('CN13.2','BS775',null)

	,('CN13.1','YT208',null)
	,('CN13.1','YT209',null)
	,('CN13.2','YT210',null)
	,('CN13.2','YT211',null)
	,('CN13.2','YT212',null)
	--------------------------------------
	,('CN14.1','BS57',null)
	,('CN14.1','BS60',null)
	,('CN14.1','YT44',null)
	,('CN14.1','YT45',null)
	,('CN14.1','BS58',null)
	,('CN14.1','TK14',null)
	,('CN14.1','BS59',null)
	,('CN14.1','YT46',null)

	,('CN14.1','BS272',null)
	,('CN14.1','BS273',null)
	,('CN14.1','BS274',null)
	,('CN14.1','BS275',null)
	,('CN14.1','BS276',null)
	,('CN14.1','BS277',null)
	,('CN14.1','BS278',null)
	,('CN14.1','BS279',null)
	,('CN14.1','BS280',null)
	,('CN14.1','BS281',null)
	
	,('CN14.1','YT213',null)
	,('CN14.1','YT214',null)
	,('CN14.1','YT215',null)
	,('CN14.1','YT216',null)
	,('CN14.1','YT217',null)
	,('CN14.1','BS781',null)
	,('CN14.1','BS782',null)
	,('CN14.1','BS783',null)
	,('CN14.1','BS784',null)
	,('CN14.1','BS785',null)
	,('CN14.1','BS786',null)
	,('CN14.1','BS787',null)
	,('CN14.1','BS788',null)
	,('CN14.1','BS789',null)
	,('CN14.1','BS790',null)
	,('CN14.1','BS791',null)
	,('CN14.1','BS792',null)
	,('CN14.1','BS793',null)
	,('CN14.1','BS794',null)
	,('CN14.1','BS795',null)
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	----------------------------------
	 ('CN15.1','BS61',null)
	,('CN15.1','BS123',null)
	,('CN15.1','BS63',null)
	,('CN15.1','YT47',null)
	,('CN15.1','YT49',null)
	,('CN15.2','BS62',null)
	,('CN15.2','BS124',null)
	,('CN15.2','TK15',null)
	,('CN15.2','YT48',null)
	,('CN15.2','YT49',null)

	,('CN15.1','BS282',null)
	,('CN15.1','BS283',null)
	,('CN15.1','BS284',null)
	,('CN15.1','BS285',null)
	,('CN15.1','BS291',null)
	,('CN15.2','BS286',null)
	,('CN15.2','BS287',null)
	,('CN15.2','BS288',null)
	,('CN15.2','BS289',null)
	,('CN15.2','BS290',null)

	,('CN15.1','BS801',null)
	,('CN15.1','BS802',null)
	,('CN15.1','BS803',null)
	,('CN15.1','BS804',null)
	,('CN15.1','BS805',null)
	,('CN15.1','BS806',null)
	,('CN15.1','BS807',null)
	,('CN15.1','BS808',null)
	,('CN15.2','BS809',null)
	,('CN15.2','BS810',null)
	,('CN15.2','BS811',null)
	,('CN15.2','BS812',null)
	,('CN15.2','BS813',null)
	,('CN15.2','BS814',null)
	,('CN15.2','BS815',null)
	,('CN15.1','YT218',null)
	,('CN15.1','YT219',null)
	,('CN15.2','YT220',null)
	,('CN15.2','YT221',null)
	,('CN15.2','YT222',null)
	------------------------------------
	,('CN16.1','BS64',null)
	,('CN16.1','BS66',null)
	,('CN16.1','YT50',null)
	,('CN16.2','BS65',null)
	,('CN16.2','BS125',null)
	,('CN16.2','TK16',null)
	,('CN16.2','YT51',null)
	,('CN16.1','YT52',null)

	,('CN16.1','BS292',null)
	,('CN16.1','BS293',null)
	,('CN16.1','BS294',null)
	,('CN16.1','BS295',null)
	,('CN16.1','BS296',null)
	,('CN16.2','BS297',null)
	,('CN16.2','BS298',null)
	,('CN16.2','BS299',null)
	,('CN16.2','BS300',null)
	,('CN16.2','BS301',null)

	,('CN16.1','BS841',null)
	,('CN16.1','BS842',null)
	,('CN16.1','BS843',null)
	,('CN16.1','BS844',null)
	,('CN16.1','BS845',null)
	,('CN16.1','BS846',null)
	,('CN16.1','BS847',null)
	,('CN16.1','BS848',null)
	,('CN16.2','BS849',null)
	,('CN16.2','BS850',null)
	,('CN16.2','BS851',null)
	,('CN16.2','BS852',null)
	,('CN16.2','BS853',null)
	,('CN16.2','BS854',null)
	,('CN16.2','BS855',null)

	,('CN16.1','YT223',null)
	,('CN16.1','YT224',null)
	,('CN16.2','YT225',null)
	,('CN16.2','YT226',null)
	,('CN16.1','YT227',null)
	------------------------------------
	,('CN18.1','BS70',null)
	,('CN18.1','BS126',null)
	,('CN18.1','TK18',null)
	,('CN18.1','YT56',null)
	,('CN18.1','YT58',null)
	,('CN18.2','BS72',null)
	,('CN18.2','BS71',null)
	,('CN18.2','YT57',null)
	,('CN18.2','YT58',null)

	,('CN18.1','BS313',null)
	,('CN18.1','BS314',null)
	,('CN18.1','BS315',null)
	,('CN18.1','BS316',null)
	,('CN18.1','BS317',null)
	,('CN18.2','BS318',null)
	,('CN18.2','BS319',null)
	,('CN18.2','BS320',null)
	,('CN18.2','BS321',null)
	,('CN18.2','BS322',null)

	,('CN18.1','BS921',null)
	,('CN18.1','BS922',null)
	,('CN18.1','BS923',null)
	,('CN18.1','BS924',null)
	,('CN18.1','BS925',null)
	,('CN18.1','BS926',null)
	,('CN18.1','BS927',null)
	,('CN18.2','BS928',null)
	,('CN18.2','BS929',null)
	,('CN18.2','BS930',null)
	,('CN18.2','BS931',null)
	,('CN18.2','BS932',null)
	,('CN18.2','BS933',null)
	,('CN18.2','BS934',null)
	,('CN18.2','BS935',null)

	,('CN18.1','YT233',null)
	,('CN18.1','YT234',null)
	,('CN18.2','YT235',null)
	,('CN18.2','YT236',null)
	,('CN18.2','YT237',null)
	------------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN19.1','BS73',null)
	,('CN19.1','BS74',null)
	,('CN19.1','BS76',null)
	,('CN19.1','YT59',null)
	,('CN19.1','YT60',null)
	,('CN19.2','BS74',null)
	,('CN19.2','BS75',null)
	,('CN19.2','BS77',null)
	,('CN19.2','YT61',null)
	,('CN19.2','YT59',null)
	,('CN19.3','BS79',null)
	,('CN19.3','BS76',null)
	,('CN19.3','BS77',null)
	,('CN19.3','YT59',null)
	,('CN19.3','YT60',null)
	,('CN19.4','TK19',null)
	,('CN19.4','BS73',null)
	,('CN19.4','BS74',null)
	,('CN19.4','YT60',null)
	,('CN19.4','YT61',null)

	,('CN19.1','BS941',null)
	,('CN19.1','BS942',null)
	,('CN19.2','BS943',null)
	,('CN19.2','BS944',null)
	,('CN19.3','BS945',null)
	,('CN19.3','BS946',null)
	,('CN19.4','BS947',null)
	,('CN19.4','BS948',null)
	,('CN19.1','BS949',null)
	,('CN19.1','BS950',null)
	,('CN19.2','BS951',null)
	,('CN19.2','BS952',null)
	,('CN19.3','BS953',null)
	,('CN19.3','BS954',null)
	,('CN19.4','BS955',null)

	,('CN19.1','YT238',null)
	,('CN19.1','YT239',null)
	,('CN19.2','YT238',null)
	,('CN19.2','YT240',null)
	,('CN19.3','YT241',null)
	,('CN19.3','YT242',null)
	,('CN19.4','YT241',null)
	,('CN19.4','YT240',null)
	,('CN19.1','BS323',null)
	,('CN19.1','BS324',null)
	,('CN19.2','BS325',null)
	,('CN19.2','BS326',null)
	,('CN19.3','BS327',null)
	,('CN19.3','BS328',null)
	,('CN19.3','BS329',null)
	------------------------------------
	,('CN20.1','BS80',null)
	,('CN20.1','YT62',null)
	,('CN20.1','BS81',null)
	,('CN20.1','BS82',null)
	,('CN20.1','YT63',null)
	,('CN20.1','TK20',null)
	,('CN20.1','YT64',null)

	,('CN20.1','BS330',null)
	,('CN20.1','BS331',null)
	,('CN20.1','BS332',null)
	,('CN20.1','BS333',null)
	,('CN20.1','BS334',null)
	,('CN20.1','BS335',null)
	,('CN20.1','BS336',null)
	,('CN20.1','BS337',null)
	,('CN20.1','BS338',null)
	,('CN20.1','BS339',null)
	,('CN20.1','BS340',null)

	,('CN20.1','BS961',null)
	,('CN20.1','BS962',null)
	,('CN20.1','BS963',null)
	,('CN20.1','BS964',null)
	,('CN20.1','BS965',null)
	,('CN20.1','BS966',null)
	,('CN20.1','BS967',null)
	,('CN20.1','BS968',null)
	,('CN20.1','BS969',null)
	,('CN20.1','BS970',null)
	,('CN20.1','BS971',null)
	,('CN20.1','BS972',null)
	,('CN20.1','BS973',null)
	,('CN20.1','BS974',null)
	,('CN20.1','BS975',null)

	,('CN20.1','YT243',null)
	,('CN20.1','YT244',null)
	,('CN20.1','YT245',null)
	,('CN20.1','YT246',null)
	,('CN20.1','YT247',null)
	------------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN21.1','BS83',null)
	,('CN21.1','BS84',null)
	,('CN21.1','BS127',null)
	,('CN21.1','YT65',null)
	,('CN21.1','YT66',null)
	,('CN21.2','BS85',null)
	,('CN21.2','BS86',null)
	,('CN21.2','YT67',null)
	,('CN21.2','YT66',null)
		
	,('CN21.1','BS341',null)
	,('CN21.1','BS342',null)
	,('CN21.1','BS347',null)
	,('CN21.2','BS343',null)
	,('CN21.2','BS344',null)
	,('CN21.2','BS348',null)
	,('CN21.4','BS345',null)
	,('CN21.4','BS346',null)

	,('CN21.1','BS981',null)
	,('CN21.1','BS982',null)
	,('CN21.1','BS983',null)
	,('CN21.1','BS984',null)
	,('CN21.1','BS985',null)
	,('CN21.2','BS986',null)
	,('CN21.2','BS987',null)
	,('CN21.2','BS988',null)
	,('CN21.2','BS989',null)
	,('CN21.2','BS990',null)
	,('CN21.4','BS991',null)
	,('CN21.4','BS992',null)
	,('CN21.4','BS993',null)
	,('CN21.4','BS994',null)
	,('CN21.4','BS995',null)

	,('CN21.1','YT248',null)
	,('CN21.1','YT249',null)
	,('CN21.2','YT250',null)
	,('CN21.2','YT251',null)
	,('CN21.4','YT252',null)
	,('CN21.4','YT249',null)
	
	------------------------------------
	------------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN22.1','BS108',null)
	,('CN22.1','BS129',null)
	,('CN22.1','BS87',null)
	,('CN22.1','YT68',null)
	,('CN22.2','BS88',null)
	,('CN22.2','BS130',null)
	,('CN22.2','BS108',null)
	,('CN22.2','YT70',null)
	,('CN22.3','TK22',null)
	,('CN22.3','BS131',null)
	,('CN22.3','YT69',null)

	,('CN22.1','BS349',null)
	,('CN22.1','BS350',null)
	,('CN22.1','BS351',null)
	,('CN22.2','BS352',null)
	,('CN22.2','BS353',null)
	,('CN22.2','BS354',null)
	,('CN22.3','BS355',null)
	,('CN22.3','BS356',null)

	,('CN22.1','BS1001',null)
	,('CN22.1','BS1002',null)
	,('CN22.1','BS1003',null)
	,('CN22.1','BS1004',null)
	,('CN22.1','BS1005',null)
	,('CN22.2','BS1006',null)
	,('CN22.2','BS1007',null)
	,('CN22.2','BS1008',null)
	,('CN22.2','BS1009',null)
	,('CN22.2','BS1010',null)
	,('CN22.3','BS1011',null)
	,('CN22.3','BS1012',null)
	,('CN22.3','BS1013',null)
	,('CN22.3','BS1014',null)
	,('CN22.3','BS1015',null)

	,('CN22.1','YT253',null)
	,('CN22.1','YT254',null)
	,('CN22.2','YT255',null)
	,('CN22.2','YT256',null)
	,('CN22.3','YT257',null)
	,('CN22.3','YT255',null)
	------------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN23.1','BS80',null)
	,('CN23.1','BS132',null)
	,('CN23.1','YT71',null)
	,('CN23.2','BS90',null)
	,('CN23.2','BS133',null)
	,('CN23.2','TK23',null)
	,('CN23.2','YT72',null)
	,('CN23.2','YT73',null)

	,('CN23.1','BS357',null)
	,('CN23.1','BS358',null)
	,('CN23.1','BS359',null)
	,('CN23.1','BS360',null)
	,('CN23.1','BS361',null)
	,('CN23.2','BS362',null)
	,('CN23.2','BS363',null)
	,('CN23.2','BS364',null)
	,('CN23.2','BS365',null)
	,('CN23.2','BS366',null)

	,('CN23.1','BS1021',null)
	,('CN23.1','BS1022',null)
	,('CN23.1','BS1023',null)
	,('CN23.1','BS1024',null)
	,('CN23.1','BS1025',null)
	,('CN23.2','BS1026',null)
	,('CN23.2','BS1027',null)
	,('CN23.2','BS1028',null)
	,('CN23.2','BS1029',null)
	,('CN23.2','BS1030',null)
	
	,('CN23.1','YT258',null)
	,('CN23.1','YT259',null)
	,('CN23.2','YT260',null)
	,('CN23.2','YT261',null)
	,('CN23.2','YT262',null)
	------------------------------------
	,('CN24.1','BS91',null)
	,('CN24.1','BS92',null)
	,('CN24.1','BS134',null)
	,('CN24.1','TK24',null)
	,('CN24.1','YT74',null)
	,('CN24.1','YT75',null)
	,('CN24.1','YT76',null)

	,('CN24.1','BS367',null)
	,('CN24.1','BS368',null)
	,('CN24.1','BS369',null)
	,('CN24.1','BS370',null)
	,('CN24.1','BS371',null)
	,('CN24.1','BS372',null)
	,('CN24.1','BS373',null)
	,('CN24.1','BS374',null)
	,('CN24.1','BS375',null)
	,('CN24.1','BS376',null)
	,('CN24.1','BS377',null)

	,('CN24.1','BS1031',null)
	,('CN24.1','BS1032',null)
	,('CN24.1','BS1033',null)
	,('CN24.1','BS1034',null)
	,('CN24.1','BS1035',null)
	,('CN24.1','BS1036',null)
	,('CN24.1','BS1037',null)
	,('CN24.1','BS1038',null)
	,('CN24.1','BS1039',null)
	,('CN24.1','BS1040',null)
	,('CN24.1','BS1041',null)
	,('CN24.1','BS1042',null)
	,('CN24.1','BS1043',null)
	,('CN24.1','BS1044',null)
	,('CN24.1','BS1045',null)

	,('CN24.1','YT263',null)
	,('CN24.1','YT264',null)
	,('CN24.1','YT265',null)
	,('CN24.1','YT266',null)
	,('CN24.1','YT267',null)
	------------------------------------
	,('CN25.1','BS93',null)
	,('CN25.1','BS135',null)
	,('CN25.1','BS94',null)
	,('CN25.1','TK25',null)
	,('CN25.1','YT77',null)
	,('CN25.1','YT88',null)
	,('CN25.1','YT79',null)

	,('CN25.2','BS93',null)
	,('CN25.2','BS136',null)
	,('CN25.3','BS94',null)
	,('CN25.2','TK25',null)
	,('CN25.2','YT77',null)
	,('CN25.3','BS137',null)
	,('CN25.3','YT88',null)
	,('CN25.3','YT79',null)

	,('CN25.1','BS378',null)
	,('CN25.1','BS379',null)
	,('CN25.1','BS380',null)
	,('CN25.2','BS381',null)
	,('CN25.2','BS382',null)
	,('CN25.2','BS383',null)
	,('CN25.3','BS384',null)
	,('CN25.3','BS385',null)
	,('CN25.3','BS386',null)

	,('CN25.1','BS1061',null)
	,('CN25.1','BS1062',null)
	,('CN25.1','BS1063',null)
	,('CN25.1','BS1064',null)
	,('CN25.1','BS1065',null)
	,('CN25.2','BS1066',null)
	,('CN25.2','BS1067',null)
	,('CN25.2','BS1068',null)
	,('CN25.2','BS1069',null)
	,('CN25.2','BS1070',null)
	,('CN25.3','BS1071',null)
	,('CN25.3','BS1072',null)
	,('CN25.3','BS1073',null)
	,('CN25.3','BS1074',null)
	,('CN25.3','BS1075',null)

	,('CN25.1','YT268',null)
	,('CN25.1','YT269',null)
	,('CN25.2','YT270',null)
	,('CN25.2','YT271',null)
	,('CN25.3','YT272',null)
	,('CN25.3','YT269',null)

	-----------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN26.1','BS95',null)
	,('CN26.1','BS97',null)
	,('CN26.1','YT80',null)
	,('CN26.1','YT82',null)
	,('CN26.2','BS96',null)
	,('CN26.2','BS138',null)
	,('CN26.2','TK26',null)
	,('CN26.2','YT81',null)
	,('CN26.2','YT80',null)
	
	,('CN26.1','BS387',null)
	,('CN26.1','BS388',null)
	,('CN26.1','BS389',null)
	,('CN26.1','BS390',null)
	,('CN26.2','BS391',null)
	,('CN26.2','BS392',null)
	,('CN26.2','BS393',null)
	,('CN26.2','BS394',null)
	,('CN26.2','BS395',null)

	,('CN26.1','BS1081',null)
	,('CN26.1','BS1082',null)
	,('CN26.1','BS1083',null)
	,('CN26.1','BS1084',null)
	,('CN26.1','BS1085',null)
	,('CN26.1','BS1086',null)
	,('CN26.1','BS1087',null)
	,('CN26.2','BS1088',null)
	,('CN26.2','BS1089',null)
	,('CN26.2','BS1090',null)
	,('CN26.2','BS1091',null)
	,('CN26.2','BS1092',null)
	,('CN26.2','BS1093',null)
	,('CN26.2','BS1094',null)
	,('CN26.2','BS1095',null)

	,('CN26.1','YT273',null)
	,('CN26.1','YT274',null)
	,('CN26.2','YT275',null)
	,('CN26.2','YT276',null)
	,('CN26.2','YT277',null)
	
	----------------------------------
	,('CN27.1','BS98',null)
	,('CN27.1','BS139',null)
	,('CN27.1','BS99',null)
	,('CN27.1','YT83',null)
	,('CN27.2','BS100',null)
	,('CN27.2','BS140',null)
	,('CN27.2','YT85',null)
	,('CN27.3','BS98',null)
	,('CN27.3','BS100',null)
	,('CN27.3','BS141',null)
	,('CN27.3','YT84',null)
	,('CN27.3','YT83',null)

	,('CN27.1','BS397',null)
	,('CN27.1','BS398',null)
	,('CN27.2','BS399',null)
	,('CN27.2','BS400',null)
	,('CN27.3','BS401',null)
	,('CN27.3','BS402',null)
	,('CN27.3','BS403',null)
	,('CN27.3','BS404',null)

	,('CN27.1','BS1101',null)
	,('CN27.1','BS1102',null)
	,('CN27.1','BS1103',null)
	,('CN27.1','BS1104',null)
	,('CN27.1','BS1105',null)
	,('CN27.2','BS1106',null)
	,('CN27.2','BS1107',null)
	,('CN27.2','BS1108',null)
	,('CN27.2','BS1109',null)
	,('CN27.2','BS1110',null)
	,('CN27.3','BS1111',null)
	,('CN27.3','BS1112',null)
	,('CN27.3','BS1113',null)
	,('CN27.3','BS1114',null)
	,('CN27.3','BS1115',null)

	,('CN27.1','YT278',null)
	,('CN27.1','YT279',null)
	,('CN27.2','YT280',null)
	,('CN27.2','YT281',null)
	,('CN27.3','YT282',null)
	,('CN27.3','YT279',null)
	--------------------------------
insert into DamNhanChuyenMon([MaChuyenNganh],[MaNV],KinhNghiem)
values
	 ('CN28.1','BS101',null)
	,('CN28.1','BS412',null)
	,('CN28.1','BS413',null)
	,('CN28.1','BS418',null)
	,('CN28.1','BS419',null)
	,('CN28.1','BS102',null)
	,('CN28.1','BS103',null)
	,('CN28.1','TK28',null)
	,('CN28.1','YT87',null)
	
	,('CN28.2','YT144',null)
	,('CN28.2','YT88',null)
	,('CN28.2','BS405',null)
	,('CN28.2','BS406',null)
	,('CN28.2','BS407',null)
	,('CN28.2','BS414',null)
	,('CN28.2','BS415',null)
	,('CN28.2','BS420',null)
	,('CN28.2','BS421',null)

	,('CN28.3','YT145',null)
	,('CN28.3','YT86',null)
	,('CN28.3','BS408',null)
	,('CN28.3','BS409',null)
	,('CN28.3','BS410',null)
	,('CN28.3','BS416',null)
	,('CN28.3','BS417',null)
	,('CN28.3','BS422',null)
	,('CN28.3','BS423',null)
	,('CN28.3','BS424',null)

	,('CN28.1','BS1201',null)
	,('CN28.1','BS1202',null)
	,('CN28.1','BS1203',null)
	,('CN28.1','BS1204',null)
	,('CN28.1','BS1205',null)
	,('CN28.2','BS1206',null)
	,('CN28.2','BS1207',null)
	,('CN28.2','BS1208',null)
	,('CN28.2','BS1209',null)
	,('CN28.2','BS1210',null)
	,('CN28.3','BS1211',null)
	,('CN28.3','BS1212',null)
	,('CN28.3','BS1213',null)
	,('CN28.3','BS1214',null)
	,('CN28.3','BS1215',null)

	,('CN28.1','YT283',null)
	,('CN28.1','YT284',null)
	,('CN28.2','YT285',null)
	,('CN28.2','YT286',null)
	,('CN28.3','YT287',null)
	,('CN28.3','YT283',null)
	----------------------------------

	,('CN29.1','BS104',null)
	,('CN29.1','BS106',null)
	,('CN29.1','BS142',null)
	,('CN29.1','YT89',null)
	,('CN29.2','BS105',null)
	,('CN29.2','TK29',null)
	,('CN29.2','BS143',null)
	,('CN29.2','YT91',null)
	,('CN29.2','YT90',null)

	,('CN29.1','BS425',null)
	,('CN29.1','BS426',null)
	,('CN29.1','BS427',null)
	,('CN29.1','BS428',null)
	,('CN29.2','BS429',null)
	,('CN29.2','BS430',null)
	,('CN29.2','BS431',null)
	,('CN29.2','BS432',null)
	,('CN29.2','BS433',null)

	,('CN29.1','BS1301',null)
	,('CN29.1','BS1302',null)
	,('CN29.1','BS1303',null)
	,('CN29.1','BS1304',null)
	,('CN29.1','BS1305',null)
	,('CN29.1','BS1306',null)
	,('CN29.1','BS1307',null)
	,('CN29.1','BS1308',null)
	,('CN29.2','BS1309',null)
	,('CN29.2','BS1310',null)
	,('CN29.2','BS1311',null)
	,('CN29.2','BS1312',null)
	,('CN29.2','BS1313',null)
	,('CN29.2','BS1314',null)
	,('CN29.2','BS1315',null)

	,('CN29.1','YT288',null)
	,('CN29.1','YT289',null)
	,('CN29.1','YT290',null)
	,('CN29.2','YT291',null)
	,('CN29.2','YT292',null)


	
	,('CN01.1','YT92',null)
	
	,('CN03.1','YT93',null)
	,('CN03.2','YT94',null)

	,('CN04.1','YT95',null)
	
	,('CN05.1','YT97',null)
	,('CN05.3','YT98',null)

	,('CN06.1','YT99',null)
	,('CN06.2','YT100',null)

	,('CN07.1','YT101',null)
	,('CN07.2','YT102',null)
	,('CN07.3','YT103',null)

	,('CN08.1','YT104',null)
	,('CN08.2','YT105',null)

	,('CN09.3','YT106',null)
	,('CN09.2','YT107',null)
	
	,('CN10.2','YT108',null)
	,('CN10.1','YT109',null)
	
	,('CN11.2','YT110',null)
	,('CN11.1','YT111',null)

	,('CN12.2','YT112',null)
	,('CN12.2','YT113',null)

	,('CN13.1','YT114',null)
	,('CN13.2','YT115',null)

	,('CN14.1','YT116',null)
	,('CN14.1','YT117',null)

	,('CN15.1','YT118',null)
	,('CN15.2','YT119',null)

	,('CN16.1','YT120',null)
	,('CN16.2','YT121',null)

	,('CN18.1','YT124',null)
	,('CN18.2','YT125',null)

	,('CN19.1','YT126',null)
	,('CN19.2','YT127',null)

	,('CN20.1','YT128',null)
	,('CN20.1','YT129',null)

	,('CN21.1','YT130',null)
	,('CN21.2','YT131',null)

	,('CN22.1','YT132',null)
	,('CN22.2','YT133',null)

	,('CN23.1','YT134',null)
	,('CN23.2','YT135',null)

	,('CN24.1','YT136',null)
	,('CN24.1','YT137',null)

	,('CN25.1','YT138',null)
	,('CN25.2','YT139',null)

	,('CN26.1','YT140',null)
	,('CN26.2','YT141',null)

	,('CN27.1','YT142',null)
	,('CN27.2','YT143',null)

	,('CN28.1','YT144',null)
	,('CN28.1','YT145',null)

	,('CN29.1','YT146',null)
	,('CN29.2','YT147',null)
	
insert into PhieuKhamBenh([MSPhieuKhamBenh],[NgayKham],[MaHoSoBA],[TrieuChung],[BenhNen],[MaLoaiKham])
VALUES
	 ('PKB01','2022/09/24',N'HOSOKBBN01',N'Ho và sốt',null,'LK01')
	,('PKB02','2022/01/26',N'HOSOKBBN01',N'Mệt mỏi và đau đầu','Bệnh tiểu đường','LK01')
	,('PKB03','2022/02/16',N'HOSOKBBN01',N'Khó thở và ho kéo dài',null,'LK01')
	,('PKB04','2002/06/17',N'HOSOKBBN02',N'Đau bụng và buồn nôn',null,'LK01')
	,('PKB05','2002/10/23',N'HOSOKBBN02',N'Sổ mũi và hắt hơi',null,'LK01')
	,('PKB06','2022/10/23',N'HOSOKBBN02',N'Mắt đỏ',null,'LK01')
	,('PKB07','2022/05/07',N'HOSOKBBN03',N'Nhức mỏi cơ bắp',N'Hen suyễn','LK01')
	,('PKB08','2022/02/09',N'HOSOKBBN03',N'Cảm giác mất vị giác',null,'LK01')
	,('PKB09','2022/04/06',N'HOSOKBBN03',N'Giảm cân không rõ nguyên nhân',null,'LK01')
	,('PKB10','2022/01/25',N'HOSOKBBN04',N'Ho ra máu',null,'LK01')
	,('PKB11','2022/12/24',N'HOSOKBBN04',N'Hay quên',N'Cao huyết áp','LK01')
	,('PKB12','2022/03/24',N'HOSOKBBN04',N'Sốt đột ngột,đau họng và nôn mửa',null,'LK01')
	,('PKB13','2022/01/25',N'HOSOKBBN05',N'Sốt đột ngột,tiểu ra máu',null,'LK01')
	,('PKB14','2022/06/30',N'HOSOKBBN05',N'Giảm sức nghe và u tai',null,'LK01')
	,('PKB15','2022/11/23',N'HOSOKBBN05',N'Giảm sức nghe và u tai',null,'LK01')
	,('PKB16','2022/03/15',N'HOSOKBBN06',N'Vàng da,mệt mỏi,chán ăn',N'Trầm cảm','LK01')
	,('PKB17','2022/01/28',N'HOSOKBBN06',N'Chán ăn kèm biểu hiện nôn ói,khó đại tiện hoặc tiêu chảy',null,'LK01')
	,('PKB18','2022/07/09',N'HOSOKBBN06',N'Ho và sốt',null,'LK01')
	,('PKB19','2022/11/30',N'HOSOKBBN07',N'Ho và sốt',null,'LK01')
	,('PKB20','2022/10/20',N'HOSOKBBN07',N'Yếu,tê hoặc liệt chân tay, khó nuốt',null,'LK01')
	,('PKB21','2022/09/10',N'HOSOKBBN07',N'Đá chân và đập tay, khó thức dậy và bối rối nếu bị đánh thức',null,'LK01')
	,('PKB22','2022/03/28',N'HOSOKBBN08',N'Mắt đỏ',N'Viêm loét dạ dày','LK01')
	,('PKB23','2022/10/03',N'HOSOKBBN08',N'Ợ nóng, đau lưng',null,'LK01')
	,('PKB24','2022/05/18',N'HOSOKBBN08',N'Sốt bị ớn lạnh, đổ mồ hôi, tiêu chảy',null,'LK01')
	,('PKB25','2022/09/03',N'HOSOKBBN09',N'Khó ngủ và dễ tỉnh giấc vào ban đêm',null,'LK01')
	,('PKB26','2022/09/03',N'HOSOKBBN09',N'Khó ngủ và dễ tỉnh giấc vào ban đêm',null,'LK01')
	,('PKB27','2022/11/14',N'HOSOKBBN09',N'Nốt ruồi to ra nhanh chóng',null,'LK01')
	,('PKB28','2022/09/24',N'HOSOKBBN10',N'Đau khi đi đại tiện',null,'LK01')
	,('PKB29','2022/01/03',N'HOSOKBBN10',N'Khó nhìn rõ vào ban đêm,mờ mắt,đau đầu',null,'LK01')
	,('PKB30','2022/02/03',N'HOSOKBBN10',N'Đau ngực và khó thở, ho kéo dài hơn 3 tuần',null,'LK01')
	,('PKB31','2022/09/24',N'HOSOKBBN11',N'Buồn nôn, đau đầu và rối loạn giấc ngủ',null,'LK01')
	,('PKB32','2022/05/07',N'HOSOKBBN11',N'Đau mắt',null,'LK01')
	,('PKB33','2022/10/21',N'HOSOKBBN11',N'Mệt mỏi liên tục, thèm ăn và tăng cân',null,'LK01')
	,('PKB34','2022/10/14',N'HOSOKBBN12',N'Đau khớp dữ dội',N'Viêm gan B','LK01')
	,('PKB35','2022/08/14',N'HOSOKBBN12',N'Chóng mặt hoặc mất thăng bằng, lú lẫn',null,'LK01')
	,('PKB36','2022/04/25',N'HOSOKBBN12',N'Nốt mụn sưng đỏ, xung quanh vùng mụn cứng',null,'LK01')
	,('PKB37','2022/03/01',N'HOSOKBBN13',N'Ho và sốt',null,'LK01')
	,('PKB38','2022/05/12',N'HOSOKBBN13',N'Ho và sốt',null,'LK01')
	,('PKB39','2022/07/19',N'HOSOKBBN13',N'Đỏ mắt',null,'LK01')
	,('PKB40','2022/06/07',N'HOSOKBBN14',N'Sưng và nổi hạch',null,'LK01')
	,('PKB41','2022/08/03',N'HOSOKBBN14',N'Đau thắt ngực',null,'LK01')
	,('PKB42','2022/04/07',N'HOSOKBBN14',N'Khó thở khi hoạt động hoặc nằm xuống',null,'LK01')
	,('PKB43','2022/05/24',N'HOSOKBBN15',N'Sốt, 2-4 ngày xuất hiện ban ngứa',null,'LK01')
	,('PKB44','2022/01/01',N'HOSOKBBN15',N'Đi cầu ra máu',null,'LK01')
	,('PKB45','2022/01/01',N'HOSOKBBN15',N'Ho dai dẳng và thở khò khè',null,'LK01')
	,('PKB46','2022/03/03',N'HOSOKBBN16',N'Co giật hoặc động kinh,mất ý thức từ vài phút đến hàng giờ',null,'LK01')
	,('PKB47','2022/02/01',N'HOSOKBBN16',N'Sụt cân không rõ nguyên nhân, tính cách thay đổi bất thường',null,'LK01')
	,('PKB48','2022/02/01',N'HOSOKBBN16',N'Chảy nước mũi, đau họng và khàn giọng',null,'LK01')
	,('PKB49','2022/02/04',N'HOSOKBBN17',N'Mệt mỏi toàn thân, chán ăn, sút cân',null,'LK01')
	,('PKB50','2022/06/12',N'HOSOKBBN17',N'Chứng sợ nước và tăng động',null,'LK01')
	,('PKB51','2022/07/20',N'HOSOKBBN17',N'Chứng sợ nước và tăng động',null,'LK01')
	,('PKB52','2022/06/12',N'HOSOKBBN18',N'Khó phân biệt màu đen và màu xanh tối',null,'LK01')
	,('PKB53','2022/07/12',N'HOSOKBBN18',N'Nước tiểu xuất hiện bọt, ăn mất ngon',null,'LK01')
	,('PKB54','2022/06/09',N'HOSOKBBN18',N'Đau tức ngực, xảy ra trong thời gian dài',null,'LK01')
	,('PKB55','2021/02/24',N'HOSOKBBN19',N'Nghẹt mũi',null,'LK01')
	,('PKB56','2022/02/04',N'HOSOKBBN19',N'Đau mắt',null,'LK01')
	,('PKB57','2022/09/16',N'HOSOKBBN19',N'Đau đầu thường xuyên, nói khó',null,'LK01')
	,('PKB58','2022/09/22',N'HOSOKBBN20',N'Sốt cao trên 38 độ C, ho, đau họng',null,'LK01')
	,('PKB59','2022/08/06',N'HOSOKBBN20',N'Khô mắt và thay đổi vị giác',null,'LK01')
	,('PKB60','2022/12/06',N'HOSOKBBN20',N'Khó phân biệt màu đen và màu xanh tối',null,'LK01')
	,('PKB61','2022/03/27',N'HOSOKBBN21',N'Mắt ngứa hoặc bỏng rát',null,'LK01')
	,('PKB62','2022/08/06',N'HOSOKBBN21',N'Đau khớp, sốt và mệt mỏi',N'Rối loạn lo âu','LK01')
	,('PKB63','2022/11/28',N'HOSOKBBN21',N'Có bùi trĩ lòi ra, đi cầu ra máu',null,'LK01')
	,('PKB64','2022/05/21',N'HOSOKBBN22',N'Vàng da hoặc mắt, đau bụng hoặc chướng bụng',null,'LK01')
	,('PKB65','2022/05/21',N'HOSOKBBN22',N'Cháy máu không kiểm soát,huyết áp giảm',null,'LK01')
	,('PKB66','2022/07/20',N'HOSOKBBN22',N'Chứng sợ nước và tăng động',null,'LK01')
	,('PKB67','2022/01/13',N'HOSOKBBN23',N'Đau bụng bên trái, chóng mặt và vả mồ hôi',null,'LK01')
	,('PKB68','2022/01/09',N'HOSOKBBN23',N'Sụt cân không rõ nguyên nhân, tính cách thay đổi bất thường',null,'LK01')
	,('PKB69','2022/06/10',N'HOSOKBBN23',N'Ợ nóng, đau lưng',null,'LK01')
	,('PKB70','2022/02/20',N'HOSOKBBN24',N'Cảm thấy ớn lạnh, đổ mồ hôi',null,'LK01')
	,('PKB71','2022/02/20',N'HOSOKBBN24',N'Cảm thấy ớn lạnh, đổ mồ hôi',null,'LK01')
	,('PKB72','2022/02/20',N'HOSOKBBN24',N'Ho ra máu và đau ngực',null,'LK01')
	,('PKB73','2022/07/28',N'HOSOKBBN25',N'Sụt cân không rõ nguyên nhân, tính cách thay đổi bất thường',N'Rối loạn lưỡng cực','LK01')
	,('PKB74','2022/09/29',N'HOSOKBBN25',N'Đau khớp',null,'LK01')
	,('PKB75','2022/04/25',N'HOSOKBBN25',N'Sốt, 2-4 ngày xuất hiện ban ngứa',null,'LK01')
	,('PKB76','2022/04/05',N'HOSOKBBN26',N'Cháy máu không kiểm soát,huyết áp giảm',null,'LK02')
	,('PKB77','2022/07/26',N'HOSOKBBN26',N'Chậm động và mất ổn định tư thế',null,'LK02')
	,('PKB78','2022/01/16',N'HOSOKBBN26',N'Chậm động và mất ổn định tư thế',null,'LK02')

	,('PKB79','2022/07/02',N'HOSOKBBN27',N'Ngứa và vàng da',null,'LK02')
	,('PKB80','2022/09/23',N'HOSOKBBN27',N'Ngứa và vàng da',null,'LK02')
	,('PKB81','2022/12/29',N'HOSOKBBN27',N'Động kinh',null,'LK02')

	,('PKB82','2022/07/28',N'HOSOKBBN28',N'Mắt đau',null,'LK02')
	,('PKB83','2023/02/09',N'HOSOKBBN28',N'Động kinh',null,'LK02')
	,('PKB84','2023/06/29',N'HOSOKBBN28',N'Ho và sốt',null,'LK02')

	,('PKB85','2022/06/02',N'HOSOKBBN29',N'Chảy nước mũi, đau họng và khàn giọng',null,'LK02')
	,('PKB86','2022/02/12',N'HOSOKBBN29',N'Nước tiểu xuất hiện bọt, ăn mất ngon',null,'LK02')
	,('PKB87','2022/02/14',N'HOSOKBBN29',N'Sổ mũi và hắt hơi',null,'LK02')

	,('PKB88','2022/01/12',N'HOSOKBBN30',N'Đau tức ngực, xảy ra trong thời gian dài',null,'LK02')
	,('PKB89','2022/01/23',N'HOSOKBBN30',N'Sưng và nổi hạch',null,'LK02')
	,('PKB90','2022/02/03',N'HOSOKBBN30',N'Đau đầu thường xuyên, nói khó',null,'LK02')

	,('PKB91','2022/05/09',N'HOSOKBBN31',N'Đau khi đi đại tiện',null,'LK02')
	,('PKB92','2022/02/22',N'HOSOKBBN31',N'Buồn nôn, đau đầu và rối loạn giấc ngủ',null,'LK02')
	,('PKB93','2022/01/26',N'HOSOKBBN31',N'Khó nhìn rõ vào ban đêm',null,'LK02')

	,('PKB94','2022/07/02',N'HOSOKBBN32',N'Khó nhìn rõ vào ban đêm',N'Gout','LK02')
	,('PKB95','2022/01/16',N'HOSOKBBN32',N'Chóng mặt hoặc mất thăng bằng, lú lẫn',null,'LK02')
	,('PKB96','2022/09/19',N'HOSOKBBN32',N'Mệt mỏi toàn thân, chán ăn, sút cân',null,'LK02')

	,('PKB97','2022/04/01',N'HOSOKBBN33',N'Cảm thấy ớn lạnh, đổ mồ hôi',null,'LK02')
	,('PKB98','2022/06/20',N'HOSOKBBN33',N'Nhức mỏi cơ bắp',null,'LK02')
	,('PKB99','2022/10/30',N'HOSOKBBN33',N'Nhức mỏi cơ bắp',null,'LK02')

	,('PKB100','2022/08/13',N'HOSOKBBN34',N'Mất vị giác',N'Béo phì','LK02')
	,('PKB101','2022/04/15',N'HOSOKBBN34',N'Đau bụng bên trái, chóng mặt và vả mồ hôi',null,'LK02')
	,('PKB102','2022/09/02',N'HOSOKBBN34',N'Mắt ngứa hoặc bỏng rát',null,'LK02')

	,('PKB103','2022/06/11',N'HOSOKBBN35',N'Đau mắt',null,'LK02')
	,('PKB104','2022/12/13',N'HOSOKBBN35',N'Nhịp tim nhanh, ngất xỉu',null,'LK02')
	,('PKB105','2022/02/07',N'HOSOKBBN35',N'Mắt ngứa hoặc bỏng rát',null,'LK02')

	,('PKB106','2022/11/12',N'HOSOKBBN36',N'Co giật và đổ mồ hôi, đau bụng',null,'LK02')
	,('PKB107','2022/02/18',N'HOSOKBBN36',N'Không chịu được tiếng ồn và đau hoặc ngứa ở vết cắn',null,'LK02')
	,('PKB108','2022/09/16',N'HOSOKBBN36',N'Mờ hoặc mù mắt trong 1 vài giây',null,'LK02')

	,('PKB109','2022/04/24',N'HOSOKBBN37',N'Sụt cân không rõ nguyên nhân, tính cách thay đổi bất thường',null,'LK02')
	,('PKB110','2022/10/20',N'HOSOKBBN37',N'Mờ hoặc mù mắt trong 1 vài giây',null,'LK02')
	,('PKB111','2023/09/08',N'HOSOKBBN37',N'Ù tai và nặng tai',null,'LK02')

	,('PKB112','2022/12/08',N'HOSOKBBN38',N'Ù tai và nặng tai',null,'LK02')
	,('PKB113','2022/01/05',N'HOSOKBBN38',N'Tầm nhìn giảm sút và vết thương lâu lành',null,'LK02')
	,('PKB114','2022/03/28',N'HOSOKBBN38',N'Tầm nhìn giảm sút và vết thương lâu lành',null,'LK02')

	,('PKB115','2022/09/08',N'HOSOKBBN39',N'Mụn có bề mặt sần sùi',null,'LK02')
	,('PKB116','2022/05/03',N'HOSOKBBN39',N'Giãn tĩnh mạch',null,'LK02')
	,('PKB117','2023/09/08',N'HOSOKBBN39',N'Run và cứng cơ',null,'LK02')

	,('PKB118','2022/08/16',N'HOSOKBBN40',N'Cảm thấy ớn lạnh, đổ mồ hôi',null,'LK02')
	,('PKB119','2022/05/28',N'HOSOKBBN40',N'Chân tay yếu và mất thăng bằng',null,'LK02')
	,('PKB120','2023/09/19',N'HOSOKBBN40',N'Đau cơ và đau lưng, phát ban nước trên da',null,'LK02')

	,('PKB121','2022/09/14',N'HOSOKBBN41',N'Đau khi đi đại tiện',null,'LK02')
	,('PKB122','2022/11/10',N'HOSOKBBN41',N'Đau khi đi đại tiện',null,'LK02')
	,('PKB123','2022/05/21',N'HOSOKBBN41',N'Mệt mỏi liên tục, thèm ăn và tăng cân',null,'LK02')

	,('PKB124','2022/06/09',N'HOSOKBBN42',N'Mệt mỏi liên tục, thèm ăn và tăng cân',null,'LK02')
	,('PKB125','2022/03/24',N'HOSOKBBN42',N'Cơn ho kéo dài và ho ra máu',null,'LK02')
	,('PKB126','2023/06/04',N'HOSOKBBN42',N'Nhạy cảm với âm thanh và miệng chảy dãi',null,'LK02')

	,('PKB127','2022/09/18',N'HOSOKBBN43',N'Nhạy cảm với âm thanh và miệng chảy dãi',null,'LK02')
	,('PKB128','2022/10/11',N'HOSOKBBN43',N'Đau họng',null,'LK02')
	,('PKB129','2022/01/17',N'HOSOKBBN43',N'Mắt ngứa hoặc bỏng rát',null,'LK02')

	,('PKB130','2022/06/17',N'HOSOKBBN44',N'Khó thở, đau ngực, khàn giọng',null,'LK02')
	,('PKB131','2022/12/03',N'HOSOKBBN44',N'Đá chân và đập tay, khó thức dậy và bối rối nếu bị đánh thức',null,'LK02')
	,('PKB132','2024/01/07',N'HOSOKBBN44',N'Đá chân và đập tay, khó thức dậy và bối rối nếu bị đánh thức',null,'LK02')

	,('PKB133','2022/06/11',N'HOSOKBBN45',N'Đá chân và đập tay, khó thức dậy và bối rối nếu bị đánh thức',null,'LK02')
	,('PKB134','2022/01/12',N'HOSOKBBN45',N'Cảm thấy ớn lạnh, đổ mồ hôi',null,'LK02')
	,('PKB135','2022/01/05',N'HOSOKBBN45',N'Khó thở và ho kéo dài',null,'LK02')

	,('PKB136','2022/11/22',N'HOSOKBBN46',N'Nhức mỏi cơ bắp',null,'LK02')
	,('PKB137','2022/11/11',N'HOSOKBBN46',N'Vết thương lâu lành',null,'LK02')
	,('PKB138','2022/09/18',N'HOSOKBBN46',N'Đau tức ngực, xảy ra trong thời gian dài',N'Béo phì','LK02')

	,('PKB139','2023/07/02',N'HOSOKBBN47',N'Nhìn mờ không kèm đau nhức',null,'LK02')
	,('PKB140','2023/11/28',N'HOSOKBBN47',N'Giảm cân không rõ nguyên nhân',null,'LK02')
	,('PKB141','2024/03/27',N'HOSOKBBN47',N'Hay quên',null,'LK02')

	,('PKB142','2022/01/02',N'HOSOKBBN48',N'Hay quên',null,'LK02')
	,('PKB143','2022/04/29',N'HOSOKBBN48',N'Chóng mặt và vả mồ hôi, đau bụng bên phải',null,'LK02')
	,('PKB144','2022/01/01',N'HOSOKBBN48',N'Sốt nhẹ, đau đầu và chán ăn',null,'LK02')

	,('PKB145','2022/08/30',N'HOSOKBBN49',N'Đau khi đi đại tiện',null,'LK02')
	,('PKB146','2022/02/22',N'HOSOKBBN49',N'Sốt cao, đau sau hốc mắt',null,'LK02')
	,('PKB147','2022/05/30',N'HOSOKBBN49',N'Kém ăn, mệt mỏi và ăn mất ngon',null,'LK02')

	,('PKB148','2022/08/27',N'HOSOKBBN50',N'Kém ăn, mệt mỏi và ăn mất ngon',null,'LK02')
	,('PKB149','2022/12/19',N'HOSOKBBN50',N'Chân tay yếu và mất thăng bằng',null,'LK02')
	,('PKB150','2023/01/12',N'HOSOKBBN50',N'Đi đại tiện ít hơn 3 lần/1 tuần',null,'LK02')


insert into NhanVien([MaNV],[TenNV],[GioiTinh],[SDT],Email,NgayBatDauLam,MaCV,MaKhoa)
values
	('NV01', N'Nguyễn Thái Kinh', 'Nam', '7281590341', 'nguyenthaik@gmail.com', '1991/02/15', 'CV01', 'K30'),
	('NV02', N'Tran Thị Lê', N'Nữ', '7281590342', 'tranthil@gmail.com', '1994/04/18', 'CV01', 'K30'),
	('NV03', N'Lê Quang Minh', 'Nam', '7281590343', 'lequangm@gmail.com', '1997/06/21', 'CV01', 'K30'),
	('NV04', N'Phạm Bảo Ngọc', N'Nữ', '7281590344', 'phambaon@gmail.com', '2001/08/24', 'CV01', 'K30'),
	('NV05', N'Hoàng Đình Ong', 'Nam', '7281590345', 'hoangdinho@gmail.com', '2003/10/28', 'CV01', 'K30'),
	('NV06', N'Vũ Văn Phong', 'Nam', '7281590346', 'vuvanp@gmail.com', '1992/01/30', 'CV01', 'K30'),
	('NV07', N'Nguyễn Thị Quỳnh', 'Nữ', '7281590347', 'nguyenthq@gmail.com', '1995/03/25', 'CV01', 'K30'),
	('NV08', N'Dương Minh Tùng', 'Nam', '7281590348', 'duongminhr@gmail.com', '1998/05/20', 'CV01', 'K30'),
	('NV09', N'Trần Bảo Sáng', 'Nữ', '7281590349', 'tranbaos@gmail.com', '2002/07/15', 'CV01', 'K30'),
	('NV10', N'Hoàng An Tú', 'Nam', '7281590350', 'hoangan@gmail.com', '2004/09/10', 'CV01', 'K30'),
	('NV11', N'Lê Thị Mai', 'Nữ', '7281590346', 'lethimai@gmail.com', '1992/04/05', 'CV01', 'K30'),
	('NV12', N'Trần Thúy Kiều', 'Nữ', '7281590347', 'tranthykieu@gmail.com', '1994/08/12', 'CV01', 'K30'),
	('NV13', N'Phạm Bảo Khánh', 'Nữ', '7281590348', 'phambaokhanh@gmail.com', '1996/11/23', 'CV01', 'K30'),
	('NV14', N'Nguyễn Minh Châu', 'Nữ', '7281590349', 'nguyenminhchau@gmail.com', '2000/02/15', 'CV01', 'K30'),
	('NV15', N'Hồ Thị Bảo Trâm', 'Nữ', '7281590350', 'hothibao@gmail.com', '2003/05/27', 'CV01', 'K30'),
	('NV16', N'Phạm Thị Lan', 'Nữ', '7281590346', 'phamthilan@gmail.com', '1992/02/15', 'CV01', 'K30'),
	('NV17', N'Trần Thùy Linh', 'Nữ', '7281590347', 'tranthuylinh@gmail.com', '1995/04/20', 'CV01', 'K30'),
	('NV18', N'Lê Hà Phương', 'Nữ', '7281590348', 'lephuong@gmail.com', '1998/06/25', 'CV01', 'K30'),
	('NV19', N'Nguyễn Minh Châu', 'Nữ', '7281590349', 'nguyenminhchau@gmail.com', '2001/08/30', 'CV01', 'K30'),
	('NV20', N'Dương Kim Thoa', 'Nữ', '7281590350', 'duongkimthoa@gmail.com', '2004/10/05', 'CV01', 'K30');
	
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],[MaNguoiYC])
values
	  ('YC01.1','P68','PKB01','BS272','NV01')
	 ,('YC01.2','P224','PKB01','BS991','BS272')

	 ,('YC02.1','P69','PKB02','BS272','NV02')
	  
	 ,('YC03.1','P184','PKB03','BS721','NV03')
	 ,('YC03.2','P51','PKB03','BS231','BS721')

	 ,('YC03.3','PXNCC263','PKB03','BS330','BS231')
	 ,('YC03.4','PXNCC273','PKB03','BS331','BS231')
	 ,('YC03.5','P303','PKB03','BS1061','BS231')
	 ,('YC03.6','PB01.3','PKB03','YT01','BS1061')
	 
	 ,('YC04.1','P16','PKB04','BS115','NV04')
	 ,('YC04.2','P299','PKB04','BS323','BS115')
	 ,('YC04.3','PB19.8','PKB04','YT60','BS323')
	  
	 ,('YC05.1','P96','PKB05','BS345','BS115')
	 ,('YC06.1','P147','PKB06','BS474','BS345')

	 ,('YC07.1','P44','PKB07','BS221','NV05')
	 ,('YC07.2','P47','PKB07','BS223','BS221')
	 
	 ,('YC08.1','P225','PKB08','BS991','NV05')
	 ,('YC09.1','P182','PKB09','BS345','NV05')
	 ,('YC09.2','P261','PKB09','BS523','BS345')	 

	 ,('YC10.1','P182','PKB10','BS703','NV06')
	 ,('YC10.2','PXNCC281','PKB10','BS336','BS703')
	 ,('YC10.3','PXNCC271','PKB10','BS974','BS703')
	 ,('YC10.4','P303','PKB10','BS386','BS703')
	 ,('YC10.5','PB10.9','PKB10','YT32','BS39')
	 
	 
	 ,('YC11.1','P225','PKB11','BS985','NV07')
	 ,('YC11.2','P232','PKB11','BS1021','BS985')
	 ,('YC11.3','P234','PKB11','BS1022','BS1021')
	
	 ,('YC12.1','P97','PKB12','BS346','NV08')
	 ,('YC12.3','PXNCC279','PKB12','BS332','BS346')
	 ,('YC12.4','PXNCC273','PKB12','BS334','BS346')
	 ,('YC12.5','P304','PKB12','BS1062','BS346')
	 ,('YC12.6','PB10.1','PKB12','YT197','BS1062')
	 
	 
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],[MaNguoiYC])
values	 
	  ('YC13.1','P196','PKB13','BS785','NV09')
	 ,('YC13.2','P108','PKB13','BS134','BS785')
	 ,('YC13.3','PXNCC274','PKB13','BS974','BS785')
	 ,('YC13.4','P304','PKB13','BS1069','BS785')
	 ,('YC13.5','PB16.10','PKB13','YT120','BS1069')
	 
	 ,('YC14.1','P95','PKB14','BS344','NV07')
	 ,('YC14.2','P359','PKB14','BS128','BS344')
	 
	 ,('YC15.1','P220','PKB15','BS986','NV05')
	 ,('YC15.2','P360','PKB15','BS341','BS986')
	
	 ,('YC16.1','P150','PKB16','BS500','NV10')
	 ,('YC16.2','P152','PKB16','BS506','BS500')
	 ,('YC16.3','PXNCC325','PKB16','TK28','BS500')
	 ,('YC16.4','P363','PKB16','BS335','BS500')
	  
	 ,('YC17.1','P18','PKB17','BS177','NV09')
	 ,('YC17.2','P16','PKB17','BS17','BS177')
	 ,('YC17.3','P301','PKB17','BS76','BS177')
	 ,('YC17.4','PB19.10','PKB17','YT241','BS76')
	
	 ,('YC18.1','P224','PKB18','BS994','NV03')
	 ,('YC19.1','P225','PKB19','BS991','NV01')
	 ,('YC20.1','P120','PKB20','BS139','NV07')
	 ,('YC20.2','P122','PKB20','BS399','BS139')
	 
	 ,('YC21.1','P252','PKB21','BS1111','NV03')
	 ,('YC22.1','P147','PKB22','BS476','NV02')
	 ,('YC23.1','P192','PKB23','BS766','NV06')
	 ,('YC23.2','P134','PKB23','BS21','BS766')
	 
	 ,('YC24.1','P258','PKB24','BS1309','NV09')
	 ,('YC25.1','P125','PKB25','BS100','NV08')
	 ,('YC25.2','P235','PKB25','BS1023','BS100')
	 ,('YC26.1','P105','PKB26','BS357','NV10')
	 ,('YC27.1','P32','PKB27','BS203','NV01')
	 ,('YC27.2','PXNCC281','PKB27','BS340','BS203')
	 ,('YC27.3','P314','PKB27','BS211','BS203')
	 ,('YC27.4','PB07.7','PKB27','YT101','BS211')
	  
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],[MaNguoiYC])
values	 
	  ('YC28.1','P151','PKB28','BS497','NV12')
	 ,('YC28.2','P304','PKB28','BS1061','BS497')
	 ,('YC28.3','PB19.4','PKB28','YT59','BS1061')
	 
	 ,('YC29.1','P13','PKB29','BS13','NV13')

	 ,('YC30.1','P58','PKB30','BS248','NV14')
	 ,('YC30.2','PXNCC271','PKB30','BS338','BS248')
	 ,('YC30.3','PXNCC322','PKB30','BS102','BS248')
	 
	 ,('YC31.1','P196','PKB31','BS781','NV15')
	 ,('YC31.2','P107','PKB31','BS132','BS781')-----------coi lại
	 ,('YC31.3','PXNCC326','PKB31','BS410','BS781')
	 ,('YC31.4','PXNCC326','PKB31','BS410','BS781')

	 ,('YC32.1','P148','PKB32','BS475','NV16')

	 ,('YC33.1','P262','PKB33','BS523','NV17')
	 ,('YC33.2','PXNCC326','PKB33','BS1214','BS523')
	 ,('YC33.3','P363','PKB33','BS339','BS523')

	 
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	 
	  ('YC34.1','P45','PKB34','BS222','NV18')
	 ,('YC34.2','PXNCC327','PKB34','BS413','BS222')	   
	 ,('YC34.3','P46','PKB34','BS36','BS222')

	 ,('YC35.1','P97','PKB35','BS345','NV19')
	 ,('YC35.2','P174','PKB35','BS578','BS345')
	 ,('YC35.3','P343','PKB35','BS251','BS345')
	 ,('YC35.4','P319','PKB35','BS1081','BS345')
	 ,('YC35.5','PB26.5','PKB35','YT273','BS1081')
	 
	 ,('YC36.1','P37','PKB36','BS27','NV20')
	 ,('YC36.2','P33','PKB36','BS210','BS27')
	 ,('YC36.3','P315','PKB36','BS121','BS27')
	 ,('YC36.4','PXNCC337','PKB36','BS1201','BS27')
	 ,('YC36.5','PB07.9','PKB36','YT102','BS121')
	
	
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	
	  ('YC37.1','P11','PKB37','BS10','NV19')
	 ,('YC38.1','P145','PKB38','TK02','NV20')
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values
	  ('YC39.1','P12','PKB39','BS109','NV11')

	 ,('YC40.1','P164','PKB40','BS560','NV13')
	 ,('YC40.2','P69','PKB40','BS276','BS560')
	 
	 ,('YC41.1','P39','PKB41','BS212','NV15')
	 ,('YC41.2','P02','PKB41','BS03','BS212')
	 ,('YC41.3','PXNCC272','PKB41','BS332','BS212')

	 ,('YC42.1','P186','PKB42','BS731','NV08')
	 ,('YC42.2','P38','PKB42','BS34','BS731')
	 ,('YC42.3','P305','PKB42','BS1062','BS731')
	 ,('YC42.4','P363','PKB42','BS974','BS731')
	 ,('YC42.5','PB08.8','PKB42','YT187','BS1062')
	  
	 ,('YC43.1','P166','PKB43','BS558','NV16')
	 ,('YC43.2','P169','PKB43','BS565','BS558')
	  
	 ,('YC44.1','P17','PKB44','BS116','NV19')
	 ,('YC44.2','P372','PKB44','BS1070','BS116')
	 ,('YC44.3','PB19.9','PKB44','YT239','BS1070')
	 
	 
	 ,('YC45.1','P69','PKB45','BS274','NV17')
	 ,('YC45.2','PXNCC272','PKB45','BS336','BS274')
	 ,('YC45.3','PXNCC324','PKB45','BS1208','BS274')

	 ,('YC45.4','P56','PKB45','BS241','BS274')
	 
	 ,('YC46.1','P136','PKB46','BS436','NV13')
	 ,('YC46.2','PXNCC283','PKB46','BS340','BS436')
	 ,('YC46.3','P318','PKB46','BS1091','BS436')
	 ,('YC46.4','PB26.3','PKB46','YT81','BS1091')
	 

	 ,('YC47.1','P104','PKB47','BS359','NV11')	

	 ,('YC48.1','P96','PKB48','BS345','NV12')
	 ,('YC49.1','P134','PKB49','BS21','NV10')
	 ,('YC49.2','P18','PKB49','BS177','BS21')
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	 
	  ('YC50.1','P130','PKB50','BS429','NV12')
	 ,('YC50.2','PXNCC338','PKB50','BS102','BS429')
	  
	 ,('YC51.1','P259','PKB51','BS1312','NV07')
	 ,('YC51.2','PXNCC337','PKB51','BS405','BS1312')
	 
	 ,('YC52.1','P13','PKB52','BS162','NV02')

	 ,('YC53.1','P261','PKB53','BS523','NV14')
	 ,('YC53.2','PXNCC325','PKB53','BS1202','BS523')
	 
	 ,('YC54.1','P174','PKB54','BS584','NV13')
	 ,('YC54.2','P186','PKB54','BS731','BS584')
	 ,('YC54.3','PXNCC273','PKB54','BS971','BS584')
	 
	 ,('YC55.1','P07','PKB55','BS04','NV10')
	 
	 ,('YC56.1','P146','PKB56','BS456','NV20')
	 ,('YC57.1','P145','PKB57','BS459','NV01')
	 ,('YC57.2','PB26.5','PKB57','BS138','BS387')
	 ,('YC57.3','P319','PKB57','BS387','BS459')
	 ,('YC57.4','PXNCC286','PKB57','BS340','BS459')

	 ,('YC58.1','P224','PKB58','BS991','NV15')
	 ,('YC58.2','P130','PKB58','BS105','BS991')
	 ,('YC58.3','P128','PKB58','BS428','BS105')
	
	 ,('YC59.1','P147','PKB59','BS474','NV11')
	 ,('YC60.1','P148','PKB60','BS477','NV06')
	 ,('YC60.2','P311','PKB60','BS11','BS477')
	 ,('YC60.3','PB03.7','PKB60','YT24','BS11')
	 
	  
	 ,('YC61.1','P14','PKB61','BS11','NV18')
	 ,('YC62.1','P130','PKB62','BS105','NV11')
	 ,('YC62.2','PXNCC325','PKB62','BS422','BS105')
	 ,('YC62.3','PXNCC325','PKB62','BS422','BS105')
	 
	 ,('YC63.1','P16','PKB63','BS17','NV20')
	 ,('YC63.2','P373','PKB63','BS1070','BS17')
	 ,('YC63.3','PB19.11','PKB63','YT242','BS1070')
	 
	 ,('YC64.1','P17','PKB64','BS170','NV18')
	 ,('YC64.2','PXNCC269','PKB64','BS334','BS170')
	 ,('YC64.3','P364','PKB64','BS338','BS170')
	 
	 ,('YC65.1','P01','PKB65','BS111','NV10')
	 ,('YC65.2','PXNCC271','PKB65','TK20','BS111')
	 ,('YC65.3','P288','PKB65','BS126','TK20')
	 ,('YC65.4','PB18.2','PKB65','YT125','BS126')
	 
	 ,('YC66.1','P254','PKB66','BS1309','NV13')
	 ,('YC66.2','PXNCC337','PKB66','BS407','BS1309')
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	 
	  ('YC67.1','P196','PKB67','BS786','NV16')
	 ,('YC67.2','PXNCC327','PKB67','BS1203','BS786')
	 ,('YC67.3','P305','PKB67','BS1075','BS1203')
	 ,('YC67.4','PB25.1','PKB67','YT271','BS1075')
	  
	 ,('YC68.1','P134','PKB68','BS525','NV11')
	 ,('YC68.2','P64','PKB68','BS262','BS525')
	 ,('YC68.3','P365','PKB68','BS975','BS525')
	 
	 ,('YC69.1','P233','PKB69','BS1025','NV04')
	 ,('YC69.2','P235','PKB69','BS1022','BS1025')
	 ,('YC69.3','P364','PKB69','BS330','BS1025')
	 ,('YC69.4','P353','PKB69','BS267','BS1025')
	 
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	 
	  ('YC70.1','P128','PKB70','BS425','NV14')
	 ,('YC70.2','PXNCC339','PKB70','BS103','NV14')
	  
	 ,('YC71.1','P129','PKB71','BS426','NV15')
	 ,('YC71.2','PXNCC340','PKB71','BS1208','BS426')

	 ,('YC72.1','P183','PKB72','BS705','NV16')
	 ,('YC72.2','PXNCC280','PKB72','BS333','BS705')
	 ,('YC72.3','PXNCC272','PKB72','BS81','BS705')
	 ,('YC72.4','P304','PKB72','BS1066','BS705')
	 ,('YC72.5','PB01.9','PKB72','YT01','BS1066')
	 
	 ,('YC73.1','P262','PKB73','BS523','NV04')
	 ,('YC73.2','P366','PKB73','BS970','BS523')
	 ,('YC73.3','PXNCC325','PKB73','BS1207','BS523')

insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	 
	  ('YC74.1','P176','PKB74','BS598','NV03')
	 ,('YC74.2','P178','PKB74','BS595','BS598')
	 ,('YC74.3','P349','PKB74','BS255','BS598')
	 ,('YC74.4','PXNCC272','PKB74','BS974','BS598')
	 
	 ,('YC75.1','P34','PKB75','BS206','NV11')
	 ,('YC75.2','PXNCC283','PKB75','BS968','BS206')

	 ,('YC76.1','P206','PKB76','BS126','NV12')
	 ,('YC76.2','PB18.3','PKB76','BS313','BS322')
	 ,('YC76.3','P290','PKB76','BS322','BS126')
	
	 
	 ,('YC77.1','P121','PKB77','BS397','NV10')

	 ,('YC78.1','P121','PKB78','BS397','NV19')
	 ,('YC78.2','PXNCC285','PKB78','BS973','BS397')
	 
	 ,('YC79.1','P18','PKB79','BS178','NV17')
	 ,('YC79.2','PXNCC327','PKB79','BS1201','BS178')
	 ,('YC79.3','P364','PKB79','BS335','BS178')
	  
	 ,('YC80.1','P19','PKB80','BS185','NV02')
	 ,('YC80.2','PXNCC327','PKB80','BS1201','BS185')
	 ,('YC80.3','P364','PKB80','BS335','BS185')
	
	 ,('YC81.1','P135','PKB81','BS434','NV03')
	 ,('YC81.2','PB26.5','PKB81','YT277','BS387')
	 ,('YC81.3','P319','PKB81','BS387','BS434')
	 ,('YC81.4','PXNCC286','PKB81','BS340','BS434')
	 
	 ,('YC82.1','P13','PKB82','BS162','NV11')

	 ,('YC83.1','P67','PKB83','BS144','NV13')
	 ,('YC83.2','P02','PKB83','BS145','BS144')
	 ,('YC83.3','PXNCC283','PKB83','BS969','BS144')
	 ,('YC83.4','P320','PKB83','BS393','BS144')
	 ,('YC83.5','PB26.9','PKB83','YT80','BS393')
	
	 ,('YC84.1','P97','PKB84','BS345','NV07')
	 ,('YC85.1','P224','PKB85','BS991','NV17')
	 ,('YC86.1','P108','PKB86','BS375','NV01')
	 ,('YC86.2','PXNCC327','PKB86','BS414','BS375')
	
	 ,('YC87.1','P224','PKB87','BS991','NV11')
	 ,('YC88.1','P171','PKB88','BS578','NV16')
	 ,('YC88.2','PXNCC274','PKB88','BS975','NV16')

insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],MaNguoiYC)
values	 
	  ('YC89.1','P69','PKB89','BS277','NV03')
	 ,('YC89.2','PXNCC322','PKB89','BS1206','BS277')

	 ,('YC90.1','P107','PKB90','BS359','NV13')
	 ,('YC90.2','PB26.5','PKB90','YT81','BS388')
	 ,('YC90.3','P319','PKB90','BS388','BS359')
	 ,('YC90.4','PXNCC286','PKB90','BS340','BS359')
	 
	 ,('YC91.1','P17','PKB91','BS172','NV14')
	 ,('YC91.2','P374','PKB91','BS1067','BS172')
	 ,('YC91.3','PB19.8','PKB91','YT126','BS1067')
	 
	 ,('YC92.1','P125','PKB92','BS100','NV12')
	 ,('YC92.2','P106','PKB92','BS361','BS100')
	 
	 ,('YC93.1','P147','PKB93','BS476','NV02')
	 ,('YC94.1','P13','PKB94','BS165','NV17')
	 ,('YC95.1','P105','PKB95','BS358','NV16')
	 ,('YC95.2','PXNCC284','PKB95','BS964','BS358')

	  
	 ,('YC96.1','P68','PKB96','BS272','NV15')
	 ,('YC96.2','P366','PKB96','BS971','BS272')
	 ,('YC96.3','PXNCC270','PKB96','BS975','BS272')
	  
	 
	 ,('YC97.1','P131','PKB97','BS430','NV06')
	 ,('YC97.2','PXNCC339','PKB97','BS411','BS430')
	 
	 ,('YC98.1','P46','PKB98','BS37','NV13')
	 ,('YC98.2','P44','PKB98','BS38','BS37')
	 ,('YC98.3','PXNCC271','PKB98','BS965','BS37')
	 ,('YC98.4','P348','PKB98','BS257','BS37')

	 
	 ,('YC99.1','P47','PKB99','BS36','NV11')
	 ,('YC99.2','P45','PKB99','BS227','BS36')
	 ,('YC99.3','PXNCC271','PKB99','BS965','BS36')
	 ,('YC99.4','P348','PKB99','BS257','BS36')
	 
	 ,('YC100.1','P120','PKB100','BS98','NV01')
	 ,('YC100.2','PXNCC286','PKB100','TK20','BS98')

	 ,('YC101.1','P68','PKB101','BS273','NV10')
	 ,('YC101.2','P17','PKB101','BS502','BS273')
	 ,('YC101.3','P289','PKB101','BS316','BS273')
	 ,('YC101.4','P289','PKB101','YT56','BS316')
	 
	 ,('YC102.1','P15','PKB102','BS14','NV11')
	 ,('YC102.2','P14','PKB102','BS163','BS14')
	 
	 ,('YC103.1','P14','PKB103','BS480','NV18')

	 ,('YC104.1','P38','PKB104','BS214','NV16')
	 ,('YC104.2','PXNCC266','PKB104','BS332','BS214')
	 ,('YC104.3','PXNCC325','PKB104','BS1206','BS214')
	 
	 ,('YC105.1','P148','PKB105','BS475','NV17')
	 ,('YC106.1','P68','PKB106','BS275','NV01')
	 ,('YC106.2','P261','PKB106','BS523','BS275')
	 ,('YC106.3','PXNCC325','PKB106','BS1203','BS275')
	 ,('YC106.4','PXNCC325','PKB106','BS1203','BS275')
	 ,('YC106.5','P354','PKB106','BS270','BS275')
	 
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],[MaNguoiYC])
values	 
	  ('YC107.1','P258','PKB107','BS1314','NV04')
	 ,('YC107.2','PXNCC337','PKB107','BS409','BS1309')
	 ,('YC108.1','P38','PKB108','BS31','NV14')
	 ,('YC108.2','P300','PKB108','BS76','BS31')
	 ,('YC108.3','PB01.10','PKB108','YT61','BS76')
	
	 ,('YC109.1','P151','PKB109','BS496','NV15')
	 
	 ,('YC110.1','P170','PKB110','BS575','NV16')
	 ,('YC110.2','P302','PKB110','BS942','BS575')
	 ,('YC110.3','PB19.7','PKB110','YT242','BS942')

	 ,('YC111.1','P94','PKB111','BS343','NV07')
	 ,('YC111.2','P359','PKB111','BS83','BS343')
	  
	 ,('YC112.1','P95','PKB112','BS85','NV09')
	 ,('YC112.2','P360','PKB111','BS348','BS85')

	 ,('YC113.1','P133','PKB113','BS117','NV10')
	 ,('YC113.2','PXNCC327','PKB113','BS409','BS118')
	 ,('YC113.3','PXNCC327','PKB113','BS409','BS118')
		 
	 ,('YC114.1','P134','PKB114','BS118','NV18')
	 ,('YC114.2','PXNCC326','PKB114','BS406','BS118')
	 ,('YC114.3','PXNCC326','PKB114','BS406','BS118')

	 ,('YC115.1','P32','PKB115','BS211','NV17')
	 ,('YC115.2','PXNCC326','PKB115','BS1208','BS211')
	 ,('YC115.3','P365','PKB115','BS332','BS211')

	 ,('YC116.1','P38','PKB116','BS212','NV16')

	 ,('YC117.1','P121','PKB117','BS397','NV06')
	 ,('YC117.2','PXNCC283','PKB117','BS82','BS397')
	 	 
	 ,('YC118.1','P69','PKB118','BS374','NV05')
	 ,('YC119.1','P120','PKB119','BS397','NV14')
	 ,('YC119.2','PXNCC284','PKB119','BS336','BS397')
	 
	 ,('YC120.1','P34','PKB120','BS28','NV17')
	 ,('YC120.2','PXNCC324','PKB120','BS1215','BS28')

	 
	 ,('YC121.1','P16','PKB121','BS16','NV18')
	 ,('YC121.2','P375','PKB121','BS93','BS16')
	 ,('YC121.3','PB19.8','PKB121','YT239','BS93')
	  

	 ,('YC122.1','P16','PKB122','BS183','NV20')
	 ,('YC122.2','P373','PKB122','BS94','BS183')
	 ,('YC122.3','PB19.4','PKB122','YT126','BS94')
	
	 ,('YC123.1','P133','PKB123','BS21','NV02')
	 ,('YC123.2','PXNCC327','PKB123','BS1213','BS21')
	 ,('YC123.3','PXNCC327','PKB123','BS1213','BS21')	 
	   
	 ,('YC124.1','P104','PKB124','BS358','NV06')
	 ,('YC124.2','PXNCC326','PKB123','BS1215','BS21')
	 ,('YC124.3','PXNCC326','PKB123','BS1215','BS21')	
	 
	 ,('YC125.1','P101','PKB125','BS108','NV16')
	 ,('YC125.2','PXNCC282','PKB125','BS340','BS108')
	 ,('YC125.3','P305','PKB125','BS1070','BS108')
	 ,('YC125.4','PB10.8','PKB125','YT197','BS1070')
	  
	 ,('YC126.1','P104','PKB126','BS1021','NV13')
	 ,('YC126.2','PXNCC285','PKB126','BS335','BS1021')
	 ,('YC126.3','P321','PKB126','TK26','BS1021')
	 ,('YC126.4','PB26.2','PKB126','YT140','TK26')
	 
	 ,('YC127.1','P105','PKB127','BS357','NV01')
	 ,('YC127.2','P321','PKB127','BS392','BS357')
	 ,('YC127.3','PB26.3','PKB127','YT273','BS392')
	 ,('YC127.4','PXNCC285','PKB127','BS335','BS357')

	 ,('YC128.1','P96','PKB128','BS345','NV14')
	 ,('YC129.1','P14','PKB129','BS13','NV12')

	 ,('YC130.1','P50','PKB130','BS231','NV01')
	 ,('YC130.2','PXNCC279','PKB130','BS335','BS231')
	 ,('YC130.3','PXNCC272','PKB130','BS340','BS231')
	 ,('YC130.4','P306','PKB130','BS1067','BS231')
	 ,('YC130.5','PB10.7','PKB130','YT197','BS1067')
	
	 ,('YC131.1','P253','PKB131','BS1113','NV05')
	 ,('YC131.2','P120','PKB131','BS1102','BS1113')
	 ,('YC131.3','PXNCC326','PKB131','BS414','BS1113')
	 ,('YC131.4','PXNCC326','PKB131','BS420','BS1113')
	
insert into Kham([MaYeuCau],[MSPhong],[MSPhieuKhamBenh],[MaNV],[MaNguoiYC])
values	 
	  ('YC132.1','P125','PKB132','BS141','NV19')
	 ,('YC132.2','P121','PKB132','BS99','BS141')
	 ,('YC132.3','PXNCC327','PKB132','BS1210','BS141')
	 ,('YC132.4','PXNCC327','PKB132','BS1211','BS141')
	 
	 ,('YC133.1','P253','PKB133','BS1111','NV14')
	 ,('YC133.2','P248','PKB133','BS1103','BS1111')
	 ,('YC133.3','PXNCC325','PKB133','BS1210','BS1111')
	 ,('YC133.4','PXNCC325','PKB133','BS1211','BS1111')

	 ,('YC134.1','P133','PKB134','BS20','NV11')
	 ,('YC134.2','PXNCC340','PKB134','BS417','BS20')
	 
	 ,('YC135.1','P50','PKB135','BS40','NV03')
	 ,('YC135.2','PXNCC282','PKB135','BS332','BS40')
	 ,('YC135.3','PXNCC274','PKB135','BS333','BS40')
	 ,('YC135.4','P305','PKB135','BS1066','BS40')
	 ,('YC135.5','P305','PKB135','BS1066','BS1066')
	 ,('YC135.6','PB01.10','PKB135','BS02','BS1066')

	 ,('YC136.1','P177','PKB136','BS596','NV05')
	 ,('YC136.2','P349','PKB136','BS743','BS596')
	 ,('YC136.3','PXNCC273','PKB136','BS973','BS596')

	 
	 ,('YC137.1','P134','PKB137','BS523','NV08')
	 ,('YC137.2','PXNCC327','PKB137','BS1207','BS523')
	 	 
	 ,('YC138.1','P38','PKB138','BS578','NV07')
	 ,('YC138.2','PXNCC264','PKB138','BS339','BS578')
	 ,('YC138.3','PXNCC326','PKB138','BS1211','BS578')

	 
	 ,('YC139.1','P13','PKB139','BS162','NV03')
	 ,('YC139.2','P15','PKB139','BS14','BS162')
	 ,('YC139.3','PB03.5','PKB139','BS165','BS114')
	 ,('YC139.4','P312','PKB139','BS114','BS162')

	 ,('YC140.1','P68','PKB140','BS277','NV10')
	 ,('YC140.2','P366','PKB40','BS340','BS277')
	 ,('YC140.3','PXNCC326','PKB40','BS103','BS277')


	 ,('YC141.1','P105','PKB141','BS132','NV11')
	 
	 ,('YC142.1','P134','PKB142','BS523','NV10')

	 ,('YC143.1','P135','PKB143','BS439','NV08')
	 ,('YC143.2','P319','PKB143','BS328','BS439')
	 ,('YC143.3','PB19.1','PKB143','BS328','BS328')

	 ,('YC144.1','P128','PKB144','BS425','NV05')
	 ,('YC144.2','P130','PKB144','BS143','BS425')
	 ,('YC144.3','PXNCC323','PKB144','BS1207','BS425')
	 
	 ,('YC145.1','P17','PKB145','BS16','NV01')
	 ,('YC145.2','P374','PKB145','TK25','BS16')
	 ,('YC145.3','PB19.6','PKB145','BS329','TK25')

	 ,('YC146.1','P128','PKB146','BS104','NV12')
	 ,('YC146.2','PXNCC322','PKB146','BS1215','BS104')

	 
	 ,('YC147.1','P64','PKB147','BS122','NV13')
	 ,('YC147.2','P68','PKB147','BS275','BS122')
	 ,('YC148.1','P65','PKB148','BS271','NV20')
	 ,('YC149.1','P120','PKB149','BS397','NV17')
	 ,('YC149.2','PXNCC285','PKB149','BS331','BS397')

	
	 ,('YC150.1','P17','PKB150','BS172','NV14')



insert into ChuanDoan([MaChuanDoan],[MaYeuCau],[MaBenh],[MSPhieuKhamBenh],[MaNV],[KetLuan],[LoiKhuyen],[MaLoaiBA])
values
		 ('CD01','YC01.1','B01','PKB01','BS272',N'Bị cảm cúm',N'Uống đủ nước,cần nghỉ ngơi','LBA01')
		,('CD02','YC02.1','B29','PKB02','BS272',N'Bị mất ngủ',N'Tập yoga và thiền để giảm stress','LBA10')
		,('CD03','YC03.2','B04','PKB03','BS231',N'Bị ung thư phổi',N'Phẫu thuật loại bỏ khối u','LBA07')
		,('CD04','YC04.1','B13','PKB04','BS115',N'Bị viêm ruột thừa',N'Phẫu thuật viêm ruột thừa','LBA02')
		,('CD05','YC05.1','B01','PKB05','BS345',N'Bị cảm cúm',N'Uống đủ nước,cần nghỉ ngơi','LBA01')
		,('CD06','YC06.1','B09','PKB06','BS474',N'Đau mắt đỏ',N'Nhỏ mắt','LBA17')
		,('CD07','YC07.1','B41','PKB07','BS221',N'Bị đau khớp',N'Tập thể dục các bài nhẹ nhàng,massage để giảm đau','LBA14')
		,('CD08','YC08.1','B01','PKB08','BS991',N'Bị cảm cúm',N'Ăn nhiều hoa quả, cần nghỉ ngơi','LBA01')
		,('CD09','YC09.2','B44','PKB09','BS523',N'Bị cường giáp',N'Giảm caffeine và stress','LBA16')
		,('CD10','YC10.1','B04','PKB10','BS703',N'Bị ung thư phổi',N'Phẫu thuật','LBA07')
		,('CD11','YC11.2','B05','PKB11','BS1021',N'Bị Alzheimer',N'Chơi giải đố, bài tập trí não','LBA02')
		,('CD12','YC12.1','B04','PKB12','BS346',N'Ung thư phổi',N'Cấp cứu khẩn cấp','LBA07')
		,('CD13','YC13.1','B10','PKB13','BS785',N'Bị sỏi thận',N'Uống nhiều nước, giảm lượng muối và ăn nhiều rau củ','LBA16')
		,('CD14','YC14.1','B11','PKB14','BS344',N'Bị viêm tai giữa',N'Đặt túi nước lên tai để giảm cảm giác khó chịu','LBA11')
		,('CD15','YC15.1','B11','PKB15','BS986',N'Bị viêm tai giữa',N'Sử dụng thuốc giảm đau và áp dụng nhiệt ấm để giảm khó chịu','LBA11')
		,('CD16','YC16.2','B12','PKB16','BS506',N'Bị xơ gan',N'Ngừng uống rượu hoàn toàn','LBA12')
		,('CD17','YC17.2','B13','PKB17','BS17',N'Bị viêm ruột thừa',N'Cần phẫu thuật gấp','LBA02')
		,('CD18','YC18.1','B01','PKB18','BS994',N'Bị cảm cúm',N'Uống nhiều nước,nước ép và nghỉ ngơi đầy đủ','LBA01')
		,('CD19','YC19.1','B01','PKB19','BS991',N'Bị cảm cúm',N'Uống nhiều nước,nước ép và nghỉ ngơi đầy đủ','LBA01')
		,('CD20','YC20.1','B25','PKB20','BS139',N'Bị parkinson',N'Tham gia các hoạt động thể chất,các kỹ thuật giảm stress','LBA20')
		,('CD21','YC21.1','B15','PKB21','BS1111',N'Bị chứng hoảng sợ khi ngủ',N'','LBA10')
		,('CD22','YC22.1','B09','PKB22','BS476',N'Bị đau mắt đỏ',N'Nghỉ ngơi mắt,hạn chế sử dụng lens','LBA17')
		,('CD23','YC23.2','B08','PKB23','BS21',N'Bị béo phì',N'Tăng cường vận động, tập trung vào thực phẩm ít calo và giàu chất xơ','LBA16')
		,('CD24','YC24.1','B23','PKB24','BS1309',N'Bị sốt rét',N'Nghỉ ngơi và uống nhiều nước','LBA05')
		,('CD25','YC25.1','B29','PKB25','BS100',N'Bị chứng mất ngủ',N'Luyện thể dục đều đặn,tránh caffeine và nicotine','LBA10')
		,('CD26','YC26.1','B29','PKB26','BS357',N'Bị mất ngủ',N'Tránh ăn quá no hoặc đói trước khi ngủ, tránh ngủ trưa dài hoặc muộn','LBA10')
		,('CD27','YC27.1','B27','PKB27','BS203',N'Ung thư da',N'Xạ trị hoặc hóa trị, phẫu thuật','LBA09')
		,('CD28','YC28.1','B60','PKB28','BS497',N'Bị trĩ nội',N'Ăn uống nhiều chất xơ,uống nhiều nước và tránh ngồi lâu','LBA12')
		,('CD29','YC29.1','B32','PKB29','BS13',N'Bị loạn thị',N'Nên đi đo mắt','LBA17')
		,('CD30','YC30.1','B18','PKB30','BS248',N'Bị lao phổi',N'Không uống rượu bia và các chất kích thích, hút thuốc','LBA05')
		,('CD31','YC31.2','B30','PKB31','BS132',N'Mất cân bằng nội tiết tố',N'Tập thể dục thường xuyên,tránh căng thẳng','LBA09')
		,('CD32','YC32.1','B09','PKB32','BS475',N'Bị đau mắt đỏ',N'Chườm ấm mắt nhưng không giảm thì nên chườm lạnh','LBA17')
		,('CD33','YC33.1','B44','PKB33','BS523',N'Bị cường giáp',N'Bổ sung vitamin D và omega 3, các thực phẩm giàu kẽm','LBA16')
		,('CD34','YC34.1','B16','PKB34','BS222',N'Bị gout',N'Uống nhiều nước,tập luyện thể dục và cần kiêng rượu bia, nước ngọt','LBA14')
		,('CD35','YC35.1','B17','PKB35','BS345',N'Bị đột quỵ',N'Cấp cứu khẩn cấp','LBA20')
		,('CD36','YC36.2','B19','PKB36','BS210',N'Bị mụn cóc',N'Cắt bỏ hoặc áp lạnh','LBA09')
		,('CD37','YC37.1','B01','PKB37','BS10',N'Bị cảm cúm',N'Uống nhiều nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD38','YC38.1','B01','PKB38','TK02',N'Bị cảm cúm',N'Uống nhiều nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD39','YC39.1','B09','PKB39','BS109',N'Bị đau mắt',N'Nghỉ ngơi và dùng thuốc nhỏ mắt','LBA17')
		,('CD40','YC40.1','B22','PKB40','BS560',N'Bị sủi mào gà',N'','LBA05')
		,('CD41','YC41.1','B42','PKB41','BS212',N'Bị đau thắt ngực',N'Khi đau dừng lại và nghỉ ngơi ngay lập tức','LBA18')
		,('CD42','YC42.2','B43','PKB42','BS34',N'Bị cơ tim giãn nở',N'Khi mệt mỏi nên hạn chế lượng muối, bỏ rượu','LBA18')
		,('CD43','YC43.1','B55','PKB43','BS558',N'Bị đậu mùa',N'Hạn chế tiếp xúc nhiều người, không dùng chung đồ dùng cá nhân','LBA05')
		,('CD44','YC44.1','B60','PKB44','BS116',N'Bị trĩ nội',N'Tránh đồ uống có cồn và có chứa chất kích thích khác','LBA12')
		,('CD45','YC45.1','B18','PKB45','BS274',N'Bị lao phổi',N'Không uống bia rượu, các chất kích thích, cafein, trà đặc, không hút thuốc lá','LBA05')
		,('CD46','YC46.1','B34','PKB46','BS436',N'Bị u não',N'Phẫu thuật gấp','LBA20')
		,('CD47','YC47.1','B05','PKB47','BS359',N'Bị Alzheimer',N'Chế biến thức ăn thì cắt nhỏ và các loại đồ ăn mềm','LBA20')
		,('CD48','YC48.1','B01','PKB48','BS345',N'Bị cảm cúm',N'Nghỉ ngơi đầy đủ','LBA01')
		,('CD49','YC49.2','B12','PKB49','BS177',N'Bị xơ gan',N'Kiêng đồ ăn nhanh,hoàn toàn rượu bia,đồ uống có cồn và thức ăn mặn','LBA12')
		,('CD50','YC50.1','B52','PKB50','BS429',N'Bị dại',N'Tiêm phòng dại','LBA05')
		,('CD51','YC51.1','B52','PKB51','BS1312',N'Bị dại',N'Tiêm phòng dại','LBA05')
		,('CD52','YC52.1','B56','PKB52','BS162',N'Bị đục thủy tinh thể',N'Điều trị bằng phẫu thuật thay tinh thể','LBA17')
		,('CD53','YC53.1','B48','PKB53','BS523',N'Bị hội chứng thận hư',N'Kiêng gia vị kích thích,rượu bia và thực phẩm nhiều muối','LBA21')
		,('CD54','YC54.1','B42','PKB54','BS584',N'Bị đau thắt ngực',N'Dấu hiệu cho bệnh tim','LBA18')
		,('CD55','YC55.1','B37','PKB55','BS04',N'Bị viêm mũi dị ứng thời tiết',N'Tránh tiếp túc với các chất gây dị ứng','LBA13')
		,('CD56','YC56.1','B09','PKB56','BS456',N'Bị đau mắt',N'Kiêng đồ cay nóng,đồ uống có cồn và các chất kích thích','LBA17')
		,('CD57','YC57.1','B34','PKB57','BS459',N'Bị u não',N'Phẫu thuật','LBA20')
		,('CD58','YC58.1','B01','PKB58','BS991',N'Bị cảm cúm',N'Uống nước ép và nhiều nước đầy đủ,nghỉ ngơi đầy đủ','LBA01')
		,('CD59','YC59.1','B09','PKB59','BS474',N'Bị đau mắt',N'Nghỉ ngơi mắt nhiều','LBA17')
		,('CD60','YC60.1','B56','PKB60','BS477',N'Bị đục thủy tinh thể',N'Sử dụng kính hỗ trợ hoặc phẫu thuật','LBA17')
		,('CD61','YC61.1','B53','PKB61','BS11',N'Bị dị ứng mắt',N'Rửa mắt bằng nước lạnh,nước muối sinh lý','LBA17')
		,('CD62','YC62.1','B06','PKB62','BS105',N'Bị sốt xuất huyết',N'Vệ sinh nơi ở sạch sẽ','LBA05')
		,('CD63','YC63.1','B60','PKB63','BS17',N'Bị trĩ nội',N'Ăn nhiều chất xơ','LBA12')
		,('CD64','YC64.1','B57','PKB64','BS170',N'Bị gan to',N'Bổ sung nhiều chất xơ, thiết lập chế đố ăn khỏe mạnh','LBA12')
		,('CD65','YC65.1','B46','PKB65','BS111',N'Bị băng huyết sau sinh',N'','LBA06')
		,('CD66','YC66.1','B52','PKB66','BS1309',N'Bị dại',N'Tiêm phòng dại','LBA05')

		,('CD67','YC67.1','B24','PKB67','BS786',N'Bị sán lá gan',N'','LBA05')
		,('CD68','YC68.1','B44','PKB68','BS525',N'Bị cường giáp',N'Kiêng thực phẩm giàu i-ốt và có hàm lượng đường cao','LBA16')
		,('CD69','YC69.1','B08','PKB69','BS1025',N'Bị béo phì',N'Kiêng thực phẩm nhiều chất béo và lượng đường cao,tập các bài tập nhẹ nhàng và giảm stress','LBA16')
		,('CD70','YC70.1','B23','PKB70','BS425',N'Bị sốt rét',N'Nằm nghỉ thoáng mát,mặc đồ mỏng','LBA05')
		,('CD71','YC71.1','B23','PKB71','BS426',N'Bị sốt rét',N'Nằm nghỉ thoáng mát, mặc đồ mỏng','LBA05')
		,('CD72','YC72.1','B04','PKB72','BS705',N'Bị ung thư phổi',N'Không hút thuốc nữa','LBA07')
		,('CD73','YC73.1','B44','PKB73','BS523',N'Bị cường giáp',N'Tránh stress và hoạt động thể chất cường độ cao','LBA16')
		,('CD74','YC74.1','B41','PKB74','BS598',N'Bị đau khớp',N'Tránh vận động quá sức, giữ 1 tự thế cố định quá lâu','LBA14')
		,('CD75','YC75.1','B55','PKB75','BS206',N'Bị đậu mùa',N'Tránh gãi hoặc chạm vào các nốt phát ban, thức ăn và đồ uống kích thích','LBA05')
		,('CD76','YC76.1','B46','PKB76','BS126',N'Bị băng huyết sau sinh',N'','LBA06')
		,('CD77','YC77.1','B25','PKB77','BS397',N'Bị parkinson',N'Tránh stress,đồ uống có caffein và rượu','LBA20')
		,('CD78','YC78.1','B25','PKB78','BS397',N'Bị parkinson',N'Tránh stress,thuốc lá và chất độc hại','LBA20')
		,('CD79','YC79.1','B12','PKB79','BS178',N'Bị xơ gan',N'Tránh rượu,thuốc lá và hóa chất độc hại','LBA12')

		,('CD80','YC80.1','B12','PKB80','BS185',N'Bị xơ gan',N'Tránh rượu,thuốc lá và hóa chất độc hại','LBA12')
		,('CD81','YC81.1','B34','PKB81','BS434',N'Bị u não',N'Phẫu thuật gấp','LBA20')
		,('CD82','YC82.1','B09','PKB82','BS162',N'Bị đau mắt đỏ',N'Tránh chạm vào mắt,bơi lội','LBA17')
		,('CD83','YC83.2','B34','PKB83','BS144',N'Bị u não',N'Phẫu thuật gấp','LBA20')
		,('CD84','YC84.1','B01','PKB84','BS345',N'Bị cảm cúm',N'Uống nhiều nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD85','YC85.1','B01','PKB85','BS991',N'Bị cảm cúm',N'Uống nhiều nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD86','YC86.1','B48','PKB86','BS375',N'Bị hội chứng thận hư',N'Tránh tiêu thụ nhiều muối,thực phẩm giàu protein, tiêu thụ nhiều chất lỏng','LBA21')
		,('CD87','YC87.1','B01','PKB87','BS991',N'Bị cảm cúm',N'Uống nhiều nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD88','YC88.1','B42','PKB88','BS578',N'Bị đau thắt ngực',N'Tránh stress và lo lắng','LBA18')
		,('CD89','YC89.1','B40','PKB89','BS277',N'Bị đậu mùa khỉ',N'Tránh tiếp xúc gần gũi và giữ vệ sinh môi trường','LBA05')
		,('CD90','YC90.1','B34','PKB90','BS359',N'Bị u não',N'','LBA20')
		,('CD91','YC91.1','B60','PKB91','BS172',N'Bị trĩ nội',N'Tránh ngồi hoặc đứng quá lâu','LBA12')
		,('CD92','YC92.1','B29','PKB92','BS100',N'Bị mất ngủ',N'Tránh ngủ quá dài vào buổi trưa','LBA10')
		,('CD93','YC93.1','B32','PKB93','BS476',N'Bị loạn thị',N'Tránh ánh sáng chói hoặc không đủ sáng,nhìn chằm chằm màn hình thời gian dài','LBA17')

		,('CD94','YC94.1','B32','PKB94','BS165',N'Bị loạn thị',N'Tránh ánh sáng chói hoặc không đủ sáng,nhìn chằm chằm màn hình thời gian dài','LBA17')
		,('CD95','YC95.1','B25','PKB95','BS358',N'Bị parkinson',N'Tránh căng thẳng và lo lắng,mất cân bằng','LBA20')
		,('CD96','YC96.1','B57','PKB96','BS272',N'Bị gan to',N'Tránh rượu,thuốc lá và thực phẩm chế biến-đóng gói','LBA12')
		,('CD97','YC97.1','B23','PKB97','BS430',N'Bị sốt rét',N'','LBA05')
		,('CD98','YC98.2','B41','PKB98','BS38',N'Bị đau khớp',N'Tránh vận động quá sức','LBA14')
		,('CD99','YC99.2','B41','PKB99','BS227',N'Bị đau khớp',N'Tránh vận động quá sức','LBA14')
		,('CD100','YC100.1','B25','PKB100','BS98',N'Bị parkinson',N'','LBA20')
		,('CD101','YC101.2','B24','PKB101','BS502',N'Bị sán lá gan',N'','LBA05')
		,('CD102','YC102.2','B53','PKB102','BS163',N'Bị dị ứng mắt',N'Sử dụng nước muối sinh lý để vệ sinh mắt hàng ngày','LBA17')
		,('CD103','YC103.1','B09','PKB103','BS480',N'Bị đau mắt',N'Tránh chạm vào mắt','LBA17')
		,('CD104','YC104.1','B03','PKB104','BS214',N'Bị bệnh tim mạch',N'Tập thể dục đều đặn và quản lý cân nặng,khám bác sĩ định kỳ','LBA18')
		,('CD105','YC105.1','B53','PKB105','BS475',N'Bị dị ứng mắt',N'Sử dụng nước muối sinh lý để vệ sinh mắt hàng ngày','LBA17')
		,('CD106','YC106.1','B02','PKB106','BS275',N'Bị đái tháo đường',N'Ăn nhiều rau,trái cây,ngũ cốc nguyên hạt','LBA16')

		,('CD107','YC107.1','B52','PKB107','BS1314',N'Bị dại',N'Tiêm phòng dại','LBA05')
		,('CD108','YC108.1','B14','PKB108','BS31',N'Bị hẹp van động mạch chủ',N'Quản lý huyết áp','LBA18')
		,('CD109','YC109.1','B44','PKB109','BS496',N'Bị cường giáp',N'Tránh stress và hoạt động thể chất cường độ cao','LBA16')
		,('CD110','YC110.1','B14','PKB110','BS575',N'Bị hẹp van động mạch chủ',N'Quản lý huyết áp và giữ cân nậng khỏe mạnh','LBA18')
		,('CD111','YC111.1','B11','PKB111','BS343',N'Bị viêm tai giữa',N'Giữ cho tai khô, chú ý đến vệ sinh mũi và họng','LBA11')
		,('CD112','YC112.1','B11','PKB112','BS85',N'Bị viêm tai giữa',N'Giữ cho tai khô, chú ý đến vệ sinh mũi và họng','LBA11')
		,('CD113','YC113.1','B02','PKB113','BS117',N'Bị đái tháo đường',N'Theo dõi đường huyết,ăn giàu rau, trái cây và ngũ cốc nguyên hạt','LBA16')
		,('CD114','YC114.1','B02','PKB114','BS118',N'Bị đái tháo đường',N'Theo dõi đường huyết,ăn giàu rau, trái cây và ngũ cốc nguyên hạt','LBA16')
		,('CD115','YC115.1','B19','PKB115','BS211',N'Bị mụn cóc',N'Không chạm hoặc gãi,giữ cho mụn cóc khô ráo','LBA09')
		,('CD116','YC116.1','B21','PKB116','BS212',N'Bị suy tĩnh mạn tính',N'Mặc áo giãn tĩnh mạch và tăng cường hoạt động','LBA18')
		,('CD117','YC117.1','B25','PKB117','BS397',N'Bị parkinson',N'','LBA20')
		,('CD118','YC118.1','B01','PKB118','BS374',N'Bị cảm cúm',N'Uống đủ nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD119','YC119.1','B25','PKB119','BS397',N'Bị parkinson',N'','LBA20')

		,('CD120','YC120.1','B40','PKB120','BS28',N'Bị đậu mùa khỉ',N'Tránh tiếp xúc gần','LBA05')
		,('CD121','YC121.1','B60','PKB121','BS16',N'Trĩ nội',N'Ăn nhiều chất xơ và uống nhiều nước','LBA12')
		,('CD122','YC122.1','B60','PKB122','BS183',N'Trĩ nội',N'Ăn nhiều chất xơ và uống nhiều nước','LBA12')
		,('CD123','YC123.1','B30','PKB123','BS21',N'Bị rối loạn nội tiết tố',N'Giữ gìn chế độ ăn lành mạnh','LBA16')
		,('CD124','YC124.1','B30','PKB124','BS358',N'Bị rối loạn nội tiết tố',N'Giữ gìn chế độ ăn lành mạnh','LBA16')
		,('CD125','YC125.1','B04','PKB125','BS108',N'Bị ung thư phổi',N'','LBA07')
		,('CD126','YC126.1','B59','PKB126','BS1021',N'Bị liệt mặt',N'Vận động và massage mặt','LBA20')
		,('CD127','YC127.1','B60','PKB127','BS357',N'Bị liệt mặt',N'Vận động và massage mặt','LBA20')
		,('CD128','YC128.1','B01','PKB128','BS345',N'Bị cảm cúm',N'Uống nước và nghỉ ngơi đầy đủ','LBA01')
		,('CD129','YC129.1','B54','PKB129','BS13',N'Bị dị ứng mắt',N'Giữ nhà cửa sạch sẽ,không chà xát mắt','LBA17')
		,('CD130','YC130.1','B04','PKB130','BS231',N'Bị ung thư phổi',N'','LBA07')
		,('CD131','YC131.1','B15','PKB131','BS1113',N'Bị hoảng sợ khi ngủ',N'Tránh chất kích thích và các phương pháp thiền như yoga,thiền','LBA10')
		,('CD132','YC132.1','B15','PKB132','BS141',N'Bị hoảng sợ khi ngủ',N'Tránh chất kích thích và các phương pháp thiền như yoga,thiền','LBA10')

		,('CD133','YC133.1','B15','PKB133','BS1111',N'Bị hoảng sợ khi ngủ',N'Tránh chất kích thích và các phương pháp thiền như yoga,thiền','LBA10')
		,('CD134','YC134.1','B23','PKB134','BS20',N'Bị sốt rét',N'','LBA05')
		,('CD135','YC135.1','B04','PKB135','BS40',N'Bị ung thư phổi',N'','LBA10')
		,('CD136','YC136.1','B41','PKB136','BS596',N'Bị nhức xương khớp',N'Bổ sung thực phẩm giàu omega-3,duy trì cân nặng hợp lý để giảm áp lực','LBA14')
		,('CD137','YC137.1','B02','PKB137','BS523',N'Bị đái tháo đường',N'Kiểm tra chân hàng ngày để phát hiện sớm các dấu hiệu của vết thương, nhiễm trùng hoặc các vấn đề khác','LBA16')
		,('CD138','YC138.1','B03','PKB138','BS578',N'Bị tim mạch',N'Hãy chọn một chế độ ăn giàu trái cây, rau, ngũ cốc nguyên hạt, và protein từ thực vật hoặc các nguồn protein lean','LBA18')
		,('CD139','YC139.1','B56','PKB139','BS162',N'Bị đục thủy tinh thể',N'Phẫu thuật','LBA17')
		,('CD140','YC140.1','B44','PKB140','BS277',N'Bị cường giáp',N'Thăm khám định kỳ','LBA16')
		,('CD141','YC141.1','B05','PKB141','BS132',N'Bị Alzheimer',N'Hoạt động như đọc sách, giải đố, hoặc học một kỹ năng mới có thể giúp duy trì chức năng nhận thức.','LBA20')
		,('CD142','YC142.1','B05','PKB142','BS523',N'Bị Alzheimer',N'Hoạt động như đọc sách, giải đố, hoặc học một kỹ năng mới có thể giúp duy trì chức năng nhận thức.','LBA20')
		,('CD143','YC143.1','B13','PKB143','BS439',N'Bị viêm ruột thừa',N'','LBA02')
		,('CD144','YC144.1','B40','PKB144','BS425',N'Bị đậu mùa khỉ',N'Tránh gần gũi với mọi người','LBA05')
		,('CD145','YC145.1','B60','PKB145','BS16',N'Bị trĩ nội',N'Ăn nhiều chất xơ,rau củ','LBA12')

		,('CD146','YC146.1','B40','PKB146','BS104',N'Bị đậu mùa khỉ',N'Tránh gần gũi với mọi người','LBA05')
		,('CD147','YC147.2','B08','PKB147','BS275',N'Bị béo phì',N'Hạn chế thực phẩm chứa nhiều đường, chất béo để tránh nguy cơ ảnh hưởng sức khỏe','LBA16')
		,('CD148','YC148.1','B08','PKB148','BS271',N'Bị béo phì',N'Hạn chế thực phẩm chứa nhiều đường, chất béo để tránh nguy cơ ảnh hưởng sức khỏe','LBA16')
		,('CD149','YC149.1','B25','PKB149','BS397',N'Bị parkinson',N'','LBA20')
		,('CD150','YC150.1','B07','PKB150','BS331',N'Bị táo bón',N'Ăn thực phẩm có nhiều chất xơ. Các lựa chọn tốt là trái cây, rau, và ngũ cốc','LBA12')
		
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
------------------------------------------Làm phẫu thuật-----------------------------------------------------
	 ('PKB03','YC03.5','BS1061','P303','DVCT02.13','2022/02/16',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB04','YC04.2','BS323','P299','DVCT02.3','2022/06/18',N'Thành công',N'Bình thường',N'Phẫu thuật','LBA22'),
     ('PKB10','YC10.4','BS386','P303','DVCT02.13','2022/01/25',N'Thành công',N'Rất cao',N'Phẫu thuật','LBA22'),
     ('PKB108','YC108.2','BS76','P300','DVCT02.31','2022/06/18',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB110','YC110.1','BS575','P170','DVCT02.31','2022/10/20',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB12','YC12.5','BS1062','P304','DVCT02.13','2022/06/24',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB121','YC121.2','BS93','P375','DVCT02.10','2022/09/27',N'Thành công',N'Thấp',N'Phẫu thuật','LBA22'),
     ('PKB125','YC125.3','BS1070','P305','DVCT02.13','2022/03/24',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB126','YC126.3','TK26','P321','DVCT02.32','2023/09/21',N'Thất bại',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB127','YC127.2','BS392','P321','DVCT02.32','2022/09/18',N'Thất bại',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB13','YC13.4','BS1069','P304','DVCT02.2','2022/04/20',N'Thành công',N'Bình thường',N'Phẫu thuật','LBA22'),
     ('PKB135','YC135.4','BS1066','P305','DVCT02.13','2022/06/05',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),

     ('PKB139','YC139.4','BS114','P312','DVCT02.7','2023/09/02',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB143','YC143.2','BS328','P319','DVCT02.3','2022/04/29',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB145','YC145.2','TK25','P374','DVCT02.10','2022/08/30',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB17','YC17.3','BS76','P301','DVCT02.3','2022/01/29',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB27','YC27.3','BS211','P314','DVCT02.21','2022/06/20',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB28','YC28.2','BS1061','P304','DVCT02.10','2022/12/24',N'Thành công',N'Thấp',N'Phẫu thuật','LBA22'),

     ('PKB36','YC36.3','BS121','P315','DVCT02.11','2022/06/10',N'Thành công',N'Thấp',N'Phẫu thuật','LBA22'),
     ('PKB42','YC42.3','BS1062','P305','DVCT02.26','2022/03/07',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB44','YC44.2','BS1070','P372','DVCT02.10','2024/03/06',N'Thành công',N'Thấp',N'Phẫu thuật','LBA22'),
     ('PKB46','YC46.3','BS1091','P318','DVCT02.22','2022/03/06',N'Thành công',N'Rất cao',N'Phẫu thuật','LBA22'),
     ('PKB57','YC57.3','BS387','P319','DVCT02.22','2023/04/23',N'Thất bại',N'Rất cao',N'Phẫu thuật','LBA22'),
     ('PKB60','YC60.2','BS11','P311','DVCT02.7','2022/09/16',N'Thành công',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB63','YC63.2','BS1070','P373','DVCT02.10','2022/05/18',N'Thấp',N'Cao',N'Phẫu thuật','LBA22'),
     ('PKB65','YC65.2','TK20','PXNCC271','DVCT02.27','2022/05/21',N'Thành công',N'Cao',N'Phẫu thuật','LBA22')
	,('PKB67','YC67.3','BS1075','P305','DVCT02.6','2022/05/19',N'Thành công',N'Cao',N'Phẫu thuật','LBA22')
	,('PKB72','YC72.4','BS1066','P304','DVCT02.13','2022/12/21',N'Thành công',N'Cao',N'Phẫu thuật','LBA22')
	,('PKB76','YC76.3','BS322','P290','DVCT02.27','2022/01/25',N'Thành công',N'Rất cao',N'Phẫu thuật','LBA22')
	,('PKB81','YC81.3','BS387','P319','DVCT02.22','2022/07/01',N'Thành công',N'Rất cao',N'Phẫu thuật','LBA22')
	,('PKB83','YC83.4','BS393','P320','DVCT02.22','2023/07/04',N'Thành công',N'Rất cao',N'Phẫu thuật','LBA22')
	,('PKB90','YC90.3','BS388','P319','DVCT02.22','2022/08/09',N'Thành công',N'Rất cao',N'Phẫu thuật','LBA22')
	,('PKB91','YC91.2','BS1067','P374','DVCT02.10','2022/05/09',N'Thành công',N'Rất thấp',N'Phẫu thuật','LBA22')
	
	-----------------------------------------------Làm XNCC---------------------------------------------------------
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
	 ('PKB03','YC03.3','BS330','PXNCC263','DVCT01.8','2022/02/16',N'Phát hiện mờ ảnh hình khối ở phổi phải',null,'XNCC','LBA23')
	,('PKB10','YC10.2','BS336','PXNCC281','DVCT01.3','2022/01/25',N'Phát hiện tăng hấp thu FDG ở phổi trái, có thể là dấu hiệu của ung thư phổi hoặc tình trạng viêm',null,'XNCC','LBA23')
	,('PKB10','YC10.3','BS974','PXNCC271','DVCT01.8','2022/01/25',N'Phát hiện mờ ảnh hình khối ở phổi phải',null,'XNCC','LBA23')
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
	 ('PKB100','YC100.1','TK20','PXNCC286','DVCT01.4','2022/08/13',N'Sự suy giảm hoạt động ở ganglia cơ sở',null,'XNCC','LBA23')
	,('PKB104','YC104.2','BS332','PXNCC266','DVCT01.1','2022/12/13',N'Suy giảm chức năng bơm máu của tim',null,'XNCC','LBA23')
	,('PKB104','YC104.3','BS1206','PXNCC325','DVCT03.4','2022/12/13',N'205, 180, 130, 35',null,'XNCC','LBA23')
	,('PKB106','YC106.3','BS1203','PXNCC325','DVCT03.1','2022/11/12',N'Mức trên 200 mg/dL',null,'XNCC','LBA23')
	,('PKB106','YC106.4','BS1203','PXNCC325','DVCT03.2','2022/11/12',N'6.8%',null,'XNCC','LBA23')	
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values		
	 ('PKB107','YC107.2','BS409','PXNCC337','DVCT03.23','2022/02/18',N'Positive',null,'XNCC','LBA23')
	,('PKB113','YC113.2','BS409','PXNCC327','DVCT03.1','2022/01/05',N'98',null,'XNCC','LBA23')
	,('PKB113','YC113.3','BS409','PXNCC327','DVCT03.2','2022/01/05',N'5.5%',null,'XNCC','LBA23')
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
	 ('PKB114','YC114.2','BS406','PXNCC326','DVCT03.1','2022/01/05',N' 190mg/DL',null,'XNCC','LBA23')
	,('PKB114','YC114.3','BS406','PXNCC326','DVCT03.2','2022/01/05',N'7.2%',null,'XNCC','LBA23')
	,('PKB115','YC115.2','BS1208','PXNCC326','DVCT03.18','2022/09/08',N'Cao',null,'XNCC','LBA23')
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
	 ('PKB117','YC117.2','BS82','PXNCC283','DVCT01.4','2023/09/08',N'Sự teo nhẹ của não',null,'XNCC','LBA23')
	,('PKB119','YC119.2','BS336','PXNCC284','DVCT01.4','2022/05/28',N'Sự teo nhẹ của não',null,'XNCC','LBA23')
	,('PKB12','YC12.3','BS332','PXNCC279','DVCT01.3','2022/03/24',N'Khối u quá trình chuyển hóa cao ở phổi phải',null,'XNCC','LBA23')
	,('PKB12','YC12.4','BS334','PXNCC273','DVCT01.8','2022/03/24',N'Có khối u được quan sát trong phổi phải',null,'XNCC','LBA23')

	,('PKB120','YC120.2','BS1215','PXNCC324','DVCT03.20','2023/09/08',N'DNA của virus đậu mùa khỉ đã được phát hiện trong mẫu',null,'XNCC','LBA23')
	,('PKB123','YC123.2','BS1213','PXNCC327','DVCT03.1','2022/05/21',N'Bình thường',null,'XNCC','LBA23')
	,('PKB123','YC123.3','BS1213','PXNCC327','DVCT03.18','2022/05/21',N'Bất thường',null,'XNCC','LBA23')	
	,('PKB124','YC124.2','BS1215','PXNCC326','DVCT03.1','2022/06/09',N'Bình thường',null,'XNCC','LBA23')
	,('PKB124','YC124.3','BS1215','PXNCC326','DVCT03.18','2022/06/09',N'Bất thường',null,'XNCC','LBA23')
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
	 ('PKB125','YC125.2','BS340','PXNCC282','DVCT01.3','2022/03/24',N'Khối u quá trình chuyển hóa cao ở phổi phải',null,'XNCC','LBA23')	
	,('PKB126','YC126.2','BS335','PXNCC285','DVCT01.4','2023/06/04',N'Phát hiện khối u hoặc tổn thương tại khu vực điều khiển cơ mặt',null,'XNCC','LBA23')	
	,('PKB13','YC13.3','BS974','PXNCC274','DVCT01.5','2022/01/25',N'Phát hiện sỏi',null,'XNCC','LBA23')	
	
	,('PKB130','YC130.2','BS335','PXNCC279','DVCT01.3','2022/06/17',N'Khối u quá trình chuyển hóa cao ở phổi phải',null,'XNCC','LBA23')
	,('PKB130','YC130.3','BS340','PXNCC272','DVCT01.8','2022/06/17',N'Có khối u được quan sát trong phổi phải',null,'XNCC','LBA23')	
	,('PKB132','YC132.3','BS1210','PXNCC327','DVCT03.18','2024/01/07',N'Mức cortisol cao, có thể do stress',null,'XNCC','LBA23')
	,('PKB132','YC132.4','BS1211','PXNCC327','DVCT03.6','2024/01/07',N'Bình thường',null,'XNCC','LBA23')
insert into LamPhauThuat_XNCC([MSPhieuKhamBenh],[MaYeuCau],[MaNV],[MSPhong],[MaLoaiChiTietDV],[ThoiGianThucHien],[KetQua],[MucDoRuiRo],[Loai],[MaLoaiBA])
values
	 ('PKB133','YC133.3','BS1210','PXNCC325','DVCT03.18','2022/06/11',N'Mức cortisol cao, có thể do stress',null,'XNCC','LBA23')
	,('PKB133','YC133.4','BS1211','PXNCC325','DVCT03.6','2022/06/11',N'Bình thường',null,'XNCC','LBA23')
	,('PKB134','YC134.2','BS417','PXNCC340','DVCT03.14','2022/01/12',N'Kháng thuốc',null,'XNCC','LBA23')---------coi lại xét nghiệm kháng thuốc sốt rét loại nào
	,('PKB135','YC135.2','BS332','PXNCC282','DVCT01.3','2022/01/05',N'Khối u quá trình chuyển hóa cao ở phổi phải',null,'XNCC','LBA23')
	,('PKB135','YC135.3','BS333','PXNCC274','DVCT01.8','2022/01/05',N'Có khối u được quan sát trong phổi phải',null,'XNCC','LBA23')
	,('PKB136','YC136.3','BS973','PXNCC273','DVCT01.11','2022/11/22',N'Phát hiện dấu hiệu thoái hóa khớp gối',null,'XNCC','LBA23')
	,('PKB137','YC137.2','BS1207','PXNCC327','DVCT03.1','2022/11/11',N'Cao,Mức đường huyết lúc đói là 180 mg/dL',null,'XNCC','LBA23')

	,('PKB138','YC138.2','BS339','PXNCC264','DVCT01.1','2022/09/18',N'Có dấu hiệu của suy tim',null,'XNCC','LBA23')
	,('PKB138','YC138.3','BS1211','PXNCC326','DVCT03.4','2022/09/18',N'Cholesterol cao, LDL cao, HDL thấp',null,'XNCC','LBA23')

insert into ToaThuoc(MaChuanDoan,MaToaThuoc,MSPhieuKhamBenh,MSThuoc,SoLuong,NgayCap,HDSuDung,MaNV)
values
	   ('CD01','TT01','PKB01','TH01',10,'2022/09/24',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD01','TT01','PKB01','TH02',10,'2022/09/24',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD05','TT05','PKB05','TH01',10,'2022/10/23',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD05','TT05','PKB05','TH02',10,'2022/10/23',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD08','TT08','PKB08','TH01',15,'2022/02/09',N'Uống sau mỗi bữa ăn','BS69')
	  ,('CD08','TT08','PKB08','TH02',15,'2022/02/09',N'Uống sau mỗi bữa ăn','BS69')
	  ,('CD118','TT118','PKB118','TH01',12,'2022/08/16',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD118','TT118','PKB118','TH02',12,'2022/08/16',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD128','TT128','PKB128','TH01',5,'2022/10/11',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD128','TT128','PKB128','TH02',5,'2022/10/11',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD18','TT18','PKB18','TH01',5,'2022/07/09',N'Uống sau mỗi bữa ăn','BS69')
	  ,('CD18','TT18','PKB18','TH02',5,'2022/07/09',N'Uống sau mỗi bữa ăn','BS69')
	  ,('CD19','TT19','PKB19','TH01',5,'2022/11/30',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD37','TT37','PKB37','TH02',8,'2022/03/01',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD38','TT38','PKB38','TH02',8,'2022/05/12',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD48','TT48','PKB48','TH01',8,'2022/02/01',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD48','TT48','PKB48','TH02',5,'2022/02/01',N'Uống sau mỗi bữa ăn','BS68')
	  ,('CD58','TT58','PKB58','TH01',9,'2022/08/06',N'Uống sau mỗi bữa ăn','BS69')
	  ,('CD58','TT58','PKB58','TH02',9,'2022/08/06',N'Uống sau mỗi bữa ăn','BS69')
	  ,('CD84','TT84','PKB84','TH01',5,'2023/06/29',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD85','TT85','PKB85','TH01',7,'2022/06/02',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD84','TT85','PKB85','TH02',9,'2022/06/02',N'Uống sau mỗi bữa ăn','BS67')
	  ,('CD87','TT87','PKB87','TH01',13,'2022/02/14',N'Uống sau mỗi bữa ăn','BS68')


	  --------------------------Đái tháo đường---------------------------
	  ,('CD106','TT106','PKB106','TH04',13,'2022/11/12',N'500 mg uống 3-4 lần/ngày','BS68')
	  ,('CD106','TT106','PKB106','TH05',5,'2022/11/12',N'Uống một lần vào buổi sáng khoảng 30 phút trước bữa điểm tâm','BS68')
	  ,('CD113','TT113','PKB113','TH35',5,'2022/01/05',N'Uống một lần/ngày vào 1 thời điểm cố định','BS67')
	  ,('CD113','TT113','PKB113','TH04',10,'2022/01/05',N'500 mg uống 3-4 lần/ngày','BS67')
	  ,('CD114','TT114','PKB114','TH05',4,'2022/03/28',N'Uống một lần vào buổi sáng khoảng 30 phút trước bữa điểm tâm','BS69')
	  ,('CD114','TT114','PKB114','TH04',12,'2022/03/28',N'500 mg uống 3-4 lần/ngày','BS69')
	  ,('CD137','TT137','PKB137','TH04',12,'2022/11/11',N'500 mg uống 3-4 lần/ngày','BS69')

	  -----------------------------Tim mạch---------------------------------
	  ,('CD104','TT104','PKB104','TH07',20,'2022/12/13',N'Uống 5 - 10 mg x 1 lần/ngày','BS67')
	  ,('CD104','TT104','PKB104','TH97',20,'2022/12/13',N'Dùng 5 – 10mg uống mỗi ngày một lần','BS67')

	  ,('CD138','TT138','PKB138','TH12',20,'2022/09/18',N'Sử dụng thuốc ramipril 5mg qua đường uống, trước hoặc sau bữa ăn','BS68')
	  ,('CD138','TT138','PKB138','TH35',20,'2022/09/18',N'Uống một lần/ngày vào 1 thời điểm cố định','BS68')
	  ------------------------------Ung thư phổi------------------------------
	 
	  ,('CD03','TT03','PKB03','TH08',11,'2022/02/16',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS68')
	  ,('CD10','TT10','PKB10','TH08',11,'2022/01/25',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS67')
	  ,('CD12','TT12','PKB12','TH08',4,'2022/03/24',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS69')
	  ,('CD125','TT125','PKB125','TH08',8,'2022/03/24',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS69')
	  ,('CD130','TT130','PKB130','TH08',6,'2022/06/17',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS67')
	  ,('CD135','TT135','PKB135','TH08',9,'2022/01/15',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS68')
	  ,('CD72','TT72','PKB72','TH08',11,'2022/02/20',N'ít nhất 1 giờ trước khi hoặc 2 giờ sau bữa ăn,một lần mỗi ngày','BS67')

	  --------------------------------Alzheimer------------------------------
	  ,('CD11','TT11','PKB11','TH11',20,'2022/12/24',N'viên nén 5 mg hoặc 10 mg, nuốt toàn bộ viên với nước, không bẻ hoặc làm vỡ','BS67')
	  ,('CD141','TT141','PKB141','TH11',20,'2024/03/27',N'6 miligam hai lần một ngày','BS67')
	  ,('CD142','TT142','PKB142','TH11',15,'2022/01/02',N'6 miligam hai lần một ngày','BS69') 
	  ,('CD47','TT47','PKB47','TH11',20,'2024/02/01',N'viên nén 5 mg hoặc 10 mg, nuốt toàn bộ viên với nước, không bẻ hoặc làm vỡ','BS68')

	  -------------------------------Sốt xuất huyết--------------------------
	  ,('CD62','TT62','PKB62','TH01',6,'2022/01/13',N'Uống sau mỗi bữa ăn','BS67')
	  ---------------------------------Táo bón---------------------------------
	  ,('CD150','TT150','PKB150','TH16',30,'2023/01/12',N'3 lần/ngày','BS68')
	  ,('CD150','TT150','PKB150','TH17',10,'2023/01/12',N'3 lần/ngày','BS68')
	  ------------------------------------Béo phì-------------------------------------
	  ,('CD147','TT147','PKB147','TH19',10,'2022/05/30',N'trong khi ăn hoặc cho đến 1 giờ sau mỗi bữa ăn chính','BS69')
	  ,('CD147','TT147','PKB147','TH20',10,'2022/05/30',N'uống trước khi ăn sáng 1 giờ hoặc 1-2 giờ sau khi ăn sáng','BS69')


	  ,('CD148','TT148','PKB148','TH19',6,'2022/08/27',N'trong khi ăn hoặc cho đến 1 giờ sau mỗi bữa ăn chính','BS67')
	  ,('CD148','TT148','PKB148','TH21',7,'2022/08/27',N'3 lần mỗi ngày','BS67')

	  ,('CD23','TT23','PKB23','TH21',8,'2022/10/03',N'3 lần mỗi ngày','BS68')
	  ,('CD23','TT23','PKB23','TH20',9,'2022/10/03',N'uống trước khi ăn sáng 1 giờ hoặc 1-2 giờ sau khi ăn sáng','BS68')

	  ,('CD69','TT69','PKB69','TH19',6,'2022/08/27',N'trong khi ăn hoặc cho đến 1 giờ sau mỗi bữa ăn chính','BS67')
	  ,('CD69','TT69','PKB69','TH20',9,'2022/08/27',N'uống trước khi ăn sáng 1 giờ hoặc 1-2 giờ sau khi ăn sáng','BS67')

	  -----------------------------Đau mắt đỏ-------------------------------
	  ,('CD06','TT06','PKB06','TH22',1,'2022/10/23',N'nhỏ 1-2 giọt','BS68')
	  ,('CD06','TT06','PKB06','TH23',1,'2022/10/23',N'nhỏ vào mắt 1 giọt, hai lần mỗi ngày trong 7 ngày','BS68')

	  ,('CD103','TT103','PKB103','TH22',1,'2022/06/11',N'nhỏ 1-2 giọt','BS68')

	  ,('CD22','TT22','PKB22','TH23',1,'2022/03/28',N'nhỏ vào mắt 1 giọt, hai lần mỗi ngày trong 7 ngày','BS67')
	  ,('CD22','TT22','PKB22','TH22',1,'2022/03/28',N'nhỏ 1-2 giọt','BS67')

	  ,('CD23','TT23','PKB32','TH23',1,'2022/05/07',N'nhỏ vào mắt 1 giọt, hai lần mỗi ngày trong 7 ngày','BS67')
	  ,('CD23','TT23','PKB32','TH22',1,'2022/05/07',N'nhỏ 1-2 giọt','BS67')

	  ,('CD39','TT39','PKB39','TH22',1,'2022/07/19',N'nhỏ 1-2 giọt','BS67')

	  ,('CD56','TT56','PKB56','TH23',1,'2024/02/04',N'nhỏ vào mắt 1 giọt, hai lần mỗi ngày trong 7 ngày','BS69')
	  ,('CD56','TT56','PKB56','TH22',1,'2024/02/04',N'nhỏ 1-2 giọt','BS69')

	  ,('CD59','TT59','PKB59','TH23',1,'2022/08/06',N'nhỏ vào mắt 1 giọt, hai lần mỗi ngày trong 7 ngày','BS69')
	  ,('CD59','TT59','PKB59','TH22',1,'2022/08/06',N'nhỏ 1-2 giọt','BS69')

	  ,('CD82','TT82','PKB82','TH23',1,'2022/07/28',N'nhỏ vào mắt 1 giọt, hai lần mỗi ngày trong 7 ngày','BS68')

	  ----------------------------Sỏi thận------------------------------
	  ,('CD13','TT13','PKB13','TH26',1,'2022/01/25',N'4 lần/ngày sau bữa ăn và trước khi đi ngủ','BS67')
	  ,('CD13','TT13','PKB13','TH01',10,'2022/01/25',N'uống sau mỗi bữa ăn','BS67')
	  ----------------------------Viêm tai giữa-------------------
	  ,('CD111','TT111','PKB111','TH02',15,'2023/09/08',N'uống sau mỗi bữa ăn','BS67')
	  ,('CD111','TT111','PKB111','TH28',15,'2023/09/08',N'uống trong vòng một giờ sau ăn','BS67')

	  ,('CD112','TT112','PKB112','TH01',15,'2022/12/08',N'uống sau mỗi bữa ăn','BS68')
	  ,('CD112','TT112','PKB112','TH02',15,'2022/12/08',N'uống sau mỗi bữa ăn','BS68')

	  ,('CD14','TT14','PKB14','TH01',13,'2022/06/30',N'uống sau mỗi bữa ăn','BS69')
	  ,('CD14','TT14','PKB14','TH28',13,'2022/06/30',N'uống trong vòng một giờ sau ăn','BS69')

	  ,('CD15','TT15','PKB15','TH01',10,'2022/11/23',N'uống sau mỗi bữa ăn','BS69')
	  ,('CD15','TT15','PKB15','TH02',10,'2022/11/23',N'uống sau mỗi bữa ăn','BS69')
	  ----------------Xơ gan-------------------------
	  ,('CD16','TT16','PKB16','TH04',15,'2022/03/15',N'500 mg uống 3-4 lần/ngày','BS67')
	  ,('CD16','TT16','PKB16','TH06',13,'2022/03/15',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')

	  ,('CD49','TT49','PKB49','TH83',13,'2024/02/04',N'uống metoprolol tartrat cùng hoặc ngay sau bữa ăn.','BS67')
	  ,('CD49','TT49','PKB49','TH06',13,'2024/02/04',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')

	  ,('CD79','TT79','PKB79','TH83',12,'2022/07/02',N'uống metoprolol tartrat cùng hoặc ngay sau bữa ăn.','BS68')
	  ,('CD79','TT79','PKB79','TH98',12,'2022/07/02',N'uống 1 viên/lần, 2 lần/ngày vào bữa trưa và bữa tối','BS68')

	  ,('CD80','TT80','PKB80','TH83',12,'2022/09/23',N'uống metoprolol tartrat cùng hoặc ngay sau bữa ăn.','BS68')
	  ,('CD80','TT80','PKB80','TH06',13,'2022/09/23',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS68')
	  -------------------Viêm ruột thừa---------------------------
	  ,('CD04','TT04','PKB04','TH02',10,'2022/06/17',N'uống sau mỗi bữa ăn','BS67')
	  -----------------Hẹp van động mạch chủ--------------------------
	  ,('CD108','TT108','PKB108','TH34',8,'2022/09/16',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD108','TT108','PKB108','TH03',13,'2022/09/16',N'dùng thuốc 2 lần/ngày, trong 5 ngày.','BS67')

	  ,('CD110','TT110','PKB110','TH34',11,'2022/10/20',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS68')
	  ,('CD110','TT110','PKB110','TH02',9,'2022/10/20',N'uống sau mỗi bữa ăn','BS68')

	  -------------------------Bị hoảng sợ khi ngủ--------------------
	  ,('CD131','TT131','PKB131','TH37',10,'2022/12/03',N'dùng 25 mg uống mỗi ngày một lần','BS68')
	  ,('CD131','TT131','PKB131','TH66',10,'2022/12/03',N'dùng 3 đến 5 mg vào buổi tối sớm, ít nhất 1.5 giờ trước khi đi ngủ mong muốn','BS68')


	  ,('CD132','TT132','PKB132','TH38',8,'2024/01/27',N'2 mg x 3 lần/ngày','BS69')
	  ,('CD132','TT132','PKB132','TH66',8,'2024/01/27',N'dùng 3 đến 5 mg vào buổi tối sớm, ít nhất 1.5 giờ trước khi đi ngủ mong muốn','BS69')

	  ,('CD133','TT133','PKB133','TH67',8,'2022/06/11',N'300-600 mg, nên uống khoảng 30-120 phút trước khi đi ngủ','BS67')
	  ,('CD133','TT133','PKB133','TH66',6,'2022/06/11',N'dùng 3 đến 5 mg vào buổi tối sớm, ít nhất 1.5 giờ trước khi đi ngủ mong muốn','BS67')

	  ,('CD21','TT21','PKB21','TH67',8,'2022/09/10',N'300-600 mg, nên uống khoảng 30-120 phút trước khi đi ngủ','BS69')
	  ,('CD21','TT21','PKB21','TH66',9,'2022/09/10',N'dùng 3 đến 5 mg vào buổi tối sớm, ít nhất 1.5 giờ trước khi đi ngủ mong muốn','BS69')
	  --------------------Bị gout----------------------------------------------

	  ,('CD34','TT34','PKB34','TH27',8,'2022/10/14',N'uống thuốc mỗi ngày một lần','BS67')
	  ,('CD34','TT34','PKB34','TH02',10,'2022/10/14',N'uống sau mỗi bữa ăn','BS67')

	  ------------------------------------Bị đột quỵ----------------------

	  ,('CD35','TT35','PKB35','TH36',25,'2022/08/14',N'bằng đường uống, có thể dùng cùng hoặc không cùng thức ăn, thường 1 lần/ngày','BS67')
	  ,('CD35','TT35','PKB35','TH01',20,'2022/08/14',N'uống sau mỗi bữa ăn','BS67')

	  -----------------Bị lao phổi -------------------------------

	  ,('CD30','TT30','PKB30','TH45',25,'2022/02/03',N'uống 5mg/kg/24 giờ.','BS68')
	  ,('CD30','TT30','PKB30','TH46',20,'2022/02/03',N'uống 8 - 12 mg/ kg, ngày dùng 1 lần, uống cách xa bữa ăn','BS68')


	  ,('CD45','TT45','PKB45','TH45',25,'2024/01/01',N'uống 5mg/kg/24 giờ.','BS68')
	  ,('CD45','TT45','PKB45','TH47',20,'2024/01/01',N'dùng liều từ 20-30mg Pyrazinamid/kg cân nặng/ngày','BS68')
	  ----------------------------------Mụn cóc--------------------------------
	  ,('CD115','TT115','PKB115','TH93',1,'2022/09/08',N'bôi 5 lần/ngày cách nhau khoảng 4 giờ, liên tục trong 5 ngày','BS69')
	  ,('CD36','TT36','PKB36','TH93',1,'2022/04/25',N'bôi 5 lần/ngày cách nhau khoảng 4 giờ, liên tục trong 5 ngày','BS69')

	  ------------------------------Suy tĩnh mạn tính---------------------------
	  ,('CD116','TT116','PKB116','TH01',10,'2022/05/03',N'uống sau mỗi bữa ăn','BS67')
	  ,('CD116','TT116','PKB116','TH15',1,'2022/05/03',N'thuốc có thể được tiêm tĩnh mạch mà không cần pha loãng hoặc có thể được pha loãng với nước muối bình thường hoặc 5% dextrose.','BS67')
	  ----------------------Sủi mào gà-----------------------------------------------
	  ,('CD40','TT40','PKB40','TH56',10,'2022/06/07',N'bôi trước khi đi ngủ và để thuốc trên da từ 6-10 tiếng','BS68')
	  ------------------------Sốt rét---------------------------------------------
	  ,('CD24','TT24','PKB24','TH01',13,'2022/05/18',N'uống sau mỗi bữa ăn','BS68')
	  ,('CD134','TT134','PKB134','TH02',13,'2022/01/12',N'uống sau mỗi bữa ăn','BS69')

	  ,('CD70','TT70','PKB70','TH01',7,'2022/02/20',N'uống sau mỗi bữa ăn','BS67')
	  ,('CD71','TT71','PKB71','TH01',5,'2022/02/20',N'uống sau mỗi bữa ăn','BS68')

	  ,('CD97','TT97','PKB97','TH01',13,'2022/04/10',N'uống sau mỗi bữa ăn','BS68')
	  -------------------------Sán lá gan--------------------------------------
	  ,('CD101','TT101','PKB101','TH12',25,'2022/04/15',N'mỗi ngày sử dụng từ 1 hoặc 2 lần trước hoặc sau bữa ăn','BS69')

	  ,('CD67','TT67','PKB67','TH06',25,'2022/01/13',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS69')
	  ----------------------------==Parkinson--------------------------------------

	  ,('CD100','TT100','PKB100','TH62',15,'2022/08/13',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS69')
	  ,('CD100','TT100','PKB100','TH63',15,'2022/08/13',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS69')

	  ,('CD117','TT117','PKB117','TH62',15,'2023/09/08',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD117','TT117','PKB117','TH63',15,'2023/09/08',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS67')

	  ,('CD119','TT119','PKB119','TH62',10,'2022/05/28',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS68')
	  ,('CD119','TT119','PKB119','TH63',9,'2022/05/28',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS68')

	  ,('CD149','TT149','PKB149','TH62',8,'2022/12/19',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD149','TT149','PKB149','TH63',9,'2022/12/19',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS67')
	 
	  ,('CD20','TT20','PKB20','TH62',12,'2022/10/20',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD20','TT20','PKB20','TH63',15,'2022/10/20',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS67')

	  ,('CD77','TT77','PKB77','TH62',10,'2022/07/26',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD77','TT77','PKB77','TH63',8,'2022/07/16',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS67')

	  ,('CD78','TT78','PKB78','TH62',8,'2022/01/16',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS68')
	  ,('CD78','TT78','PKB78','TH63',9,'2022/01/16',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS68')

	  ,('CD95','TT95','PKB95','TH62',6,'2022/01/16',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD95','TT95','PKB95','TH63',4,'2022/01/16',N'được dùng để uống, thường uống làm 2 lần trong ngày vào bữa ăn sáng và ăn trưa','BS67')
	  -------------------------------------- Ung thư da-------------------------------------------------
	  ,('CD27','TT27','PKB27','TH56',1,'2022/11/14',N'thoa kem 3 lần/tuần','BS67')
	  ,('CD27','TT27','PKB27','TH74',1,'2022/11/14',N'dùng theo đường tiêm tĩnh mạch theo chỉ dẫn của bác sĩ, thường tiêm truyền trong khoảng hơn 90 phút','BS67')
	  ,('CD27','TT27','PKB27','TH75',1,'2022/11/14',N'được tiêm trong hơn 90 phút như liều tiêm tĩnh mạch sau hóa trị','BS67')
	  -----------------------------bị mất ngủ--------------------------------------------------------------

	  ,('CD02','TT02','PKB02','TH38',20,'2022/01/26',N'2 mg x 3 lần/ngày, có thể tăng liều tới tối đa 30 mg/ngày.','BS68')
	  ,('CD02','TT02','PKB02','TH66',7,'2022/01/26',N'dùng 3 đến 5 mg vào buổi tối sớm, ít nhất 1.5 giờ trước khi đi ngủ mong muốn.','BS68')

	  ,('CD25','TT25','PKB25','TH38',20,'2022/09/03',N'2 mg x 3 lần/ngày, có thể tăng liều tới tối đa 30 mg/ngày.','BS68')
	  ,('CD25','TT25','PKB25','TH92',7,'2022/09/03',N'25-50 mg mỗi đêm trước khi đi ngủ.','BS68')

	  ,('CD26','TT26','PKB26','TH38',10,'2022/09/03',N'2 mg x 3 lần/ngày, có thể tăng liều tới tối đa 30 mg/ngày.','BS69')
	  ,('CD26','TT26','PKB26','TH92',6,'2022/09/03',N'25-50 mg mỗi đêm trước khi đi ngủ.','BS69')

	  ,('CD92','TT92','PKB92','TH38',15,'2022/02/22',N'2 mg x 3 lần/ngày, có thể tăng liều tới tối đa 30 mg/ngày.','BS68')
	  ,('CD92','TT92','PKB92','TH66',5,'2022/02/22',N'dùng 3 đến 5 mg vào buổi tối sớm, ít nhất 1.5 giờ trước khi đi ngủ mong muốn.','BS68')

	  --------------------------------Rối loạn nội tiết tố----------------------------------------------------
	  ,('CD123','TT123','PKB123','TH04',10,'2022/05/21',N'500 mg uống 3-4 lần/ngày','BS69')
	  ,('CD123','TT123','PKB123','TH68',6,'2022/05/21',N'mỗi lần uống thuốc nên uống với nửa ly nước khi bụng rỗng vào buổi sáng, trước khi ăn 30 phút.','BS69')

	  ,('CD124','TT124','PKB124','TH04',10,'2022/06/09',N'500 mg uống 3-4 lần/ngày','BS69')
	  ,('CD124','TT124','PKB124','TH68',6,'2022/06/09',N'mỗi lần uống thuốc nên uống với nửa ly nước khi bụng rỗng vào buổi sáng, trước khi ăn 30 phút.','BS69')
	  -----------------------------Loạn thị-------------------------------------------------------------------
	  -----------------------------------------U não-----------------------------------------------------
	  ,('CD46','TT46','PKB46','TH11',8,'2022/03/03',N'dùng một lần mỗi ngày vào buổi tối','BS68')
	  ,('CD46','TT46','PKB46','TH13',5,'2022/03/03',N'dùng 1,5 mg uống hai lần mỗi ngày sau bữa ăn sáng và tối','BS68')


	  ,('CD57','TT57','PKB57','TH11',10,'2022/09/16',N'dùng một lần mỗi ngày vào buổi tối','BS67')
	  ,('CD57','TT57','PKB57','TH13',15,'2022/09/16',N'dùng 1,5 mg uống hai lần mỗi ngày sau bữa ăn sáng và tối','BS67')

	  ,('CD81','TT81','PKB81','TH11',8,'2022/12/29',N'dùng một lần mỗi ngày vào buổi tối','BS68')
	  ,('CD81','TT81','PKB81','TH13',5,'2022/12/29',N'dùng 1,5 mg uống hai lần mỗi ngày sau bữa ăn sáng và tối','BS68')

	  ,('CD83','TT83','PKB83','TH11',10,'2023/02/09',N'dùng một lần mỗi ngày vào buổi tối','BS69')
	  ,('CD83','TT83','PKB83','TH13',12,'2023/02/09',N'dùng 1,5 mg uống hai lần mỗi ngày sau bữa ăn sáng và tối','BS69')

	  ,('CD90','TT90','PKB90','TH11',10,'2022/02/03',N'dùng một lần mỗi ngày vào buổi tối','BS68')
	  ,('CD90','TT90','PKB90','TH13',12,'2022/02/03',N'dùng 1,5 mg uống hai lần mỗi ngày sau bữa ăn sáng và tối','BS68')

	  -------------------------------------Viêm mũi dị ứng thời tiết-----------------------------------
	  ,('CD55','TT55','PKB55','TH77',10,'2022/02/24',N'là 1 lần/ngày','BS68')
	  ,('CD55','TT55','PKB55','TH78',12,'2022/02/24',N'mỗi bên mũi, ấn xịt 1 - 2 lần','BS68')
	  -----------------------------------------đậu mùa khỉ---------------------------------------------
	  ,('CD120','TT120','PKB120','TH77',10,'2023/09/19',N'là 1 lần/ngày','BS68')
	  ,('CD120','TT120','PKB120','TH78',5,'2023/09/19',N' mỗi bên mũi, ấn xịt 1 - 2 lần, dùng mỗi buổi sáng và tối','BS68')
	  ,('CD120','TT120','PKB120','TH01',15,'2022/12/08',N'uống sau mỗi bữa ăn','BS68')

	  ,('CD144','TT144','PKB144','TH77',10,'2022/01/01',N'là 1 lần/ngày','BS69')
	  ,('CD144','TT144','PKB144','TH02',15,'2022/12/08',N'uống sau mỗi bữa ăn','BS69')

	  ,('CD89','TT89','PKB89','TH77',10,'2022/01/23',N'là 1 lần/ngày','BS67')
	  ,('CD89','TT89','PKB89','TH01',15,'2022/12/08',N'uống sau mỗi bữa ăn','BS68')
	  -------------------------------------đau khớp-----------------------------------------------------
	  ,('CD07','TT07','PKB07','TH43',8,'2022/05/07',N'300-650 mg đường uống hoặc đặt trực tràng mỗi 4-6 giờ','BS67')
	  ,('CD07','TT07','PKB07','TH01',9,'2022/05/07',N'uống sau mỗi bữa ăn','BS67')

	  ,('CD136','TT136','PKB136','TH54',8,'2022/11/23',N'chia làm nhiều lần (25mg x 4 lần/ ngày','BS67')
	  ,('CD136','TT136','PKB136','TH01',9,'2022/11/23',N'uống sau mỗi bữa ăn','BS67')

	  ,('CD74','TT74','PKB74','TH54',8,'2022/11/23',N'chia làm nhiều lần (25mg x 4 lần/ ngày','BS68')
	  ,('CD74','TT74','PKB74','TH02',9,'2022/11/23',N'uống sau mỗi bữa ăn','BS68')

	  ,('CD98','TT98','PKB98','TH43',8,'2022/06/20',N'300-650 mg đường uống hoặc đặt trực tràng mỗi 4-6 giờ','BS68')
	  ,('CD98','TT98','PKB98','TH02',9,'2022/06/20',N'uống sau mỗi bữa ăn','BS68')

	  ,('CD99','TT99','PKB99','TH54',10,'2022/10/30',N'chia làm nhiều lần (25mg x 4 lần/ ngày','BS69')
	  ,('CD99','TT99','PKB99','TH01',12,'2022/10/30',N'uống sau mỗi bữa ăn','BS69')
	  ---------------------------------đau thắt ngực---------------------------------------------------
	  ,('CD41','TT41','PKB41','TH38',10,'2022/08/03',N'2 mg x 3 lần/ngày','BS69')
	  ,('CD41','TT41','PKB41','TH02',12,'2022/08/03',N'uống sau mỗi bữa ăn','BS69')

	  ,('CD54','TT54','PKB54','TH38',10,'2022/06/09',N'2 mg x 3 lần/ngày','BS69')

	  ,('CD88','TT88','PKB88','TH38',5,'2022/01/12',N'2 mg x 3 lần/ngày','BS69')
	  ,('CD88','TT88','PKB88','TH02',14,'2022/01/12',N'uống sau mỗi bữa ăn','BS69')
	  ---------------------------Cơ tim giãn nở------------------------------------------------------
	  ,('CD42','TT42','PKB42','TH12',5,'2022/04/07',N'trước hoặc sau bữa ăn','BS67')
	  ,('CD42','TT42','PKB42','TH07',14,'2022/04/07',N'uống 5 - 10 mg x 1 lần/ngày','BS67')
	  ,('CD42','TT42','PKB42','TH53',6,'2022/04/07',N'dùng 80 mg, 1 lần','BS67')
	  -----------------------------Cường giáp-------------------------------------------
	  ,('CD09','TT09','PKB09','TH84',6,'2022/04/06',N'dùng từ 1 đến 3 lần mỗi ngày','BS68')
	  ,('CD09','TT09','PKB09','TH31',8,'2022/04/06',N' 2-4 lần mỗi ngày trước bữa ăn ','BS68')

	  ,('CD109','TT109','PKB109','TH83',6,'2022/04/24',N'uống viên nén metoprolol mỗi lần 50 mg, cứ 6 giờ một lần, bắt đầu cho uống 15 phút sau lần tiêm tĩnh mạch cuối cùng, và tiếp tục trong 48 giờ','BS68')
	  ,('CD109','TT109','PKB109','TH31',8,'2022/04/24',N' 2-4 lần mỗi ngày trước bữa ăn ','BS68')

	  ,('CD140','TT140','PKB140','TH84',6,'2023/11/28',N'dùng từ 1 đến 3 lần mỗi ngày','BS68')

	  ,('CD33','TT33','PKB33','TH84',10,'2022/10/21',N'dùng từ 1 đến 3 lần mỗi ngày','BS67')
	  ,('CD33','TT33','PKB33','TH31',12,'2022/10/21',N' 2-4 lần mỗi ngày trước bữa ăn ','BS67')

	  ,('CD68','TT68','PKB68','TH31',8,'2022/01/09',N' 2-4 lần mỗi ngày trước bữa ăn ','BS68')

	  ,('CD73','TT73','PKB73','TH83',8,'2022/07/28',N'uống viên nén metoprolol mỗi lần 50 mg, cứ 6 giờ một lần, bắt đầu cho uống 15 phút sau lần tiêm tĩnh mạch cuối cùng, và tiếp tục trong 48 giờ','BS68')
	  ,('CD73','TT73','PKB73','TH31',14,'2022/07/28',N' 2-4 lần mỗi ngày trước bữa ăn','BS68')
	  -----------------------------Băng huyết sau sinh------------------------------
	  ,('CD65','TT65','PKB65','TH97',10,'2022/05/21',N'uống mỗi ngày một lần','BS67')
	  ,('CD65','TT65','PKB65','TH01',12,'2022/05/21',N'uống mỗi lần sau mỗi bữa ăn','BS67')

	  ,('CD76','TT76','PKB76','TH97',10,'2022/04/05',N'uống mỗi ngày một lần','BS67')
	  ,('CD76','TT76','PKB76','TH02',12,'2022/04/05',N'uống mỗi lần sau mỗi bữa ăn','BS67')
	  ------------------------------Hội chứng thận hư------------------------------------------
	  ,('CD53','TT53','PKB53','TH07',8,'2022/07/12',N'uống 5 - 10 mg x 1 lần/ngày','BS69')
	  ,('CD53','TT53','PKB53','TH02',6,'2022/07/12',N'uống mỗi lần sau mỗi bữa ăn','BS69')

	  ,('CD86','TT86','PKB86','TH05',8,'2022/07/12',N'uống khoảng 30 phút trước một bữa ăn để giảm tối đa nồng độ glucose trong máu sau ăn','BS68')
	  ,('CD86','TT86','PKB86','TH35',6,'2022/07/12',N'uống thuốc 1 lần mỗi ngày vào một thời điểm cố định','BS68')
	  -------------------------------Bệnh dại-----------------------------------------------------
	 ,('CD50','TT50','PKB50','TH101',1,'2022/06/12','Bảo quản vaccine từ 2 đến 8 độ C. Rửa tay sạch sẽ với nước và xà phòng trước khi tiêm','BS67')
	 ,('CD51','TT51','PKB51','TH100',1,'2022/07/20','Bảo quản vaccine từ 2 đến 8 độ C. Rửa tay sạch sẽ với nước và xà phòng trước khi tiêm','BS68')
	 ,('CD66','TT66','PKB66','TH102',1,'2022/07/20','Bảo quản vaccine từ 2 đến 8 độ C. Rửa tay sạch sẽ với nước và xà phòng trước khi tiêm','BS69')
	 ,('CD107','TT107','PKB107','TH100',1,'2022/02/18','Bảo quản vaccine từ 2 đến 8 độ C. Rửa tay sạch sẽ với nước và xà phòng trước khi tiêm','BS68')
	  ------------------------------Dị ứng mắt----------------------------------------------------
	  ,('CD102','TT102','PKB102','TH91',8,'2023/09/02',N'nhỏ 1 giọt vào mắt bị ngứa x 2 lần/ ngày','BS69')
	  ,('CD102','TT102','PKB102','TH90',6,'2023/09/02',N'mỗi lần 1 viên vào buổi sáng và buổi tối khi ăn','BS69')

	  ,('CD105','TT105','PKB105','TH91',10,'2022/02/07',N'nhỏ 1 giọt vào mắt bị ngứa x 2 lần/ ngày','BS67')
	  ,('CD105','TT105','PKB105','TH90',11,'2022/02/07',N'mỗi lần 1 viên vào buổi sáng và buổi tối khi ăn','BS67')

	  ,('CD61','TT61','PKB61','TH91',8,'2022/03/27',N'nhỏ 1 giọt vào mắt bị ngứa x 2 lần/ ngày','BS68')
	  ,('CD61','TT61','PKB61','TH90',6,'2022/03/27',N'mỗi lần 1 viên vào buổi sáng và buổi tối khi ăn','BS68')

	  ,('CD129','TT129','PKB129','TH91',16,'2022/01/17',N'nhỏ 1 giọt vào mắt bị ngứa x 2 lần/ ngày','BS69')
	  ,('CD129','TT129','PKB129','TH90',10,'2022/01/17',N'mỗi lần 1 viên vào buổi sáng và buổi tối khi ăn','BS69')

	  --------------------------------------Đậu mùa----------------------------------------------
	  ,('CD43','TT43','PKB43','TH77',16,'2022/05/24',N'1 lần/ngày','BS69')
	  ,('CD43','TT43','PKB43','TH94',30,'2022/05/24',N'4 – 60 mg/ngày','BS69')


	  ,('CD75','TT75','PKB75','TH81',5,'2023/04/25',N'2 – 4 lần mỗi ngày','BS67')
	  ,('CD75','TT75','PKB75','TH77',5,'2023/04/25',N'1 lần/ngày','BS67')
	  -----------------------------------Đục thủy tinh thể--------------------------------------------
	  ,('CD139','TT139','PKB139','TH76',5,'2023/07/02',N'chia làm 2 - 4 lần','BS67')
	  ,('CD139','TT139','PKB139','TH77',5,'2023/07/02',N'1 lần/ngày','BS67')

	  ,('CD52','TT52','PKB52','TH24',6,'2023/07/02',N'uống hoặc truyền tĩnh mạch trên 60 phút','BS68')
	  ,('CD52','TT52','PKB52','TH23',8,'2023/07/02',N'hai lần mỗi ngày trong 7 ngày','BS68')

	  ,('CD60','TT60','PKB60','TH24',6,'2023/07/02',N'uống hoặc truyền tĩnh mạch trên 60 phút','BS68')
	  ,('CD60','TT60','PKB60','TH77',8,'2023/07/02',N'1 lần/ngày','BS68')
	  -------------------------------------Gan to------------------------------------------------------
	  ,('CD64','TT64','PKB64','TH06',6,'2022/05/21',N'uống chỉ một lần trong ngày, kèm hoặc không kèm theo thức ăn','BS67')
	  ,('CD64','TT64','PKB64','TH94',8,'2022/05/21',N'từ 4 – 60 mg/ngày','BS67')

	  ,('CD96','TT96','PKB96','TH03',6,'2022/09/19',N'dùng thuốc 2 lần/ngày, trong 5 ngày','BS67')
	  ,('CD96','TT96','PKB96','TH01',8,'2022/09/19',N'uống mỗi lần sau mỗi bữa ăn','BS67')
	  ---------------------------------------Liệt mặt---------------------------------------------------------
	  ,('CD126','TT126','PKB126','TH92',6,'2023/06/04',N'dùng thuốc 2 lần/ngày, trong 5 ngày','BS67')
	  ,('CD126','TT126','PKB126','TH28',8,'2023/06/04',N'uống cùng hoặc không cùng với thức ăn','BS67')
	 ---------------------------------------Trĩ nội----------------------------------------------------------
	 ,('CD145','TT145','PKB145','TH92',10,'2022/01/01',N'dùng thuốc 2 lần/ngày, trong 5 ngày','BS67')
	 ,('CD145','TT145','PKB145','TH55',11,'2022/01/01',N'bôi một lần vào buổi sáng và một lần nữa vào buổi tối trong 3 ngày, sau đó là nghỉ 4 ngày','BS67')

	 ,('CD28','TT28','PKB28','TH54',8,'2022/09/24',N'uống 100 - 125mg/ ngày, chia làm nhiều lần (25mg x 4 lần/ ngày','BS68')
	 ,('CD28','TT28','PKB28','TH98',7,'2022/09/24',N'uống 1 viên/lần, 2 lần/ngày vào bữa trưa và bữa tối','BS68')

	 ,('CD44','TT44','PKB44','TH54',8,'2024/01/01',N'uống 100 - 125mg/ ngày, chia làm nhiều lần (25mg x 4 lần/ ngày','BS68')
	 ,('CD44','TT44','PKB44','TH55',7,'2024/01/01',N'bôi một lần vào buổi sáng và một lần nữa vào buổi tối trong 3 ngày, sau đó là nghỉ 4 ngày','BS68')

	 ,('CD63','TT63','PKB63','TH54',8,'2022/11/28',N'uống 100 - 125mg/ ngày, chia làm nhiều lần (25mg x 4 lần/ ngày','BS67')
	 ,('CD63','TT63','PKB63','TH92',7,'2022/11/28',N'dùng thuốc 2 lần/ngày, trong 5 ngày','BS67')

	 ,('CD91','TT91','PKB91','TH54',6,'2022/05/09',N'uống 100 - 125mg/ ngày, chia làm nhiều lần (25mg x 4 lần/ ngày','BS67')
	 ,('CD91','TT91','PKB91','TH92',5,'2022/05/09',N'dùng thuốc 2 lần/ngày, trong 5 ngày','BS67')
	
insert into PhanGiuong(MaGiuong,MaYeuCau,NgayNhanGiuong,NgayTraGiuong,MSPhieuKhamBenh,MaLoaiBA,MaLoaiChiTietDV)
values
	 ('G01.3','YC03.6','2022/02/10','2022/02/28','PKB03','LBA24','DVCT12.1.1')
	,('G19.8.1','YC04.3','2022/06/10','2022/06/25','PKB04','LBA24','DVCT12.4.19')
	,('G10.9.1','YC10.5','2022/01/10','2022/04/12','PKB10','LBA24','DVCT12.4.10')
	 
	,('G01.10.1','YC108.3','2022/12/20','2023/01/13','PKB108','LBA24','DVCT12.4.1')
	,('G19.7.1','YC110.3','2022/10/10','2022/10/30','PKB110','LBA24','DVCT12.2.14')
	
	,('G10.1','YC12.6','2022/06/10','2022/07/01','PKB12','LBA24','DVCT12.1.10')
	
	,('G19.8.1','YC121.3','2022/09/19','2022/10/03','PKB121','LBA24','DVCT12.3.19')
	,('G19.4','YC122.3','2022/10/30','2022/11/20','PKB122','LBA24','DVCT12.1.19')
	,('G10.8.1','YC125.4','2022/03/10','2022/04/01','PKB125','LBA24','DVCT12.3.10')
	,('G26.2','YC126.4','2023/09/15','2023/09/30','PKB126','LBA24','DVCT12.1.27')
	,('G26.3','YC127.3','2022/09/10','2022/09/25','PKB127','LBA24','DVCT12.1.27')
	
	,('G16.10.1','YC13.5','2022/04/10','2022/04/27','PKB13','LBA24','DVCT12.2.16')
	,('G10.7.1','YC130.5','2022/05/30','2022/06/22','PKB130','LBA24','DVCT12.2.10')
	,('G01.10.1','YC135.6','2022/05/30','2022/06/12','PKB135','LBA24','DVCT12.4.1')
	,('G03.5.1','YC139.3','2023/01/26','2023/09/14','PKB139','LBA24','DVCT12.3.3')
	 
	,('G19.1','YC143.3','2022/04/20','2022/05/08','PKB143','LBA24','DVCT12.1.19')
	,('G19.6','YC145.3','2022/08/21','2022/09/04','PKB145','LBA24','DVCT12.1.19')
	,('G19.10.2','YC17.4','2022/01/20','2022/02/08','PKB17','LBA24','DVCT12.2.19')
	,('G07.7.1','YC27.4','2022/06/11','2022/06/28','PKB27','LBA24','DVCT12.2.7')
	,('G19.4','YC28.3','2022/12/18','2022/01/03','PKB28','LBA24','DVCT12.1.19')
	 
	,('G26.5','YC35.5','2022/12/21','2022/01/07','PKB35','LBA24','DVCT12.1.27')
	,('G07.9.1','YC36.5','2022/05/30','2022/06/17','PKB36','LBA24','DVCT12.4.7')
	,('G08.8.1','YC42.5','2022/02/28','2022/03/15','PKB42','LBA24','DVCT12.3.8')
	,('G19.9.1','YC44.3','2024/02/28','2024/03/16','PKB44','LBA24','DVCT12.4.19')
	 
	,('G26.5','YC57.2','2023/04/18','2024/04/30','PKB57','LBA24','DVCT12.1.26')
	,('G03.7.1','YC60.3','2022/09/10','2022/09/25','PKB60','LBA24','DVCT12.2.3')
	,('G19.11.1','YC63.3','2022/05/10','2022/05/26','PKB63','LBA24','DVCT12.3.19')
	,('G18.2','YC65.4','2022/05/11','2022/05/30','PKB65','LBA24','DVCT12.1.18')
	,('G25.1','YC67.4','2022/05/10','2022/05/30','PKB67','LBA24','DVCT12.1.25')
	,('G01.9.1','YC72.5','2022/12/09','2023/01/03','PKB72','LBA24','DVCT12.3.1')
	,('G18.3','YC76.2','2022/01/10','2022/02/25','PKB76','LBA24','DVCT12.1.18')
	,('G26.5','YC81.2','2022/06/25','2022/07/15','PKB81','LBA24','DVCT12.1.27')
	,('G26.9.1','YC83.5','2023/06/28','2023/07/14','PKB83','LBA24','DVCT12.4.27')
	,('G26.5','YC90.2','2022/07/30','2022/08/17','PKB90','LBA24','DVCT12.4.27')
	,('G19.8.1','YC91.3','2022/04/26','2022/05/18','PKB91','LBA24','DVCT12.3.19')

insert into TheoDoiSucKhoe([MaTheoDoi],[MaYeuCau],[MSPhieuKhamBenh],[MaNV],[NgayTheoDoi],[TinhTrangSK],GhiChu)
values
	 ('TD02','YC60.3','PKB60','YT24','2022/09/21',N'Còn hơi yếu sau phẫu thuật',N'Nên ăn thức ăn dạng lỏng')
	,('TD03','YC139.3','PKB139','BS165','2022/09/04',N'Thị lực thường cải thiện gần như ngay lập tức sau phẫu thuật',null)
	,('TD05','YC121.3','PKB121','YT239','2022/09/30',N'Một lượng nhỏ chảy máu có thể xảy ra sau khi đi vệ sinh.',N'Nên có chế độ ăn giàu chất xơ')
	,('TD06','YC13.5','PKB13','YT120','2022/04/24',N'Sức khỏe ổn định sau phẫu thuật',null)
	,('TD08','YC36.5','PKB36','YT102','2022/06/11',N'Sức khỏe ổn định sau phẫu thuật',N'Vệ sinh da sạch sẽ')

	,('TD10','YC27.4','PKB27','YT101','2022/06/23',N'',N'Vệ sinh thường xuyên và thay băng')
	,('TD12','YC108.3','PKB108','YT61','2022/01/10',N'Sức khỏe và tinh thần ổn định sau phẫu thuật',null)
	,('TD13','YC110.3','PKB110','YT242','2022/10/22',N'Sức khỏe và tinh thần ổn định sau phẫu thuật',N'Nghỉ ngơi, tránh hoạt động nặng')
	,('TD14','YC76.2','PKB76','BS313','2022/02/10',null,N'Dùng thuốc giảm đau')

	,('TD16','YC42.5','PKB42','YT187','2022/03/12',null,N'Khuyến khích thực hiện các hoạt động nhẹ nhàng để ngăn ngừa các biến chứng và thúc đẩy quá trình hồi phục.')
	,('TD17','YC65.4','PKB65','YT125','2022/05/24',null,N'Cần nghỉ ngơi đầy đủ hơn dùng thuốc để giảm đau')
	,('TD18','YC03.6','PKB03','YT01','2022/02/13',N'Chức năng hô hấp và tổng thể sức khỏe của bệnh nhân để đảm bảo họ có thể chịu đựng được ca phẫu thuật',N'')
	,('TD21','YC145.3','PKB145','BS329','2022/09/01',N'Sức khỏe ổn định',N'Chế độ ăn giàu chất xơ')

	,('TD22','YC125.4','PKB125','YT197','2022/03/20',N'Sức khỏe ổn định',null)
	,('TD24','YC28.3','PKB28','YT59','2022/12/20',N'Sức khỏe ổn định',null)
	,('TD25','YC28.3','PKB28','YT59','2022/12/26',N'Sức khỏe ổn định,đi vệ sinh ra máu',N'Ăn thức ăn giàu chất xơ')
	,('TD26','YC91.3','PKB91','YT126','2022/05/01',N'Sức khỏe ổn định',null)
	,('TD29','YC44.3','PKB44','YT239','2024/03/02',N'Sức khỏe ổn định',N'Sử dụng thuốc nhuận tràng')
	,('TD30','YC63.3','PKB63','YT242','2022/05/20',N'Sức khỏe ổn định,đi vệ sinh ra máu',N'Sử dụng thuốc nhuận tràng')
	,('TD31','YC04.3','PKB04','YT60','2022/06/14',N'Sức khỏe ổn định',N'Yêu cầu nhịn ăn và uống để ruột được trống trước khi phẫu thuật.')
	,('TD32','YC04.3','PKB04','YT60','2022/06/20',N'Sức khỏe ổn định',null)
	,('TD33','YC12.6','PKB12','YT197','2022/06/20',N'Sức khỏe ổn định để đáp ứng được cuộc phẫu thuật',null)
	,('TD34','YC12.6','PKB12','YT197','2022/06/27',N'Sức khỏe ổn định để đáp ứng được cuộc phẫu thuật','Không uống rượu bia, hút thuốc')

	,('TD35','YC143.3','PKB143','BS328','2022/05/01',N'Sức khỏe ổn định sau cuộc phẫu thuật',N'Chỉ nên uống nước hoặc chất lỏng trong suốt như nước ép không có bã, nước dùng trong và trà')
	,('TD36','YC145.3','PKB135','BS329','2022/06/07',N'Sức khỏe ổn định','Sẽ được kê đơn thuốc giảm đau')
	,('TD38','YC17.4','PKB17','YT241','2022/02/03',N'Sức khỏe ổn định',N'Có thể ăn thức ăn nhẹ như cháo')
	,('TD39','YC10.5','PKB10','YT32','2022/01/27',N'Sức khỏe ổn định',N'Sử dụng thuốc giảm đau')

	,('TD46','YC72.5','PKB72','YT01','2022/12/25',N'Sức khỏe ổn định',null)
	,('TD47','YC127.3','PKB127','YT273','2022/09/15',N'Sức khỏe đủ điều kiện để phẫu thuật',null)
	,('TD48','YC127.3','PKB127','YT273','2022/09/20',N'Bệnh nhân khó khăn trong việc nhai và nuốt, cũng như trong việc phát âm một số âm thanh.',null)

	,('TD50','YC90.2','PKB90','YT81','2022/08/12',N'Sức khỏe ổn định nhưng bệnh nhân căng thẳng',N'Cần dùng thuốc giảm đau, thuốc chống co giật')
	,('TD51','YC57.2','PKB57','BS138','2023/04/20',N'Sức khỏe ổn định nhưng bệnh nhân căng thẳng',null)
	,('TD52','YC57.2','PKB57','BS138','2022/04/26',N'Sức khỏe ổn định nhưng bệnh nhân căng thẳng',N'Cần dùng thuốc giảm đau, thuốc chống co giật')

	,('TD54','YC126.4','PKB126','YT140','2023/09/25',N'Bệnh nhân khó khăn trong việc nhai và nuốt, cũng như trong việc phát âm một số âm thanh.',null)
	,('TD56','YC81.2','PKB81','YT277','2022/07/05',N'Sức khỏe ổn định.',N'Kiểm tra định kỳ và hình ảnh MRI/CT để theo dõi tái phát của u')
	
	,('TD60','YC83.3','PKB83','BS969','2023/07/10',N'Sức khỏe ổn định.',N'Hóa trị hoặc xạ trị được khuyến nghị sau phẫu thuật để tiêu diệt các tế bào ung thư còn sót lại.')
	,('TD62','YC67.4','PKB67','YT271','2022/05/22',N'Sức khỏe ổn định.',N'Sử dụng thuốc giảm đau và thuốc kháng sinh để ngăn ngừa nhiễm trùng')

insert into HoaDon([MaHD],[MSPhieuKhamBenh],[NgayXuatHD])
values
     ('HD01','PKB01','2022-09-24')
	,('HD02','PKB02','2022/01/26')
	,('HD03','PKB03','2022/02/16')
	,('HD04','PKB04','2002/06/17')
	,('HD05','PKB05','2002/10/23')
	,('HD06','PKB06','2022/10/23')
	,('HD07','PKB07','2022/05/07')
	,('HD08','PKB08','2022/02/09')
	,('HD09','PKB09','2022/04/06')
	,('HD10','PKB10','2022/01/25')
	,('HD11','PKB11','2022/12/24')
	,('HD12','PKB12','2022/03/24')
	,('HD13','PKB13','2022/01/25')
	,('HD14','PKB14','2022/06/30')
	,('HD15','PKB15','2022/11/23')
	,('HD16','PKB16','2022/03/15')
	,('HD17','PKB17','2022/01/28')
	,('HD18','PKB18','2022/07/09')
	,('HD19','PKB19','2022/11/30')
	,('HD20','PKB20','2022/10/20')
	,('HD21','PKB21','2022/09/10')
	,('HD22','PKB22','2022/03/28')
	,('HD23','PKB23','2022/10/03')
	,('HD24','PKB24','2022/05/18')
	,('HD25','PKB25','2022/09/03')
	,('HD26','PKB26','2022/09/03')
	,('HD27','PKB27','2022/11/14')
	,('HD28','PKB28','2022/09/24')
	,('HD29','PKB29','2022/01/03')
	,('HD30','PKB30','2022/02/03')
	,('HD31','PKB31','2022/09/24')
	,('HD32','PKB32','2022/05/07')
	,('HD33','PKB33','2022/10/21')
	,('HD34','PKB34','2022/10/14')
	,('HD35','PKB35','2022/08/14')
	,('HD36','PKB36','2022/04/25')
	,('HD37','PKB37','2022/03/01')
	,('HD38','PKB38','2022/05/12')
	,('HD39','PKB39','2022/07/19')
	,('HD40','PKB40','2022/06/07')
	,('HD41','PKB41','2022/08/03')
	,('HD42','PKB42','2022/04/07')
	,('HD43','PKB43','2022/05/24')
	,('HD44','PKB44','2022/01/01')
	,('HD45','PKB45','2022/01/01')
	,('HD46','PKB46','2022/03/03')
	,('HD47','PKB47','2022/02/01')
	,('HD48','PKB48','2022/02/01')
	,('HD49','PKB49','2022/02/04')
	,('HD50','PKB50','2022/06/12')

	,('HD51','PKB51','2022/07/20')
	,('HD52','PKB52','2022/06/12')
	,('HD53','PKB53','2022/07/12')
	,('HD54','PKB54','2022/06/09')
	,('HD55','PKB55','2021/02/24')
	,('HD56','PKB56','2022/02/04')
	,('HD57','PKB57','2022/09/16')
	,('HD58','PKB58','2022/09/22')
	,('HD59','PKB59','2022/08/06')
	,('HD60','PKB60','2022/12/06')
	,('HD61','PKB61','2022/03/27')
	,('HD62','PKB62','2022/08/06')
	,('HD63','PKB63','2022/11/28')
	,('HD64','PKB64','2022/05/21')
	,('HD65','PKB65','2022/05/21')
	,('HD66','PKB66','2022/07/20')
	,('HD67','PKB67','2022/01/13')
	,('HD68','PKB68','2022/01/09')
	,('HD69','PKB69','2022/06/10')
	,('HD70','PKB70','2022/02/20')
	,('HD71','PKB71','2022/02/20')
	,('HD72','PKB72','2022/02/20')
	,('HD73','PKB73','2022/07/28')
	,('HD74','PKB74','2022/09/29')
	,('HD75','PKB75','2022/04/25')
	,('HD76','PKB76','2022/04/05')
	,('HD77','PKB77','2022/07/26')
	,('HD78','PKB78','2022/01/16')
	,('HD79','PKB79','2022/07/02')
	,('HD80','PKB80','2022/09/23')
	,('HD81','PKB81','2022/12/29')
	,('HD82','PKB82','2022/07/28')
	,('HD83','PKB83','2023/02/09')
	,('HD84','PKB84','2023/06/29')
	,('HD85','PKB85','2022/06/02')
	,('HD86','PKB86','2022/02/12')
	,('HD87','PKB87','2022/02/14')
	,('HD88','PKB88','2022/01/12')
	,('HD89','PKB89','2022/01/23')
	,('HD90','PKB90','2022/02/03')
	,('HD91','PKB91','2022/05/09')
	,('HD92','PKB92','2022/02/22')
	,('HD93','PKB93','2022/01/26')
	,('HD94','PKB94','2022/07/02')
	,('HD95','PKB95','2022/01/16')
	,('HD96','PKB96','2022/09/19')
	,('HD97','PKB97','2022/04/01')
	,('HD98','PKB98','2022/06/20')
	,('HD99','PKB99','2022/10/30')
	,('HD100','PKB100','2022/08/13')
	,('HD101','PKB101','2022/04/15')
	,('HD102','PKB102','2022/09/02')
	,('HD103','PKB103','2022/06/11')
	,('HD104','PKB104','2022/12/13')
	,('HD105','PKB105','2022/02/07')
	,('HD106','PKB106','2022/11/12')
	,('HD107','PKB107','2022/02/18')
	,('HD108','PKB108','2022/09/16')
	,('HD109','PKB109','2022/04/24')
	,('HD110','PKB110','2022/10/20')
	,('HD111','PKB111','2023/09/08')
	,('HD112','PKB112','2022/12/08')
	,('HD113','PKB113','2022/01/05')
	,('HD114','PKB114','2022/03/28')
	,('HD115','PKB115','2022/09/08')

	,('HD116','PKB116','2022/05/03')
	,('HD117','PKB117','2023/09/08')
	,('HD118','PKB118','2022/08/16')
	,('HD119','PKB119','2022/05/28')
	,('HD120','PKB120','2023/09/19')
	,('HD121','PKB121','2022/09/14')
	,('HD122','PKB122','2022/11/10')
	,('HD123','PKB123','2022/05/21')
	,('HD124','PKB124','2022/06/09')
	,('HD125','PKB125','2022/03/24')
	,('HD126','PKB126','2023/06/04')
	,('HD127','PKB127','2022/09/18')
	,('HD128','PKB128','2022/10/11')
	,('HD129','PKB129','2022/01/17')
	,('HD130','PKB130','2022/06/17')
	,('HD131','PKB131','2022/12/03')
	,('HD132','PKB132','2024/01/07')
	,('HD133','PKB133','2022/06/11')
	,('HD134','PKB134','2022/01/12')
	,('HD135','PKB135','2022/01/05')
	,('HD136','PKB136','2022/11/22')
	,('HD137','PKB137','2022/11/11')
	,('HD138','PKB138','2022/09/18')
	,('HD139','PKB139','2023/07/02')
	,('HD140','PKB140','2023/11/28')
	,('HD141','PKB141','2024/03/27')
	,('HD142','PKB142','2022/01/02')
	,('HD143','PKB143','2022/04/29')
	,('HD144','PKB144','2022/01/01')
	,('HD145','PKB145','2022/08/30')
	,('HD146','PKB146','2022/02/22')
	,('HD147','PKB147','2022/05/30')
	,('HD148','PKB148','2022/08/27')
	,('HD149','PKB149','2022/12/19')
	,('HD150','PKB150','2023/01/12')
insert into BHYT([MaSoBHYT],[NgayCap],MSBN)
values
	('DN4562345267456','2022/03/24','BN01')
	,('HS4322345262341','2022/04/06','BN03')
	,('CA5432345341212','2022/06/27','BN04')
	,('DN4562345223413','2022/01/10','BN06')
	,('DN4122345223414','2022/09/17','BN07')
	,('HS4322345233415','2022/01/01','BN08')
	,('HS3792345223416','2022/01/01','BN09')
	,('CA5322345223417','2022/09/25','BN10')
	,('SV4792345223418','2023/05/06','BN11')
	,('TE1792345223419','2022/03/01','BN13')
	,('SV4562345223420','2022/03/29','BN14')
	,('HN4212345223422','2024/01/06','BN16')
	,('SV4782345223423','2022/12/21','BN17')
	,('SV4262345223424','2022/06/01','BN18')
	,('TE1792345223425','2022/02/24','BN19')
	,('HN4322345223426','2022/05/16','BN20')
	,('SV4322345223427','2022/03/27','BN21')
	,('HN4212345223428','2022/01/13','BN23')
	,('DN4562345223429','2022/06/16','BN25')
	,('TC3212345223430','2022/06/30','BN26')
	,('TE1672345223431','2022/07/28','BN28')
	,('HS4612345223432','2022/11/28','BN29')
	,('DN4612345223433','2022/09/12','BN30')
	,('DN4222345223434','2022/02/01','BN31')
	,('DN4212345223435','2022/01/18','BN33')
	,('DN4232345223436','2022/12/09','BN34')
	,('TQ4452345223437','2022/09/27','BN35')
	,('CN3612345223438','2022/11/12','BN36')
	,('SV4592345223439','2022/04/25','BN39')
	,('CA5582345223440','2022/03/23','BN40')
	,('DN4432345223441','2022/09/11','BN43')
	,('DN4892345223442','2022/08/15','BN45')
	,('TS2342345223443','2022/12/20','BN46')
	,('TE1342345223444','2023/07/02','BN47')
	,('HS4672345223445','2022/06/13','BN48')
	,('HT3452345223446','2022/01/18','BN49')
	,('DN4322345223447','2022/07/08','BN50')
------------------Viết store procedure
------Xuất hóa đơn
go
CREATE PROC XuatToaThuoc(@MSPhieuKB nvarchar(12))
AS
BEGIN
    SELECT Thuoc.TenThuoc,ToaThuoc.SoLuong,Thuoc.DonGia,ToaThuoc.HDSuDung,ToaThuoc.Tien,HoaDon.TienThuoc,ToaThuoc.MaNV,
	BenhLy.TenBenh
	FROM ToaThuoc
	join Thuoc on ToaThuoc.MSThuoc = Thuoc.MSThuoc
	join HoaDon on ToaThuoc.MSPhieuKhamBenh = HoaDon.MSPhieuKhamBenh
	join ChuanDoan on ChuanDoan.MSPhieuKhamBenh = HoaDon.MSPhieuKhamBenh
	join BenhLy on BenhLy.MaBenh = ChuanDoan.MaBenh
    WHERE ToaThuoc.MSPhieuKhamBenh = @MSPhieuKB
END
go
CREATE PROC XuatTienLamPT_XNCC(@MSPhieuKB nvarchar(12))
AS
BEGIN
    SELECT PhongKham.TenPhong AS 'TenPhongPT_XNCC',LamPhauThuat_XNCC.ThoiGianThucHien,LamPhauThuat_XNCC.KetQua,
	BangGia.Gia,BangGia.TenLoaiChiTietDV,HoaDon.TienPT_XNCC
	FROM LamPhauThuat_XNCC
	join BangGia on LamPhauThuat_XNCC.MaLoaiChiTietDV = BangGia.MaLoaiChiTietDV
	join PhongKham on LamPhauThuat_XNCC.MSPhong = PhongKham.MSPhong
	join HoaDon on HoaDon.MSPhieuKhamBenh = LamPhauThuat_XNCC.MSPhieuKhamBenh
    WHERE LamPhauThuat_XNCC.MSPhieuKhamBenh = @MSPhieuKB
END
go
create proc XuatTienHD(@MSPhieuKB nvarchar(12))
as
begin
	SELECT * FROM HoaDon
	where HoaDon.MSPhieuKhamBenh = @MSPhieuKB
end
go
create proc XuatTienGB(@MSPhieuKB nvarchar(12))
as
begin
	SELECT PhongKham.TenPhong AS 'TenPhongBenh',GiuongBenh.SoGiuongBenh,PhanGiuong.NgayNhanGiuong,PhanGiuong.NgayTraGiuong,
	BangGia.Gia,HoaDon.TienGiuong
	FROM PhanGiuong
	join BangGia on PhanGiuong.MaLoaiChiTietDV = BangGia.MaLoaiChiTietDV
	join GiuongBenh on PhanGiuong.MaGiuong = GiuongBenh.MaGiuong
	join PhongKham on GiuongBenh.MSPhong = PhongKham.MSPhong
	join HoaDon on HoaDon.MSPhieuKhamBenh = PhanGiuong.MSPhieuKhamBenh
	where PhanGiuong.MSPhieuKhamBenh = @MSPhieuKB
end
go
CREATE PROC XuatTTCuaBN(@MSPhieuKB nvarchar(12))
AS
BEGIN
    SELECT BenhNhan.MSBN, BenhNhan.TenBN, BenhNhan.DiaChi, BHYT.MaSoBHYT,BenhNhan.GioiTinh
    FROM PhieuKhamBenh
    LEFT JOIN HoSoBenhAn ON PhieuKhamBenh.MaHoSoBA = HoSoBenhAn.MaHoSoBA
    LEFT JOIN BenhNhan ON HoSoBenhAn.MSBN = BenhNhan.MSBN
    LEFT JOIN BHYT ON BenhNhan.MSBN = BHYT.MSBN
    WHERE PhieuKhamBenh.MSPhieuKhamBenh = @MSPhieuKB
END
go
-----------------------Xuất lịch sử chữa trị của bệnh nhân
-----------Xuất theo PKB
CREATE PROC XuatLSTTCuaBN(@MSPhieuKB nvarchar(12))
AS
BEGIN
    SELECT BenhNhan.MSBN, BenhNhan.TenBN, BenhNhan.DiaChi, BHYT.MaSoBHYT,BenhNhan.GioiTinh,
	PhieuKhamBenh.TrieuChung,PhieuKhamBenh.BenhNen,BenhLy.TenBenh,ChuanDoan.KetLuan,ChuanDoan.LoiKhuyen
    FROM PhieuKhamBenh
    LEFT JOIN HoSoBenhAn ON PhieuKhamBenh.MaHoSoBA = HoSoBenhAn.MaHoSoBA
    LEFT JOIN BenhNhan ON HoSoBenhAn.MSBN = BenhNhan.MSBN
    LEFT JOIN BHYT ON BenhNhan.MSBN = BHYT.MSBN
	LEFT join ChuanDoan on ChuanDoan.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	join BenhLy on ChuanDoan.MaBenh = BenhLy.MaBenh
    WHERE PhieuKhamBenh.MSPhieuKhamBenh = @MSPhieuKB
END
go
CREATE PROC XuatLSKhamCuaPKB(@MSPhieuKB nvarchar(12))
AS
BEGIN
    select PhongKham.TenPhong,Kham.MaNV,Kham.MaNguoiYC  from Kham
	left join PhieuKhamBenh on Kham.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	left join PhongKham on Kham.MSPhong = PhongKham.MSPhong
	where Kham.MSPhieuKhamBenh = @MSPhieuKB
END
go

--------------------------------------Lấy tên bệnh nhân
CREATE PROC XuatToaThuocNhoTenBN(@MSBN nvarchar(12))
AS
BEGIN
    SELECT Thuoc.TenThuoc,ToaThuoc.SoLuong,Thuoc.DonGia,ToaThuoc.HDSuDung,ToaThuoc.Tien,HoaDon.TienThuoc,ToaThuoc.MaNV,
	PhieuKhamBenh.MSPhieuKhamBenh,BenhLy.TenBenh
	FROM ToaThuoc
	join Thuoc on ToaThuoc.MSThuoc = Thuoc.MSThuoc
	join HoaDon on ToaThuoc.MSPhieuKhamBenh = HoaDon.MSPhieuKhamBenh
	join PhieuKhamBenh on ToaThuoc.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
    join HoSoBenhAn on HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
	LEFT JOIN BenhNhan ON HoSoBenhAn.MSBN = BenhNhan.MSBN 
	left join ChuanDoan on ChuanDoan.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	left join BenhLy on BenhLy.MaBenh = ChuanDoan.MaBenh
	where BenhNhan.MSBN = @MSBN 
END
go
CREATE PROC XuatTienLamPT_XNCCNhoTenBN(@MSBN nvarchar(12))
AS
BEGIN
    SELECT PhongKham.TenPhong AS 'TenPhongPT_XNCC',LamPhauThuat_XNCC.ThoiGianThucHien,LamPhauThuat_XNCC.KetQua,
    BangGia.Gia,BangGia.TenLoaiChiTietDV,HoaDon.TienPT_XNCC,HoaDon.MSPhieuKhamBenh
    FROM LamPhauThuat_XNCC
    LEFT JOIN BangGia ON LamPhauThuat_XNCC.MaLoaiChiTietDV = BangGia.MaLoaiChiTietDV
    LEFT JOIN PhongKham ON LamPhauThuat_XNCC.MSPhong = PhongKham.MSPhong
    LEFT JOIN HoaDon ON HoaDon.MSPhieuKhamBenh = LamPhauThuat_XNCC.MSPhieuKhamBenh
	join PhieuKhamBenh on LamPhauThuat_XNCC.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
    LEFT JOIN HoSoBenhAn ON HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
    LEFT JOIN BenhNhan ON HoSoBenhAn.MSBN = BenhNhan.MSBN 
    WHERE BenhNhan.MSBN = @MSBN 
END
go
create proc XuatTienGBNhoTenBN(@MSBN nvarchar(12))
as
begin
	SELECT PhongKham.TenPhong AS 'TenPhongBenh',GiuongBenh.SoGiuongBenh,PhanGiuong.NgayNhanGiuong,PhanGiuong.NgayTraGiuong,
	BangGia.Gia,HoaDon.TienGiuong,HoaDon.MSPhieuKhamBenh
	FROM PhanGiuong
	left join BangGia on PhanGiuong.MaLoaiChiTietDV = BangGia.MaLoaiChiTietDV
	left join GiuongBenh on PhanGiuong.MaGiuong = GiuongBenh.MaGiuong
	left join PhongKham on GiuongBenh.MSPhong = PhongKham.MSPhong
	left join HoaDon on HoaDon.MSPhieuKhamBenh = PhanGiuong.MSPhieuKhamBenh
	left join PhieuKhamBenh on PhieuKhamBenh.MSPhieuKhamBenh = PhanGiuong.MSPhieuKhamBenh
	left join HoSoBenhAn on HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
	left join BenhNhan on HoSoBenhAn.MSBN = BenhNhan.MSBN 
	where BenhNhan.MSBN = @MSBN
end
go
CREATE PROC XuatLSTTCuaBNNhoTenBN(@MSBN nvarchar(12))
AS
BEGIN
    SELECT BenhNhan.MSBN, BenhNhan.TenBN, BenhNhan.DiaChi, BHYT.MaSoBHYT,BenhNhan.GioiTinh,
	PhieuKhamBenh.TrieuChung,PhieuKhamBenh.BenhNen,BenhLy.TenBenh,ChuanDoan.KetLuan,ChuanDoan.LoiKhuyen,PhieuKhamBenh.MSPhieuKhamBenh
    FROM PhieuKhamBenh
    LEFT JOIN HoSoBenhAn ON PhieuKhamBenh.MaHoSoBA = HoSoBenhAn.MaHoSoBA
    LEFT JOIN BenhNhan ON HoSoBenhAn.MSBN = BenhNhan.MSBN
    LEFT JOIN BHYT ON BenhNhan.MSBN = BHYT.MSBN
	LEFT join ChuanDoan on ChuanDoan.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	join BenhLy on ChuanDoan.MaBenh = BenhLy.MaBenh
    WHERE BenhNhan.MSBN = @MSBN
END
go
CREATE PROC XuatLSKhamNhoTenBN(@MSBN nvarchar(12))
AS
BEGIN
    select PhongKham.TenPhong,Kham.MaNV,Kham.MaNguoiYC,Kham.MSPhieuKhamBenh  from Kham
	left join PhieuKhamBenh on Kham.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	left join PhongKham on Kham.MSPhong = PhongKham.MSPhong
	LEFT JOIN HoSoBenhAn ON PhieuKhamBenh.MaHoSoBA = HoSoBenhAn.MaHoSoBA
	left join BenhNhan on BenhNhan.MSBN = HoSoBenhAn.MSBN
	where  BenhNhan.MSBN = @MSBN
END
-------------------------Thống kê danh sách
go
CREATE PROCEDURE XuatDSSoLuongTheoNgay(@NgayKham datetime)
AS
BEGIN
    SELECT 
        PhongKham.MSPhong,
        PhongKham.TenPhong,
        Khoa.TenKhoa,
        BenhNhan.MSBN,
        BenhNhan.TenBN,
		PhieuKhamBenh.MSPhieuKhamBenh,
		PhieuKhamBenh.NgayKham
    FROM Kham
    JOIN PhongKham ON Kham.MSPhong = PhongKham.MSPhong
    JOIN PhieuKhamBenh ON Kham.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
    JOIN HoSoBenhAn ON HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
    JOIN BenhNhan ON BenhNhan.MSBN = HoSoBenhAn.MSBN    
    JOIN Khoa ON PhongKham.MaKhoa = Khoa.MaKhoa
   WHERE CAST(PhieuKhamBenh.NgayKham AS date) = CAST(@NgayKham AS date)
END
go

CREATE PROCEDURE XuatDSSoLuongTheoThangNam
    @Thang int,
    @Nam int
AS
BEGIN
    SELECT 
        PhongKham.MSPhong,
        PhongKham.TenPhong,
        Khoa.TenKhoa,
		BenhNhan.MSBN,
        BenhNhan.TenBN,
		PhieuKhamBenh.MSPhieuKhamBenh,PhieuKhamBenh.NgayKham
    FROM Kham
    JOIN PhongKham ON Kham.MSPhong = PhongKham.MSPhong
    JOIN PhieuKhamBenh ON Kham.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
    JOIN HoSoBenhAn ON HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
    JOIN BenhNhan ON BenhNhan.MSBN = HoSoBenhAn.MSBN    
    JOIN Khoa ON PhongKham.MaKhoa = Khoa.MaKhoa
    WHERE MONTH(PhieuKhamBenh.NgayKham) = @Thang AND YEAR(PhieuKhamBenh.NgayKham) = @Nam
END
go
CREATE PROCEDURE XuatDSSoLuongTheoNam
    @Nam int
AS
BEGIN
    SELECT 
        PhongKham.MSPhong,
        PhongKham.TenPhong,
        Khoa.TenKhoa,
        BenhNhan.MSBN,
        BenhNhan.TenBN,
		PhieuKhamBenh.MSPhieuKhamBenh,PhieuKhamBenh.NgayKham
    FROM Kham
    JOIN PhongKham ON Kham.MSPhong = PhongKham.MSPhong
    JOIN PhieuKhamBenh ON Kham.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
    JOIN HoSoBenhAn ON HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
    JOIN BenhNhan ON BenhNhan.MSBN = HoSoBenhAn.MSBN    
    JOIN Khoa ON PhongKham.MaKhoa = Khoa.MaKhoa
END
--------------Thống kê danh sách bệnh
go
CREATE PROCEDURE LayTKCuaBenhCuThe
    @MaBenh NVARCHAR(12),@nam int
AS
BEGIN
    SELECT
        BL.MaBenh,
        BL.TenBenh,
        SUM(CASE WHEN BN.GioiTinh = 'Nam' THEN 1 ELSE 0 END) AS SoLuongNam,
        SUM(CASE WHEN BN.GioiTinh = N'Nữ' THEN 1 ELSE 0 END) AS SoLuongNu,
        COUNT(*) AS TongSoLuong
    FROM ChuanDoan CD
    JOIN BenhLy BL ON CD.MaBenh = BL.MaBenh
    JOIN PhieuKhamBenh PKB ON CD.MSPhieuKhamBenh = PKB.MSPhieuKhamBenh
    JOIN HoSoBenhAn HSBA ON PKB.MaHoSoBA = HSBA.MaHoSoBA
    JOIN BenhNhan BN ON HSBA.MSBN = BN.MSBN
    WHERE BL.MaBenh = @MaBenh and  YEAR(PKB.NgayKham) = @nam
    GROUP BY BL.MaBenh, BL.TenBenh
END
go
CREATE PROCEDURE LayTinhTrangSKCuaBenhNhan
    @MaBenh NVARCHAR(12),
	@nam int
AS
BEGIN
    SELECT
        PKB.MSPhieuKhamBenh,
        BN.MSBN,
        BN.TenBN,
        BL.TenBenh,
        CASE 
            WHEN EXISTS (
                SELECT 1 
                FROM LamPhauThuat_XNCC LPT
                WHERE LPT.MSPhieuKhamBenh = PKB.MSPhieuKhamBenh 
                      AND LPT.Loai = N'Phẫu thuật'
            )
            THEN N'Đã phẫu thuật'
            ELSE NULL
        END AS TinhTrangPhauThuat,BN.GioiTinh
    FROM ChuanDoan CD
    JOIN BenhLy BL ON CD.MaBenh = BL.MaBenh
    JOIN PhieuKhamBenh PKB ON CD.MSPhieuKhamBenh = PKB.MSPhieuKhamBenh
    JOIN HoSoBenhAn HSBA ON PKB.MaHoSoBA = HSBA.MaHoSoBA
    JOIN BenhNhan BN ON HSBA.MSBN = BN.MSBN
    WHERE BL.MaBenh = @MaBenh and YEAR(PKB.NgayKham) = @nam
END
go
CREATE PROCEDURE LayTKCuaDSBenh
	@nam int
AS
BEGIN
    SELECT
        BL.MaBenh,
        BL.TenBenh,
        SUM(CASE WHEN BN.GioiTinh = 'Nam' THEN 1 ELSE 0 END) AS SoLuongNam,
        SUM(CASE WHEN BN.GioiTinh = N'Nữ' THEN 1 ELSE 0 END) AS SoLuongNu,
        COUNT(*) AS TongSoLuong
    FROM ChuanDoan CD
    JOIN BenhLy BL ON CD.MaBenh = BL.MaBenh
    JOIN PhieuKhamBenh PKB ON CD.MSPhieuKhamBenh = PKB.MSPhieuKhamBenh
    JOIN HoSoBenhAn HSBA ON PKB.MaHoSoBA = HSBA.MaHoSoBA
    JOIN BenhNhan BN ON HSBA.MSBN = BN.MSBN
    WHERE YEAR(PKB.NgayKham) = @nam
    GROUP BY BL.MaBenh, BL.TenBenh
END
go
create proc ThongKeDoanhSoCuaTatCaPKBTheoNgay(@date DateTime)
as
begin
	SELECT Sum(HoaDon.TienThuoc) AS TongDoanhThuThuoc,SUM(HoaDon.TienPT_XNCC) AS TongDoanhThuPT_XNCC
	,SUM(HoaDon.TienGiuong) AS TongDoanhThuVienPhi,SUM(HoaDon.TienKham) AS TongDoanhThuTienKham,
	SUM(HoaDon.TongTien) AS TongTien,SUM(HoaDon.TienBHYTChiTra) AS TongTienBHYTChiTra
	,SUM(HoaDon.TongTienSauKhiDaGiam) AS TongTienConLai,GETDATE() AS NgayXuatTK	
	FROM HoaDon	
	where CAST(HoaDon.NgayXuatHD AS date) = CAST(@date AS date)
end
go
create proc XuatTienHDCuaTatCaPKBTheoNgay(@date DateTime)
as
begin
	SELECT * FROM HoaDon
	where CAST(HoaDon.NgayXuatHD AS date) = CAST(@date AS date)
end
go
create proc ThongKeDoanhSoCuaTatCaPKBTheoThang(@Thang int, @Nam int)
as
begin
	SELECT Sum(HoaDon.TienThuoc) AS TongDoanhThuThuoc,SUM(HoaDon.TienPT_XNCC) AS TongDoanhThuPT_XNCC
	,SUM(HoaDon.TienGiuong) AS TongDoanhThuVienPhi,SUM(HoaDon.TienKham) AS TongDoanhThuTienKham,
	SUM(HoaDon.TongTien) AS TongTien,SUM(HoaDon.TienBHYTChiTra) AS TongTienBHYTChiTra
	,SUM(HoaDon.TongTienSauKhiDaGiam) AS TongTienConLai,GETDATE() AS NgayXuatTK	
	FROM HoaDon	
	where MONTH(HoaDon.NgayXuatHD) = @Thang AND YEAR(HoaDon.NgayXuatHD) = @Nam
end
go
create proc XuatTienHDCuaTatCaPKBTheoThang(@Thang int, @Nam int)
as
begin
	SELECT * FROM HoaDon
	where MONTH(HoaDon.NgayXuatHD) = @Thang AND YEAR(HoaDon.NgayXuatHD) = @Nam
end
go
create proc ThongKeDoanhSoCuaTatCaPKBTheoNam(@Nam int)
as
begin
	SELECT Sum(HoaDon.TienThuoc) AS TongDoanhThuThuoc,SUM(HoaDon.TienPT_XNCC) AS TongDoanhThuPT_XNCC
	,SUM(HoaDon.TienGiuong) AS TongDoanhThuVienPhi,SUM(HoaDon.TienKham) AS TongDoanhThuTienKham,
	SUM(HoaDon.TongTien) AS TongTien,SUM(HoaDon.TienBHYTChiTra) AS TongTienBHYTChiTra
	,SUM(HoaDon.TongTienSauKhiDaGiam) AS TongTienConLai,GETDATE() AS NgayXuatTK
	FROM HoaDon	
	where YEAR(HoaDon.NgayXuatHD) = @Nam
end
go
create proc XuatTienHDCuaTatCaPKBTheoNam(@Nam int)
as
begin
	SELECT * FROM HoaDon
	where YEAR(HoaDon.NgayXuatHD) = @Nam
end
go
CREATE PROC XuatToaThuocNhoMaTT(@MaTT nvarchar(12))
AS
BEGIN
    SELECT Thuoc.TenThuoc,ToaThuoc.SoLuong,Thuoc.DonGia,ToaThuoc.HDSuDung,ToaThuoc.Tien,HoaDon.TienThuoc,ToaThuoc.MaNV,
	BenhLy.TenBenh
	FROM ToaThuoc
	join Thuoc on ToaThuoc.MSThuoc = Thuoc.MSThuoc
	join HoaDon on ToaThuoc.MSPhieuKhamBenh = HoaDon.MSPhieuKhamBenh
	join ChuanDoan on ChuanDoan.MSPhieuKhamBenh = HoaDon.MSPhieuKhamBenh
	join BenhLy ON BenhLy.MaBenh = ChuanDoan.MaBenh
    WHERE ToaThuoc.MaToaThuoc = @MaTT
END
go
------------------create lấy dsbn
create proc LayDSBNNoiTruTheoNgay(@Ngay datetime)
as
begin 
	select BenhNhan.MSBN,BenhNhan.TenBN,BenhNhan.GioiTinh,BenhNhan.NgSinh,BenhNhan.SDT,
	BHYT.MaSoBHYT,PhanGiuong.NgayNhanGiuong,PhanGiuong.NgayTraGiuong,BenhLy.TenBenh,PhongKham.TenPhong,
	GiuongBenh.MaGiuong,PhieuKhamBenh.BenhNen,
	CASE 
       WHEN PhanGiuong.NgayTraGiuong IS NOT NULL AND CAST(PhanGiuong.NgayTraGiuong AS date) <= CAST(GETDATE() AS date) THEN N'Đã xuất viện'
	   WHEN PhanGiuong.NgayTraGiuong IS NULL THEN 'Chưa xuất viện'
       ELSE N'Chưa xuất viện'
    END AS TrangThaiXuatVien, (SELECT COUNT(*) FROM PhanGiuong WHERE CAST(PhanGiuong.NgayNhanGiuong AS date) = CAST(@Ngay AS date)) AS TongSoCa,
	NhanVien.MaNV,PhieuKhamBenh.MSPhieuKhamBenh
	from BenhNhan
	join HoSoBenhAn on BenhNhan.MSBN = HoSoBenhAn.MSBN
	join PhieuKhamBenh on HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
	join ChuanDoan on PhieuKhamBenh.MSPhieuKhamBenh = ChuanDoan.MSPhieuKhamBenh
	join BenhLy on BenhLy.MaBenh = ChuanDoan.MaBenh
	join PhanGiuong on PhanGiuong.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	join GiuongBenh on GiuongBenh.MaGiuong = PhanGiuong.MaGiuong
	join PhongKham on PhongKham.MSPhong = GiuongBenh.MSPhong
	left join BHYT on BenhNhan.MSBN = BHYT.MSBN
	left join Kham on PhanGiuong.MSPhieuKhamBenh = Kham.MSPhieuKhamBenh
	LEFT JOIN NhanVien on NhanVien.MaNV = Kham.MaNV
	where CAST(PhanGiuong.NgayNhanGiuong AS date) = CAST(@Ngay AS date) and  Kham.MSPhong = GiuongBenh.MSPhong
end

go
create proc LayDSBNNoiTruTheoThang(@Thang int,@Nam int)
as
begin 
	select BenhNhan.MSBN,BenhNhan.TenBN,BenhNhan.GioiTinh,BenhNhan.NgSinh,BenhNhan.SDT,
	BHYT.MaSoBHYT,PhanGiuong.NgayNhanGiuong,PhanGiuong.NgayTraGiuong,BenhLy.TenBenh,PhongKham.TenPhong,
	GiuongBenh.MaGiuong,PhieuKhamBenh.BenhNen,
	CASE 
       WHEN PhanGiuong.NgayTraGiuong IS NOT NULL AND CAST(PhanGiuong.NgayTraGiuong AS date) <= CAST(GETDATE() AS date) THEN N'Đã xuất viện'
	   WHEN PhanGiuong.NgayTraGiuong IS NULL THEN 'Chưa xuất viện'
       ELSE N'Chưa xuất viện'
    END AS TrangThaiXuatVien, (SELECT COUNT(*) FROM PhanGiuong WHERE MONTH(PhanGiuong.NgayNhanGiuong) = @Thang AND YEAR(PhanGiuong.NgayNhanGiuong) = @Nam ) AS TongSoCa,
	NhanVien.MaNV,PhieuKhamBenh.MSPhieuKhamBenh
	from BenhNhan
	join HoSoBenhAn on BenhNhan.MSBN = HoSoBenhAn.MSBN
	join PhieuKhamBenh on HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
	join ChuanDoan on PhieuKhamBenh.MSPhieuKhamBenh = ChuanDoan.MSPhieuKhamBenh
	join BenhLy on BenhLy.MaBenh = ChuanDoan.MaBenh
	join PhanGiuong on PhanGiuong.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	join GiuongBenh on GiuongBenh.MaGiuong = PhanGiuong.MaGiuong
	join PhongKham on PhongKham.MSPhong = GiuongBenh.MSPhong
	left join BHYT on BenhNhan.MSBN = BHYT.MSBN
	left join Kham on PhanGiuong.MSPhieuKhamBenh = Kham.MSPhieuKhamBenh
	LEFT JOIN NhanVien on NhanVien.MaNV = Kham.MaNV
	where MONTH(PhanGiuong.NgayNhanGiuong) = @Thang AND YEAR(PhanGiuong.NgayNhanGiuong) = @Nam and  Kham.MSPhong = GiuongBenh.MSPhong
end
go
create proc LayDSBNNoiTruTheoNam(@Nam int)
as
begin 
	select BenhNhan.MSBN,BenhNhan.TenBN,BenhNhan.GioiTinh,BenhNhan.NgSinh,BenhNhan.SDT,
	BHYT.MaSoBHYT,PhanGiuong.NgayNhanGiuong,PhanGiuong.NgayTraGiuong,BenhLy.TenBenh,PhongKham.TenPhong,
	GiuongBenh.MaGiuong,PhieuKhamBenh.BenhNen,
	CASE 
       WHEN PhanGiuong.NgayTraGiuong IS NOT NULL AND CAST(PhanGiuong.NgayTraGiuong AS date) <= CAST(GETDATE() AS date) THEN N'Đã xuất viện'
	   WHEN PhanGiuong.NgayTraGiuong IS NULL THEN 'Chưa xuất viện'
       ELSE N'Chưa xuất viện'
    END AS TrangThaiXuatVien, (SELECT COUNT(*) FROM PhanGiuong WHERE YEAR(PhanGiuong.NgayNhanGiuong) = @Nam ) AS TongSoCa,
	NhanVien.MaNV,PhieuKhamBenh.MSPhieuKhamBenh
	from BenhNhan
	join HoSoBenhAn on BenhNhan.MSBN = HoSoBenhAn.MSBN
	join PhieuKhamBenh on HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
	join ChuanDoan on PhieuKhamBenh.MSPhieuKhamBenh = ChuanDoan.MSPhieuKhamBenh
	join BenhLy on BenhLy.MaBenh = ChuanDoan.MaBenh
	join PhanGiuong on PhanGiuong.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	join GiuongBenh on GiuongBenh.MaGiuong = PhanGiuong.MaGiuong
	join PhongKham on PhongKham.MSPhong = GiuongBenh.MSPhong
	left join BHYT on BenhNhan.MSBN = BHYT.MSBN
	left join Kham on PhanGiuong.MSPhieuKhamBenh = Kham.MSPhieuKhamBenh
	LEFT JOIN NhanVien on NhanVien.MaNV = Kham.MaNV
	where YEAR(PhanGiuong.NgayNhanGiuong) = @Nam and  Kham.MSPhong = GiuongBenh.MSPhong
end
go
create proc LayDSBNNoiTruTrongKhoangThoiGian(@TuNgay datetime,@DenNgay datetime)
as
begin 
	select BenhNhan.MSBN,BenhNhan.TenBN,BenhNhan.GioiTinh,BenhNhan.NgSinh,BenhNhan.SDT,
	BHYT.MaSoBHYT,PhanGiuong.NgayNhanGiuong,PhanGiuong.NgayTraGiuong,BenhLy.TenBenh,PhongKham.TenPhong,
	GiuongBenh.MaGiuong,PhieuKhamBenh.BenhNen,
	CASE 
       WHEN PhanGiuong.NgayTraGiuong IS NOT NULL AND CAST(PhanGiuong.NgayTraGiuong AS date) <= CAST(GETDATE() AS date) THEN N'Đã xuất viện'
	   WHEN PhanGiuong.NgayTraGiuong IS NULL THEN 'Chưa xuất viện'
       ELSE N'Chưa xuất viện'
    END AS TrangThaiXuatVien, (SELECT COUNT(*) FROM PhanGiuong WHERE CAST(PhanGiuong.NgayNhanGiuong AS date) >= CAST(@TuNgay AS date) AND CAST(PhanGiuong.NgayNhanGiuong AS date) <= CAST(@DenNgay AS date)) AS TongSoCa,
	NhanVien.MaNV,PhieuKhamBenh.MSPhieuKhamBenh
	from BenhNhan
	join HoSoBenhAn on BenhNhan.MSBN = HoSoBenhAn.MSBN
	join PhieuKhamBenh on HoSoBenhAn.MaHoSoBA = PhieuKhamBenh.MaHoSoBA
	join ChuanDoan on PhieuKhamBenh.MSPhieuKhamBenh = ChuanDoan.MSPhieuKhamBenh
	join BenhLy on BenhLy.MaBenh = ChuanDoan.MaBenh
	join PhanGiuong on PhanGiuong.MSPhieuKhamBenh = PhieuKhamBenh.MSPhieuKhamBenh
	join GiuongBenh on GiuongBenh.MaGiuong = PhanGiuong.MaGiuong
	join PhongKham on PhongKham.MSPhong = GiuongBenh.MSPhong
	left join BHYT on BenhNhan.MSBN = BHYT.MSBN
	left join Kham on PhanGiuong.MSPhieuKhamBenh = Kham.MSPhieuKhamBenh
	LEFT JOIN NhanVien on NhanVien.MaNV = Kham.MaNV
	where CAST(PhanGiuong.NgayNhanGiuong AS date) >= CAST(@TuNgay AS date) and CAST(PhanGiuong.NgayNhanGiuong AS date) <= CAST(@DenNgay AS date) and  Kham.MSPhong = GiuongBenh.MSPhong
end
go
------------------------------
create proc LayTTNVTheoKhoa(@MaKhoa nvarchar(12))
as
begin
	Select *,ChuyenNganh.TenChuyenNganh from NhanVien
	join ChuyenNganh on ChuyenNganh.MaKhoa = NhanVien.MaKhoa
	where NhanVien.MaKhoa = @MaKhoa	
end
go
create proc LayTTBNTheoKhoa(@MaKhoa nvarchar(12))
as
begin
	Select * from PhieuKhamBenh 
end
