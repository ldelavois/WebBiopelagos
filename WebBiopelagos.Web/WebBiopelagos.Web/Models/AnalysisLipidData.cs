using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisLipidData
    {
        public int AnalysisLipidDataId { get; set; }
        public int AnalysisBaseLipidId { get; set; }
        public DateTime FattyAnalysisDate { get; set; }
        public string LipidFattyId { get; set; }
        public double? LipidValue { get; set; }

        public AnalysisLipid AnalysisBaseLipid { get; set; }
        public LipidFatty LipidFatty { get; set; }
    }
}
