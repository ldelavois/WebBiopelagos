using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TrainingStaff
    {
        public TrainingStaff()
        {
            TrainingStaffCourse = new HashSet<TrainingStaffCourse>();
        }

        public int TrainingStaffId { get; set; }
        public int TrainingId { get; set; }
        public short StaffId { get; set; }
        public string CertificateNo { get; set; }
        public double? OverallResult { get; set; }
        public string Comment { get; set; }

        public Staff Staff { get; set; }
        public Training Training { get; set; }
        public ICollection<TrainingStaffCourse> TrainingStaffCourse { get; set; }
    }
}
