using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3ServersAccessLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServerId { get; set; }
        public int AccessId { get; set; }
        public string Parameter { get; set; }
        public int Timestamp { get; set; }
    }
}
