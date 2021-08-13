CREATE PROCEDURE [dbo].[spOpretSalgsOrdre]
	
	
	@Id int,
	@OrdrenummerID int
	
AS
begin
	set nocount on;
	
                               
	insert into dbo.OrdrenummerGen(Id,OrdrenummerID)
	values (@Id,@OrdrenummerID);
end