using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Contract
    {
        public Contract()
        {
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
        }

        public short ContractId { get; set; }
        public string ContractName { get; set; }
        public short EntityLocationId { get; set; }
        public short ContactStaffId { get; set; }
        public short OwnershipLocationId { get; set; }
        public DateTime SignatureFinalDate { get; set; }
        public short? SamplesNb { get; set; }
        public DateTime? FreightLastFinal { get; set; }
        public DateTime? EstimatedFeedbackDate { get; set; }
        public string ScanPath { get; set; }
        public string ScanName { get; set; }
        public string PrepPath { get; set; }
        public string PrepName { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }

        public Staff ContactStaff { get; set; }
        public Location EntityLocation { get; set; }
        public Location OwnershipLocation { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
    }
}
