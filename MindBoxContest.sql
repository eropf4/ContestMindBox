SELECT Products.Name, Categories.Name from Products
LEFT JOIN ProductsCategories ON ProductsCategories.Product_Id = Products.Id
LEFT JOIN Categories ON Categories.Id = ProductsCategories.Categories_Id
-- Для связи таблиц многие ко многим, предполагается вспомогательная таблица ProductsCategories
-- После этого используем оператор Left Join, чтобы соеденить таблицу, не исключая факт, что у некоторых продуктов не будет категории.