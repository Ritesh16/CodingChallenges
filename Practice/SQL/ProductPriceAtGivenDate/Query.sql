/****** Script for SelectTopNRows command from SSMS  ******/
with cte as
(
select  product_id, new_price as price, change_Date,row_number() over(partition by product_id order by change_date desc) as rownumber from products where change_Date<='20190816'
   
)

select distinct p.product_id, isnull(c.price,10) as price from products p
left join cte c
on p.product_id = c.product_id
and c.rownumber=1