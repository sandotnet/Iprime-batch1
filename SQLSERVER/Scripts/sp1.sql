create procedure Greet
as
begin
print 'Welcome to SqlServer!!!'
end
--exexute procedure
exec Greet
create procedure sp_Add(@a int,@b int)
as
begin
declare @result int
set @result=@a+@b
print @result
select @result as Result
end
exec sp_Add 12,34
exec sp_Add 56,89