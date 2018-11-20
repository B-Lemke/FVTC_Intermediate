CREATE TABLE [dbo].[tblSoftware]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(30) NOT NULL,
	[Size] INT NOT NULL,
	[Description] VARCHAR(100) NOT NULL,
	[Price] DECIMAL(11,2) NOT NULL, 
    [EquipmentID] INT NOT NULL
)
