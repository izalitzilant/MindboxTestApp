CREATE TABLE IF NOT EXISTS products(
    product_id INT PRIMARY KEY NOT NULL,
    product_title VARCHAR(50) NOT NULL,
    product_description VARCHAR(100)
);

CREATE TABLE IF NOT EXISTS categories(
    category_id INT PRIMARY KEY NOT NULL,
    category_title VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS products_categories(
    product_id INT REFERENCES products ON DELETE CASCADE,
    category_id INT REFERENCES categories ON DELETE CASCADE,
    PRIMARY KEY (product_id, category_id)
);

INSERT INTO products (product_id, product_title, product_description) VALUES
(1, 'Laptop', 'A high performance laptop'),
(2, 'Smartphone', 'A latest model smartphone'),
(3, 'Headphones', 'Noise-cancelling headphones'),
(4, 'Monitor', '4K UHD monitor'),
(5, 'Keyboard', 'Mechanical keyboard'),
(6, 'Mouse', 'Wireless mouse'),
(7, 'Webcam', '1080p HD webcam'),
(8, 'Printer', 'All-in-one printer'),
(9, 'Tablet', '10-inch display tablet'),
(10, 'Smartwatch', 'Fitness tracking smartwatch');


INSERT INTO categories (category_id, category_title) VALUES
(1, 'Electronics'),
(2, 'Computers'),
(3, 'Accessories');

INSERT INTO products_categories (product_id, category_id) VALUES
(1, 1),
(1, 2),
(2, 1),
(3, 1),
(3, 3),
(4, 1),
(4, 2),
(5, 3);