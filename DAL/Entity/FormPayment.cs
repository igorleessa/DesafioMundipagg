using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    public class FormPayment
    {
        public int PkFormPayment { get; set; }
        public int Plots { get; set; }
        public decimal ValuePlots { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int PkPayment { get; set; }

        public virtual Payment Payments { get; set; }


        ////tabela de forma de pagamento
        //[Table("FormPayment")]
        //public class FormPayment
        //{
        //    //id forma de pagamento
        //    [Key]
        //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //    [Column("PkFormPayment")]
        //    public int PkFormPayment { get; set; }

        //    //Parcelas
        //    [Column("Plots")]
        //    [Required]
        //    public int Plots { get; set; }

        //    //Valor da Parcela
        //    [Column("ValuePlots")]
        //    [Required]
        //    public decimal ValuePlots { get; set; }

        //    /* [Column("ExpirationDate")]
        //     [Required]
        //     public DateTime ExpirationDate { get; set; }*/

        //    [Column("PkPaymentFk")]
        //    [Required]
        //    public int PkPayment { get; set; }

        //    //Relacionamento TER 1 (Payemt)
        //    [ForeignKey("PkPayment")]
        //    public virtual Payment Payments { get; set; }

    }
}
