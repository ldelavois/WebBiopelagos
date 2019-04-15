using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ZooplanktonDepthSpecimen
    {
        public int SetZooplanktonId { get; set; }
        public int FishId { get; set; }
        public string Comment { get; set; }

        public Fish Fish { get; set; }
        public SetBiologicalZooplankton SetZooplankton { get; set; }
    }
}
