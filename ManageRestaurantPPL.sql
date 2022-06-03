CREATE DATABASE ManageRestaurant
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
	ID_GROUP VARCHAR(50) NOT NULL PRIMARY KEY,
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
	NAME_PRODUCT_EN NVARCHAR(50) NOT NULL,
	NAME_PRODUCT_VN NVARCHAR(50) NOT NULL,
	PRICE_PRODUCT INT,
	IMAGE_PRODUCT VARCHAR(MAX),
	FLAG_DEL INT
)
--chi tiết sản phẩm || công thức món ăn
CREATE TABLE DETAIL_PRODUCT
(
	ID_DETAIL VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_PRODUCT VARCHAR(50) NOT NULL,
	ID_INGREDIENT VARCHAR(50) NOT NULL,
	WEIGHT_DETAIL INT,
	FLAG_DEL INT
)

--nguyên vật liệu && kho
CREATE TABLE INGREDIENT
(
	ID_INGREDIENT VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_SUPPLIER VARCHAR(50),
	NAME_INGREDIENT NVARCHAR(50) NOT NULL,
	INVENTORY INT,
	FLAG_DEL INT,
)


-- TIN TUC SU KIEN
CREATE TABLE NEWS
(	
	ID_NEWS VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_PROMOTION VARCHAR(50),
	USERNAME_STAFF VARCHAR(50) NOT NULL,
	TITLE NVARCHAR(MAX),
	CONTENT NVARCHAR(MAX),
	DATE_VISIBLE DATE,
	DATE_HIDDEN DATE,
	FLAG_DEL int,
)


CREATE TABLE IMAGE_NEWS
(	
	ID_IMAGE VARCHAR(50) NOT NULL PRIMARY KEY,
	ID_NEWS VARCHAR(50) NOT NULL ,
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
	PASSWORD_CUSTOMER VARCHAR(MAX),
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
	ID_CUSTOMER VARCHAR(50),
	ID_METHOD VARCHAR(50),
	DATE_CREATE DATE,
	TOTAL_PRODUCT int,
	TOTAL_PRICE int,
	POINT int,
	STATE_RECEIPT INT,
	ADDRESS_RECEIPT NVARCHAR(MAX)
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
	ID_PROMOTION VARCHAR(50),
	DATE_CREATE DATE,
	DATE_START DATE,
	DATE_END DATE,
	TYPE_REDUCTION NVARCHAR(50),
	TYPE_CUSTOMER NVARCHAR(50),
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
	ID_INGREDIENT VARCHAR(50) NOT NULL,
	PRICE INT,
	QUANTITY INT,
)

