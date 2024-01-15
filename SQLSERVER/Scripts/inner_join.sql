select * from Dept
select * from Employee
select e.id,e.Name,e.JoinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_Code=d.Dept_Code
select e.id,e.Name,e.JoinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_Code=d.Dept_Code order by d.Dept_Name
select e.id,e.Name,e.JoinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_Code=d.Dept_Code where d.Dept_Name='Admin' order by d.Dept_Name
select COUNT(e.id) from Employee e join Dept d on e.Dept_Code=d.Dept_Code where d.Dept_Name='Admin'