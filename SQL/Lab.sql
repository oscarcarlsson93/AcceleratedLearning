use Chinook
--Uppgift 6
--SELECT * from Album
--WHere Title LIKE '_ar%'

--Uppgift 7
--SELECT * from Album
--WHere Title LIKE 'a%'
--or Title LIKE 'e%'
--or Title LIKE 'o%'
--or title LIKE 'i%'
--or title like 'u%'
--or title like 'y%'
--Where name like '[aeoiuy}]'

--Uppgift 8
--Select Title, Name from Album
--INNER JOIN Artist ON Album.ArtistId = Artist.ArtistId


--Uppgift 10
--Select top 10 Artist.Name, COUNT(AlbumId) AS NrOfAlbums FROM Album
--left join Artist ON Album.ArtistId = Artist.ArtistId
--Group BY Artist.Name
--order by NrOfAlbums desc

--Uppgift 11
--select distinct Title as AlbumTitle from Album
--join Track on album.AlbumId = Track.AlbumId
--join Genre on Track.GenreId = Genre.GenreId
--where Genre.Name = 'Jazz' or Genre.Name = 'Blues'



--Uppgift 12
--Alter Table Track
--add Track int

--select * from Track

--Update Track
--set TrackNumber = TrackId -14
--where AlbumId = 4


--Uppgift 13
--select Genre.Name, COUNT(*) as NrOfTracks
--From Track
--Join Genre on Track.GenreId = Genre.GenreId
--Group by Genre.Name
--having count (TrackId) > 100
--Order by COUNT(TrackId) desc


--Uppgift 14
--Declare @MyCustomer int =
--(
--select Customer.CustomerId
--from Customer
--Where Customer.FirstName = 'Leonie' and Customer.LastName = 'Köhler'
--)
--Select Cast(InvoiceDate as date) as Datum
--from Invoice
--Where CustomerId = @MyCustomer


--Uppgift 15
--Select Customer.FirstName as CustomerFirstname, Customer.LastName as CustomerLastName, Employee.FirstName as SupportFirstName, Employee.LastName as SupportLastName
--into #CustomerWithSupport2
--from Customer
--Join Employee on Customer.SupportRepId = Employee.EmployeeId

--select * from #CustomerWithSupport2

--Uppgift 16
--select e1.FirstName + ' ' + e1.LastName as EmployeeName, e2.FirstName + ' ' + e2.LastName as BossName
--from Employee e1
--join Employee e2
--on e1.ReportsTo = e2.EmployeeId


--Uppgift 17
--select MAX(LEN(Email)) as LongestMail
--from Customer

--Uppgift 18
--select track.Name as Name,Track.Milliseconds/60000.0 as Minutes
--from Track
--where track.Milliseconds/60000.0 > 45
--order by Minutes DESC

--Uppgift 19
--Alter Table Customer
--ADD UNique (Email)

--Uppgift 20
--select DATEPART(YEAR, Invoice.InvoiceDate) as YEAR, SUM(Invoice.Total)as Sum
--from Invoice
--group by DATEPART(YEAR, Invoice.InvoiceDate)
--order by DATEPART(Year, Invoice.InvoiceDate) desc

--Uppgift 21

--select Playlist.Name, SUM((Track.Milliseconds/60000.0)/ 60) as TotalLengthInHours
--from Playlist
--join PlaylistTrack on Playlist.PlaylistId = PlaylistTrack.PlaylistId
--join Track on PlaylistTrack.TrackId = Track.TrackId
--Group by Playlist.Name
--order by SUM((Track.MilliSeconds/60000.0) / 60 )  desc

--Uppgift 22
--select e1.FirstName + ' ' + e1.LastName as EmployeeName, e2.FirstName + ' ' + e2.LastName as BossName, e3.FirstName + ' ' + e3.LastName as BossesBossName
--from Employee e1
--join Employee e2
--on e1.ReportsTo = e2.EmployeeId
--join Employee e3
--on e2.ReportsTo = e3.EmployeeId

--Uppgift 23
--Create Table ReviewAlbum 
--(
--Ratings decimal(2,1)
--CONstraint chk_Ratings CHECK (Ratings >= 0 AND Ratings <= 5)
--)
--Create Table ReviewAlbum2
--(
--AlbumID int,
--AlbumReview varchar (50)
--);

--select ReviewAlbum2.AlbumReview
--from ReviewAlbum2
-- join Album on Album.AlbumId = ReviewAlbum2.AlbumID

 --INSERT INTO ReviewAlbum2(AlbumReview.Albumid, ReviewAlbum2.AlbumReview)
 --VALUES ((select Album.AlbumId from Album where Title = 'Black SAbbath'), 'Riktigt bra album!')





















