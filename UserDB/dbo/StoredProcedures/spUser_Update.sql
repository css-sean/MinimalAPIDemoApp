CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int, 
	@FirstName NVARCHAR(50), 
	@LastName NVARCHAR(100)
AS
begin
	update dbo.[User]
	set FirstName = @FirstName, LastName = @LastName
	where Id = @Id;
end