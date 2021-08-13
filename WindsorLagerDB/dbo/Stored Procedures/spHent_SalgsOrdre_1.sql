CREATE PROCEDURE [dbo].[spHent_SalgsOrdre]
	
AS
begin
set nocount on;

	SELECT [Id], [KundeID], [OrdreNummer], [LinieTotal], [Moms], [FakturaTotal], [BetalingsFrist], [FakturaTekst], [IndkoebMaengde], [VareNummer], [IndkobsPris], [OrdreOprettet]
	FROM dbo.Salgsordre
	
end 