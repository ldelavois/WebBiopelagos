using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Debriefing
    {
        public int DebriefingId { get; set; }
        public short DebrieferStaffId { get; set; }
        public short? DebrieferStaffId2 { get; set; }
        public short SamplerStaffId { get; set; }
        public int TripId { get; set; }
        public DateTime DebriefingDate { get; set; }
        public string PortLocationCode { get; set; }
        public bool IsDebriefReceived { get; set; }
        public string Comment { get; set; }

        public Staff DebrieferStaff { get; set; }
        public Staff DebrieferStaffId2Navigation { get; set; }
        public Port PortLocationCodeNavigation { get; set; }
        public Staff SamplerStaff { get; set; }
        public Trip Trip { get; set; }
    }
}
