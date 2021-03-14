using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3ServersStatus
    {
        public int ServerId { get; set; }
        public string NameColors { get; set; }
        public string Map { get; set; }
        public int CurPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int Speedaward { get; set; }
        public string SpeedawardName { get; set; }
        public int Physic { get; set; }
        public int Mode { get; set; }
    }
}
