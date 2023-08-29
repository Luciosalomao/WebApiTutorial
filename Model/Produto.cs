using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiTutorial.Model.Base;

namespace WebApiTutorial.Model
{
    [Table("TbProdutos")]
    public class Produto : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("preco")]
        [Required]
        public decimal Preco { get; set; }

        [Column("descricao")]
        [StringLength(200)]
        public string Descricao { get; set; }

    }
}
