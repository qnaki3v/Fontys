SELECT ProjectID, e.EmployeeNumber, LastName, FirstName, e.Phone
FROM ASSIGNMENT AS a
INNER JOIN EMPLOYEE AS e
ON a.EmployeeNumber = e.EmployeeNumber