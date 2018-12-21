 
 select Location.LocationName, Church.YearBuiltId, ChurchName.Name from Church
 join ChurchName on Church.ChurchNameId = ChurchName.ChurchNameId
join Location on Church.LocationId = Location.LocationId

select Person.PersonName, LocationName from Person
join Location on Person.LocationId = Location.LocationId

Select Person.PersonName, ChurchName.Name, Church.YearBuiltId from PersonLike
join Person on Person.PersonId = PersonLike.PersonId
join Church on Church.ChurchId = PersonLike.Church
join ChurchName on ChurchName.ChurchNameId = PersonLike.Church