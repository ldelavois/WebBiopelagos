using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class VerticalClass
    {
        public VerticalClass()
        {
            Species = new HashSet<Species>();
        }

        public string VerticalClassId { get; set; }
        public string VerticalClassDesc { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
