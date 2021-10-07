Select distinct a.seat_id
from Cinema a
join Cinema b
on abs(a.seat_id-b.seat_id) = 1
and a.Free = 1 and b.Free = 1
order by a.Seat_Id;

 Select Seat_Id
 from 
(Select 
	Seat_Id,
	Free,
	LEAD(Free,1) Over(Order by Seat_Id) as Free_Lead,
	LAG(Free,1) Over(Order by Seat_Id) as Free_Lag
 from Cinema) as t
 where (t.Free = 1 and t.Free_Lag = 1) or (t.Free = 1 and t.Free_Lead = 1)