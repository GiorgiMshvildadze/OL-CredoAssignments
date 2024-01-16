CREATE TABLE Authors
(	
	Id int PRIMARY KEY identity,
	Name varchar(30),
	Age int
);
CREATE TABLE Books
(
	BookId int PRIMARY KEY identity,
	Title varchar(50),
	AuthorID int FOREIGN KEY references dbo.Authors (Id),
	YearPublished int
);

CREATE TABLE Members
(
	MembersId int identity,
	Name varchar(30),
	MemberShip DateTime

);

SELECT * FROM Books where books.YearPublished >2000;

SELECT AuthorID, 
		Count(BookId),
		(select Name From Authors Where Id=b.AuthorID)
 FROM Dbo.Books b
 group by AuthorID
 Having COUNT(BookId)>3;


SELECT * FROM dbo.Authors
SELECT * FROM dbo.Books
 

INSERT INTO dbo.Authors(Name, Age)
VALUES('Author1', 25),
	  ('Author2', 35),
	  ('Author3', 45),
	  ('Author4', 55),
	  ('Author5', 65);

INSERT INTO dbo.Books(Title,AuthorID,YearPublished)
  Values('Book4.2',4,2019),
		('Book2.1',2,2010),
		('Book3.1',3,2000),
		('Book3.2',3,2004),
		('Book3.3',3,1998),
		('Book4.1',4,1991);

UPDATE dbo.Books
SET AuthorID = 3 
WHERE BookId = 7;

DELETE FROM dbo.Books WHERE BookId = 7;


SELECT * FROM Dbo.Authors 
	ORDER BY AUthors.Name;

SELECT a.Id, a.Name, Count(a.Id) BookCount
FROM Books b
JOIN Authors a
ON b.AuthorID = a.Id
GROUP BY 
a.Id, a.Name;


SELECT a.Name, b.Title FROM Authors a
JOIN Books b
ON b.AuthorID = a.Id
 WHERE a.Name = 'Author3';


 SELECT AuthorID, 
		Count(BookId),
		(select Name From Authors Where Id=b.AuthorID)
 FROM Dbo.Books b
 group by AuthorID
 Having COUNT(BookId)>2;

 CREATE INDEX Books_YearPublished
 ON dbo.Books (YearPublished);	

 USE Library
 CREATE PROCEDURE GetBookByAuthorId
   @AuthorId int
 AS
BEGIN
	 
	SET NOCOUNT ON;
	SELECT * FROM Library.dbo.Books
	WHERE AuthorId = @AuthorId
    
END
GO

