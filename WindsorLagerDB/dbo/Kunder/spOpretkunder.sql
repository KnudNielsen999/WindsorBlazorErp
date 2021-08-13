CREATE PROCEDURE [dbo].[spOpretkunder] 
    @KundeID NVARCHAR(50), 
    @Firmanavn NVARCHAR(50) , 
    @Adresse NVARCHAR(50) , 
    @Bynavn NVARCHAR(50) 
	
AS
begin
	set nocount on;

	insert into dbo.Kunder(KundeID,Firmanavn,Adresse,Bynavn)
	values (@KundeID,@Firmanavn,@Adresse,@Bynavn);
end
