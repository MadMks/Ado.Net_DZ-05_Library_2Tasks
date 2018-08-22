USE model;
GO

CREATE DATABASE LibraryDB;
GO

USE LibraryDB;
GO

CREATE TABLE Author
(
	"Id" INT NOT NULL PRIMARY KEY IDENTITY,
	"FirstName" NVARCHAR(20) NOT NULL,
	"LastName" NVARCHAR(35) NOT NULL
);
GO

CREATE TABLE Visitor
(
	"Id" INT NOT NULL PRIMARY KEY IDENTITY,
	"FirstName" NVARCHAR(20) NOT NULL,
	"LastName" NVARCHAR(35) NOT NULL
);
GO

CREATE TABLE Book
(
	"Id" INT NOT NULL PRIMARY KEY IDENTITY,
	"Title" NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE BookAuthor
(
	"Id" INT NOT NULL PRIMARY KEY IDENTITY,
	"BookId" INT NOT NULL
		FOREIGN KEY
		REFERENCES dbo.Book(Id),
	"AuthorId" INT NOT NULL
		FOREIGN KEY
		REFERENCES dbo.Author(Id)
);
GO

CREATE TABLE Debtor
(
	"Id" INT NOT NULL PRIMARY KEY IDENTITY,
	"BookId" INT NOT NULL
		FOREIGN KEY
		REFERENCES dbo.Book(Id),
	"VisitorId" INT NOT NULL
		FOREIGN KEY
		REFERENCES dbo.Visitor(Id)
);
GO

--
-- Filling in with data
--

INSERT INTO dbo.Author
	(FirstName, LastName)
	VALUES
	('Nick', 'Bostrom'), 
	('Brian', 'Christian'),
	('Ray', 'Kurzweil'),
	('Nicolas', 'Carr'),
	('Max', 'Tegmark'),
	('Thomas', 'Cormen'),
	('Joe', 'Baron'),
	('David', 'Chandler'),
	('Donella', 'Meadows'),
	('Gareth', 'James'),
	('Donald', 'Knuth'),
	('Bjarne', 'Stroustrup'),
	('Eric', 'Matthes'),
	('Charlez', 'Petzold'),
	('Robert', 'Nystrom'),
	('Wallace', 'Wang'),
	('Joseph', 'Connor'),
	('Jordan', 'Hudgens'),
	('Aditya', 'Shankar'),
	('Paul', 'Laurence'),
	('Michael', 'Dawson'),
	('Brian', 'Kerninghan'),
	('Bill', 'Phillips');
GO

INSERT INTO dbo.Visitor
	(FirstName, LastName)
	VALUES
	('Егор', 'Ершов'),
	('Bender', 'Rodriguez'),
	('Аристарх', 'Буров'),
	('Альберт', 'Миронов'),
	('Родион', 'Дементьев'),
	('Анатолий', 'Гусев'),
	('Платон', 'Дроздов'),
	('Геннадий', 'Логинов'),
	('Орест', 'Журавлёв');
GO

INSERT INTO dbo.Book
	(Title)
	VALUES
	('Superintelligence 2'),
	('Algorithms to Live By'),
	('Introduction to Algorithms'),
	('AWS Certified Solutions'),
	('The Black Swan'),
	('Pro HTML5 Games'),
	('Beginning C++ Through Game'),
	('The Art of Programming'),
	('Python Crash Course');
GO

INSERT INTO dbo.BookAuthor
	(BookId, AuthorId)
	VALUES
	(9, 23),
	(6, 1),
	(6, 19),
	(5, 2),
	(4, 1),
	(3, 1),
	(3, 4),
	(3, 15),
	(3, 18),
	(2, 2),
	(1, 10),
	(1, 11);
GO

INSERT INTO dbo.Debtor
	(BookId, VisitorId)
	VALUES
	(1, 9),
	(1, 2),
	(7, 2),
	(3, 2),
	(8, 4),
	(5, 7);
GO