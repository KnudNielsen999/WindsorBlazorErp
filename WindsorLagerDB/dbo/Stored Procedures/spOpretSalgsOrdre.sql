CREATE PROCEDURE [dbo].[spOpretSalgsOrdre]
	@Ordrenummer int
AS
begin
	set nocount on;

	insert into dbo.NytOrdrenummer(Ordrenummer)
	values (@Ordrenummer)

end
	
