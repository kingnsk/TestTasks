CREATE TABLE Products (
	Id INT PRIMARY KEY NOT NULL,
	CategoryId INT NOT NULL,
	"ProductName" VARCHAR(20) NOT NULL
	);

INSERT INTO Products
VALUES
	(1, 1, 'Sneakers'),
	(2, 2, 'Apple'),
	(3, 3, 'Cream'),
	(4, 4, 'Milk'),
	(5, 2, 'Orange'),
	(6, 1, 'Sandals'),
	(7, 5, 'Beer');


CREATE TABLE Categories (
	Id INT PRIMARY KEY NOT NULL,
	"CategoryName" VARCHAR(20) NOT NULL
);

INSERT INTO Categories
VALUES
	(1, 'Shoes'),
	(2, 'Fruits'),
	(3, 'Cosmetics');

SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN Categories ON Products.CategoryId = Categories.Id;
