using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    public class Payment
    {
        public int PkPayment { get; set; }
        public int Portion { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PkTicket { get; set; }
        public virtual Ticket Ticket { get; set; }
        
        //Relacionamento TER Muitos (FormPayment)
        public virtual ICollection<FormPayment> FormPayments { get; set; }



    ////Pagamentos
    //[Table("Payment")]
    //public class Payment
    //{
    //    //id do pagamento
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    [Column("PkPayment")]
    //    public int PkPayment { get; set; }

    //    //numero de parcelas
    //    [Column("Portion")]
    //    [Required]
    //    public int Portion { get; set; }

    //    //data da compra
    //    [Column("PurchaseDate")]
    //    [Required]
    //    public DateTime PurchaseDate { get; set; }


    //    [Column("PkTicketFk")]
    //    [Required]
    //    public int PkTicket { get; set; }


    //    [ForeignKey("PkTicket")]
    //    public virtual Ticket Ticket { get; set; }

    //    //Relacionamento TER Muitos (FormPayment)
    //    public virtual ICollection<FormPayment> FormPayments { get; set; }
    }
}
