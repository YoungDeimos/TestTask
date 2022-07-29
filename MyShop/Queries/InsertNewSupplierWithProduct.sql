USE MyShop

INSERT INTO Suppliers (SupplierName, City, Country)
VALUES ('Norske Meierier', 'Lviv', 'Ukraine')


INSERT INTO Products (ProductName, SupplierID, CategoryID, Price)
VALUES (
    'Green tea',
    SELECT SupplierID FROM Supplier WHERE SupplierName = 'Norske Meierier',
    SELECT CategoryID FROM Categories WHERE CategoryName = 'Beverages', 
    10.00)