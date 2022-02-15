using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbProduct
    {
        public TbProduct()
        {
            TbCarts = new HashSet<TbCart>();
            TbStockIns = new HashSet<TbStockIn>();
        }

        public string Pcode { get; set; }
        public string Barcode { get; set; }
        public string Pdesc { get; set; }
        public int Bid { get; set; }
        public int Cid { get; set; }
        public decimal Price { get; set; }
        public int? Qty { get; set; }
        public int? Reorder { get; set; }

        public virtual TbBrand BidNavigation { get; set; }
        public virtual ICollection<TbCart> TbCarts { get; set; }
        public virtual ICollection<TbStockIn> TbStockIns { get; set; }
    }
}
