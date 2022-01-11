CREATE PROCEDURE spOrdersAboveThreshold(@Threshold DECIMAL, @StartYear INT)
AS
BEGIN
	SELECT * FROM Sales.SalesOrderHeader 
	WHERE TotalDue > @Threshold 
		AND YEAR(OrderDate) 
		BETWEEN @StartYear AND @EndYear 
END

EXEC spOrdersAboveThreshold 100, 2014,2020