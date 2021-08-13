CREATE PROCEDURE [dbo].[spKunder_hentkunder]
	AS
begin
	select [Id], [KundeID], [Firmanavn], [Adresse], [Bynavn]
	from dbo.Kunder;
end