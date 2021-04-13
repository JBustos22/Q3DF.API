using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3UsersVote
    {
        public int VoteId { get; set; }
        public int AnswerId { get; set; }
        public int UserId { get; set; }
        public int Timestamp { get; set; }
    }
}
