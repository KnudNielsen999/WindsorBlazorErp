CREATE PROCEDURE [dbo].[spLager_DeleteProdukt]
	@Id int
AS
begin
	set nocount on;

	delete from dbo.Lagerdata
	where Id = @Id;
end
