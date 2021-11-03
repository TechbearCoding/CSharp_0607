 CREATE TABLE Students (
	StudentsId INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Course INT
 );
 
INSERT INTO Students (FirstName, LastName, Course)
VALUES ('Juris', 'New', 1);
 
INSERT INTO Students (FirstName, LastName, Course)
VALUES ('Juris', 'Apse', 2),
	   ('Anna', 'Kļava', 1);
       
INSERT INTO Students (StudentsId, FirstName, LastName, Course)
VALUES (9, 'Arturs', 'Kalnins', 2);
 
SELECT * FROM Students;
 
SELECT FirstName, LastName FROM Students;

SELECT FirstName, LastName 
FROM Students
WHERE Course = 2;