create database QLKS
go
use QLKS
create table NhanVien(
MaNV int IDENTITY(1,1) Primary key,
TenNV nvarchar(20) not null,
GioiTinh nvarchar(3) not null,
SDT int not null,
Email nvarchar(20) not null,
CCCD int not null,
DiaChi nvarchar(50) not null)

create table TaiKhoan(
MaNV int IDENTITY(1,1) Primary key,
usernameAcc nvarchar(20) not null,
passwordAcc nvarchar(20) not null,
quyen nvarchar(20) not null
)

create table DichVu(
IdDichVu int identity (1,1) primary key,
TenDichVu nvarchar(50) not null,
TienDichVu int not null)

create table QLKhachHang(
MaKH nvarchar(20) not null,
TenKH nvarchar(20) not null,
GioiTinhKH nvarchar(20) not null,
EmailKH nvarchar(20) not null,
SDTKH int not null,
QuocTich nvarchar(20) not null,
CCCD nvarchar(20) not null)

create table KyThuat(
ThongTinBaoTri nvarchar(20) not null,
TienPhuCap money not null,
NgayBaoTri date not null,
MaPhong nvarchar(20) not null,
MaNV nvarchar(20) not null)

create table NhaBep(
MaMonAn nvarchar(20) not null,
TenMonAn nvarchar(20) not null,
SoLuong int not null,
TongTien money not null,
GhiChuThem nvarchar(100) not null,
MaNV nvarchar(20) not null)

create table QLKho(
MaVL nvarchar(20) not null,
TenVL nvarchar(20) not null,
NCC nvarchar(20) not null,
DonViTinh nvarchar(20) not null,
SoLuong int default 0,
SoLuongToiDa int
)

create table ThongKeDoanhThu(
MaDoanhThu nvarchar(20) not null,
NgayLapBC nvarchar(20) not null,
TongDoanhThu nvarchar(20) not null,
DoanhThuPhong money not null,
DoanhThuDichVu money not null,
DoanhThuBep money not null,
SoTienChiTra money not null,
LoaiHangDaChi nvarchar(100) not null,
ThanhTien money not null,
MaNV nvarchar(20) not null
)

create table LoaiPhong(
roomid	int	identity (1,1) primary key,
MaPhong nvarchar(20) not null,
TenLoaiPhong nvarchar(20) not null,
LoaiGiuong nvarchar(20) not null,
GiaPhong int not null,
TinhTrangPhong varchar(3) default ('No') 
)

create table DatPhong(
cid		int	identity (1,1) primary key,
cname	nvarchar(100) not null,
mobile	bigint	not null,
quoctich nvarchar(100)not null,
gioitinh nvarchar(20)not null,
ngaysinh nvarchar(100)not null,
maDN nvarchar(100) not null,
diachi nvarchar(100) not null,
checkin nvarchar(100) not null,
chekout nvarchar(20) default('Null'),
checkout nvarchar(20) default ('No'),
rservice nvarchar(100) default (N'Không'),
roomid int not null,
allcost int not null,
foreign key ([roomid]) references [dbo].[LoaiPhong] ([roomid])
)

create table DatMon(
MaPhong nvarchar(20) not null,
TenMon nvarchar(20) not null,
GhiChu nvarchar(100) not null,
MaKH nvarchar(20) not null
)

create table DatDV(
TenDV nvarchar(20) not null,
GhiChu nvarchar(20) not null,
MaKhachHang nvarchar(20) not null,
MaPhong nvarchar(20) not null
)

INSERT INTO NhanVien (TenNV, GioiTinh, SDT, Email, CCCD, DiaChi)
VALUES
  (N'Nguyễn Văn A', N'Nam', 123456789, N'a.nguyen@company.com', 123456789, N'Ho Chi Minh, Vietnam'),
  (N'Trần Thị B', N'Nữ', 987654321, N'b.tran@company.com', 987654321, N'Ho Chi Minh, Vietnam'),
  (N'Lê Văn C', N'Nam', 234583890, N'c.le@company.com', 234567890, N'Ho Chi Minh, Vietnam'), 
  (N'Lê Văn D', N'Nam', 838967890, N'd.le@company.com', 234012345, N'Ho Chi Minh, Vietnam'), 
