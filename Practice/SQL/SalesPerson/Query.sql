SELECT 
s.Name
FROM SalesPerson s
WHERE s.Sales_ID NOT IN 
	(SELECT o.Sales_Id FROM Orders o
	 LEFT JOIN Company c 
		on o.Com_Id = c.Com_Id
	 WHERE c.Name = 'RED')


