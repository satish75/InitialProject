CREATE PROCEDURE [dbo].[DeleteById] 
	-- Add the parameters for the stored procedure here
@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure by id
	delete from Employees where Id=@Id
END