(N'Lê Văn F', N'Nam', 234568389, N'f.le@company.com', 234501235, N'Ho Chi Minh, Vietnam'), 
(N'Lê Văn H', N'Nữ', 234358190, N'h.le@company.com', 234567895, N'Ho Chi Minh, Vietnam'), 
(N'Lê Văn I', N'Nam', 201747890, N'i.le@company.com', 890012345, N'Ho Chi Minh, Vietnam'), 
(N'Lê Văn K', N'Nữ', 291747890, N'k.le@company.com', 239001245, N'Ho Chi Minh, Vietnam'), 
(N'Lê Văn M', N'Nữ', 290371891, N'm.le@company.com', 256780145, N'Ho Chi Minh, Vietnam'),
(N'Lê Văn N', N'Nữ', 292063924, N'n.le@company.com', 282480145, N'Ho Chi Minh, Vietnam'),
(N'Lê Văn O', N'Nữ', 038267891, N'o.le@company.com', 250240145, N'Ho Chi Minh, Vietnam'),
(N'Lê Văn P', N'Nữ', 292936891, N'p.le@company.com', 256782294, N'Ho Chi Minh, Vietnam')

INSERT INTO TaiKhoan(usernameAcc,passwordAcc, Quyen)
VALUES
  ('nva', 'nva1', N'Nhân viên'),
  ('ttb', 'ttb1', N'Nhân viên'),
  ('lvc', 'lvc1', N'Nhân viên'),
  ('lvd', 'lvd1', N'Nhân viên'),
  ('lvf', 'lvf1', N'Nhân viên'),
  ('lvh', 'lvh1', N'Nhân viên'),
  ('lvi', 'lvi1', N'Nhân viên'),
  ('lvk', 'lvk1', N'Nhân viên'),
  ('lvm', 'lvm1', N'Nhân viên'),
  ('lvn', 'lvn1', N'Nhân viên'),
  ('lvo', 'lvo1', N'Quản lý'),
  ('lvp', 'lvp1', N'Quản lý')

INSERT INTO DichVu (TenDichVu, TienDichVu)
VALUES
  (N'Dọn phòng', 150000),
  (N'Thuê tập gym', 200000),
  (N'Giặt ủi', 300000),
 (N'Trang trí phòng', 2000000),
 (N'Thuê tập gym, Giặt ủi, Dọn Phòng', 3500000),
  (N'Giặt ủi, Dọn Phòng', 500000)
  select TienDichVu, TenDichVu from DichVu where TenDichVu = N'Dọn Phòng'
INSERT INTO QLKhachHang (MaKH, TenKH, GioiTinhKH, EmailKH, SDTKH, QuocTich, CCCD)
VALUES
  ('KH00001', N'Nguyễn Văn A', N'Nam', N'a.nguyen@gmail.com', 127432789, N'Việt Nam', '123243245'),
  ('KH00002', N'Trần Thị B', N'Nữ', N'b.tran@company.com', 173534321, N'Singapore', '915542345'),
  ('KH00003', N'Lê Văn C', N'Nam', N'c.le@hotmail.com', 231839890, N'Nhật Bản', '234567345'),
  ('KH00004', N'Nguyễn Văn D', N'Nam', N'd.nguyen@gmail.com', 617376789, N'Việt Nam', '189012345'),
  ('KH00005', N'Trần Thị E', N'Nữ', N'e.tran@company.com', 987617381, N'Singapore', '987651345'),
  ('KH00006', N'Lê Văn F', N'Nam', N'f.le@hotmail.com', 234518364, N'Nhật Bản', '236212345'),
  ('KH00007', N'Nguyễn Văn G', N'Nam', N'g.nguyen@gmail.com', 175932789, N'Việt Nam', '123252345'),
  ('KH00008', N'Trần Thị H', N'Nữ', N'h.tran@company.com', 174743371, N'Singapore', '981673245'),
  ('KH00009', N'Lê Văn I', N'Nam', N'i.le@hotmail.com', 234178427, N'Nhật Bản', '235633245')

INSERT INTO KyThuat (ThongTinBaoTri, TienPhuCap, NgayBaoTri, MaPhong, MaNV)
VALUES
  (N'Sửa chữa điều hòa', 500000, '2024-04-20', 102, N'NV00004'),
  (N'Vệ sinh máy giặt', 500000, '2024-04-22', 103, N'NV00005'),
  (N'Kiểm tra thoát nước', 500000, '2024-04-25', 101, N'NV00006'),
  (N'Sửa chữa điều hòa', 500000, '2024-04-26', 104, N'NV00004'),
  (N'Vệ sinh máy giặt', 500000, '2024-04-27', 105, N'NV00005'),
  (N'Kiểm tra thoát nước', 500000, '2024-04-25', 106, N'NV00006'),
  (N'Sửa chữa điều hòa', 500000, '2024-04-27', 107, N'NV00004'),
  (N'Vệ sinh máy giặt', 500000, '2024-04-29', 108, N'NV00005'),
  (N'Kiểm tra thoát nước', 500000, '2024-04-29', 109, N'NV00006')

