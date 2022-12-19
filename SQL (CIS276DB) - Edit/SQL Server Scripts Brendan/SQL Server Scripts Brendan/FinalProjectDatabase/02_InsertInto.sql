/*
	Author: Brendan Ellison
	Date: 11/25/2021
*/
USE BrendansAutoShop
GO

INSERT INTO Vehicle (Producer, Model, Year, Description)
VALUES ('Toyota', 'Tacoma', 2014, 'Owner had his catalytic converter stolen and needs it replaced aswell as a protective strap'),--True story btw
		('Chevrolet', 'Malibu', 2014,'Car needs a replacment secondary battary in the trunk, car runs fine otherwise'),
		('Ford','F-250', 2015,'Nail found in the tire, needs a new wheel'),
		('Chevrolet','Silverado 2500HD',2021,'Needs an oil change'),
		('Honda','Civic',2016,'Needs new brake pads and ac filter'),
		('Ford','F-150',2020,'Alternator needs to be replaced and battery as well'),
		('BMW','328i',2011,'Thermostate needs to be replaced'),
		('Nissan','NV Cargo',2021,'Both side mirrors missing, needs replacing'),
		('Chevrolet','Malibu',2014,'Brake lights stoped working');
GO

SELECT *
FROM Vehicle
GO

INSERT INTO Customer (VehicleID, FirstName, LastName, BillingAddress, ZipCode, CardNumber, CardExpMonth, CardExpYear, CardCVV)
VALUES (1,'Brendan','Ellison','2220 E Beardsley Road', '85024','9330093598667675',04,23,123),
		(2,'Marianne','Ellison','2220 E Beardsley Road','85024','6990504036642041',12,25,596),
		(3,'Skye','Berry','105 New Saddle Street Stroudsburg','43017','4064645536577681',05,24,670),
		(4,'Quentin','Smith','104 S. Primrose Street Murfreesboro','22468','8388647097946058',07,27,099),
		(5,'Greyson','Smith','726 Warren Ave. South Richmond Hill','55582','1664849122693541',09,29,433),
		(6,'Jack','Neal','417 Walnut Street Saint Albans','53158','3906897658221940',11,21,888),
		(7,'Cheyenne','Cowan','118 Devonshire St. Rahway','44155','1157808329225578',01,26,671),
		(8,'John','Lee','9557 Carriage Ave. Tualatin','95809','0515829402171149',04,24,263),
		(9,'Wesley','Mcdaniel','9528 Halifax Drive Wantagh','37821','8528535821184297',02,27,397);
GO

SELECT *
FROM Customer
GO

INSERT INTO Parts (UnitsAvailable, PartType, PartManufacturer, PartDescription)
VALUES (0,'Catalytic Converter','ExtremeTerrain.com','Reduces emmissions and sound from truck engine'),
		(0,'Strap','getcatsecurity.com','A big metal plate that covers parts from being stole off the undercarriage'),
		(1,'Auxiliary Battery','AutoZone','A secondary battery found in some cars'),
		(2,'Tire','Discount Tire','Large truck tire, 18"'),
		(2,'Synthetic Oil','Amsoil','Synthetic Oil for mid sized truck'),
		(0,'Brake Pad','BrakeProformance','Brake pads for 2015 honda civic'),
		(5,'AC Filter','Amazon.com','Replacment air filter'),
		(0,'Alternator','Amazon.com','Alternator for Ford vehicles'),
		(1,'Battery','Advanced Auto Parts','Battery for a mid sized truck, Size: 34'),
		(0,'Thermostat','FCP Euro','Thermostat used for BMW'),
		(0,'Side Mirror','1AAuto.com','Side mirror for NV Cargo'),
		(4,'Brake Light','Amazon.com','2013-2015 Malibu brake light');
GO

SELECT *
FROM Parts
GO

INSERT INTO OrderList (CustomerID, PartID, OrderDate, UnitPrice, QuantityOrdered)
VALUES (1,1,'2021-10-20',650.99,1),
		(1,2,'2021-10-20',299.99,1),
		(2,3,'2021-09-10',92.99,1),
		(3,4,'2021-09-26',283,1),
		(4,5,'2021-11-11',55.29,1),
		(5,6,'2021-11-14',78.40,4),
		(5,7,'2021-11-14',15.76,1),
		(6,8,'2021-10-29',72.95,1),
		(6,9,'2021-10-29',201.99,1),
		(7,10,'2021-11-10',58.51,1),
		(8,11,'2021-12-01',35.95,2),
		(9,12,'2021-11-04',98.98,2);
GO

SELECT *
FROM OrderList
GO

INSERT INTO Invoices (CustomerID, SubTotal)
SELECT CustomerID, SUM(OrderTotal) 
FROM OrderList
GROUP BY CustomerID
GO

SELECT *
FROM Invoices
GO

-- These are just to simulate some payments
UPDATE Invoices
SET PaymentTotal = 1169.71
WHERE CustomerID = 1

UPDATE Invoices
SET PaymentTotal = 114.38
WHERE CustomerID = 2

UPDATE Invoices
SET PaymentTotal = 338.18
WHERE CustomerID = 6

UPDATE Invoices
SET PaymentTotal = 88.44
WHERE CustomerID = 8

UPDATE Invoices
SET PaymentTotal = 200
WHERE CustomerID = 5

UPDATE Invoices
SET PaymentTotal = 100
WHERE CustomerID = 9

SELECT *
FROM Invoices
GO