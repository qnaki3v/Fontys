SELECT DISTINCT e.EmployeeNumber, FirstName,LastName,Department
FROM EMPLOYEE AS e
INNER JOIN ASSIGNMENT AS a
ON a.EmployeeNumber = e.EmployeeNumber
WHERE HoursWorked > 50