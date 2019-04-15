using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SpeciesLenwt
    {
        public string SpId { get; set; }
        public string Main { get; set; }
        public decimal? LenwtA { get; set; }
        public decimal? LenwtB { get; set; }
        public decimal? N { get; set; }
        public decimal? RSq { get; set; }
        public string SexId { get; set; }
        public string LenId { get; set; }
        public string Comments { get; set; }
        public string Source { get; set; }
        public string SubSpId { get; set; }
    }
}
