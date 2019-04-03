# BikeConfigurationAPI
# ASP.NET API, Entity Framework, REST, SQL Server
The sql server and Web Api both are hosted in Azure. 
#Change the database connection string in appsettings.json for local development.

 "ConnectionStrings": {
    "BikesDatabase": "Server=YourServer;Database=WBConf_API.Models;Trusted_Connection=True;"
  }
#Use the BiKeDB backupfile to restore database in your machine
Rest API

1.https://wbconf.azurewebsites.net/api/bike/Getbikes //Get List OF Bikes

2.https://wbconf.azurewebsites.net/api/bike/GetBikeConfigs/6  //Get List Of Configuration for Bike with bike ID

3.https://wbconf.azurewebsites.net/api/bike/GetBikeConfig/11  //Get a configuration  with configId

4.https://wbconf.azurewebsites.net/api/bike/AddBike  //add a bike
{	
        "name": "genesis rct23",
        "initialCost": 201,
        "upgradedCost": 201,
        "walmartId": 22222,
        "bikeConfs": []
}

5.https://wbconf.azurewebsites.net/api/bike/AddBikeConfig  //Add a bike config
{
   
    "pedal": "Raceface5",
    "seatPost": "Raceface5",
    "seat": "Raceface5",
    "brake": "Shimano101",
    "stem": "Jessica Acekit5",
    "handlebar": "Jessica Acekit5",
    "derailleurs": "Shimano5",
    "chainSet": "3xspeed5",
    "bikeId": 7
}

6.https://wbconf.azurewebsites.net/api/bike/DeleteBikeConfig/3  //delete a bike configuration

7.https://wbconf.azurewebsites.net/api/bike/DeleteBike/3  //delete a bike

8.https://wbconf.azurewebsites.net/api/bike/UpdateBike  //update a bike
{		     "bikeId":6,
        "name": "genesis rct2",
        "initialCost": 201,
        "upgradedCost": 201,
        "walmartId": 222212,
        "bikeConfs": []
}

9.https://wbconf.azurewebsites.net/api/bike/UpdateBikeConf  //update a bike configuration
{
    "configId":11,
    "pedal": "Raceface5",
    "seatPost": "Raceface5",
    "seat": "Raceface5",
    "brake": "Shimano5",
    "stem": "Jessica Acekit5",
    "handlebar": "Jessica Acekit5",
    "derailleurs": "Shimano5",
    "chainSet": "3xspeed55",
    "bikeId": 6
    
    }
    
