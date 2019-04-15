using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SpecimenBird
    {
        public SpecimenBird()
        {
            SpecimenBirdLength = new HashSet<SpecimenBirdLength>();
        }

        public int SpecimenBirdId { get; set; }
        public int SpecimenId { get; set; }
        public string BirdDevelopmentId { get; set; }
        public string BirdReproductionId { get; set; }
        public string BirdStatusId { get; set; }
        public string BurrowNo { get; set; }

        public BirdDevelopment BirdDevelopment { get; set; }
        public BirdReproduction BirdReproduction { get; set; }
        public BirdStatus BirdStatus { get; set; }
        public Fish Specimen { get; set; }
        public ICollection<SpecimenBirdLength> SpecimenBirdLength { get; set; }
    }
}
