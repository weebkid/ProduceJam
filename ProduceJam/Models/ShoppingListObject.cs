using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace ProduceJam.Models
{

    public class ShoppingListObject
    {
        
        public int Id { get; set; }
        public DateTime ShoppingDate { get; set; }
        public string User { get; set; }
        public List<string> Commodity { get; set; }
        public List<float?> Price { get; set; }

        public ShoppingListObject() { }



    }
}
