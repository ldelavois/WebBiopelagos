using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisAgingAnnualZone
    {
        public int AnalysisAgingAnnualZoneId { get; set; }
        public int AnalysisBaseId { get; set; }
        public byte AnnualZoneNb { get; set; }
        public decimal AnnualZoneMm { get; set; }

        public AnalysisAging AnalysisBase { get; set; }
    }
}
