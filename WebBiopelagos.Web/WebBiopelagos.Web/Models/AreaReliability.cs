using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AreaReliability
    {
        public AreaReliability()
        {
            SetPsa = new HashSet<SetPsa>();
        }

        public byte AreaReliabilityId { get; set; }
        public string AreaReliabilityDesc { get; set; }

        public ICollection<SetPsa> SetPsa { get; set; }
    }
}
