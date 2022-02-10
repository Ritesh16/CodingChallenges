select isnull((select salary from(
    select *,dense_rank() over(order by salary desc) as rk from employee
) tmp
where rk = 2 group by salary),null) as 'SecondHighestSalary'


select max(Salary) AS SecondHighestSalary from Employee
where salary < (Select Max(Salary) from Employee)