using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SpeciesNameCategory
    {
        public SpeciesNameCategory()
        {
            Species = new HashSet<Species>();
        }

        public string SpeciesNameCategoryId { get; set; }
        public string SpeciesNameCategoryDesc { get; set; }

        public ICollection<Species> Species { get; set; }
    }
}
