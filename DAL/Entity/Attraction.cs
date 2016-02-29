using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    public class Attraction
    {
        public int PkAttraction { get; set; }
        public string AttractionName { get; set; }
        public string AttractionDate { get; set; }
        public string AttractionDescription { get; set; }
        public string AttractionAddress { get; set; }
        public string AttractionImage { get; set; }

        //Relacionamento TER Muitos (Tickets)
        public virtual List<Ticket> Ticket { get; set; }


    //[Table("Attraction")]
    //public class Attraction
    //{
    //    //Chave do Evento
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    [Column("PkAttraction")]
    //    public int PkAttraction { get; set; }

    //    //Nome do Evento
    //    [Column("AttractionName")]
    //    [StringLength(50)]
    //    [Required]
    //    [Index("IdxAttractionName", IsUnique = true)]
    //    public string AttractionName { get; set; }

    //    //Data do evento
    //    [Column("AttractionDate")]
    //    [StringLength(30)]
    //    [Required]
    //    public string AttractionDate { get; set; }


    //    //Descrição do evento
    //    [Column("AttractionDescription")]
    //    [StringLength(4000)]
    //    [Required]
    //    public string AttractionDescription { get; set; }

    //    //Endereço
    //    [Column("AttractionAddress")]
    //    [StringLength(4000)]
    //    [Required]
    //    public string AttractionAddress { get; set; }


    //    //Caminho da imagem do evento
    //    [Column("AttractionImage")]
    //    [StringLength(4000)]
    //    [Required]
    //    public string AttractionImage { get; set; }

    //    //preço do ingresso
    //    [Column("TicketPrice")]
    //    [Required]
    //    public decimal TicketPrice { get; set; }

    //    //quantidade de tickets
    //    [Column("QuantityTicket")]
    //    [Required]
    //    public int QuanityTicket { get; set; }

    //    //Relacionamento TER Muitos (Tickets)
    //    public virtual List<Ticket> Ticket { get; set; }
    }
}
