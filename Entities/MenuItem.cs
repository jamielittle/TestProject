using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class MenuItem
    {
        public string MenuHeader { get; set; }
        public string ItemText { get; set; }
        public List<UrlLink> Links { get; set; }
    }
}
