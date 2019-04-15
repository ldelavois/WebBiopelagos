using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SpeciesCategory
    {
        public SpeciesCategory()
        {
            Species = new HashSet<Species>();
        }

        public byte SpeciesCategoryId { get; set; }
        public string SpeciesCategoryDesc { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
