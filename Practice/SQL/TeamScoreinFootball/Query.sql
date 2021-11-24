select t.team_id,t.team_name, case when sum(xx.results) is null then 0 else sum(xx.results) end as num_points from (
select host_team as team_id, case when host_goals > guest_goals then 3 when host_goals = guest_goals then 1 else 0 end as results
from Matches a 

union all

select guest_team as team_id, case when guest_goals > host_goals then 3 when host_goals = guest_goals then 1 else 0 end as results
from Matches b 
)xx right join Teams t
on xx.team_id = t.team_id
group by t.team_id,t.team_name
order by case when sum(xx.results) is null then 0 else sum(xx.results) end desc, t.team_id asc