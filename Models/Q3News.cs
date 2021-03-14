using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3News
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Headline { get; set; }
        public string Content { get; set; }
        public DateTime Datetime { get; set; }
        public bool Locked { get; set; }
    }
}
