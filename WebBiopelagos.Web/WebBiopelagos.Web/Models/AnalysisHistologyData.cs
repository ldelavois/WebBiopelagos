using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisHistologyData
    {
        public int AnalysisHistologyDataId { get; set; }
        public int AnalysisBaseHistologyId { get; set; }
        public string HistologyCellId { get; set; }

        public AnalysisHistology AnalysisBaseHistology { get; set; }
        public HistologyCell HistologyCell { get; set; }
    }
}
