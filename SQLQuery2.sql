CREATE TABLE products (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(50)
);
CREATE TABLE categories(
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(50)
);
CREATE TABLE products_categories(
	id INT PRIMARY KEY IDENTITY(1,1),
	product_id int,
	category_id int
)

INSERT INTO products (name) VALUES ('Banana');
INSERT INTO products (name) VALUES ('Laptop');
INSERT INTO products (name) VALUES ('Teapot');
INSERT INTO products (name) VALUES ('Ps5');

INSERT INTO categories (name) VALUES ('Fruits');
INSERT INTO categories (name) VALUES ('Gadgets');


INSERT INTO products_categories (product_id,category_id) values(1,1)
INSERT INTO products_categories (product_id,category_id) values(2,2)
INSERT INTO products_categories (product_id,category_id) values(4,2)

SELECT 
    p.name AS ProductName,
    c.name AS CategoryName
FROM 
    products p
LEFT JOIN 
    products_categories pc ON p.id = pc.product_id
LEFT JOIN 
    categories c ON pc.category_id = c.id;
