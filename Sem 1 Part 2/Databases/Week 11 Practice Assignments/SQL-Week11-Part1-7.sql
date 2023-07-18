SELECT ProjectID, Name, StartDate
FROM PROJECT AS p
INNER JOIN DEPARTMENT AS d
ON p.Department = d.DepartmentName
WHERE BudgetCode = 'BC-400-10'