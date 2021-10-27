Select project_id from
(Select 
project_id,
RANK() over(order by count(employee_id) desc) rk
from PRoject
group by project_id) d
where d.rk = 1