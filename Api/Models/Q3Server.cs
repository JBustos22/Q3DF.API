using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3Server
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public string Rcon { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public byte Del { get; set; }
        public string Comment { get; set; }
    }
}
