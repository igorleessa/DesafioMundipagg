using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    public class SystemUser
    {
        public int PkUser { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserCpf { get; set; }
        public string UserBirth { get; set; }
        public string UserGender { get; set; }
        public string AddressCep { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNumber { get; set; }
        public string AddressComplement { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressDistrict { get; set; }
        
        public virtual List<Purchase> Purchases { get; set; }

    ////table System user
    //[Table("SystemUser")]
    //public class SystemUser
    //{
    //    //Id Usuario
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    [Column("PkUser")]
    //    public int PkUser { get; set; }

    //    //Usuario de login
    //    [Column("UserLogin")]
    //    [StringLength(20)]
    //    [Required]
    //    [Index("IdxUserLogin", IsUnique = true)]
    //    public string UserLogin { get; set; }

    //    //Senhad de Login
    //    [Column("UserPassword")]
    //    [StringLength(50)]
    //    [Required]
    //    public string UserPassword { get; set; }

    //    //Nome do Usuario
    //    [Column("UserName")]
    //    [StringLength(15)]
    //    [Required]
    //    public string UserName { get; set; }

    //    //Cpf
    //    [Column("UserCpf")]
    //    [StringLength(50)]
    //    [Required]
    //    [Index("IdxUserCpf", IsUnique = true)]
    //    public string UserCpf { get; set; }

    //    //Data de nascimento
    //    [Column("UserBirth")]
    //    [Required]
    //    public DateTime UserBirth { get; set; }

    //    //sexo
    //    [Column("UserGender")]
    //    [StringLength(15)]
    //    [Required]
    //    public string UserGender { get; set; }

    //    //cep
    //    [Column("AddressCep")]
    //    [StringLength(20)]
    //    [Required]
    //    public string AddressCep { get; set; }

    //    //Rua
    //    [Column("AddressStreet")]
    //    [StringLength(50)]
    //    [Required]
    //    public string AddressStreet { get; set; }

    //    //Numero casa
    //    [Column("AddressNumber")]
    //    [StringLength(15)]
    //    [Required]
    //    public string AddressNumber { get; set; }

    //    //Complemento
    //    [Column("AddressComplement")]
    //    [StringLength(50)]
    //    [Required]
    //    public string AddressComplement { get; set; }

    //    //Cidade
    //    [Column("AddressCity")]
    //    [StringLength(50)]
    //    [Required]
    //    public string AddressCity { get; set; }

    //    //Estado
    //    [Column("AddressState")]
    //    [StringLength(50)]
    //    [Required]
    //    public string AddressState { get; set; }

    //    //Bairro
    //    [Column("AddressDistrict")]
    //    [StringLength(50)]
    //    [Required]
    //    public string AddressDistrict { get; set; }

    //    //InstantBuyKey do cartão
    //    [Column("InstantBuyKey")]
    //    [StringLength(50)]
    //    [Required]
    //    public string InstantBuyKey { get; set; }


    //    public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
