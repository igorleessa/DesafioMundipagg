using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{

    public class Ticket
    {
        public int PkTicket { get; set; }
        public int PkAttraction { get; set; }
        public decimal TicketPrice { get; set; }
        public int QuantityTicket { get; set; }

        public virtual Attraction Attractions { get; set; }


        ////table Ticket
        //[Table("Ticket")]
        //public class Ticket
        //{
        //    //Id do ingresso
        //    [Key]
        //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //    [Column("PkTicket")]
        //    public int PkTicket { get; set; }


        //    [Column("PkUserFk")]
        //    [Required]
        //    public int PkUser { get; set; }

        //    //Relacionamento TER 1 (SystemUser)
        //    [ForeignKey("PkUser")]
        //    public virtual SystemUser SystemUser { get; set; }

        //    [Column("PkAttractionFk")]
        //    [Required]
        //    public int PkAttraction { get; set; }

        //    //Relacionamento TER 1 (Attraction)
        //    [ForeignKey("PkAttraction")]
        //    public virtual Attraction Attractions { get; set; }

    }

}