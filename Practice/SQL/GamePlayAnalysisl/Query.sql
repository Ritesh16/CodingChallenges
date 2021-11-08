Select player_id,min(event_Date) as first_login from Activity
group by player_id