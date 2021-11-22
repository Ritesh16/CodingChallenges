Select top 1 person_name
from 
(Select person_name , turn, sum(Weight) over (order by turn) as Total
from queue) t
where t.Total<=1000
order by turn desc

