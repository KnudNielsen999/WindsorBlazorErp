CREATE PROCEDURE [dbo].[spHent_SalgsOrdre]
	 @OrdreNummer int
AS
	SELECT KundeID,OrdreNummer,LinieTotal,Moms,FakturaTotal,BetalingsFrist,FakturaTekst,IndkoebMaengde,VareNummer,IndkobsPris,OrdreOprettet
	FROM dbo.Salgsordre
	where [dbo].[Salgsordre].[OrdreNummer]=@OrdreNummer
RETURN 0
