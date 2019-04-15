using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class PurchaseItem
    {
        public int PurchaseItemId { get; set; }
        public short ItemId { get; set; }
        public short ToLocationId { get; set; }
        public DateTime CreationDate { get; set; }

        public RefItem Item { get; set; }
        public Location ToLocation { get; set; }
    }
}
