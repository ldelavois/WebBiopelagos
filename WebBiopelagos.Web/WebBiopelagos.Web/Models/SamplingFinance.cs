using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SamplingFinance
    {
        public int SamplingFinanceId { get; set; }
        public int SamplingId { get; set; }
        public bool? IsPaymentNeeded { get; set; }
        public bool IsPaymentDone { get; set; }
        public short? PaymentAmount { get; set; }
        public string Currency { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? ManagementEntityId { get; set; }
        public string PayslipPath { get; set; }
        public string PayslipName { get; set; }
        public string Comment { get; set; }
        public DateTime? CreationDate { get; set; }

        public ManagementEntity ManagementEntity { get; set; }
        public Sampling Sampling { get; set; }
    }
}
