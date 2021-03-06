# SASid_Code_Example

This is a C# .NET Core MVC web app which consists of a single view - an input box and a submit button.
The user is able to enter their User ID in the input box and click submit or hit enter in the input box.
This action by the user sends a request to a server, which retrieves a record from a Users table in a SQL Server database that is running in a docker container.
The record is returned as an object using Entity Framework. The User table has 5 fields: UserID, FirstName, LastName, Gender, and DOB (Date of Birth).
Database objects are mapped to an entity class and then to a model class which calculates the days until their birthday.
This information is returned in the form of a sentence letting the user know how long it will be before it is that person's birthday.

**NOTE: The web app and web server are part of the same project in this case. Most of the time, in a real real world scenario, those should be separated. Additionally, if this was a real world app, I would have given more thought about what the proper access modifiers to class properties should be.**

## How to run the project

[Install Docker](https://hub.docker.com/) and make sure the application is running.
[Install .NET Core](https://dotnet.microsoft.com/download).

Open a terminal. Create a SQL Server database, start the docker container, and confirm it is running.
```
  sudo docker pull microsoft/mssql-server-linux:2017-latest
  sudo docker run -e 'ACCEPT_EULA=Y' \
  -e 'SA_PASSWORD=Passw0rd!' \
  -p 1433:1433 \
  --name mssql \
  -d microsoft/mssql-server-linux:2017-latest
  docker start mssql
  docker ps -a
```

Navigate to the project directory and start the web app.
```
  dotnet run
```

Open up a compatible web browser (tested on **Chrome, Firefox, and Safari**) and navigate to <http://localhost:5000/>.
