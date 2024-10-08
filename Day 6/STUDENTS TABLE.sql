CREATE DATABASE myDb;

use myDb;

CREATE TABLE [students](
	[id] INT PRIMARY KEY IDENTITY,
	[name] VARCHAR(50) NOT NULL,
	[email] VARCHAR(100) UNIQUE NOT NULL,
	[class] INT DEFAULT 1
);

INSERT INTO [students] ([name], [email], [class]) VALUES 
('John Doe', 'john.doe@example.com', 1),
('Jane Smith', 'jane.smith@example.com', 2),
('Alex Johnson', 'alex.johnson@example.com', 1),
('Emily Davis', 'emily.davis@example.com', 3),
('Michael Brown', 'michael.brown@example.com', 1),
('Sarah Miller', 'sarah.miller@example.com', 2),
('David Wilson', 'david.wilson@example.com', 1),
('Laura Moore', 'laura.moore@example.com', 3),
('James Taylor', 'james.taylor@example.com', 2),
('Olivia Anderson', 'olivia.anderson@example.com', 1);

SELECT * FROM students;

SELECT [id], [name], [email] from students;

SELECT id, name FROM students WHERE id = 1;
SELECT id, name FROM students WHERE email = 'laura.moore@example.com';

SELECT id, name, class FROM students WHERE id >=1 AND id <=5;
SELECT id, name, class FROM students WHERE id BETWEEN 1 AND 5;

SELECT id, name, class FROM students WHERE class = 1 OR class = 3;
SELECT id, name, class FROM students WHERE class IN (1, 3);

SELECT id, name, class FROM students ORDER BY NAME ASC;
SELECT id, name, class FROM students ORDER BY NAME DESC;

SELECT id, name AS full_name, class AS grade from students;

SELECT class, COUNT(id) FROM students GROUP BY class;
SELECT class, COUNT(id) AS count_of_students FROM students GROUP BY class;

SELECT class, COUNT(id) AS [count] FROM students GROUP BY class HAVING count(id) < 5;

SELECT TOP 5 id, name, class FROM students;
SELECT id, name, class FROM students 
	ORDER BY id 
	OFFSET 5 ROWS 
	FETCH NEXT 3 ROWS ONLY;

SELECT LEN('Hello');
SELECT name, LEN(name) as name_length FROM students;

SELECT COUNT(id) AS total_students FROM students;
SELECT SUM(class) AS sum_of_classes FROM students;
SELECT MIN(class) AS min_class FROM students;
SELECT MAX(class) AS max_class FROM students;
SELECT AVG(class) AS avg_class FROM students;