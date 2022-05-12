﻿CREATE DATABASE ManageRestaurant
GO
use ManageRestaurant
go

USE MASTER 
GO
DROP DATABASE ManageRestaurant
GO




-- nhóm người dùng || phân quyền
CREATE TABLE GROUP_USER
(
	ID_GROUP VARCHAR(50)NOT NULL PRIMARY KEY,
	ROLE_USER NVARCHAR(50)NOT NULL,
	FLAG_DEL INT NOT NULL,
)
-- nhân viên
CREATE TABLE STAFF
(
	--ACCOUNT
	USERNAME_STAFF VARCHAR(50) NOT NULL PRIMARY KEY,
	PASSWORD_STAFF VARCHAR(50),
	ID_GROUP VARCHAR(50),
	--INFORMATION 
	SURNAME_STAFF NVARCHAR(100),
	NAME_STAFF NVARCHAR(100),
	GENDER_STAFF INT,-- 0: FEMALE , 1: MALE
	DATE_OF_BIRTH DATE,
	ADDRESS_STAFF NVARCHAR(MAX),
	NUMBER_PHONE VARCHAR(11),
	FLAG_DEL INT,
)


--danh mục sản phẩm || loại món
CREATE TABLE CATEGORY
(
	ID_CATEGORY VARCHAR(50) NOT NULL PRIMARY KEY,
	GROUP_CATEGORY NVARCHAR(100),
	NAME_CATEGORY NVARCHAR(100),
	FLAG_DEL INT
)
--sản phẩm || món ăn
CREATE TABLE PRODUCT
(
	ID_PRODUCT VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_CATEGORY VARCHAR(50) NOT NULL ,
	NAME_PRODUCT_VN NVARCHAR(50) NOT NULL,
	NAME_PRODUCT_EN NVARCHAR(50) NOT NULL,
	PRICE_PRODUCT INT,
	IMAGE_PRODUCT VARCHAR(MAX),
	FLAG_DEL INT
)
--chi tiết sản phẩm || công thức món ăn
CREATE TABLE DETAIL_PRODUCT
(
	ID_DETAIL VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_PRODUCT VARCHAR(50) NOT NULL,
	ID_MATERIAL VARCHAR(50) NOT NULL,
	WEIGHT_DETAIL INT,
	FLAG_DEL INT
)

--nguyên vật liệu && kho
CREATE TABLE MATERIAL
(
	ID_MATERIAL VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_DETAIL VARCHAR(50) NOT NULL,
	NAME_MATERIAL NVARCHAR(50) NOT NULL,
	INVENTORY INT,
	FLAG_DEL INT,
)


-- TIN TUC SU KIEN
CREATE TABLE NEWS
(	
	ID_NEWS VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_IMAGE VARCHAR(50),
	DATE_CREATE DATE NOT NULL,
	USERNAME_STAFF VARCHAR(50) NOT NULL,
	TITLE NVARCHAR(MAX),
	CONTENT NVARCHAR(MAX),
	DATE_VISIBLE DATE,
	DATE_HIDDEN DATE,
)

CREATE TABLE IMAGE_NEWS
(	
	ID_IMAGE VARCHAR(50) NOT NULL PRIMARY KEY,
	PATH_IMAGE VARCHAR(MAX) NOT NULL,
)

-- LOẠI KHÁCH HÀNG


-- KHÁCH HÀNG
CREATE TABLE CUSTOMER
(
	ID_CUSTOMER VARCHAR(50) NOT NULL PRIMARY KEY,
	NAME_CUSTOMER NVARCHAR(50) NOT NULL,
	SURNAME_CUSTOMER NVARCHAR(50) NOT NULL,
	GENDER_CUSTOMER INT,
	DATE_CREATE DATE,
	DATE_UPDATE DATE,
	PHONE_CUSTOMER VARCHAR(11),
	MAIL_CUSTOMER VARCHAR(MAX),
	PASSWORD_CUSTOMER VARCHAR(50),
	ADDRESS_CUSTOMER NVARCHAR(MAX),
	DATE_OF_BIRTH DATE,
	POINT INT,
	TYPE_CUSTOMER NVARCHAR(50),
)







