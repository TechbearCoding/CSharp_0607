CREATE TABLE Authors(
	AuthorId INT AUTO_INCREMENT PRIMARY KEY,
    AuthorName VARCHAR(20) NOT NULL,
    AuthorLastname VARCHAR(20) NOT NULL
);

INSERT INTO Authors(AuthorName, AuthorLastName)
VALUES
	('Test1', 'Test1'),
    ('Test2', 'Test2'),
	('Test3', 'Test3'),
    ('Test4', 'Test4');
    
CREATE TABLE Books(
	BookId INT AUTO_INCREMENT PRIMARY KEY,
    BookName VARCHAR(50) NOT NULL
);

INSERT INTO Books(BookName)
VALUES
	('TestBook1'),
    ('TestBook2');


CREATE TABLE Authors_Books(
	AuthorId INT NOT NULL,
    BookId INT NOT NULL,
	FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId),
	FOREIGN KEY (BookId) REFERENCES Books(BookId)
);

SELECT * FROM Books;

SELECT * FROM Authors;

INSERT INTO Authors_Books(AuthorId, BookId)
VALUES
	(1, 1),
    (2, 1),
    (3, 2),
    (4, 2);
    
SELECT * FROM Authors_Books;

SELECT Authors.AuthorName, Authors.AuthorLastname, Books.BookName
FROM Authors
INNER JOIN Authors_Books
ON Authors.AuthorId = Authors_Books.AuthorId
INNER JOIN Books
ON Books.BookId = Authors_Books.BookId
WHERE Books.BookName = 'TestBook1';