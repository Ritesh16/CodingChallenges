Select id, 'Root' as 'type' 
from tree
where p_id is null
union
Select id, 'Inner' as 'type'
from tree
where id in
(select distinct p_id from tree
where p_id is not null)
and p_id is not null
union
Select id, 'Leaf' as 'type'
from Tree
where id not in
(Select distinct p_id from tree
where p_id is not null) and 
p_id is not null