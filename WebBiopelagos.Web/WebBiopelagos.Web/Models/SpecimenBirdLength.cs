using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SpecimenBirdLength
    {
        public int SpecimenBirdLengthId { get; set; }
        public int SpecimenBirdId { get; set; }
        public string BirdLengthCodeId { get; set; }
        public double BirdLengthMm { get; set; }

        public BirdLengthCode BirdLengthCode { get; set; }
        public SpecimenBird SpecimenBird { get; set; }
    }
}
