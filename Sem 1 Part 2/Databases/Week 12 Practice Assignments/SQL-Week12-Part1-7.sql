SELECT OrderNumber, AVG(Price) AS 'AvgPrice'
FROM ORDER_ITEM
GROUP BY OrderNumber