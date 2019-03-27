using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WBConf.Models;


namespace WBConf.Repository
{
    public class BikeRepository : IBikeRepository
    {
        WalmartBikeDbContext db;
        public BikeRepository(WalmartBikeDbContext _db)
        {
            db = _db;
        }

        //add bike 
        public async Task<int> AddBike(Bike bike)
        {
           if (db!= null)
            {
                await db.Bike.AddAsync(bike);
                await db.SaveChangesAsync();
                return bike.BikeId;
            }
            return 0;
        }
        //add a bike configuration
        public async Task<int> AddBikeConfiguration(BikeConfiguration bikeConfig)
        {
            if (db != null)
            {
                await db.BikeConf.AddAsync(bikeConfig);
                await db.SaveChangesAsync();
                return bikeConfig.ConfigId;

            }
            return 0;
        }
        // delete a bike
        public async Task<int> DeleteBike(int? bikeId)
        {
            int result = 0;
            if (db != null)
            {
                //find bike with bikeid
                var bike = await db.Bike.FirstOrDefaultAsync(x => x.BikeId == bikeId);
                if (bike != null)
                {
                    //delete the bike
                    db.Bike.Remove(bike);
                    //commit the transaction
                   
                        result = await db.SaveChangesAsync();
                   
                    
                }
                return result;
            }
            return result;
        }
        //delete bike configuration
        public async Task<int> DeleteBikeConfiguration(int? configId)
        {
            int result = 0;
            if (db != null)
            {
                //find bikeconfiguration with configId
                var bikeConfig = await db.BikeConf.FirstOrDefaultAsync(x => x.ConfigId == configId);
                if (bikeConfig != null)
                {
                    //delete the bike configuration
                    db.BikeConf.Remove(bikeConfig);
                    //commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }
       
        //get a bikeconfiguration 
        public async Task<BikeConfiguration> GetAConfiguration(int? configId)
        {
            if (db != null)
            {
                return await(from b in db.Bike
                             from bc in db.BikeConf
                             where bc.ConfigId==configId
                             select new BikeConfiguration
                             {
                                 ConfigId = bc.ConfigId,
                                 Pedal = bc.Pedal,
                                 SeatPost = bc.SeatPost,
                                 Seat = bc.Seat,
                                 Brake = bc.Brake,
                                 Stem = bc.Stem,
                                 Handlebar = bc.Handlebar,
                                 Derailleurs = bc.Derailleurs,
                                 ChainSet = bc.ChainSet,
                                 BikeId=b.BikeId,
                                 CurrentBike = b
                             }).FirstOrDefaultAsync();
            }

            return null;
        }
        // gets the list of the bikes
        public async Task<List<Bike>> GetBikes()
        {
            if (db != null)
            {
               
                return await db.Bike.ToListAsync();
            }
            return null;
        }
        // gets a list of configuration of bikes for the bike
        public async Task<List<BikeConfiguration>> GetConfigurations(int? bikeId)
        {
           if (db != null)
            {
                return await (from b in db.Bike where b.BikeId==bikeId
                             from bc in db.BikeConf where bc.BikeId == bikeId
                             select new BikeConfiguration
                             {
                                 ConfigId = bc.ConfigId,
                                 Pedal = bc.Pedal,
                                 SeatPost = bc.SeatPost,
                                 Seat = bc.Seat,
                                 Brake = bc.Brake,
                                 Stem = bc.Stem,
                                 Handlebar = bc.Handlebar,
                                 Derailleurs = bc.Derailleurs,
                                 ChainSet = bc.ChainSet,
                                 BikeId=b.BikeId,
                                 CurrentBike=b

                             }).ToListAsync();
            }
            return null;
        }

        public async Task UpdateBikeConfiguration(BikeConfiguration bikeConfig)
        {
            if (db != null)
            {
                //update that bikeConfig
                db.BikeConf.Update(bikeConfig);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }

        public async Task UpdateBike(Bike bike)
        {

            if (db != null)
            {
                //update that bike
                db.Bike.Update(bike);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
    }
}
