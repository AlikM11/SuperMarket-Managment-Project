using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbAdjustment
    {
        public int Id { get; set; }
        public string Referenceno { get; set; }
        public string Pcode { get; set; }
        public int? Qty { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
        public DateTime? Sdate { get; set; }
        public string User { get; set; }
    }
}
