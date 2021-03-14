using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3NewsComment
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime Datetime { get; set; }
        public int Delete { get; set; }
    }
}
