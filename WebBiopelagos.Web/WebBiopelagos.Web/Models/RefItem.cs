using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class RefItem
    {
        public RefItem()
        {
            KitItem = new HashSet<KitItem>();
            Movement = new HashSet<Movement>();
            PurchaseItem = new HashSet<PurchaseItem>();
        }

        public short ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }

        public ICollection<KitItem> KitItem { get; set; }
        public ICollection<Movement> Movement { get; set; }
        public ICollection<PurchaseItem> PurchaseItem { get; set; }
    }
}
