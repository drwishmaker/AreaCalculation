CREATE TABLE Products (
	Id INTEGER PRIMARY KEY,
	Name TEXT
);

CREATE TABLE Categories (
	Id INTEGER PRIMARY KEY,
	Name TEXT
);

CREATE TABLE ProductCategories (
  ProductId INTEGER,
  CategoryId INTEGER,
  FOREIGN KEY (ProductId) REFERENCES Products(Id),
  FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
  PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products VALUES (1, 'Pencil');
INSERT INTO Products VALUES (2, 'CLR via C#');
INSERT INTO Products VALUES (3, 'Copybook');
INSERT INTO Products VALUES (4, 'marmalade');

INSERT INTO Categories VALUES (1, 'Book');
INSERT INTO Categories VALUES (2, 'Office supplies');

INSERT INTO ProductCategories VALUES (2, 1);
INSERT INTO ProductCategories VALUES (1, 2);
INSERT INTO ProductCategories VALUES (3, 2);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
