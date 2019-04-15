using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class BirdStatus
    {
        public BirdStatus()
        {
            SpecimenBird = new HashSet<SpecimenBird>();
        }

        public string BirdStatusId { get; set; }
        public string BirdStatusDesc { get; set; }

        public ICollection<SpecimenBird> SpecimenBird { get; set; }
    }
}
