select * from employee
--insert
insert into employee values(1,'Rohan','12.2.2020',45000,null)
--add multiple rows
insert into dept(dept_code,dept_name) values('D0001','IT'),('D0002','Admin')
									select * from dept
insert into employee(id,name,dept_code) values(2,'Cherry','D0001')
select * from employee
--update 
update employee set Salary=50000 where id in(1,2) --update salary for id 1 and 2
update employee set Salary=56000,Dept_Code='D0001' where id=1
update employee set Salary=Salary+10000 where Dept_Code='D0001'
select * from employee
--Delete
delete from employee -- all rows will delete
delete from emloyee where dept_code='D0001' --delete employee with dept as 'D0001'
delete from employee where id=2 -- delete employee with id=2