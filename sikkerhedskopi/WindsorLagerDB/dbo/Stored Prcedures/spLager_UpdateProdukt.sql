CREATE PROCEDURE [dbo].[spLager_UpdateProdukt]
	@Id Int,
	@VareNummer nvarchar(50),
	@VareTekst nvarchar(200),
	@Maengde  decimal(18,0) ,
	@Enhed  nvarchar(10) ,
	@IndkobsPris money,
	@OprDT datetime
AS
begin
	set nocount on;

	update dbo.Lagerdata
	set 
	    VareNummer=@VareNummer,
	    Varetekst=@VareTekst,
	    Maengde=@Maengde,
		Enhed=@Enhed,
		IndkobsPris=@IndkobsPris,
		OprDT=@OprDT
	    
	where Id = @Id;
end