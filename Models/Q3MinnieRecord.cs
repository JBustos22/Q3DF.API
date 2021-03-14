using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3MinnieRecord
    {
        public int Id { get; set; }
        public string Mapname { get; set; }
        public string Playername { get; set; }
        public string Visname { get; set; }
        public uint Rectime { get; set; }
        public ushort Physic { get; set; }
        public int Rank { get; set; }
        public DateTime Ts { get; set; }
    }
}
