using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WBConf.Models
{
    public class Bike
    {
       
        [Key]
        public int BikeId { get; set; }
        public string Name { get; set; }
        public int InitialCost { get; set; }
        public int UpgradedCost { get; set; }       
        public int WalmartId { get; set; }

        public ICollection<BikeConfiguration> BikeConfs { get; set; } = new List<BikeConfiguration>();
    }
}
