CREATE PROCEDURE [dbo].[spLager_UpdateOrdre]
	@Id INT, 
    @KundeID NVARCHAR(50)  , 
    @OrdreNummer INT , 
    @LinieTotal MONEY , 
    @Moms MONEY , 
    @FakturaTotal MONEY , 
    @BetalingsFrist NVARCHAR(25) , 
    @FakturaTekst NVARCHAR(200) ,
    @IndkoebMaengde NUMERIC , 
    @VareNummer NVARCHAR(50), 
    @IndkobsPris MONEY , 
    @OrdreOprettet DATETIME2 

AS
begin
	set nocount on;
	update dbo.Salgsordre
	set  KundeID=@KundeID,
     OrdreNummer=@OrdreNummer,
     LinieTotal = @LinieTotal,
      Moms=@Moms,
     FakturaTotal=@FakturaTotal,
     BetalingsFrist=@BetalingsFrist,
     FakturaTekst=@FakturaTekst,
    IndkoebMaengde= @IndkoebMaengde,
     VareNummer= @VareNummer,
     IndkobsPris=@IndkobsPris,
      OrdreOprettet=@OrdreOprettet
	where Id = @Id;
end