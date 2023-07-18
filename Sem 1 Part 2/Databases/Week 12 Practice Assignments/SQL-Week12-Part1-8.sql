SELECT SUM(ExtendedPrice) AS 'Revenue'
FROM ORDER_ITEM AS oi
INNER JOIN SKU_DATA AS sd
ON oi.SKU = sd.SKU
WHERE Department = 'Water Sports'
