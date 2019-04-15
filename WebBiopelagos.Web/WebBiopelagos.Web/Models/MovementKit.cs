using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class MovementKit
    {
        public int MovementKitId { get; set; }
        public byte KitTypeId { get; set; }
        public byte StockTypeId { get; set; }
        public DateTime MovementDate { get; set; }
        public short Quantity { get; set; }
        public short FromLocationId { get; set; }
        public short? ToLocationId { get; set; }
        public short FromStaffId { get; set; }
        public short ToStaffId { get; set; }
        public string TransportedBy { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatorName { get; set; }

        public RefKitType KitType { get; set; }
        public Location ToLocation { get; set; }
        public Staff ToStaff { get; set; }
    }
}
