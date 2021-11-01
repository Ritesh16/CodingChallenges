SELECT
    Name
FROM
    Employee1 AS t1 JOIN
    (SELECT
        ManagerId
    FROM
        Employee1
    GROUP BY ManagerId
    HAVING COUNT(ManagerId) >= 5) AS t2
    ON t1.id = t2.ManagerId