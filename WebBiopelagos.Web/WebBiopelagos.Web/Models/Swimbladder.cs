using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Swimbladder
    {
        public Swimbladder()
        {
            Species = new HashSet<Species>();
        }

        public byte SwimbladderId { get; set; }
        public string SwimbladderAttribute { get; set; }
        public string SwimbladderDesc { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
