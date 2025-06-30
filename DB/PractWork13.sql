-- task1
SELECT *
FROM Book
WHERE (Genre = N'проза') AND
	Price BETWEEN 500 AND 1000;

-- task 2
SELECT Surname, [Name], Phone
FROM Customer
WHERE (Phone IS NOT NULL)

-- task3
SELECT *
FROM Book
WHERE Title LIKE '%ри%';

-- task4
SELECT Title
FROM Book
WHERE Title LIKE 'Д%';

-- task5
SELECT Country, COUNT(*) AS AuthorsCount
FROM Author
GROUP BY Country
HAVING (COUNT(*) > 1)

-- task6
SELECT OrderId, SUM(Quantity) AS BooksCount
FROM OrderedBook
GROUP BY OrderId
HAVING (SUM(Quantity) > 5)

-- task7
SELECT AuthorId, Title, COUNT(*) AS BooksCount
FROM Book
GROUP BY AuthorId, Title
HAVING (COUNT(*) > 1)