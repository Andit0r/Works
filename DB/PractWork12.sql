-- task1
SELECT *
FROM Book;

-- task2
SELECT Surname + ' ' + Name AS FullName
FROM Author;

-- task3
SELECT Country
FROM Author
GROUP BY Country;

-- task4
SELECT BookId
	, Title
	, Price * '0.95' AS [Цена со скидкой 5%]
FROM Book
ORDER BY Price DESC, Title;

-- task5
SELECT AuthorId
	, Title
	, COUNT(*) AS [Количество книг]
FROM Book
GROUP BY Title, AuthorId

-- task6
SELECT COUNT(*) AS [Количество книг]
	, MIN(Price) AS [Минимальная цена]
	, MAX(Price) AS [Максимальная цена]
	, AVG(Price) AS [Средняя цена]
FROM Book

-- task7
SELECT Genre AS Жанр
	, MIN(Price) AS [Минимальная цена]
	, MAX(Price) AS [Максимальная цена]
	, AVG(Price) AS [Средняя цена]
	, COUNT(*) AS [Количество книг]
FROM Book
GROUP BY Genre