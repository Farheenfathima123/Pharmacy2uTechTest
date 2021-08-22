# Pharmacy2uTechTest

Please follow the below steps,

1. Map the repository in your local machine.
2. Create a database by name Pharmacy2udb
3. Create a table using the below query,

USE [Pharmacy2udb]
GO

CREATE TABLE [dbo].[CurrencyAudit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyType] [varchar](255) NOT NULL,
	[ActualAmount] [decimal](38, 2) NOT NULL,
	[ConvertedAmount] [decimal](38, 2) NOT NULL,
	[DateAdded] [datetime] NULL,
)
GO


4. Update the connection string in Web.config
