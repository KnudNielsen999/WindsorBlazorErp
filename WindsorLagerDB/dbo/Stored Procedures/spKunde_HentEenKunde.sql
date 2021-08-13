CREATE PROCEDURE [dbo].[spKunde_HentEenKunde]
	@Id int
	AS
begin
	select [Id], [KundeID], [Firmanavn], [Adresse], [Bynavn]
	from dbo.Kunder
	where Id = @Id;
end
