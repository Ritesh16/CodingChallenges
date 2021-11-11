with cte as(
  select a.action_date, 
           100.00* count(distinct r.post_id)/count(distinct a.post_id) as rate
    from Actions a left join Removals r
    on a.post_id = r.post_id
    where extra = 'spam'
    group by action_date)
    
select  round(avg(rate), 2) as average_daily_percent 
from cte


With cte as
(Select 
	a.action_Date, 100.00 * count(distinct r.post_id)/count(distinct a.post_id) as rate
From Actions a
Left Join Removals r on a.post_id = r.post_id
where a.extra = 'spam'
group by a.action_date
)

Select round(avg(rate), 2) as 'average_daily_percent' from cte
