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
	, Price * '0.95' AS [���� �� ������� 5%]
FROM Book
ORDER BY Price DESC, Title;

-- task5
SELECT AuthorId
	, Title
	, COUNT(*) AS [���������� ����]
FROM Book
GROUP BY Title, AuthorId

-- task6
SELECT COUNT(*) AS [���������� ����]
	, MIN(Price) AS [����������� ����]
	, MAX(Price) AS [������������ ����]
	, AVG(Price) AS [������� ����]
FROM Book

-- task7
SELECT Genre AS ����
	, MIN(Price) AS [����������� ����]
	, MAX(Price) AS [������������ ����]
	, AVG(Price) AS [������� ����]
	, COUNT(*) AS [���������� ����]
FROM Book
GROUP BY Genre