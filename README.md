# BikeConfigurationAPI
# ASP.NET API, Entity Framework, REST, SQL Server
#Change the database connection string in appsettings.json.

 "ConnectionStrings": {
    "BikesDatabase": "Server=YourServer;Database=WBConf_API.Models;Trusted_Connection=True;"
  }
#Use the BiKeDB backupfile to restore database in your machine
Rest API
//Get List OF Bikes
# https://wbconf.azurewebsites.net/api/bike/Getbikes
//Get List Of Configuration for Bike with bike ID
#https://wbconf.azurewebsites.net/api/bike/GetBikeConfigs/6
//Get a configuration  with configId
3.https://wbconf.azurewebsites.net/api/bike/GetBikeConfig/11
//add a bike
4.https://wbconf.azurewebsites.net/api/bike/AddBike
{	
        "name": "genesis rct23",
        "initialCost": 201,
        "upgradedCost": 201,
        "walmartId": 22222,
        "bikeConfs": []
}
//Add a bike config
5.https://wbconf.azurewebsites.net/api/bike/AddBikeConfig
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
// delete a bike configuration
6.https://wbconf.azurewebsites.net/api/bike/DeleteBikeConfig/3
//deleta a bike
7.https://wbconf.azurewebsites.net/api/bike/DeleteBike/3
//update a bike
8.https://wbconf.azurewebsites.net/api/bike/UpdateBike
    {		"bikeId":6,
        "name": "genesis rct2",
        "initialCost": 201,
        "upgradedCost": 201,
        "walmartId": 222212,
        "bikeConfs": []
}
//update a bike configuration
9.https://wbconf.azurewebsites.net/api/bike/UpdateBikeConf
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
    
