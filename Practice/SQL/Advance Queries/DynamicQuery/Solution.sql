CREATE PROCEDURE NameSearch (@NameToSearch VARCHAR(50), @SearchPattern VARCHAR(50), @MatchType INT)
AS
BEGIN
	DECLARE @DynamicQuery VARCHAR(MAX)
	DECLARE @Column VARCHAR(20)
	IF @NameToSearch = 'first'
	BEGIN
		SET @Column = 'FirstName'
	END
	ELSE IF @NameToSearch = 'middle'
	BEGIN
		SET @Column = 'MiddleName'
	END
	ELSE
	BEGIN
		SET @Column = 'LastName'
	END

	SET @DynamicQuery = 'SELECT * FROM Person.Person WHERE ' + @Column 

	IF @MatchType = 1
	BEGIN 
		SET @DynamicQuery = @DynamicQuery + ' = ' + '''' +  @SearchPattern + ''''
	END

   IF @MatchType  = 2
   BEGIN 
		SET @DynamicQuery = @DynamicQuery + ' LIKE ' + '''' +  @SearchPattern + '%' + ''''
   END

   IF @MatchType  = 3
   BEGIN 
		SET @DynamicQuery = @DynamicQuery + ' LIKE ' + '''' + '%' +  @SearchPattern + ''''
   END

   IF @MatchType  = 4
   BEGIN 
		SET @DynamicQuery = @DynamicQuery + ' LIKE ' + '''' + '%' +  @SearchPattern + '%' + ''''
   END


   EXEC(@DynamicQuery)

END


exec NameSearch 'last','ee',4