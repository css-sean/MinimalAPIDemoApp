CREATE PROCEDURE [dbo].[spUser_Insert]
	
	@FirstName NVARCHAR(50), 
	@LastName NVARCHAR(100)
AS
begin
	insert into dbo.[User] (FirstName, LastName) 
	values (@FirstName, @LastName);
end
