using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetDws
    {
        public int SetBaseId { get; set; }
        public short? DepthStart { get; set; }
        public string LatEnd { get; set; }
        public string LonEnd { get; set; }
        public string TimeEnd { get; set; }
        public short? DepthEnd { get; set; }
        public bool IsBurley { get; set; }
        public short? LinesNo { get; set; }
        public string Bait { get; set; }
        public short? HooksNo { get; set; }

        public SetBase SetBase { get; set; }
    }
}
