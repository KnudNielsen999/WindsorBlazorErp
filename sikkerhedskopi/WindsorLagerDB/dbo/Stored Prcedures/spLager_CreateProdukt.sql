CREATE PROCEDURE [dbo].[spLager_CreateProdukt]
	@VareNummer nvarchar(50),
	@VareTekst nvarchar(200),
	@Maengde  decimal(18,0) ,
	@Enhed  nvarchar(10) ,
	@IndkobsPris money,
	@OprDT datetime
	
AS
begin
	set nocount on;

	insert into dbo.Lagerdata(VareNummer, VareTekst, Maengde, Enhed, IndkobsPris, OprDT)
	values (@VareNummer, @VareTekst, @Maengde, @Enhed, @IndkobsPris, @OprDT);
end
