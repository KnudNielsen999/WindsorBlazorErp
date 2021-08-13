CREATE PROCEDURE [dbo].[spSlet_Kunde]
		@Id int
AS
begin
	set nocount on;

	delete from dbo.Kunder
	where Id = @Id;
end
