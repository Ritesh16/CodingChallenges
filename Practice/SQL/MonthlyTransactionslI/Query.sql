with cte as (
	Select id as trans_id, country,state, amount,trans_date from Transactions where state = 'approved'
	union all
	Select cr.trans_id, tr.country, 'back' as 'state', tr.amount, cr.trans_Date  from Chargebacks cr 
	join Transactions tr on cr.trans_id = tr.id
)
Select 
	distinct  left(trans_date, 7) as month, country,
	Sum(case when state = 'approved' then 1 else 0 end) as approved_count,
	Sum(case when state = 'approved' then amount else 0 end) as approved_amount,
	Sum(case when state = 'back' then 1 else 0 end) as chargeback_count,
	Sum(case when state='back' then amount else 0 end) as chargeback_amount
From cte
group by  left(trans_date, 7), country
order by  left(trans_date, 7)