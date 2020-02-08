CREATE PROCEDURE [dbo].[PrGetStudent]
	@sid int
AS
	SELECT * from Student1 where id=@sid;
RETURN 0
