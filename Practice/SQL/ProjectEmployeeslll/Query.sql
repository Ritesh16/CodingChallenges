with cte as (

    select p.project_id, max(experience_years) max_exp   from Project p join Employee e on e.employee_id = p.employee_id
    group by p.project_id
    )
    
    select distinct p.project_id, p.employee_id from Project p 
                            join cte ex on ex.project_id = p.project_id
                            join Employee e on e.experience_years  = ex.max_exp and e.employee_id = p.employee_id
