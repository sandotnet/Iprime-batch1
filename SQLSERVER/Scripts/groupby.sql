select * from authors
--couting authors per each state
select state,COUNT(*) as 'Authors Count' from authors group by state
----couting authors per each state minimum 2 authors from each state
select state,count(*) as 'Authors Count' from authors group by state having COUNT(*)>1
select state,count(*) as 'Authors Count' from authors group by state having COUNT(*)>1 order by [Authors Count]
select * from sales
--get sum of the qty of each store
select stor_id,sum(qty) as 'Total qty' from sales group by stor_id
--get sum of the qty of each store minimum sum is 50
select stor_id,sum(qty) as 'Total qty' from sales group by stor_id having SUM(qty)>50
select state,COUNT(*) as 'Authors Count' from authors group by state
select state,COUNT(*) as 'Authors Count' from authors where contract=1 group by state 
select state,COUNT(*) as 'Authors Count' from authors where contract=1 group by state order by [Authors Count]

