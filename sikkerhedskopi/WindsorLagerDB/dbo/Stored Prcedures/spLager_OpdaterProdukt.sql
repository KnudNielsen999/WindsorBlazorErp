CREATE PROCEDURE [dbo].[spLager_OpdaterProdukt]
	@Id int,
	@VareNummer nvarchar(50),
	@Varetekst nvarchar(200),
	@Maengde  decimal(18,0),
	@Enhed  nvarchar(200),
	@IndkobsPris money,
	@OprDT  datetime2(7)
AS
begin
	set nocount on;

	update dbo.Lagerdata
	set VareNummer=@VareNummer,
	    VareTekst=@Varetekst,
	    Maengde=@Maengde,
	    Enhed=@Enhed,
	    IndkobsPris=@IndkobsPris,
	    OprDT=@OprDT
	where Id = @Id;
end
