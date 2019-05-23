using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisQuantity
    {

        [Display(Name = "ID Analyse Base")]
        public int AnalysisBaseId { get; set; }

        [Display(Name = "Valeur")]
        public double QuantityValue { get; set; }

        [Display(Name = "Unité")]
        public string QuantityUnit { get; set; }
        public string Comment { get; set; }

        [Display(Name = "Sous-type")]
        public string SubAnalysisType { get; set; }

        [Display(Name = "Type")]
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
        public AnalysisType AnalysisType { get; set; }
    }
}
