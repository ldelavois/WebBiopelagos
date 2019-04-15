using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Staff
    {
        public Staff()
        {
            AnalysisBaseAnalyserStaff = new HashSet<AnalysisBase>();
            AnalysisBaseAnalyserStaffId2Navigation = new HashSet<AnalysisBase>();
            AnalysisBaseAnalyserStaffId3Navigation = new HashSet<AnalysisBase>();
            Contract = new HashSet<Contract>();
            DebriefingDebrieferStaff = new HashSet<Debriefing>();
            DebriefingDebrieferStaffId2Navigation = new HashSet<Debriefing>();
            DebriefingSamplerStaff = new HashSet<Debriefing>();
            FishEditorStaff = new HashSet<Fish>();
            FishEditorStaffId2Navigation = new HashSet<Fish>();
            MovementFromStaff = new HashSet<Movement>();
            MovementKit = new HashSet<MovementKit>();
            MovementToStaff = new HashSet<Movement>();
            SampleBase = new HashSet<SampleBase>();
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
            SampleUnknown = new HashSet<SampleUnknown>();
            SetBase = new HashSet<SetBase>();
            TrainingStaff = new HashSet<TrainingStaff>();
            TrainingTrainerStaff = new HashSet<Training>();
            TrainingTrainerStaffId2Navigation = new HashSet<Training>();
            TrainingTrainerStaffId3Navigation = new HashSet<Training>();
            TripSamplerStaff = new HashSet<Trip>();
            TripSamplerStaffId2Navigation = new HashSet<Trip>();
            TripSamplerStaffId3Navigation = new HashSet<Trip>();
        }

        public short StaffId { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Position { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? FinishingDate { get; set; }
        public string TubsCode { get; set; }
        public string CountryId { get; set; }
        public bool IsTrainer { get; set; }
        public bool IsTrainee { get; set; }
        public bool IsDebriefer { get; set; }
        public bool IsSampler { get; set; }
        public bool IsDataEditor { get; set; }
        public bool IsAnalyser { get; set; }
        public bool IsStockSupervisor { get; set; }
        public bool IsInventoryOfficer { get; set; }
        public bool IsContact { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatorName { get; set; }
        public bool? IsStillActive { get; set; }
        public int? TmpId { get; set; }

        public Country Country { get; set; }
        public ICollection<AnalysisBase> AnalysisBaseAnalyserStaff { get; set; }
        public ICollection<AnalysisBase> AnalysisBaseAnalyserStaffId2Navigation { get; set; }
        public ICollection<AnalysisBase> AnalysisBaseAnalyserStaffId3Navigation { get; set; }
        public ICollection<Contract> Contract { get; set; }
        public ICollection<Debriefing> DebriefingDebrieferStaff { get; set; }
        public ICollection<Debriefing> DebriefingDebrieferStaffId2Navigation { get; set; }
        public ICollection<Debriefing> DebriefingSamplerStaff { get; set; }
        public ICollection<Fish> FishEditorStaff { get; set; }
        public ICollection<Fish> FishEditorStaffId2Navigation { get; set; }
        public ICollection<Movement> MovementFromStaff { get; set; }
        public ICollection<MovementKit> MovementKit { get; set; }
        public ICollection<Movement> MovementToStaff { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
        public ICollection<SetBase> SetBase { get; set; }
        public ICollection<TrainingStaff> TrainingStaff { get; set; }
        public ICollection<Training> TrainingTrainerStaff { get; set; }
        public ICollection<Training> TrainingTrainerStaffId2Navigation { get; set; }
        public ICollection<Training> TrainingTrainerStaffId3Navigation { get; set; }
        public ICollection<Trip> TripSamplerStaff { get; set; }
        public ICollection<Trip> TripSamplerStaffId2Navigation { get; set; }
        public ICollection<Trip> TripSamplerStaffId3Navigation { get; set; }
    }
}
