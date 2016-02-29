using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    public class Purchase
    {
        public int PkPurchase { get; set; }
        public int PkUser { get; set; }
        public int PkTicket { get; set; }
        public int QuantityPurchase { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual SystemUser SystemUsers { get; set; }
        public virtual Ticket Tickets { get; set; }
    }
}
