using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3ServersStatusPlayer
    {
        public int PlayerId { get; set; }
        public int ServerId { get; set; }
        public string NameColors { get; set; }
        public int Ping { get; set; }
        public string Country { get; set; }
        public int UserId { get; set; }
        public string SpectatorName { get; set; }
        public int Mstime { get; set; }
        public bool IsSpectated { get; set; }
        public bool HasSpeedaward { get; set; }
    }
}