-- VÙNG THANH TOÁN 
-- HÓA ĐƠN
CREATE TABLE RECEIPT
(
	ID_RECEIPT VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_VOUCHER VARCHAR(50),
	ID_CUSTOMER VARCHAR(50) ,
	ID_METHOD VARCHAR(50),
	DATE_CREATE DATE,
	TOTAL_PRODUCT int,
	TOTAL_PRICE int,
	POINT int,
)
--CHI TIẾT HÓA ĐƠN
CREATE TABLE DETAIL_RECEIPT 
(
	ID_DETAIL_RECEIPT  VARCHAR(50) not null PRIMARY KEY,
	ID_RECEIPT VARCHAR(50) not null,
	ID_PRODUCT VARCHAR(50) not null,
	QUANTITY INT,
	PRICE INT ,
)
-- PHƯƠNG THỨC THANH TOÁN 
CREATE TABLE METHOD_PAY
(
	ID_METHOD VARCHAR(50)NOT NULL PRIMARY KEY,
	USERNAME_STAFF VARCHAR(50) NOT NULL,
	DATE_CREATE DATE,
	TYPE_METHOD  VARCHAR(50)NOT NULL ,
	NAME_METHOD  NVARCHAR(50) not null,
	FLAG_DEL INT
)

CREATE TABLE VOUCHER
(
	ID_VOUCHER VARCHAR(50) NOT NULL PRIMARY KEY,
	USERNAME_STAFF VARCHAR(50) NOT NULL,
	DATE_CREATE DATE,
	DATE_START DATE,
	DATE_END DATE,
	TYPE_REDUCTION NVARCHAR(50),
	PERCENT_REDUCTION INT,
	AMOUNT_REDUCTION INT,
	QUANTITY_VOUCHER INT,
	FLAG_DEL INT,
)









-- VÙNG NHẬP HÀNG 
-- NHÀ CUNG CẤP
CREATE TABLE SUPPLIER
(
	ID_SUPPLIER VARCHAR(50) not null PRIMARY KEY,
	NAME_SUPPLIER nvarchar(MAX),
	PHONE_SUPPLIER VARCHAR(11),
	ADDRESS_SUPPLIER NVARCHAR(MAX),
	FLAG_DEL INT,
)
-- NHẬP KHẨU HÀNG HÓA
-- IOG STAND FOR IMPORT_OF_GOODS
CREATE TABLE IMPORT
(
	ID_IOG VARCHAR(50) not null PRIMARY KEY,
	ID_SUPPLIER VARCHAR(50),
	USERNAME_STAFF VARCHAR(50),
	DATE_IOG date NOT NULL,
	TOTAL_PRICE int,
	NOTE NVARCHAR(MAX),
	FLAG_DEL INT,
)
-- CHI TIẾT ĐƠN NHẬP KHẨU 
CREATE TABLE DETAIL_IMPORT
(
	ID_DETAIL_IOG  VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_IOG VARCHAR(50) NOT NULL,
	ID_MATERIAL VARCHAR(50) NOT NULL,
	ID_SUPPLIER VARCHAR(50) not null,
	PRICE INT,
	QUANTITY INT,
)


BEGIN --FOREIGN KEY

--STAFF
ALTER TABLE STAFF
ADD CONSTRAINT FK_STAFF_GROUPUSER FOREIGN KEY (ID_GROUP) REFERENCES GROUP_USER(ID_GROUP)
--PRODUCT
ALTER TABLE PRODUCT
ADD CONSTRAINT FK_PRO_CATE FOREIGN KEY (ID_CATEGORY) REFERENCES CATEGORY(ID_CATEGORY)
--DETAIL PRODUCT
ALTER TABLE DETAIL_PRODUCT
ADD CONSTRAINT FK_DETAILPRO_PRO FOREIGN KEY (ID_PRODUCT) REFERENCES PRODUCT(ID_PRODUCT)
--MATERIAL
ALTER TABLE MATERIAL
ADD CONSTRAINT FK_MRL_DETAILPRO FOREIGN KEY (ID_DETAIL) REFERENCES DETAIL_PRODUCT(ID_DETAIL)
--NEWS
ALTER TABLE NEWS
ADD CONSTRAINT FK_NEWS_IMG FOREIGN KEY (ID_IMAGE) REFERENCES IMAGE_NEWS(ID_IMAGE)

--RECEIPT

ALTER TABLE RECEIPT
ADD CONSTRAINT FK_RECEIPT_VOUCHER FOREIGN KEY (ID_VOUCHER) REFERENCES VOUCHER(ID_VOUCHER)

ALTER TABLE RECEIPT
ADD CONSTRAINT FK_RECEIPT_METHOD FOREIGN KEY (ID_METHOD) REFERENCES METHOD_PAY(ID_METHOD)

