select * from Employee
select e.id,e.Name,e.JoinDate,e.salary,d.Dept_Name from Employee e left outer join Dept d on e.Dept_Code=d.Dept_Code
select e.id,e.Name,e.JoinDate,e.salary,d.Dept_Name from Employee e right outer join Dept d on e.Dept_Code=d.Dept_Code
select e.id,e.Name,e.JoinDate,e.salary,d.Dept_Name from Employee e full outer join Dept d on e.Dept_Code=d.Dept_Code
--cross join
select e.Name,d.dept_Name from Employee e,Dept d