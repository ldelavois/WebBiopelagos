using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SetBiological
    {
        public int SetBaseId { get; set; }
        public string StationNo { get; set; }
        public string BioSetNo { get; set; }
        public double? TimeZone { get; set; }
        public string DayNightId { get; set; }
        public DateTime? CodendWaterTimeUtc { get; set; }
        public DateTime? CodendDeckTimeUtc { get; set; }
        public string DetectionDepthM { get; set; }
        public short? BottomDepthM { get; set; }
        public double? Speed { get; set; }
        public short? Direction { get; set; }
        public string TowMethodId { get; set; }
        public double? FlowmeterRevolution { get; set; }
        public string FlowmeterNo { get; set; }
        public double? FlowmeterCalibration { get; set; }
        public double? VerticalMouthOpeningSetObservedM { get; set; }
        public double? HorizontalMouthOpeningSetObservedM { get; set; }
        public double? SurfaceMouthOpeningSetObservedM2 { get; set; }
        public double? VolumeFilteredSetObservedM3 { get; set; }
        public byte? SourceVolumeSetFilteredId { get; set; }
        public string Catch { get; set; }
        public string CtdCastNb { get; set; }
        public short? BagNb { get; set; }
        public string Composition { get; set; }
        public short? CableLengthMOld { get; set; }
        public double? SurfaceMouthOpeningObsM2Old { get; set; }
        public double? VolumeFilteredObsM3Old { get; set; }
        public double? HorizontalMouthOpeningObsMOld { get; set; }
        public double? VerticalMouthOpeningObsMOld { get; set; }
        public TimeSpan? TrawlTotalDuration { get; set; }
        public string GearBrandOld { get; set; }
        public string GearOwnerOld { get; set; }
        public string MeshRangeOld { get; set; }
        public double? CodendMeshOld { get; set; }
        public short? NetNbOld { get; set; }
        public double? OverallLengthOld { get; set; }
        public string OpeningClosingSystOld { get; set; }
        public DateTime? NetWaterDateUtcOld { get; set; }
        public DateTime? NetDeckDateUtcOld { get; set; }
        public DateTime? NetWaterDateLocalOld { get; set; }
        public DateTime? NetDeckDateLocalOld { get; set; }
        public short? ScanmarDepthOld { get; set; }
        public string DepthRangeOld { get; set; }
        public string TrawlDurationOld { get; set; }
        public string HaulDurationOld { get; set; }
        public string SetEndTimeUtcOld { get; set; }
        public string SetEndLatOld { get; set; }
        public string SetEndLonOld { get; set; }
        public string HaulStartTimeUtcOld { get; set; }
        public string HaulStartLatOld { get; set; }
        public string HaulStartLonOld { get; set; }
        public string HaulEndTimeUtcOld { get; set; }
        public string HaulEndLatOld { get; set; }
        public string HaulEndLonOld { get; set; }
        public short? TargetDepthMOld { get; set; }
        public double? ObservedDepthAvgOld { get; set; }
        public short? ObservedDepthMinOld { get; set; }
        public string ObservedDepthMaxOld { get; set; }
        public string SetDurationOld { get; set; }
        public string TotalDurationOld { get; set; }

        public DayNight DayNight { get; set; }
        public SetBase SetBase { get; set; }
        public TowMethod TowMethod { get; set; }
    }
}
