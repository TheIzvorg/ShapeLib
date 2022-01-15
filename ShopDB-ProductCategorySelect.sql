use [ShopDB];
GO

SELECT p.[Name] as 'Продукт', c.[Name] as 'Категория'
FROM [ProductCategory] pc
left join [Category] c ON pc.[CategoryId] = c.[Id]
left join [Product] p ON pc.[ProductId] = p.[Id]