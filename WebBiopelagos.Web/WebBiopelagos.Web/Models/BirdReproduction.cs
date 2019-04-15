using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class BirdReproduction
    {
        public BirdReproduction()
        {
            SpecimenBird = new HashSet<SpecimenBird>();
        }

        public string BirdReproductionId { get; set; }
        public string BirdReproductionDesc { get; set; }

        public ICollection<SpecimenBird> SpecimenBird { get; set; }
    }
}
