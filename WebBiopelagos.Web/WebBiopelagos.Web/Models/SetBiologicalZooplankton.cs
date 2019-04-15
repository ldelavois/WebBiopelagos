using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetBiologicalZooplankton
    {
        public SetBiologicalZooplankton()
        {
            ZooplanktonDepthSpecimen = new HashSet<ZooplanktonDepthSpecimen>();
        }

        public int SetZooplanktonId { get; set; }
        public int SetBaseId { get; set; }
        public short DepthMinM { get; set; }
        public short DepthMaxM { get; set; }
        public int DepthNo { get; set; }
        public double? VolumeFilteredM3 { get; set; }
        public string Comment { get; set; }
        public int? TmpId { get; set; }

        public SetBase SetBase { get; set; }
        public ICollection<ZooplanktonDepthSpecimen> ZooplanktonDepthSpecimen { get; set; }
    }
}
