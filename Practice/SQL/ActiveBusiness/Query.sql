select business_id from 
(
select  * , avg(occurences) over(partition by event_type ) as e_avg from 
events) a where occurences>e_avg
group by business_id having count(event_type)>1
