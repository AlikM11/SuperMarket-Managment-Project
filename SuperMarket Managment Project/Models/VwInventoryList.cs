using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class VwInventoryList
    {
        public string Pcode { get; set; }
        public string Barcode { get; set; }
        public string Pdesc { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int? Qty { get; set; }
        public int? Reorder { get; set; }
    }
}
