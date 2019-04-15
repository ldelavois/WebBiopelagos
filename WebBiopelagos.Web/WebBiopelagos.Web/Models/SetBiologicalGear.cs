using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetBiologicalGear
    {
        public SetBiologicalGear()
        {
            SetBiologicalGearLink = new HashSet<SetBiologicalGearLink>();
        }

        public int SetBiologicalGearId { get; set; }
        public string GearName { get; set; }
        public string GearId { get; set; }
        public byte TargetGroupId { get; set; }
        public string GearBrand { get; set; }
        public string GearOwner { get; set; }
        public string MeshRange { get; set; }
        public double? CodendMesh { get; set; }
        public byte? CodendTypeId { get; set; }
        public byte? NetNb { get; set; }
        public double? OverallLengthM { get; set; }
        public bool IsOpenClose { get; set; }
        public double? HorizontalMouthOpeningTheory { get; set; }
        public double? VerticalMouthOpeningTheory { get; set; }
        public double? SurfaceMouthOpeningTheoryM2 { get; set; }
        public string ReferenceDoc { get; set; }
        public string PhotoLnk { get; set; }
        public string Comment { get; set; }

        public CodendType CodendType { get; set; }
        public TargetGroup TargetGroup { get; set; }
        public ICollection<SetBiologicalGearLink> SetBiologicalGearLink { get; set; }
    }
}
