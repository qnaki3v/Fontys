SELECT ProjectID, Name, StartDate
FROM PROJECT
WHERE Name LIKE '%Q3%'
AND StartDate >= '2008-08-01' AND StartDate < '2008-09-01'