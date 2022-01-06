CREATE TABLE #Sales(
 OrderDate DATE,
 OrderMonth DATE,
 TotalDue MONEY,
 OrderRank INT
)

CREATE TABLE #AvgSalesMinusTop10(
 OrderMonth DATE,
 TotalSales MONEY,
)

CREATE TABLE #Purchases(
 OrderDate DATE,
 OrderMonth DATE,
 TotalDue MONEY,
 OrderRank INT
)

CREATE TABLE #AvgPurchasesMinusTop10(
 OrderMonth DATE,
 TotalPurchases MONEY,
)

INSERT INTO #Sales
SELECT 
       OrderDate
	  ,OrderMonth = DATEFROMPARTS(YEAR(OrderDate),MONTH(OrderDate),1)
      ,TotalDue
	  ,OrderRank = ROW_NUMBER() OVER(PARTITION BY DATEFROMPARTS(YEAR(OrderDate),MONTH(OrderDate),1) ORDER BY TotalDue DESC)
FROM AdventureWorks2019.Sales.SalesOrderHeader


INSERT INTO #AvgSalesMinusTop10 
SELECT
OrderMonth,
TotalSales = SUM(TotalDue)
FROM #Sales
WHERE OrderRank > 10
GROUP BY OrderMonth

INSERT INTO #Purchases
SELECT 
       OrderDate
	  ,OrderMonth = DATEFROMPARTS(YEAR(OrderDate),MONTH(OrderDate),1)
      ,TotalDue
	  ,OrderRank = ROW_NUMBER() OVER(PARTITION BY DATEFROMPARTS(YEAR(OrderDate),MONTH(OrderDate),1) ORDER BY TotalDue DESC)
FROM AdventureWorks2019.Purchasing.PurchaseOrderHeader

INSERT INTO #AvgPurchasesMinusTop10
SELECT
OrderMonth,
TotalPurchases = SUM(TotalDue)
FROM #Purchases
WHERE OrderRank > 10
GROUP BY OrderMonth


SELECT
A.OrderMonth,
A.TotalSales,
B.TotalPurchases

FROM #AvgSalesMinusTop10 A
	JOIN #AvgPurchasesMinusTop10 B
		ON A.OrderMonth = B.OrderMonth

ORDER BY 1


DROP TABLE #Sales
DROP TABLE #AvgSalesMinusTop10
DROP TABLE #Purchases
DROP TABLE #AvgPurchasesMinusTop10
