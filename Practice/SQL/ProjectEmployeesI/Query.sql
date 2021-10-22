
Select 
p.project_id, cast(avg(
         cast(e.experience_years as decimal(9,2)))
        as decimal(9,2))  as average_years 
from PRoject p
join Employee e on p.employee_id = e.employee_id
group by p.project_id
