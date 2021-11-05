SELECT 
	player_id,
	event_date,
	games_played_so_far = Sum(games_played) Over(PArtition by player_id order by event_Date)
FROM Activity