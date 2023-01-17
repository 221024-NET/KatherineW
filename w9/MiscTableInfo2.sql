use Chinook

SELECT * FROM Employee;

SELECT TOP 3 FirstName, LastName, DENSE_RANK() OVER( ORDER BY LastName ASC) rank FROM Employee

SELECT TOP 1 * FROM (SELECT TOP 3 FirstName, LastName, DENSE_RANK() OVER( ORDER BY LastName ASC) rank FROM Employee) AS Names
Where rank = 3