using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbSupplier
    {
        public TbSupplier()
        {
            TbStockIns = new HashSet<TbStockIn>();
        }

        public int Id { get; set; }
        public string Supplier { get; set; }
        public string Address { get; set; }
        public string Contactperson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<TbStockIn> TbStockIns { get; set; }
    }
}
