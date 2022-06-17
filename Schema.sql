/*

Rabih Utomo 20.02.0607

*/

CREATE DATABASE CRUDHotel

CREATE TABLE Users (
	username VARCHAR(50) NOT NULL PRIMARY KEY,
	password VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	telp VARCHAR(15) NOT NULL
)

CREATE TABLE Pemesan (
	id CHAR(5) PRIMARY KEY,
	nama VARCHAR(50) NOT NULL,
	email VARCHAR(40) NULL,
	telp VARCHAR(20) NOT NULL
)

CREATE TABLE Kamar (
	id CHAR(5) NOT NULL PRIMARY KEY,
	tipe VARCHAR(50) NOT NULL,
	harga INT NOT NULL,
	tersedia INT DEFAULT 0,
	jumlah INT DEFAULT 0
)

CREATE TABLE Transaksi (
	id CHAR(5) NOT NULL PRIMARY KEY,
	id_pemesan CHAR(5) FOREIGN KEY REFERENCES Pemesan(id),
	checkin DATETIME,
	checkout DATETIME,
	harga_total INT NOT NULL
)

CREATE TABLE Transaksi_Kamar (
	id_transaksi CHAR(5) NOT NULL FOREIGN KEY REFERENCES Transaksi(id),
	id_kamar CHAR(5) NOT NULL FOREIGN KEY REFERENCES Kamar(id)
)


/*
	Insert data things
*/

 INSERT INTO Users(username, password, email, telp) VALUES 
('naruto', 'naruto', 'naruto@gmail.com', '0851234567');

INSERT INTO Pemesan(ID, nama, email, telp) VALUES 
('P0002', 'Naruto', 'naruto@gmail.com', '085888888');

INSERT INTO Kamar(id, tipe, harga, tersedia, jumlah) VALUES
('K0001', 'Double Bed', 900000, 3, 5)

INSERT INTO Transaksi(id, id_pemesan, checkin, checkout, harga_total) VALUES 
('T0001', 'P0001', '2021-06-28', '2021-06-30', 900000)

INSERT INTO Transaksi_Kamar(id_transaksi, id_kamar) VALUES 
('T0001', 'K0001')

INSERT INTO Pemesan(ID, nama, email, telp) VALUES 
('P0002', 'Sakura', 'sakura@gmail.com', '085888888');

INSERT INTO Kamar(id, tipe, harga, tersedia, jumlah) VALUES
('K0002', 'Double Bed', 900000, 5, 10)

INSERT INTO Transaksi(id, id_pemesan, checkin, checkout, harga_total) VALUES 
('T0002', 'P0002', '2021-06-28', '2021-06-30', 900000)

INSERT INTO Transaksi_Kamar(id_transaksi, id_kamar) VALUES 
('T0002', 'K0002')

SELECT * FROM Users
SELECT * FROM Pemesan
SELECT * FROM Kamar
SELECT * FROM Transaksi
SELECT * FROM Transaksi_Kamar


/*
	Procedure things
*/

/* Kamar procedure */

GO
CREATE Procedure [dbo].[ValidateUserCredentials]
@username varchar(50),
@password varchar(50)
AS
BEGIN
	SELECT * FROM Users WHERE username = @username COLLATE SQL_Latin1_General_CP1_CS_AS AND password = @password COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO

CREATE Procedure [dbo].[GetAllKamar]
AS
SELECT * FROM Kamar
GO

CREATE PROCEDURE AddKamar
	@id VARCHAR(5) = NULL,
	@tipe VARCHAR(20) = NULL,
	@harga INTEGER = NULL,
	@tersedia INTEGER = 0,
	@jumlah INTEGER = 0
AS
BEGIN
	INSERT INTO Kamar(id, tipe, harga, tersedia, jumlah) VALUES
	(@id, @tipe, @harga, @tersedia, @jumlah)
END
GO

CREATE PROCEDURE EditKamar
	@id VARCHAR(5) = NULL,
	@tipe VARCHAR(20) = NULL,
	@harga INTEGER = NULL,
	@tersedia INTEGER = 0,
	@jumlah INTEGER = 0
AS
BEGIN
	UPDATE Kamar 
	SET tipe = @tipe, harga = @harga, tersedia = @tersedia, jumlah = @jumlah WHERE id = @id
END
GO

CREATE Procedure [dbo].[DeleteKamar]
@id VARCHAR(5)
AS
	DELETE FROM Kamar WHERE id = @id
GO


/* User procedure */

CREATE Procedure [dbo].[GetAllUser]
AS
SELECT * FROM Users
GO

CREATE PROCEDURE [dbo].[AddUser]
(
	@username varchar(50),
	@password varchar(50),
	@email varchar(50),
	@telp varchar(50)
)
AS
BEGIN
	INSERT INTO Users (username, password, email, telp)
	VALUES(@username, @password, @email, @telp)
END

GO

CREATE Procedure [dbo].[DeleteUser]
(@username varchar(50))
AS
BEGIN
DELETE FROM Users WHERE username = @username
END
GO

CREATE PROCEDURE [dbo].[EditUser]
(
	@username varchar(50),
	@password varchar(50),
	@email varchar(50),
	@telp varchar(50)
)
AS
BEGIN
	UPDATE Users 
	SET username = @username, password = @password, email = @email, telp = @telp
	WHERE username = @username
END

/* 
	Drop procedure things 
*/

DROP PROCEDURE [ValidateUserCredentials];  
DROP PROCEDURE [AddKamar];
DROP PROCEDURE [GetAllKamar];
DROP PROCEDURE [DeleteKamar];  
DROP PROCEDURE [EditKamar];

DROP PROCEDURE [AddUser]
DROP PROCEDURE [GetAllUser]
DROP PROCEDURE [DeleteUser]
DROP PROCEDURE [EditUser]

/* 
	Drop all tables
*/

DROP TABLE Users
SELECT * FROM Pemesan
SELECT * FROM Kamar
SELECT * FROM Transaksi
SELECT * FROM Transaksi_Kamar


EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"

DECLARE @sql NVARCHAR(max)=''

SELECT @sql += ' Drop table ' + QUOTENAME(s.NAME) + '.' + QUOTENAME(t.NAME) + '; '
FROM   sys.tables t
       JOIN sys.schemas s
         ON t.[schema_id] = s.[schema_id]
WHERE  t.type = 'U'

Exec sp_executesql @sql

DROP TABLE Kamar
