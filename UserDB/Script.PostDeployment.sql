if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Sean', 'Savage'),
	('Hernan', 'Hernandez'),
	('Steven', 'Amani'), 
	('Angelo', 'Ortiz')
end
