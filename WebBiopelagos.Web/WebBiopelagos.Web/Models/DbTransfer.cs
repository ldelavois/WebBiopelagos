using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class DbTransfer
    {
        public int DbTransferId { get; set; }
        public int TransferBlockId { get; set; }
        public int SampleBaseId { get; set; }
        public DateTime DateTransfer { get; set; }
        public string UserName { get; set; }
        public byte TypeTransfer { get; set; }
        public short? FromLocationId { get; set; }
        public short? ToLocationId { get; set; }
        public byte? FromFreezerId { get; set; }
        public byte? ToFreezerId { get; set; }
        public string FromConditionId { get; set; }
        public string ToConditionId { get; set; }
        public string FromStorageQualityId { get; set; }
        public string ToStorageQualityId { get; set; }
        public short? ContractId { get; set; }
        public string LocationDetails { get; set; }
        public DateTime LocationDate { get; set; }
        public DateTime? InventoryDate { get; set; }
        public string VolumeSamplingFreightId { get; set; }
        public short? ContactStaffId { get; set; }
        public string AnalysisTypeId { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public bool IsDbUpdated { get; set; }
        public bool IsExcelUpdated { get; set; }
        public string FromIdOld { get; set; }
        public string ToIdOld { get; set; }
        public byte? FreezerLocationIdOld { get; set; }
        public byte? LaboratoryLocationIdOld { get; set; }
        public string ContactNameOld { get; set; }
        public DateTime? GivenDateOld { get; set; }

        public SampleBase SampleBase { get; set; }
    }
}
