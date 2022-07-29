USE MyShop

SELECT SUM(Price) as SumFromUsa 
FROM Products p
INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
WHERE Country = 'USA'