using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FatmeterMeasure
    {
        public FatmeterMeasure()
        {
            AnalysisFatmeterData = new HashSet<AnalysisFatmeterData>();
        }

        public string FatmeterMeasureId { get; set; }
        public string FatmeterMeasureDesc { get; set; }

        public ICollection<AnalysisFatmeterData> AnalysisFatmeterData { get; set; }
    }
}
