--Count,Max,Min,Sum and AVG
select * from sales
select count(*) as [Count] from sales
select COUNT(*) as [Result] from sales where qty>20
select Min(Qty) from sales
select Max(Qty) from sales
select Sum(Qty) as Total from sales
select Avg(Qty) as [Avg] from sales
select Max(ord_date) from sales
select Min(ord_date) from sales