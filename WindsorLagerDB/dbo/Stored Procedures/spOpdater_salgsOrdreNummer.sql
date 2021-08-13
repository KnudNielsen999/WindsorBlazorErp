CREATE PROCEDURE [dbo].[spOpdater_salgsOrdreNummer]
	@Id int,
	@Ordrenummer int
AS
begin
	set nocount on;

	update dbo.NytOrdrenummer
	set Ordrenummer=@Ordrenummer
	    
	where Id = @Id;
end