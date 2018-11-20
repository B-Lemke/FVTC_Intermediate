CREATE TABLE [dbo].[tblEquipment]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[SerialNo] VARCHAR(20) NOT NULL,
	[Manufacturer] VARCHAR(20) NOT NULL,
	[Description] VARCHAR(100) NOT NULL,
	[Model] VARCHAR(20) NOT NULL,
	[Price] DECIMAL(11,2) NOT NULL,
	[EquipmentTypeID] INT NOT NULL
)
