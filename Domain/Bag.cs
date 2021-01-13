using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public abstract class Bag
    {
        [Key]
        public string Number { get; set; }  
        public Shipment shipment { get; set; } 
    }
}