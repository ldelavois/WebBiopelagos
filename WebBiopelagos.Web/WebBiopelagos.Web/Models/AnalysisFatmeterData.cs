using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisFatmeterData
    {
        public int AnalysisFatmeterDataId { get; set; }
        public int AnalysisBaseFatmeterId { get; set; }
        public string FatmeterMeasureId { get; set; }
        public double ValFat1 { get; set; }
        public double ValFat2 { get; set; }
        public double ValFat3 { get; set; }
        public double ValFat4 { get; set; }
        public double? ValFat5 { get; set; }
        public double? ValFat6 { get; set; }
        public double? ValFat7 { get; set; }
        public double? ValFat8 { get; set; }
        public double Average { get; set; }
        public bool IsAvgRecalc { get; set; }
        public bool IsOutlierDetect { get; set; }
        public string Comment { get; set; }
        public bool IsValid { get; set; }
        public string JustVal { get; set; }
        public double? AvgChosenVal { get; set; }
        public double? StdDev { get; set; }

        public AnalysisFatmeter AnalysisBaseFatmeter { get; set; }
        public FatmeterMeasure FatmeterMeasure { get; set; }
    }
}
