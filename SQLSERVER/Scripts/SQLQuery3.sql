create table Dept(Dept_Code char(5) primary key,Dept_Name varchar(30) unique not null)
create table Employee(Id int primary key,Name varchar(30),JoinDate Date default getdate(),
Salary int check(Salary>0), Dept_Code char(5)
constraint Dept_Code_FK Foreign key(Dept_Code) References Dept(Dept_Code) on delete cascade)

