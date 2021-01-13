using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Shipment
    {
        [Key]
        public string Number { get; set; }

        public Airport AirPort { get; set;}

        public string FlightNumber { get; set; }

        public DateTime FlightDate {get; set; }

        public List<Bag> Bags{ get; set; }

    }

    public enum Airport
    {
        TLL,
        RIX,
        HEL
    }
}