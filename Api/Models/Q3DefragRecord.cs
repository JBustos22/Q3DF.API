using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3DefragRecord
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Map { get; set; }
        public int Mstime { get; set; }
        public int Physic { get; set; }
        public bool Mode { get; set; }
        public string Userinfostring { get; set; }
        public int Timestamp { get; set; }
        public string O3jVersion { get; set; }
        public string DefragVersion { get; set; }
        public bool Status { get; set; }
    }
}
