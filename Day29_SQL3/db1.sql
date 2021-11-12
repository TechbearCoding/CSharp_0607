CREATE TABLE Authors(
	AuthorId INT AUTO_INCREMENT PRIMARY KEY,
    AuthorName VARCHAR(20) NOT NULL,
    AuthorLastname VARCHAR(20) NOT NULL
);


INSERT INTO Authors(AuthorName, AuthorLastName)
VALUES
	('Aleksandrs', 'Grīns'),
    ('Džoanna Ketlina', 'Rollinga');
    
CREATE TABLE Books(
	BookId INT AUTO_INCREMENT PRIMARY KEY,
    BookName VARCHAR(50) NOT NULL,
    AuthorId INT NOT NULL,
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
);

INSERT INTO Books(BookName, AuthorId)
VALUES
	('Dvēseļu Putenis', 1),
    ('Harijs Poters 1', 2),
    ('Harijs Poters 2', 2);
    
SELECT * FROM Books;

SELECT BookName, CONCAT_WS(' ',Authors.AuthorName,Authors.AuthorLastname) as 'Author'
FROM Books, Authors
WHERE Books.AuthorId = Authors.AuthorId;

SELECT Books.BookName, CONCAT_WS(' ',Authors.AuthorName,Authors.AuthorLastname) as 'Author'
FROM Books
INNER JOIN Authors
ON Authors.AuthorId = Books.AuthorId;
