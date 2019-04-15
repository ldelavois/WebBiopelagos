using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FishPreyItemLink
    {
        public int FishId { get; set; }
        public int AnalysisStomachPreyItemId { get; set; }

        public AnalysisStomachPreyItem AnalysisStomachPreyItem { get; set; }
        public Fish Fish { get; set; }
    }
}
