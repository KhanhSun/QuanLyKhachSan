CREATE DATABASE QL_KyThuat ON (NAME = TenCSDL_Data, FILENAME = 'D:\QLKS_ Project\QuanLyKhachSan\QL_KyThuat\QL_KyThuat\\QL_KyThuat.mdf')
						LOG ON (NAME = TenCSDL_Log, FILENAME = 'D:\QLKS_ Project\QuanLyKhachSan\QL_KyThuat\QL_KyThuat\QL_KyThuat.ldf');

Go
Use QL_KyThuat

CREATE TABLE Maintenance (
    MaBaoTri INT PRIMARY KEY,
    NgayBaoTri DATE,
    MoTaCongViec NVARCHAR(255),
    TrangThai NVARCHAR(50)
);

CREATE TABLE MaintenanceStatus (
    MaBaoTri INT PRIMARY KEY,
    TrangThai NVARCHAR(50)
);

CREATE TABLE RepairCost (
    MaBaoTri INT PRIMARY KEY,
    ChiPhiSuaChua DECIMAL(18, 2),
    MoTaSuaChua NVARCHAR(255)
);

INSERT INTO Maintenance (MaBaoTri, NgayBaoTri, MoTaCongViec, TrangThai)
VALUES
    (1, '2024-04-26', N'Ki?m tra và v? sinh máy móc', N'Hoàn thành'),
    (2, '2024-04-26', N'Thay b? ph?n h?ng', N'Hoàn thành'),
	(3, '2024-04-26', N'Ki?m tra h? th?ng ?i?n', N'Hoàn thành'),
	(4, '2024-04-26', N'Ki?m tra và v? sinh máy móc', N'Hoàn thành'),
	(5, '2024-04-27', N'Thay b? ph?n h?ng', N'Hoàn thành'),
	(6, '2024-04-27', N'Ki?m tra h? th?ng ?i?n', N'Hoàn thành'),
	(7, '2024-04-27', N'Ki?m tra và v? sinh máy móc', N'Hoàn thành'),
	(8, '2024-04-27', N'Thay b? ph?n h?ng', N'?ang x? lý'),
	(9, '2024-04-28', N'Ki?m tra h? th?ng ?i?n', N'?ang x? lý'),
	(10, '2024-04-28', N'Ki?m tra và v? sinh máy móc', N'?ang x? lý'),
    (11, '2024-04-28', N'Thay b? ph?n h?ng', N'?ang x? lý');


INSERT INTO RepairCost (MaBaoTri, ChiPhiSuaChua, MoTaSuaChua)
VALUES 
	(1, 500000, N'Ki?m tra và v? sinh máy móc'),
	(2, 500000, N'Thay b? ph?n b? h?ng'),
	(3, 500000, N'Ki?m tra h? th?ng ?i?n'),
	(4, 500000, N'Ki?m tra và v? sinh máy móc'),
	(5, 500000, N'Thay b? ph?n b? h?ng'),
	(6, 500000, N'Ki?m tra h? th?ng ?i?n'),
	(7, 500000, N'Ki?m tra và v? sinh máy móc'),
	(8, 500000, N'Thay b? ph?n b? h?ng'),
	(9, 500000, N'Ki?m tra h? th?ng ?i?n'),
	(10, 500000, N'Ki?m tra và v? sinh máy móc'),
	(11, 500000, N'Thay b? ph?n b? h?ng');

INSERT INTO MaintenanceStatus (MaBaoTri, TrangThai)
VALUES
	(1, N'Hoàn thành'),
	(2, N'Hoàn thành'),
	(3, N'Hoàn thành'),
	(4, N'Hoàn thành'),
	(5, N'Hoàn thành'),
	(6, N'Hoàn thành'),
	(7, N'Hoàn thành'),
	(8, N'Hoàn thành'),
	(9, N'?ang x? lý'),
	(10, N'?ang x? lý'),
	(11, N'?ang x? lý');