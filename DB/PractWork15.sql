-- task1
UPDATE Book
SET Price = ROUND(Price, -1)
FROM [Book]

SELECT *
FROM Book;

--task2
SELECT MONTH(OrderDatetime) As Month
	, YEAR(OrderDatetime) AS Year
	, COUNT(*) AS OrderCount
FROM [Order]
GROUP BY YEAR(OrderDatetime), MONTH(OrderDatetime)
ORDER BY YEAR(OrderDatetime) DESC,
	MONTH(OrderDatetime) DESC;

-- task3
UPDATE Book
SET Price *= 0.9
WHERE BookId NOT IN(SELECT DISTINCT OrderedBook.BookId
					FROM [Order] JOIN
                         OrderedBook ON [Order].OrderId = OrderedBook.OrderId
					WHERE (YEAR(OrderDatetime) = YEAR(GETDATE())))

SELECT *
FROM Book

--task4
SELECT CustomerId, UPPER(Concat(Surname, ' ', LEFT(Name, 1), '.')) AS 'CustomerInfo'
FROM Customer

--task5
UPDATE Customer
SET Login = REPLACE(TRIM(Login), ' ','_');


SELECT *
FROM Customer

--task6
SELECT CustomerId
	, Login
	, Surname
	, Name
	, NULLIF(Address, '') AS Address
	, ISNULL(Phone, '-') AS Phone
FROM Customer

--task7
SELECT DISTINCT STRING_AGG(Title, ',') AS Titles
FROM Book
GROUP BY AuthorId
ORDER BY Titles

--task8
SELECT OrderId, STRING_AGG(CONCAT(Surname
						, ' '
						, [Name]
						, '-'
						, Book.Title)
						, ', ') AS 'AuthorsAndBooks'
FROM OrderedBook JOIN
    Book ON OrderedBook.BookId = Book.BookId JOIN
    Author ON Book.AuthorId = Author.AuthorId
GROUP BY OrderedBook.OrderId

--task9
SELECT ROW_NUMBER() OVER (ORDER BY Title) AS 'Row'
	, *
FROM Book

--task10
SELECT ROW_NUMBER() OVER (PARTITION BY Genre ORDER BY Title) AS 'Row'
	, Title
	, Genre
FROM Book
