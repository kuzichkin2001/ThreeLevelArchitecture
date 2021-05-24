CREATE DATABASE PRODUCTS_SHOP
COLLATE Cyrillic_General_CI_AS
GO

CREATE TABLE Products (
	[ID_Product][int] NOT NULL IDENTITY (1, 1),
	[ProductName][varchar] (50) NOT NULL,
	[Cost][float] NOT NULL,
	[SalePercent][float] NOT NULL,
	[SaleStartDate][DateTime],
	[SaleEndDate][DateTime]
)
ALTER TABLE Products
ADD
PRIMARY KEY (ID_Product)
GO

DROP TABLE Products

CREATE PROCEDURE GetAllProducts
AS
BEGIN
	SELECT * FROM Products
END
GO

CREATE PROCEDURE GetAllSaleInfo
AS
BEGIN
	SELECT ProductName, Cost, SalePercent, SaleStartDate, SaleEndDate FROM Products
	WHERE SalePercent > 0
END
GO

CREATE PROCEDURE AddNewProduct
@idProduct int OUTPUT,
@productName varchar(50),
@cost float,
@salePercent float,
@saleStartDate DateTime,
@saleEndDate DateTime
AS
BEGIN
	IF @saleStartDate IS NULL and @saleEndDate IS NULL
		INSERT INTO Products (ProductName, Cost, SalePercent)
		VALUES (@productName, @cost, @salePercent)
	ELSE
		INSERT INTO Products (ProductName, Cost, SalePercent, SaleStartDate, SaleEndDate)
		VALUES (@productName, @cost - @salePercent * @cost / 100, @salePercent, @saleStartDate, @saleEndDate)
END
GO

CREATE PROCEDURE UpdateSaleInfo
@idProduct int,
@cost float,
@salePercent float,
@saleStartDate DateTime,
@saleEndDate Datetime
AS
BEGIN
	UPDATE Products SET
		Cost = @cost - @cost * @salePercent / 100,
		SalePercent = @salePercent,
		SaleStartDate = @saleStartDate,
		SaleEndDate = @saleEndDate
	WHERE ID_Product = @idProduct
END
GO

CREATE PROCEDURE DeleteProduct
@idProduct int
AS
BEGIN
	DELETE FROM Products WHERE ID_Product = @idProduct
END
GO

CREATE PROCEDURE DeleteSaleInfo
@idProduct int
AS
BEGIN
	UPDATE Products SET
		SalePercent = 0,
		SaleStartDate = NULL,
		SaleEndDate = NULL,
		Cost = Cost * 100 / (100 - SalePercent)
	WHERE ID_Product = @idProduct
END
GO

CREATE PROCEDURE SearchByProductName
@productName varchar(50)
AS
BEGIN
	SELECT * FROM Products WHERE ProductName = @productName
END
GO

CREATE PROCEDURE SearchBySaleDate
@currentDate DateTime
AS
BEGIN
	SELECT * FROM Products WHERE SaleStartDate <= @currentDate AND SaleEndDate >= @currentDate
END
GO