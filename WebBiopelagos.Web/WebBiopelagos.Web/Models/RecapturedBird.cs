using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class RecapturedBird
    {
        public int NewBirdSpecimenId { get; set; }
        public int FirstBirdSpecimenId { get; set; }

        public Fish NewBirdSpecimen { get; set; }
    }
}
