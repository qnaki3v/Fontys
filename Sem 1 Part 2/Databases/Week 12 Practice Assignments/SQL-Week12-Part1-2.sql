SELECT SUM(MaxHours) AS 'TotalMaxHoursForMarketingDepProjects'
  FROM PROJECT
  WHERE DEPARTMENT = 'Marketing'