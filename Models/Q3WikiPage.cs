using System;
using System.Collections.Generic;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class Q3WikiPage
    {
        public Q3WikiPage()
        {
            InverseParent = new HashSet<Q3WikiPage>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Lft { get; set; }
        public int Lvl { get; set; }
        public int Rgt { get; set; }
        public int? Root { get; set; }
        public byte Active { get; set; }

        public virtual Q3WikiPage Parent { get; set; }
        public virtual ICollection<Q3WikiPage> InverseParent { get; set; }
    }
}
