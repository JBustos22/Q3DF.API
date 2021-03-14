using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3ServersAccess
    {
        public int UserId { get; set; }
        public int ServerId { get; set; }
        public int AccessBits { get; set; }
    }
}
