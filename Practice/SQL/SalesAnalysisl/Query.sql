select seller_id from
(select seller_id, rank() over(order by sum(price) desc) as rank
from sales1 group by seller_id) b
where rank = 1