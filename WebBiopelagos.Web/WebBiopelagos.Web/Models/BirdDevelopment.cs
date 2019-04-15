using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class BirdDevelopment
    {
        public BirdDevelopment()
        {
            SpecimenBird = new HashSet<SpecimenBird>();
        }

        public string BirdDevelopmentId { get; set; }
        public string BirdDevelopmentDesc { get; set; }

        public ICollection<SpecimenBird> SpecimenBird { get; set; }
    }
}
