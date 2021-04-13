using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3IpToCountry
    {
        public double IpFrom { get; set; }
        public double IpTo { get; set; }
        public string Zwei { get; set; }
        public string Drei { get; set; }
        public string Name { get; set; }
    }
}
