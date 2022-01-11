CREATE FUNCTION ufnIntegerPercent(@number1 INT, @number2 INT)
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @RESULT FLOAT
	SET @RESULT = (@number1 * 1.0) / @number2

	RETURN FORMAT(@RESULT, 'P')
END

DECLARE @maxvacation INT = (SELECT MAX(VacationHours) FROM HumanResources.Employee)

SELECT 
 BusinessEntityID
,JobTitle
, VacationHours
, [PercentOfMaxVacation] = dbo.ufnIntegerPercent(A.VacationHours, @maxvacation)
FROM HumanResources.Employee A



