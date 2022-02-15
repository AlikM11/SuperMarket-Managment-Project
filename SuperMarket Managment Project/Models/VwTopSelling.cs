using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class VwTopSelling
    {
        public string Pcode { get; set; }
        public string Pdesc { get; set; }
        public int? Qty { get; set; }
        public DateTime? Sdate { get; set; }
        public decimal? Total { get; set; }
        public string Status { get; set; }
    }
}
