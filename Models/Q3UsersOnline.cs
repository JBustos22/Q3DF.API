using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3UsersOnline
    {
        public int Uid { get; set; }
        public string Sessionid { get; set; }
        public string UserAgent { get; set; }
        public string RequestUri { get; set; }
        public int Timestamp { get; set; }
    }
}
