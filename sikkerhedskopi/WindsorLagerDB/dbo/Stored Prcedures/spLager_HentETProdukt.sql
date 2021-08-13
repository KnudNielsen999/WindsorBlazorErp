CREATE PROCEDURE [dbo].[spLager_HentETProdukt]
		 @Id int
AS
	SELECT [Id], [VareNummer], [Varetekst], [Maengde], [Enhed], [IndkobsPris], [OprDT]
	FROM dbo.Lagerdata
	where Id = @Id;
RETURN 0
