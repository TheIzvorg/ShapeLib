use [master];
IF EXISTS(SELECT [name] FROM master.sys.databases WHERE [name] = N'ShopDB')
BEGIN
	ALTER DATABASE [ShopDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	drop database [ShopDB]
END;
create database[ShopDB]
GO

use [ShopDB];
GO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'dbo' AND
				TABLE_NAME = N'ProductCategory' )
	drop table [ProductCategory];
GO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'dbo' AND
				TABLE_NAME = N'Category' )
	drop table [Category];
GO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'dbo' AND
				TABLE_NAME = N'Product' )
	drop table [Product];
GO

create table [Category]
(
[Id] int PRIMARY KEY IDENTITY(1,1),
[Name] nvarchar(100) UNIQUE NOT NULL
);
GO

create table [Product]
(
[Id] int PRIMARY KEY IDENTITY(1,1),
[Name] nvarchar(100) NOT NULL,
);
GO

create table [ProductCategory]
(
[Id] int PRIMARY KEY IDENTITY(1,1),
[ProductId] int NOT NULL,
[CategoryId] int,
FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]),
);
GO

INSERT INTO [Product]
([Name])
VALUES
('Product1'),
('Product2'),
('Product3');
GO

INSERT INTO [Category]
([Name])
VALUES
('Category1'),
('Category2'),
('Category3');
GO

INSERT INTO [ProductCategory]
([ProductId],[CategoryId])
VALUES
(1,1),
(1,2),
(3,3),
(2,null);
GO