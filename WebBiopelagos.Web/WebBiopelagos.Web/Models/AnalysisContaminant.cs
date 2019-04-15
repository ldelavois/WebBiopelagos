using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisContaminant
    {
        public int AnalysisBaseId { get; set; }
        public string Instrumentation { get; set; }
        public string LabIdNo { get; set; }
        public string Project { get; set; }
        public decimal? SampleWeightGr { get; set; }
        public string ContaminantWeightId { get; set; }
        public string ContaminantId { get; set; }
        public decimal? DwValue { get; set; }
        public string DwUnit { get; set; }
        public decimal? WwValue { get; set; }
        public string WwUnit { get; set; }
        public decimal? Rsd { get; set; }
        public string ComparedContaminantId { get; set; }
        public byte? ComparedPercent { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
        public Contaminant ComparedContaminant { get; set; }
        public Contaminant Contaminant { get; set; }
        public ContaminantWeight ContaminantWeight { get; set; }
    }
}
