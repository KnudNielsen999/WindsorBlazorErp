CREATE PROCEDURE [dbo].[spSlet_SalgsOrdre]
	@Id int
AS
begin
	set nocount on;

	delete from dbo.Salgsordre
	where Id = @Id;
end
