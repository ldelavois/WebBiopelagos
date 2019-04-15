using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisAging
    {
        public AnalysisAging()
        {
            AnalysisAgingAnnualZone = new HashSet<AnalysisAgingAnnualZone>();
        }

        public int AnalysisBaseId { get; set; }
        public decimal? WeightGr { get; set; }
        public string WeightStorageQualityId { get; set; }
        public string LengthMm { get; set; }
        public decimal? WidthMm { get; set; }
        public decimal? DepthMm { get; set; }
        public string RadiusMm { get; set; }
        public string OtolithSectionTypeId { get; set; }
        public string SideId { get; set; }
        public double? SectionThicknessMm { get; set; }
        public short? DailyIncrements { get; set; }
        public short? AnnualFinalZoneCnt { get; set; }
        public decimal? AnnualIncrements { get; set; }
        public decimal? Meas365Mm { get; set; }
        public decimal? Meas730Mm { get; set; }
        public decimal? MeasEdgeMm { get; set; }
        public string ReadibilityQualityId { get; set; }
        public string OtolithMarginTypeId { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
        public OtolithMarginType OtolithMarginType { get; set; }
        public OtolithSectionType OtolithSectionType { get; set; }
        public Quality ReadibilityQuality { get; set; }
        public Side Side { get; set; }
        public ICollection<AnalysisAgingAnnualZone> AnalysisAgingAnnualZone { get; set; }
    }
}
