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
    (1, '2024-04-26', N'Ki?m tra v� v? sinh m�y m�c', N'Ho�n th�nh'),
    (2, '2024-04-26', N'Thay b? ph?n h?ng', N'Ho�n th�nh'),
	(3, '2024-04-26', N'Ki?m tra h? th?ng ?i?n', N'Ho�n th�nh'),
	(4, '2024-04-26', N'Ki?m tra v� v? sinh m�y m�c', N'Ho�n th�nh'),
	(5, '2024-04-27', N'Thay b? ph?n h?ng', N'Ho�n th�nh'),
	(6, '2024-04-27', N'Ki?m tra h? th?ng ?i?n', N'Ho�n th�nh'),
	(7, '2024-04-27', N'Ki?m tra v� v? sinh m�y m�c', N'Ho�n th�nh'),
	(8, '2024-04-27', N'Thay b? ph?n h?ng', N'?ang x? l�'),
	(9, '2024-04-28', N'Ki?m tra h? th?ng ?i?n', N'?ang x? l�'),
	(10, '2024-04-28', N'Ki?m tra v� v? sinh m�y m�c', N'?ang x? l�'),
    (11, '2024-04-28', N'Thay b? ph?n h?ng', N'?ang x? l�');


INSERT INTO RepairCost (MaBaoTri, ChiPhiSuaChua, MoTaSuaChua)
VALUES 
	(1, 500000, N'Ki?m tra v� v? sinh m�y m�c'),
	(2, 500000, N'Thay b? ph?n b? h?ng'),
	(3, 500000, N'Ki?m tra h? th?ng ?i?n'),
	(4, 500000, N'Ki?m tra v� v? sinh m�y m�c'),
	(5, 500000, N'Thay b? ph?n b? h?ng'),
	(6, 500000, N'Ki?m tra h? th?ng ?i?n'),
	(7, 500000, N'Ki?m tra v� v? sinh m�y m�c'),
	(8, 500000, N'Thay b? ph?n b? h?ng'),
	(9, 500000, N'Ki?m tra h? th?ng ?i?n'),
	(10, 500000, N'Ki?m tra v� v? sinh m�y m�c'),
	(11, 500000, N'Thay b? ph?n b? h?ng');

INSERT INTO MaintenanceStatus (MaBaoTri, TrangThai)
VALUES
	(1, N'Ho�n th�nh'),
	(2, N'Ho�n th�nh'),
	(3, N'Ho�n th�nh'),
	(4, N'Ho�n th�nh'),
	(5, N'Ho�n th�nh'),
	(6, N'Ho�n th�nh'),
	(7, N'Ho�n th�nh'),
	(8, N'Ho�n th�nh'),
	(9, N'?ang x? l�'),
	(10, N'?ang x? l�'),
	(11, N'?ang x? l�');