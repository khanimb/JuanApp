SET IDENTITY_INSERT Categories ON;
INSERT INTO Categories (Id, Name) VALUES (1, 'Men Shoes'), (2, 'Women Shoes'), (3, 'Kids Shoes');
SET IDENTITY_INSERT Categories OFF;

SET IDENTITY_INSERT Products ON;
INSERT INTO Products (Id, Name, Price, DiscountPrice, Description, ImageUrl, IsDeleted, IsNew, CreatedAt, CategoryId) 
VALUES 
(1, 'Leather Mens Slipper', 80.0, 70.0, 'Some description', '/assets/img/product/product-1.jpg', 0, 1, '2024-01-01', 1),
(2, 'Quickiin Mens shoes', 80.0, 70.0, 'Some description', '/assets/img/product/product-2.jpg', 0, 1, '2024-01-01', 1),
(3, 'Rexpo Womens shoes', 80.0, 70.0, 'Some description', '/assets/img/product/product-3.jpg', 0, 1, '2024-01-01', 2);
SET IDENTITY_INSERT Products OFF;