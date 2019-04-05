# BikeConfigurationAPI
# ASP.NET API, Entity Framework, REST, SQL Server
The sql server and Web Api both are hosted in Azure.
https://wbconf.azurewebsites.net/

#Change the database connection string in appsettings.json for local development.

 "ConnectionStrings": {
    "BikesDatabase": "Server=YourServer;Database=WBConf_API.Models;Trusted_Connection=True;"
  }
#Use the BiKeDB backupfile to restore database in your machine