ALTER TABLE RECEIPT
ADD CONSTRAINT FK_RECEIPT_CUSTOMER FOREIGN KEY (ID_CUSTOMER) REFERENCES CUSTOMER(ID_CUSTOMER)

--DETAIL RECEIPT 
ALTER TABLE DETAIL_RECEIPT
ADD CONSTRAINT FK_DETAILRECEIPT_RECEIPT FOREIGN KEY (ID_RECEIPT) REFERENCES RECEIPT(ID_RECEIPT)

ALTER TABLE DETAIL_RECEIPT
ADD CONSTRAINT FK_DETAILRECEIPT_PRODUCT FOREIGN KEY (ID_PRODUCT) REFERENCES PRODUCT(ID_PRODUCT)

-- METHOD_PAY
ALTER TABLE METHOD_PAY
ADD CONSTRAINT FK_METHODPAY_STAFF FOREIGN KEY (USERNAME_STAFF) REFERENCES STAFF(USERNAME_STAFF)

--VOUCHER
ALTER TABLE VOUCHER
ADD CONSTRAINT FK_VOUCHER_STAFF FOREIGN KEY (USERNAME_STAFF) REFERENCES STAFF(USERNAME_STAFF)

--IMPORT_OF_GOODS
ALTER TABLE IMPORT
ADD CONSTRAINT FK_IOG_STAFF FOREIGN KEY (USERNAME_STAFF) REFERENCES STAFF(USERNAME_STAFF)

ALTER TABLE IMPORT
ADD CONSTRAINT FK_IOG_SUPPLIER FOREIGN KEY(ID_SUPPLIER) REFERENCES SUPPLIER(ID_SUPPLIER)
-- DETAIL IMPORT_OF_GOODS
ALTER TABLE DETAIL_IMPORT
ADD CONSTRAINT FK_DETAILIMPORT_IOG FOREIGN KEY(ID_IOG) REFERENCES IMPORT(ID_IOG)

ALTER TABLE DETAIL_IMPORT
ADD CONSTRAINT FK_DETAILIMPORT_MATERIAL FOREIGN KEY(ID_MATERIAL) REFERENCES MATERIAL(ID_MATERIAL)


END


-- CATEGORY DATA
INSERT INTO CATEGORY VALUES 
('IDLMON01',N'MAIN',N'PREMIUM STEAK',0),
('IDLMON02',N'MAIN',N'PEPPER RICE',0),
('IDLMON03',N'MAIN',N'JAPANESE CLASSICS',0),
('IDLMON04',N'MAIN',N'TEPPAN PASTA',0),
('IDLMON05',N'MAIN',N'CHEESY SIZZLING RICE',0),
('IDLMON06',N'MAIN',N'SPECIAL COMBO',0),
('IDLMON07',N'SIDE',N'SIDE DISHES',0),
('IDLMON08',N'SIDE',N'ICE CREAM',0),
('IDLMON09',N'SIDE',N'DRINKS',0),
('IDLMON10',N'SIDE',N'ADD-ONS',0),
('IDLMON11',N'COMBO',N'COMBO',0)

