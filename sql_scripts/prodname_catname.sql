SELECT product_title, category_title FROM products AS p 
    LEFT JOIN products_categories AS pc ON p.product_id = pc.product_id
    LEFT JOIN categories AS c ON c.category_id = pc.category_id;
