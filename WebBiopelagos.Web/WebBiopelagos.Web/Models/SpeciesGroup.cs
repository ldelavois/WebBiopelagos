using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SpeciesGroup
    {
        public SpeciesGroup()
        {
            Species = new HashSet<Species>();
        }

        public string SpeciesGroupId { get; set; }
        public string SpeciesGroupDesc { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
