using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisFatmeter
    {
        public AnalysisFatmeter()
        {
            AnalysisFatmeterData = new HashSet<AnalysisFatmeterData>();
        }

        public int AnalysisBaseFatmeterId { get; set; }
        public string FatmeterNo { get; set; }
        public string Produce { get; set; }
        public DateTime? TransferDbDate { get; set; }
        public byte RecordsNb { get; set; }
        public bool IsCorrectOldFat { get; set; }
        public bool IsCorrectWrongProc { get; set; }
        public string SampleCalib { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
        public ICollection<AnalysisFatmeterData> AnalysisFatmeterData { get; set; }
    }
}
