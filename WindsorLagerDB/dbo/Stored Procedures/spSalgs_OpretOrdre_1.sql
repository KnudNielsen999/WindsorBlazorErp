CREATE PROCEDURE [dbo].[spSalgs_OpretOrdre]
	@KundeID NVARCHAR(50) ,
    @OrdreNummer INT ,
    @LinieTotal MONEY ,
    @Moms MONEY ,
    @FakturaTotal MONEY  ,
    @BetalingsFrist NVARCHAR(25) ,
    @FakturaTekst NVARCHAR(200) ,
    @IndkoebMaengde NUMERIC ,
    @VareNummer NVARCHAR(50) ,
    @IndkobsPris MONEY ,
    @OrdreOprettet DATETIME2(7)
	
AS
begin
	set nocount on;

	insert into dbo.Salgsordre(KundeID,OrdreNummer,LinieTotal,Moms,FakturaTotal,BetalingsFrist,FakturaTekst,IndkoebMaengde,VareNummer,IndkobsPris,OrdreOprettet)
	values (@KundeID,@OrdreNummer,@LinieTotal,@Moms,@FakturaTotal,@BetalingsFrist,@FakturaTekst,@IndkoebMaengde,@VareNummer,@IndkobsPris,@OrdreOprettet);
end