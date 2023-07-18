SELECT EmployeeNumber, FirstName, LastName, Department
FROM EMPLOYEE
WHERE DEPARTMENT IN ('Administration', 'Accounting', 'Production', 'Legal')
ORDER BY Department, LastName