using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ProduceJam.Models
{
    public class LastWeek
    {
        public int Id { get; set; }
        public string Commodity { get; set; }
        public decimal CorronationCommonPrice { get; set; }
        public decimal CrossRoadsCommonPrice { get; set; }
        public decimal PapineCommonPrice { get; set; }
    }

}
