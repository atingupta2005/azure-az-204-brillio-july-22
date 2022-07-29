# Miscellaneous
## Azure Web App
- Azure Web App - Azure SQL Database
- Using Azure Web App - Connecting strings


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

- Refer Web App Code - [Sqlapp.zip](Sqlapp.zip)
- Publish Project to Azure
- Change connection string in Azure Web App to refer to Azure SQL Database
  - Open Azure Web App\Configuration\Connection String
  - New Connection String -> Name: SQLConnection, Paste value taken from Database, Type: SQLAzure
