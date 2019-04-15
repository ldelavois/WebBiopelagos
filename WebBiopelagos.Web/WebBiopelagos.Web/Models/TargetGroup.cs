using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TargetGroup
    {
        public TargetGroup()
        {
            SetBiologicalGear = new HashSet<SetBiologicalGear>();
        }

        public byte TargetGroupId { get; set; }
        public string TargetGroupDesc { get; set; }

        public ICollection<SetBiologicalGear> SetBiologicalGear { get; set; }
    }
}
