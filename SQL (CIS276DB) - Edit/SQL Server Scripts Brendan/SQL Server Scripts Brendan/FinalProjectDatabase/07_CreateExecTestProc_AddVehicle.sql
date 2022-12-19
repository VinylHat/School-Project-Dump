/*
	Author: Brendan Ellison
	Date: 12/3/21
	Objective: Procedure to insert into vehicle table via app
*/
USE BrendansAutoShop
GO

DROP PROC IF EXISTS Proc_AddVehicle
GO

CREATE PROC Proc_AddVehicle
	@Producer NVARCHAR(32),
	@Model NVARCHAR(64),
	@Year SMALLINT NULL,
	@Description NVARCHAR(255)
AS
INSERT INTO Vehicle (Producer, Model, Year, Description)
VALUES (@Producer, @Model, @Year, @Description)
GO

SELECT * FROM Vehicle
GO

EXEC Proc_AddVehicle 'Ford','F-250',NULL,'Truck has a flat tire'
GO

SELECT * FROM Vehicle
GO

--Clean up
DELETE FROM Vehicle WHERE VehicleID > 9;
GO

SELECT * FROM Vehicle
GO
