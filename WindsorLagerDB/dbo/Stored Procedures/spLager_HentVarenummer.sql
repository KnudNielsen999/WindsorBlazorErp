CREATE PROCEDURE [dbo].[spLager_HentVarenummer]
	
		 @VareNummer nvarchar(50)
AS
	SELECT [Id], [VareNummer], [Varetekst], [Maengde], [Enhed], [IndkobsPris], [OprDT]
	FROM dbo.Lagerdata
	where VareNummer = @VareNummer;
RETURN 0