select * from employee
select * from sales
select Max(qty) from sales
select * from sales where qty=Max(qty)
select * from sales where qty=(select Max(qty) from sales)
select * from sales where qty=(select Min(qty) from sales)
select Max(ord_date) from sales
select * from sales where ord_date=(select MAX(ord_date) from sales)
select count(*) from sales where ord_date=(select MAX(ord_date) from sales)
select * from sales where qty<(select Max(qty) from sales)
select * from sales where qty>(select Min(qty) from sales)
select * from stores
select * from sales where stor_id=(select stor_id  from stores where  stor_name='Bookbeat')
select * from sales where stor_id in(select stor_id  from stores where  stor_name in('Bookbeat','Fricative Bookshop','News & Brews'))
select * from sales where stor_id=7131
select * from sales where qty>all(select qty from sales where stor_id=7131)
select * from sales where qty>(select max(qty) from sales where stor_id=7131)