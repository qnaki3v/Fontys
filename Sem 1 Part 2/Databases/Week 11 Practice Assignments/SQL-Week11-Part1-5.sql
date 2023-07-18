SELECT DISTINCT e.EmployeeNumber, FirstName, LastName
FROM EMPLOYEE AS e
INNER JOIN ASSIGNMENT AS a
ON e.EmployeeNumber = a.EmployeeNumber