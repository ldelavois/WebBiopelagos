using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisGenetic
    {
        public int AnalysisBaseId { get; set; }
        public string HaplotypeCodeId { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
    }
}
