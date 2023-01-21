//CREATE DATABASE ShippingDB; --perintah untuk membuat database
//

/*
 
 --CREATE DATABASE ShippingDB; --perintah untuk membuat database
--merubah database atau tabel
USE MASTER;
GO -- untuk menjalankan perintah diatas
--ALTER DATABASE ShippingDB SET SINGLE_USER; -- WITH ROLLBACK IMMEDIATE;
--GO

ALTER DATABASE ShipDB2 MODIFY NAME = ShipDB; -- merubah database menjadi ship_db
GO

--ALTER DATABASE ShipDB SET MULTI_USER; -- set database menjadi multi user kembali
--GO
 

--create tabel
USE ShipDB; -- perintah untuk berganti atau menggunakan database tertentu
CREATE TABLE Customer (cust_id INT, --membuat sebuah tabel dengan field dibawah
	cust_name VARCHAR(100), 
	ship_address VARCHAR(250), 
	news_letter VARCHAR(50) )

TIPe data pada SQL Server
numeric == BIGINT, SMALLINT, NUMERIC, BIT, DECIMAL, INT, SMALLMONEY, TINYINT, MONEY
decimal numeric, == FLOAT, REAL
datetime, == DATE, DATETIME, DATETIME2 (24 jam), DATETIMEOFFSET, SMALLDATETIME, TIME
string, == CHAR, VARCHAR 2GB, TEXT (65rb karakter)
unicode strings, == NCHAR, NVARCHAR(4GB), NTEXT(65K) == (menerima unicode,  bahasa aneh, misalnya huruf jepang,dll)
binary strings, == BINARY, IMAGE, VARBINARY == 2Gb, biasanya dipakai untuk menyimpan gambar tetapi NOT RECOMMENDED
other == CURSOR, XML, TABEL
 

DQL -- Data Query Language

--DQL

--SELECT * FROM Customer;

--SELECT cust_id, cust_name, ship_address, news_letter FROM Customer;

----DML
--INSERT INTO Customer 
--(cust_id, cust_name, ship_address, news_letter) 
--VALUES (1, 'Rafif3', NULL ,'');


--menambah field pada tabel
--USE ShipDB;
--ALTER TABLE Customer ADD zipcode INT ;

--menghapus kolom field tabel
--ALTER TABLE CUSTOMER DROP COLUMN zipcode;

--menghapus tabel
--DROP TABLE Customer;


-- UPDATE == untuk mengupdate / merubah field pada tabel
-- cara 1 untuk mengupdate semua record --TIDAK ADA Predicate
--UPDATE Customer 
--SET cust_id = 1,
--cust_name = 'Raihanudin Rafif'

--cara 2 == untuk mengupdate record tertentu
--UPDATE Customer
--SET news_letter = 'C# Fund'
--WHERE cust_id = 1

--SELECT * FROM Customer;


--DELETE == untuk menghapus record pada sebuah tabel
--DELETE FROM Customer -- untuk mendelete semua record yg ada HATI HATI GAN


--DELETE FROM Customer WHERE cust_name = 'Rafif2'; -- untuk mendelete record dengan kondisi tertentu.


--MERGE yakni  menggabungkan tabel

--USE ShipDB; -- perintah untuk berganti atau menggunakan database tertentu
--CREATE TABLE CustomerBakery (cust_id INT, --membuat sebuah tabel dengan field dibawah
--	cust_name VARCHAR(100), 
--	ship_address VARCHAR(250), 
--	news_letter VARCHAR(50) )

--INSERT INTO CustomerBakery 
--(cust_id, cust_name, ship_address, news_letter) 
--VALUES (4, 'Rafif4', NULL ,'Tangerang Lagi');

--SELECT * FROM CustomerBakery;
--SELECT * FROM Customer;

--syntax merge
--MERGE CustomerBakery AS TARGET
--USING Customer AS SOURCE
--ON SOURCE.cust_id = TARGET.cust_id
--WHEN NOT MATCHED BY TARGET THEN
--	INSERT (cust_id, cust_name, ship_address, news_letter)
--	VALUES( SOURCE.cust_id, SOURCE.cust_name, SOURCE.ship_address, SOURCE.news_letter);

--syntax merge
--MERGE CustomerBakery AS TARGET
--USING Customer AS SOURCE
--ON SOURCE.cust_id = TARGET.cust_id
--WHEN NOT MATCHED BY TARGET THEN -- ini ketika sumber tidak sama dengan target 
--	INSERT (cust_id, cust_name, ship_address, news_letter)
--	VALUES( SOURCE.cust_id, SOURCE.cust_name, SOURCE.ship_address, SOURCE.news_letter)
--WHEN MATCHED THEN UPDATE SET --ini ketika sama antara sumber dan target
--	TARGET.ship_address = SOURCE.ship_address,
--	TARGET.news_letter = SOURCE.news_letter
--WHEN NOT MATCHED BY SOURCE THEN --ini jika target tidak sama dengan sumber (yg didelete adalah yg di target)
--	DELETE;



--CALL digunakan untuk mengeksekusi perintah tertentu
-- EXEC PROSEDURE 
CREATE PROCEDURE SelectAllCustomer
AS
	SELECT * FROM Customer
GO

--mengeksekusi
EXEC SelectAllCustomer  --perintah yang dijalankan akan sama dengan yang diatas

 --LOCK TABEL
SELECT * FROM Customer
WITH (TABLOCK); --mengunci tabel sampai transaksi selesai, semua eksekusi akan diblok otomatis oleh SQL Server

SELECT * FROM Customer
WITH (HOLDLOCK); -- mengunci tabel sampai transaksi selesai, semua eksekusi akan di hold sementara

SELECT * FROM Customer
WITH (UPDLOCK); --mengunci tabel tapi hanya pada perintah INSERT, UPDATE, DELETE, tapi memperbolehkan perintah SELECT

SELECT * FROM Customer
WITH (ROWLOCK); -- Mengunci table per row records dan merealese row records setelah diread

SELECT * FROM Customer
WITH (NOLOCK); -- tidak melakukan kuncian apapun dan akan mrealase setelah digunakan
 
 
 
 
 
 
 
 
 
 
 
 
 
 */