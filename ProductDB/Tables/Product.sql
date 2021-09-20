CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [ProductName] NCHAR(50) NOT NULL, 
    [ProductPrice] FLOAT NOT NULL, 
    [ProductQuantity] INT NOT NULL, 
    [ProductDescription] NCHAR(100) NOT NULL
)
