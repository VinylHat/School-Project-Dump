/*
	Author: Brendan Ellison
	Date: 12/2/21
	Objective: Procedure to find info on customer With First and Last name
	I feel in a larger Database this is a more realistic way of getting info,
	this would be easy to set up in an application
*/
USE BrendansAutoShop
GO

DROP PROCEDURE IF EXISTS GetCustomerInfo_Name
GO

CREATE PROCEDURE GetCustomerInfo_Name
@CustomerFName NVARCHAR(32),
@CustomerLName NVARCHAR(32)

AS

SELECT * 
FROM View_FindCustomer
WHERE FirstName = @CustomerFName AND
	LastName = @CustomerLName
GO

EXEC GetCustomerInfo_Name @CustomerFName = 'Brendan', @CustomerLName = 'Ellison'