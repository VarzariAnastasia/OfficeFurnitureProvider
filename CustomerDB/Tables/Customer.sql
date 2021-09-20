CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NOT NULL, 
    [CustomerName] NCHAR(100) NOT NULL, 
    [CustomerRebate] INT NOT NULL

)