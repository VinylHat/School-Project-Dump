/*
	Author: Brendan Ellison
	Date: 12/2/21
	Objective: Simple view to find customers with debt
*/

USE BrendansAutoShop
GO

DROP VIEW IF EXISTS View_FindDebt
GO

CREATE VIEW View_FindDebt AS
SELECT FirstName, LastName, -- Full Name (I hate doing Last, First)
	Year, Model, -- The Customers Vehicle
	FORMAT(Total, 'C') AS [Total Due], FORMAT(PaymentTotal, 'C') AS [Ammount Paid],
	FORMAT((Total - PaymentTotal), 'C')  AS [Ammount Due] -- Usefull Payment Info
FROM Invoices JOIN Customer
	ON Invoices.CustomerID = Customer.CustomerID
	JOIN Vehicle
	ON Customer.VehicleID = Vehicle.VehicleID
WHERE PaymentTotal < Total
GO

SELECT *
FROM View_FindDebt
GO