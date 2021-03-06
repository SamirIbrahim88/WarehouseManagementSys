USE [master]
GO
/****** Object:  Database [PRODUCT_DB]    Script Date: 03/25/2017 19:32:11 ******/
CREATE DATABASE [PRODUCT_DB] ON  PRIMARY 
( NAME = N'PRODUCT_DB', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\PRODUCT_DB.mdf' , SIZE = 18432KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PRODUCT_DB_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\PRODUCT_DB_log.ldf' , SIZE = 9216KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PRODUCT_DB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRODUCT_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRODUCT_DB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PRODUCT_DB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PRODUCT_DB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PRODUCT_DB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PRODUCT_DB] SET ARITHABORT OFF
GO
ALTER DATABASE [PRODUCT_DB] SET AUTO_CLOSE ON
GO
ALTER DATABASE [PRODUCT_DB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PRODUCT_DB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PRODUCT_DB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PRODUCT_DB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PRODUCT_DB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PRODUCT_DB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PRODUCT_DB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PRODUCT_DB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PRODUCT_DB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PRODUCT_DB] SET  DISABLE_BROKER
GO
ALTER DATABASE [PRODUCT_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PRODUCT_DB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PRODUCT_DB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PRODUCT_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PRODUCT_DB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PRODUCT_DB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PRODUCT_DB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PRODUCT_DB] SET  READ_WRITE
GO
ALTER DATABASE [PRODUCT_DB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [PRODUCT_DB] SET  MULTI_USER
GO
ALTER DATABASE [PRODUCT_DB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PRODUCT_DB] SET DB_CHAINING OFF
GO
USE [PRODUCT_DB]
GO
/****** Object:  Table [dbo].[TRADER]    Script Date: 03/25/2017 19:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRADER](
	[ID_TRADER] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [varchar](25) NULL,
	[LAST_NAME] [varchar](25) NULL,
	[TEL] [nchar](15) NULL,
	[EMAIL] [varchar](25) NULL,
	[IMAGE_TRADER] [image] NULL,
 CONSTRAINT [PK_TRADER] PRIMARY KEY CLUSTERED 
(
	[ID_TRADER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[SupCust_TypeFromID]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[SupCust_TypeFromID]
(
	-- Add the parameters for the function here
	@ID int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = SupCust_Type from dbo.SupCust where id=@id

	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[SupCust_NameFromID]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[SupCust_NameFromID]
(
	-- Add the parameters for the function here
	@ID int
)
RETURNS varchar(100)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result varchar(100)

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result =SupCust_Name from dbo.SupCust where ID=@ID

	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  Table [dbo].[SHOP]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHOP](
	[ID_SHOP] [int] NOT NULL,
	[DATE_ORDER] [datetime] NOT NULL,
	[TRADER_ID] [int] NOT NULL,
	[DESCRIPTION_ORDER] [varchar](250) NOT NULL,
	[PAYMAN] [varchar](75) NOT NULL,
 CONSTRAINT [PK_SHOP] PRIMARY KEY CLUSTERED 
(
	[ID_SHOP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[ID_CUSTOMER] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [varchar](25) NULL,
	[LAST_NAME] [varchar](25) NULL,
	[TEL] [varchar](50) NULL,
	[EMAIL] [varchar](25) NULL,
	[IMAGE_CUSTOMER] [image] NULL,
 CONSTRAINT [PK_CUSTOMERS] PRIMARY KEY CLUSTERED 
(
	[ID_CUSTOMER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CATEGORIES]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIES](
	[ID_CAT] [int] NOT NULL,
	[DESCRIPTION_CAT] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED 
(
	[ID_CAT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [varchar](50) NOT NULL,
	[PWD] [varchar](50) NULL,
	[USERTYPE] [varchar](50) NULL,
	[FULLNAME] [varchar](50) NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[IsSupCustDisabled]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[IsSupCustDisabled]
(
	-- Add the parameters for the function here
	@supcust_id int
)
RETURNS int
AS
BEGIN
if exists (select * from dbo.supcust where id =@supcust_id and SupCust_IsDisabled=0)
return 0
else
return 1

return 0

END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalOfBill]    Script Date: 03/25/2017 19:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[GetTotalOfBill]
(
	-- Add the parameters for the function here
	@ID int
)
RETURNS decimal(18,2)
AS
BEGIN
DECLARE @BILL_TOTAL  DECIMAL(18,2)


--SELECT @dISC_TYPE=dISCTYPE , @ADDITIONS=additions, @DISCOUNTS=DISCOUNTS from dbo.Invoice_master WHERE ID=@ID

SELECT @BILL_TOTAL=SUM(QUANTITY * UNITPRICE) from dbo.invoice_details WHERE INVOICE_ID=@ID

IF (@BILL_TOTAL IS NULL) SET @BILL_TOTAL=0


RETURN @BILL_TOTAL
END
GO
/****** Object:  StoredProcedure [dbo].[GET_SIGNLE_CATEGORIES]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_SIGNLE_CATEGORIES]
@ID VARCHAR (50)
AS
SELECT ID_CAT,DESCRIPTION_CAT
FROM CATEGORIES
WHERE ID_CAT=@ID
GO
/****** Object:  StoredProcedure [dbo].[VERIFYUSERTID]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VERIFYUSERTID]
@ID varchar(50)
as
select * from USERS where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_TRADER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_TRADER]
@FIRST_NAME varchar(25),
@LAST_NAME varchar(25),
@TEL nchar(15),
@EMAIL varchar(25),
@IMG image,
@criterion varchar(50),
@ID INT
as
UPDATE [PRODUCT_DB].[dbo].[TRADER]
   SET [FIRST_NAME] =@FIRST_NAME
      ,[LAST_NAME] =@LAST_NAME
      ,[TEL] = @TEL
      ,[EMAIL] =@EMAIL
      ,[IMAGE_TRADER] = @IMG
 WHERE ID_TRADER=@ID
GO
/****** Object:  StoredProcedure [dbo].[ADD_USER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_USER]
@ID VARCHAR(50)
,@FULLNAME VARCHAR(50),
@PWD VARCHAR(50),
@USERTYPE VARCHAR(50)
AS
INSERT INTO [PRODUCT_DB].[dbo].[USERS]
           ([ID]
           ,[PWD]
           ,[USERTYPE]
           ,[FULLNAME])
     VALUES
           (@ID
           ,@PWD
           ,@USERTYPE
           ,@FULLNAME)
GO
/****** Object:  StoredProcedure [dbo].[ADD_TRADER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_TRADER]
@FIRST_NAME varchar(25),
@LAST_NAME varchar(25),
@TEL nchar(15),
@EMAIL varchar(25),
@IMG image,
@criterion varchar(50)
AS
if @criterion='withimage'
begin
INSERT INTO [PRODUCT_DB].[dbo].[TRADER]
           ([FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL]
           ,[EMAIL]
           ,[IMAGE_TRADER])
     VALUES
           (@FIRST_NAME
           ,@LAST_NAME
           ,@TEL
           ,@EMAIL
           ,@IMG)
           end
if @criterion='withoutimage'
begin
INSERT INTO [PRODUCT_DB].[dbo].[TRADER]
           (
           [FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL]
           ,[EMAIL])
     VALUES
          (
           @FIRST_NAME
           ,@LAST_NAME
           ,@TEL
           ,@EMAIL)
end
GO
/****** Object:  StoredProcedure [dbo].[ADD_SHOP]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_SHOP]
@ID_SHOP int,
@DATE_ORDER datetime,
@TRADER_ID int,
@DESCRIPTION_ORDER varchar(250),
@PAYMAN  varchar(75)
as
INSERT INTO [PRODUCT_DB].[dbo].[SHOP]
           ([ID_SHOP]
           ,[DATE_ORDER]
           ,[TRADER_ID]
           ,[DESCRIPTION_ORDER]
           ,PAYMAN )
     VALUES
           (@ID_SHOP
           ,@DATE_ORDER
           ,@TRADER_ID
           ,@DESCRIPTION_ORDER
           ,@PAYMAN )
GO
/****** Object:  StoredProcedure [dbo].[add_customer]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[add_customer]
@FIRST_NAME varchar(25),
@LAST_NAME varchar(25),
@TEL nchar(15),
@EMAIL varchar(25),
@IMG image,
@criterion varchar(50)
AS
if @criterion='withimage'
begin
INSERT INTO [PRODUCT_DB].[dbo].[CUSTOMERS]
           ([FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL]
           ,[EMAIL]
           ,[IMAGE_CUSTOMER])
     VALUES
           (@FIRST_NAME
           ,@LAST_NAME
           ,@TEL
           ,@EMAIL
           ,@IMG)
end
if @criterion='withoutimage'
begin
INSERT INTO [PRODUCT_DB].[dbo].[CUSTOMERS]
           ([FIRST_NAME]
           ,[LAST_NAME]
           ,[TEL]
           ,[EMAIL])
     VALUES
           (@FIRST_NAME
           ,@LAST_NAME
           ,@TEL
           ,@EMAIL)
end
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_CUSTOMER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ALL_CUSTOMER]
AS
SELECT [ID_CUSTOMER]
      ,[FIRST_NAME] AS'اسم العميل'
      ,[LAST_NAME] AS' التصنيف'
      ,[TEL] AS'رقم الهاتف'
      ,[EMAIL] AS' العنوان'
      ,[IMAGE_CUSTOMER]
  FROM [CUSTOMERS]
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_CATEGORIES]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_ALL_CATEGORIES]
as
select * from CATEGORIES
GO
/****** Object:  StoredProcedure [dbo].[EDITUSER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EDITUSER]
@ID VARCHAR(50)
,@FULLNAME VARCHAR(50),
@PWD VARCHAR(50),
@USERTYPE VARCHAR(50)
AS
UPDATE [USERS]
   SET [ID] = @ID
      ,[PWD] = @PWD
      ,[USERTYPE] = @USERTYPE
      ,[FULLNAME] = @FULLNAME
 WHERE ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[EDIT_CUSTOMER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EDIT_CUSTOMER]
@FIRST_NAME varchar(25),
@LAST_NAME varchar(25),
@TEL nchar(15),
@EMAIL varchar(25),
@IMG image,
@criterion varchar(50),
@ID INT
AS
if @criterion='withimage'
begin
UPDATE [PRODUCT_DB].[dbo].[CUSTOMERS]
   SET [FIRST_NAME] = @FIRST_NAME
      ,[LAST_NAME] = @LAST_NAME
      ,[TEL] =@TEL
      ,[EMAIL] =@EMAIL
      ,[IMAGE_CUSTOMER] = @IMG
 WHERE ID_CUSTOMER=@ID
 end
if @criterion='withoutimage'
begin
UPDATE [PRODUCT_DB].[dbo].[CUSTOMERS]
   SET [FIRST_NAME] = @FIRST_NAME
      ,[LAST_NAME] = @LAST_NAME
      ,[TEL] =@TEL
      ,[EMAIL] =@EMAIL
 WHERE ID_CUSTOMER=@ID
 end
GO
/****** Object:  StoredProcedure [dbo].[DELETEUSER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DELETEUSER]
@ID VARCHAR(50)
AS
delete from USERS
 WHERE ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[DELETE_TRADERS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_TRADERS]
@ID INT
AS
DELETE FROM TRADER
WHERE ID_TRADER=@ID
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CUSTOMER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DELETE_CUSTOMER]
@ID INT
AS
DELETE FROM CUSTOMERS
WHERE ID_CUSTOMER=@ID
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_TRADERS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ALL_TRADERS]
as
SELECT [ID_TRADER]
      ,[FIRST_NAME]AS'الاسم '
      ,[LAST_NAME]AS'اسم الشركه'
      ,[TEL]AS'رقم الهاتف'
      ,[EMAIL]AS'العنوان'
            ,[IMAGE_TRADER]
  FROM [PRODUCT_DB].[dbo].[TRADER]
GO
/****** Object:  StoredProcedure [dbo].[GET_LAST_SHOP_ID]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_LAST_SHOP_ID]
as
select ISNULL(MAX(ID_SHOP)+1,1)
from SHOP
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_TRADERS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SEARCH_TRADERS]
@CRITERION varchar(50)
as
SELECT ID_TRADER
      ,[FIRST_NAME]AS'الاسم '
      ,[LAST_NAME]AS'اسم الشركه'
      ,[TEL]AS'رقم الهاتف'
      ,[EMAIL]AS'العنوان'
  FROM TRADER
  where [FIRST_NAME] +[LAST_NAME] +[TEL] +[EMAIL] like +'%'+@CRITERION +'%'
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SEARCH_CUSTOMER]
@CRITERION varchar(50)
as
SELECT [ID_CUSTOMER]
      ,[FIRST_NAME] as'الاسم الشخصي'
      ,[LAST_NAME]as'اسم العائله'
      ,[TEL]as'رقم الهاتف'
      ,[EMAIL]as'العنوان'
  FROM [CUSTOMERS]
  where [FIRST_NAME] +[LAST_NAME] +[TEL] +[EMAIL] like +'%'+@CRITERION +'%'
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[ID_PRODUCT] [nvarchar](50) NOT NULL,
	[LABEL_PRODUCT] [nvarchar](50) NULL,
	[QTE_IN_STOCK] [int] NULL,
	[PRICE] [nvarchar](50) NULL,
	[ID_CAT] [int] NULL,
	[IMAGE_PRODUCT] [image] NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORDERS](
	[ID_ORDER] [int] NOT NULL,
	[DATE_ORDER] [datetime] NULL,
	[CUSTOMER_ID] [int] NULL,
	[DESCRIPTION_ORDER] [varchar](250) NULL,
	[SALESMAN] [varchar](75) NULL,
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[ID_ORDER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SEARCHUSER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SEARCHUSER]
@CRITERION VARCHAR(50)
as
SELECT [ID]as'اسم المستخدم'
      ,[PWD]as'كلمه السر'
      ,[USERTYPE]as'نوع المستخدم'
      ,[FULLNAME]as'الاسم كاملا'
  FROM [PRODUCT_DB].[dbo].[USERS]
  where ID+FULLNAME+PWD+USERTYPE like '%' + @CRITERION +'%'
GO
/****** Object:  StoredProcedure [dbo].[SEARCHSHOP]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SEARCHSHOP]
@criterion varchar(50)
as
SELECT [ID_SHOP]as'رقم الفاتوره'
      ,[DATE_ORDER]as'تاريخ الفاتوره'
      ,FIRST_NAME+''+LAST_NAME as 'اسم المورد'
      ,[DESCRIPTION_ORDER]as'وصف الفاتوره'
      ,[PAYMAN]as'اسم المشتري'
  FROM [PRODUCT_DB].[dbo].[SHOP]
    inner join TRADER
    ON TRADER.ID_TRADER=SHOP.ID_SHOP
     where CONVERT(varchar,(ID_SHOP))+CONVERT(varchar,(DATE_ORDER))+FIRST_NAME+LAST_NAME+DESCRIPTION_ORDER+PAYMAN like '%' + @criterion + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_login]
@ID varchar(50),@PWD varchar(50)
AS
SELECT * FROM USERS
WHERE ID=@ID AND PWD=@PWD
GO
/****** Object:  Table [dbo].[SHOP_DETAILS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHOP_DETAILS](
	[ID_PRODUCT] [nvarchar](50) NULL,
	[ID_shop] [int] NULL,
	[QTE] [int] NULL,
	[PRICE] [varchar](50) NULL,
	[AMOUNT] [varchar](50) NULL,
	[TOTAL_AMOUNT] [varchar](50) NULL,
	[DISCOUNT] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SEARCHPRODUCT]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SEARCHPRODUCT]
@ID varchar(50)
as
SELECT
      DESCRIPTION_CAT as"الصنف",
      [ID_PRODUCT] as"وصف المنتج"
      ,[LABEL_PRODUCT]as"اسم المنتج"
      ,[QTE_IN_STOCK]as"كميه المنتج"
      ,[PRICE]as"سعر المنتج"
  FROM [PRODUCTS]
  inner join CATEGORIES
  on CATEGORIES.ID_CAT=PRODUCTS.ID_CAT
where
[ID_PRODUCT]+
[LABEL_PRODUCT]+
CONVERT(varchar,[QTE_IN_STOCK])+
[PRICE]+DESCRIPTION_CAT like +'%'+@ID+'%'
GO
/****** Object:  StoredProcedure [dbo].[SEARCHORDERS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SEARCHORDERS]
@criterion varchar(50)
as
SELECT [ID_ORDER]as'رقم الفاتوره'
      ,[DATE_ORDER]as'تاريخ الفاتوره'
      ,[FIRST_NAME]as'اسم العميل'
      ,LAST_NAME as'التصنيف '
      ,[DESCRIPTION_ORDER]as'وصف الفاتوره'
      ,[SALESMAN]as'اسم البائع'
  FROM [ORDERS]
  inner join CUSTOMERS
  on CUSTOMERS.ID_CUSTOMER=ORDERS.CUSTOMER_ID
  where CONVERT(varchar,(ID_ORDER))+CONVERT(varchar,(DATE_ORDER))+FIRST_NAME+LAST_NAME+DESCRIPTION_ORDER+SALESMAN like +'%'+@criterion+'%'
GO
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL](
	[ID_PRODUCT] [nvarchar](50) NULL,
	[ID_ORDER] [int] NULL,
	[QTE] [int] NULL,
	[PRICE] [varchar](50) NULL,
	[DISCOUNT] [float] NULL,
	[AMOUNT] [varchar](50) NULL,
	[TOTAL_AMOUNT] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[GET_LAST_ORDER_ID]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_LAST_ORDER_ID]
as
select ISNULL(MAX(ID_ORDER)+1,1)
from ORDERS
GO
/****** Object:  StoredProcedure [dbo].[GET_LAST_ORDER_FOR_PRINT]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_LAST_ORDER_FOR_PRINT]
as
select MAX(ID_ORDER)
from ORDERS
GO
/****** Object:  StoredProcedure [dbo].[GET_IMAGE_PRODUCTS]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_IMAGE_PRODUCTS]
@ID varchar(50)
as
select IMAGE_PRODUCT from PRODUCTS
where ID_PRODUCT=@ID
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_PRODUCT]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ALL_PRODUCT]
as
SELECT [ID_PRODUCT]as'اسم المنتج '
      ,[LABEL_PRODUCT]as'وصف المنتج'
      ,[QTE_IN_STOCK]as'الكميه'
      ,[PRICE]as'السعر'
      ,[DESCRIPTION_CAT]as'الصنف'
      ,[IMAGE_PRODUCT]
  FROM [PRODUCT_DB].[dbo].[PRODUCTS]
    inner join CATEGORIES
  on CATEGORIES.ID_CAT=PRODUCTS.ID_CAT
GO
/****** Object:  StoredProcedure [dbo].[DELETEPRODUCT]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DELETEPRODUCT]
@ID VARCHAR(50)
AS
DELETE FROM PRODUCTS WHERE ID_PRODUCT=@ID
GO
/****** Object:  StoredProcedure [dbo].[ADD_ORDER]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_ORDER]
@ID_ORDER int,
@DATE_ORDER datetime,
@CUSTOMER_ID int,
@DESCRIPTION_ORDER varchar(250),
@SALES_MAN varchar(75)
as
INSERT INTO [PRODUCT_DB].[dbo].[ORDERS]
           ([ID_ORDER] 
           ,[DATE_ORDER]
           ,[CUSTOMER_ID]
           ,[DESCRIPTION_ORDER]
           ,[SALESMAN])
     VALUES
     (@ID_ORDER,
      @DATE_ORDER
     ,@CUSTOMER_ID
     ,@DESCRIPTION_ORDER
     ,@SALES_MAN)
GO
/****** Object:  StoredProcedure [dbo].[add_product]    Script Date: 03/25/2017 19:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[add_product]
@ID_CAT INT,
@ID_PRODUCT nvarchar(50),
@Label nvarchar(50),
@QTE int,
@PRICE nvarchar(50),
@IMG image,
@criterion nvarchar(50)
AS
if @criterion='withimage'
begin
INSERT INTO [PRODUCT_DB].[dbo].[PRODUCTS]
           ([ID_PRODUCT]
           ,[LABEL_PRODUCT]
           ,[QTE_IN_STOCK]
           ,[PRICE]
           ,[ID_CAT]
           ,[IMAGE_PRODUCT])
     VALUES
           (@ID_PRODUCT
           ,@LABEL
           ,@QTE
           ,@PRICE
           ,@ID_CAT
           ,@IMG)
end
if @criterion='withoutimage'
begin
INSERT INTO [PRODUCT_DB].[dbo].[PRODUCTS]
           ([ID_PRODUCT]
           ,[LABEL_PRODUCT]
           ,[QTE_IN_STOCK]
           ,[PRICE]
           ,[ID_CAT])
     VALUES
           (@ID_PRODUCT
           ,@LABEL
           ,@QTE
           ,@PRICE
           ,@ID_CAT)
end
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_PRODUCT]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UPDATE_PRODUCT]
@ID_CAT INT,
@ID_PRODUCT varchar(30),
@Label varchar(30),
@QTE int,
@PRICE varchar(50),
@IMG image,
@criterion varchar(50)
AS
if @criterion='withimage'
begin
UPDATE [PRODUCT_DB].[dbo].[PRODUCTS]
   SET [ID_CAT] =@ID_CAT
      ,[LABEL_PRODUCT] =@LABEL
      ,[QTE_IN_STOCK] =@QTE
      ,[PRICE] =@PRICE
      ,[IMAGE_PRODUCT] =@IMG
WHERE
ID_PRODUCT=@ID_PRODUCT
end
if @criterion='withoutimage'
begin
UPDATE [PRODUCT_DB].[dbo].[PRODUCTS]
   SET [ID_CAT] =@ID_CAT
      ,[LABEL_PRODUCT] =@LABEL
      ,[QTE_IN_STOCK] =@QTE
      ,[PRICE] =@PRICE
WHERE
ID_PRODUCT=@ID_PRODUCT
end
GO
/****** Object:  StoredProcedure [dbo].[GET_SIGNLE_PRODUCTS]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[GET_SIGNLE_PRODUCTS]
@ID VARCHAR (30)
AS
SELECT [ID_PRODUCT]
      ,[LABEL_PRODUCT]
      ,[QTE_IN_STOCK]
      ,[PRICE]
      ,[IMAGE_PRODUCT]
      ,[DESCRIPTION_CAT]
  FROM [PRODUCT_DB].[dbo].[PRODUCTS]
  INNER JOIN CATEGORIES
  ON CATEGORIES.ID_CAT=PRODUCTS.ID_CAT
  WHERE ID_PRODUCT=@ID
GO
/****** Object:  StoredProcedure [dbo].[GET_SIGNLE_PRODUCT]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_SIGNLE_PRODUCT]
@ID VARCHAR (30)
AS
SELECT [ID_PRODUCT]
      ,[LABEL_PRODUCT]
      ,[QTE_IN_STOCK]
      ,[PRICE]
      ,[IMAGE_PRODUCT]
      ,[DESCRIPTION_CAT]
  FROM [PRODUCT_DB].[dbo].[PRODUCTS]
  INNER JOIN CATEGORIES
  ON CATEGORIES.ID_CAT=PRODUCTS.ID_CAT
  WHERE ID_PRODUCT=@ID
GO
/****** Object:  StoredProcedure [dbo].[VERIFYQUANTITY]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VERIFYQUANTITY]
@ID_PRODUCT varchar(30),
@QTY_ENTERED int
as
select * from PRODUCTS
where ID_PRODUCT=@ID_PRODUCT
and QTE_IN_STOCK > @QTY_ENTERED
GO
/****** Object:  StoredProcedure [dbo].[VERIFYPRODUCTID]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VERIFYPRODUCTID]
@ID varchar(50)
as
select * from PRODUCTS where ID_PRODUCT=@ID
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDER_DETAILS_for_print]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ORDER_DETAILS_for_print]
as
SELECT ORDER_DETAIL.ID_PRODUCT as'معرف المنتج'
      ,PRODUCTS.LABEL_PRODUCT AS'اسم المنتج'
      ,[ORDER_DETAIL].[ID_ORDER]as'رقم الفاتوره '
      ,[QTE]as'الكميه '
      ,convert(float,ORDER_DETAIL.PRICE) as'الثمن '
      ,[DISCOUNT] as'الخصم '
      ,convert(float,[AMOUNT]) as'المبلغ '
      ,convert(float,[TOTAL_AMOUNT]) as' المبلغ الاجمالي'
      ,DATE_ORDER as'تاريخ الفاتوره '
      ,DESCRIPTION_ORDER as'وصف الفاتوره '
      ,SALESMAN as'اسم البائع '
      ,ID_CUSTOMER as'معرف العميل'
      ,[FIRST_NAME] AS'اسم العميل'
      ,[LAST_NAME] AS' التصنيف'
      ,[TEL] AS'رقم الهاتف'
      ,[EMAIL] AS' العنوان'
  FROM [PRODUCT_DB].[dbo].[ORDER_DETAIL]
  inner join ORDERS
  on ORDERS.ID_ORDER=ORDER_DETAIL.ID_ORDER
   inner join CUSTOMERS
   on CUSTOMERS.ID_CUSTOMER=ORDERS.CUSTOMER_ID
   inner join PRODUCTS
   on PRODUCTS.ID_PRODUCT=ORDER_DETAIL.ID_PRODUCT
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDER_DETAILS]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_ORDER_DETAILS]
@ID_ORDER int
as
SELECT ORDER_DETAIL.ID_PRODUCT as'معرف المنتج'
      ,PRODUCTS.LABEL_PRODUCT AS'اسم المنتج'
      ,[ORDER_DETAIL].[ID_ORDER]as'رقم الفاتوره '
      ,[QTE]as'الكميه '
      ,convert(float,ORDER_DETAIL.PRICE)as'الثمن '
      ,[DISCOUNT] as'الخصم '
      ,convert(float,[AMOUNT]) as'المبلغ '
      ,convert(float,[TOTAL_AMOUNT]) as' المبلغ الاجمالي'
      ,DATE_ORDER as'تاريخ الفاتوره '
      ,DESCRIPTION_ORDER as'وصف الفاتوره '
      ,SALESMAN as'اسم البائع '
      ,ID_CUSTOMER as'معرف العميل'
      ,[FIRST_NAME] AS'اسم العميل'
      ,[LAST_NAME] AS' التصنيف'
      ,[TEL] AS'رقم الهاتف'
      ,[EMAIL] AS' العنوان'
  FROM [PRODUCT_DB].[dbo].[ORDER_DETAIL]
  inner join ORDERS
  on ORDERS.ID_ORDER=ORDER_DETAIL.ID_ORDER
   inner join CUSTOMERS
   on CUSTOMERS.ID_CUSTOMER=ORDERS.CUSTOMER_ID
   inner join PRODUCTS
   on PRODUCTS.ID_PRODUCT=ORDER_DETAIL.ID_PRODUCT
   WHERE ORDER_DETAIL.ID_ORDER=@ID_ORDER
GO
/****** Object:  StoredProcedure [dbo].[ADD_ORDER_DETAILS]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_ORDER_DETAILS]
@ID_PRODUCT varchar(30),
@ID_ORDER int,
@QTE int,
@PRICE varchar(50),
@DISCOUNT float,
@AMOUNT varchar(50),
@TOTAL_AMOUNT varchar(50)
as
INSERT INTO [PRODUCT_DB].[dbo].[ORDER_DETAIL]
           ([ID_PRODUCT]
           ,[ID_ORDER]
           ,[QTE]
           ,[PRICE]
           ,[DISCOUNT]
           ,[AMOUNT]
           ,[TOTAL_AMOUNT])
     VALUES
           (@ID_PRODUCT
           ,@ID_ORDER
           ,@QTE           
           ,@PRICE
           ,@DISCOUNT
           ,@AMOUNT
           ,@TOTAL_AMOUNT)
GO
/****** Object:  StoredProcedure [dbo].[ADD_SHOP_DETAILS]    Script Date: 03/25/2017 19:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ADD_SHOP_DETAILS]
@ID_PRODUCT varchar(30),
@ID_shop int,
@QTE int,
@PRICE varchar(50),
@AMOUNT varchar(50),
@TOTAL_AMOUNT varchar(50),
@DISCOUNT float
as
INSERT INTO [PRODUCT_DB].[dbo].[SHOP_DETAILS]
           ([ID_PRODUCT]
           ,[ID_shop]
           ,[QTE]
           ,[PRICE]
           ,[AMOUNT]
           ,[TOTAL_AMOUNT]
           ,[DISCOUNT])
     VALUES
           (@ID_PRODUCT
           ,@ID_shop
           ,@QTE
           ,@PRICE
           ,@AMOUNT
           ,@TOTAL_AMOUNT
           ,@DISCOUNT)
update PRODUCTS
set QTE_IN_STOCK=QTE_IN_STOCK+@QTE
where ID_PRODUCT=@ID_PRODUCT
GO
/****** Object:  ForeignKey [FK_PRODUCTS_CATEGORIES]    Script Date: 03/25/2017 19:32:34 ******/
ALTER TABLE [dbo].[PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTS_CATEGORIES] FOREIGN KEY([ID_CAT])
REFERENCES [dbo].[CATEGORIES] ([ID_CAT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PRODUCTS] CHECK CONSTRAINT [FK_PRODUCTS_CATEGORIES]
GO
/****** Object:  ForeignKey [FK_ORDERS_CUSTOMERS]    Script Date: 03/25/2017 19:32:34 ******/
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_CUSTOMERS] FOREIGN KEY([CUSTOMER_ID])
REFERENCES [dbo].[CUSTOMERS] ([ID_CUSTOMER])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_CUSTOMERS]
GO
/****** Object:  ForeignKey [FK_SHOP_DETAILS_PRODUCTS1]    Script Date: 03/25/2017 19:32:34 ******/
ALTER TABLE [dbo].[SHOP_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_SHOP_DETAILS_PRODUCTS1] FOREIGN KEY([ID_PRODUCT])
REFERENCES [dbo].[PRODUCTS] ([ID_PRODUCT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SHOP_DETAILS] CHECK CONSTRAINT [FK_SHOP_DETAILS_PRODUCTS1]
GO
/****** Object:  ForeignKey [FK_SHOP_DETAILS_SHOP]    Script Date: 03/25/2017 19:32:34 ******/
ALTER TABLE [dbo].[SHOP_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_SHOP_DETAILS_SHOP] FOREIGN KEY([ID_shop])
REFERENCES [dbo].[SHOP] ([ID_SHOP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SHOP_DETAILS] CHECK CONSTRAINT [FK_SHOP_DETAILS_SHOP]
GO
/****** Object:  ForeignKey [FK_ORDER_DETAIL_ORDERS]    Script Date: 03/25/2017 19:32:34 ******/
ALTER TABLE [dbo].[ORDER_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_DETAIL_ORDERS] FOREIGN KEY([ID_ORDER])
REFERENCES [dbo].[ORDERS] ([ID_ORDER])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDER_DETAIL] CHECK CONSTRAINT [FK_ORDER_DETAIL_ORDERS]
GO
/****** Object:  ForeignKey [FK_ORDER_DETAIL_PRODUCTS]    Script Date: 03/25/2017 19:32:34 ******/
ALTER TABLE [dbo].[ORDER_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_DETAIL_PRODUCTS] FOREIGN KEY([ID_PRODUCT])
REFERENCES [dbo].[PRODUCTS] ([ID_PRODUCT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDER_DETAIL] CHECK CONSTRAINT [FK_ORDER_DETAIL_PRODUCTS]
GO