INSERT INTO NhaBep (MaMonAn, TenMonAn, SoLuong, TongTien, GhiChuThem, MaNV)
VALUES
  ('DA00001', N'Cơm chiên hải sản', 2, 150000, N'Thêm nhiều hải sản', 'NV00001'),
  ('DA00002', N'Phở bò', 1, 80000, N'Phở tái, nước dùng đậm đà', 'NV00002'),
  ('DA00003', N'Gà xào chua ngọt', 3, 120000, N'Ăn kèm với dưa leo, cà chua', 'NV00003')

INSERT INTO QLKho(MaVL,TenVL,NCC,DonViTinh,SoLuong,SoLuongToiDa)
VALUES
  ('VL00001', N'Bàn ghế', N'Nội thất X', N'Cái', 10, 50),
  ('VL00002', N'Giấy in', N'Văn phòng phẩm Y', N'Ream',45, 200),
  ('VL00003', N'Bút viết',  N'Văn phòng phẩm Z', N'Chiếc',200, 300)

INSERT INTO ThongKeDoanhThu (MaDoanhThu, NgayLapBC, TongDoanhThu, DoanhThuPhong, DoanhThuDichVu, DoanhThuBep, SoTienChiTra, LoaiHangDaChi, ThanhTien, MaNV)
VALUES
  ('DT00001', '2024-04-25', 10000000, 5000000, 2000000, 3000000, 1500000, N'Vật tư văn phòng', 200000, 'NV00007'),
  ('DT00002', '2024-04-20', 8000000, 4000000, 1500000, 2500000, 1000000, N'Thực phẩm', 500000, 'NV00008'),
  ('DT00003', '2024-04-22', 9500000, 3500000, 2200000, 3800000, 1200000, N'Dịch vụ giặt ủi', 300000, 'NV00009')


INSERT INTO LoaiPhong (MaPhong, TenLoaiPhong, LoaiGiuong,GiaPhong)
VALUES
  ('101', N'Phòng đơn', N'Giường đơn',500000),
  ('102', N'Phòng đôi', N'Giường đôi',800000),
  ('103', N'Phòng VIP', N'Giường cao cấp',1200000),
  ('104', N'Phòng đơn', N'Giường đơn',500000),
  ('105', N'Phòng đôi', N'Giường đôi',800000),
  ('106', N'Phòng VIP', N'Giường cao cấp',1200000),
  ('107', N'Phòng đơn', N'Giường đơn',500000),
  ('108', N'Phòng đôi', N'Giường đôi',800000),
  ('109', N'Phòng VIP', N'Giường cao cấp',1200000)

  select kh.MaKH, kh.TenKH, kh.GioiTinhKH, kh.EmailKH, kh.SDTKH, kh.QuocTich, kh.CCCD From QLKhachHang kh
INSERT INTO DatPhong (cname, mobile, quoctich, gioitinh, ngaysinh, maDN, diachi, checkin,rservice, roomid,allcost)
VALUES
  ('John Doe', 1234567890, 'American', 'Nam', '1990-01-01', '1876543456', N'Quận 3, Hồ Chí Minh', '2024-04-30',N'Giặt ủi', 1),
  ('Jane Doe', 9876543210, 'British', 'Nữ', '1995-05-20', '9876545678', N'QUận 7, Hồ Chí Minh', '2024-04-29',NULL, 2)


INSERT INTO DatMon (MaPhong, TenMon, GhiChu, MaKH)
VALUES
  ('101', N'Cơm chiên hải sản', N'Thêm nhiều hải sản', 'KH001'),
  ('102', N'Phở bò', N'Phở tái, nước dùng đậm đà', 'KH002'),
  ('103', N'Gà xào chua ngọt', N'Ăn kèm với dưa leo, cà chua', 'KH003')

INSERT INTO DatDV (TenDV, GhiChu, MaKhachHang, MaPhong)
VALUES
  (N'Dọn phòng',N'Cẩn thận đồ dễ vở', 'KH00001', '101'),
  (N'Thuê tập gym',N'Không có', 'KH00002', '102'),
  (N'Giặt, Ủi',N'Đò mỏng dễ bung chỉ', 'KH00003', '103')

update LoaiPhong set TinhTrangPhong ='No'
select DatPhong.cid, DatPhong.cname, DatPhong.mobile, DatPhong.quoctich, DatPhong.gioitinh, DatPhong.ngaysinh, DatPhong.maDN, DatPhong.diachi, DatPhong.checkin,DatPhong.rservice, LoaiPhong.MaPhong,  LoaiPhong.TenLoaiPhong,DatPhong.allcost from DatPhong inner join LoaiPhong on DatPhong.roomid = LoaiPhong.roomid where checkout = 'No';