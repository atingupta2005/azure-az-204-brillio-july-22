## Azure Cache for Redis

- What is Azure Cache for Redis?
- Redis Console Commands
```
set myNum 100
GET myNum
set myStr "Atin"
GET myStr
```

```
INFO
CONFIG GET *
CLIENT LIST
MSET key1 "value1" key2 "value2" key3 "value3"
MGET key1 key2 key3 key4
DEL key
SET favNum 10
INCR favNum # 11
INCR favNum # 12
DECR favNum # 11
EXPIRE favNum 10	# Expire after 10 seconds
TTL favNum
# SET and EXPIRE together with SETEX.
SETEX key 10 value
```

- Azure Cache for Redis - ASP.Net Core
  - Refer: 288-simple-strings
  - Update cache_connectionstring

- Azure Redis Cache - Data Invalidation
  - Use below code sample:
```
public void Save(string key, string value)
{
    var ts = TimeSpan.FromMinutes(_settings.CacheTimeout);
    _cache.StringSet(key, value, ts);
}
```

- Azure Redis Cache - StackExchange package
  - Refer - "289-sql-app"
  - Install Package - "StackExchange.Redis"
  - Update connection string in CourseService.cs
  - Create SQL Database and create Course table in it

## Creating a web app to connect to Azure SQL - Resources
- Create Azure SQL Database
- Create a table
```
CREATE TABLE Course
(
   CourseID int,
   CourseName varchar(1000),
   Rating numeric(2,1)
)
```

- Insert Data
```
INSERT INTO Course(CourseID,CourseName,Rating) VALUES(1,'AZ-204 Developing Azure solutions',4.5)
INSERT INTO Course(CourseID,CourseName,Rating) VALUES(2,'AZ-303 Architecting Azure solutions',4.6)
INSERT INTO Course(CourseID,CourseName,Rating) VALUES(3,'DP-203 Azure Data Engineer',4.7)
```

- Inspect Data
```
SELECT * FROM Course
```

- Publish Project to Azure
- Change connection string in Azure Web App to refer to Azure SQL Database
  - Open Azure Web App->Configuration->Connection String
  - New Connection String -> Name: SQLConnection, Paste value taken from Database, Type: SQLAzure