-- PRODUCT DATA
------PRODUCT------
--PRODUCT PREMIUM STEAK---
INSERT INTO PRODUCT VALUES 
--PRODUCT PREMIUM STEAK---1
('MAMON01','IDLMON01',N'The Giant',N'Bò Mỹ Thượng Hạng',369000,'IMAGE',0),
('MAMON02','IDLMON01',N'Ribeye Steak',N'Bò Mỹ Ribeye',299000,'IMAGE',0),
('MAMON03','IDLMON01',N'Pepper Steak',N'Bò Úc Tiêu Đen',239000,'IMAGE',0),
('MAMON04','IDLMON01',N'Hitokuchi Steak',N'Mông Bò Hitokuchi',369000,'IMAGE',0),
('MAMON05','IDLMON01',N'Hamburger Eggs',N'Hamburger Với Trứng',169000,'IMAGE',0),
--PRODUCT PEPPER RICE----2
('MAMON07','IDLMON02',N'Jumbo Beef Pepper Rice',N'Cơm Bò Mỹ Siêu Khủng',149000,'IMAGE',0),
('MAMON08','IDLMON02',N'Beef Pepper Rice',N'Cơm Bò Mỹ Tiêu Đen',99000,'IMAGE',0),
('MAMON09','IDLMON02',N'Chicken Pepper Rice',N'Cơm Gà Tiêu Đen',89000,'IMAGE',0),
('MAMON10','IDLMON02',N'Salmon Pepper Rice',N'Cơm Cá Hồi Tiêu Đen',139000,'IMAGE',0),
('MAMON12','IDLMON02',N'Broccoli & Mushroom Pepper Rice',N'Cơm Chay Tiêu Đen',89000,'IMAGE',0),
--PRODUCT JAPANESE CLASSICS----3
('MAMON14','IDLMON03',N'Beef Sukiyaki',N'Bò Sốt Sukiyaki',169000,'IMAGE',0),
('MAMON17','IDLMON03',N'Salmon Sukiyaki',N'Cá Hồi Sốt Sukiyaki',219000,'IMAGE',0),
('MAMON18','IDLMON03',N'Teriyaki Chicken',N'Gà Sốt Teriyaki',149000,'IMAGE',0),
('MAMON19','IDLMON03',N'Teriyaki Salmon And Saba',N'Cá Hồi Và Cá Thu Nhật Sốt Teriyaki',209000,'IMAGE',0),
--PRODUCT TEPPAN PASTA----4
('MAMON20','IDLMON04',N'Beef Aglio Olio',N'Mì Ý Bò Sốt Aglio',139000,'IMAGE',0),
('MAMON21','IDLMON04',N'Seafood Aglio Olio',N'Mì Ý Hải Sản Sốt Aglio',119000,'IMAGE',0),
('MAMON22','IDLMON04',N'Chicken & Cheese Chicken Sausage Pasta',N'Mì Ý Gà Và Xúc Xích Phô Mai Gà',149000,'IMAGE',0),
('MAMON23','IDLMON04',N'Seafood Creamy Cheese Pasta',N'Mì Ý Hải Sản Sốt Phô Mai Kem',139000,'IMAGE',0),
--PRODUCT CHEESY ---5
('MAMON15','IDLMON05',N'Scallop & Prawn',N'VN_NAME',169000,'IMAGE',0),
('MAMON24','IDLMON05',N'Beef Hamburger & Beef',N'VN_NAME',199000,'IMAGE',0),
('MAMON25','IDLMON05',N'Scallop & Chicken',N'VN_NAME',169000,'IMAGE',0),
('MAMON26','IDLMON05',N'Broccoli & Mushroom',N'VN_NAME',169000,'IMAGE',0),
--PRODUCT SPECIAL COMBO---6
('MAMON31','IDLMON06',N'Ultimate Meat Deluxe',N'VN_NAME',299000,'IMAGE',0),
('MAMON32','IDLMON06',N'Beef Trio Deluxe',N'VN_NAME',249000,'IMAGE',0),
('MAMON33','IDLMON06',N'Meat Trio Deluxe',N'VN_NAME',199000,'IMAGE',0),
('MAMON34','IDLMON06',N'Dice Cut Beef & Chicken',N'VN_NAME',199000,'IMAGE',0),
('MAMON35','IDLMON06',N'Seafood Trio Deluxe',N'VN_NAME',179000,'IMAGE',0) ,
('MAMON37','IDLMON06',N'Salmon & Chicken',N'VN_NAME',189000,'IMAGE',0),
('MAMON38','IDLMON06',N'Saba & Chicken',N'VN_NAME',89000,'IMAGE',0),
--PRODUCT SIDE DISHES---
('MAMON59','IDLMON07','Macaroni & Cheese ',N'Mì Ông Và Phô Mai',22000,'IMAGE',0),
('MAMON60','IDLMON07','Seasonal Dessert',N'Món Tráng Miệng Theo Mùa',28000,'IMAGE',0),
('MAMON61','IDLMON07','Mashed Potato',N'Khoai Tây Nghiền',28000,'IMAGE',0),
('MAMON62','IDLMON07','Seasonal Soup',N'Súp Theo Mùa',22000,'IMAGE',0),
('MAMON63','IDLMON07','Miso Soup',N'Súp Miso Rong Biển',25000,'IMAGE',0),
--PRODUCT ICE-CREAM---
('MAMON64','IDLMON08','Vanilla',N'Kem Vani',25000,'IMAGE',0),
('MAMON65','IDLMON08','Chocolate',N'Kem Sô Cô La',25000,'IMAGE',0),
('MAMON67','IDLMON08','Strawberries & Cream',N'Kem Dâu',25000,'IMAGE',0),
--PRODUCT DRINKS---
('MAMON49','IDLMON09','Pepsi',N'Pepsi',20000,'IMAGE',0),
('MAMON50','IDLMON09','Mirinda',N'Mirinda',20000,'IMAGE',0),
('MAMON51','IDLMON09','7 Up',N'7 Up',20000,'IMAGE',0),
('MAMON52','IDLMON09','Aquafina',N'Nước Suối',20000,'IMAGE',0),
('MAMON53','IDLMON09','Nestle Milo',N'Sữa Milo',20000,'IMAGE',0),
('MAMON54','IDLMON09','Hot Green Tea',N'Trà Xanh Nóng',20000,'IMAGE',0),
--PRODUCT ADD-ONS---
('MAMON39','IDLMON10','King Oyster Mushroom',N'Nấm Sò vua',12000,'IMAGE',0),
('MAMON40','IDLMON10','Edamame',N'Đậu Nhật',7000,'IMAGE',0),
('MAMON41','IDLMON10','Cabbage',N'Bắp Cải',30000,'IMAGE',0),
('MAMON42','IDLMON10','Broccoli',N'Bông Cải Xanh',30000,'IMAGE',0),
('MAMON43','IDLMON10','Sweet Corn',N'Bắp ngọt',5000,'IMAGE',0),
('MAMON44','IDLMON10','Okra',N'Đậu Bắp',15000,'IMAGE',0),
('MAMON45','IDLMON10','Egg',N'Trứng Gà',20000,'IMAGE',0),
('MAMON46','IDLMON10','Beef',N'Bò',30000,'IMAGE',0),
('MAMONBPS1','IDLMON10','Chicken',N'Gà',12000,'IMAGE',0),
('MAMONBPS2','IDLMON10','Cheese Chicken Sausage',N'Súc Xích Gà Phô Mai',12000,'IMAGE',0),
('MAMONBJC1','IDLMON10','Salmon',N'Cá Hồi',10000,'IMAGE',0),
('MAMONBJC2','IDLMON10','Scallops',N'Sò',15000,'IMAGE',0),
('MAMON47','IDLMON10','Prawns',N'Tôm',30000,'IMAGE',0),
--PRODUCT COMBOS 
('MAMONCB01','IDLMON11','SET A',N'Combo A',30000,'IMAGE',0),
('MAMONCB02','IDLMON11','SET B',N'Combo B',40000,'IMAGE',0)




