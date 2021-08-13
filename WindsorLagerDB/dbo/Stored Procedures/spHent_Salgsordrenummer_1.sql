CREATE PROCEDURE [dbo].[spHent_Salgsordrenummer]
		@Id int 
	
AS
	SELECT [Id], [Ordrenummer]
	FROM dbo.NytOrdrenummer
	where Id = @Id
RETURN 0