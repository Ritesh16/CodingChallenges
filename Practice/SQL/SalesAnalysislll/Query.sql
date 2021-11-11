SELECT p.product_id,
       p.product_name
FROM   product1 p
       JOIN sales1 s
         ON p.product_id = s.product_id
GROUP  BY p.product_id,
          p.product_name
HAVING Min(sale_date) >= '2019-01-01'
       AND Max(sale_date) <= '2019-03-31'

