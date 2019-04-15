using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Location
    {
        public Location()
        {
            AnalysisBase = new HashSet<AnalysisBase>();
            ContractEntityLocation = new HashSet<Contract>();
            ContractOwnershipLocation = new HashSet<Contract>();
            FreezerLocation = new HashSet<FreezerLocation>();
            MovementFromLocation = new HashSet<Movement>();
            MovementKit = new HashSet<MovementKit>();
            MovementToLocation = new HashSet<Movement>();
            PurchaseItem = new HashSet<PurchaseItem>();
            SampleBaseInventoryLocation = new HashSet<SampleBase>();
            SampleBaseOwnershipLocation = new HashSet<SampleBase>();
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
            SampleUnknownInventoryLocation = new HashSet<SampleUnknown>();
            SampleUnknownOwnershipLocation = new HashSet<SampleUnknown>();
            SamplingFreightArrivalLocation = new HashSet<SamplingFreight>();
            SamplingFreightDepartureLocation = new HashSet<SamplingFreight>();
        }

        public short LocationId { get; set; }
        public string LocationName { get; set; }
        public string NormalizedName { get; set; }
        public string CountryId { get; set; }
        public short? ContactStaffId { get; set; }
        public string LocationAddress { get; set; }
        public bool IsStorageInventory { get; set; }
        public bool IsLaboratory { get; set; }
        public bool IsStockManager { get; set; }
        public bool IsSampleOwner { get; set; }
        public string LocationContactOld { get; set; }
        public int? TmpId { get; set; }

        public Country Country { get; set; }
        public ICollection<AnalysisBase> AnalysisBase { get; set; }
        public ICollection<Contract> ContractEntityLocation { get; set; }
        public ICollection<Contract> ContractOwnershipLocation { get; set; }
        public ICollection<FreezerLocation> FreezerLocation { get; set; }
        public ICollection<Movement> MovementFromLocation { get; set; }
        public ICollection<MovementKit> MovementKit { get; set; }
        public ICollection<Movement> MovementToLocation { get; set; }
        public ICollection<PurchaseItem> PurchaseItem { get; set; }
        public ICollection<SampleBase> SampleBaseInventoryLocation { get; set; }
        public ICollection<SampleBase> SampleBaseOwnershipLocation { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
        public ICollection<SampleUnknown> SampleUnknownInventoryLocation { get; set; }
        public ICollection<SampleUnknown> SampleUnknownOwnershipLocation { get; set; }
        public ICollection<SamplingFreight> SamplingFreightArrivalLocation { get; set; }
        public ICollection<SamplingFreight> SamplingFreightDepartureLocation { get; set; }
    }
}
