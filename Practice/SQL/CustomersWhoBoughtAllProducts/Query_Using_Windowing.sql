SELECT DISTINCT customer_id
FROM (
    
SELECT *, MAX(CT) OVER(PARTITION BY customer_id) AS MX
    
FROM (  
SELECT *, DENSE_RANK() OVER(PARTITION BY customer_id ORDER BY product_key) AS CT
FROM Customer
WHERE product_key IN (SELECT DISTINCT product_key FROM Product2)) AS temp1
    
 ) AS temp2
WHERE MX = (SELECT COUNT(DISTINCT product_key) FROM Product2)