CREATE TABLE #Persons (
	BusinessEntityID INT,
	Title NVARCHAR(8),
	FirstName NVARCHAR(50),
	MiddleName NVARCHAR(50),
	LastName NVARCHAR(50),
	PhoneNumber NVARCHAR(20),
	PhoneNumberType NVARCHAR(10),
	EmailAddress NVARCHAR(100),
	PhoneNumberTypeId INT
)


INSERT INTO #Persons (
 BusinessEntityID,
 Title,
 FirstName,
 MiddleName,
 LastName
)
SELECT 
	BusinessEntityID,
	Title,
	FirstName,
	MiddleName,
	LastName
FROM Person.Person

UPDATE A
SET PhoneNumber = B.PhoneNumber
   , PhoneNumberTypeId = b.PhoneNumberTypeID
FROM #Persons A
JOIN Person.PersonPhone B
	ON A.BusinessEntityID = B.BusinessEntityID


UPDATE A
SET PhoneNumberType = B.Name
FROM #Persons A
JOIN Person.PhoneNumberType B
	ON A.PhoneNumberTypeId = B.PhoneNumberTypeID


UPDATE A
SET EmailAddress = B.EmailAddress
FROM #Persons A
JOIN Person.EmailAddress B
	ON A.BusinessEntityID = B.BusinessEntityID


SELECT * FROM #Persons

DROP TABLE #Persons