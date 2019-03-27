using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WBConf.Models;
using WBConf.Repository;

namespace WBConf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        IBikeRepository bikeRepository;
        public BikeController(IBikeRepository bikeRepo)
        {
            bikeRepository = bikeRepo;
        }
        //Get List of Bikes
        [HttpGet]
        [Route("GetBikes")]
        public async Task<IActionResult> GetBikes()
        {
            try
            {
                var bikes = await bikeRepository.GetBikes();
                if (bikes == null)
                {
                    return NotFound();
                }
                
                return Ok(bikes);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        //Get Lists of Bike configuration for a bike
        [HttpGet("{BikeId}")]
        [Route("GetBikeConfigs/{bikeId}")]
        public async Task<IActionResult> GetBikeConfigs(int? bikeId)
        {
            try
            {
                var bikeConfigs = await bikeRepository.GetConfigurations(bikeId);
                if (bikeConfigs == null)
                {
                    return NotFound();
                }

                return Ok(bikeConfigs);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        //get a single bike configuration
        [HttpGet("{configId}")]
        [Route("GetBikeConfig/{configId}")]
        public async Task<IActionResult> GetBikeConfig(int? configId)
        {
            if (configId == null)
            {
                return BadRequest();
            }

            try
            {
                var bikeConfig = await bikeRepository.GetAConfiguration(configId);

                if (bikeConfig == null)
                {
                    return NotFound();
                }

                return Ok(bikeConfig);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        //add a bike
        [HttpPost]
        [Route("AddBike")]
        public async Task<IActionResult> AddBike([FromBody]Bike bikeModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bikeId = await bikeRepository.AddBike(bikeModel);
                    if (bikeId > 0)
                    {
                        return Ok(bikeId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        //add a bike Configuration
        [HttpPost]
        [Route("AddBikeConfig")]
        public async Task<IActionResult> AddBikeConfig([FromBody]BikeConfiguration bikeConfigModal)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bikeConfigId = await bikeRepository.AddBikeConfiguration(bikeConfigModal);
                    if (bikeConfigId > 0)
                    {
                        return Ok(bikeConfigId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }
        //delete a bike
        [HttpDelete("{bikeId}")]
        [Route("DeleteBike/{bikeId}")]
        public async Task<IActionResult> DeleteBIke(int? bikeId)
        {
            int result = 0;

            if (bikeId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await bikeRepository.DeleteBike(bikeId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        //delete a bike Configuration
        [HttpDelete("{bikeConfigId}")]
        [Route("DeleteBikeConfig/{bikeConfigId}")]
        public async Task<IActionResult> DeleteBIkeConfig(int? bikeConfigId)
        {
            int result = 0;

            if (bikeConfigId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await bikeRepository.DeleteBikeConfiguration(bikeConfigId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        //update a bike
        [HttpPut]
        [Route("UpdateBike")]
        public async Task<IActionResult> UpdateBike([FromBody]Bike bikeModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await bikeRepository.UpdateBike(bikeModel);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName ==
                             "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }

        //update a bike Configuration
        [HttpPut]
        [Route("UpdateBikeConf")]
        public async Task<IActionResult> UpdateBikeConf([FromBody]BikeConfiguration bikeConfModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await bikeRepository.UpdateBikeConfiguration(bikeConfModel);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName ==
                             "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }

    }

    



}
