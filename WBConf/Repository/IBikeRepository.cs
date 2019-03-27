using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBConf.Models;

namespace WBConf.Repository
{
   public  interface IBikeRepository
    {
        Task<List<Bike>> GetBikes();
        Task<int> AddBike(Bike bike);
        Task<int> DeleteBike(int? bikeId);
        Task UpdateBike(Bike bike);

        Task<List<BikeConfiguration>> GetConfigurations(int? bikeId);
        Task<BikeConfiguration> GetAConfiguration(int? configId);
        Task<int> AddBikeConfiguration(BikeConfiguration bikeConfig);
        Task<int> DeleteBikeConfiguration(int? configId);
        Task UpdateBikeConfiguration(BikeConfiguration bikeConfig);

    }
}
