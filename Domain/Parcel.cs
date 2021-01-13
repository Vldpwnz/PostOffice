using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Parcel
    {
       [Key] 
        public string Number{ get; set; }
        
        public string RecepientName { get; set; }

        public string DestinationCountry { get; set; }

        public double Weight { get; set; }

        public double Price { get; set; }

        public BagWithParcels bag { get; set; }

    }
}
