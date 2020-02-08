CREATE PROCEDURE [dbo].[InsertRows]
	@Cid int = 0,
	@Cname varchar(max),
	@Pname varchar(max),
	@Price varchar(max)

AS
	SELECT @Cid, @Cname,@Pname,@Price
RETURN 0
