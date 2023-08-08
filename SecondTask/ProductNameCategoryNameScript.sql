SELECT p.Name, c.Name FROM Products p
LEFT OUTER JOIN ProductCategories pc ON p.Id = pc.ProductId 
LEFT OUTER JOIN Categories c ON c.Id = pc.CategoryId