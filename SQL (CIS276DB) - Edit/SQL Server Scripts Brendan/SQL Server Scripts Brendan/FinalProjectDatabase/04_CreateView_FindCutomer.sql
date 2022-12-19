/*
	Author: Brendan Ellison
	Date: 12/2/21
	Objective: View to find customer Info
*/

USE BrendansAutoShop
GO

DROP VIEW IF EXISTS View_FindCustomer
GO

CREATE VIEW View_FindCustomer AS
SELECT CustomerID,
	FirstName, LastName,
	BillingAddress, ZipCode,
	'************' + RIGHT(CardNumber,4) AS [Last 4 on Card] -- For varification if needed
FROM Customer
GO

SELECT * FROM View_FindCustomer GO