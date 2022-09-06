CREATE DATABASE Shop
GO

USE Shop
GO

CREATE TABLE Products
(
    Id   uniqueidentifier PRIMARY KEY,
    Name nvarchar(200) NOT NULL
)
    GO

CREATE TABLE Categories
(
    Id   uniqueidentifier PRIMARY KEY,
    Name nvarchar(200) NOT NULL
)
    GO

CREATE TABLE ProductsCategories
(
    ProductId  uniqueidentifier NOT NULL,
    CategoryId uniqueidentifier NOT NULL,
    CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES Products (Id),
    CONSTRAINT FK_CategoryId FOREIGN KEY (CategoryId) REFERENCES Categories (Id),
)
    GO

INSERT INTO Products (Id, Name)
VALUES ('6471c9a4-f69e-4cb6-8c39-f5ec4c074808', N'Table'),
       ('0d54720b-71cc-41c1-adbb-0e6b2a2374aa', N'Chair'),
       ('773e9815-f21d-461b-9eeb-a03b072d3df2', N'Sofa'),
       ('a7e73b35-41b3-4253-9832-3e43d387bcc9', N'Lamp'),
       ('f12bf7c8-ddd0-4342-a495-d02ea3c184c1', N'Bottle')
GO

INSERT INTO Categories(Id, Name)
VALUES ('907c665e-2c6f-46c0-a89c-804820bde410', N'Furniture'),
       ('96a33563-3742-426c-a0d9-cada0bcc650b', N'Lightning'),
       ('dfd4c4c7-a05e-4fe8-bcf3-85de4d5f0be4', N'House')
GO

INSERT INTO ProductsCategories (ProductId, CategoryId)
VALUES ('0d54720b-71cc-41c1-adbb-0e6b2a2374aa', '907c665e-2c6f-46c0-a89c-804820bde410'),
       ('a7e73b35-41b3-4253-9832-3e43d387bcc9', '96a33563-3742-426c-a0d9-cada0bcc650b'),
       ('773e9815-f21d-461b-9eeb-a03b072d3df2', '907c665e-2c6f-46c0-a89c-804820bde410'),
       ('773e9815-f21d-461b-9eeb-a03b072d3df2', 'dfd4c4c7-a05e-4fe8-bcf3-85de4d5f0be4'),
       ('6471c9a4-f69e-4cb6-8c39-f5ec4c074808', '907c665e-2c6f-46c0-a89c-804820bde410')
GO

SELECT P.Name AS ProductName, C.Name AS CategoryName
FROM Products P
         LEFT JOIN ProductsCategories PC ON P.Id = PC.ProductId
         LEFT JOIN Categories C ON PC.CategoryId = C.Id
ORDER BY ProductName, CategoryName
    GO
