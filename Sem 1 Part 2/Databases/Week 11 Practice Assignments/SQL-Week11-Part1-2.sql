SELECT a.ProjectID, p.Name AS 'ProjectName', p.Department AS 'ProjectDepartment', e.EmployeeNumber, LastName,FirstName,e.Phone
FROM ASSIGNMENT AS a
INNER JOIN PROJECT AS p
ON a.ProjectID = p.ProjectID
INNER JOIN EMPLOYEE AS e
ON a.EmployeeNumber = e.EmployeeNumber
ORDER BY a.ProjectID