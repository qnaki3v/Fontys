SELECT EmployeeNumber, FirstName, LastName, Email, DepartmentName, OfficeNumber
FROM EMPLOYEE AS e
INNER JOIN DEPARTMENT AS d
ON d.DepartmentName = e.Department
ORDER BY DepartmentName