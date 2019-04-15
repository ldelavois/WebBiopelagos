using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetBiologicalGearLink
    {
        public int SetBiologicalGearId { get; set; }
        public int SetBaseId { get; set; }

        public SetBase SetBase { get; set; }
        public SetBiologicalGear SetBiologicalGear { get; set; }
    }
}
