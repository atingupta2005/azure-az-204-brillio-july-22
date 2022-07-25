## Azure Cache for Redis

- What is Azure Cache for Redis?
- Redis Console Commands
```
set myNum 100
GET myNum
set myStr "Atin"
GET myStr
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
