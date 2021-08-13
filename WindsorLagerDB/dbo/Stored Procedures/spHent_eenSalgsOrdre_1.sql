CREATE PROCEDURE [dbo].[spHent_eenSalgsOrdre]
	@Id int 
	
AS
	SELECT [Id], [KundeID], [OrdreNummer], [LinieTotal], [Moms], [FakturaTotal], [BetalingsFrist], [FakturaTekst], [IndkoebMaengde], [VareNummer], [IndkobsPris], [OrdreOprettet]
	from dbo.Salgsordre
	where Id = @Id;
RETURN 0