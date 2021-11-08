Select cast(count(distinct nxt.player_id) / (count(distinct src.player_id) * 1.0) as decimal(18,2)) as fraction from (Select player_id, min(event_date) as event_date from activity group by player_id) as src
left join Activity nxt
 on nxt.player_id = src.player_id
 and dateadd(day, -1, nxt.event_date) = src.event_date

