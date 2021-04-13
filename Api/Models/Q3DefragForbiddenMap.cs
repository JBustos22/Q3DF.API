using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3DefragForbiddenMap
    {
        public sbyte Id { get; set; }
        public string Mapname { get; set; }
        public int Timeout { get; set; }
    }
}
