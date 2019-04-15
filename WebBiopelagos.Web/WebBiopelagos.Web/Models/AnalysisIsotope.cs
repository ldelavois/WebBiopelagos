using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisIsotope
    {
        public int AnalysisBaseId { get; set; }
        public string Instrumentation { get; set; }
        public string LabIdNo { get; set; }
        public string Project { get; set; }
        public bool IsLipidExtracted { get; set; }
        public DateTime? LeDate { get; set; }
        public DateTime? SiaDate { get; set; }
        public double? D15N { get; set; }
        public double? PercentN { get; set; }
        public double? D13C { get; set; }
        public double? PercentC { get; set; }
        public double? Cn { get; set; }
        public double? D34S { get; set; }
        public double? D199Hg { get; set; }
        public double? D200Hg { get; set; }
        public double? D201Hg { get; set; }
        public double? D202Hg { get; set; }
        public double? D204Hg { get; set; }
        public double? D199hg1 { get; set; }
        public double? D200hg1 { get; set; }
        public double? D201hg1 { get; set; }
        public double? D204hg1 { get; set; }
        public double? D13CCsia { get; set; }
        public decimal? DwValue { get; set; }
        public string DwUnit { get; set; }
        public decimal? WwValue { get; set; }
        public string WwUnit { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
    }
}
