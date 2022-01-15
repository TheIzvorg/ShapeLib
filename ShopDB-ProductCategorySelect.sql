use [ShopDB];
GO

SELECT p.[Name] as 'Product', c.[Name] as 'Category'
FROM [ProductCategory] pc
left join [Category] c ON pc.[CategoryId] = c.[Id]
left join [Product] p ON pc.[ProductId] = p.[Id]
