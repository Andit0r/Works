-- Task1
INSERT INTO Book(AuthorId, Title)
VALUES (1, 'Дирижабль');

-- Task2
DELETE
FROM Customer
WHERE Phone IS NULL;

-- Task3
UPDATE Book
SET Price -= 100
WHERE Title LIKE '%Сказки%';

-- Task4
SELECT Surname, [Name], Title, Price, PublicationYear
INTO Prose
FROM Book 
	JOIN Author ON Author.AuthorId = Book.AuthorId
WHERE Genre='проза';

-- Task5
DELETE FROM [Order]
WHERE OrderId NOT IN (SELECT DISTINCT OrderId
						FROM OrderedBook)



