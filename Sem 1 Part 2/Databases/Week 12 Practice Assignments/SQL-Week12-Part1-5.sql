SELECT ProjectID, MIN(HoursWorked) AS 'MinimumHoursWorked', MAX(HoursWorked) AS 'MaximumHoursWorked'
FROM EMPLOYEE AS e
INNER JOIN ASSIGNMENT AS a
ON a.EmployeeNumber=e.EmployeeNumber
GROUP BY ProjectID