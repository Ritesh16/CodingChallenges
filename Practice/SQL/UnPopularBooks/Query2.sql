Select 
b.book_id, b.name
from 
Books b
left join BookOrders bo on b.book_id = bo.book_id and bo.dispatch_date between dateadd(yy,-1,'2019-06-23')  and '2019-06-23'
where b.available_from < DateADD(mm,-1,'2019-06-23') 
group by b.book_id,b.name
having sum(isnull(bo.quantity,0)) < 10
order by 1
