using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class HistologyCell
    {
        public HistologyCell()
        {
            AnalysisHistologyData = new HashSet<AnalysisHistologyData>();
        }

        public string HistologyCellId { get; set; }
        public string HistologyCellDesc { get; set; }

        public ICollection<AnalysisHistologyData> AnalysisHistologyData { get; set; }
    }
}
