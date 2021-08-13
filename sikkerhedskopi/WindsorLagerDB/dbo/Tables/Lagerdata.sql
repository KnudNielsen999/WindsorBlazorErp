CREATE TABLE [dbo].[Lagerdata]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VareNummer] NVARCHAR(50) NULL, 
    [Varetekst] NVARCHAR(200) NULL, 
    [Maengde] DECIMAL NULL, 
    [Enhed] NVARCHAR(10) NULL, 
    [IndkobsPris] MONEY NULL, 
    [OprDT] DATETIME2 NULL, 
)
