 CREATE TABLE Students (
	StudentsId INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Course INT
 ); 
 
  CREATE TABLE Faculties(
	FacultyId INT PRIMARY KEY AUTO_INCREMENT,
    FacultyName VARCHAR(30) NOT NULL
 );
 
 ALTER TABLE Students
 ADD COLUMN FacultyId INT;

 ALTER TABLE Students
 ADD FOREIGN KEY (FacultyId) REFERENCES Faculties(FacultyId);

INSERT INTO Faculties(FacultyName)
VALUES
	('DITF'),
    ('ETF');
 
UPDATE Students
SET FacultyId = 2
WHERE Students.StudentsId = 1 OR Students.StudentsId = 3;

UPDATE Students
SET FacultyId = 1
WHERE Students.StudentsId = 2 OR Students.StudentsId = 9;
 
SELECT * FROM Students;
 
SELECT * FROM Faculties;

SELECT Students.FirstName, Students.LastName, Faculties.FacultyName, Students.Course
FROM Students, Faculties
WHERE Students.FacultyId = Faculties.FacultyId
AND Course = 2;


SELECT Customers.FirstName, Customers.LastName, Employees.FirstName, Employees.LastName
FROM Customers, Employees
WHERE Customers.EmplyoeesId = Employees.EmplyoeesId;
