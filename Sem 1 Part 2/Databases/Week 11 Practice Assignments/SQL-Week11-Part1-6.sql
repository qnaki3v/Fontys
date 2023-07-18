SELECT ProjectID, Name, StartDate, Department, BudgetCode
FROM PROJECT AS p
INNER JOIN DEPARTMENT AS d
ON p.Department = d.DepartmentName
