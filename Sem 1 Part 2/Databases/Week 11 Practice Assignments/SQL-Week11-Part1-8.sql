SELECT a.EmployeeNumber, FirstName, LastName, p.ProjectID ,p.Name ,HoursWorked
FROM ASSIGNMENT AS a
INNER JOIN EMPLOYEE AS e
ON a.EmployeeNumber = e.EmployeeNumber
INNER JOIN DEPARTMENT AS d
ON d.DepartmentName = e.Department
INNER JOIN PROJECT AS p
ON p.ProjectID = a.ProjectID
WHERE d.DepartmentName = 'Administration'