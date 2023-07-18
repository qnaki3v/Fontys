SELECT p.ProjectID, p.Name, e.Department, d.Phone AS 'Department Phone', e.LastName, e.FirstName, e.Phone AS 'Employee Phone'
FROM ASSIGNMENT AS a
INNER JOIN PROJECT AS p
ON a.ProjectID = p.ProjectID
INNER JOIN EMPLOYEE AS e
ON a.EmployeeNumber = e.EmployeeNumber
INNER JOIN DEPARTMENT AS d
ON e.Department = d.DepartmentName
WHERE p.Department = 'Marketing'
ORDER BY ProjectID