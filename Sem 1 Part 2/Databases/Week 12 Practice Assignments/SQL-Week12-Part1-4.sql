SELECT Department, COUNT(*) AS 'NumberOfDepProjects'
  FROM PROJECT
  GROUP BY Department
