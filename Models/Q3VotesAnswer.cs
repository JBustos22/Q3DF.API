using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3VotesAnswer
    {
        public int Id { get; set; }
        public int VoteId { get; set; }
        public string Answer { get; set; }
    }
}
