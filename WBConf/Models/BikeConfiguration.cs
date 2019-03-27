using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WBConf.Models
{
    public class BikeConfiguration
    {
        [Key]
        public int ConfigId { get; set; }
        public string Pedal { get; set; }
        public string SeatPost { get; set; }
        public string Seat { get; set; }
        public string Brake { get; set; }
        public string Stem { get; set; }
        public string Handlebar { get; set; }
        public string Derailleurs { get; set; }
        public string ChainSet { get; set; }

        [ForeignKey("BikeId")]
        public int BikeId { get; set; }

        public virtual Bike CurrentBike { get; set; }
    }
}
