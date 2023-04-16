CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"ProductName" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Energy Drink'),
	(2, 'Banana'),
	(3, 'Cheese'),
	(4, 'Orange'),
	(5, 'Bacon'),
	(6, 'Apple Juice'),
	(7, 'Milk');

CREATE TABLE Category (
	Id INT PRIMARY KEY,
	"CategoryName" TEXT
);

INSERT INTO Category
VALUES
	(1, 'Drink'),
	(2, 'Fruit'),
	(3, 'Dairy Product'),
	(4, 'Meat');

CREATE TABLE ProductsCategory (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY (ProductId, CategoryId)
);


INSERT INTO ProductsCategory 
VALUES
	(1,1),
	(2,2),
	(3,3),
	(4,2),
	(5,4),
	(6,1),
	(7,2),
	(7,1);

SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductsCategory PC ON P.id = PC.ProductId
LEFT JOIN Category C ON PC.CategoryId = C.id
