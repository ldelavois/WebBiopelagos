using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FreezerLocation
    {
        public FreezerLocation()
        {
            SampleBase = new HashSet<SampleBase>();
            SampleUnknown = new HashSet<SampleUnknown>();
        }

        public byte FreezerLocationId { get; set; }
        public string FreezerLocationName { get; set; }
        public string FreezerLocationDesc { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public short InventoryLocationId { get; set; }
        public string InventoryLocationIdOld { get; set; }

        public Location InventoryLocation { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
    }
}
