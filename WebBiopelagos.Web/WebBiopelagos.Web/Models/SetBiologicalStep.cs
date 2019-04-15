using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetBiologicalStep
    {
        public int SetBaseId { get; set; }
        public byte StepNo { get; set; }
        public DateTime? SetStartStepUtcDt { get; set; }
        public string SetStartStepLat { get; set; }
        public string SetStartStepLon { get; set; }
        public DateTime? SetEndStepUtcDt { get; set; }
        public string SetEndStepLat { get; set; }
        public string SetEndStepLon { get; set; }
        public TimeSpan? SetStepDuration { get; set; }
        public DateTime? HaulStartStepUtcDt { get; set; }
        public string HaulStartStepLat { get; set; }
        public string HaulStartStepLon { get; set; }
        public DateTime? HaulEndStepUtcDt { get; set; }
        public string HaulEndStepLat { get; set; }
        public string HaulEndStepLon { get; set; }
        public TimeSpan? HaulStepDuration { get; set; }
        public TimeSpan? TrawlStepDuration { get; set; }
        public short? TargetDepthStepM { get; set; }
        public double? ObservedDepthStepM { get; set; }
        public double? ObservedDepthStepMinM { get; set; }
        public double? ObservedDepthStepMaxM { get; set; }
        public double? VerticalMouthOpeningStepObservedM { get; set; }
        public double? HorizontalMouthOpeningStepObservedM { get; set; }
        public double? SurfaceMouthOpeningStepObservedM2 { get; set; }
        public double? VolumeFilteredStepObservedM3 { get; set; }
        public short? CableLengthStepM { get; set; }
        public byte? SourceVolumeStepFilteredId { get; set; }

        public SetBase SetBase { get; set; }
        public SourceVolumeFiltered SourceVolumeStepFiltered { get; set; }
    }
}
