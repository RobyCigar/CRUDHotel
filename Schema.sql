/*

Rabih Utomo 20.02.0607

*/



CREATE TABLE Pemesan (
	id CHAR(5) PRIMARY KEY,
	nama VARCHAR(50) NOT NULL,
	email VARCHAR(40) NULL,
	telp VARCHAR(20) NOT NULL
)

CREATE TABLE Kamar (
	id CHAR(5) NOT NULL PRIMARY KEY,
	tipe VARCHAR(50) NOT NULL,
	harga INT NOT NULL
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

 DROP DATABASE Tugas_Join;


INSERT INTO Pemesan(ID, nama, email, telp) VALUES 
('P0002', 'Naruto', 'naruto@gmail.com', '085888888');

INSERT INTO Kamar(id, tipe, harga) VALUES
('K0001', 'Double Bed', 900000)

INSERT INTO Transaksi(id, id_pemesan, checkin, checkout, harga_total) VALUES 
('T0001', 'P0001', '2021-06-28', '2021-06-30', 900000)

INSERT INTO Transaksi_Kamar(id_transaksi, id_kamar) VALUES 
('T0001', 'K0001')

INSERT INTO Pemesan(ID, nama, email, telp) VALUES 
('P0002', 'Sakura', 'sakura@gmail.com', '085888888');

INSERT INTO Kamar(id, tipe, harga) VALUES
('K0002', 'Double Bed', 900000)

INSERT INTO Transaksi(id, id_pemesan, checkin, checkout, harga_total) VALUES 
('T0002', 'P0002', '2021-06-28', '2021-06-30', 900000)

INSERT INTO Transaksi_Kamar(id_transaksi, id_kamar) VALUES 
('T0002', 'K0002')

SELECT * FROM Pemesan
SELECT * FROM Kamar
SELECT * FROM Transaksi
SELECT * FROM Transaksi_Kamar


SELECT * FROM Pemesan AS p 
JOIN Transaksi AS t 
ON t.id_pemesan = p.id

SELECT * FROM Pemesan AS p 
JOIN Transaksi AS t 
ON t.id_pemesan = p.id
JOIN Transaksi_Kamar AS tk
ON tk.id_transaksi = t.id

GO

CREATE PROCEDURE storekmr
	@id VARCHAR(5) = NULL,
	@tipe VARCHAR(20) = NULL,
	@harga INTEGER = NULL
AS
BEGIN
	INSERT INTO Kamar(id, tipe, harga) VALUES
	(@id, @tipe, @harga)
END

GO

EXEC storekmr
	@id = 'K0003',
	@tipe = 'Single Bed',
	@harga = 1000000


CREATE PROCEDURE join2tbl
AS 
BEGIN
	SELECT * FROM Pemesan AS p 
	JOIN Transaksi AS t 
	ON t.id_pemesan = p.id
END
GO

EXEC join2tbl

CREATE PROCEDURE join3tbl
AS
	SELECT * FROM Pemesan AS p 
	JOIN Transaksi AS t 
	ON t.id_pemesan = p.id
	JOIN Transaksi_Kamar AS tk
	ON tk.id_transaksi = t.id
GO

EXEC join3tbl;
END

CREATE VIEW [cust] AS
SELECT nama, email, telp
FROM Pemesan

SELECT * FROM [cust]

GO

CREATE VIEW [tampilkan_double_bed]
AS
		SELECT *
		FROM Kamar
		WHERE tipe LIKE '%Double%';
GO

SELECT 
    * 
FROM 
    tampilkan_double_bed


GO
CREATE PROCEDURE [dbo].[USP_UserRoles_Select]
(
    @Rolename VARCHAR(30) = ''
)
AS
BEGIN
    Select ID,Name
    FROM
        AspNetRoles
    WHERE
        Name like  @Rolename +'%'
END
GO

EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"

DECLARE @sql NVARCHAR(max)=''

SELECT @sql += ' Drop table ' + QUOTENAME(s.NAME) + '.' + QUOTENAME(t.NAME) + '; '
FROM   sys.tables t
       JOIN sys.schemas s
         ON t.[schema_id] = s.[schema_id]
WHERE  t.type = 'U'

Exec sp_executesql @sql
