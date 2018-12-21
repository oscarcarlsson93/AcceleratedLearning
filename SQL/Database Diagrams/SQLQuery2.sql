select Location.LocationName, Church.YearBuiltId, Church.Name from Church
join Location on Church.LocationId = Location.LocationId

