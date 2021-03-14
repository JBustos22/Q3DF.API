using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3DefragDemo
    {
        public int RecId { get; set; }
        public string Filename { get; set; }
        public int Size { get; set; }
        public DateTime Datetime { get; set; }
        public int Counter { get; set; }
    }
}
