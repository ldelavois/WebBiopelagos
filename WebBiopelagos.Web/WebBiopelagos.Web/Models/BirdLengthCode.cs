using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class BirdLengthCode
    {
        public BirdLengthCode()
        {
            SpecimenBirdLength = new HashSet<SpecimenBirdLength>();
        }

        public string BirdLengthCodeId { get; set; }
        public string BirdLengthCodeDesc { get; set; }

        public ICollection<SpecimenBirdLength> SpecimenBirdLength { get; set; }
    }
}
