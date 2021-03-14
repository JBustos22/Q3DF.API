using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3UsersRight
    {
        public int Uid { get; set; }
        public bool CanNewsAdd { get; set; }
        public bool CanNewsEdit { get; set; }
        public bool CanNewsDel { get; set; }
        public bool CanNewsCommentDel { get; set; }
        public bool CanUserAdd { get; set; }
        public bool CanUserEdit { get; set; }
        public bool CanUserDel { get; set; }
        public bool CanAddMddrecords { get; set; }
        public bool CanRecsDel { get; set; }
        public bool CanRights { get; set; }
    }
}
