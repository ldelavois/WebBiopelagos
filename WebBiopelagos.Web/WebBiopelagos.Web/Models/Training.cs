using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Training
    {
        public Training()
        {
            TrainingStaff = new HashSet<TrainingStaff>();
        }

        public int TrainingId { get; set; }
        public short TrainingTypeId { get; set; }
        public DateTime TrainingDate { get; set; }
        public string TrainingLocation { get; set; }
        public short TrainerStaffId { get; set; }
        public short? TrainerStaffId2 { get; set; }
        public short? TrainerStaffId3 { get; set; }
        public string Comment { get; set; }

        public Staff TrainerStaff { get; set; }
        public Staff TrainerStaffId2Navigation { get; set; }
        public Staff TrainerStaffId3Navigation { get; set; }
        public TrainingType TrainingType { get; set; }
        public ICollection<TrainingStaff> TrainingStaff { get; set; }
    }
}
