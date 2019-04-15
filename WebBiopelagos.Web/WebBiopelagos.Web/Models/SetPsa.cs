using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetPsa
    {
        public int SetBaseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string VesselName { get; set; }
        public string LatMin { get; set; }
        public string LonMin { get; set; }
        public string LatMax { get; set; }
        public string LonMax { get; set; }
        public byte AreaReliabilityId { get; set; }

        public AreaReliability AreaReliability { get; set; }
        public SetBase SetBase { get; set; }
    }
}
