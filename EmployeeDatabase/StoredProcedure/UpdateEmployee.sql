CREATE PROCEDURE [dbo].[UpdateEmployeeById]
	-- Add the parameters for the stored procedure here
	@Id int,@Name varchar(50),@Salary int,@Address varchar(60)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	UPDATE Employees set Name =@Name,
	                     Salary=@Salary,
	                     Address=@Address
	                     where Id=@Id
END
