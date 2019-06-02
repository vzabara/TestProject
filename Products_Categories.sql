select p.ProductName, c.CategoryName from dbo.Pruducts p 
left join dbo.Product_Category pc on p.ProductID = pc.ProductID
left join dbo.Categories c on c.CategoryID = pc.CategoryID
