CREATE PROCEDURE InsertEmployeeProcedure
	-- Add the parameters for the stored procedure here
	@id int,@name varchar(50),@salary int,@address varchar(60)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Employees(Id,Name,Salary,Address) values(@id,@name,@salary,@address)
END

