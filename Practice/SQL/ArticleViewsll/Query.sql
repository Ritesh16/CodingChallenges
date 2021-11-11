Select 
distinct viewer_id as "id"
From [Views]
group by view_date, viewer_id
having count(distinct article_id) > 1
