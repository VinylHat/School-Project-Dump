/*
	Author: Brendan Ellison
	Date: 11/23/2021

	This can be executed all at once but I want to keep this consolidated,
	so if anything is added it should be highlighted then executed
*/
USE MASTER
GO

IF  DB_ID('BrendansAutoShop') IS NOT NULL
    DROP DATABASE BrendansAutoShop;
GO

CREATE DATABASE BrendansAutoShop
GO

USE BrendansAutoShop
GO

CREATE TABLE Vehicle
(
	VehicleID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Producer		NVARCHAR(32) NOT NULL,
	Model			NVARCHAR(64) NOT NULL,
	Year			SMALLINT NULL, -- I feel that not every one remembers their model year
	Description		NVARCHAR(255) NOT NULL, -- Must have a description of the work needed to repair
	CHECK (Producer = 'Ford' OR Producer = 'Honda' OR Producer = 'Toyota' OR Producer = 'VolksWagen' OR Producer = 'Chevrolet' OR
			Producer = 'GM' OR Producer = 'BMW' OR Producer = 'Hyundai' OR Producer = 'Nissan' OR Producer = 'Volvo' OR Producer = 'Other')
	--The Check is to avoid bad entires/user error/stupid entries, it is more of a concept then a complete list
	--I did not add a check for models because that list would be too big and not really add much
);
GO

CREATE TABLE Parts
(
	PartID				INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	UnitsAvailable		INT	NOT NULL, -- Storage/Spares
	PartType			NVARCHAR(24) NOT NULL, -- Alternator, Battery, Cylinder, etc...
	PartManufacturer	NVARCHAR(24) NOT NULL, -- I think it is useful to know reliable sellers
	PartDescription		NVARCHAR(255) NULL, -- Encouraged but not required, might change later
);
GO

CREATE TABLE Customer
(
	CustomerID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	VehicleID		INT NOT NULL REFERENCES Vehicle (VehicleID),
	FirstName		NVARCHAR(32) NOT NULL,
	LastName		NVARCHAR(32) NOT NULL,
	BillingAddress	NVARCHAR(255) NOT NULL,
	ZipCode			NVARCHAR(5) NOT NULL,
	CardNumber		NVARCHAR(16) NOT NULL,
	CardExpMonth	SMALLINT NOT NULL,
	CardExpYear		SMALLINT NOT NULL,
	CardCVV			NVARCHAR(3) NOT NULL
);
GO

CREATE TABLE OrderList
(
	OrderListID			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CustomerID			INT NOT NULL REFERENCES Customer (CustomerID),
	PartID				INT NOT NULL REFERENCES Parts (PartID),
	OrderDate			DATE NOT NULL,
	UnitPrice			MONEY NOT NULL,
	QuantityOrdered		INT NOT NULL,
	OrderTotal			AS UnitPrice * QuantityOrdered
);
GO

-- DO NOT have the orders tied to the invoices, input with a query 
CREATE TABLE Invoices
(
	InvoiceID			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CustomerID			INT NOT NULL REFERENCES Customer (CustomerID),
	SubTotal			MONEY NULL,
	Tax					AS SubTotal * 0.08, --I think tax is 8%...
	Service				AS SubTotal * 0.15,
	Total				AS SubTotal * 1.23,
	PaymentTotal		MONEY NULL DEFAULT 0
	CONSTRAINT Payment_Validator CHECK (PaymentTotal >= 0) --AND (PaymentTotal <= Total)) Does not like the computed column in here
);
GO