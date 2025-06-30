-- task1
SELECT Book.BookId
	, Book.Title
	, Author.Surname
	, Author.Name
	, Book.Price
FROM Author JOIN
	Book ON Author.AuthorId = Book.AuthorId

-- task2
SELECT OrderedBook.OrderId
	, OrderedBook.BookId
	, Book.Title
	, Author.Surname
	, Author.Name
	, Book.Price
	, OrderedBook.Quantity
	, OrderedBook.Quantity * Book.Price AS BooksCost
FROM OrderedBook JOIN
     Book ON OrderedBook.BookId = Book.BookId JOIN
     Author ON Book.AuthorId = Author.AuthorId

-- task3
SELECT [Order].OrderId, [Order].OrderDatetime, SUM(Book.Price * OrderedBook.Quantity) AS OrderCost
FROM [Order] JOIN
     OrderedBook ON [Order].OrderId = OrderedBook.OrderId JOIN
     Book ON OrderedBook.BookId = Book.BookId
GROUP BY [Order].OrderId, [Order].OrderDatetime
ORDER BY [Order].OrderDatetime DESC

-- task4
SELECT Customer.CustomerId
	, Customer.Login
	, COUNT([Order].OrderId) AS OrderCount
FROM Customer LEFT JOIN
     [Order] ON Customer.CustomerId = [Order].CustomerId
GROUP BY Customer.CustomerId, Customer.Login

-- task5
SELECT *
FROM [Order]
WHERE OrderId NOT IN (SELECT DISTINCT OrderId FROM OrderedBook);

-- task6
SELECT *
FROM Customer
WHERE CustomerId IN (SELECT DISTINCT CustomerId
					FROM [Order])

-- task7
SELECT Author.Surname
	, Author.Name
	, 'Автор' AS 'Тип'
FROM Author
UNION
SELECT Surname
	, [Name]
	, 'Заказчик'
FROM Customer
ORDER BY 1, 2
	