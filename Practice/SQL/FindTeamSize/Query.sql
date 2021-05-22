/* Write your T-SQL query statement below */
SELECT employee_id, T.SIZE AS team_size
FROM Employee AS E
LEFT JOIN
(SELECT TEAM_ID, COUNT(TEAM_ID) AS SIZE FROM Employee GROUP BY TEAM_ID) AS T 
ON E.team_id = T.TEAM_ID
GROUP BY employee_id,T.SIZE;