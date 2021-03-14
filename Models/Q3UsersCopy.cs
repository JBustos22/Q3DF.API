using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3UsersCopy
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Visname { get; set; }
        public string StripVisname { get; set; }
        public int Serverid { get; set; }
        public int LastActive { get; set; }
        public int LastLogin { get; set; }
        public int EloStartWert { get; set; }
        public string Sessionid { get; set; }
        public string Avatar { get; set; }
        public string Hardware { get; set; }
        public string Country { get; set; }
        public string Dateformat { get; set; }
        public int Timezone { get; set; }
        public bool Del { get; set; }
        public string OldUsername { get; set; }
        public int Boardid { get; set; }
        public bool BackendUser { get; set; }
        public byte WikiAdmin { get; set; }
        public string Comment { get; set; }
    }
}
