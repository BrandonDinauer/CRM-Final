CREATE TABLE [dbo].[CustomerTable2]
(
	[Customer ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(50) NOT NULL, 
    [Address] NCHAR(50) NOT NULL, 
    [Phone Number] NCHAR(50) NOT NULL,  
    [Email] NCHAR(50) NOT NULL, 
    [Vehicle] NCHAR(50) NOT NULL, 
    [Invoices] NCHAR(50) NOT NULL, 
    [Notes] NCHAR(50) NOT NULL
)
