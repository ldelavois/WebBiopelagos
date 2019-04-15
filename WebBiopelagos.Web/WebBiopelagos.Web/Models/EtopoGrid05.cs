using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class EtopoGrid05
    {
        public int EtopoGrid05Id { get; set; }
        public int? ShpId { get; set; }
        public double? Xmin { get; set; }
        public double? Xmax { get; set; }
        public double? Ymin { get; set; }
        public double? Ymax { get; set; }
        public decimal XCenter { get; set; }
        public decimal YCenter { get; set; }
        public decimal? BathyMeters { get; set; }
    }
}
