using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisSizeStructure
    {
        public int AnalysisBaseId { get; set; }
        public double Esd { get; set; }
        public double SizeStructureValue { get; set; }
        public string SizeStructureUnit { get; set; }
        public string Comment { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
    }
}
