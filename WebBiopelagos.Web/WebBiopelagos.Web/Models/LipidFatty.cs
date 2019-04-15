using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class LipidFatty
    {
        public LipidFatty()
        {
            AnalysisLipidData = new HashSet<AnalysisLipidData>();
        }

        public string LipidFattyId { get; set; }
        public string LipidGroup { get; set; }
        public string SystematicName { get; set; }
        public string CommonCode { get; set; }
        public string CommonName { get; set; }

        public ICollection<AnalysisLipidData> AnalysisLipidData { get; set; }
    }
}
