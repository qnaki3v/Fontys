SELECT p.ProjectID, p.Name AS 'ProjectName', p.Department AS 'ProjectDepartment', d.Phone AS 'DepartmentPhone', e.EmployeeNumber, e.LastName, e.FirstName, e.Phone AS 'Employee Phone'
FROM ASSIGNMENT AS a
INNER JOIN PROJECT AS p
ON a.ProjectID = p.ProjectID
INNER JOIN EMPLOYEE AS e
ON a.EmployeeNumber = e.EmployeeNumber
INNER JOIN DEPARTMENT AS d
ON e.Department = d.DepartmentName
ORDER BY p.ProjectID