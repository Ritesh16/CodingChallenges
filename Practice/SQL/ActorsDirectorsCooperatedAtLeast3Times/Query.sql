SELECT actor_id,director_id  FROM ActorDirector
GROUP BY actor_id, director_id
having count(director_id) > 2