--BANG CHUONG TRINH KHUYEN MAI
CREATE TABLE PROMOTION
(
	ID_PROMOTION VARCHAR(50) NOT NULL PRIMARY KEY,--MA CHUONG TRINH KM
	NAME_PROMOTION VARCHAR(MAX),--TEN CTKM
	USERNAME_STAFF VARCHAR(50),--MA NV TAO
	DATE_CREATE DATE,--NGAY TAO
	DATE_START DATE,--NGAY BAT DAU CHUONG TRINH
	DATE_END DATE,--NGAY KET THUC CHUONG TRINH
	FLAG_DEL int,
)
--BANG LOAI KHACH HANG
CREATE TABLE CUSTOMER_TYPE
(
	TYPE_CUSTOMER NVARCHAR(50) NOT NULL PRIMARY KEY,--MA LOAI KHACH HANG
	NAME_TYPE NVARCHAR(50),--TEN LOAI KHACH HANG
	LEVEL_TYPE INT,--MUC KHACH HANG,VD: 0--THANH VIEN,1-BAC,2-VANG,3-BACH KIM,...
	POINT_MIN INT,--DIEM TOI THIEU CUA HANG KHACH HANG VD: THANH VIEN:0
	POINT_MAX INT,--DIEM TOI DA CUA HANG KHACH HANGVD:THANHVIEN:100
	POINT_RATE FLOAT,--TI LE TICH DIEM TREN HOA DON, VD: THANHVIEN:0.1=10%
	FLAG_DEL int,
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
ALTER TABLE DETAIL_PRODUCT
ADD CONSTRAINT FK_DETAILPRO_INGREDIENT FOREIGN KEY (ID_INGREDIENT) REFERENCES INGREDIENT(ID_INGREDIENT)
--NEWS

ALTER TABLE NEWS
ADD CONSTRAINT FK_NEWS_PROMO FOREIGN KEY(ID_PROMOTION) REFERENCES PROMOTION(ID_PROMOTION)

ALTER TABLE NEWS
ADD CONSTRAINT FK_NEWS_STAFF FOREIGN KEY(USERNAME_STAFF) REFERENCES STAFF(USERNAME_STAFF)
--NEWS IMAGE

ALTER TABLE IMAGE_NEWS
ADD CONSTRAINT FK_IMAGE_NEWS_NEWS FOREIGN KEY (ID_NEWS) REFERENCES NEWS(ID_NEWS)

--CUSTOMER  
ALTER TABLE CUSTOMER
ADD CONSTRAINT FK_CUSTOMER_TYPE FOREIGN KEY(TYPE_CUSTOMER) REFERENCES CUSTOMER_TYPE(TYPE_CUSTOMER)


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
ALTER TABLE VOUCHER
ADD CONSTRAINT FK_VOUCHER_PROMO FOREIGN KEY(ID_PROMOTION) REFERENCES PROMOTION(ID_PROMOTION)
ALTER TABLE VOUCHER
ADD CONSTRAINT FK_VOUCHER_TYPE FOREIGN KEY(TYPE_CUSTOMER) REFERENCES CUSTOMER_TYPE(TYPE_CUSTOMER)


--IMPORT_OF_GOODS
ALTER TABLE IMPORT
ADD CONSTRAINT FK_IOG_STAFF FOREIGN KEY (USERNAME_STAFF) REFERENCES STAFF(USERNAME_STAFF)

ALTER TABLE IMPORT
ADD CONSTRAINT FK_IOG_SUPPLIER FOREIGN KEY(ID_SUPPLIER) REFERENCES SUPPLIER(ID_SUPPLIER)
-- DETAIL IMPORT_OF_GOODS
ALTER TABLE DETAIL_IMPORT
ADD CONSTRAINT FK_DETAILIMPORT_IOG FOREIGN KEY(ID_IOG) REFERENCES IMPORT(ID_IOG)

ALTER TABLE DETAIL_IMPORT
ADD CONSTRAINT FK_DETAILIMPORT_INGREDIENT FOREIGN KEY(ID_INGREDIENT) REFERENCES INGREDIENT(ID_INGREDIENT)

-- PROMOTION
ALTER TABLE PROMOTION
ADD CONSTRAINT FK_DETAILIMPORT_STAFF FOREIGN KEY(USERNAME_STAFF) REFERENCES STAFF(USERNAME_STAFF)

END

SET DATEFORMAT DMY;

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
('MAMON01','IDLMON01',N'The Giant',N'Bò Mỹ Thượng Hạng',369000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPremiumSteak%2FTheGIANT.png?alt=media&token=b410306b-dfab-44f0-bb61-b465b422418d',0),
('MAMON02','IDLMON01',N'Ribeye Steak',N'Bò Mỹ Ribeye',299000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPremiumSteak%2FRibeyeSteak.png?alt=media&token=c491db51-73c0-429b-941d-026a3729232b',0),
('MAMON03','IDLMON01',N'Pepper Steak',N'Bò Úc Tiêu Đen',239000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPremiumSteak%2FPepperSteak.png?alt=media&token=155645ca-bcf2-49d5-b86f-4b8ea0d12337',0),
('MAMON04','IDLMON01',N'Hitokuchi Steak',N'Mông Bò Hitokuchi',369000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPremiumSteak%2FDicedCutSteak.png?alt=media&token=08b943a0-564f-462b-ab99-09ee8bc2392c',0),
('MAMON05','IDLMON01',N'Hamburger Eggs',N'Hamburger Với Trứng',169000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPremiumSteak%2FBeefHamburgwithEgg.png?alt=media&token=508999c4-9b23-4d86-97e3-a1d7a5d37a30',0),
--PRODUCT PEPPER RICE----2
('MAMON07','IDLMON02',N'Jumbo Beef Pepper Rice',N'Cơm Bò Mỹ Siêu Khủng',149000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPepperRice%2FjumboBeefPepperRice.png?alt=media&token=f73d67e8-14d0-430d-a41f-64da66c5cc56',0),
('MAMON08','IDLMON02',N'Beef Pepper Rice',N'Cơm Bò Mỹ Tiêu Đen',99000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPepperRice%2FbeefPepperRice.png?alt=media&token=2a35cd1c-8c2e-4737-a44a-9e5a263cfeec',0),
('MAMON09','IDLMON02',N'Chicken Pepper Rice',N'Cơm Gà Tiêu Đen',89000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPepperRice%2FchickenPepperRice.png?alt=media&token=307f1f3b-39f0-43e2-84e7-8b04aa394aaf',0),
('MAMON10','IDLMON02',N'Salmon Pepper Rice',N'Cơm Cá Hồi Tiêu Đen',139000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPepperRice%2FsalmonRice.png?alt=media&token=7a464331-463c-4eda-b66d-2d6125a2ad6c',0),
('MAMON12','IDLMON02',N'Broccoli & Mushroom Pepper Rice',N'Cơm Chay Tiêu Đen',89000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FPepperRice%2FbroccoliMushroonPepperRice.png?alt=media&token=f3e0ec3d-0362-4661-873d-183147993193',0),
--PRODUCT JAPANESE CLASSICS----3
('MAMON14','IDLMON03',N'Beef Sukiyaki',N'Bò Sốt Sukiyaki',169000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FJapaneseClassic%2FbeefSukiyaki.png?alt=media&token=053b70fd-c0a2-402c-8478-41065b9bf223',0),
('MAMON17','IDLMON03',N'Salmon Sukiyaki',N'Cá Hồi Sốt Sukiyaki',219000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FJapaneseClassic%2FsalmonSukiya.png?alt=media&token=454c183d-ac47-4d75-b6d7-b4db5543a1f4',0),
('MAMON18','IDLMON03',N'Teriyaki Chicken',N'Gà Sốt Teriyaki',149000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FJapaneseClassic%2FTeriyakiChickenwithEgg.png?alt=media&token=45954e65-6907-419d-ae24-72858767518a',0),
('MAMON19','IDLMON03',N'Teriyaki Salmon And Saba',N'Cá Hồi Và Cá Thu Nhật Sốt Teriyaki',209000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FJapaneseClassic%2FTeriyakiSalmonSaba.png?alt=media&token=702ad9d1-c941-4a4f-bcd6-0fe4cbd40a4e',0),
--PRODUCT TEPPAN PASTA----4
('MAMON20','IDLMON04',N'Beef Aglio Olio',N'Mì Ý Bò Sốt Aglio',139000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FTeppanPasta%2FbeefAglioOlio.png?alt=media&token=9ccbd752-f76e-44ca-8736-d9a8e52a60db',0),
('MAMON21','IDLMON04',N'Seafood Aglio Olio',N'Mì Ý Hải Sản Sốt Aglio',119000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FTeppanPasta%2FseafoodAglioOlio.png?alt=media&token=b44065a6-ada1-46db-92d4-a80bafb17017',0),
('MAMON22','IDLMON04',N'Chicken & Cheese Chicken Sausage Pasta',N'Mì Ý Gà Và Xúc Xích Phô Mai Gà',149000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FTeppanPasta%2FchickenCheeseSausageTomatoPasta.png?alt=media&token=71dd0211-25cc-4bff-839c-b6e3fdd58e04',0),
('MAMON23','IDLMON04',N'Seafood Creamy Cheese Pasta',N'Mì Ý Hải Sản Sốt Phô Mai Kem',139000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FTeppanPasta%2FsalmonPrawnCarbonara.png?alt=media&token=ee16f9ec-5eb7-4f53-a326-c0ec66a3450c',0),
--PRODUCT CHEESY ---5
('MAMON15','IDLMON05',N'Scallop & Prawn',N'VN_NAME',169000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FCheesySizzlingRice%2FscallopPrawnCheeseCurryRice.png?alt=media&token=e3d09352-39a6-4d29-8f2c-e5ae6f89d228',0),
('MAMON24','IDLMON05',N'Beef Hamburger & Beef',N'VN_NAME',199000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FCheesySizzlingRice%2FBeefHamburgCheesySizzlingRice.png?alt=media&token=60e2b730-60a1-4a34-8209-1c5104e132c8',0),
('MAMON25','IDLMON05',N'Scallop & Chicken',N'VN_NAME',169000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FCheesySizzlingRice%2FscallopChickenCheeseCurryRice.png?alt=media&token=ce5022d1-fe69-4912-8402-714e38a7afb3',0),
('MAMON26','IDLMON05',N'Broccoli & Mushroom',N'VN_NAME',169000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FCheesySizzlingRice%2FbroccoliMushroomCheeseCurryRice.png?alt=media&token=c19e133d-c8fa-49b8-9377-43850fe799f7',0),
--PRODUCT SPECIAL COMBO---6
('MAMON31','IDLMON06',N'Ultimate Meat Deluxe',N'VN_NAME',299000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FUltimateMeatDeluxe.png?alt=media&token=10c26291-c290-4f80-aa6d-7f626bc2495a',0),
('MAMON32','IDLMON06',N'Beef Trio Deluxe',N'VN_NAME',249000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FBeefTrioDeluxe.png?alt=media&token=666c86ad-4042-4273-ab9b-1ce184e3de9e',0),
('MAMON33','IDLMON06',N'Meat Trio Deluxe',N'VN_NAME',199000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FMeatTrioDeluxe.png?alt=media&token=895f7e38-c3cc-4c17-9fa7-3a6c6ad02a64',0),
('MAMON34','IDLMON06',N'Dice Cut Beef & Chicken',N'VN_NAME',199000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FDicedCutSteakChicken.png?alt=media&token=e0240c71-6e3a-48bc-b8fd-d255b7bfae1e',0),
('MAMON35','IDLMON06',N'Seafood Trio Deluxe',N'VN_NAME',179000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FSeafoodTrioDeluxe.png?alt=media&token=4d4d3432-f532-42f3-9c00-5059565ba4b2',0) ,
('MAMON37','IDLMON06',N'Salmon & Chicken',N'VN_NAME',189000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FSalmonChicken.png?alt=media&token=6e85cc56-91d4-453b-8b2d-9c42a086a395',0),
('MAMON38','IDLMON06',N'Saba & Chicken',N'VN_NAME',89000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/image%2FComboSpecial%2FSabaChicken.png?alt=media&token=da24ed9d-3f8b-47e1-83d5-01bbfddac2e1',0),
--PRODUCT SIDE DISHES---
('MAMON59','IDLMON07','Macaroni & Cheese ',N'Mì Ông Và Phô Mai',22000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fside%2Fmacaroni_chesse.png?alt=media&token=2683fb86-9e80-4357-a2fe-9bfd9ece351b',0),
('MAMON60','IDLMON07','Seasonal Dessert',N'Món Tráng Miệng Theo Mùa',28000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fside%2Fseasonal_dessert.png?alt=media&token=838c2f66-9268-47f2-8e11-bac2a4f62c22',0),
('MAMON61','IDLMON07','Mashed Potato',N'Khoai Tây Nghiền',28000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fside%2Fmashed_potatoes.png?alt=media&token=eda30e35-903c-49fb-82fd-17627e964ca5',0),
('MAMON62','IDLMON07','Seasonal Soup',N'Súp Theo Mùa',22000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fside%2Fseasonal_soup.png?alt=media&token=2a7d71e8-50e3-45c9-8d25-96d4029218de',0),
('MAMON63','IDLMON07','Miso Soup',N'Súp Miso Rong Biển',25000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fside%2Fmiso_soup.png?alt=media&token=cd5d2a54-af27-4043-b708-fc1e8b809768',0),
--PRODUCT ICE-CREAM---
('MAMON64','IDLMON08','Vanilla',N'Kem Vani',25000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fice_cream%2FkemVani.png?alt=media&token=ba941e61-6a1c-4bb4-98e6-dd7eaa963d3a',0),
('MAMON65','IDLMON08','Chocolate',N'Kem Sô Cô La',25000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fice_cream%2FkemSocola.png?alt=media&token=03fccb1f-2bbc-4b25-be1c-f95956b225e7',0),
('MAMON67','IDLMON08','Strawberries & Cream',N'Kem Dâu',25000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fice_cream%2FkemDau.png?alt=media&token=faf82b76-7deb-4b51-8ab2-08b6ef7b78e5',0),
--PRODUCT DRINKS---
('MAMON49','IDLMON09','Pepsi',N'Pepsi',20000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fdrink%2Fpepsi.png?alt=media&token=2e68e80b-01b7-410a-8a2f-51fb9fac9c2a',0),
('MAMON50','IDLMON09','Mirinda',N'Mirinda',20000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fdrink%2Fmirinda.png?alt=media&token=9757c1bb-6480-4b57-a328-1fb582486600',0),
('MAMON51','IDLMON09','7 Up',N'7 Up',20000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fdrink%2F7up.png?alt=media&token=b2fc721f-bf6d-4fe7-a2a7-b862039ad942',0),
('MAMON52','IDLMON09','Aquafina',N'Nước Suối',20000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fdrink%2Faquafina.png?alt=media&token=de73165a-ce47-4d81-b272-2f0e6571e621',0),
('MAMON53','IDLMON09','Nestle Milo',N'Sữa Milo',20000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fdrink%2FMilo.png?alt=media&token=e676dcc1-dd4d-428c-a1f8-833ad7d259fe',0),
('MAMON54','IDLMON09','Hot Green Tea',N'Trà Xanh Nóng',20000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fdrink%2Fhotgreentea.png?alt=media&token=9f9ccf09-d010-4f8f-b775-8561c4d33919',0),
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
('MAMONCB01','IDLMON11','SET A',N'Combo A',30000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fcombo%2Fimg_menu_15.jpg?alt=media&token=fa1aa5ba-6e3b-42ad-ade5-6c5c27ca02d8',0),
('MAMONCB02','IDLMON11','SET B',N'Combo B',40000,'https://firebasestorage.googleapis.com/v0/b/dbpepperlunch.appspot.com/o/sideDish%2Fcombo%2Fimg_menu_16.jpg?alt=media&token=74e01dc4-891b-49c9-960e-e58fc0021ef2',0)
-- SUPPLIER 
INSERT INTO SUPPLIER
VALUES
('NCC01', N'Công Ty TNHH MTV Thực Phẩm Tấn Tài', '0989078678', N'904/35-904/35A, Nguyễn Duy, Phường 12, Quận 8,Tp.Hồ Chí Minh', 0),
('NCC02', N'Công Ty TNHH Thương Mại Dịch Vụ Thiên Linh Thanh', '0989675456', N'KP.Tân Hạnh, P.Phú Mỹ, TX.Phú Mỹ,Bà Rịa-Vũng Tàu', 0),
('NCC03', N'Công Ty TNHH SX TMDV Thực Phẩm Xanh Đồng Nai', '0789675678', N'Số 2778A, QL.1A, Ấp Tam Hiệp, X.Xuân Hiệp, H.Xuân Lộc,Đồng Nai', 0),
('NCC04', N'Công Ty CP Zin Food Việt Nam', '0956756789', N'TT10-39, KĐT Mới Văn Phú, P. Phú La, Q.Hà Đông,Hà Nội', 0),
('NCC05', N'Công Ty TNHH San Hà', '0978345234', N'Công Ty TNHH San Hà Số 951 Tạ Quang Bửu, P.6, Q.8,Tp.Hồ Chí Minh', 0)

--INGREDIENT
INSERT INTO INGREDIENT
VALUES
('NL0001','NCC04',N'Thịt bò Úc',1000,0),
('NL0002','NCC04',N'Thịt bò Mỹ',1000,0),
('NL0004','NCC04',N'Mông Bò Mỹ',1000,0),
('NL0005','NCC03',N'Thịt Gà Miếng',1000,0),
('NL0007','NCC02',N'Cá Hồi',1000,0),
('NL0008','NCC02',N'Cá Saba',1000,0),
('NL0009','NCC04',N'Hamburger',1000,0),
('NL0010','NCC04',N'Sườn Bò Mỹ',1000,0),
('NL0011','NCC02',N'Tôm',1000,0),
('NL0012','NCC04',N'Sausage',1000,0),
('NL0016','NCC03',N'Trứng',1000,0),
('NL0023','NCC02',N'Gạo',1000,0),
('NL0024','NCC02',N'Bột Kem',1000,0),
('NL0025','NCC03',N'Nước Ngọt',1000,0),
('NL0026','NCC01',N'BỘT KHOAI NGHIỀN',1000,0),
('NL0027','NCC01',N'Phô Mai',1000,0),
('NL0028','NCC01',N'Mì',1000,0),
('NL0029','NCC02',N'Sốt Cà Chua',1000,0),
('NL0031','NCC02',N'Sốt kem',1000,0),
('NL0032','NCC02',N'Sốt Cà ri',1000,0),
('NL0033','NCC01',N'Cải Xanh',1000,0),
('NL0034','NCC01',N'Miso Paste',1000,0),
('NL0035','NCC01',N'Vani',1000,0),
('NL0036','NCC01',N'Chocolate',1000,0),
('NL0037','NCC02',N'Strawberries',1000,0),
('NL0038','NCC02',N'Pepsi',1000,0),
('NL0039','NCC02',N'Mirinda',1000,0),
('NL0040','NCC01',N'7 Up',1000,0),
('NL0041','NCC01',N'Nước Suối',1000,0),
('NL0042','NCC01',N'Trà Xanh Nóng',1000,0),
('NL0043','NCC01',N'Nấm Sò vua',1000,0),
('NL0044','NCC02',N'Đậu Nhật',1000,0),
('NL0045','NCC02',N'Bắp Cải',1000,0),
('NL0046','NCC02',N'Sò',1000,0),
('NL0047','NCC02',N'Bắp Ngọt',1000,0),
('NL0048','NCC02',N'Đậu Bắp',1000,0)



-- DETAIL PRODUCT
INSERT INTO DETAIL_PRODUCT
(ID_DETAIL,ID_PRODUCT,ID_INGREDIENT,WEIGHT_DETAIL,FLAG_DEL)
VALUES
--The Giant
('ID001','MAMON01','NL0002',230,0),
('ID002','MAMON01','NL0023',210,0),
--Ribeye Steak
('ID006','MAMON02','NL0002',230,0),
('ID010','MAMON02','NL0023',210,0),
--Pepper Steak
('ID011','MAMON03','NL0001',130,0),
('ID015','MAMON03','NL0023',210,0),
--Hitokuchi Steak
('ID016','MAMON04','NL0004',200,0),
('ID021','MAMON04','NL0023',210,0),
--Hamburger Eggs
('ID022','MAMON05','NL0009',140,0),
('ID026','MAMON05','NL0023',210,0),
--Jumbo Beef Pepper Rice
('ID034','MAMON07','NL0002',160,0),
('ID037','MAMON07','NL0023',210,0),
--Beef Pepper Rice
('ID038','MAMON08','NL0002',80,0),
('ID041','MAMON08','NL0023',190,0),
--Chicken Pepper Rice
('ID042','MAMON09','NL0005',90,0),
('ID045','MAMON09','NL0023',190,0),
--Salmon Pepper Rice
('ID046','MAMON10','NL0007',80,0),
('ID049','MAMON10','NL0023',190,0),
--Broccoli & Mushroom Pepper Rice
('ID050','MAMON12','NL0033',80,0),
('ID053','MAMON12','NL0023',210,0),
--Beef Sukiyaki
('ID054','MAMON14','NL0002',90,0),
('ID057','MAMON14','NL0023',190,0),
--Salmon Sukiyaki
('ID058','MAMON17','NL0007',20,0),
('ID064','MAMON17','NL0023',190,0),
--Teriyaki Chicken
('ID065','MAMON18','NL0005',110,0),
('ID071','MAMON18','NL0023',210,0),
--Teriyaki Salmon And Saba
('ID072','MAMON19','NL0005',200,0),
('ID073','MAMON19','NL0008',200,0),
('ID076','MAMON19','NL0023',210,0),
--Beef Aglio Olio
('ID077','MAMON20','NL0002',80,0),
('ID078','MAMON20','NL0028',210,0),
--Seafood Aglio Olio
('ID083','MAMON21','NL0011',140,0),
('ID084','MAMON21','NL0028',210,0),
--Chicken & Cheese Chicken Sausage Pasta
('ID089','MAMON22','NL0012',100,0),
('ID090','MAMON22','NL0005',70,0),
('ID091','MAMON22','NL0028',210,0),
--Seafood Creamy Cheese Pasta
('ID099','MAMON23','NL0007',5,0),
('ID100','MAMON23','NL0011',10,0),
('ID101','MAMON23','NL0031',10,0),
('ID102','MAMON23','NL0028',210,0),
--Scallop & Prawn
('ID103','MAMON15','NL0011',200,0),
('ID104','MAMON15','NL0032',80,0),
('ID105','MAMON15','NL0023',210,0),
--Beef Hamburger & Beef
('ID106','MAMON24','NL0002',200,0),
('ID107','MAMON24','NL0032',200,0),
('ID108','MAMON24','NL0009',200,0),
('ID109','MAMON24','NL0023',210,0),
--Scallop & Chicken
('ID200','MAMON25','NL0005',20,0),
('ID208','MAMON25','NL0032',80,0),
('ID209','MAMON25','NL0023',210,0),
--Broccoli & Mushroom
('ID111','MAMON26','NL0032',200,0),
('ID112','MAMON26','NL0033',60,0),
('ID113','MAMON26','NL0016',30,0),
('ID114','MAMON26','NL0023',140,0),
---Ultimate Meat Deluxe
('ID115','MAMON31','NL0023',190,0),
('ID116','MAMON31','NL0027',20,0),
('ID117','MAMON31','NL0009',140,0),
('ID118','MAMON31','NL0016',2,0),
--Beef Trio Deluxe
('ID119','MAMON32','NL0002',80,0),
('ID120','MAMON32','NL0023',190,0),
('ID121','MAMON32','NL0027',20,0),
('ID122','MAMON32','NL0016',2,0),
--Meat Trio Deluxe
('ID123','MAMON33','NL0005',100,0),
('ID124','MAMON33','NL0023',190,0),
('ID125','MAMON33','NL0027',20,0),
('ID126','MAMON33','NL0016',2,0),
--Dice Cut Beef & Chicken
('ID127','MAMON34','NL0023',190,0),
('ID130','MAMON34','NL0007',90,0),
-- Seafood Trio Deluxe
('ID131','MAMON35','NL0023',190,0),
('ID133','MAMON35','NL0009',140,0),
('ID134','MAMON35','NL0032',90,0),
--Salmon & Chicken
('ID135','MAMON37','NL0023',190,0),
('ID137','MAMON37','NL0002',80,0),
('ID138','MAMON37','NL0009',70,0),
('ID139','MAMON37','NL0032',90,0),
--Saba & Chicken
('ID140','MAMON38','NL0023',190,0),
('ID142','MAMON38','NL0011',30,0),
('ID144','MAMON38','NL0032',90,0),

--Macaroni & Cheese
('ID145','MAMON59','NL0002',75,0),
('ID146','MAMON59','NL0012',70,0),
('ID152','MAMON59','NL0023',210,0),

--Seasonal Dessert
('ID155','MAMON60','NL0002',75,0),
('ID156','MAMON60','NL0004',75,0),
('ID157','MAMON60','NL0009',70,0),
('ID158','MAMON60','NL0023',210,0),
--Mashed Potato
('ID159','MAMON61','NL0026',5,0),

--Seasonal Soup
('ID165','MAMON62','NL0034',75,0),
--Seasonal Soup
('ID166','MAMON63','NL0034',75,0),
--Vanilla
('ID171','MAMON64','NL0024',75,0),
--Chocolate
('ID172','MAMON65','NL0024',75,0),
--Strawberries & Cream
('ID173','MAMON67','NL0024',75,0),
--Pepsi
('ID174','MAMON49','NL0025',75,0),
--Mirinda
('ID175','MAMON50','NL0025',75,0),
--7 Up
('ID176','MAMON51','NL0025',75,0),
--Aquafina
('ID177','MAMON52','NL0025',75,0),
--Nestle Milo
('ID178','MAMON53','NL0025',75,0),
--Hot Green Tea
('ID179','MAMON54','NL0025',75,0),
--King Oyster Mushroom
('ID183','MAMON39','NL0043',75,0),
--Edamame
('ID184','MAMON40','NL0044',70,0),
--Cabbage
('ID185','MAMON41','NL0045',5,0),
--Broccoli
('ID186','MAMON42','NL0033',20,0),
--Sweet Corn
('ID187','MAMON43','NL0047',20,0),
--Okra
('ID188','MAMON44','NL0048',210,0),

--Egg
('ID189','MAMON45','NL0016',190,0),
--Beef
('ID190','MAMON46','NL0002',5,0),
--Chicken
('ID191','MAMONBPS1','NL0005',5,0),
--Cheese Chicken Sausage
('ID192','MAMONBPS2','NL0012',5,0),
--Salmon
('ID193','MAMONBJC1','NL0007',40,0),
--Scallops
('ID194','MAMONBJC2','NL0046',40,0),
--Prawns
('ID195','MAMON47','NL0011',5,0),
--SET A
('ID196','MAMONCB01','NL0024',500,0),
('ID197','MAMONCB01','NL0025',500,0),
--SET B
('ID198','MAMONCB02','NL0024',500,0),
('ID199','MAMONCB02','NL0025',500,0)


--GROUP USER
INSERT INTO GROUP_USER
VALUES
('AD1','ADMIN',0),
('USER1','USER',0)

-- STAFF
INSERT INTO STAFF
(USERNAME_STAFF,PASSWORD_STAFF ,ID_GROUP,SURNAME_STAFF,NAME_STAFF,GENDER_STAFF ,
DATE_OF_BIRTH ,ADDRESS_STAFF ,NUMBER_PHONE ,FLAG_DEL)
VALUES
('NV01','123','USER1',N'Ngô Tích',N'Vinh',1,'09-09-2001',N'39/7 Trần Quang Khải , Quận 1 HCM','0977263652',0),
('NV02','123','USER1',N'Nguyễn Thị Thanh ',N'Hoa',0,'09-09-2001',N'48 Bùi Thị Xuân , Quận Tân Bình HCM','0963071488',0),
('NV03','123','USER1',N'Nguyễn Ngọc Thảo',N' Quyên',1,'09-09-2001',N'39 Trương Thị Ngào , Quận 12 HCM','0983300149',0),
('NV04','123','USER1',N'Vũ Ngọc',N' Anh',1,'09-09-2001',N'12 Lê Lợi , Quận 1 HCM','0932634971',0),
('NV05','123','USER1',N'Phạm Thị Thúy',N' Vi',1,'09-09-2001',N'140 Lê Trọng Tấn , Quận Tân Phú HCM','0346312770',0),
('NV06','123','USER1',N'Nguyễn Thị',N' Thư',1,'09-09-2001',N'167 Quang Trung , Quận Gò Vấp HCM','0348242789',0),
('NV07','123','USER1',N'Nguyễn Thị Lệ ',N'Quỳnh',1,'09-09-2001',N'42 Tây Thạnh , Quận Tân Phú HCM','0327916792',0),
('NV08','123','USER1',N'Võ Thị Tuyết',N' Nhung',1,'09-09-2001',N'52/11 Dương Đức Hiền , Quận Tân Phú HCM','0934263967',0),
('NV09','123','USER1',N'Lê Thị Tú',N' Hảo',1,'09-09-2001',N'10 Trần Quang Khải , Quận 1 HCM','0354499599',0),
('NV10','123','USER1',N'Phùng Kim',N' Yến',1,'09-09-2001',N'41 Nguyễn Ảnh Thủ , Quận 12 HCM','0909215728',0),
('NV11','123','USER1',N'Trần Ngọc',N' Hiểu',1,'09-09-2001',N'12 Độc Lập , Quận Tân Phú HCM','0938202193',0),
('NV12','123','USER1',N'Biện Hoàng',N' Vinh',1,'09-09-2001',N'09 Trần Hưng Đạo , Quận 3 HCM','0902353183',0),
('NV13','123','USER1',N'Lâm Gia',N' Huy',1,'09-09-2001',N'11 Ngô Quyền , Quận 2 HCM','0522944609',0),
('NV14','123','USER1',N'Phạm Minh',N' Toàn',1,'09-09-2001',N'12 Nguyễn Trãi , Quận 8 HCM','0901395705',0),
('NV15','123','USER1',N'Nguyễn Thị Thanh',N'Tuyền',1,'09-09-2001',N'09 Trần Vinh , Quận 6 HCM','0367531861',0),
('NV16','123','USER1',N'Đoàn Thị',N'Khánh',1,'09-09-2001',N'73 Trần Vinh , Quận 6 HCM','0367531861',0)

--METHOD_PAY
INSERT INTO METHOD_PAY 
VALUES
('METHOD01','NV01','20-5-2022', 'CASH', N'Thanh Toán Tiền Mặt',  0),
('METHOD02','NV01', '20-5-2022', 'ATM', N'Thanh Toán Thẻ Ngân Hàng', 0),
('METHOD03','NV01', '20-5-2022', 'INTERNET BANKING', N'Thanh Toán Ví Điện Tử', 0)

--PROMOTION
INSERT INTO PROMOTION
VALUES
('PROMOTION1','TEN PROMOTION','NV01','21-05-2022', '21-06-2022', '22-07-2022',0)
--TYPE CUSTOMER
INSERT INTO CUSTOMER_TYPE
VALUES
('TYPECUS01',N'Khách hàng thân quen Đồng',0,10,100,0.2,0),
('TYPECUS02',N'Khách hàng thân quen Bạc',1,10,100,0.2,0),
('TYPECUS03',N'Khách hàng thân quen Vàng',2,10,100,0.2,0)


--VOUCHER
--INSERT INTO VOUCHER
--VALUES
--('VOUCHER010','NV01', 'PROMOTION1', '21-05-2022', '21-06-2022', '22-07-2022', 'percent','TYPECUS01','15', 50000, 10, 0)




Insert into NEWS
VALUES
('SK01','PROMOTION1','NV01', N'Khuyến mãi', N'Khi mua một dĩa rau trộn được tặng súp và kem', '20-06-2022', '22-07-2022',0)

--IMAGE_NEWS
Insert into IMAGE_NEWS
values
('IM01', 'SK01','HTTPS/URL')
-- CREATE VIEWS HERE

INSERT INTO CUSTOMER
VALUES
('KH01','HUNG','LY',1,'5-1-2022',NULL,'0901395705','phmtoan2005@gmail.com','123','HCM','20-5-2001',0,'TYPECUS01')



--RECEIPT
INSERT INTO RECEIPT
VALUES
('ID001','VOUCHER010','KH01','METHOD01','1-6-2022',2,235000,20,0,'')
--DETAIL_RECEIPT
INSERT INTO DETAIL_RECEIPT
VALUES
('CTHD01','ID001','MAMON01',1,100000),
('CTHD02','ID001','MAMON02',1,135000)
--IMPORT
INSERT INTO IMPORT
VALUES
('IOG01','NCC01','NV01','21-5-2022',500000,'TEST',0)
--DETAIL_IMPORT
INSERT INTO DETAIL_IMPORT
VALUES
('DETAILIOG01','IOG01','NL0001',500000,1)

go
CREATE VIEW RECEIPT_FULL AS
SELECT RC.*,VC.PERCENT_REDUCTION,VC.AMOUNT_REDUCTION ,CUS.ADDRESS_CUSTOMER,CUS.MAIL_CUSTOMER,CUS.NAME_CUSTOMER,CUS.SURNAME_CUSTOMER,CUS.PHONE_CUSTOMER,
MT.NAME_METHOD,MT.TYPE_METHOD
FROM RECEIPT AS RC, VOUCHER AS VC,CUSTOMER AS CUS ,METHOD_PAY AS MT
WHERE RC.ID_VOUCHER = VC.ID_VOUCHER
AND RC.ID_CUSTOMER=CUS.ID_CUSTOMER
AND RC.ID_METHOD = MT.ID_METHOD


go
CREATE VIEW RECIPE_JOIN AS
SELECT R.*,P.NAME_PRODUCT_EN,I.NAME_INGREDIENT
FROM DETAIL_PRODUCT AS R , INGREDIENT AS I , PRODUCT AS P
WHERE R.ID_PRODUCT=P.ID_PRODUCT AND R.ID_INGREDIENT=I.ID_INGREDIENT


