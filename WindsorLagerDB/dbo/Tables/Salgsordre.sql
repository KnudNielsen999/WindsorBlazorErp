CREATE TABLE [dbo].[Salgsordre]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [KundeID] INT NULL, 
    [OrdreNummer] INT NULL, 
    [LinieTotal] MONEY NULL, 
    [Moms] MONEY NULL, 
    [FakturaTotal] MONEY NULL, 
    [BetalingsFrist] NVARCHAR(25) NULL, 
    [FakturaTekst] NVARCHAR(200) NULL, 
    [IndkoebMaengde] NUMERIC NULL, 
    [VareNummer] NVARCHAR(50) NULL, 
    [IndkobsPris] MONEY NULL, 
    [OrdreOprettet] DATETIME2 NULL
)