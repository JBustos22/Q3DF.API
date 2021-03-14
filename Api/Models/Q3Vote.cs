using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3Vote
    {
        public int Id { get; set; }
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public string Title { get; set; }
    }
}
