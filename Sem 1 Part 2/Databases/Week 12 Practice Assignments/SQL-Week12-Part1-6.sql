SELECT OrderNumber, FORMAT(SUM(ExtendedPrice), 'C', 'fr-FR') AS 'TotalOrder'
FROM ORDER_ITEM
GROUP BY OrderNumber