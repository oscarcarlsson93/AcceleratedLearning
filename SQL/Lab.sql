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











