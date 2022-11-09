Select FirstName + ' ' + LastName As FullName, CustomerId, Country From Customer
Where Country != 'USA';

Select * From Customer Where Country = 'Brazil';

Select * From Employee Where Title LIKE '%Sale%';

Select BillingCountry From Invoice;

Select COUNT(*) As '2009 Invoices', SUM(Total) As '2009 SalesTotal' From Invoice
Where InvoiceDate LIKE '%2009%';

Select COUNT(*) From InvoiceLine Where InvoiceId = 37;

Select BillingCountry, COUNT(InvoiceId) As InvoiceTotal From Invoice Group By BillingCountry;

Select BillingCountry, SUM(Total) As CountryTotal From Invoice Group By BillingCountry Order By SUM(Total) DESC, BillingCountry;

Select Invoice.* From Invoice Join Customer On Customer.Country = 'Brazil';

Select Employee.FirstName + ' ' + Employee.LastName As EmployeeName, Invoice.* From Employee
Join Customer On Employee.EmployeeId = Customer.SupportRepId
Join Invoice On Customer.CustomerId = Invoice.CustomerId;


-- get track numbers per playlist -- playlist songs and songs on playlists are listed separately... need to get number of rows for each unique PlaylistId
-- find the number of songs for each distinct selection

--Select Distinct PlaylistId From PlaylistTrack Group By PlaylistTrack.PlaylistId

--Select * From PlaylistTrack WHERE PlaylistId = (Select Distinct PlaylistId From PlaylistTrack)

--Select Playlist.Name, PlaylistTrack.TrackId
--From Playlist Join PlaylistTrack On Playlist.PlaylistId = PlaylistTrack.PlaylistId Order By COUNT(PlaylistTrack.TrackId) DESC;

Select Playlist.Name, COUNT(PlaylistTrack.PlaylistId) as SongCount From PlaylistTrack
	Join Playlist On Playlist.PlaylistId = PlaylistTrack.PlaylistId
	Group By Playlist.Name
	Order By SongCount DESC;

-- Only returns playlist names and IDs of playlists with tracks
Select Playlist.Name, Playlist.PlaylistId From Playlist
	Join PlaylistTrack On Playlist.PlaylistId = PlaylistTrack.PlaylistId
	Group By Playlist.Name, Playlist.PlaylistId;

Select * From PlaylistTrack Where PlaylistId = ALL(Select PlaylistId From Playlist Where Playlist.Name = 'Audiobooks') -- 0 Audiobooks

Select * From Customer
	Join Invoice On Customer.CustomerId = Invoice.CustomerId
	Group By Customer.CustomerID

-- 2009 Invoice -> Customer Support ID -> Employee Name -- , COUNT(Employee.EmployeeId) As EmployeeSales
--Invoice.InvoiceId, Invoice.InvoiceDate, Employee.FirstName + ' ' + Employee.LastName As Employee, Employee.EmployeeId From Invoice

Select Emp.FirstName + ' ' + Emp.LastName As EmpName, COUNT(Emp.EmployeeId) As Id From Invoice As I -- Employee.FirstName + ' ' + Employee.LastName, COUNT(Employee.EmployeeId) From Invoice
	Join Customer As Cus On I.CustomerId = Cus.CustomerId
	Join Employee As Emp On Cus.SupportRepId = Emp.EmployeeId
	Where I.InvoiceDate LIKE '%2009%'
	Group By Emp.FirstName, Emp.LastName, Emp.EmployeeId
	Order By Id DESC;
	
-- Which sales agent made the most sales in 2009?