CREATE PROCEDURE [dbo].[spKunder_update]
	@Id int,
	@KundeID NVARCHAR(50) , 
    @Firmanavn NVARCHAR(50), 
    @Adresse NVARCHAR(50), 
    @Bynavn NVARCHAR(50) 
AS
begin
	set nocount on;

	update dbo.Kunder
	set KundeID = @KundeID,
		Firmanavn = @Firmanavn,
		Adresse = @Adresse,
		Bynavn =@Bynavn
	where Id = @Id;
end