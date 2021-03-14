using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Tmp
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public int? Boardid { get; set; }
        public string Username { get; set; }
        public int? CountRecords { get; set; }
        public int? CountRecordsHistory { get; set; }
        public int? CountComments { get; set; }
        public int? CountPosts { get; set; }
    }
}
