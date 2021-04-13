using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3Pinboard
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string Message { get; set; }
        public int Timestamp { get; set; }
        public bool Del { get; set; }
    }
}
