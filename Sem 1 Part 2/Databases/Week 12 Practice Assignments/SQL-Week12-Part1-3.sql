SELECT AVG(Cast(MaxHours AS Float)) AS 'TotalMaxHoursForMarketingDepProjects'
  FROM PROJECT
  WHERE DEPARTMENT = 'Marketing'