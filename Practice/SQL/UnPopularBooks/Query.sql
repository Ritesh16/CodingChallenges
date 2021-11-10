DECLARE @GetDate DATE= '2019-06-23';

SELECT
       book_id,
       name
FROM   Books
WHERE  available_from < DATEADD(month, -1, @GetDate)
       AND book_id NOT IN(SELECT
                                 book_id
                          FROM   BookOrders
                          WHERE  dispatch_date > DATEADD(year, -1, @GetDate)
                          GROUP BY
                                   book_id
                          HAVING SUM(quantity) >= 10);