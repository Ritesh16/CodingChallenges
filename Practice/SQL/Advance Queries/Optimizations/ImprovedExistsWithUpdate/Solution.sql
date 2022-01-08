CREATE TABLE #Purchases (
	PurchaseOrderID INT,
	OrderDate DATE,
	TotalDue MONEY,
	RejectedQty INT
)

INSERT INTO #Purchases
( PurchaseOrderID
 , OrderDate
 , TotalDue
 )
SELECT
PurchaseOrderID,
OrderDate,
TotalDue

FROM AdventureWorks2019.Purchasing.PurchaseOrderHeader

UPDATE A
SET 
	A.RejectedQty = B.RejectedQty
FROM #Purchases A
JOIN Purchasing.PurchaseOrderDetail B
	ON A.PurchaseOrderID = B.PurchaseOrderID
WHERE B.RejectedQty > 5

SELECT * FROM #Purchases WHERE RejectedQty IS NOT NULL

DROP TABLE #Purchases