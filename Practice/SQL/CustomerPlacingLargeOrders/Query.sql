Select top 1 Customer_number from Orders
group by customer_number
order by COUNT(Order_number) desc