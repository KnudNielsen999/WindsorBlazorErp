CREATE PROCEDURE [dbo].[spLager_HentproduktData]
	
AS
	SELECT [Id], [VareNummer], [Varetekst], [Maengde], [Enhed], [IndkobsPris], [OprDT]
	FROM dbo.Lagerdata
	ORDER BY [VareNummer];
RETURN 0
