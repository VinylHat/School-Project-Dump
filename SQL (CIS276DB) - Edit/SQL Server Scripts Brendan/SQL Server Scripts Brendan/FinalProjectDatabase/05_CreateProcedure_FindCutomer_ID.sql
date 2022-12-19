/*
	Author: Brendan Ellison
	Date: 12/2/21
	Objective: Procedure to find info on customer
*/
USE BrendansAutoShop
GO

DROP PROCEDURE IF EXISTS GetCustomerInfo_ID
GO

CREATE PROCEDURE GetCustomerInfo_ID
@CustomerID INT -- I just want the meaning to be very clear

AS

SELECT * 
FROM View_FindCustomer
WHERE CustomerID = @CustomerID
GO

EXEC GetCustomerInfo_ID @CustomerID = 1
GO