-- CREATE VIEWS HERE

CREATE VIEW RECEIPT_FULL AS
SELECT RC.*,VC.PERCENT_REDUCTION,VC.AMOUNT_REDUCTION ,CUS.ADDRESS_CUSTOMER,CUS.MAIL_CUSTOMER,CUS.NAME_CUSTOMER,CUS.SURNAME_CUSTOMER,CUS.PHONE_CUSTOMER,
MT.NAME_METHOD,MT.TYPE_METHOD
FROM RECEIPT AS RC, VOUCHER AS VC,CUSTOMER AS CUS ,METHOD_PAY AS MT
WHERE RC.ID_VOUCHER = VC.ID_VOUCHER
AND RC.ID_CUSTOMER=CUS.ID_CUSTOMER
AND RC.ID_METHOD = MT.ID_METHOD


SET DATEFORMAT DMY;
INSERT INTO GROUP_USER
VALUES
('AD1','ADMIN',0),
('USER1','USER',0)


INSERT INTO STAFF
VALUES
('NV1','123','AD1',N'PHẠM MINH',N'TOÀN',1,'20-05-2001',N'370 B Binh Dong','0901395705',0),
('NV2','123','USER1',N'NGUYEN THI',N'NGUOI DUNG',1,'20-05-2001',N'Phuong 15 Q8','0901395705',0)


--DELETE FROM RECEIPT
INSERT INTO RECEIPT
VALUES
('ID001','ABCXYZ','KH01','PT1','1-1-2010',9,5000000,10),
('ID002','ABCXYZ','KH01','PT1','1-1-2010',10,5000000,10),
('ID003','ABCXYZ','KH01','PT1','1-1-2010',130,5000000,10),
('ID004','ABCXYZ',null,null,'1-1-2010',10,5000000,10)

INSERT INTO VOUCHER
VALUES
('ABCXYZ','NV1','04-30-1975','11-05-2021','12-05-2022','PERCENT',15,15000,100,0)


INSERT INTO CUSTOMER
VALUES
('KH01','HUNG','LY',1,'5-1-2022',NULL,'0901395705','phmtoan2005@gmail.com','123','HCM','20-5-2001',0,'NORMAL')


INSERT INTO METHOD_PAY
VALUES
('PT1','NV1','30-05-2021','THE TIN DUNG','INTERNET BANKING',0)